using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_REG_SMOKE_ORA_BATCH4 : SeleniumTestRun
    {
        public CP711PE_REG_SMOKE_ORA_BATCH4(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGO12");
				AddTestScripts(new HPMASTEP_SMOKE());
				AddTestScripts(new HPMAWD_SMOKE());
				AddTestScripts(new HPMCASE_SMOKE());
				AddTestScripts(new HPMCRSE_SMOKE());
				AddTestScripts(new HPMDEGRE_SMOKE());
				AddTestScripts(new HPMDOC_SMOKE());
				AddTestScripts(new HPMDPOS_SMOKE());
				AddTestScripts(new HPMDRUG_SMOKE());
				AddTestScripts(new HPMEAWD_SMOKE());
				AddTestScripts(new HPMEDOC_SMOKE());
				AddTestScripts(new HPMEDRUG_SMOKE());
				AddTestScripts(new HPMEDS_SMOKE());
				AddTestScripts(new HPMELIC_SMOKE());
				AddTestScripts(new HPMEMPEF_SMOKE());
				AddTestScripts(new HPMEPROP_SMOKE());
				AddTestScripts(new HPMESTAT_SMOKE());
				AddTestScripts(new HPMEVEH_SMOKE());
				AddTestScripts(new HPMFPOS_SMOKE());
				AddTestScripts(new HPMF_SMOKE());
				AddTestScripts(new HPMHRORG_00_SMOKE_PREREQ());
				AddTestScripts(new HPMHRORG_01_SMOKE());
				AddTestScripts(new HPMHRORG_02_SMOKE_POSTREQ());
				AddTestScripts(new HPMI9CD_SMOKE());
				AddTestScripts(new HPMI9DAT_SMOKE());
				AddTestScripts(new HPMINJ_SMOKE());
				AddTestScripts(new HPMINTID_SMOKE());
				AddTestScripts(new HPMPHOTO_SMOKE());
		           
        }
    }
}
