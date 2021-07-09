using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class DeleteReports_SYMRPTAR : SeleniumTestRun
    {
        public DeleteReports_SYMRPTAR(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71MQCO12AEHQ");
            AddTestScripts(new SYMRPTAR_DeleteReports());
        }

    }
}
