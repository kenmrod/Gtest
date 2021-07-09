using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Sys.Appium
{
    public abstract class AppiumTestScript : ITestScript
    {
        private const int IDX_RUN_ARG_PLATFORM = 0;
        private const int IDX_RUN_ARG_ENVIRONMENT = 1;
        private const int IDX_RUN_ARG_DEVICE = 2;
        private const int IDX_RUN_ARG_ACTIVITY = 3;
        private const int IDX_RUN_ARG_INCLUDEINRESULTS = 4;
        private const string IMG_FILE_HEADER = "err_";

        private const int INT_DEFAULT_INSTANCE = 1;
        private const int INT_MIN_RUN_ARGS = 4;
        private const int INT_MAX_RUN_ARGS = 5;
        private static string LOGS_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Logs");

        private string mError;

        public AppiumDriver Driver { get; set; }
        public AppiumDriver.Platform TargetPlatform { get; set; }
        public Device TargetDevice { get; set; }
        public AppEnvironment TargetEnvironment { get; set; }
        public int Instance { get; set; }
        public bool Result { get; set; }
        public Logger ScriptLogger { get; set; }
        public string Error
        {
            get
            {
                return mError;
            }
        }

        public string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }

        public string Platform
        {
            get
            {
                return Enum.GetName(typeof(AppiumDriver.Platform), TargetPlatform);
            }
        }

        public string Machine
        {
            get
            {
                return "N/A";
            }
        }

        public string ErrorScreenshot { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Elapsed { get; set; }

        public virtual bool Run(ITestRun Owner, params object[] Arguments)
        {
            Result = false;
            TargetPlatform = (AppiumDriver.Platform)Arguments[IDX_RUN_ARG_PLATFORM];
            ScriptLogger = new Logger();
            ITestRun owner = Owner;
            TargetEnvironment = Arguments[IDX_RUN_ARG_ENVIRONMENT] as AppEnvironment;
            TargetDevice = (Device)Arguments[IDX_RUN_ARG_DEVICE];
            var appActivity = Arguments[IDX_RUN_ARG_ACTIVITY].ToString();
            Instance = INT_DEFAULT_INSTANCE;

            Driver = new AppiumDriver(TargetPlatform, TargetEnvironment.AppID, TargetEnvironment.PackagePath, TargetDevice, 
                TargetEnvironment.AppUrl, owner.SessionLogger, appActivity);

            /* Track run number of owner run */
            if (TestSetup(out mError))
            {
                try
                {
                    Result = string.IsNullOrEmpty(TargetEnvironment.UniqueName) ? TestExecute(out mError, Driver)
                        : TestExecute(out mError, TargetEnvironment.UniqueName, Driver);
                }
                catch (Exception e)
                {
                    mError = e.Message;
                    Result = false;
                }

                if (!Result)
                {
                    Directory.CreateDirectory(LOGS_PATH);
                    ErrorScreenshot = Path.Combine(LOGS_PATH, IMG_FILE_HEADER + Util.GetDateTimeString(DateTime.Now) + ".png");
                    Driver.CaptureScreenshot(ErrorScreenshot);
                    Driver.SessionLogger.WriteLine(String.Format("Image: {0}", ErrorScreenshot), Logger.MessageType.ERR);
                }

                if (!TestTearDown(Error))
                {

                }
            }
            if (Arguments.Length == INT_MAX_RUN_ARGS ? (bool)Arguments[IDX_RUN_ARG_INCLUDEINRESULTS] : true)
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

        public virtual bool TestExecute(out string ErrorMessage, IDriver Driver)
        {
            ErrorMessage = string.Empty;
            return true;
        }

        public virtual bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {
            ErrorMessage = string.Empty;
            return true;
        }

        public virtual bool TestSetup(out string ErrorMessage)
        {
            StartTime = DateTime.Now;
            bool ret = true;
            ErrorMessage = string.Empty;
            ErrorScreenshot = "-";
            try
            {
                Driver.SessionLogger.WriteLine("Running test: " + Name + "...");
                Driver.TargetPlatform = TargetPlatform;
                Driver.TargetDevice = TargetDevice;
                Driver.StartSession();
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
                ret = false;
            }
            return ret;
        }

        public virtual bool TestTearDown(string ErrorMessage)
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
