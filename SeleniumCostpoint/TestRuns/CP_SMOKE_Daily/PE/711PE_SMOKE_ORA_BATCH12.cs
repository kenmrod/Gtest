using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_SMOKE_ORA_BATCH12 : SeleniumTestRun
    {
        public CP711PE_SMOKE_ORA_BATCH12(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCO12AE2");
				AddTestScripts(new PRMLTT_SMOKE());
				AddTestScripts(new PRMMAG_SMOKE());
				AddTestScripts(new PRMMCLO_SMOKE());
				AddTestScripts(new PRMMCSO_SMOKE());
				AddTestScripts(new PRMMC_SMOKE());
				AddTestScripts(new PRMPAYTT_SMOKE());
				AddTestScripts(new PRMPRPD_SMOKE());
				AddTestScripts(new PRMPRSET_SMOKE());
				AddTestScripts(new PRMPTF_SMOKE());
				AddTestScripts(new PRMQRD_SMOKE());
				AddTestScripts(new PRMRTAX_SMOKE());
				AddTestScripts(new PRMSMM_SMOKE());
				AddTestScripts(new PRMSMW_SMOKE());
				AddTestScripts(new PRMSSD_SMOKE());
				AddTestScripts(new PRMSTAC_SMOKE());
				AddTestScripts(new PRMSTI_SMOKE());
				AddTestScripts(new PRMSTT_SMOKE());
				AddTestScripts(new PRMSUPT_SMOKE());
				AddTestScripts(new PRMSWW_SMOKE());
				AddTestScripts(new PRMW2_SMOKE());
				AddTestScripts(new PRMWCMC_SMOKE());
				AddTestScripts(new PRPAPVCH_SMOKE());
				AddTestScripts(new PRPAVCK_SMOKE());
				AddTestScripts(new PRPBANK_SMOKE());
				AddTestScripts(new PRPCKNUM_SMOKE());
				AddTestScripts(new PRPCLRTS_SMOKE());
				AddTestScripts(new PRPCNTRY_SMOKE());
				AddTestScripts(new PRPCPR_SMOKE());
		           
        }
    }
}
