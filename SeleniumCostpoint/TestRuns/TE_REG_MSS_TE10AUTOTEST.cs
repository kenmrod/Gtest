using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests.TE_BUILD;

namespace SeleniumCostpoint.TestRuns
{
    public class TE_REG_MSS_TE10AUTOTEST : SeleniumTestRun
    {
        public TE_REG_MSS_TE10AUTOTEST(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
            SetDefaultArgs(SeleniumDriver.Browser.CHROME, "TE_REG_MSS_TE10AUTOTEST");
            AddTestScripts(new TEBuildAcceptanceTest_Reg());
        }
    }
}
