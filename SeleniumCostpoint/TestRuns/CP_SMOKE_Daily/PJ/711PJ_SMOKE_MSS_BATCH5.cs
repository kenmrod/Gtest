using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CP711PJ_SMOKE_MSS_BATCH5 : SeleniumTestRun
    {
        public CP711PJ_SMOKE_MSS_BATCH5(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
				SetDefaultArgs(SeleniumDriver.Browser.CHROME, "C71MQCM16AE");
				AddTestScripts(new PJMPAO_SMOKE());
				AddTestScripts(new PJMPAW_SMOKE());
				AddTestScripts(new PJMPLCE_SMOKE());
				AddTestScripts(new PJMPLCPJ_SMOKE());
				AddTestScripts(new PJMPLCP_SMOKE());
				AddTestScripts(new PJMPLCRT_SMOKE());
				AddTestScripts(new PJMPLC_SMOKE());
				AddTestScripts(new PJMPOOL_SMOKE());
				AddTestScripts(new PJMPOW_SMOKE());
				AddTestScripts(new PJMPRSEQ_SMOKE());
				AddTestScripts(new PJMPTSET_SMOKE());
				AddTestScripts(new PJMPTYPE_SMOKE());
				AddTestScripts(new PJMPWFRT_SMOKE());
				AddTestScripts(new PJMPYCST_SMOKE());
				AddTestScripts(new PJMPYGL_SMOKE());
				AddTestScripts(new PJMPYLAB_SMOKE());
				AddTestScripts(new PJMPYTM_SMOKE());
				AddTestScripts(new PJMPYUNT_SMOKE());
				AddTestScripts(new PJMQORG_SMOKE());
				AddTestScripts(new PJMQPAG_SMOKE());
				AddTestScripts(new PJMQPJAP_SMOKE());
				AddTestScripts(new PJMQPROJ_SMOKE());
				AddTestScripts(new PJMQSETA_SMOKE());
				AddTestScripts(new PJMQTPLT_SMOKE());
				AddTestScripts(new PJMQWBS_SMOKE());
				AddTestScripts(new PJMRAMT_SMOKE());
				AddTestScripts(new PJMREV_SMOKE());
				AddTestScripts(new PJMSETNG_SMOKE());
				AddTestScripts(new PJMTCEIL_SMOKE());
				AddTestScripts(new PJMTEXT_SMOKE());
				AddTestScripts(new PJMTMSEQ_SMOKE());
				AddTestScripts(new PJMUDINF_SMOKE());
				AddTestScripts(new PJMUDLAB_SMOKE());
				AddTestScripts(new PJMUNBDP_SMOKE());
				AddTestScripts(new PJMVCEIL_SMOKE());
				AddTestScripts(new PJMVEWRK_SMOKE());
				AddTestScripts(new PJMVNWRK_SMOKE());
				AddTestScripts(new PJMWORK_SMOKE());
				AddTestScripts(new PJP533PR_SMOKE());
				AddTestScripts(new PJPAAFC_SMOKE());
		           
        }
    }
}
