using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCostpoint.TestRuns
{
    public class KP_SAMPLE_COMP : SeleniumTestRun
    {
        public KP_SAMPLE_COMP(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
            SetDefaultArgs(SeleniumDriver.Browser.CHROME_HEADLESS, "CP_STAGING_C71STAGEM");
            AddTestScripts(new KP_FOR_PUPP_COMP());
        }
    }
}
