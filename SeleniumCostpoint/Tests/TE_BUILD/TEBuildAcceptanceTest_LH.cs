using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Common;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumCostpoint.Tests.TE_BUILD
{
    public class TEBuildAcceptanceTest_LH : SeleniumTestScript
    {
        public override bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {
            bool ret = true;
            ErrorMessage = string.Empty;
            SeleniumDriver sDriver = Driver as SeleniumDriver;
            Functions Function = new Functions(sDriver);

            try
            {
                /* Login */
                Function.Login(TestEnvironment, out ErrorMessage);

                /* 1 - Navigate to Timesheets app */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitLoadingFinished();
                    sDriver.SessionLogger.WriteLine("[CP7Main] Perfoming SelectMenu on NavMenu...", Logger.MessageType.INF);
                    SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver,"NavMenu", "ID", "navCont");
                    if (!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed)
                        new SeleniumControl( sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
                    new SeleniumControl( sDriver,"Time & Expense", "xpath", "//div[@class='busItem'][.='Time & Expense']").Click();
                    new SeleniumControl( sDriver,"Time", "xpath", "//div[@class='deptItem'][.='Time']").Click();
                    new SeleniumControl( sDriver,"Timesheets", "xpath", "//div[@class='navItem'][.='Timesheets']").Click();
                    new SeleniumControl( sDriver,"Manage/Approve Timesheets", "xpath", "//div[@class='navItem'][.='Manage/Approve Timesheets']").Click();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error navigating to Manage/Approve Timesheets app [ln 39]. " + ex.Message);
                }

                /* 2 - Click Execute */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitLoadingFinished();
                    sDriver.SessionLogger.WriteLine("[CP7Main] Perfoming ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
                    SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver,"MainToolBar", "ID", "tlbr");
                    Function.WaitControlDisplayed(CP7Main_MainToolBar);
                    IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute (F3)')]")).FirstOrDefault();
                    if (tlbrBtn == null)
                        throw new Exception("Unable to find button Execute (F3).");
                    tlbrBtn.Click();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error clicking Excute [ln 57]. " + ex.Message);
                }
                /* 3 - Click Browse Apps */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitLoadingFinished();
                    sDriver.SessionLogger.WriteLine("[CP7Main] Perfoming Click on BrowseApplications...", Logger.MessageType.INF);
                    SeleniumControl CP7Main_BrowseApplications = new SeleniumControl( sDriver,"BrowseApplications", "ID", "goToLbl");
                    Function.WaitControlDisplayed(CP7Main_BrowseApplications);
                    if (CP7Main_BrowseApplications.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
                        CP7Main_BrowseApplications.Click(5, 5);
                    else
                        CP7Main_BrowseApplications.Click(4.5);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error clicking Browse Apps [ln 74]. " + ex.Message);
                }

                /* 4 - Navigate to Manage/Approve Expense Authorization */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    if (!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed)
                        new SeleniumControl( sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
                    new SeleniumControl( sDriver,"Time & Expense", "xpath", "//div[@class='busItem'][.='Time & Expense']").Click();
                    new SeleniumControl( sDriver,"Expense", "xpath", "//div[@class='deptItem'][.='Expense']").Click();
                    new SeleniumControl( sDriver,"Expense Authorizations", "xpath", "//div[@class='navItem'][.='Expense Authorizations']").Click();
                    new SeleniumControl( sDriver,"Manage/Approve Expense Authorizations", "xpath", "//div[@class='navItem'][.='Manage/Approve Expense Authorizations']").Click();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error navigating to Manage/Approve Expense Authorization app [ln 90]. " + ex.Message);
                }

                /* 5 - Click Execute */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver,"MainToolBar", "ID", "tlbr");
                    Function.WaitControlDisplayed(CP7Main_MainToolBar);
                    IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute (F3)123')]")).FirstOrDefault();
                    if (tlbrBtn == null)
                        throw new Exception("Unable to find button Execute (F3)123.");
                    tlbrBtn.Click();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error clicking Execute [ln 106]. " + ex.Message);
                }

                /* 6 - Logout */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitLoadingFinished();
                    sDriver.SessionLogger.WriteLine("[CP7Main] Perfoming Click on LogOut...", Logger.MessageType.INF);
                    SeleniumControl CP7Main_LogOut = new SeleniumControl( sDriver,"LogOut", "ID", "lgoffBttn");
                    Function.WaitControlDisplayed(CP7Main_LogOut);
                    if (CP7Main_LogOut.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
                        CP7Main_LogOut.Click(5, 5);
                    else
                        CP7Main_LogOut.Click(4.5);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error logging out [ln 124]. " + ex.Message);
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
