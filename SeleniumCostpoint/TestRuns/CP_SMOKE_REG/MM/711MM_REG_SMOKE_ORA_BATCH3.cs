using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711MM_REG_SMOKE_ORA_BATCH3 : SeleniumTestRun
    {
        public CP711MM_REG_SMOKE_ORA_BATCH3(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGO12");
				AddTestScripts(new ECMAPPR_SMOKE());
				AddTestScripts(new ECMECAPP_SMOKE());
				AddTestScripts(new ECMECAPT_SMOKE());
				AddTestScripts(new ECMECN_SMOKE());
				AddTestScripts(new ECMIGRP_SMOKE());
				AddTestScripts(new ECMPOPT_SMOKE());
				AddTestScripts(new ECMPRAPP_SMOKE());
				AddTestScripts(new ECMPRI_SMOKE());
				AddTestScripts(new ECMREJR_SMOKE());
				AddTestScripts(new ECMRSN_SMOKE());
				AddTestScripts(new ECMSET_SMOKE());
				AddTestScripts(new ECMTYPE_SMOKE());
				AddTestScripts(new ECMUDFL_SMOKE());
				AddTestScripts(new ECPINECN_SMOKE());
				AddTestScripts(new ECQECNST_SMOKE());
				AddTestScripts(new ECRIMPCT_SMOKE());
				AddTestScripts(new ECRTRVLR_SMOKE());
				AddTestScripts(new INMACCT_SMOKE());
				AddTestScripts(new INMBCKOR__SMOKE());
				AddTestScripts(new INMCSADJ_SMOKE());
				AddTestScripts(new INMLOXFR_SMOKE());
				AddTestScripts(new INMPAISS_SMOKE());
				AddTestScripts(new INMPARSV_SMOKE());
				AddTestScripts(new INMPAXFR_SMOKE());
				AddTestScripts(new INMPCACT_SMOKE());
				AddTestScripts(new INMPCLST_SMOKE());
		           
        }
    }
}
