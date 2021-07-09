using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;
using SeleniumCostpoint.Tests.CP_SMOKE.PJ;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PJ_REG_SMOKE_ORA_BATCH3 : SeleniumTestRun
    {
        public CP711PJ_REG_SMOKE_ORA_BATCH3(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGO12");
				AddTestScripts(new BLRCPROD_SMOKE());
				AddTestScripts(new BLRIRBIL_SMOKE());
				AddTestScripts(new BLRMBIL_SMOKE());
				AddTestScripts(new BLRMPCB_SMOKE());
				AddTestScripts(new BLROBD_SMOKE());
				AddTestScripts(new BLRPBIL_SMOKE());
				AddTestScripts(new BLRPJPRD_SMOKE());
				AddTestScripts(new BLRRBIL_SMOKE());
				AddTestScripts(new BLRUEDIT_SMOKE());
				AddTestScripts(new BLRUHIST_SMOKE());
				AddTestScripts(new BLRUNBIL_SMOKE());
				AddTestScripts(new BPMAGLC_SMOKE());
				AddTestScripts(new BPMAPLC_SMOKE());
				AddTestScripts(new BPMPBETC_SMOKE());
				AddTestScripts(new BPMPDDAY_SMOKE());
				AddTestScripts(new BPMRVSN_SMOKE());
				AddTestScripts(new BPMSET_SMOKE());
				AddTestScripts(new BPPBRECL_SMOKE());
				AddTestScripts(new BPPETCUP_SMOKE());
				AddTestScripts(new BPPMASS_SMOKE());
				AddTestScripts(new BPPMBRT_SMOKE());
				AddTestScripts(new BPPREV_SMOKE());
				AddTestScripts(new BPQBBUD_SMOKE());
				AddTestScripts(new BPQBETC_SMOKE());
				AddTestScripts(new BPRLBETC_SMOKE());
				AddTestScripts(new BPRPJBUD_SMOKE());
				AddTestScripts(new BPRPJETC_SMOKE());
				AddTestScripts(new BPRPJEV_SMOKE());
				AddTestScripts(new BPRPJSUB_SMOKE());
				AddTestScripts(new IWMALLOC_SMOKE());
				AddTestScripts(new IWMEXPMP_SMOKE());
				AddTestScripts(new IWMLOC_SMOKE());
				AddTestScripts(new IWMPROJ_SMOKE());
				AddTestScripts(new IWMSUSP_SMOKE());
				AddTestScripts(new IWPALLOC_SMOKE());
				AddTestScripts(new IWPEXPRT_SMOKE());
				AddTestScripts(new IWPIMPRT_SMOKE());
				AddTestScripts(new IWPPOST_SMOKE());
				AddTestScripts(new IWPUPLD_SMOKE());
				AddTestScripts(new PJM533FM_SMOKE());
				AddTestScripts(new PJM533FY_SMOKE());
		           
        }
    }
}
