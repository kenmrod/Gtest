using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests.TE_BUILD;

namespace SeleniumCostpoint.TestRuns
{
    public class TE_REG_ORA_TE10AUTOTEST_HEADLESS : SeleniumTestRun
    {
        public TE_REG_ORA_TE10AUTOTEST_HEADLESS(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
            SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "TE_REG_ORA_TE10AUTOTEST");
            AddTestScripts(new TEBuildAcceptanceTest_Reg());
        }
    }
}
