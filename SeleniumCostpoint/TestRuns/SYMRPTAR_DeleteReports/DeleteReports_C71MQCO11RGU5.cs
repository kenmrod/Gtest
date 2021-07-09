using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class DeleteReports_C71MQCO11RGU5 : SeleniumTestRun
    {
        public DeleteReports_C71MQCO11RGU5(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71MQCO11RGU5");
            AddTestScripts(new SYMRPTAR_DeleteReports());
        }
    }
}
