using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;
using SeleniumCostpoint.Tests.CP_SMOKE.PE;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_REG_SMOKE_ORA_BATCH9 : SeleniumTestRun
    {
        public CP711PE_REG_SMOKE_ORA_BATCH9(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGO12");
				AddTestScripts(new LDMRACE_SMOKE());
				AddTestScripts(new LDMTCACT_SMOKE());
				AddTestScripts(new LDMTCAT_SMOKE());
				AddTestScripts(new LDMTCORG_SMOKE());
				AddTestScripts(new LDMTCPJ_SMOKE());
				AddTestScripts(new LDMTIME_SMOKE());
				AddTestScripts(new LDMTSPD_SMOKE());
				AddTestScripts(new LDMUDI_SMOKE());
				AddTestScripts(new LDMUDL_SMOKE());
				AddTestScripts(new LDMUNPRO_00_SMOKE_PREREQ());
				AddTestScripts(new LDMUNPRO_01_SMOKE());
				AddTestScripts(new LDMUNPRO_02_SMOKE_POSTREQ());
				AddTestScripts(new LDMVISA_SMOKE());
				AddTestScripts(new LDMWC_SMOKE());
				AddTestScripts(new LDMWORK_SMOKE());
				AddTestScripts(new LDPADD_SMOKE());
				AddTestScripts(new LDPALLOC_SMOKE());
				AddTestScripts(new LDPAUTO_SMOKE());
				AddTestScripts(new LDPBADD_SMOKE());
				AddTestScripts(new LDPBALL_SMOKE());
				AddTestScripts(new LDPBRET_SMOKE());
				AddTestScripts(new LDPCLHF_SMOKE());
				AddTestScripts(new LDPCOST_SMOKE());
				AddTestScripts(new LDPDTC_SMOKE());
				AddTestScripts(new LDPDUMTS_SMOKE());
				AddTestScripts(new LDPEXPM_SMOKE());
				AddTestScripts(new LDPFRNG_00_SMOKE_PREREQ());
				AddTestScripts(new LDPFRNG_01_SMOKE());
				AddTestScripts(new LDPFRNG_02_SMOKE_POSTREQ());
		           
        }
    }
}
