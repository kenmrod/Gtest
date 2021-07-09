using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;
using SeleniumCostpoint.Tests.CP_SMOKE.PJ;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PJ_REG_SMOKE_ORA_BATCH7 : SeleniumTestRun
    {
        public CP711PJ_REG_SMOKE_ORA_BATCH7(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGO12");
				AddTestScripts(new PJPPOP_SMOKE());
				AddTestScripts(new PJPPOSTP_SMOKE());
				AddTestScripts(new PJPPOSTR_SMOKE());
				AddTestScripts(new PJPPREP_SMOKE());
				AddTestScripts(new PJPPREV_SMOKE());
				AddTestScripts(new PJPPTRAN_SMOKE());
				AddTestScripts(new PJPPURGE_SMOKE());
				AddTestScripts(new PJPPUR_SMOKE());
				AddTestScripts(new PJPQPREP_SMOKE());
				AddTestScripts(new PJPREALL_SMOKE());
				AddTestScripts(new PJPSGOAL_SMOKE());
				AddTestScripts(new PJPSTLVL_SMOKE());
				AddTestScripts(new PJPSYNCH_SMOKE());
				AddTestScripts(new PJPTOTU_SMOKE());
				AddTestScripts(new PJPUPLAB_SMOKE());
				AddTestScripts(new PJPUPPOA_SMOKE());
				AddTestScripts(new PJPUPPSR_SMOKE());
				AddTestScripts(new PJPUPPY_SMOKE());
				AddTestScripts(new PJPUPTHT_SMOKE());
				AddTestScripts(new PJPUPVAL_SMOKE());
				AddTestScripts(new PJQETC_SMOKE());
				AddTestScripts(new PJQPROJL_SMOKE());
				AddTestScripts(new PJQPROJP_SMOKE());
				AddTestScripts(new PJQPROJ_SMOKE());
				AddTestScripts(new PJR533RP_SMOKE());
				AddTestScripts(new PJRALJNL_SMOKE());
				AddTestScripts(new PJRBASIC_SMOKE());
				AddTestScripts(new PJRCSSR_SMOKE());
				AddTestScripts(new PJRETCH_SMOKE());
				AddTestScripts(new PJRETC_SMOKE());
				AddTestScripts(new PJRFORM_SMOKE());
				AddTestScripts(new PJRLABSM_SMOKE());
				AddTestScripts(new PJRNLD_SMOKE());
				AddTestScripts(new PJRORCST_SMOKE());
				AddTestScripts(new PJRPAG_SMOKE());
				AddTestScripts(new PJRPOOL_SMOKE());
				AddTestScripts(new PJRPRLIS_SMOKE());
				AddTestScripts(new PJRPROJ_SMOKE());
				AddTestScripts(new PJRPWF_SMOKE());
				AddTestScripts(new PJRREVW_SMOKE());
				AddTestScripts(new PJRREV_SMOKE());
				AddTestScripts(new PJRSCTR_SMOKE());
				AddTestScripts(new PJRSETUP_SMOKE());
				AddTestScripts(new PJRSVCST_SMOKE());
				AddTestScripts(new PJRTMA_SMOKE());
				AddTestScripts(new POPCOMM_SMOKE());
		           
        }
    }
}
