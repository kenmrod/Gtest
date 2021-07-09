using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class CLASSIC_SMOKE_CONFIG_DAILY_ORA_HEADLESS : SeleniumTestRun
    {
        public CLASSIC_SMOKE_CONFIG_DAILY_ORA_HEADLESS(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests()
        {
SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "TE_DAILY_TE10QCO12AUTOTEST_CLASSIC");
            AddTestScripts(new ADMGENCONFIG_SMOKE());
            AddTestScripts(new ADMUDT01TYPE_SMOKE());
            AddTestScripts(new ADMGROUPTYPE_SMOKE());
            AddTestScripts(new ADMEMPLINFO_SMOKE());
            AddTestScripts(new ADMEMPLGRP_SMOKE());
            AddTestScripts(new ADMSECURITYROLE_SMOKE());
            AddTestScripts(new ADMFUNCTIONALROLE_SMOKE());
            AddTestScripts(new ADMEMPLPREF_SMOKE());
            AddTestScripts(new ADMDESKTOP_SMOKE());
            AddTestScripts(new ADQRESLICENSE_SMOKE());
            AddTestScripts(new ADMCHGTREE_SMOKE());
            AddTestScripts(new ADMUDT01_SMOKE());
            AddTestScripts(new ADMUDT02_SMOKE());
            AddTestScripts(new ADMUDT03_SMOKE());
            AddTestScripts(new ADMUDT04_SMOKE());
            AddTestScripts(new ADMUDT05_SMOKE());
            AddTestScripts(new ADMUDT06_SMOKE());
            AddTestScripts(new ADMUDT07_SMOKE());
            AddTestScripts(new ADMUDT08_SMOKE());
            AddTestScripts(new ADMUDT09_SMOKE());
            AddTestScripts(new ADMUDT10_SMOKE());
            AddTestScripts(new ADMUDT11_SMOKE());
            AddTestScripts(new ADMUDT12_SMOKE());
            AddTestScripts(new ADMUDT13_SMOKE());
            AddTestScripts(new ADMUDT14_SMOKE());
            AddTestScripts(new ADMUDT15_SMOKE());
            AddTestScripts(new ADPIMPORT_SMOKE());
            AddTestScripts(new ADPIMPORTLOG_SMOKE());
        }
    }
}
