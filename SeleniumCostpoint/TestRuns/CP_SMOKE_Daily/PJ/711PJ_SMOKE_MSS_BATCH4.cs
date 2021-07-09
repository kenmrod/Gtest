using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PJ_SMOKE_MSS_BATCH4 : SeleniumTestRun
    {
        public CP711PJ_SMOKE_MSS_BATCH4(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCM16AE");
				AddTestScripts(new PJM533PD_SMOKE());
				AddTestScripts(new PJM533PJ_SMOKE());
				AddTestScripts(new PJMACGRP_SMOKE());
				AddTestScripts(new PJMAGLC_SMOKE());
				AddTestScripts(new PJMALGRP_SMOKE());
				AddTestScripts(new PJMALJNL_SMOKE());
				AddTestScripts(new PJMALTRP_SMOKE());
				AddTestScripts(new PJMAPLC_SMOKE());
				AddTestScripts(new PJMBASE_SMOKE());
				AddTestScripts(new PJMBASIC_SMOKE());
				AddTestScripts(new PJMBCEIL_SMOKE());
				AddTestScripts(new PJMBDGLC_SMOKE());
				AddTestScripts(new PJMBDPER_SMOKE());
				AddTestScripts(new PJMBDPLC_SMOKE());
				AddTestScripts(new PJMBDREV_SMOKE());
				AddTestScripts(new PJMBDTOT_SMOKE());
				AddTestScripts(new PJMBLIR_SMOKE());
				AddTestScripts(new PJMBUDCO_SMOKE());
				AddTestScripts(new PJMBURDT_SMOKE());
				AddTestScripts(new PJMBURFE_SMOKE());
				AddTestScripts(new PJMCEIL_SMOKE());
				AddTestScripts(new PJMCLIN_SMOKE());
				AddTestScripts(new PJMCOGS_SMOKE());
				AddTestScripts(new PJMCOSTA_SMOKE());
				AddTestScripts(new PJMCOST_SMOKE());
				AddTestScripts(new PJMCSSRB_SMOKE());
				AddTestScripts(new PJMCSSR_SMOKE());
				AddTestScripts(new PJMCSTFE_SMOKE());
				AddTestScripts(new PJMDELIV_SMOKE());
				AddTestScripts(new PJMECEIL_SMOKE());
				AddTestScripts(new PJMETCD_SMOKE());
				AddTestScripts(new PJMGLCE_SMOKE());
				AddTestScripts(new PJMGLCP_SMOKE());
				AddTestScripts(new PJMGOVT_SMOKE());
				AddTestScripts(new PJMHCEIL_SMOKE());
				AddTestScripts(new PJMLIB_SMOKE());
				AddTestScripts(new PJMMJAS_SMOKE());
				AddTestScripts(new PJMMJCHS_SMOKE());
				AddTestScripts(new PJMMJLHS_SMOKE());
				AddTestScripts(new PJMMLPAO_SMOKE());
				AddTestScripts(new PJMMMO_SMOKE());
				AddTestScripts(new PJMMOD_SMOKE());
		           
        }
    }
}
