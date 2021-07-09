using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests.TE_BUILD;

namespace SeleniumCostpoint.TestRuns
{
    public class TE_DAILY_T10QCM16AUTOTEST : SeleniumTestRun
    {
        public TE_DAILY_T10QCM16AUTOTEST(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
            SetDefaultArgs(SeleniumDriver.Browser.CHROME, "TE_DAILY_T10QCM16AUTOTEST");
            AddTestScripts(new TE_BA());
        }
    }
}
