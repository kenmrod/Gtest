using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;
using SeleniumCostpoint.Tests.CP_SMOKE.AC;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711AC_REG_SMOKE_ORA_BATCH3 : SeleniumTestRun
    {
        public CP711AC_REG_SMOKE_ORA_BATCH3(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGO12");
				AddTestScripts(new ARPPURCR_SMOKE());
				AddTestScripts(new ARPRATE_SMOKE());
				AddTestScripts(new ARPRESCR_SMOKE());
				AddTestScripts(new ARRAGED_SMOKE());
				AddTestScripts(new ARRCRREG_SMOKE());
				AddTestScripts(new ARRCR_SMOKE());
				AddTestScripts(new ARRCUST_SMOKE());
				AddTestScripts(new ARRHIST_SMOKE());
				AddTestScripts(new ARRLWPRT_SMOKE());
				AddTestScripts(new ARRSTMT_SMOKE());
				AddTestScripts(new BLMPCLOS_SMOKE());
				AddTestScripts(new CMMCFA_SMOKE());
				AddTestScripts(new CMMCFT_SMOKE());
				AddTestScripts(new CMMCOBKI_SMOKE());
				AddTestScripts(new CMMECF_SMOKE());
				AddTestScripts(new CMMIB_SMOKE());
				AddTestScripts(new CMPCCF_SMOKE());
				AddTestScripts(new CMRCF_SMOKE());
				AddTestScripts(new COMEAO_SMOKE());
				AddTestScripts(new COMLNKLC_SMOKE());
				AddTestScripts(new COMLOC_SMOKE());
				AddTestScripts(new COMMAP_SMOKE());
				AddTestScripts(new COMSETNG_SMOKE());
				AddTestScripts(new COMSUSP_SMOKE());
				AddTestScripts(new COMXFRHS_SMOKE());
				AddTestScripts(new COPELIM_SMOKE());
				AddTestScripts(new COPENTRY_SMOKE());
				AddTestScripts(new COPEXPPJ_SMOKE());
				AddTestScripts(new COPIMPRT_SMOKE());
				AddTestScripts(new COPUPBB_SMOKE());
				AddTestScripts(new COPUPLD_SMOKE());
				AddTestScripts(new FAMAACCT_SMOKE());
				AddTestScripts(new FAMACTED_SMOKE());
				AddTestScripts(new FAMADACT_SMOKE());
				AddTestScripts(new FAMALBL_SMOKE());
				AddTestScripts(new FAMANC_SMOKE());
				AddTestScripts(new FAMASSET_SMOKE());
				AddTestScripts(new FAMATCS_SMOKE());
				AddTestScripts(new FAMBCEXC_SMOKE());
				AddTestScripts(new FAMCLASS_SMOKE());
				AddTestScripts(new FAMDEACT_SMOKE());
				AddTestScripts(new FAMDEPRM_SMOKE());
				AddTestScripts(new FAMDISP_SMOKE());
				AddTestScripts(new FAMDISTY_SMOKE());
				AddTestScripts(new FAMFY_SMOKE());
				AddTestScripts(new FAMGCA_SMOKE());
				AddTestScripts(new FAMGCTU_SMOKE());
				AddTestScripts(new FAMGCT_SMOKE());
				AddTestScripts(new FAMGCU_SMOKE());
				AddTestScripts(new FAMINT_SMOKE());
				AddTestScripts(new FAMINV_SMOKE());
				AddTestScripts(new FAMLOC1_SMOKE());
				AddTestScripts(new FAMLOC2_SMOKE());
		           
        }
    }
}
