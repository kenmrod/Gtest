using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumCostpoint.Common;
using Core.Sys;
using Core.Sys.Selenium;
using OpenQA.Selenium;

namespace SeleniumCostpoint.Tests.CP_BUILD
{
    public class CheckUser : SeleniumTestScript
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

                /* 2 - Click Query button */
                try
                {
                    Function.CurrentComponent = "SYMUSR";
                    Function.WaitLoadingFinished();
                    Driver.SessionLogger.WriteLine("[SYMUSR] Perfoming Click on Query...", Logger.MessageType.INF);
                    SeleniumControl SYMUSR_MainForm = new SeleniumControl(sDriver, "Query", "xpath", "//div[@id='0']/form[1]");
                    Function.WaitControlDisplayed(SYMUSR_MainForm);
                    IWebElement formBttn = SYMUSR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Where(x => x.Displayed).FirstOrDefault();
                    if (formBttn != null)
                        formBttn.Click();
                    else
                        throw new Exception("Query Button not found ");
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking SYMUSR Query button [ln 55]. ", ex.Message));
                }

                /* 3 - Set Criteria Value */
                try
                {
                    Function.CurrentComponent = "Query";
                    Function.WaitLoadingFinished();
                    Driver.SessionLogger.WriteLine("[Query] Perfoming Set on Criteria Value...", Logger.MessageType.INF);
                    SeleniumControl QUERY_Find_CriteriaValue1 = new SeleniumControl(sDriver, "Find_CriteriaValue1", "ID", "basicField0");
                    QUERY_Find_CriteriaValue1.Click();
                    QUERY_Find_CriteriaValue1.SendKeys("CPBUILDACCEPTANCE", true);
                    Function.WaitLoadingFinished();
                    QUERY_Find_CriteriaValue1.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error setting Criteria Value in SYMUSR Query ", ex.Message));
                }

                /* 4 - Click Find Count */
                try
                {
                    Function.CurrentComponent = "Query";
                    Function.WaitLoadingFinished();
                    Driver.SessionLogger.WriteLine("[Query] Perfoming click on Find Count...", Logger.MessageType.INF);
                    new SeleniumControl(sDriver, "Find_Count", "ID", "basicCountBttn").Click();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Find Count in SYMUSR Query ", ex.Message));
                }

                /* 5 - Verify Find Count Results */
                try
                {
                    Function.CurrentComponent = "Query";
                    Function.WaitLoadingFinished();
                    SeleniumControl QUERY_Find_Count_Results = new SeleniumControl(sDriver, "Find_Count_Results", "ID", "basicCountBox");
                    QUERY_Find_Count_Results.FindElement();
                    Function.AssertEqual(Function.ReplaceCarriageReturn("0 records will be returned", ""), Function.ReplaceCarriageReturn(QUERY_Find_Count_Results.mElement.Text.Trim(), ""));
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error verifying text in Find Count Results in SYMUSR Query ", ex.Message));
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
