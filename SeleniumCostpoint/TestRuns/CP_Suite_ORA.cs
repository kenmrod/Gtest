using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP_Suite_ORA : SeleniumTestRun
    {
        public CP_Suite_ORA (Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
            SetDefaultArgs(SeleniumDriver.Browser.CHROME, "CP_STAGING_C71STAGEO", false);
            AddTestScripts(new VerifyField());
            AddTestScripts(new VerifyFieldFail());
            AddTestScripts(new CPBuildAcceptanceTest_Full(), SeleniumDriver.Browser.CHROME, "CP_STAGING_C71STAGEO");
        }
    }
}
