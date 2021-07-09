using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_REG_SMOKE_MSS_BATCH8 : SeleniumTestRun
    {
        public CP711PE_REG_SMOKE_MSS_BATCH8(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGM14");
				AddTestScripts(new LDMELV_SMOKE());
				AddTestScripts(new LDMEPD_SMOKE());
				AddTestScripts(new LDMFCEIL_00_SMOKE_PREREQ());
				AddTestScripts(new LDMFCEIL_01_SMOKE());
				AddTestScripts(new LDMFCEIL_02_SMOKE_POSTREQ());
				AddTestScripts(new LDMFRG_00_SMOKE_PREREQ());
				AddTestScripts(new LDMFRG_01_SMOKE());
				AddTestScripts(new LDMFRG_02_SMOKE_POSTREQ());
				AddTestScripts(new LDMGLC_SMOKE());
				AddTestScripts(new LDMLABRT_SMOKE());
				AddTestScripts(new LDMLAD_SMOKE());
				AddTestScripts(new LDMLBB_SMOKE());
				AddTestScripts(new LDMLCTR_SMOKE());
				AddTestScripts(new LDMLEAVE_SMOKE());
				AddTestScripts(new LDMLEDIT_SMOKE());
				AddTestScripts(new LDMLLOC_SMOKE());
				AddTestScripts(new LDMLSET_SMOKE());
				AddTestScripts(new LDMLVMOD_SMOKE());
				AddTestScripts(new LDMLVPD_SMOKE());
				AddTestScripts(new LDMLVTAB_SMOKE());
				AddTestScripts(new LDMLVTP_SMOKE());
				AddTestScripts(new LDMMAA_SMOKE());
				AddTestScripts(new LDMOTLOC_SMOKE());
				AddTestScripts(new LDMOTP_SMOKE());
				AddTestScripts(new LDMOTST_SMOKE());
				AddTestScripts(new LDMPAYTP_SMOKE());
				AddTestScripts(new LDMPAYTR_SMOKE());
				AddTestScripts(new LDMPD_SMOKE());
		           
        }
    }
}
