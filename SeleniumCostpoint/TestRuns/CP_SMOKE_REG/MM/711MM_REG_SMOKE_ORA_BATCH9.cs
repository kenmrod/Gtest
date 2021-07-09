using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711MM_REG_SMOKE_ORA_BATCH9 : SeleniumTestRun
    {
        public CP711MM_REG_SMOKE_ORA_BATCH9(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGO12");
				AddTestScripts(new PCMINSP_SMOKE());
				AddTestScripts(new PCMMCOST_SMOKE());
				AddTestScripts(new PCMMEXPD_SMOKE());
				AddTestScripts(new PCMMOISS_SMOKE());
				AddTestScripts(new PCMMOLAB_SMOKE());
				AddTestScripts(new PCMMOMNT_SMOKE());
				AddTestScripts(new PCMNETG_SMOKE());
				AddTestScripts(new PCMPLNR_SMOKE());
				AddTestScripts(new PCMPRTOP_SMOKE());
				AddTestScripts(new PCMREJCD_SMOKE());
				AddTestScripts(new PCMRELMO_SMOKE());
				AddTestScripts(new PCMSCRQ_SMOKE());
				AddTestScripts(new PCMSET_SMOKE());
				AddTestScripts(new PCMSFCAL_SMOKE());
				AddTestScripts(new PCMSUPV_SMOKE());
				AddTestScripts(new PCPMRR_SMOKE());
				AddTestScripts(new PCPWIPV_SMOKE());
				AddTestScripts(new PCQMOST_SMOKE());
				AddTestScripts(new PCRMOCST_SMOKE());
				AddTestScripts(new PCRMODC_SMOKE());
				AddTestScripts(new PCRSHRT_SMOKE());
				AddTestScripts(new PDMALT_SMOKE());
				AddTestScripts(new PDMCOMCD_SMOKE());
				AddTestScripts(new PDMCOST_SMOKE());
				AddTestScripts(new PDMGOODS_SMOKE());
				AddTestScripts(new PDMIBILL_SMOKE());
				AddTestScripts(new PDMINDCL_SMOKE());
		           
        }
    }
}
