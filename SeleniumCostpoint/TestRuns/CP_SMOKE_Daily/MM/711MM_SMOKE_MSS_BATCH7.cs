using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711MM_SMOKE_MSS_BATCH7 : SeleniumTestRun
    {
        public CP711MM_SMOKE_MSS_BATCH7(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCM16AE");
				AddTestScripts(new MSPPLRT_SMOKE());
				AddTestScripts(new MSPRCAP_SMOKE());
				AddTestScripts(new MSQRCAP_SMOKE());
				AddTestScripts(new MSRACTM_SMOKE());
				AddTestScripts(new MSRBCKLG_SMOKE());
				AddTestScripts(new MSRMSS_SMOKE());
				AddTestScripts(new OEMAMORT_SMOKE());
				AddTestScripts(new OEMAPPRP_SMOKE());
				AddTestScripts(new OEMAPPRT_SMOKE());
				AddTestScripts(new OEMAPPSO_SMOKE());
				AddTestScripts(new OEMCATLG_SMOKE());
				AddTestScripts(new OEMCST_SMOKE());
				AddTestScripts(new OEMCTADR_SMOKE());
				AddTestScripts(new OEMDEF_SMOKE());
				AddTestScripts(new OEMINVC1_SMOKE());
				AddTestScripts(new OEMINVC2_SMOKE());
				AddTestScripts(new OEMISADR_SMOKE());
				AddTestScripts(new OEMISSU1_SMOKE());
				AddTestScripts(new OEMISSU2_SMOKE());
				AddTestScripts(new OEMNTSO1_SMOKE());
				AddTestScripts(new OEMNTSO2_SMOKE());
				AddTestScripts(new OEMPOPTS_SMOKE());
				AddTestScripts(new OEMPROJ_SMOKE());
				AddTestScripts(new OEMRFU_SMOKE());
				AddTestScripts(new OEMRREAS_SMOKE());
		           
        }
    }
}
