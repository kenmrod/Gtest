using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;
using SeleniumCostpoint.Tests.CP_SMOKE.MM;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711MM_SMOKE_MSS_BATCH11 : SeleniumTestRun
    {
        public CP711MM_SMOKE_MSS_BATCH11(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCM16AE");
				AddTestScripts(new PDRITEX_SMOKE());
				AddTestScripts(new PDRMAL_SMOKE());
				AddTestScripts(new PDRMCAT_SMOKE());
				AddTestScripts(new PDRPML_SMOKE());
				AddTestScripts(new PDRPPE_SMOKE());
				AddTestScripts(new PDRPPRJ_SMOKE());
				AddTestScripts(new PDRPSUB_SMOKE());
				AddTestScripts(new POMBRNCH_SMOKE());
				AddTestScripts(new POMBUY_SMOKE());
				AddTestScripts(new POMCHNG_SMOKE());
				AddTestScripts(new POMEXPD_SMOKE());
				AddTestScripts(new POMEXPN_SMOKE());
				AddTestScripts(new POMLCHRG_SMOKE());
				AddTestScripts(new POMMAIN_SMOKE());
				AddTestScripts(new POMPOPTS_SMOKE());
				AddTestScripts(new POMRELS_SMOKE());
				AddTestScripts(new POMSCST_SMOKE());
				AddTestScripts(new POMSET_SMOKE());
				AddTestScripts(new POMSHIP_SMOKE());
				AddTestScripts(new POMSTAT_SMOKE());
				AddTestScripts(new POPARCH_SMOKE());
				AddTestScripts(new POPCOMM_SMOKE());
				AddTestScripts(new POPRECON_SMOKE());
				AddTestScripts(new POQCHNG_SMOKE());
				AddTestScripts(new POQCOMM_SMOKE());
				AddTestScripts(new POQITEM_SMOKE());
				AddTestScripts(new POQSTAT_SMOKE());
				AddTestScripts(new PORACTV_SMOKE());
				AddTestScripts(new POREXPD_SMOKE());
				AddTestScripts(new PORPCO_SMOKE());
		           
        }
    }
}
