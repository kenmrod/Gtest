using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PJ_SMOKE_MSS_BATCH6 : SeleniumTestRun
    {
        public CP711PJ_SMOKE_MSS_BATCH6(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCM16AE");
				AddTestScripts(new PJPABJP_SMOKE());
				AddTestScripts(new PJPAIPRJ_SMOKE());
				AddTestScripts(new PJPALBUD_SMOKE());
				AddTestScripts(new PJPALCST_SMOKE());
				AddTestScripts(new PJPAPPIC_SMOKE());
				AddTestScripts(new PJPBBCR_SMOKE());
				AddTestScripts(new PJPBLDRA_SMOKE());
				AddTestScripts(new PJPBREAL_SMOKE());
				AddTestScripts(new PJPCHORG_SMOKE());
				AddTestScripts(new PJPCKAO_SMOKE());
				AddTestScripts(new PJPCKSEG_SMOKE());
				AddTestScripts(new PJPCKUN_SMOKE());
				AddTestScripts(new PJPCOGS_SMOKE());
				AddTestScripts(new PJPCOMPL_SMOKE());
				AddTestScripts(new PJPCOMPP_SMOKE());
				AddTestScripts(new PJPCOMPR_SMOKE());
				AddTestScripts(new PJPCOPY_SMOKE());
				AddTestScripts(new PJPCRETC_SMOKE());
				AddTestScripts(new PJPCRLNK_SMOKE());
				AddTestScripts(new PJPCRRPT_SMOKE());
				AddTestScripts(new PJPCSSRU_SMOKE());
				AddTestScripts(new PJPCSSR_SMOKE());
				AddTestScripts(new PJPCSTR_SMOKE());
				AddTestScripts(new PJPDISIN_SMOKE());
				AddTestScripts(new PJPETCR_SMOKE());
				AddTestScripts(new PJPETCU_SMOKE());
				AddTestScripts(new PJPEXCPT_SMOKE());
				AddTestScripts(new PJPFIXIN_SMOKE());
				AddTestScripts(new PJPGOAL_SMOKE());
				AddTestScripts(new PJPGPLAB_SMOKE());
				AddTestScripts(new PJPIMPPL_SMOKE());
				AddTestScripts(new PJPINBRD_SMOKE());
				AddTestScripts(new PJPLDRAT_SMOKE());
				AddTestScripts(new PJPMADD_SMOKE());
				AddTestScripts(new PJPMBRT_SMOKE());
				AddTestScripts(new PJPMJALC_SMOKE());
				AddTestScripts(new PJPMJAS_SMOKE());
				AddTestScripts(new PJPOBT_SMOKE());
				AddTestScripts(new PJPPARMS_SMOKE());
				AddTestScripts(new PJPPERF_SMOKE());
				AddTestScripts(new PJPPLSUM_SMOKE());
		           
        }
    }
}
