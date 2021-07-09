using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using SeleniumCostpoint.Common;
using Core.Sys;
using Core.Sys.Selenium;
using Core.Sys.JavaScript;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace SeleniumCostpoint.Tests
{
    public class JSTest : SeleniumTestScript
    {
        private const string STR_ERR_HEADER = "[ERR] ";
        public override bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {
            bool ret = true;
            ErrorMessage = string.Empty;
            SeleniumDriver sDriver = Driver as SeleniumDriver;
            Functions Function = new Functions(sDriver);

            try
            {
                /* Login */
                Function.Login(TestEnvironment, out ErrorMessage);

                /* parse java script, add common headers */
                var common = File.ReadAllText(Headers.HEADER_COMMON);
                var scr = common + File.ReadAllText(mJSFilePath);

                /* set to 1 hour limit of javascript timeout */
                sDriver.Instance.Manage().Timeouts().AsynchronousJavaScript = new TimeSpan(1, 0, 0);

                /* execute - will return logs */
                var res = ((sDriver.Instance as IJavaScriptExecutor).ExecuteAsyncScript(scr) as ReadOnlyCollection<object>).Cast<string>();
                /* Write each log entry into LoggerRecord */
                List<LoggerRecord> lstResults = new List<LoggerRecord>();
                foreach(string r in res)
                {
                    lstResults.Add(new LoggerRecord(DateTime.Now, Logger.MessageType.INF, r));
                }
                sDriver.SessionLogger.Logs.AddRange(lstResults);
                var err = res.FirstOrDefault(x => x.Contains(STR_ERR_HEADER));
                if (err != null)
                {
                    throw new Exception(err.Replace(STR_ERR_HEADER, string.Empty));
                }
            }
            catch (Exception ex)
            {
                ret = false;
                ErrorMessage = ex.Message;
                throw new Exception(ex.Message);
            }
            return ret;
        }
    }
}
