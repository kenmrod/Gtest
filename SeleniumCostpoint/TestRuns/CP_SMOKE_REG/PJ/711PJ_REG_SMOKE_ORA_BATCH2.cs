using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PJ_REG_SMOKE_ORA_BATCH2 : SeleniumTestRun
    {
        public CP711PJ_REG_SMOKE_ORA_BATCH2(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGO12");
				AddTestScripts(new BLMTAXAL_SMOKE());
				AddTestScripts(new BLMTAXCD_SMOKE());
				AddTestScripts(new BLMUBRC_SMOKE());
				AddTestScripts(new BLMUHIST_SMOKE());
				AddTestScripts(new BLMUSAGE_SMOKE());
				AddTestScripts(new BLMUSGRP_SMOKE());
				AddTestScripts(new BLMWAWF_SMOKE());
				AddTestScripts(new BLMWBS_SMOKE());
				AddTestScripts(new BLMWHCD_SMOKE());
				AddTestScripts(new BLPACRN_SMOKE());
				AddTestScripts(new BLPAOBD_SMOKE());
				AddTestScripts(new BLPCASHB_SMOKE());
				AddTestScripts(new BLPCUSPD_SMOKE());
				AddTestScripts(new BLPEDI_SMOKE());
				AddTestScripts(new BLPGBILL_SMOKE());
				AddTestScripts(new BLPGEN_SMOKE());
				AddTestScripts(new BLPLMTRN_SMOKE());
				AddTestScripts(new BLPMANB_SMOKE());
				AddTestScripts(new BLPMPCB_SMOKE());
				AddTestScripts(new BLPOBDFC_SMOKE());
				AddTestScripts(new BLPPOBD_SMOKE());
				AddTestScripts(new BLPPROGP_SMOKE());
				AddTestScripts(new BLPPROJB_SMOKE());
				AddTestScripts(new BLPPRO_SMOKE());
				AddTestScripts(new BLPRBIL_SMOKE());
				AddTestScripts(new BLPREVB_SMOKE());
				AddTestScripts(new BLPSELCT_SMOKE());
				AddTestScripts(new BLPSUBPP_SMOKE());
				AddTestScripts(new BLPUMB_SMOKE());
				AddTestScripts(new BLPUNBIL_SMOKE());
				AddTestScripts(new BLPUPCUR_SMOKE());
				AddTestScripts(new BLPUPOBD_SMOKE());
				AddTestScripts(new BLPUPPLC_SMOKE());
				AddTestScripts(new BLPUPTAX_SMOKE());
				AddTestScripts(new BLPUPUU_SMOKE());
				AddTestScripts(new BLPUSAGE_SMOKE());
				AddTestScripts(new BLPWAWF_SMOKE());
				AddTestScripts(new BLPWHCD_SMOKE());
				AddTestScripts(new BLQSTDHS_SMOKE());
				AddTestScripts(new BLR1034_SMOKE());
				AddTestScripts(new BLRACRN_SMOKE());
				AddTestScripts(new BLRBREG_SMOKE());
		           
        }
    }
}
