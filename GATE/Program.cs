using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using Core.Sys;

namespace GATE
{
    class Program
    {
        #region CONSTANTS
        private const string RUN = "Run";
        private const string HEADER = "==================================================";
        private const string TITLE = "GATE (General-purpose Automated Test Environment)";
        private static string LOGS_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Logs");
        private static string REPOS_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Repositories");
        private static string ENV_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Environments");

        private static string SHAREFOLDER_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SharedFolderFull.bat");
        private const string LOG_FILE_HEADER = "log_";
        private const string EMAIL_SMTP_HOST = "smtp.deltek.com";
        private const string EMAIL_SENDER = "TestHarness@deltek.com";
        private const int EMAIL_SMTP_PORT = 25;
        private const string EMAIL_SMTP_USER = "Random@Deltek.com";
        private const string EMAIL_SMTP_PASS = "1234";
        private const string EMAIL_SUBJECT_HEADER = "[Test Harness] Results Summary: ";
        private const char EMAIL_DELIMITER = ';';
        private const string STR_JS_TESTRUN = "JSTestRun";
        #endregion

        private static Mailer Emailer = new Mailer(EMAIL_SMTP_HOST, EMAIL_SMTP_PORT, EMAIL_SMTP_USER, EMAIL_SMTP_PASS);
        private static ReportBuilder Reporter = new ReportBuilder();

        static Type GetType(string TestRunClassName, bool IsJavaScript)
        {
            Type ret = null;
            var typeName = TestRunClassName;

            if (IsJavaScript)
            {
                if (!File.Exists(TestRunClassName)) /* this is file path if javascript */
                {
                    return null;
                }
                typeName = STR_JS_TESTRUN;
            }
            foreach (Type typ in GetAllTestRuns())
            {
                if (typ.Name.ToLower() == typeName.ToLower())
                {
                    ret = typ;
                    break;
                }
            }
            return ret;
        }

        static ITestRun GetTestRun(Type type, params object[] Params)
        {
            ITestRun ret = null;
            ret = Activator.CreateInstance(type, Params) as ITestRun;
            return ret;
        }

        static int Main(string[] args)
        {
            int ret = -1;

            /* Get arguments */
            InputArgs myArgs = GetArgs(args);

            /* Special commands */
            if (myArgs.IsHelp)
            {
                DisplayHelp();
                ret = 0;
            }
            else if (myArgs.IsList)
            {
                DisplayTestRuns();
                ret = 0;
            }
            else if (myArgs.IsUnsupported)
            {
                DisplayHelp(false);
                ret = 0;
            }
            /* Run command */
            else
            {
                ret = Run(myArgs);
            }
            return ret;
        }

        static void PrepareLogs(Logger SessionLog, ITestRun TestRun)
        {
            Directory.CreateDirectory(SessionLog.LogsPath);
            //File.WriteAllLines(Path.Combine(SessionLog.LogsPath, LOG_FILE_HEADER + GetDateTimeString(DateTime.Now) + ".txt"),
            //SessionLog.Logs);

            //Logs per script
            List<XElement> mScriptLogs = new List<XElement>();
            foreach (KeyValuePair<int, ITestScript> kvp in TestRun.TestManifest)
            {
                List<XElement> scriptLogs = new List<XElement>();
                foreach (LoggerRecord log in kvp.Value.ScriptLogger.Logs)
                {
                    XElement element = new XElement("logmessage",
                        new XAttribute("MessageTimeStamp", String.Format("{0:yyyy-MM-dd hh:mm:ss tt}", log.TimeStamp)),
                        new XAttribute("MessageType", log.MessageType),
                        new XAttribute("MessageDetails", log.MessageDetails));
                    scriptLogs.Add(element);
                }

                XElement elm = new XElement("testscript", new XAttribute("name", kvp.Value.Name),
                    new XAttribute("instance", kvp.Value.Instance),
                    new XElement("scriptlogs", scriptLogs));
                mScriptLogs.Add(elm);
            }
            //Logs for events outside scripts
            List<XElement> mRunLogs = new List<XElement>();
            foreach (LoggerRecord log in SessionLog.Logs)
            {
                XElement elm = new XElement("logmessage",
                    new XAttribute("MessageTimeStamp", String.Format("{0:yyyy-MM-dd hh:mm:ss tt}", log.TimeStamp)),
                    new XAttribute("MessageType", log.MessageType),
                    new XAttribute("MessageDetails", log.MessageDetails));
                mRunLogs.Add(elm);
            }
            //Assemble logs
            string strElapsed = TestRun.Elapsed.ToString().Contains(".") ? TestRun.Elapsed.ToString().Substring(0, TestRun.Elapsed.ToString().LastIndexOf('.')) : "00:00:00";
            XElement ElmRoot = new XElement("testrun",
                new XElement("testrunname", TestRun.Name),
                new XElement("testrundetails", mScriptLogs, mRunLogs),
                new XElement("testrunresults",
                new XElement("passed", TestRun.Test_Passed),
                new XElement("failed", TestRun.Test_Failed),
                new XElement("total", TestRun.Test_Total),
                new XElement("elapsed", strElapsed))
                );

            //Save to XML
            XDocument xDoc = new XDocument(ElmRoot);
            xDoc.Save(Path.Combine(SessionLog.LogsPath, LOG_FILE_HEADER + GetDateTimeString(DateTime.Now) + ".xml"));
        }

        #region PRIVATE METHODS
        private static string GetDateTimeString(DateTime inputString)
        {
            return string.Format("{0:yyyyMMddHHmmss}", inputString);
        }

        private static InputArgs GetArgs(string[] Arguments)
        {
            var temp = Arguments.Select(x => x.ToLower().TrimStart(new char[] { '-', '/' })).ToList();
            var ret =  new InputArgs
            {
                IsJavaScript = temp.Contains("js"),
                IsHelp = temp.Contains("h") || temp.Contains("help"),
                IsList = temp.Contains("l"),
                IsNotification = temp.Contains("notif")
            };

            var remoteArgIndex = Arguments.ToList().FindIndex(a => a.Contains("-r") || a.Contains("/r"));
            if (remoteArgIndex != -1)
            {
                ret.IsRemote = true;

                var hostname = Arguments.ElementAt(remoteArgIndex + 1);
                ret.Hostname = hostname;
            }

            var portArgIndex = Arguments.ToList().FindIndex(a => a.Contains("-p") || a.Contains("/p"));
            if (portArgIndex != -1 && ret.IsRemote)
            {
                var port = Arguments.ElementAt(portArgIndex + 1);
                ret.Port = port;
            }

            ret.IsUnsupported = !Arguments.Any() || (!ret.IsHelp && !ret.IsJavaScript && !ret.IsList && 
                !ret.IsNotification && !ret.IsRemote && Arguments.Any(x => x.StartsWith("/") || x.StartsWith("-")));

            temp = Arguments.ToList();
            temp.RemoveAll(x => x.StartsWith("/") || x.StartsWith("-"));
            ret.TestRun = temp.FirstOrDefault();
            ret.EmailList = temp.Count > 1 ? temp.LastOrDefault() : null;
            if (!String.IsNullOrEmpty(ret.EmailList))
            {
                //Get the parameter directly after the testrun name. 
                ret.Environment = temp.Count > 2 ? temp[1] : null;
            }

            return ret;
        }

        private static int Run(InputArgs arguments)
        {
            DisplayPreamble();
            CreateSharedFolder(LOGS_PATH);
            InitializeTestEnvironments();

            int ret = -1;
            Type type = GetType(arguments.TestRun, arguments.IsJavaScript);
            if (type != null)
            {
                Logger log = new Logger();
                var testRun = GetTestRun(type, log, arguments.Environment);
                log.LogsPath = Path.Combine(LOGS_PATH, type.Namespace.Replace(".TestRuns", ""), arguments.TestRun);
                if (testRun != null)
                {
                    if (arguments.IsNotification) { EmailNotifier(testRun, arguments.EmailList.Split(EMAIL_DELIMITER)); }
                    ret = arguments.IsJavaScript 
                        ? testRun.Run(new object[] { arguments.TestRun }) 
                        : arguments.IsRemote 
                            ? arguments.Port == null 
                                ? testRun.Run(arguments.Hostname) 
                                : testRun.Run(arguments.Hostname, arguments.Port)
                        : testRun.Run();

                    EmailResults(testRun, arguments.EmailList.Split(EMAIL_DELIMITER));
                    PrepareLogs(log, testRun);
                }
                else
                {
                    Console.WriteLine("ERROR: Instance of TestRun cannot be created.");
                }
            }
            else
            {
                Console.WriteLine("ERROR: No such TestRun exists.");
            }
            return ret;
        }

        private static void EmailResults(ITestRun TestRun, string[] EmailList)
        {
            // Assemble email. Text for now
            // send email
            if (EmailList != null && EmailList.Length > 0)
            {
                string summaryFile = Guid.NewGuid().ToString() + ".html";
                try
                {
                    string subject = String.IsNullOrEmpty(TestRun.Environment) ? $"{EMAIL_SUBJECT_HEADER} {TestRun.Name}" : $"{EMAIL_SUBJECT_HEADER} {TestRun.Name} - {TestRun.Environment}";
                    string errorMessage;
                    if (Emailer.SendMail(subject, EMAIL_SENDER, EmailList, Reporter.CreateHTMLReportBody(TestRun, summaryFile), true, out errorMessage))
                    {
                        TestRun.SessionLogger.WriteLine("Result notification email sent!", Logger.MessageType.INF,false);
                    }
                    else
                    {
                        throw new Exception(errorMessage);
                    }
                }
                catch (Exception e)
                {
                    TestRun.CacheAndDisplayLogs("\n" + e.Message);
                }
                finally
                {
                    string fullPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), summaryFile);
                    if (File.Exists(fullPath))
                        File.Delete(fullPath);
                }
            }
        }

        /// <summary>
        /// sends notification email that an execution has begun
        /// </summary>
        /// <param name="TestRun"></param>
        /// <param name="EmailList"></param>
        private static void EmailNotifier(ITestRun TestRun, string[] EmailList)
        {
            // Assemble email. 
            if (EmailList != null && EmailList.Length > 0)
            {
                try
                {
                    string machineName = Environment.MachineName;
                    string runName = String.IsNullOrEmpty(TestRun.Environment) ? $"{TestRun.Name}" :
                            $"{TestRun.Name} ({TestRun.Environment})";
                    string subject = $"[Test Harness] {runName} has started execution on {machineName}";
                    if (Emailer.SendMail(subject, EMAIL_SENDER, EmailList, string.Empty, false, out string errorMessage))
                    {
                        TestRun.SessionLogger.WriteLine("Start execution notification email sent!", Logger.MessageType.INF, false);
                    }
                    else
                    {
                        throw new Exception(errorMessage);
                    }
                }
                catch (Exception e)
                {
                    TestRun.CacheAndDisplayLogs("\n" + e.Message);
                }
            }
        }

        private static void DisplayPreamble()
        {
            Console.WriteLine(HEADER);
            Console.WriteLine(TITLE);
            Console.WriteLine("Version\t: " + Assembly.GetExecutingAssembly().GetName().Version.ToString());
            Console.WriteLine("Author\t: MakatiAutomation");
            Console.WriteLine(HEADER);
            Console.WriteLine();
        }

        private static void DisplayHelp(bool IsRecognized = true)
        {
            if (!IsRecognized)
            {
                Console.WriteLine("This command is not supported by Test Harness. Please see below for supported commands:");
            }
            else
            {
                Console.WriteLine("Test Harness executes a Test Run and sends an execution report to the email provided.");
            }
            Console.WriteLine();
            Console.WriteLine("TESTH TESTRUNNAME EMAILADDRESSLIST [HELP |/H | /? |-H ] [/L]");
            Console.WriteLine();
            Console.WriteLine(" TESTRUNNAME             Name of the Test Run to execute.");
            Console.WriteLine(" EMAILADDRESSLIST        List of email addresses that will be recipients of the ");
            Console.WriteLine("                         execution report. Addresses should be separated by a ");
            Console.WriteLine("                         semicolon (;)");
            Console.WriteLine(" HELP, /H, /?, -H        Provides help information for GATE.");
            Console.WriteLine(" /L, -L                  Displays all available Test Runs.");
            Console.WriteLine(" /JS, -JS                Runs test written in JavaScript. TESTRUNNAME corresponds to absolute or relative file path");
            Console.WriteLine(" /r, -r <HostName>       Hostname of the Grid.");
            Console.WriteLine(" /p, -p <Port>           Port number of Grid / Node.");
            Console.WriteLine();
            Console.WriteLine(HEADER);
        }

        private static void DisplayTestRuns(bool IsDescending = false)
        {
            Console.WriteLine("Available Test Runs in {0}", REPOS_PATH);
            Console.WriteLine();
            foreach (Type typ in GetAllTestRuns().OrderByWithDirection(x => x.Name, IsDescending))
            {
                Console.WriteLine("[{1}] {0}", typ.Name, typ.Namespace.Replace(".TestRuns", ""));
            }
            Console.WriteLine();
            Console.WriteLine("Total Test Runs: {0}", GetAllTestRuns().Count);
        }

        private static List<Type> GetAllTestRuns()
        {
            List<Type> ret = new List<Type>();

            foreach (String file in Directory.EnumerateFiles(REPOS_PATH))
            {
                var assembly = Assembly.LoadFile(file);
                foreach (Type typ in assembly.GetTypes())
                {
                    if (!String.IsNullOrEmpty(typ.Namespace))
                    {
                        if (typ.Namespace.Contains("TestRuns"))
                            ret.Add(typ);
                    }                   
                }
            }
            return ret;
        }

        private static void CreateSharedFolder(String FolderPath)
        {
            try
            {
                Console.WriteLine("Creating shared folder ...");
                Util.RunProcess(SHAREFOLDER_PATH, FolderPath,
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    false,
                    300);
                Console.WriteLine("DONE");
            }
            catch
            {
                //swallow
            }
        }

        private static void InitializeTestEnvironments()
        {
            TestEnvironment.EnvironmentData.Clear();
            foreach (String file in Directory.EnumerateFiles(REPOS_PATH))
            {
                var assembly = Assembly.LoadFile(file);
                string assemblyname = assembly.GetName().Name;
                string envpath = Path.Combine(ENV_PATH, assemblyname + ".csv");
                if (File.Exists(envpath))
                {
                    DataTable dt = Util.CSVParse(envpath);
                    TestEnvironment.EnvironmentData.Add(assemblyname, dt);
                }
            }
        }
        #endregion

        private class InputArgs
        {
            string emailList = string.Empty;
            public string Environment { get; set; }
            public bool IsJavaScript { get; set; }
            public bool IsHelp { get; set; }
            public bool IsList { get; set; }
            public bool IsUnsupported { get; set; }
            public bool IsNotification{ get; set; }
            public bool IsRemote { get; set; }
            public string Hostname { get; set; }
            public string Port { get; set; }
            public string TestRun { get; set; }
            public string EmailList
            {
                get
                {
                    return emailList ?? string.Empty; // prevent null
                }
                set
                {
                    emailList = value;
                }
            }

        }
    }
}
