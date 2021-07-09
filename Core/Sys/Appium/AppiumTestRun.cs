using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Sys.Appium
{
    public abstract class AppiumTestRun : ITestRun
    {
        private const string HEADER = "==================================================";
        private const string SUBHEADER = "--------------------------------------------------";
        private const string TEST_RUN = "TestRun\t\t: ";
        private const string TEST_PASSED = "Passed\t\t: ";
        private const string TEST_FAILED = "Failed\t\t: ";
        private const string TEST_TOTAL = "Total\t\t: ";
        private const string ELAPSED = "Elapsed\t\t: ";

        private Dictionary<int, ITestScript> mTestManiFest = new Dictionary<int, ITestScript>();
        private List<string> ResultLogs = new List<string>();

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Elapsed { get; set; }
        public int Test_Total { get; set; }
        public int Test_Passed { get; set; }
        public int Test_Failed { get; set; }
        public int Test_CurrentRunNumber { get; set; }
        public Logger SessionLogger { get; set; }
        public string Environment { get; set; }

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

        public AppiumTestRun(Logger SessionLogs, String OverrideEnvironment = null)
        {
            SessionLogger = SessionLogs;
            Environment = OverrideEnvironment;
        }

        public void CacheAndDisplayLogs(string Msg)
        {
            SessionLogger.WriteLine(Msg);
            ResultLogs.Add(Msg);
        }

        public abstract void ExecuteTests();

        public virtual void ExecuteTests(object[] Arguments)
        {
            throw new NotImplementedException();
        }

        public int Run()
        {
            SetUp();
            ExecuteTests();
            TearDown();
            return PassRate;
        }

        public int Run(params object[] Arguments)
        {
            SetUp();
            ExecuteTests(Arguments);
            TearDown();
            return PassRate;
        }

        public void SetUp()
        {
            StartTime = DateTime.Now;
            SessionLogger.WriteLine("Initializing test run: " + Name + "...\n");
            TestEnvironment.LoadEnvironmentDataToList(this.GetType().Assembly.GetName().Name);
        }

        public void TearDown()
        {
            EndTime = DateTime.Now;
            Elapsed = EndTime - StartTime;
            string strElapsed = Elapsed.ToString().Substring(0, Elapsed.ToString().LastIndexOf('.'));
            SessionLogger.WriteLine("\nTerminating test run: " + Name + "...\n");

            // Collate stats
            CacheAndDisplayLogs(HEADER);
            CacheAndDisplayLogs(TEST_RUN + Name);
            CacheAndDisplayLogs(TEST_PASSED + Test_Passed);
            CacheAndDisplayLogs(TEST_FAILED + Test_Failed);
            CacheAndDisplayLogs(TEST_TOTAL + Test_Total);
            CacheAndDisplayLogs(ELAPSED + strElapsed);
            CacheAndDisplayLogs(HEADER);
        }

        public int Run(string RemoteUri)
        {
            throw new NotImplementedException();
        }

        public int Run(string HostName, string Port)
        {
            throw new NotImplementedException();
        }
    }
}
