using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_SMOKE_MSS_BATCH2 : SeleniumTestRun
    {
        public CP711PE_SMOKE_MSS_BATCH2(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCM16AE");
				AddTestScripts(new HAPAAPLN_SMOKE());
				AddTestScripts(new HAREEO1_SMOKE());
				AddTestScripts(new HAREROST_SMOKE());
				AddTestScripts(new HARJOBGP_SMOKE());
				AddTestScripts(new HARNHIRE_SMOKE());
				AddTestScripts(new HARPERS_SMOKE());
				AddTestScripts(new HARPROF_SMOKE());
				AddTestScripts(new HARPROG_SMOKE());
				AddTestScripts(new HARPROMO_SMOKE());
				AddTestScripts(new HARTERM_SMOKE());
				AddTestScripts(new HARTRAIN_SMOKE());
				AddTestScripts(new HARTRANS_SMOKE());
				AddTestScripts(new HARUTIL_SMOKE());
				AddTestScripts(new HARV100_SMOKE());
				AddTestScripts(new HARWORK_SMOKE());
				AddTestScripts(new HBMABEN_SMOKE());
				AddTestScripts(new HBMADEP_SMOKE());
				AddTestScripts(new HBMBPKG_SMOKE());
				AddTestScripts(new HBMBPSET_SMOKE());
				AddTestScripts(new HBMBTYPE_SMOKE());
				AddTestScripts(new HBMCOVOP_SMOKE());
				AddTestScripts(new HBMCVAGE_SMOKE());
				AddTestScripts(new HBMCVSAL_SMOKE());
				AddTestScripts(new HBMDCSET_SMOKE());
				AddTestScripts(new HBMDEPHS_SMOKE());
				AddTestScripts(new HBMEBELC_SMOKE());
				AddTestScripts(new HBMEDEP_SMOKE());
				AddTestScripts(new HBMEDPHS_SMOKE());
		           
        }
    }
}
