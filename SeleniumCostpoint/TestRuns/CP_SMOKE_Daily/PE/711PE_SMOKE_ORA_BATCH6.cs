using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_SMOKE_ORA_BATCH6 : SeleniumTestRun
    {
        public CP711PE_SMOKE_ORA_BATCH6(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCO12AE2");
				AddTestScripts(new HSMCPDEF_SMOKE());
				AddTestScripts(new HSMCPSAL_SMOKE());
				AddTestScripts(new HSMCPSET_SMOKE());
				AddTestScripts(new HSMDETL_SMOKE());
				AddTestScripts(new HSMEMPRF_SMOKE());
				AddTestScripts(new HSMFUNC_SMOKE());
				AddTestScripts(new HSMGRADE_SMOKE());
				AddTestScripts(new HSMMGMR_00_SMOKE_PREREQ());
				AddTestScripts(new HSMMGMR_SMOKE());
				AddTestScripts(new HSMMGMR_02_SMOKE_POSTREQ());
				AddTestScripts(new HSMNBPAY_SMOKE());
				AddTestScripts(new HSMPERR_SMOKE());
				AddTestScripts(new HSMRATEG_SMOKE());
				AddTestScripts(new HSMRATEP_SMOKE());
				AddTestScripts(new HSMRATE_SMOKE());
				AddTestScripts(new HSMREAS_SMOKE());
				AddTestScripts(new HSMRFDEF_SMOKE());
				AddTestScripts(new HSMSETUP_SMOKE());
				AddTestScripts(new HSMSET_SMOKE());
				AddTestScripts(new HSMSUM_SMOKE());
				AddTestScripts(new HSMSURCP_SMOKE());
				AddTestScripts(new HSMSURJT_SMOKE());
				AddTestScripts(new HSMSUR_SMOKE());
				AddTestScripts(new HSPCOMP_SMOKE());
				AddTestScripts(new HSPECOMP_SMOKE());
				AddTestScripts(new HSPMGR_SMOKE());
				AddTestScripts(new HSPUPSUR_SMOKE());
				AddTestScripts(new HSRBUDR_SMOKE());
				AddTestScripts(new HSRCPREF_SMOKE());
		           
        }
    }
}
