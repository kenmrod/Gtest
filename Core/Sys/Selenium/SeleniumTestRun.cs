using OpenQA.Selenium.Remote;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Sys.Selenium
{
    public abstract class SeleniumTestRun : ITestRun
    {
        private const string HEADER = "==================================================";
        private const string SUBHEADER = "--------------------------------------------------";
        private const string TEST_RUN = "TestRun\t\t: ";
        private const string BATCH = "Batch\t\t: ";
        private const string TEST_PASSED = "Passed\t\t: ";
        private const string TEST_FAILED = "Failed\t\t: ";
        private const string TEST_TOTAL = "Total\t\t: ";
        private const string ELAPSED = "Elapsed\t\t: ";

        private const int LOAD_BALANCE_INSTANCE = 4;
        private const int DEFAULT_MAX_CAPACITY = 4;
        private const int DEFAULT_PORT = 4444;

        private Dictionary<int, ITestScript> mTestManiFest = new Dictionary<int, ITestScript>();
        private List<string> ResultLogs = new List<string>();
        private List<TestScriptWithArgs> TestScripts;
        private SeleniumDriver Driver;
        private object[] DefaultArgs = null;
        protected SeleniumDriver.Browser TargetBrowser;



        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Elapsed { get; set; }
        public int Test_Total { get; set; }
        public int Test_Passed { get; set; }
        public int Test_Failed { get; set; }
        public int Test_CurrentRunNumber { get; set; }
        public string Environment { get; set; }
        public string Port { get; set; }
        public int Capacity { get; set; }

        public string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }

        public int PassRate
        {
            get
            {
                if (Test_Total > 0)
                {
                    decimal passed = Test_Passed;
                    decimal total = Test_Total;
                    return decimal.ToInt32((passed / total) * 100);
                }
                else
                {
                    return 0;
                }
            }
        }

        public Dictionary<int, ITestScript> TestManifest
        {
            get
            {
                return mTestManiFest;
            }
            set
            {
                mTestManiFest = value;
            }
        }


        public Logger SessionLogger { get; set; }

        public SeleniumTestRun(Logger SessionLogs, String OverrideEnvironment = null)
        {
            SessionLogger = SessionLogs;
            Environment = OverrideEnvironment;
            TestScripts = new List<TestScriptWithArgs>();
            //Drivers = new ConcurrentBag<SeleniumDriver>();
            Port = DEFAULT_PORT.ToString();
            Capacity = DEFAULT_MAX_CAPACITY;
        }

        public int Run(string hostname, string port)
        {
            Port = port;
            return Run(hostname);
        }

        public int Run(string hostname)
        {
            SetUp();
            ExecuteTests();
            InvokeScripts(hostname);
            return PassRate;
        } 

        public int Run() 
        {
            SetUp();
            ExecuteTests();
            InvokeScripts();
            TearDown();
            return PassRate;
        }

        public int Run(params object[] Arguments)
        {
            SetUp();
            ExecuteTests(Arguments);
            InvokeScripts();
            TearDown();
            return PassRate;
        }

        public void SetUp()
        {
            StartTime = DateTime.Now;
            SessionLogger.WriteLine("Initializing test run: " + Name + "...", Logger.MessageType.INF, false);
            TestEnvironment.LoadEnvironmentDataToList(this.GetType().Assembly.GetName().Name);
        }

        public bool TestSetup(SeleniumDriver Driver, Uri remoteURI = null)
        {
            bool ret = true;
            try
            {
                Driver.TargetBrowser = TargetBrowser;
                Driver.RemoteURI = remoteURI;
                Driver.StartBrowser(false);
                if(remoteURI == null) this.Driver = Driver;
            }
            catch (Exception e)
            {
                SessionLogger.WriteLine(e.Message, Logger.MessageType.ERR);
                ret = false;
            }
            return ret;
        }

        protected void AddTestScripts(SeleniumTestScript TestScript) =>
            TestScripts.Add(new TestScriptWithArgs
            {
                TestScript = TestScript,
                Args = null
            });

        protected void AddTestScripts(SeleniumTestScript TestScript, params object[] Args) =>
            TestScripts.Add(new TestScriptWithArgs { 
                TestScript = TestScript,
                Args = Args
            });

        protected void SetDefaultArgs(SeleniumDriver.Browser DefaultBrowser, params object[] Args) 
        {
            TargetBrowser = DefaultBrowser;
            DefaultArgs = Args;

        }

        private void InvokeScripts()
        {
            if (DefaultArgs == null) throw new Exception($"{this.GetType().Name} doesn't have Default Args set.");
            var driver = new SeleniumDriver(SessionLogger);
            if(TestSetup(driver))
            {
                foreach (var script in TestScripts)
                {
                    script.TestScript.SetDriver(driver);
                    if (script.Args == null)
                    {
                        object[] args = new object[DefaultArgs.Length + 1];
                        args[0] = TargetBrowser;
                        DefaultArgs.CopyTo(args, 1);
                        script.TestScript.Run(this, args);
                    }
                    else script.TestScript.Run(this, script.Args);
                }
            }
        }

        private void InvokeScripts(string hostName)
        { 
            if (DefaultArgs == null) throw new Exception($"{this.GetType().Name} doesn't have Default Args set.");
                        
            LoadBalancer(hostName);
        }

        private void LoadBalancer(string hostName)
        {
            Uri remoteURI = ConvertStringToUri($"http://{hostName}:{Port}/wd/hub");
            SeleniumGrid.Infologger = (e) => SessionLogger.WriteLine(e, Logger.MessageType.INF);
            SeleniumGrid.Errlogger = (e) => SessionLogger.WriteLine(e, Logger.MessageType.ERR);

            var cap = SeleniumGrid.GetCapacity(hostName);
            var capacity = cap.Capacity > Capacity ? Capacity : cap.Capacity;

            var TestSriptBatches = SplitTestScripts(TestScripts, capacity);

            string testId = Guid.NewGuid().ToString();

            List<Task> tasks = new List<Task>();

            foreach (var tsBatch in TestSriptBatches.Select((tsb, i) => new { index = i, value = tsb, batchId = Guid.NewGuid().ToString()}))
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    try
                    {
                        bool ready = false;

                        var state = SeleniumGrid.GetGridState(hostName, testId, tsBatch.batchId);
                        ready = state.Ready;

                        while (!ready)
                        {
                            SessionLogger.WriteLine($"Grid is busy as of the moment, batch {tsBatch.index + 1} of {capacity} is in queue.");
                            Thread.Sleep(1000);
                            state = SeleniumGrid.GetGridState(hostName, testId, tsBatch.batchId);
                            ready = state.Ready;
                        }
                            
                        var driver = new SeleniumDriver(SessionLogger);
                        try
                        {
                            if (TestSetup(driver, remoteURI))
                            {
                                var sessionId = ((RemoteWebDriver)driver.Instance).SessionId;
                                var testSession = SeleniumGrid.GetTestSession(hostName, sessionId.ToString());
                                LoadBalanceInstance(hostName, state.Data.Id, tsBatch.value, driver, testSession.Hostname);
                            }
                        }
                        catch(Exception e)
                        {
                            TearDown(driver);
                            throw;
                        }

                        TearDown(driver);
                    } 
                    catch(Exception e)
                    {
                        SessionLogger.WriteLine(e.Message, Logger.MessageType.ERR);
                    }
                }));
            }
           
            
            Task.WaitAll(tasks.ToArray());

            EndTime = DateTime.Now;
            Elapsed = EndTime - StartTime;
            string strElapsed = Elapsed.ToString().Substring(0, Elapsed.ToString().LastIndexOf('.'));
            SessionLogger.WriteLine("Terminating test run: " + Name + "...", Logger.MessageType.INF, false);

            // Collate stats
            CacheAndDisplayLogs(HEADER);
            CacheAndDisplayLogs(TEST_RUN + Name);
            CacheAndDisplayLogs(TEST_PASSED + Test_Passed);
            CacheAndDisplayLogs(TEST_FAILED + Test_Failed);
            CacheAndDisplayLogs(TEST_TOTAL + Test_Total);
            CacheAndDisplayLogs(ELAPSED + strElapsed);
            CacheAndDisplayLogs(HEADER);
        }

        private void LoadBalanceInstance(string hostName, string sessId, List<TestScriptWithArgs> testScripts, SeleniumDriver driver, string machine)
        {
            try
            {
                foreach (var script in testScripts)
                {
                    script.TestScript.SetDriver(driver);
                    if (script.Args == null)
                    {
                        object[] args = new object[DefaultArgs.Length + 1];
                        args[0] = TargetBrowser;
                        DefaultArgs.CopyTo(args, 1);
                        script.TestScript.Machine = machine;
                        script.TestScript.Run(this, args);
                    }
                    else script.TestScript.Run(this, script.Args);

                }
            }
            finally
            {
                SeleniumGrid.RemoveSession(hostName, sessId);
            }
        }

        public abstract void ExecuteTests();

        public virtual void ExecuteTests(object[] Arguments)
        {
            throw new NotImplementedException();
        }

        public void TearDown(SeleniumDriver driver)
        {
            try
            {
                driver.CloseSession();
            }
            catch (Exception e)
            {
                SessionLogger.WriteLine(e.Message, Logger.MessageType.ERR);
            }
        }

        public void TearDown()
        {
            EndTime = DateTime.Now;
            Elapsed = EndTime - StartTime;
            string strElapsed = Elapsed.ToString().Substring(0, Elapsed.ToString().LastIndexOf('.'));
            SessionLogger.WriteLine("Terminating test run: " + Name + "...", Logger.MessageType.INF, false);

            try
            {
                Driver?.CloseSession();
            }
            catch (Exception e)
            {
                SessionLogger.WriteLine(e.Message, Logger.MessageType.ERR);
            }

            // Collate stats
            CacheAndDisplayLogs(HEADER);
            CacheAndDisplayLogs(TEST_RUN + Name);
            CacheAndDisplayLogs(TEST_PASSED + Test_Passed);
            CacheAndDisplayLogs(TEST_FAILED + Test_Failed);
            CacheAndDisplayLogs(TEST_TOTAL + Test_Total);
            CacheAndDisplayLogs(ELAPSED + strElapsed);
            CacheAndDisplayLogs(HEADER);
        }

        public void CacheAndDisplayLogs(string Msg)
        {
            SessionLogger.removeBatch().WriteLine(Msg,Logger.MessageType.INF,false);
            ResultLogs.Add(Msg);
        }

        public List<List<TestScriptWithArgs>> SplitTestScripts(List<TestScriptWithArgs> testScripts, int capacity)
        {
            var list = new List<List<TestScriptWithArgs>>();

            for (int i = 0; i < capacity; i++) list.Add(new List<TestScriptWithArgs>());

            var curr = 0;

            foreach(var testScript in testScripts)
            {
                list.ElementAt(curr).Add(testScript);
                if (curr == capacity - 1) curr = 0;
                else curr++;
            }

            return list;
        }

        private Uri ConvertStringToUri(string uri, bool willthrow = true)
        {
            bool isValidUri = Uri.TryCreate(uri, UriKind.RelativeOrAbsolute, out var remoteURI);
            if (!isValidUri && willthrow) throw new Exception($"Invalid Remote Uri {uri}");
            if (!isValidUri) return null;
            return remoteURI;
        }
    }

    public class TestScriptWithArgs
    {
        public SeleniumTestScript TestScript { get; set; }
        public object[] Args { get; set; }
        public bool Ran { get; set; } = false;
    }
}
