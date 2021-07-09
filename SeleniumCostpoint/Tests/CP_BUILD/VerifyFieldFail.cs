using System;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Common;
using OpenQA.Selenium;

namespace SeleniumCostpoint.Tests
{
    public class VerifyFieldFail : SeleniumTestScript
    {
        public override bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {
            bool ret = true;
            ErrorMessage = string.Empty;
            SeleniumDriver sDriver = Driver as SeleniumDriver;
            Functions Function = new Functions(sDriver, this);
            try
            {
                /* Log-in */
                Function.Login(TestEnvironment, out ErrorMessage);

                /* 1 - Navigate to Manage Users */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitLoadingFinished();
                    if (!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed)
                        new SeleniumControl(sDriver, "Browse", "css", "span[id = 'goToLbl']").Click();
                    new SeleniumControl(sDriver, "Admin", "xpath", "//div[@class='busItem'][.='Admin']").Click();
                    new SeleniumControl(sDriver, "Security", "xpath", "//div[@class='deptItem'][.='Security']").Click();
                    new SeleniumControl(sDriver, "System Security", "xpath", "//div[@class='navItem'][.='System Security']").Click();
                    new SeleniumControl(sDriver, "Manage Users", "xpath", "//div[@class='navItem'][.='Manage Users']").Click();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error navigating to Manage Users app ", ex.Message));
                }

                /* 2 - Verify MainForm exists*/
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    Function.AssertEqual(true, new SeleniumControl(sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]").Exists());
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error verifying main form ", ex.Message));
                }

            }
            catch (Exception ex)
            {
                ret = false;
                ErrorMessage = ex.Message;
                throw new Exception(ex.Message);
            }
            return ret;
        }
    }
}
