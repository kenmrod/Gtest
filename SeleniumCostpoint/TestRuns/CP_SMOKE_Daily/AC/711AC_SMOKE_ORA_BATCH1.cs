using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711AC_SMOKE_ORA_BATCH1 : SeleniumTestRun
    {
        public CP711AC_SMOKE_ORA_BATCH1(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCO12AE2");
				AddTestScripts(new AOMSETCR_SMOKE());
				AddTestScripts(new AOMSUSAP_SMOKE());
				AddTestScripts(new AOMSUSJE_SMOKE());
				AddTestScripts(new AOMSUSTE_SMOKE());
				AddTestScripts(new AOPCPLCP_SMOKE());
				AddTestScripts(new AOPPOVCH_SMOKE());
				AddTestScripts(new AOPUTLAM_SMOKE());
				AddTestScripts(new AOPUTLAP_SMOKE());
				AddTestScripts(new AOPUTLCR_SMOKE());
				AddTestScripts(new AOPUTLJE_SMOKE());
				AddTestScripts(new AOPUTLTE_SMOKE());
				AddTestScripts(new AOPUTLVU_SMOKE());
				AddTestScripts(new APM1099_SMOKE());
				AddTestScripts(new APMACCT_SMOKE());
				AddTestScripts(new APMBNDTY_SMOKE());
				AddTestScripts(new APMCASH_SMOKE());
				AddTestScripts(new APMCCUPI_SMOKE());
				AddTestScripts(new APMCISVH_SMOKE());
				AddTestScripts(new APMCKHST_SMOKE());
				AddTestScripts(new APMCKSET_SMOKE());
				AddTestScripts(new APMCSHRQ_SMOKE());
				AddTestScripts(new APMINSCR_SMOKE());
				AddTestScripts(new APMINSTY_SMOKE());
				AddTestScripts(new APMLWDOC_SMOKE());
				AddTestScripts(new APMLWMNT_SMOKE());
				AddTestScripts(new APMLWPRJ_SMOKE());
				AddTestScripts(new APMMANCK_SMOKE());
				AddTestScripts(new APMOPEN_SMOKE());
				AddTestScripts(new APMRECCD_SMOKE());
				AddTestScripts(new APMSETA_SMOKE());
				AddTestScripts(new APMSETNG_SMOKE());
				AddTestScripts(new APMSETVA_SMOKE());
				AddTestScripts(new APMSETVN_SMOKE());
				AddTestScripts(new APMSETVR_SMOKE());
				AddTestScripts(new APMTECSU_SMOKE());
				AddTestScripts(new APMTERM_SMOKE());
				AddTestScripts(new APMVCHRA_SMOKE());
				AddTestScripts(new APMVCHR_SMOKE());
				AddTestScripts(new APMVENDA_SMOKE());
				AddTestScripts(new APMVENDH_SMOKE());
				AddTestScripts(new APMVEND_SMOKE());
				AddTestScripts(new APMVNLAB_SMOKE());
				AddTestScripts(new APP1099C_SMOKE());
				AddTestScripts(new APPCISSP_SMOKE());
				AddTestScripts(new APPCKA_SMOKE());
				AddTestScripts(new APPEFT_SMOKE());
				AddTestScripts(new APPPOSTV_SMOKE());
				AddTestScripts(new APPPSTCD_SMOKE());
				AddTestScripts(new APPPURVR_SMOKE());
				AddTestScripts(new APPRATE_SMOKE());
				AddTestScripts(new APPRECVR_SMOKE());
				AddTestScripts(new APPREVVR_SMOKE());
				AddTestScripts(new APPRUNCK_SMOKE());
				AddTestScripts(new APPSELVR_SMOKE());
		           
        }
    }
}
