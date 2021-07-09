using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests.TE_BUILD;

namespace SeleniumCostpoint.TestRuns
{
    public class TE_DAILY_TE10QCO12AUTOTEST : SeleniumTestRun
    {
        public TE_DAILY_TE10QCO12AUTOTEST(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
            SetDefaultArgs(SeleniumDriver.Browser.CHROME, "TE_DAILY_TE10QCO12AUTOTEST");
            AddTestScripts(new TE_BA());
        }
    }
}
