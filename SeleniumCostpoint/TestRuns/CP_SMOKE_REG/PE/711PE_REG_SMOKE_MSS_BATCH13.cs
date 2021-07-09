using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PE_REG_SMOKE_MSS_BATCH13 : SeleniumTestRun
    {
        public CP711PE_REG_SMOKE_MSS_BATCH13(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGM14");
				AddTestScripts(new PRPCW2_SMOKE());
				AddTestScripts(new PRPFQTD_SMOKE());
				AddTestScripts(new PRPFRBND_SMOKE());
				AddTestScripts(new PRPPADT_SMOKE());
				AddTestScripts(new PRPPCHK_SMOKE());
				AddTestScripts(new PRPPDCLS_SMOKE());
				AddTestScripts(new PRPPPAF_SMOKE());
				AddTestScripts(new PRPPPCLS_SMOKE());
				AddTestScripts(new PRPPRTD_SMOKE());
				AddTestScripts(new PRPPYCLS_SMOKE());
				AddTestScripts(new PRPRCOMP_SMOKE());
				AddTestScripts(new PRPSDED_SMOKE());
				AddTestScripts(new PRPSEXLI_SMOKE());
				AddTestScripts(new PRPSMM_SMOKE());
				AddTestScripts(new PRPSPRE_SMOKE());
				AddTestScripts(new PRPVCHK_SMOKE());
				AddTestScripts(new PRPVPAF_SMOKE());
				AddTestScripts(new PRPW2F_00_SMOKE_PREREQ());
				AddTestScripts(new PRPW2F_01_SMOKE());
				AddTestScripts(new PRPW2F_02_SMOKE_POSTREQ());
				AddTestScripts(new PRPW2S_00_SMOKE_PREREQ());
				AddTestScripts(new PRPW2S_01_SMOKE());
				AddTestScripts(new PRPW2S_02_SMOKE_POSTREQ());
				AddTestScripts(new PRQBADT_SMOKE());
				AddTestScripts(new PRQBHS_SMOKE());
				AddTestScripts(new PRQEBT_SMOKE());
				AddTestScripts(new PRQECNT_SMOKE());
		           
        }
    }
}
