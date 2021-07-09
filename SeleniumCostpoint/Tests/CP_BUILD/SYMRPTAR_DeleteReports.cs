using System;
using System.Collections.Generic;
using System.Linq;
using Core.Sys;
using Core.Sys.Selenium;
using SeleniumCostpoint.Common;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumCostpoint.Tests
{
    public class SYMRPTAR_DeleteReports : SeleniumTestScript
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

                /* 1 - Navigate to SYMRPTAR */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

                    this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
                    SeleniumControl CP7Main_NavMenu = new SeleniumControl(sDriver, "NavMenu", "ID", "navCont");
                    if (!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver, "Browse", "css", "span[id = 'goToLbl']").Click();
                    new SeleniumControl(sDriver, "Admin", "xpath", "//div[@class='busItem'][.='Admin']").Click();
                    new SeleniumControl(sDriver, "System Administration", "xpath", "//div[@class='deptItem'][.='System Administration']").Click();
                    new SeleniumControl(sDriver, "System Administration Reports/Inquiries", "xpath", "//div[@class='navItem'][.='System Administration Reports/Inquiries']").Click();
                    new SeleniumControl(sDriver, "Print Archived Reports", "xpath", "//div[@class='navItem'][.='Print Archived Reports']").Click();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error performing [SelectMenu]", ex.Message));
                }

                /* 2 - Select All Rows/Reports */
                try
                {
                    Function.CurrentComponent = "SYMRPTAR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMRPTAR] Perfoming Click on Delete button...", Logger.MessageType.INF);
                    SeleniumControl SYMRPTAR_MainFormTable = new SeleniumControl(sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
                    Function.WaitControlDisplayed(SYMRPTAR_MainFormTable);
                    IWebElement tblBttn = SYMRPTAR_MainFormTable.mElement.FindElements(By.Id("selectAllImg")).Where(x => x.Displayed).FirstOrDefault();
                    if (tblBttn != null)
                    {
                        tblBttn.Click();
                    }
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Select All ", ex.Message));
                }

                /* 3 - Click Delete */
                try
                {
                    Function.CurrentComponent = "SYMRPTAR";
                    Function.WaitLoadingFinished();
                    this.ScriptLogger.WriteLine("[SYMRPTAR] Perfoming Click on Delete button...", Logger.MessageType.INF);
                    SeleniumControl SYMRPTAR_MainForm = new SeleniumControl(sDriver, "SYMRPTAR_MainForm", "xpath", "//div[@id='0']/form[1]");
                    Function.WaitControlDisplayed(SYMRPTAR_MainForm);
                    IWebElement formBttn = SYMRPTAR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).Where(x => x.Displayed).FirstOrDefault();
                    if (formBttn != null)
                    {
                        formBttn.Click();
                    }
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Delete ", ex.Message));
                }

                /* 4 - Click Save */
                try
                {
                    Function.CurrentComponent = "CP7Main";
                    SeleniumControl CP7Main_MainToolBar = new SeleniumControl(sDriver, "MainToolBar", "ID", "tlbr");
                    Function.WaitControlDisplayed(CP7Main_MainToolBar);
                    IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save (F5)')]")).FirstOrDefault();
                    if (tlbrBtn == null)
                        throw new Exception("Unable to find button Save (F5).");
                    Thread.Sleep(800);
                    tlbrBtn.Click();
                    Thread.Sleep(1000);
                    Function.WaitLoadingFinished();
                }
                catch (Exception ex)
                {
                    throw new Exception(TraceMessage("Error clicking Save ", ex.Message));
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
