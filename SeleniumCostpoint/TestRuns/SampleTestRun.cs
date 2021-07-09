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
    class SampleTestRun: SeleniumTestRun
    {
        public SampleTestRun(Logger SessionLogger, String Environment) : base(SessionLogger, Environment) { }

        public override void ExecuteTests()
        {
            new SampleTest().Run(this, SeleniumDriver.Browser.CHROME_HEADLESS, "C71QCM16");
        }
    }
}
