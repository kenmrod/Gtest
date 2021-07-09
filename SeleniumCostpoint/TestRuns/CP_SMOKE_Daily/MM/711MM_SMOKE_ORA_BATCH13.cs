using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711MM_SMOKE_ORA_BATCH13 : SeleniumTestRun
    {
        public CP711MM_SMOKE_ORA_BATCH13(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCO12AE2");
				AddTestScripts(new PPRAPPR_SMOKE());
				AddTestScripts(new PPRCOMT_SMOKE());
				AddTestScripts(new PPRPRRFQ_SMOKE());
				AddTestScripts(new PPRPRRQ_SMOKE());
				AddTestScripts(new RCMINSP_SMOKE());
				AddTestScripts(new RCMMSRC_SMOKE());
				AddTestScripts(new RCMPORC_SMOKE());
				AddTestScripts(new RCMREJCD_SMOKE());
				AddTestScripts(new RCMRTRN_SMOKE());
				AddTestScripts(new RCMSET_SMOKE());
				AddTestScripts(new RCRLOG_SMOKE());
				AddTestScripts(new RCRPINSP_SMOKE());
				AddTestScripts(new RCRTRVLR_SMOKE());
				AddTestScripts(new RUMEQUIP_SMOKE());
				AddTestScripts(new RUMKEYR_SMOKE());
				AddTestScripts(new RUMLABCL_SMOKE());
				AddTestScripts(new RUMLABOP_SMOKE());
				AddTestScripts(new RUMMAINT_SMOKE());
				AddTestScripts(new RUMOPTYP_SMOKE());
				AddTestScripts(new RUMPRTYP_SMOKE());
				AddTestScripts(new RUMROUT_SMOKE());
				AddTestScripts(new RUMRROUT_SMOKE());
				AddTestScripts(new RUMRSTYP_SMOKE());
				AddTestScripts(new RUMRTSET_SMOKE());
				AddTestScripts(new RUMSUBOP_SMOKE());
				AddTestScripts(new RUMWCM_SMOKE());
				AddTestScripts(new RUMWCTYP_SMOKE());
				AddTestScripts(new RUQROUT_SMOKE());
				AddTestScripts(new RURROUT_SMOKE());
		           
        }
    }
}
