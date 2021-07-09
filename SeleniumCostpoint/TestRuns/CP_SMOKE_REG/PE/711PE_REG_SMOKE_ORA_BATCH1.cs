using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_REG_SMOKE_ORA_BATCH1 : SeleniumTestRun
    {
        public CP711PE_REG_SMOKE_ORA_BATCH1(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGO12");
				AddTestScripts(new AOMADP25_SMOKE());
				AddTestScripts(new AOMADPMP_SMOKE());
				AddTestScripts(new AOMCDCCN_SMOKE());
				AddTestScripts(new AOMESSAL_SMOKE());
				AddTestScripts(new AOMESSBE_SMOKE());
				AddTestScripts(new AOMESSCL_SMOKE());
				AddTestScripts(new AOMESSCS_SMOKE());
				AddTestScripts(new AOMESSGS_SMOKE());
				AddTestScripts(new AOMESSLE_SMOKE());
				AddTestScripts(new AOMESSRB_SMOKE());
				AddTestScripts(new AOMESSST_SMOKE());
				AddTestScripts(new AOMESSUF_SMOKE());
				AddTestScripts(new AOMSUEBP_SMOKE());
				AddTestScripts(new AOMSUSTP_SMOKE());
				AddTestScripts(new AOPADPTS_SMOKE());
				AddTestScripts(new AOPCDCTS_SMOKE());
				AddTestScripts(new AOPESSDB_SMOKE());
				AddTestScripts(new AOPESSPG_SMOKE());
				AddTestScripts(new AOPESSUD_SMOKE());
				AddTestScripts(new AOPESSUE_SMOKE());
				AddTestScripts(new AOPUTLDL_SMOKE());
				AddTestScripts(new AOPUTLEL_SMOKE());
				AddTestScripts(new AOPUTLTS_SMOKE());
				AddTestScripts(new HAMAPSET_SMOKE());
				AddTestScripts(new HAMCDATA_SMOKE());
				AddTestScripts(new HAMFEED_SMOKE());
				AddTestScripts(new HAMJBGRP_SMOKE());
				AddTestScripts(new HAMSET_SMOKE());
		           
        }
    }
}
