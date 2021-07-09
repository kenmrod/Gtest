using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Linq;

namespace Core.Sys.Selenium
{
    public abstract class SeleniumTestScript: ITestScript
    {
        #region PRIVATE CONSTANTS
        private const int IDX_RUN_ARG_BROWSER = 0;
        private const int IDX_RUN_ARG_ENV = 1;
        private const int IDX_RUN_ARG_INCLUDEINRESULTS = 2;
        private const int IDX_RUN_ARG_SPECIALTEST = 3;
        private const int IDX_RUN_ARG_FILEPATH = 4;
        private const int IDX_RUN_ARG_INSTANCE = 5;
        private const int INT_MIN_RUN_ARGS = 2;
        private const int INT_MAX_RUN_ARGS = 6;
        private const int INT_DEFAULT_INSTANCE = 1;
        private static string DATA_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Data");
        private const string IMG_FILE_HEADER = "err_";
        #endregion

        #region PRIVATE DECLATATIONS
        private bool isDriverInherited = false;
        #endregion

        #region DECLARATIONS
        public SeleniumDriver Driver = null;
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
        public String DataPath { get; set; }
        public Logger ScriptLogger { get; set; }

        public List<DataRecord> DataSet => _dataset;
        private List<DataRecord> _dataset = null;

        protected ITestRun mOwner = null;
        protected SeleniumDriver.Browser mTargetBrowser;
        protected string mEnvironment = string.Empty;
        protected string mJSFilePath = string.Empty;
        protected bool IsDataDriven = false;
        protected bool IsJavaScript = false;
        protected bool IsIncludedInResults = true;

        public string Platform
        {
            get
            {
                return Enum.GetName(typeof(SeleniumDriver.Browser), mTargetBrowser);
            }
        }

        public string Machine { get; set; }
        #endregion

        #region PUBLIC METHODS
        public void SetDriver(SeleniumDriver Driver)
        {
            this.Driver = Driver;
            isDriverInherited = true;
        }

        public virtual bool Run(ITestRun Owner, params object[] Arguments)
        {
            Result = false;
            ScriptLogger = new Logger();
            mOwner = Owner;
            Instance = INT_DEFAULT_INSTANCE;
            try
            {
                if(Driver == null) Driver = new SeleniumDriver(mOwner.SessionLogger);
                AssembleArgs(Arguments);

                /* Track run number of owner run */
                if (TestSetup(out _Error))
                {
                    //Run test script
                    try
                    {
                        Result = string.IsNullOrEmpty(mEnvironment) ? TestExecute(out _Error, Driver)
                        : TestExecute(out _Error, mEnvironment, Driver);
                    }
                    catch (Exception e)
                    {
                        _Error = e.Message;
                        ScriptLogger.WriteLine(_Error, Logger.MessageType.ERR);
                        ScriptLogger.WriteLine(e.StackTrace, Logger.MessageType.ERR);
                        Result = false;
                    }

                    //Log Error Message and Screenshot
                    if (!Result)
                    {                     
                        Directory.CreateDirectory(Driver.SessionLogger.LogsPath);
                        ErrorScreenshot = Path.Combine(Driver.SessionLogger.LogsPath, IMG_FILE_HEADER + GetDateTimeString(DateTime.Now) + ".png");
                        Driver.CaptureScreenshot(ErrorScreenshot);
                        ScriptLogger.WriteLine(String.Format("Image: {0}", ErrorScreenshot), Logger.MessageType.ERR);
                    }

                    if (!TestTearDown(Error))
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                _Error = ex.Message;
                ErrorScreenshot = "-";
            }

            // Results statistics
            if (IsIncludedInResults)
            {
                mOwner.TestManifest.Add(++(mOwner.Test_CurrentRunNumber), this);
                mOwner.Test_Total++; // this shouldn't be here, total should be determined before runtime
                if (Result)
                {
                    mOwner.Test_Passed++;
                }
                else
                {
                    mOwner.Test_Failed++;
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
                Driver.SessionLogger.WriteLine("Running test: " + Name + "...", Logger.MessageType.INF, false);
                if (!isDriverInherited)
                {
                    Driver.TargetBrowser = mTargetBrowser;
                    Driver.StartBrowser(false);
                }
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
                ret = false;
            }
            return ret;
        }

        public virtual bool TestExecute(out string ErrorMessage, IDriver Driver)
        {
            throw new NotImplementedException("Check if test environment parameter was properly defined.");
        }

        public virtual bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {            
            throw new NotImplementedException("Check if test environment parameter was properly defined.");
        }        

        public bool TestTearDown(string ErrorMessage)
        {
            bool ret = true;

            try
            {
                if(!isDriverInherited) Driver.CloseSession();
                ScriptLogger.WriteLine("Test execution completed.", Logger.MessageType.INF);
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
        #endregion

       

        #region PRIVATE METHODS

        private string GetDateTimeString(DateTime inputString)
        {
            return string.Format("{0:yyyyMMddHHmmss}", inputString);
        }

        /// <summary>
        /// Gets the parameter values for a given step. Determines the value whether to use default value or use data-driven. 
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        private string[] GetParameterValues(List<Step.Parameter> Parameters)
        {
            try
            {
                List<string> values = new List<string>();

                foreach(Step.Parameter param in Parameters)
                {
                    //If DataDriven get the value from the csv file, if not use default value
                    string val = IsDataDriven ? ( param.IsDataDriven ? GetDataValue(param.Name) : param.Value ) : param.Value;
                    values.Add(val);
                }
                return values.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception("Data variable substitution failed:" + ex.Message);
            }
        }

        /// <summary>
        /// Get the value from a datarecord given the parameter Name
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        private string GetDataValue(string Name)
        {
            try
            {
                return DataSet.Where(x => x.Name == Name).FirstOrDefault().Values.ElementAt(Instance - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new Exception("Instance [" + Instance.ToString() + "] is not available in the given dataset.");
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to get data value for [" + Name + "] :" + ex.Message);
            }
        }

        /// <summary>
        /// Populates DataSet with values from the given datapath file
        /// </summary>
        /// <param name="FilePath"></param>
        private void PopulateDataSet(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    FileInfo file = new FileInfo(FilePath);
                    string fileType = file.Extension;
                    _dataset = new List<DataRecord>();

                    switch (fileType.Trim('.').ToLower())
                    {
                        case "csv":
                            DataTable dt = Util.CSVParse(FilePath);
                            foreach(DataColumn dc in dt.Columns)
                            {
                                DataRecord newrec = new DataRecord();

                                newrec.Name = dc.ColumnName;
                                newrec.Values = new List<string>();
                                foreach(DataRow dr in dt.Rows)
                                {
                                    newrec.Values.Add(dr[newrec.Name].ToString());
                                }
                                _dataset.Add(newrec);
                            }
                            break;
                        case "xml":
                            break;
                        default:
                            throw new Exception("Dataset filetype not yet supported.");
                    }
                }
                catch (Exception ex)
                {
                    Driver.SessionLogger.WriteLine("Error encountered during retrieval of dataset file: " + ex.Message, Logger.MessageType.WRN);
                }
            }
            else
            {
                Driver.SessionLogger.WriteLine(String.Format("File: {0} does not exist. Dataset for this test cannot be applied.", FilePath),Logger.MessageType.WRN);
            }
        }

        /// <summary>
        /// Assembles the string arguments into test script fields
        /// </summary>
        /// <param name="Arguments"></param>
        /// <returns></returns>
        private void AssembleArgs(object[] Arguments)
        {
            try
            {
                //Guard clause: If arguments are insufficient or more than required, terminate test.
                if (Arguments.Length > INT_MAX_RUN_ARGS || Arguments.Length < INT_MIN_RUN_ARGS)
                {
                    throw new Exception("Arguments supplied did not match acceptable requirements for running test script. ");
                }

                // Set minimum requirements to run test
                mTargetBrowser = (SeleniumDriver.Browser)Arguments[IDX_RUN_ARG_BROWSER];
                mEnvironment = string.IsNullOrEmpty(mOwner.Environment) ? Arguments[IDX_RUN_ARG_ENV].ToString() : mOwner.Environment;

                // Tests are included by default. If arguments are more than minimum, check if test is included or not.               
                if (Arguments.Length > INT_MIN_RUN_ARGS)
                {
                    IsIncludedInResults = Convert.ToBoolean(Arguments[IDX_RUN_ARG_INCLUDEINRESULTS]);
                }
                //If arguments exceed the minimum requirements, determine if the script type is data-driven or javascript
                if (Arguments.Length > INT_MIN_RUN_ARGS + 1)
                {
                    string testType = Arguments[IDX_RUN_ARG_SPECIALTEST].ToString();
                    switch (testType.ToLower())
                    {
                        case "dd":
                            IsDataDriven = true;
                            ScriptLogger.WriteLine("Test will run in data-driven mode...", Logger.MessageType.INF);
                            string filePath = Arguments[IDX_RUN_ARG_FILEPATH].ToString();
                            DataPath = Path.IsPathRooted(filePath) ? filePath : Path.Combine(DATA_PATH, filePath);
                            if(Arguments.Length - 1 == IDX_RUN_ARG_INSTANCE)
                            {
                                Instance = (int)Arguments[IDX_RUN_ARG_INSTANCE];
                            }
                            PopulateDataSet(DataPath);
                            ScriptLogger.WriteLine("Dataset:" + DataPath, Logger.MessageType.INF);
                            ScriptLogger.WriteLine("Instance:" + Instance.ToString(), Logger.MessageType.INF, false);
                            break;
                        case "js":
                            IsJavaScript = true;
                            ScriptLogger.WriteLine("Test will run in javascript mode...", Logger.MessageType.INF);
                            mJSFilePath = Arguments[IDX_RUN_ARG_FILEPATH].ToString();
                            break;
                        default:
                            throw new Exception("Incorrect special test type [" + testType + "]. Please use 'DD' for DataDriven or 'JS' for Javascript.");
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            } 
        }

        #endregion

        #region PROTECTED METHODS
        /// <summary>
        /// Returns a string message containing the line number where an exception was thrown
        /// </summary>
        /// <param name="CustomMessage"></param>
        /// <param name="ExceptionMessage"></param>
        /// <param name="LineNumber"></param>
        /// <returns></returns>
        protected string TraceMessage(string CustomMessage, string ExceptionMessage, [CallerLineNumber] int LineNumber = 0)
        {
            return String.Format("[Ln {0}] {1} : {2}", LineNumber.ToString(), CustomMessage, ExceptionMessage);
        }

        /// <summary>
        /// Performs a step in the test script 
        /// </summary>
        /// <param name="MyMethod"></param>
        protected void PerformStep(Delegate MyMethod)
        {
            try
            {
                var attribute = MyMethod.Method.GetCustomAttribute<Step>();
                string stepInfo = string.Format("Step [{0}]|{1}|{2}",attribute.stepnumber.ToString(),attribute.component, attribute.description);
                ScriptLogger.WriteLine(this,stepInfo, Logger.MessageType.STEP);
                string[] parameters = GetParameterValues(attribute.Parameters);
                MyMethod.DynamicInvoke(new object[] { parameters });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }
        }

        /// <summary>
        /// Gets the list of steps ina given test script.
        /// </summary>
        protected void GetScriptSteps()
        {
            try
            {
                Driver.SessionLogger.WriteLine("STEPS FOR TEST [" + this.Name + "]");
                //List<string> lstSteps = new List<string>();

                //Get the methods at runtime for the currently running test script
                foreach (MethodInfo method in this.GetType().GetRuntimeMethods())
                {
                    var attribute = method.GetCustomAttribute<Step>();
                    if (attribute != null)
                    {
                        string stepinfo = String.Format("Step [{0}] | Component [{1}] | Description: {2} | Parameters: {3}",
                                attribute.stepnumber, attribute.component, attribute.description, attribute.Parameters.FirstOrDefault().Value);
                        Driver.SessionLogger.WriteLine(stepinfo);
                        //lstSteps.Add(stepinfo);
                    }
                }
                Driver.SessionLogger.WriteLine("======================");
                //return lstSteps;
            }
            catch (Exception e)
            {
                throw new Exception("Unable to display steps for script[" + this.Name + "]" + e.Message);
            }
        }
        #endregion
    }
}
