 
using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class OpenCloseAllApps_People : SeleniumTestRun
    {
        public OpenCloseAllApps_People(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
			SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71QCM16");
			AddTestScripts(new OpenCloseApp_AOMADP25());
			AddTestScripts(new OpenCloseApp_AOMCDCCN());
			AddTestScripts(new OpenCloseApp_AOMESSAP());
			AddTestScripts(new OpenCloseApp_AOMESSBE());
			AddTestScripts(new OpenCloseApp_AOMESSBL());
			AddTestScripts(new OpenCloseApp_AOMESSCL());
			AddTestScripts(new OpenCloseApp_AOMESSCS());
			AddTestScripts(new OpenCloseApp_AOMESSLE());
			AddTestScripts(new OpenCloseApp_AOMESSST());
			AddTestScripts(new OpenCloseApp_AOMESSUF());
			AddTestScripts(new OpenCloseApp_AOMSUEBP());
			AddTestScripts(new OpenCloseApp_AOPESSUE());
			AddTestScripts(new OpenCloseApp_EMMEHSA());
			AddTestScripts(new OpenCloseApp_EMMIDFORMAT());
			AddTestScripts(new OpenCloseApp_EMMJOBEXPORT());
			AddTestScripts(new OpenCloseApp_EMMLOCEXPORT());
			AddTestScripts(new OpenCloseApp_EMMUSITAR());
			AddTestScripts(new OpenCloseApp_EMPEEOI());
			AddTestScripts(new OpenCloseApp_ESMADDRESSPHONE());
			AddTestScripts(new OpenCloseApp_ESMBENENROLL());
			AddTestScripts(new OpenCloseApp_ESMDEPBEN());
			AddTestScripts(new OpenCloseApp_ESMDESBEN());
			AddTestScripts(new OpenCloseApp_ESMDIRDEP());
			AddTestScripts(new OpenCloseApp_ESMELECW2());
			AddTestScripts(new OpenCloseApp_ESMEMERCON());
			AddTestScripts(new OpenCloseApp_ESMESS());
			AddTestScripts(new OpenCloseApp_ESMEXPCHECKS());
			AddTestScripts(new OpenCloseApp_ESMFEDWH());
			AddTestScripts(new OpenCloseApp_ESMLIFEEVENT());
			AddTestScripts(new OpenCloseApp_ESMPAYCHECKS());
			AddTestScripts(new OpenCloseApp_ESMRETBEN());
			AddTestScripts(new OpenCloseApp_ESMSTATEWH());
			AddTestScripts(new OpenCloseApp_ESQCOMPBEN());
			AddTestScripts(new OpenCloseApp_ESQCOMPDIR());
			AddTestScripts(new OpenCloseApp_ESQCOMPLNK());
			AddTestScripts(new OpenCloseApp_ESQEMPLPERINFO());
			AddTestScripts(new OpenCloseApp_ESQLVSTAT());
			AddTestScripts(new OpenCloseApp_ESRSELFSERVSTAT());
			AddTestScripts(new OpenCloseApp_HAMAPSET());
			AddTestScripts(new OpenCloseApp_HAMCDATA());
			AddTestScripts(new OpenCloseApp_HAMSET());
			AddTestScripts(new OpenCloseApp_HAREEO1());
			AddTestScripts(new OpenCloseApp_HAREPR());
			AddTestScripts(new OpenCloseApp_HARPERS());
			AddTestScripts(new OpenCloseApp_HARV100());
			AddTestScripts(new OpenCloseApp_HBM1094C());
			AddTestScripts(new OpenCloseApp_HBM1095C());
			AddTestScripts(new OpenCloseApp_HBMABEN());
			AddTestScripts(new OpenCloseApp_HBMBENYR());
			AddTestScripts(new OpenCloseApp_HBMBPKG());
			AddTestScripts(new OpenCloseApp_HBMBPSET());
			AddTestScripts(new OpenCloseApp_HBMCVAGE());
			AddTestScripts(new OpenCloseApp_HBMCVSAL());
			AddTestScripts(new OpenCloseApp_HBMDEPHS());
			AddTestScripts(new OpenCloseApp_HBMEBELC());
			AddTestScripts(new OpenCloseApp_HBMEDPHS());
			AddTestScripts(new OpenCloseApp_HBMEFSA());
			AddTestScripts(new OpenCloseApp_HBMEMED());
			AddTestScripts(new OpenCloseApp_HBMMFSA());
			AddTestScripts(new OpenCloseApp_HBMOPTOF());
			AddTestScripts(new OpenCloseApp_HBMPASAL());
			AddTestScripts(new OpenCloseApp_HBMPDFLT());
			AddTestScripts(new OpenCloseApp_HBMPRAGE());
			AddTestScripts(new OpenCloseApp_HBMPROV());
			AddTestScripts(new OpenCloseApp_HBMSET());
			AddTestScripts(new OpenCloseApp_HBP1094C());
			AddTestScripts(new OpenCloseApp_HBP109XC());
			AddTestScripts(new OpenCloseApp_HBPAPDED());
			AddTestScripts(new OpenCloseApp_HBPFTE());
			AddTestScripts(new OpenCloseApp_HBPOPTOF());
			AddTestScripts(new OpenCloseApp_HBR1094C());
			AddTestScripts(new OpenCloseApp_HBR1095C());
			AddTestScripts(new OpenCloseApp_HKME401K());
			AddTestScripts(new OpenCloseApp_HKMSET());
			AddTestScripts(new OpenCloseApp_HPMAINFO());
			AddTestScripts(new OpenCloseApp_HPMCASE());
			AddTestScripts(new OpenCloseApp_HPMDPOS());
			AddTestScripts(new OpenCloseApp_HPMEDS());
			AddTestScripts(new OpenCloseApp_HPMEFSET());
			AddTestScripts(new OpenCloseApp_HPMEMPEF());
			AddTestScripts(new OpenCloseApp_HPMFPOS());
			AddTestScripts(new OpenCloseApp_HPMI9CD());
			AddTestScripts(new OpenCloseApp_HPMI9DAT());
			AddTestScripts(new OpenCloseApp_HPMTRAIN());
			AddTestScripts(new OpenCloseApp_HPMVEH());
			AddTestScripts(new OpenCloseApp_HPPTRNE());
			AddTestScripts(new OpenCloseApp_HPREF());
			AddTestScripts(new OpenCloseApp_HPREFT());
			AddTestScripts(new OpenCloseApp_HSMBUDOR());
			AddTestScripts(new OpenCloseApp_HSMCPSAL());
			AddTestScripts(new OpenCloseApp_HSMDETL());
			AddTestScripts(new OpenCloseApp_HSMEMPRF());
			AddTestScripts(new OpenCloseApp_HSMNBPAY());
			AddTestScripts(new OpenCloseApp_HSMPERR());
			AddTestScripts(new OpenCloseApp_HSMRATEG());
			AddTestScripts(new OpenCloseApp_HSMRATEP());
			AddTestScripts(new OpenCloseApp_HSMREAS());
			AddTestScripts(new OpenCloseApp_HSMSETUP());
			AddTestScripts(new OpenCloseApp_HSMSUR());
			AddTestScripts(new OpenCloseApp_HSMSURCP());
			AddTestScripts(new OpenCloseApp_HSMSURJT());
			AddTestScripts(new OpenCloseApp_HTMADDRESS());
			AddTestScripts(new OpenCloseApp_HTMCHANGES());
			AddTestScripts(new OpenCloseApp_HTMCITIZENSHIP());
			AddTestScripts(new OpenCloseApp_HTMDETAIL());
			AddTestScripts(new OpenCloseApp_HTMKNOWLEDGE());
			AddTestScripts(new OpenCloseApp_HTMLEAVE());
			AddTestScripts(new OpenCloseApp_HTMLIFEEVENTS());
			AddTestScripts(new OpenCloseApp_HTMPHONE());
			AddTestScripts(new OpenCloseApp_HTMPROPERTY());
			AddTestScripts(new OpenCloseApp_HTMSETTINGS());
			AddTestScripts(new OpenCloseApp_HTMTOTALCOMP());
			AddTestScripts(new OpenCloseApp_HTPCHANGES());
			AddTestScripts(new OpenCloseApp_HTRTEAMINFO());
			AddTestScripts(new OpenCloseApp_LDMAGLC());
			AddTestScripts(new OpenCloseApp_LDMBTCH());
			AddTestScripts(new OpenCloseApp_LDMCOST());
			AddTestScripts(new OpenCloseApp_LDMCREW());
			AddTestScripts(new OpenCloseApp_LDMCTIME());
			AddTestScripts(new OpenCloseApp_LDMEINFO());
			AddTestScripts(new OpenCloseApp_LDMELSET());
			AddTestScripts(new OpenCloseApp_LDMELV());
			AddTestScripts(new OpenCloseApp_LDMFCEIL());
			AddTestScripts(new OpenCloseApp_LDMFMC());
			AddTestScripts(new OpenCloseApp_LDMLABOR());
			AddTestScripts(new OpenCloseApp_LDMLBB());
			AddTestScripts(new OpenCloseApp_LDMLEDIT());
			AddTestScripts(new OpenCloseApp_LDMLLOC());
			AddTestScripts(new OpenCloseApp_LDMLVMOD());
			AddTestScripts(new OpenCloseApp_LDMLVPD());
			AddTestScripts(new OpenCloseApp_LDMLVTAB());
			AddTestScripts(new OpenCloseApp_LDMLVTP());
			AddTestScripts(new OpenCloseApp_LDMPAYTP());
			AddTestScripts(new OpenCloseApp_LDMRACE());
			AddTestScripts(new OpenCloseApp_LDMTCACT());
			AddTestScripts(new OpenCloseApp_LDMTCORG());
			AddTestScripts(new OpenCloseApp_LDMTCPJ());
			AddTestScripts(new OpenCloseApp_LDMTIME());
			AddTestScripts(new OpenCloseApp_LDMTSPD());
			AddTestScripts(new OpenCloseApp_LDMUDI());
			AddTestScripts(new OpenCloseApp_LDMUDL());
			AddTestScripts(new OpenCloseApp_LDMUNPRO());
			AddTestScripts(new OpenCloseApp_LDMWORK());
			AddTestScripts(new OpenCloseApp_LDPBLPTS());
			AddTestScripts(new OpenCloseApp_LDPBRET());
			AddTestScripts(new OpenCloseApp_LDPCLHF());
			AddTestScripts(new OpenCloseApp_LDPLPTS());
			AddTestScripts(new OpenCloseApp_LDPLVREC());
			AddTestScripts(new OpenCloseApp_LDPRACE());
			AddTestScripts(new OpenCloseApp_LDPRETRO());
			AddTestScripts(new OpenCloseApp_LDPREVTS());
			AddTestScripts(new OpenCloseApp_LDPSRDAT());
			AddTestScripts(new OpenCloseApp_LDQLABOR());
			AddTestScripts(new OpenCloseApp_LDQLHF());
							
		}
    }
	
}
