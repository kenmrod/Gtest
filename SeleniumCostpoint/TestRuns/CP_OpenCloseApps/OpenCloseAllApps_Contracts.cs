 
using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class OpenCloseAllApps_Contracts : SeleniumTestRun
    {
        public OpenCloseAllApps_Contracts(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
			SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71QCM16");
			AddTestScripts(new OpenCloseApp_CNQCTF());
			AddTestScripts(new OpenCloseApp_CTMCNLAB());
			AddTestScripts(new OpenCloseApp_CTMCNTR());
			AddTestScripts(new OpenCloseApp_CTMCUST());
			AddTestScripts(new OpenCloseApp_CTMDFAR());
			AddTestScripts(new OpenCloseApp_CTMEMPL());
			AddTestScripts(new OpenCloseApp_CTMFAR());
			AddTestScripts(new OpenCloseApp_CTMOCI());
			AddTestScripts(new OpenCloseApp_CTMOCLAB());
			AddTestScripts(new OpenCloseApp_CTMOPLAB());
			AddTestScripts(new OpenCloseApp_CTMOPP());
			AddTestScripts(new OpenCloseApp_CTMOPPBU());
			AddTestScripts(new OpenCloseApp_CTMOPSET());
			AddTestScripts(new OpenCloseApp_CTMSBCNTR());
			AddTestScripts(new OpenCloseApp_CTMSBLAB());
			AddTestScripts(new OpenCloseApp_CTMSETNG());
			AddTestScripts(new OpenCloseApp_CTMVEND());
			AddTestScripts(new OpenCloseApp_CTMVENDA());
			AddTestScripts(new OpenCloseApp_CTQSUBC());
			AddTestScripts(new OpenCloseApp_CNRADM());
			AddTestScripts(new OpenCloseApp_CNRBKL());
			AddTestScripts(new OpenCloseApp_CNREXP());
			AddTestScripts(new OpenCloseApp_CNRVEH());
			AddTestScripts(new OpenCloseApp_CTMACTM());
			AddTestScripts(new OpenCloseApp_CTMACTS());
			AddTestScripts(new OpenCloseApp_CTMAGENC());
			AddTestScripts(new OpenCloseApp_CTMAGRTYPE());
			AddTestScripts(new OpenCloseApp_CTMCLSRS());
			AddTestScripts(new OpenCloseApp_CTMCMPT());
			AddTestScripts(new OpenCloseApp_CTMCNTDT());
			AddTestScripts(new OpenCloseApp_CTMCNTST());
			AddTestScripts(new OpenCloseApp_CTMCNTVEH());
			AddTestScripts(new OpenCloseApp_CTMCNTYPE());
			AddTestScripts(new OpenCloseApp_CTMCTTYP());
			AddTestScripts(new OpenCloseApp_CTMCUSTA());
			AddTestScripts(new OpenCloseApp_CTMDOCTP());
			AddTestScripts(new OpenCloseApp_CTMGSA());
			AddTestScripts(new OpenCloseApp_CTMLOSS());
			AddTestScripts(new OpenCloseApp_CTMNAICS());
			AddTestScripts(new OpenCloseApp_CTMOCIRV());
			AddTestScripts(new OpenCloseApp_CTMOCIST());
			AddTestScripts(new OpenCloseApp_CTMOTYPE());
			AddTestScripts(new OpenCloseApp_CTMPROB());
			AddTestScripts(new OpenCloseApp_CTMRESP());
			AddTestScripts(new OpenCloseApp_CTMROLES());
			AddTestScripts(new OpenCloseApp_CTMSOURC());
			AddTestScripts(new OpenCloseApp_CTMSTAGE());
			AddTestScripts(new OpenCloseApp_CTMVENDDC());
			AddTestScripts(new OpenCloseApp_CTMVENDRT());
			AddTestScripts(new OpenCloseApp_CTPIQDAT());
			AddTestScripts(new OpenCloseApp_OPRCPL());
			AddTestScripts(new OpenCloseApp_OPROPN());
			AddTestScripts(new OpenCloseApp_OPRWLS());
		}
    }
	
}
