using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_REG_SMOKE_MSS_BATCH7 : SeleniumTestRun
    {
        public CP711PE_REG_SMOKE_MSS_BATCH7(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGM14");
				AddTestScripts(new HSREMPT_SMOKE());
				AddTestScripts(new HSRGRADE_SMOKE());
				AddTestScripts(new HSRINCP_SMOKE());
				AddTestScripts(new HSRJOBT_SMOKE());
				AddTestScripts(new HSRRATIO_SMOKE());
				AddTestScripts(new HSRRFT_SMOKE());
				AddTestScripts(new HSRRF_SMOKE());
				AddTestScripts(new HSRRSCH_SMOKE());
				AddTestScripts(new HSRSSCH_SMOKE());
				AddTestScripts(new HSRSTATE_SMOKE());
				AddTestScripts(new HSRSTATM_SMOKE());
				AddTestScripts(new INMPARSV_PREREQ());
				AddTestScripts(new INMPARSV_SMOKE());
				AddTestScripts(new INMPARSV_POSTREQ());
				AddTestScripts(new LDMADD_SMOKE());
				AddTestScripts(new LDMAGLC_SMOKE());
				AddTestScripts(new LDMCLASS_SMOKE());
				AddTestScripts(new LDMCOST_SMOKE());
				AddTestScripts(new LDMCREW_00_SMOKE_PREREQ());
				AddTestScripts(new LDMCREW_01_SMOKE());
				AddTestScripts(new LDMCREW_02_SMOKE_POSTREQ());
				AddTestScripts(new LDMCTIME_SMOKE());
				AddTestScripts(new LDMEADD_SMOKE());
				AddTestScripts(new LDMEAD_SMOKE());
				AddTestScripts(new LDMEHIS_SMOKE());
				AddTestScripts(new LDMELSET_SMOKE());
		           
        }
    }
}
