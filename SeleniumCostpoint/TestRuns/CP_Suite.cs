using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;
using SeleniumCostpoint.Tests.CP_BUILD;

namespace SeleniumCostpoint.TestRuns
{
    public class CP_Suite: SeleniumTestRun
    {
        public CP_Suite(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
            SetDefaultArgs(SeleniumDriver.Browser.CHROME, "CP_STAGING_C71STAGEM");

            //MSS
            AddTestScripts(new VerifyField());
            AddTestScripts(new VerifyFieldFail());
            AddTestScripts(new CheckUser());
            AddTestScripts(new DeleteUser());
            AddTestScripts(new CPBuildAcceptanceTest_Full());

            //ORA
            AddTestScripts(new VerifyField(), SeleniumDriver.Browser.CHROME, "CP_STAGING_C71STAGEO");
            AddTestScripts(new VerifyFieldFail(), SeleniumDriver.Browser.CHROME, "CP_STAGING_C71STAGEO");
            AddTestScripts(new CheckUser(), SeleniumDriver.Browser.CHROME, "CP_STAGING_C71STAGEO");
            AddTestScripts(new DeleteUser(), SeleniumDriver.Browser.CHROME, "CP_STAGING_C71STAGEO");
            AddTestScripts(new CPBuildAcceptanceTest_Full(), SeleniumDriver.Browser.CHROME, "CP_STAGING_C71STAGEO");
        }
    }
}
