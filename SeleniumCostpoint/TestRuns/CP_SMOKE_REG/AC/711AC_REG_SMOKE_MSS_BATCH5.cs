using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711AC_REG_SMOKE_MSS_BATCH5 : SeleniumTestRun
    {
        public CP711AC_REG_SMOKE_MSS_BATCH5(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C711AUTOTESTREGM14");
				AddTestScripts(new FAPTOOL3_SMOKE());
				AddTestScripts(new FAPTOOL4_SMOKE());
				AddTestScripts(new FAPTOOL5_SMOKE());
				AddTestScripts(new FAPTOOL6_SMOKE());
				AddTestScripts(new FAPTOOL7_SMOKE());
				AddTestScripts(new FAPTRNS_SMOKE());
				AddTestScripts(new FAPVUAT_SMOKE());
				AddTestScripts(new FAPVUDCD_SMOKE());
				AddTestScripts(new FAQAAL_SMOKE());
				AddTestScripts(new FAQDEPHS_SMOKE());
				AddTestScripts(new FAQPDE_SMOKE());
				AddTestScripts(new FAQTAL_SMOKE());
				AddTestScripts(new FARACTED_SMOKE());
				AddTestScripts(new FARADTL_SMOKE());
				AddTestScripts(new FARALST_SMOKE());
				AddTestScripts(new FARASLOC_SMOKE());
				AddTestScripts(new FARBKVAL_SMOKE());
				AddTestScripts(new FARCBD_SMOKE());
				AddTestScripts(new FARCDEPR_SMOKE());
				AddTestScripts(new FARCHIST_SMOKE());
				AddTestScripts(new FARDCIB_SMOKE());
				AddTestScripts(new FARDISP_SMOKE());
				AddTestScripts(new FARINV_SMOKE());
				AddTestScripts(new FARMNT_SMOKE());
				AddTestScripts(new FAROBDH_SMOKE());
				AddTestScripts(new FARPDE_SMOKE());
				AddTestScripts(new FARPDISP_SMOKE());
				AddTestScripts(new FARPPUR_SMOKE());
				AddTestScripts(new FARPTDTL_SMOKE());
				AddTestScripts(new FARRECON_SMOKE());
				AddTestScripts(new FARSAA_SMOKE());
				AddTestScripts(new FARSADA_SMOKE());
				AddTestScripts(new FARSPDH_SMOKE());
				AddTestScripts(new FARTDTL_SMOKE());
				AddTestScripts(new FARTLST_SMOKE());
				AddTestScripts(new FARTRNS_SMOKE());
				AddTestScripts(new GLMACLAB_SMOKE());
				AddTestScripts(new GLMACPT_SMOKE());
				AddTestScripts(new GLMACSET_SMOKE());
				AddTestScripts(new GLMACT_SMOKE());
				AddTestScripts(new GLMACUDF_SMOKE());
				AddTestScripts(new GLMAEG_SMOKE());
				AddTestScripts(new GLMALTFY_SMOKE());
				AddTestScripts(new GLMBANK_SMOKE());
				AddTestScripts(new GLMBDORG_SMOKE());
				AddTestScripts(new GLMBDREV_SMOKE());
				AddTestScripts(new GLMBEGFY_SMOKE());
				AddTestScripts(new GLMBEGIN_SMOKE());
				AddTestScripts(new GLMBSEAO_SMOKE());
				AddTestScripts(new GLMCFAT_SMOKE());
				AddTestScripts(new GLMCFLOW_SMOKE());
				AddTestScripts(new GLMCOBNK_SMOKE());
				AddTestScripts(new GLMCOMP_SMOKE());
		           
        }
    }
}
