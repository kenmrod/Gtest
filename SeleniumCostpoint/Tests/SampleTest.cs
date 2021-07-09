using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCostpoint.Tests
{
    class SampleTest: SeleniumTestScript
    {
        public override bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {

            try
            {
                ErrorMessage = string.Empty;
                SeleniumDriver sDriver = Driver as SeleniumDriver;
                Functions Function = new Functions(sDriver, this);
                
                Function.Login(TestEnvironment, out ErrorMessage);
                return true;
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
                return false;
            }
        }
    }
}
