using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;
using SeleniumCostpoint.Tests.CP_SMOKE.PJ;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PJ_REG_SMOKE_ORA_BATCH1 : SeleniumTestRun
    {
        public CP711PJ_REG_SMOKE_ORA_BATCH1(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGO12");
				AddTestScripts(new AOMCBPYC_SMOKE());
				AddTestScripts(new AOMMICEC_SMOKE());
				AddTestScripts(new AOMMICOR_SMOKE());
				AddTestScripts(new AOMMICPJ_SMOKE());
				AddTestScripts(new AOMMICRS_SMOKE());
				AddTestScripts(new AOMPLMAP_SMOKE());
				AddTestScripts(new AOMPLNST_SMOKE());
				AddTestScripts(new AOPCBLAB_SMOKE());
				AddTestScripts(new AOPMICDN_SMOKE());
				AddTestScripts(new AOPPLNCP_SMOKE());
				AddTestScripts(new AOPPPLAB_SMOKE());
				AddTestScripts(new BLMADDR_SMOKE());
				AddTestScripts(new BLMADSC_SMOKE());
				AddTestScripts(new BLMBFRM_SMOKE());
				AddTestScripts(new BLMBHIST_SMOKE());
				AddTestScripts(new BLMBLCYC_SMOKE());
				AddTestScripts(new BLMCASH_SMOKE());
				AddTestScripts(new BLMCDSC_SMOKE());
				AddTestScripts(new BLMCLOSE_SMOKE());
				AddTestScripts(new BLMCPBIL_SMOKE());
				AddTestScripts(new BLMCTADR_SMOKE());
				AddTestScripts(new BLMEDIST_SMOKE());
				AddTestScripts(new BLMEDI_SMOKE());
				AddTestScripts(new BLMEUBRC_SMOKE());
				AddTestScripts(new BLMGBILL_SMOKE());
				AddTestScripts(new BLMGPO_SMOKE());
				AddTestScripts(new BLMINFO_SMOKE());
				AddTestScripts(new BLMMAB_SMOKE());
				AddTestScripts(new BLMMNBIL_SMOKE());
				AddTestScripts(new BLMMPCB_SMOKE());
				AddTestScripts(new BLMOPEN_SMOKE());
				AddTestScripts(new BLMOTH_SMOKE());
				AddTestScripts(new BLMPBS_SMOKE());
				AddTestScripts(new BLMPCLOS_SMOKE());
				AddTestScripts(new BLMPDSC_SMOKE());
				AddTestScripts(new BLMPJPRD_SMOKE());
				AddTestScripts(new BLMPROGP_SMOKE());
				AddTestScripts(new BLMSETNG_SMOKE());
				AddTestScripts(new BLMSHFRM_SMOKE());
				AddTestScripts(new BLMSTTXT_SMOKE());
				AddTestScripts(new BLMSUBPP_SMOKE());
		           
        }
    }
}
