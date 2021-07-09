using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711MM_REG_SMOKE_MSS_BATCH4 : SeleniumTestRun
    {
        public CP711MM_REG_SMOKE_MSS_BATCH4(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGM14");
				AddTestScripts(new INMPLANT_SMOKE());
				AddTestScripts(new INMPORSV_SMOKE());
				AddTestScripts(new INMPROJ_SMOKE());
				AddTestScripts(new INMQTADJ_SMOKE());
				AddTestScripts(new INMREASA_SMOKE());
				AddTestScripts(new INMREASS_SMOKE());
				AddTestScripts(new INMRQST_SMOKE());
				AddTestScripts(new INMSCADJ_SMOKE());
				AddTestScripts(new INMSET_SMOKE());
				AddTestScripts(new INMSLSET_SMOKE());
				AddTestScripts(new INMSLUDL_SMOKE());
				AddTestScripts(new INMSRLT_SMOKE());
				AddTestScripts(new INMWACCT_SMOKE());
				AddTestScripts(new INMWHSEL_SMOKE());
				AddTestScripts(new INMWHSE_SMOKE());
				AddTestScripts(new INPEDJNL_SMOKE());
				AddTestScripts(new INPFY_SMOKE());
				AddTestScripts(new INPMSXFR_SMOKE());
				AddTestScripts(new INPPCABC_SMOKE());
				AddTestScripts(new INPPCDSC_SMOKE());
				AddTestScripts(new INPPHYS_SMOKE());
				AddTestScripts(new INPRECON_SMOKE());
				AddTestScripts(new INPREORD_SMOKE());
				AddTestScripts(new INPUID_SMOKE());
				AddTestScripts(new INQHSTPR_SMOKE());
				AddTestScripts(new INQPINV_SMOKE());
		           
        }
    }
}
