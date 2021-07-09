using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711MM_SMOKE_ORA_BATCH10 : SeleniumTestRun
    {
        public CP711MM_SMOKE_ORA_BATCH10(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCO12AE2");
				AddTestScripts(new PDMITMRU_SMOKE());
				AddTestScripts(new PDMMANUF_SMOKE());
				AddTestScripts(new PDMPART_SMOKE());
				AddTestScripts(new PDMPOPT_SMOKE());
				AddTestScripts(new PDMPPCAT_SMOKE());
				AddTestScripts(new PDMPRCAT_SMOKE());
				AddTestScripts(new PDMPRDCL_SMOKE());
				AddTestScripts(new PDMPRDTY_SMOKE());
				AddTestScripts(new PDMPREFR_SMOKE());
				AddTestScripts(new PDMPRJCS_SMOKE());
				AddTestScripts(new PDMPRJPD_SMOKE());
				AddTestScripts(new PDMPRPTT_SMOKE());
				AddTestScripts(new PDMPRPT_SMOKE());
				AddTestScripts(new PDMSALES_SMOKE());
				AddTestScripts(new PDMSCGRP_SMOKE());
				AddTestScripts(new PDMSERV_SMOKE());
				AddTestScripts(new PDMTEXT_SMOKE());
				AddTestScripts(new PDMUOM_SMOKE());
				AddTestScripts(new PDMVEND_SMOKE());
				AddTestScripts(new PDMWARR_SMOKE());
				AddTestScripts(new PDPCONV_SMOKE());
				AddTestScripts(new PDQINQ_SMOKE());
				AddTestScripts(new PDQMFR_SMOKE());
				AddTestScripts(new PDRAVR_SMOKE());
				AddTestScripts(new PDRCAT_SMOKE());
				AddTestScripts(new PDRCOST_SMOKE());
		           
        }
    }
}
