 
using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class OpenCloseAllApps_TE : SeleniumTestRun
    {
        public OpenCloseAllApps_TE(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
			SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "C71QCM16");
			AddTestScripts(new OpenCloseApp_ADMCHGTREE());
			AddTestScripts(new OpenCloseApp_ADMDESKTOP());
			AddTestScripts(new OpenCloseApp_ADMEMPLGRP());
			AddTestScripts(new OpenCloseApp_ADMEMPLINFO());
			AddTestScripts(new OpenCloseApp_ADMEMPLPREF());
			AddTestScripts(new OpenCloseApp_ADMGENCONFIG());
			AddTestScripts(new OpenCloseApp_ADMSECURITYROLE());
			AddTestScripts(new OpenCloseApp_ADMUDT01());
			AddTestScripts(new OpenCloseApp_ADMUDT02());
			AddTestScripts(new OpenCloseApp_ADMUDT03());
			AddTestScripts(new OpenCloseApp_ADMUDT07());
			AddTestScripts(new OpenCloseApp_ADMUDT09());
			AddTestScripts(new OpenCloseApp_ADPIMPORT());
			AddTestScripts(new OpenCloseApp_ADPIMPORTLOG());
			AddTestScripts(new OpenCloseApp_ADQRESLICENSE());
			AddTestScripts(new OpenCloseApp_EPMCOMMITINQUIRY());
			AddTestScripts(new OpenCloseApp_EPMCONFIG());
			AddTestScripts(new OpenCloseApp_EPMCURSCH());
			AddTestScripts(new OpenCloseApp_EPMEXPAUTH());
			AddTestScripts(new OpenCloseApp_EPMEXPAUTHAPPROVE());
			AddTestScripts(new OpenCloseApp_EPMEXPAUTHRPT());
			AddTestScripts(new OpenCloseApp_EPMEXPBATCHTYPE());
			AddTestScripts(new OpenCloseApp_EPMEXPCHGTYPE());
			AddTestScripts(new OpenCloseApp_EPMEXPENSECLASS());
			AddTestScripts(new OpenCloseApp_EPMEXPREPRPT());
			AddTestScripts(new OpenCloseApp_EPMEXPREPTYPE());
			AddTestScripts(new OpenCloseApp_EPMEXPRPT());
			AddTestScripts(new OpenCloseApp_EPMEXPRPTAPPROVE());
			AddTestScripts(new OpenCloseApp_EPMEXPRPTCVTATT());
			AddTestScripts(new OpenCloseApp_EPMEXPTYPE());
			AddTestScripts(new OpenCloseApp_EPMIMPEXP());
			AddTestScripts(new OpenCloseApp_EPMPAYUTIL());
			AddTestScripts(new OpenCloseApp_EPMPERDIEMSCH());
			AddTestScripts(new OpenCloseApp_EPMPROVIDERS());
			AddTestScripts(new OpenCloseApp_EPMTAXSCH());
			AddTestScripts(new OpenCloseApp_EPPEXPORTEXP());
			AddTestScripts(new OpenCloseApp_EPQCHGEXPSTAT());
			AddTestScripts(new OpenCloseApp_EPQCLREPAUTH());
			AddTestScripts(new OpenCloseApp_EPQCLREXPRPT());
			AddTestScripts(new OpenCloseApp_EPRCOMMITSTATUS());
			AddTestScripts(new OpenCloseApp_EPREXPAUTHSTATUS());
			AddTestScripts(new OpenCloseApp_EPREXPRPTSTATUS());
			AddTestScripts(new OpenCloseApp_EPROUTAGING());
			AddTestScripts(new OpenCloseApp_TMMCONFIG());
			AddTestScripts(new OpenCloseApp_TMMEMPLWORKSCH());
			AddTestScripts(new OpenCloseApp_TMMEVENTS());
			AddTestScripts(new OpenCloseApp_TMMLEAVETYPES());
			AddTestScripts(new OpenCloseApp_TMMMGRWORKSCH());
			AddTestScripts(new OpenCloseApp_TMMTIMESHEET());
			AddTestScripts(new OpenCloseApp_TMMTIMESHEET_APPROVE());
			AddTestScripts(new OpenCloseApp_TMMTSCLASS());
			AddTestScripts(new OpenCloseApp_TMMTSLNAPP());
			AddTestScripts(new OpenCloseApp_TMMTSSCHD());
			AddTestScripts(new OpenCloseApp_TMMWAGESCHEDULE());
			AddTestScripts(new OpenCloseApp_TMMWORKSCHEDULE());
			AddTestScripts(new OpenCloseApp_TMPEXPORTTS());
			AddTestScripts(new OpenCloseApp_TMPGENTS());
			AddTestScripts(new OpenCloseApp_TMQCHNGTSSTAT());
			AddTestScripts(new OpenCloseApp_TMQCLRTMSHT());
			AddTestScripts(new OpenCloseApp_TMQMASSCORRECT());
			AddTestScripts(new OpenCloseApp_TMQRBLDLV());
			AddTestScripts(new OpenCloseApp_TMRBILLINGBACKUP());
			AddTestScripts(new OpenCloseApp_TMRCHGACT());
			AddTestScripts(new OpenCloseApp_TMREMPACT());
			AddTestScripts(new OpenCloseApp_TMRFLRCHK());
			AddTestScripts(new OpenCloseApp_TMRINTERIMTS());
			AddTestScripts(new OpenCloseApp_TMRTSSTATUS());
			AddTestScripts(new OpenCloseApp_TMRUTILIZATION());
			AddTestScripts(new OpenCloseApp_ADMEMAILTEXT());
			AddTestScripts(new OpenCloseApp_ADMFUNCTIONALROLE());
			AddTestScripts(new OpenCloseApp_ADMGROUPTYPE());
			AddTestScripts(new OpenCloseApp_ADMUDT01TYPE());
			AddTestScripts(new OpenCloseApp_ADMUDT04());
			AddTestScripts(new OpenCloseApp_ADMUDT05());
			AddTestScripts(new OpenCloseApp_ADMUDT06());
			AddTestScripts(new OpenCloseApp_ADMUDT08());
			AddTestScripts(new OpenCloseApp_ADMUDT10());
			AddTestScripts(new OpenCloseApp_ADMUDT11());
			AddTestScripts(new OpenCloseApp_ADMUDT12());
			AddTestScripts(new OpenCloseApp_ADMUDT13());
			AddTestScripts(new OpenCloseApp_ADMUDT14());
			AddTestScripts(new OpenCloseApp_ADMUDT15());
			AddTestScripts(new OpenCloseApp_EPMADVUTIL());
			AddTestScripts(new OpenCloseApp_EPMCURRENCY());
			AddTestScripts(new OpenCloseApp_EPMEXPUTIL());
			AddTestScripts(new OpenCloseApp_EPMMIE());
			AddTestScripts(new OpenCloseApp_EPMPAYMETHOD());
			AddTestScripts(new OpenCloseApp_EPPBARPROCESSOR());
			AddTestScripts(new OpenCloseApp_EPPCOMPUTECOMMIT());
			AddTestScripts(new OpenCloseApp_EPPEXPORTCOMMIT());
			AddTestScripts(new OpenCloseApp_TMMCORRECTSTATUS());
			AddTestScripts(new OpenCloseApp_TMMTSINTERIMCHG());
			AddTestScripts(new OpenCloseApp_TMMUTILIZATION());
			AddTestScripts(new OpenCloseApp_TMPTSTRANS());
			AddTestScripts(new OpenCloseApp_TMRTSCHRG());
		}
    }
	
}
