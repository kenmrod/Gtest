using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;
using SeleniumCostpoint.Tests.CP_SMOKE.AC;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711AC_SMOKE_ORA_BATCH2 : SeleniumTestRun
    {
        public CP711AC_SMOKE_ORA_BATCH2(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCO12AE2");
				AddTestScripts(new APPTECMT_SMOKE());
				AddTestScripts(new APPTOOL2_SMOKE());
				AddTestScripts(new APPTOOL3_SMOKE());
				AddTestScripts(new APPTOOL4_SMOKE());
				AddTestScripts(new APPTOOL5_SMOKE());
				AddTestScripts(new APPUNRL_SMOKE());
				AddTestScripts(new APPUPPWP_SMOKE());
				AddTestScripts(new APPUTLCC_SMOKE());
				AddTestScripts(new APQCKHST_SMOKE());
				AddTestScripts(new APQVCHRH_SMOKE());
				AddTestScripts(new APQVENDH_SMOKE());
				AddTestScripts(new APR1099E_SMOKE());
				AddTestScripts(new APR1099_SMOKE());
				AddTestScripts(new APRBANK_SMOKE());
				AddTestScripts(new APRCASH_SMOKE());
				AddTestScripts(new APRCKPRE_SMOKE());
				AddTestScripts(new APRCKREG_SMOKE());
				AddTestScripts(new APRCK_SMOKE());
				AddTestScripts(new APRDUPIN_SMOKE());
				AddTestScripts(new APREFTED_SMOKE());
				AddTestScripts(new APREFTPR_SMOKE());
				AddTestScripts(new APRHIST_SMOKE());
				AddTestScripts(new APRLWPRT_SMOKE());
				AddTestScripts(new APROPEN_SMOKE());
				AddTestScripts(new APRPEND_SMOKE());
				AddTestScripts(new APRSUB_SMOKE());
				AddTestScripts(new APRVCHRA_SMOKE());
				AddTestScripts(new APRVCHR_SMOKE());
				AddTestScripts(new APRVEND_SMOKE());
				AddTestScripts(new APRVINFO_SMOKE());
				AddTestScripts(new APRVREG_SMOKE());
				AddTestScripts(new ARMCRLIM_SMOKE());
				AddTestScripts(new ARMCRNUM_SMOKE());
				AddTestScripts(new ARMCRRAT_SMOKE());
				AddTestScripts(new ARMCR_SMOKE());
				AddTestScripts(new ARMCTYPE_SMOKE());
				AddTestScripts(new ARMCUST_SMOKE());
				AddTestScripts(new ARMHIST_SMOKE());
				AddTestScripts(new ARMLWDOC_SMOKE());
				AddTestScripts(new ARMLWMNT__SMOKE());
				AddTestScripts(new ARMLWPRJ_SMOKE());
				AddTestScripts(new ARMOREC_SMOKE());
				AddTestScripts(new ARMSALET_SMOKE());
				AddTestScripts(new ARMSETNG_SMOKE());
				AddTestScripts(new ARMSHIPM_SMOKE());
				AddTestScripts(new ARMTERM_SMOKE());
				AddTestScripts(new ARMTRACT_SMOKE());
				AddTestScripts(new ARMUDINF_SMOKE());
				AddTestScripts(new ARMUSRDF_SMOKE());
				AddTestScripts(new ARPCR_SMOKE());
				AddTestScripts(new ARPFINCH_SMOKE());
				AddTestScripts(new ARPPADJ_SMOKE());
				AddTestScripts(new ARPPCUST_SMOKE());
		           
        }
    }
}
