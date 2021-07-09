using System;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.IO;
using System.Reflection;

namespace Core.Sys.API
{
    public abstract class APITestScript : ITestScript
    {
        private const int IDX_RUN_ARG_ENV = 0;
        private const int IDX_RUN_ARG_INCLUDEINRESULTS = 1;
        private const int INT_MAX_RUN_ARGS = 2;

        private const int INT_DEFAULT_INSTANCE = 1;
        public APIDriver Driver = null;
        private static string LOGS_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Logs");
        private const string IMG_FILE_HEADER = "err_";
        public bool Result { get; set; }
        public string Error
        {
            get
            {
                return _Error;
            }
        }
        protected string _Error = string.Empty;
        public string ErrorScreenshot { get; set; }
        public string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }
        public int Instance { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Elapsed { get; set; }
        public Logger ScriptLogger { get; set; }
        public string Platform
        {
            get
            {
                return "API";
            }
        }
        public string Machine
        {
            get
            {
                return "N/A";
            }
        }
        public virtual bool Run(ITestRun Owner, params object[] Arguments)
        {
            Result = false;
            ITestRun owner = Owner;
            ScriptLogger = new Logger();
            Driver = new APIDriver(owner.SessionLogger);
            ErrorScreenshot = "--";
            Instance = INT_DEFAULT_INSTANCE;

            /* Track run number of owner run */
            if (TestSetup(out _Error))
            {
                try
                {
                    var testEnvironment = string.IsNullOrEmpty(owner.Environment) ? Arguments[IDX_RUN_ARG_ENV].ToString() : owner.Environment;
                    Result = string.IsNullOrEmpty(testEnvironment) ? TestExecute(out _Error, Driver)
                        : TestExecute(out _Error, testEnvironment, Driver);
                }
                catch (Exception e)
                {
                    _Error = e.Message;
                    Result = false;
                }

                if (!Result)
                {
                    Directory.CreateDirectory(LOGS_PATH);
                }

                if (!TestTearDown(Error))
                {

                }
            }

            if (Arguments.Length >= INT_MAX_RUN_ARGS ? (bool)Arguments[IDX_RUN_ARG_INCLUDEINRESULTS] : true)
            {
                owner.TestManifest.Add(++(owner.Test_CurrentRunNumber), this);
                owner.Test_Total++; // this shouldn't be here, total should be determined before runtime
                if (Result)
                {
                    owner.Test_Passed++;
                }
                else
                {
                    owner.Test_Failed++;
                }
            }
            return Result;
        }

        public bool TestSetup(out string ErrorMessage)
        {
            StartTime = DateTime.Now;
            // Open Browser
            bool ret = true;
            ErrorMessage = string.Empty;
            ErrorScreenshot = "-";
            try
            {
                Driver.SessionLogger.WriteLine("Running test: " + Name + "...");
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
                ret = false;
            }
            return ret;
        }

        protected string TraceMessage(string CustomMessage, string ExceptionMessage, [CallerLineNumber] int LineNumber = 0)
        {
            return String.Format("[Ln {0}] {1} : {2}", LineNumber.ToString(), CustomMessage, ExceptionMessage);
        }
        
        public virtual bool TestExecute(out string ErrorMessage, IDriver Driver)
        {
            throw new NotImplementedException("Check if test environment parameter was properly defined.");
        }

        public virtual bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {

            throw new NotImplementedException("Check if test environment parameter was properly defined.");
        }

        private string GetDateTimeString(DateTime inputString)
        {
            return string.Format("{0:yyyyMMddHHmmss}", inputString);
        }

        public bool TestTearDown(string ErrorMessage)
        {
            bool ret = true;

            try
            {
                Driver.CloseSession();
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
                ret = false;
            }
            EndTime = DateTime.Now;
            Elapsed = EndTime - StartTime;
            return ret;
        }
    }
}
