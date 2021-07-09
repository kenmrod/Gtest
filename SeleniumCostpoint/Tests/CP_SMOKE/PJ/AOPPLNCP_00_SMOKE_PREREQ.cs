 
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
    public class AOPPLNCP_00_SMOKE_PREREQ : SeleniumTestScript
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
new SeleniumControl(sDriver,"Project Setup", "xpath","//div[@class='deptItem'][.='Project Setup']").Click();
new SeleniumControl(sDriver,"Project Setup Controls", "xpath","//div[@class='navItem'][.='Project Setup Controls']").Click();
new SeleniumControl(sDriver,"Configure Project Settings", "xpath","//div[@class='navItem'][.='Configure Project Settings']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMSETNG_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing VerifyExists on InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_BudgetingAndETC...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_BudgetingAndETC = new SeleniumControl( sDriver, "InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_BudgetingAndETC", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_BUDGET_METHOD' and @value='O']");
				Function.AssertEqual(true,PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_BudgetingAndETC.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing Select on InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_AdvancedBudgeting...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_AdvancedBudgeting = new SeleniumControl( sDriver, "InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_AdvancedBudgeting", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_BUDGET_METHOD' and @value='N']");
				Function.WaitControlDisplayed(PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_AdvancedBudgeting);
PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_AdvancedBudgeting.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMSETNG] Performing Select on InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_BudgetingAndETC...", Logger.MessageType.INF);
				SeleniumControl PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_BudgetingAndETC = new SeleniumControl( sDriver, "InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_BudgetingAndETC", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_BUDGET_METHOD' and @value='O']");
				Function.WaitControlDisplayed(PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_BudgetingAndETC);
PJMSETNG_InterCompanyWorkOrders_ProjectProcessSettings_SelectBudgetingMethod_BudgetingAndETC.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SAVE AND CLOSE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Save.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(true));

				this.ScriptLogger.WriteLine("[CP7Main] Performing VerifyMessageExists on MessagesArea...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MessagesArea = new SeleniumControl( sDriver, "MessagesArea", "XPATH", "//div[contains(@class,'msg') and contains(@style,'visible')]");
				Function.WaitControlDisplayed(CP7Main_MessagesArea);
IList<IWebElement> msgElements = sDriver.Instance.FindElements(By.XPath("//span[contains(@class,'msgTextHdr')]/following-sibling::span[not(contains(@class,'msgTextHdr'))]"));
Function.AssertEqual(true, msgElements.ToList().Select(x => new SeleniumControl( sDriver, "x", x).GetValue().Trim()).Any(x => x == "Record modifications successfully completed."));


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyMessageExists]" , ex.Message));
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

