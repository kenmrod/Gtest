using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_SMOKE_MSS_BATCH3 : SeleniumTestRun
    {
        public CP711PE_SMOKE_MSS_BATCH3(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCM16AE");
				AddTestScripts(new HBMEFSA_SMOKE());
				AddTestScripts(new HBMEMED_SMOKE());
				AddTestScripts(new HBMEQEV_SMOKE());
				AddTestScripts(new HBMMCSET_SMOKE());
				AddTestScripts(new HBMMEDSV_SMOKE());
				AddTestScripts(new HBMMFSA_SMOKE());
				AddTestScripts(new HBMPASAL_SMOKE());
				AddTestScripts(new HBMPDFLT_SMOKE());
				AddTestScripts(new HBMPRAGE_SMOKE());
				AddTestScripts(new HBMPROV_SMOKE());
				AddTestScripts(new HBMQEVNT_SMOKE());
				AddTestScripts(new HBMRDEPR_SMOKE());
				AddTestScripts(new HBMRMEDR_SMOKE());
				AddTestScripts(new HBMSET_SMOKE());
				AddTestScripts(new HBPAPDED_SMOKE());
				AddTestScripts(new HBRCEN_SMOKE());
				AddTestScripts(new HBRCVG_SMOKE());
				AddTestScripts(new HBREBEN_SMOKE());
				AddTestScripts(new HBREDEP_SMOKE());
				AddTestScripts(new HBREFSA_SMOKE());
				AddTestScripts(new HBREMED_SMOKE());
				AddTestScripts(new HKMDED_SMOKE());
				AddTestScripts(new HKME401K_SMOKE());
				AddTestScripts(new HKMSET_SMOKE());
				AddTestScripts(new HKPLOAD_SMOKE());
				AddTestScripts(new HPMAINFO_SMOKE());
				AddTestScripts(new HPMANAT_SMOKE());
				AddTestScripts(new HPMAPPL_SMOKE());
		           
        }
    }
}
