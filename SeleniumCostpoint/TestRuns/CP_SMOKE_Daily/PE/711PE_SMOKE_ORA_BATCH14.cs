using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_SMOKE_ORA_BATCH14 : SeleniumTestRun
    {
        public CP711PE_SMOKE_ORA_BATCH14(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCO12AE2");
				AddTestScripts(new PRQEDED_SMOKE());
				AddTestScripts(new PRQEHIS_SMOKE());
				AddTestScripts(new PRQEINFO_SMOKE());
				AddTestScripts(new PRQERF_SMOKE());
				AddTestScripts(new PRQETAX_SMOKE());
				AddTestScripts(new PRQPTF_SMOKE());
				AddTestScripts(new PRRBANK_SMOKE());
				AddTestScripts(new PRRCERT_SMOKE());
				AddTestScripts(new PRRDDB_SMOKE());
				AddTestScripts(new PRRDEDS_SMOKE());
				AddTestScripts(new PRREBT_SMOKE());
				AddTestScripts(new PRRERF_SMOKE());
				AddTestScripts(new PRRFDTAX_SMOKE());
				AddTestScripts(new PRRFICA_SMOKE());
				AddTestScripts(new PRRLCWH_SMOKE());
				AddTestScripts(new PRRMBEN_00_SMOKE_PREREQ());
				AddTestScripts(new PRRMBEN_01_SMOKE());
				AddTestScripts(new PRRMBEN_02_SMOKE_POSTREQ());
				AddTestScripts(new PRRPTF_SMOKE());
				AddTestScripts(new PRRSTTAX_SMOKE());
				AddTestScripts(new PRRSTWH_SMOKE());
				AddTestScripts(new PRRVCHR_SMOKE());
				AddTestScripts(new PRRW2R_SMOKE());
				AddTestScripts(new PRRW2_SMOKE());
				AddTestScripts(new PRRWCTAX_SMOKE());
				AddTestScripts(new PRRWKST_SMOKE());
		           
        }
    }
}
