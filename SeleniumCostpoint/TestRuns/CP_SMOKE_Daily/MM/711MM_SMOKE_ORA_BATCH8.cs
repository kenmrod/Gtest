using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711MM_SMOKE_ORA_BATCH8 : SeleniumTestRun
    {
        public CP711MM_SMOKE_ORA_BATCH8(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCO12AE2");
				AddTestScripts(new OEMSET_SMOKE());
				AddTestScripts(new OEMSHIPM_SMOKE());
				AddTestScripts(new OEMSHIP_SMOKE());
				AddTestScripts(new OEMSOUDI_SMOKE());
				AddTestScripts(new OEMSREP_SMOKE());
				AddTestScripts(new OEMUDL_SMOKE());
				AddTestScripts(new OEPEDIIN_SMOKE());
				AddTestScripts(new OEPGRQ_SMOKE());
				AddTestScripts(new OEPINVC_SMOKE());
				AddTestScripts(new OEPPOST_SMOKE());
				AddTestScripts(new OEPRFID_SMOKE());
				AddTestScripts(new OEPWAWF_SMOKE());
				AddTestScripts(new OEQSALES_SMOKE());
				AddTestScripts(new OEQSTAT_SMOKE());
				AddTestScripts(new OER250I_SMOKE());
				AddTestScripts(new OER250PS_SMOKE());
				AddTestScripts(new OERACKN_SMOKE());
				AddTestScripts(new OERAPPR_SMOKE());
				AddTestScripts(new OERBLOG_SMOKE());
				AddTestScripts(new OERINVC_SMOKE());
				AddTestScripts(new OERPCKSL_SMOKE());
				AddTestScripts(new OERPICK_SMOKE());
				AddTestScripts(new OERSHLAB_SMOKE());
				AddTestScripts(new PCMCOMP_SMOKE());
				AddTestScripts(new PCMCSTOP_SMOKE());
				AddTestScripts(new PCMEEPM_SMOKE());
		           
        }
    }
}
