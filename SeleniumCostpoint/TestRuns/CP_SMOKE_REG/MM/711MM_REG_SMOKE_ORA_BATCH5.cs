using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;
using SeleniumCostpoint.Tests.CP_SMOKE.MM;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711MM_REG_SMOKE_ORA_BATCH5 : SeleniumTestRun
    {
        public CP711MM_REG_SMOKE_ORA_BATCH5(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGO12");
				AddTestScripts(new INQSRLT_SMOKE());
				AddTestScripts(new INRHSTPA_SMOKE());
				AddTestScripts(new INRISTS_SMOKE());
				AddTestScripts(new INRPHYS_SMOKE());
				AddTestScripts(new INRRESV_SMOKE());
				AddTestScripts(new IWPIMPRT_SMOKE());
				AddTestScripts(new IWPPOST_SMOKE());
				AddTestScripts(new IWPUPLD_SMOKE());
				AddTestScripts(new LDPEXPM_SMOKE());
				AddTestScripts(new LDQPMESH_SMOKE());
				AddTestScripts(new MEMECS_SMOKE());
				AddTestScripts(new MEMPBOM_SMOKE());
				AddTestScripts(new MEMPROP_SMOKE());
				AddTestScripts(new MEMPRPLI_SMOKE());
				AddTestScripts(new MEMPRPLS_SMOKE());
				AddTestScripts(new MEMRFQS_SMOKE());
				AddTestScripts(new MEMSET_SMOKE());
				AddTestScripts(new MEPCPIC_SMOKE());
				AddTestScripts(new MEPGRFQ_SMOKE());
				AddTestScripts(new MEPMCC_SMOKE());
				AddTestScripts(new MEPPBOM_SMOKE());
				AddTestScripts(new MEQPWU_SMOKE());
				AddTestScripts(new MERPEXC_SMOKE());
				AddTestScripts(new MERPICH_SMOKE());
				AddTestScripts(new MRMACTM_SMOKE());
		           
        }
    }
}
