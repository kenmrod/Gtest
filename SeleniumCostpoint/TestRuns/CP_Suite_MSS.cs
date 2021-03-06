using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP_Suite_MSS : SeleniumTestRun
    {
        public CP_Suite_MSS(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
            SetDefaultArgs(SeleniumDriver.Browser.CHROME, "CP_STAGING_C71STAGEM", false);
            AddTestScripts(new VerifyField());
            AddTestScripts(new VerifyFieldFail());
            AddTestScripts(new CPBuildAcceptanceTest_Full(), SeleniumDriver.Browser.CHROME, "CP_STAGING_C71STAGEM");
        }
    }
}
