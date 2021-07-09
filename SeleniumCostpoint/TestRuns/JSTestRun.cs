using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Tests;

namespace SeleniumCostpoint.TestRuns
{
    public class JSTestRun : SeleniumTestRun
    {
        #region CONSTANTS
        private const int IDX_ARG_PATH = 0;
        private const int IDX_ARG_BROWSER = 1;
        private const int IDX_ARG_ENV = 2;
        private const int COUNT_EXACT_TEST_DELIMITER = 2;
        #endregion

        #region PUBLIC
        public JSTestRun(Logger SessionLogger) : base(SessionLogger) { }

        public override void ExecuteTests(object[] Arguments)
        {
            foreach (InputTest test in GetInputTests(Arguments.First().ToString())) /* for now only path is being passed */
            {
                new JSTest().Run(this, GetBrowser(test.browser), test.environment, true, test.path);
            }
        }

        public override void ExecuteTests()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region PRIVATE
        private SeleniumDriver.Browser GetBrowser(string browserName)
        {
            switch (browserName.ToLower())
            {
                case "firefox":
                    return SeleniumDriver.Browser.FIREFOX;
                case "ie":
                    return SeleniumDriver.Browser.IE;
                case "chrome":
                default:
                    return SeleniumDriver.Browser.CHROME;

            }
        }

        private List<InputTest> GetInputTests(string TestRunPath)
        {
            List<InputTest> ret = new List<InputTest>();
            var lines = System.IO.File.ReadAllLines(TestRunPath);
            for (int idx = 0; idx < lines.Count(); idx++)
            {
                if (lines[idx].Count(x => x == '|') != 2 )
                {
                    SessionLogger.WriteLine("Invalid format detected on line " + idx + ". Skipping...");
                    Thread.Sleep(1000); /* allow timer to tick, when 1line only errors out, messes up the logger */
                    continue;
                }
                string[] iT = lines[idx].Split('|');
                ret.Add(new InputTest { path = iT[IDX_ARG_PATH], browser = iT[IDX_ARG_BROWSER], environment = iT[IDX_ARG_ENV] });
            }
            return ret;
        }

        private class InputTest
        {
            public string path { get; set; }
            public string browser { get; set; }
            public string environment { get; set; }
        }
        #endregion
    }
}
