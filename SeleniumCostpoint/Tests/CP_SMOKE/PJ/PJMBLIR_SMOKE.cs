 
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
    public class PJMBLIR_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Encumbrance Tracking", "xpath","//div[@class='navItem'][.='Encumbrance Tracking']").Click();
new SeleniumControl(sDriver,"Manage Project Budget Line Item Revisions", "xpath","//div[@class='navItem'][.='Manage Project Budget Line Item Revisions']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBLIR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBLIR] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBLIR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMBLIR_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBLIR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBLIR] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMBLIR_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMBLIR_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBLIR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBLIR] Performing VerifyExists on BudgetLineItemRevisionsLink...", Logger.MessageType.INF);
				SeleniumControl PJMBLIR_BudgetLineItemRevisionsLink = new SeleniumControl( sDriver, "BudgetLineItemRevisionsLink", "ID", "lnk_3798_PJMBLIR_PROJBUGLNREV_HDR");
				Function.AssertEqual(true,PJMBLIR_BudgetLineItemRevisionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Budget Line Item Revisions");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBLIR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBLIR] Performing Click on BudgetLineItemRevisionsLink...", Logger.MessageType.INF);
				SeleniumControl PJMBLIR_BudgetLineItemRevisionsLink = new SeleniumControl( sDriver, "BudgetLineItemRevisionsLink", "ID", "lnk_3798_PJMBLIR_PROJBUGLNREV_HDR");
				Function.WaitControlDisplayed(PJMBLIR_BudgetLineItemRevisionsLink);
PJMBLIR_BudgetLineItemRevisionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBLIR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBLIR] Performing VerifyExists on BudgetLineItemRevisionsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBLIR_BudgetLineItemRevisionsForm = new SeleniumControl( sDriver, "BudgetLineItemRevisionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBLIR_PROJBUGLNREV_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBLIR_BudgetLineItemRevisionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBLIR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBLIR] Performing VerifyExist on BudgetLineItemRevisionsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMBLIR_BudgetLineItemRevisionsFormTable = new SeleniumControl( sDriver, "BudgetLineItemRevisionsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBLIR_PROJBUGLNREV_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBLIR_BudgetLineItemRevisionsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBLIR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBLIR] Performing ClickButton on BudgetLineItemRevisionsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBLIR_BudgetLineItemRevisionsForm = new SeleniumControl( sDriver, "BudgetLineItemRevisionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBLIR_PROJBUGLNREV_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBLIR_BudgetLineItemRevisionsForm);
IWebElement formBttn = PJMBLIR_BudgetLineItemRevisionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBLIR_BudgetLineItemRevisionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBLIR_BudgetLineItemRevisionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBLIR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBLIR] Performing VerifyExists on BudgetLineItemRevisions_RevisionID...", Logger.MessageType.INF);
				SeleniumControl PJMBLIR_BudgetLineItemRevisions_RevisionID = new SeleniumControl( sDriver, "BudgetLineItemRevisions_RevisionID", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBLIR_PROJBUGLNREV_CHLD_']/ancestor::form[1]/descendant::*[@id='REV_ID']");
				Function.AssertEqual(true,PJMBLIR_BudgetLineItemRevisions_RevisionID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBLIR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBLIR] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBLIR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBLIR_MainForm);
IWebElement formBttn = PJMBLIR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

