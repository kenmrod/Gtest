using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class DeleteReports_C71MQCM14RU6Q : SeleniumTestRun
    {
        public DeleteReports_C71MQCM14RU6Q(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71MQCM14RU6Q");
            AddTestScripts(new SYMRPTAR_DeleteReports());
        }
    }
}
