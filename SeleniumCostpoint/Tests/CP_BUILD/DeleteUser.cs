using System;
using System.Linq;
using SeleniumCostpoint.Common;
using Core.Sys;
using Core.Sys.Selenium;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumCostpoint.Tests.CP_BUILD
{
    public class DeleteUser : SeleniumTestScript
    {
        public override bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {
            bool ret = true;
            ErrorMessage = string.Empty;
            SeleniumDriver sDriver = Driver as SeleniumDriver;
            Functions Function = new Functions(sDriver);

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
                        new SeleniumControl( sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
                    new SeleniumControl( sDriver,"Admin", "xpath", "//div[@class='busItem'][.='Admin']").Click();
                    new SeleniumControl( sDriver,"Security", "xpath", "//div[@class='deptItem'][.='Security']").Click();
                    new SeleniumControl( sDriver,"System Security", "xpath", "//div[@class='navItem'][.='System Security']").Click();
                    new SeleniumControl( sDriver,"Manage Users", "xpath", "//div[@class='navItem'][.='Manage Users']").Click();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error navigating to Manage Users app ", ex.Message));
                }

                /* 2 - Click Query button */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    Driver.SessionLogger.WriteLine("[Query] Perfoming Click on Query...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_MainForm = new SeleniumControl( sDriver,"Query", "xpath", "//div[@id='0']/form[1]");
                    Function.WaitControlDisplayed(SYMUSR_MainForm);
                    IWebElement formBttn = SYMUSR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Where(x => x.Displayed).FirstOrDefault();
                    if (formBttn != null)
                        formBttn.Click();
                    else
                        throw new Exception("Query Button not found ");
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking SYMUSR Query button ", ex.Message));
                }

                /* 3 - Set Criteria Value */
                try
                {
                    Function.CurrentComponent = "Query";
                    Function.WaitLoadingFinished();
                    Driver.SessionLogger.WriteLine("[Query] Perfoming Set on Criteria Value...", Logger.MessageType.INF);
                    SeleniumControl QUERY_Find_CriteriaValue1 = new SeleniumControl( sDriver,"Find_CriteriaValue1", "ID", "basicField0");
                    QUERY_Find_CriteriaValue1.Click();
                    QUERY_Find_CriteriaValue1.SendKeys("CPBUILDACCEPTANCE", true);
                    Function.WaitLoadingFinished();
                    QUERY_Find_CriteriaValue1.SendKeys(Keys.Shift + Keys.Tab);
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error setting Criteria Value in SYMUSR Query ", ex.Message));
                }

                /* 4 - Click Find */
                try
                {
                    Function.CurrentComponent = "Query";
                    Function.WaitLoadingFinished();
                    Driver.SessionLogger.WriteLine("[Query] Perfoming Click on Find...", Logger.MessageType.INF);
                    new SeleniumControl( sDriver,"Find", "ID", "submitQ").Click();
                    Thread.Sleep(800);
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Find button in SYMUSR Query ", ex.Message));
                }

                /* 5 - Click Delete button */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    Driver.SessionLogger.WriteLine("[SYMUSR] Perfoming Click on Delete button...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_MainForm = new SeleniumControl( sDriver,"Query", "xpath", "//div[@id='0']/form[1]");
                    Function.WaitControlDisplayed(SYMUSR_MainForm);
                    IWebElement formBttn = SYMUSR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).Where(x => x.Displayed).FirstOrDefault();
                    if (formBttn != null)
                    {
                        formBttn.Click();
                    }
                    else
                        throw new Exception("Delete Button not found ");
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking SYMUSR Delete button ", ex.Message));
                }

                /* 6 - Click Save and continue */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver,"MainToolBar", "ID", "tlbr");
                    Function.WaitControlDisplayed(CP7Main_MainToolBar);
                    IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save & Continue (F6)')]")).FirstOrDefault();
                    if (tlbrBtn == null)
                        throw new Exception("Unable to find button Save & Continue (F6).");
                    Thread.Sleep(800);
                    tlbrBtn.Click();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Save and Continue ", ex.Message));
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
