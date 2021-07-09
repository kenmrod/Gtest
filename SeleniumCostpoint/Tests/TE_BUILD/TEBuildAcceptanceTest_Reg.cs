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
    public class TEBuildAcceptanceTest_Reg : SeleniumTestScript
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
                    new SeleniumControl( sDriver,"Manage Timesheets", "xpath", "//div[@class='navItem'][.='Manage Timesheets']").Click();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error navigating to Manage/Approve Timesheets app [ln 39]. " + ex.Message);
                }

                /* 2 - Click Browse Applications */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitLoadingFinished();
                    sDriver.SessionLogger.WriteLine("[CP7Main] Perfoming Click on BrowseApplications...", Logger.MessageType.INF);
                    SeleniumControl CP7Main_BrowseApplications = new SeleniumControl( sDriver,"BrowseApplications", "ID", "goToLbl");
                    Function.WaitControlDisplayed(CP7Main_BrowseApplications);
                    if (CP7Main_BrowseApplications.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
                        CP7Main_BrowseApplications.Click(5, 5);
                    else CP7Main_BrowseApplications.Click(4.5);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error clicking Browse Applications [ln 56]. " + ex.Message);
                }

                /* 3 - Navigate to Expense Authorization app */
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
                    throw new Exception("Error navigating to Expense Authorization app [ln 72]. " + ex.Message);
                }

                /* 4 - Select FilterBy */
                try
                {
                    Function.CurrentComponent = "EPMEXPAUTHAPPROVE";
                    Function.WaitLoadingFinished();
                    sDriver.SessionLogger.WriteLine("[EPMEXPAUTHAPPROVE] Perfoming Select on FilterBy...", Logger.MessageType.INF);
                    SeleniumControl EPMEXPAUTHAPPROVE_FilterBy = new SeleniumControl( sDriver,"Description", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FILTER_BY']");
                    EPMEXPAUTHAPPROVE_FilterBy.FindElement();
                    EPMEXPAUTHAPPROVE_FilterBy.ScrollIntoViewUsingJavaScript();
                    SeleniumControl EPMEXPAUTHAPPROVE_FilterByList = new SeleniumControl( sDriver,"FilterByList", "xpath_display", "//div[@class='tCCBV']/div[text()='Status']/..");
                    int currRetry = 0;
                    while (++currRetry <= 3)
                    {
                        try
                        {
                            EPMEXPAUTHAPPROVE_FilterBy.Click();
                            EPMEXPAUTHAPPROVE_FilterByList.FindElement(1); // quicker -> if not found then initilize will not be called
                            break;
                        }
                        catch
                        {
                            sDriver.SessionLogger.WriteLine("Unable to display combobox dropdown list...", Logger.MessageType.INF);
                        }
                    }
                    if (currRetry > 3)
                    {
                        throw new Exception("Unable to display combobox dropdown list on final attempt.");
                    }
                    SeleniumControl target = new SeleniumControl( sDriver,"ItemToSelect", EPMEXPAUTHAPPROVE_FilterByList, "xpath", "./descendant::div[text()='Status']");
                    target.Click();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error selecting FilterBy [ln 108]. " + ex.Message);
                }

                /* 5 - Click Execute */
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
                    throw new Exception("Error clicking Excute [ln 126]. " + ex.Message);
                }

                /* 6 - Click Browse Applications */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitLoadingFinished();
                    sDriver.SessionLogger.WriteLine("[CP7Main] Perfoming Click on BrowseApplications...", Logger.MessageType.INF);
                    SeleniumControl CP7Main_BrowseApplications = new SeleniumControl( sDriver,"BrowseApplications", "ID", "goToLbl");
                    Function.WaitControlDisplayed(CP7Main_BrowseApplications);
                    if (CP7Main_BrowseApplications.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
                        CP7Main_BrowseApplications.Click(5, 5);
                    else CP7Main_BrowseApplications.Click(4.5);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error clicking Browse Applications [ln 143]. " + ex.Message);
                }

                /* 7 - Navigate to Manage Expense Report app */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    if (!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl( sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
                    new SeleniumControl( sDriver,"Time & Expense", "xpath", "//div[@class='busItem'][.='Time & Expense']").Click();
                    new SeleniumControl( sDriver,"Expense", "xpath", "//div[@class='deptItem'][.='Expense']").Click();
                    new SeleniumControl( sDriver,"Expense Reports", "xpath", "//div[@class='navItem'][.='Expense Reports']").Click();
                    new SeleniumControl( sDriver,"Manage Expense Report", "xpath", "//div[@class='navItem'][.='Manage Expense Report']").Click();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error navigating to Manage Expense Report app [ln 158]. " + ex.Message);
                }

                /* 8 - Click Browse Applications */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitLoadingFinished();
                    sDriver.SessionLogger.WriteLine("[CP7Main] Perfoming Click on BrowseApplications...", Logger.MessageType.INF);
                    SeleniumControl CP7Main_BrowseApplications = new SeleniumControl( sDriver,"BrowseApplications", "ID", "goToLbl");
                    Function.WaitControlDisplayed(CP7Main_BrowseApplications);
                    if (CP7Main_BrowseApplications.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
                        CP7Main_BrowseApplications.Click(5, 5);
                    else CP7Main_BrowseApplications.Click(4.5);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error clicking Browse Applications [ln 175]. " + ex.Message);
                }

                /* 9 - Navigate to Manage Expense Types app */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    if (!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl( sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
                    new SeleniumControl( sDriver,"Time & Expense", "xpath", "//div[@class='busItem'][.='Time & Expense']").Click();
                    new SeleniumControl( sDriver,"Expense", "xpath", "//div[@class='deptItem'][.='Expense']").Click();
                    new SeleniumControl( sDriver,"Expense Reports", "xpath", "//div[@class='navItem'][.='Expense Controls']").Click();
                    new SeleniumControl( sDriver,"Manage Expense Report", "xpath", "//div[@class='navItem'][.='Manage Expense Types']").Click();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error navigating to Manage Expense Report app [ln 190]. " + ex.Message);
                }

                /* 10 - Set ExpenseTypCode */
                try
                {
                    Function.CurrentComponent = "EPMEXPTYPE";
                    Function.WaitLoadingFinished();
                    sDriver.SessionLogger.WriteLine("[EPMEXPTYPE] Perfoming Set on ExpenseTypeCode...", Logger.MessageType.INF);
                    SeleniumControl EPMEXPTYPE_ExpenseTypeCode = new SeleniumControl( sDriver,"ExpenseTypeCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EXP_TYPE_CD']");
                    EPMEXPTYPE_ExpenseTypeCode.Click();
                    EPMEXPTYPE_ExpenseTypeCode.SendKeys("BUILDTEST", true);
                    Function.WaitLoadingFinished();
                    EPMEXPTYPE_ExpenseTypeCode.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error setting ExpenseTypeCode [ln 207]. " + ex.Message);
                }

                /* 11 - Set Description */
                try
                {

                    Function.CurrentComponent = "EPMEXPTYPE";
                    Function.WaitLoadingFinished();
                    sDriver.SessionLogger.WriteLine("[EPMEXPTYPE] Perfoming Set on Description...", Logger.MessageType.INF);
                    SeleniumControl EPMEXPTYPE_Description = new SeleniumControl( sDriver,"Description", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EXP_TYPE_DESC']");
                    EPMEXPTYPE_Description.Click();
                    EPMEXPTYPE_Description.SendKeys("Build Test", true);
                    Function.WaitLoadingFinished();
                    EPMEXPTYPE_Description.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error setting Description [ln 225]. " + ex.Message);
                }

                /* 12 - Select WizardType */
                try
                {
                    Function.CurrentComponent = "EPMEXPTYPE";
                    Function.WaitLoadingFinished();
                    sDriver.SessionLogger.WriteLine("[EPMEXPTYPE] Perfoming Select on WizardType...", Logger.MessageType.INF);
                    SeleniumControl EPMEXPTYPE_WizardType = new SeleniumControl( sDriver,"Description", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_TYPE_CD']");
                    EPMEXPTYPE_WizardType.FindElement();
                    EPMEXPTYPE_WizardType.ScrollIntoViewUsingJavaScript();
                    SeleniumControl EPMEXPTYPE_WizardTypeList = new SeleniumControl( sDriver,"WizardTypeList", "xpath_display", "//div[@class='tCCBV']/div[text()='Car Rental']/..");
                    int currRetry = 0;
                    while (++currRetry <= 3)
                    {
                        try
                        {
                            EPMEXPTYPE_WizardType.Click();
                            EPMEXPTYPE_WizardTypeList.FindElement(1); // quicker -> if not found then initilize will not be called
                            break;
                        }
                        catch
                        {
                            sDriver.SessionLogger.WriteLine("Unable to display combobox dropdown list...", Logger.MessageType.INF);
                        }
                    }
                    if (currRetry > 3)
                    {
                        throw new Exception("Unable to display combobox dropdown list on final attempt.");
                    }
                    SeleniumControl target = new SeleniumControl( sDriver,"ItemToSelect", EPMEXPTYPE_WizardTypeList, "xpath", "./descendant::div[text()='Car Rental']");
                    target.Click();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error selecting WizardType [ln 261]. " + ex.Message);
                }

                /* 13 - Click Save & Continue */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver,"MainToolBar", "ID", "tlbr");
                    Function.WaitControlDisplayed(CP7Main_MainToolBar);
                    IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save & Continue')]")).FirstOrDefault();
                    if (tlbrBtn == null)
                        throw new Exception("Unable to find button Save & Continue.");
                    Thread.Sleep(800);
                    tlbrBtn.Click();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error clicking Save and Continue [ln 278]. " + ex.Message);
                }

                /* 14 - Click Query */
                try
                {
                    Function.CurrentComponent = "EPMEXPTYPE";
                    Function.WaitLoadingFinished();
                    sDriver.SessionLogger.WriteLine("[EPMEXPTYPE] Perfoming ClickButton on MainForm...", Logger.MessageType.INF);
                    SeleniumControl EPMEXPTYPE_MainForm = new SeleniumControl( sDriver,"MainForm", "xpath", "//div[@id='0']/form[1]");
                    Function.WaitControlDisplayed(EPMEXPTYPE_MainForm);
                    IWebElement formBttn = EPMEXPTYPE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0
                        ? EPMEXPTYPE_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
                    EPMEXPTYPE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
                    if (formBttn != null)
                    {
                        new SeleniumControl( sDriver,"FormButton", formBttn).MouseOver();
                        formBttn.Click();
                    }
                    else
                    {
                        throw new Exception("Query not found");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error clicking Query [ln 304]. " + ex.Message);
                }

                /* 15 - Set Find criteria */
                try
                {
                    Function.CurrentComponent = "Query";
                    Function.WaitLoadingFinished(true);
                    sDriver.SessionLogger.WriteLine("[Query] Perfoming Set on Find_CriteriaValue1...", Logger.MessageType.INF);
                    SeleniumControl Query_Find_CriteriaValue1 = new SeleniumControl( sDriver,"Find_CriteriaValue1", "ID", "basicField0");
                    Query_Find_CriteriaValue1.Click();
                    Query_Find_CriteriaValue1.SendKeys("BUILDTEST", true);
                    Function.WaitLoadingFinished(true);
                    Query_Find_CriteriaValue1.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error setting Find Criteria [ln 321]. " + ex.Message);
                }

                /* 16 - Click Find */
                try
                {
                    Function.CurrentComponent = "Query";
                    Function.WaitLoadingFinished(true);
                    sDriver.SessionLogger.WriteLine("[Query] Perfoming Click on Find...", Logger.MessageType.INF);
                    SeleniumControl Query_Find = new SeleniumControl( sDriver,"Find", "ID", "submitQ");
                    Function.WaitControlDisplayed(Query_Find);
                    if (Query_Find.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
                        Query_Find.Click(5, 5);
                    else Query_Find.Click(4.5);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error clicking Find [ln 338]. " + ex.Message);
                }

                /* 17 - Verify ExpenseTypeCode */
                try
                {
                    Function.CurrentComponent = "EPMEXPTYPE";
                    SeleniumControl EPMEXPTYPE_ExpenseTypeCode = new SeleniumControl( sDriver,"ExpenseTypeCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EXP_TYPE_CD']");
                    Function.AssertEqual("BUILDTEST", EPMEXPTYPE_ExpenseTypeCode.GetAttributeValue("value"));
                }
                catch (Exception ex)
                {
                    throw new Exception("Error verifying ExpenseTypeCode [ln 350]. " + ex.Message);
                }

                /* 18 - Click Delete */
                try
                {
                    Function.CurrentComponent = "EPMEXPTYPE";
                    SeleniumControl EPMEXPTYPE_MainForm = new SeleniumControl( sDriver,"MainForm", "xpath", "//div[@id='0']/form[1]");
                    Function.WaitControlDisplayed(EPMEXPTYPE_MainForm);
                    IWebElement formBttn = EPMEXPTYPE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).Count <= 0
                        ? EPMEXPTYPE_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Delete')]")).FirstOrDefault() :
                    EPMEXPTYPE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).FirstOrDefault();
                    if (formBttn != null)
                    {
                        new SeleniumControl( sDriver,"FormButton", formBttn).MouseOver();
                        formBttn.Click();
                    }
                    else
                    {
                        throw new Exception("Delete not found");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error clicking Delete [ln 374]. " + ex.Message);
                }

                /* 19 - Click Save & Continue */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver,"MainToolBar", "ID", "tlbr");
                    Function.WaitControlDisplayed(CP7Main_MainToolBar);
                    IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save & Continue')]")).FirstOrDefault();
                    if (tlbrBtn == null)
                        throw new Exception("Unable to find button Save & Continue.");
                    Thread.Sleep(800);
                    tlbrBtn.Click();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error clicking Save and Continue [ln 391]. " + ex.Message);
                }

                /* 20 - Logout */
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
                    throw new Exception("Error logging out [ln 409]. " + ex.Message);
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
