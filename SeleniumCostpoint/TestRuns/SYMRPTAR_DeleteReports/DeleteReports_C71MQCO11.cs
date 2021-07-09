using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class DeleteReports_C71MQCO11BE2E : SeleniumTestRun
    {
        public DeleteReports_C71MQCO11BE2E(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71MQCO11");
            AddTestScripts(new SYMRPTAR_DeleteReports());
        }
    }
}
