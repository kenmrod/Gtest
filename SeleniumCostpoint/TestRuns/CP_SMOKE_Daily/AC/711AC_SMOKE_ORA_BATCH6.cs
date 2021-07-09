using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711AC_SMOKE_ORA_BATCH6 : SeleniumTestRun
    {
        public CP711AC_SMOKE_ORA_BATCH6(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCO12AE2");
				AddTestScripts(new GLMCURR__SMOKE());
				AddTestScripts(new GLMCYC_SMOKE());
				AddTestScripts(new GLMFS_SMOKE());
				AddTestScripts(new GLMFY_SMOKE());
				AddTestScripts(new GLMJEA_SMOKE());
				AddTestScripts(new GLMJENUM_SMOKE());
				AddTestScripts(new GLMJE_SMOKE());
				AddTestScripts(new GLMLOA_SMOKE());
				AddTestScripts(new GLMLREO_SMOKE());
				AddTestScripts(new GLMORACT_SMOKE());
				AddTestScripts(new GLMORLAB_SMOKE());
				AddTestScripts(new GLMORMNT_SMOKE());
				AddTestScripts(new GLMORSET_SMOKE());
				AddTestScripts(new GLMORUDF_SMOKE());
				AddTestScripts(new GLMPD_SMOKE());
				AddTestScripts(new GLMPJBEG_SMOKE());
				AddTestScripts(new GLMPJBFY_SMOKE());
				AddTestScripts(new GLMRECTM_SMOKE());
				AddTestScripts(new GLMREO_SMOKE());
				AddTestScripts(new GLMRESET_SMOKE());
				AddTestScripts(new GLMRE_SMOKE());
				AddTestScripts(new GLMRNBEG_SMOKE());
				AddTestScripts(new GLMRNSET_SMOKE());
				AddTestScripts(new GLMRN_SMOKE());
				AddTestScripts(new GLMROA_SMOKE());
				AddTestScripts(new GLMSETA_SMOKE());
				AddTestScripts(new GLMSETNG_SMOKE());
				AddTestScripts(new GLMSTMT_SMOKE());
				AddTestScripts(new GLMSUBPD_SMOKE());
				AddTestScripts(new GLMTAXA_SMOKE());
				AddTestScripts(new GLMTAXT_SMOKE());
				AddTestScripts(new GLPAJE_SMOKE());
				AddTestScripts(new GLPBATCH_SMOKE());
				AddTestScripts(new GLPBKPRG_SMOKE());
				AddTestScripts(new GLPBKTRN_SMOKE());
				AddTestScripts(new GLPBSREV_SMOKE());
				AddTestScripts(new GLPCFLOW_SMOKE());
				AddTestScripts(new GLPCLOSE_SMOKE());
				AddTestScripts(new GLPCRRPT_SMOKE());
				AddTestScripts(new GLPDEFER_SMOKE());
				AddTestScripts(new GLPINTER_SMOKE());
				AddTestScripts(new GLPJEPRG_SMOKE());
				AddTestScripts(new GLPJE_SMOKE());
				AddTestScripts(new GLPMCBAJ_SMOKE());
				AddTestScripts(new GLPPINTR_SMOKE());
				AddTestScripts(new GLPPTER_SMOKE());
				AddTestScripts(new GLPREC_SMOKE());
				AddTestScripts(new GLPREVJE_SMOKE());
				AddTestScripts(new GLPTOOL1_SMOKE());
				AddTestScripts(new GLPTUPD_SMOKE());
				AddTestScripts(new GLPUACCT_SMOKE());
				AddTestScripts(new GLPUPBB_SMOKE());
		           
        }
    }
}
