using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711AC_REG_SMOKE_MSS_BATCH4 : SeleniumTestRun
    {
        public CP711AC_REG_SMOKE_MSS_BATCH4(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGM14");
				AddTestScripts(new FAMLOC3_SMOKE());
				AddTestScripts(new FAMLOCGP_SMOKE());
				AddTestScripts(new FAMMNT_SMOKE());
				AddTestScripts(new FAMPAD_SMOKE());
				AddTestScripts(new FAMPAP_SMOKE());
				AddTestScripts(new FAMPRD_SMOKE());
				AddTestScripts(new FAMPROPT_SMOKE());
				AddTestScripts(new FAMSACCT_SMOKE());
				AddTestScripts(new FAMSCOST_SMOKE());
				AddTestScripts(new FAMSDESC_SMOKE());
				AddTestScripts(new FAMSDISP_SMOKE());
				AddTestScripts(new FAMSFYPD_SMOKE());
				AddTestScripts(new FAMSGLBK_SMOKE());
				AddTestScripts(new FAMSGOVT_SMOKE());
				AddTestScripts(new FAMSLOC_SMOKE());
				AddTestScripts(new FAMSOTBK_SMOKE());
				AddTestScripts(new FAMSPOST_SMOKE());
				AddTestScripts(new FAMSPO_SMOKE());
				AddTestScripts(new FAMSUBCL_SMOKE());
				AddTestScripts(new FAMSYSWP_SMOKE());
				AddTestScripts(new FAMTEMPL_SMOKE());
				AddTestScripts(new FAMTRLBL_SMOKE());
				AddTestScripts(new FAMTRNS_SMOKE());
				AddTestScripts(new FAMTRT_SMOKE());
				AddTestScripts(new FAMUDAST_SMOKE());
				AddTestScripts(new FAMUDLBL_SMOKE());
				AddTestScripts(new FAMUDTPL_SMOKE());
				AddTestScripts(new FAMUMNT_SMOKE());
				AddTestScripts(new FAPACAST_SMOKE());
				AddTestScripts(new FAPAEXP_SMOKE());
				AddTestScripts(new FAPATRNS_SMOKE());
				AddTestScripts(new FAPBCLOC_SMOKE());
				AddTestScripts(new FAPCDEPR_SMOKE());
				AddTestScripts(new FAPCRDSP_SMOKE());
				AddTestScripts(new FAPCRINT_SMOKE());
				AddTestScripts(new FAPCRMNT_SMOKE());
				AddTestScripts(new FAPCRTRT_SMOKE());
				AddTestScripts(new FAPDEXP_SMOKE());
				AddTestScripts(new FAPDISP_SMOKE());
				AddTestScripts(new FAPFAJNL_SMOKE());
				AddTestScripts(new FAPFYPD_SMOKE());
				AddTestScripts(new FAPINV_SMOKE());
				AddTestScripts(new FAPMNT_SMOKE());
				AddTestScripts(new FAPPDCLS_SMOKE());
				AddTestScripts(new FAPPDE_SMOKE());
				AddTestScripts(new FAPPGTD_SMOKE());
				AddTestScripts(new FAPPREP_SMOKE());
				AddTestScripts(new FAPPRGAI__SMOKE());
				AddTestScripts(new FAPPRGAL_SMOKE());
				AddTestScripts(new FAPPRGOB_SMOKE());
				AddTestScripts(new FAPRPOST_SMOKE());
				AddTestScripts(new FAPTOOL1_SMOKE());
				AddTestScripts(new FAPTOOL2_SMOKE());
		           
        }
    }
}
