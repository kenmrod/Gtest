using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711MM_SMOKE_ORA_BATCH6 : SeleniumTestRun
    {
        public CP711MM_SMOKE_ORA_BATCH6(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCO12AE2");
				AddTestScripts(new MRMDTPT_SMOKE());
				AddTestScripts(new MRMIAPEG_SMOKE());
				AddTestScripts(new MRMPOPTS_SMOKE());
				AddTestScripts(new MRMSET_SMOKE());
				AddTestScripts(new MRPFPO_SMOKE());
				AddTestScripts(new MRPLLC_SMOKE());
				AddTestScripts(new MRPMRP_SMOKE());
				AddTestScripts(new MRPTOOL1_SMOKE());
				AddTestScripts(new MRPTOOL2_SMOKE());
				AddTestScripts(new MRPTOOL3_SMOKE());
				AddTestScripts(new MRPTOOL4_SMOKE());
				AddTestScripts(new MRPTOOL5_SMOKE());
				AddTestScripts(new MRPTOOL6_SMOKE());
				AddTestScripts(new MRQSPA_SMOKE());
				AddTestScripts(new MRRACTM_SMOKE());
				AddTestScripts(new MRRBMAM_SMOKE());
				AddTestScripts(new MRRDTPT_SMOKE());
				AddTestScripts(new MRRSPA_SMOKE());
				AddTestScripts(new MSMACTM_SMOKE());
				AddTestScripts(new MSMMPS_SMOKE());
				AddTestScripts(new MSMPLNCD_SMOKE());
				AddTestScripts(new MSMPLRT_SMOKE());
				AddTestScripts(new MSMSET_SMOKE());
				AddTestScripts(new MSPCPY_SMOKE());
				AddTestScripts(new MSPFPO_SMOKE());
				AddTestScripts(new MSPMPS_SMOKE());
		           
        }
    }
}
