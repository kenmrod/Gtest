using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP_Suite_HEADLESS_C71STAGEM : SeleniumTestRun
    {
        public CP_Suite_HEADLESS_C71STAGEM(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
            SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "CP_STAGING_C71STAGEM", false);
            AddTestScripts(new VerifyField());
            AddTestScripts(new VerifyFieldFail());
            AddTestScripts(new CPBuildAcceptanceTest_Full(), SeleniumDriver.Browser.CHROME_HEADLESS, "CP_STAGING_C71STAGEM");
        }
    }
}
