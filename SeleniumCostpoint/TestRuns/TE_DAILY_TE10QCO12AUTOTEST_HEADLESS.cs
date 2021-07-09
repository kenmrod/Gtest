using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests.TE_BUILD;

namespace SeleniumCostpoint.TestRuns
{
    public class TE_DAILY_TE10QCO12AUTOTEST_HEADLESS : SeleniumTestRun
    {
        public TE_DAILY_TE10QCO12AUTOTEST_HEADLESS(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
            SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "TE_DAILY_TE10QCO12AUTOTEST");
            AddTestScripts(new TE_BA());
        }
    }
}
