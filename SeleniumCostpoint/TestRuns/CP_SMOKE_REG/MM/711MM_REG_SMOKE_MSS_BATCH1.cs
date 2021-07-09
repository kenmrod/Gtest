using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;
using SeleniumCostpoint.Tests.CP_SMOKE.MM;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711MM_REG_SMOKE_MSS_BATCH1 : SeleniumTestRun
    {
        public CP711MM_REG_SMOKE_MSS_BATCH1(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGM14");
				AddTestScripts(new AOMCPPRM_SMOKE());
				AddTestScripts(new AOPBOM_SMOKE());
				AddTestScripts(new AOPCPIMO_SMOKE());
				AddTestScripts(new AOPCPMO_SMOKE());
				AddTestScripts(new AOPCPWC_SMOKE());
				AddTestScripts(new AOPEPAD_SMOKE());
				AddTestScripts(new AOPEPIA_SMOKE());
				AddTestScripts(new AOPEPITM_SMOKE());
				AddTestScripts(new AOPEPPAO_SMOKE());
				AddTestScripts(new AOPEPRC_SMOKE());
				AddTestScripts(new AOPEPRQE_SMOKE());
				AddTestScripts(new AOPEPVN_SMOKE());
				AddTestScripts(new AOPINTRN_SMOKE());
				AddTestScripts(new AOPITEM_SMOKE());
				AddTestScripts(new AOPQTV_SMOKE());
				AddTestScripts(new AOPRCPRE_SMOKE());
				AddTestScripts(new AOPRQPP_SMOKE());
				AddTestScripts(new AOPSCST_SMOKE());
				AddTestScripts(new AOPSOPP_SMOKE());
				AddTestScripts(new AOPUTLPO_SMOKE());
				AddTestScripts(new APRVEND_SMOKE());
				AddTestScripts(new APRVINFO_SMOKE());
				AddTestScripts(new ARMCUST_SMOKE());
				AddTestScripts(new ARRCUST_SMOKE());
				AddTestScripts(new BMMCID_SMOKE());
				AddTestScripts(new BMMDOCMD_SMOKE());
		           
        }
    }
}
