using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class DeleteReports_C71MQCM16AE : SeleniumTestRun
    {
        public DeleteReports_C71MQCM16AE(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71MQCM16AE");
            AddTestScripts(new SYMRPTAR_DeleteReports());
        }
    }
}
