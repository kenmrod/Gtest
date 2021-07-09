using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class NEW_SMOKE_TIME_CLOUD : SeleniumTestRun
    {
        public NEW_SMOKE_TIME_CLOUD(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
SetDefaultArgs(SeleniumDriver.Browser.CHROME, "TE_DCO_C711T10CLDAUTOTEST_NEW");
            AddTestScripts(new TMMEMPLWORKSCH_SMOKE());
            AddTestScripts(new TMMMGRWORKSCH());
            AddTestScripts(new TMMTIMESHEET_SMOKE());
            AddTestScripts(new TMMTSLNAPP_SMOKE());
            AddTestScripts(new TMMTIMESHEETAPPROVE_SMOKE());
            AddTestScripts(new TMRFLRCHK_SMOKE());
            AddTestScripts(new TMRTSSTATUS_SMOKE());
            AddTestScripts(new TMMCORRECTSTATUS_SMOKE());
            AddTestScripts(new TMREMPACT_SMOKE());
            AddTestScripts(new TMRCHGACT_SMOKE());
            AddTestScripts(new TMRUTILIZATION_SMOKE());
            AddTestScripts(new TMRTSCHRG_SMOKE());
            AddTestScripts(new TMRBILLINGBACKUP_SMOKE());
            AddTestScripts(new TMRINTERIMTS_SMOKE());
            AddTestScripts(new TMPEXPORTTS_SMOKE());
            AddTestScripts(new TMMCONFIG_SMOKE());
            AddTestScripts(new TMMUTILIZATION_SMOKE());
            AddTestScripts(new TMMLEAVETYPES_SMOKE());
            AddTestScripts(new TMMWORKSCHEDULE_SMOKE());
            AddTestScripts(new TMMTSSCHD_SMOKE());
            AddTestScripts(new TMMTSCLASS_SMOKE());
            AddTestScripts(new TMMWAGESCHEDULE_SMOKE());
            AddTestScripts(new TMMEVENTS_SMOKE());
            AddTestScripts(new TMMTSINTERIMCHG_SMOKE());
            AddTestScripts(new TMQMASSCORRECT_SMOKE());
            AddTestScripts(new TMPGENTS_SMOKE());
            AddTestScripts(new TMQCHNGTSSTAT_SMOKE());
            AddTestScripts(new TMQRBLDLV_SMOKE());
            AddTestScripts(new TMQCLRTMSHT_SMOKE());
            AddTestScripts(new TMPTSTRANS_SMOKE());
        }
    }
}
