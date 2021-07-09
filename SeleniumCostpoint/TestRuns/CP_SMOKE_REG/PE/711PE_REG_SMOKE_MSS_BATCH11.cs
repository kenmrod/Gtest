using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_REG_SMOKE_MSS_BATCH11 : SeleniumTestRun
    {
        public CP711PE_REG_SMOKE_MSS_BATCH11(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGM14");
				AddTestScripts(new LDRESET_SMOKE());
				AddTestScripts(new LDRFLSA_SMOKE());
				AddTestScripts(new LDRLEDIT_SMOKE());
				AddTestScripts(new LDRLSTAT_SMOKE());
				AddTestScripts(new LDRLUR_SMOKE());
				AddTestScripts(new LDRLVR_SMOKE());
				AddTestScripts(new LDRMIS_SMOKE());
				AddTestScripts(new LDRTEDIT_SMOKE());
				AddTestScripts(new LDRTHFR_SMOKE());
				AddTestScripts(new PRMCKSET_SMOKE());
				AddTestScripts(new PRMCOURT_SMOKE());
				AddTestScripts(new PRMCSBI_SMOKE());
				AddTestScripts(new PRMDDB_SMOKE());
				AddTestScripts(new PRMDDC_SMOKE());
				AddTestScripts(new PRMDEDSC_SMOKE());
				AddTestScripts(new PRMECNT_SMOKE());
				AddTestScripts(new PRMEDED_SMOKE());
				AddTestScripts(new PRMEGARN_SMOKE());
				AddTestScripts(new PRMEIC_SMOKE());
				AddTestScripts(new PRMERF_SMOKE());
				AddTestScripts(new PRMETAX_SMOKE());
				AddTestScripts(new PRMEXTAX_SMOKE());
				AddTestScripts(new PRMFLVY_SMOKE());
				AddTestScripts(new PRMFTI_SMOKE());
				AddTestScripts(new PRMFTT_SMOKE());
				AddTestScripts(new PRMLSD_SMOKE());
				AddTestScripts(new PRMLTI_SMOKE());
		           
        }
    }
}
