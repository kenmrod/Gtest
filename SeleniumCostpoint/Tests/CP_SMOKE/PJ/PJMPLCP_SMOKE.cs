 
using System;
using System.Threading.Tasks;
using SeleniumCostpoint.Common;
using System.Collections.Generic;
using Core.Sys;
using Core.Sys.Selenium;
using System.Threading;
using System.Linq;
using OpenQA.Selenium;

namespace SeleniumCostpoint.Tests
{
    public class PJMPLCP_SMOKE : SeleniumTestScript
    {
        public override bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {
			bool ret = true;
			ErrorMessage = string.Empty;
			SeleniumDriver sDriver = Driver as SeleniumDriver;
			Functions Function = new Functions(sDriver, this);

			try
			{
				Function.Login( TestEnvironment, out ErrorMessage);
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"Projects", "xpath","//div[@class='busItem'][.='Projects']").Click();
new SeleniumControl(sDriver,"Budgeting and ETC", "xpath","//div[@class='deptItem'][.='Budgeting and ETC']").Click();
new SeleniumControl(sDriver,"Period Budgets", "xpath","//div[@class='navItem'][.='Period Budgets']").Click();
new SeleniumControl(sDriver,"Manage PLC Budgets By Period", "xpath","//div[@class='navItem'][.='Manage PLC Budgets By Period']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMPLCP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCP] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMPLCP_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMPLCP_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPLCP_MainForm);
IWebElement formBttn = PJMPLCP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMPLCP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMPLCP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMPLCP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPLCP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("BUDGETS BY PERIOD");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCP] Performing VerifyExists on BudgetsByPeriodLink...", Logger.MessageType.INF);
				SeleniumControl PJMPLCP_BudgetsByPeriodLink = new SeleniumControl( sDriver, "BudgetsByPeriodLink", "ID", "lnk_1000887_PJMPLCP_PROJBUDPLC_HDR");
				Function.AssertEqual(true,PJMPLCP_BudgetsByPeriodLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCP] Performing Click on BudgetsByPeriodLink...", Logger.MessageType.INF);
				SeleniumControl PJMPLCP_BudgetsByPeriodLink = new SeleniumControl( sDriver, "BudgetsByPeriodLink", "ID", "lnk_1000887_PJMPLCP_PROJBUDPLC_HDR");
				Function.WaitControlDisplayed(PJMPLCP_BudgetsByPeriodLink);
PJMPLCP_BudgetsByPeriodLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCP] Performing VerifyExist on BudgetsByPeriodFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMPLCP_BudgetsByPeriodFormTable = new SeleniumControl( sDriver, "BudgetsByPeriodFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPLCP_PROJBUDPLC_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPLCP_BudgetsByPeriodFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCP] Performing ClickButton on BudgetsByPeriodForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCP_BudgetsByPeriodForm = new SeleniumControl( sDriver, "BudgetsByPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPLCP_PROJBUDPLC_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPLCP_BudgetsByPeriodForm);
IWebElement formBttn = PJMPLCP_BudgetsByPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMPLCP_BudgetsByPeriodForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMPLCP_BudgetsByPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCP] Performing VerifyExists on BudgetsByPeriod_PLCDetails_PLC...", Logger.MessageType.INF);
				SeleniumControl PJMPLCP_BudgetsByPeriod_PLCDetails_PLC = new SeleniumControl( sDriver, "BudgetsByPeriod_PLCDetails_PLC", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPLCP_PROJBUDPLC_CHILD_']/ancestor::form[1]/descendant::*[@id='BILL_LAB_CAT_CD']");
				Function.AssertEqual(true,PJMPLCP_BudgetsByPeriod_PLCDetails_PLC.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPLCP_MainForm);
IWebElement formBttn = PJMPLCP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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

