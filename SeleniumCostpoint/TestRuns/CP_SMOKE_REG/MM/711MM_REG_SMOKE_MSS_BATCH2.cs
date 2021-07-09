using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711MM_REG_SMOKE_MSS_BATCH2 : SeleniumTestRun
    {
        public CP711MM_REG_SMOKE_MSS_BATCH2(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGM14");
				AddTestScripts(new BMMDOCSZ_SMOKE());
				AddTestScripts(new BMMDOCTP_SMOKE());
				AddTestScripts(new BMMEBOM1_SMOKE());
				AddTestScripts(new BMMEBOM2_SMOKE());
				AddTestScripts(new BMMEICN_SMOKE());
				AddTestScripts(new BMMERELS_SMOKE());
				AddTestScripts(new BMMMBOM1_SMOKE());
				AddTestScripts(new BMMMBOM2_SMOKE());
				AddTestScripts(new BMMMDOC_SMOKE());
				AddTestScripts(new BMMMNTG_SMOKE());
				AddTestScripts(new BMMMRELS_SMOKE());
				AddTestScripts(new BMMRDOC_SMOKE());
				AddTestScripts(new BMMSET_SMOKE());
				AddTestScripts(new BMPCOPY_SMOKE());
				AddTestScripts(new BMPCOST_SMOKE());
				AddTestScripts(new BMPMCC_SMOKE());
				AddTestScripts(new BMPTOOL1_SMOKE());
				AddTestScripts(new BMPTOOL2_SMOKE());
				AddTestScripts(new BMQSMLB_SMOKE());
				AddTestScripts(new BMQWU_SMOKE());
				AddTestScripts(new BMRCOMP_SMOKE());
				AddTestScripts(new BMRSLMLB_SMOKE());
				AddTestScripts(new BMRSUMBM_SMOKE());
				AddTestScripts(new BMRWU_SMOKE());
				AddTestScripts(new ECMAMAIN_SMOKE());
		           
        }
    }
}
