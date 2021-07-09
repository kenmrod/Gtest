using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711MM_REG_SMOKE_MSS_BATCH12 : SeleniumTestRun
    {
        public CP711MM_REG_SMOKE_MSS_BATCH12(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGM14");
				AddTestScripts(new PORREG_SMOKE());
				AddTestScripts(new PPMBUYAL_SMOKE());
				AddTestScripts(new PPMBUYAS_SMOKE());
				AddTestScripts(new PPMNTRQ1_SMOKE());
				AddTestScripts(new PPMNTRQ2_SMOKE());
				AddTestScripts(new PPMPOHDR_SMOKE());
				AddTestScripts(new PPMPRTYP_SMOKE());
				AddTestScripts(new PPMQREAS_SMOKE());
				AddTestScripts(new PPMQREQ_SMOKE());
				AddTestScripts(new PPMQTI_SMOKE());
				AddTestScripts(new PPMQTTYP_SMOKE());
				AddTestScripts(new PPMQTV_SMOKE());
				AddTestScripts(new PPMRCST_SMOKE());
				AddTestScripts(new PPMRFQI_SMOKE());
				AddTestScripts(new PPMRFQSE_SMOKE());
				AddTestScripts(new PPMRFQV_SMOKE());
				AddTestScripts(new PPMRQAPP_SMOKE());
				AddTestScripts(new PPMRQAPT_SMOKE());
				AddTestScripts(new PPMRQAPX_SMOKE());
				AddTestScripts(new PPMRQLN_SMOKE());
				AddTestScripts(new PPMRQOP_SMOKE());
				AddTestScripts(new PPMRQSET_SMOKE());
				AddTestScripts(new PPMRQTYP_SMOKE());
				AddTestScripts(new PPMRREAS_SMOKE());
				AddTestScripts(new PPPGPO_SMOKE());
				AddTestScripts(new PPPVNDP_SMOKE());
				AddTestScripts(new PPQRQSTS_SMOKE());
				AddTestScripts(new PPQVNDP_SMOKE());
				AddTestScripts(new PPQVQT_SMOKE());
		           
        }
    }
}
