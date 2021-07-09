using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class DeleteReports_C71MQCO12PEB1 : SeleniumTestRun
    {
        public DeleteReports_C71MQCO12PEB1(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71MQCO12PEB1");
            AddTestScripts(new SYMRPTAR_DeleteReports());
        }
    }
}
