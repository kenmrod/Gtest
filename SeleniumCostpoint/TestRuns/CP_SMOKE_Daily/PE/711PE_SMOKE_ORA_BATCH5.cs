using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_SMOKE_ORA_BATCH5 : SeleniumTestRun
    {
        public CP711PE_SMOKE_ORA_BATCH5(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCO12AE2");
				AddTestScripts(new HPMPROF_SMOKE());
				AddTestScripts(new HPMPROP_SMOKE());
				AddTestScripts(new HPMREQA_SMOKE());
				AddTestScripts(new HPMREQR_SMOKE());
				AddTestScripts(new HPMSECID_SMOKE());
				AddTestScripts(new HPMSET_SMOKE());
				AddTestScripts(new HPMSKILL_SMOKE());
				AddTestScripts(new HPMSLVL_SMOKE());
				AddTestScripts(new HPMSTUDY_SMOKE());
				AddTestScripts(new HPMTRAIN_SMOKE());
				AddTestScripts(new HPMTRNL_SMOKE());
				AddTestScripts(new HPMTRNPS_SMOKE());
				AddTestScripts(new HPMTRNS_SMOKE());
				AddTestScripts(new HPMVEH_SMOKE());
				AddTestScripts(new HPMWCFR_SMOKE());
				AddTestScripts(new HPPAWD_SMOKE());
				AddTestScripts(new HPPTRNE_SMOKE());
				AddTestScripts(new HPRACCHS_SMOKE());
				AddTestScripts(new HPREAWD_SMOKE());
				AddTestScripts(new HPREFT_SMOKE());
				AddTestScripts(new HPREF_SMOKE());
				AddTestScripts(new HPRFREAS_SMOKE());
				AddTestScripts(new HPROSHA_SMOKE());
				AddTestScripts(new HPRPOS_SMOKE());
				AddTestScripts(new HPRPROG_SMOKE());
				AddTestScripts(new HPRWAGHS_SMOKE());
				AddTestScripts(new HPRWCI_SMOKE());
				AddTestScripts(new HSMBSUR_SMOKE());
		           
        }
    }
}
