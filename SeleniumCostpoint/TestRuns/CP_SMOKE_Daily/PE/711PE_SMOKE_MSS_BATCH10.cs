using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_SMOKE_MSS_BATCH10 : SeleniumTestRun
    {
        public CP711PE_SMOKE_MSS_BATCH10(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCM16AE");
				AddTestScripts(new LDPLDJ_SMOKE());
				AddTestScripts(new LDPLHF_SMOKE());
				AddTestScripts(new LDPLPCLS_SMOKE());
				AddTestScripts(new LDPLPTS_SMOKE());
				AddTestScripts(new LDPPLHF_SMOKE());
				AddTestScripts(new LDPPTHF_SMOKE());
				AddTestScripts(new LDPRACE_SMOKE());
				AddTestScripts(new LDPRETRO_SMOKE());
				AddTestScripts(new LDPREVTS_SMOKE());
				AddTestScripts(new LDPROTP_SMOKE());
				AddTestScripts(new LDPSRDAT_SMOKE());
				AddTestScripts(new LDPTOOL3_SMOKE());
				AddTestScripts(new LDPTOOL4_SMOKE());
				AddTestScripts(new LDPTOOL6_SMOKE());
				AddTestScripts(new LDPTOOLD_SMOKE());
				AddTestScripts(new LDPUPET_SMOKE());
				AddTestScripts(new LDPWORK_SMOKE());
				AddTestScripts(new LDQLHF_SMOKE());
				AddTestScripts(new LDQTHF_SMOKE());
				AddTestScripts(new LDRAEDIT_SMOKE());
				AddTestScripts(new LDREHIR_SMOKE());
				AddTestScripts(new LDREHIS_SMOKE());
				AddTestScripts(new LDRELSUM_SMOKE());
				AddTestScripts(new LDRELV_SMOKE());
				AddTestScripts(new LDREMPL_SMOKE());
		           
        }
    }
}
