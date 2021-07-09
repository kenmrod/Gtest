 
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
    public class APPCKA_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"Accounts Payable", "xpath","//div[@class='deptItem'][.='Accounts Payable']").Click();
new SeleniumControl(sDriver,"Payment Processing", "xpath","//div[@class='navItem'][.='Payment Processing']").Click();
new SeleniumControl(sDriver,"Approve Checks", "xpath","//div[@class='navItem'][.='Approve Checks']").Click();


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
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APPCKA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APPCKA_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing VerifyExists on CashAccountDescription...", Logger.MessageType.INF);
				SeleniumControl APPCKA_CashAccountDescription = new SeleniumControl( sDriver, "CashAccountDescription", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CASH_ACCT_DESC']");
				Function.AssertEqual(true,APPCKA_CashAccountDescription.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing Set on CashAccountDescription...", Logger.MessageType.INF);
				SeleniumControl APPCKA_CashAccountDescription = new SeleniumControl( sDriver, "CashAccountDescription", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CASH_ACCT_DESC']");
				APPCKA_CashAccountDescription.Click();
APPCKA_CashAccountDescription.SendKeys("CASH 00111-010.1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
APPCKA_CashAccountDescription.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Execute.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHECK SUMMARY");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing VerifyExist on CheckSummaryTable...", Logger.MessageType.INF);
				SeleniumControl APPCKA_CheckSummaryTable = new SeleniumControl( sDriver, "CheckSummaryTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APPCKA_CHKDETAILS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APPCKA_CheckSummaryTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing ClickButton on CheckSummaryForm...", Logger.MessageType.INF);
				SeleniumControl APPCKA_CheckSummaryForm = new SeleniumControl( sDriver, "CheckSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APPCKA_CHKDETAILS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APPCKA_CheckSummaryForm);
IWebElement formBttn = APPCKA_CheckSummaryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APPCKA_CheckSummaryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APPCKA_CheckSummaryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing VerifyExists on CheckSummaryForm...", Logger.MessageType.INF);
				SeleniumControl APPCKA_CheckSummaryForm = new SeleniumControl( sDriver, "CheckSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APPCKA_CHKDETAILS_']/ancestor::form[1]");
				Function.AssertEqual(true,APPCKA_CheckSummaryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing VerifyExists on CheckSummary_PayVendorInformation_PayVendorID...", Logger.MessageType.INF);
				SeleniumControl APPCKA_CheckSummary_PayVendorInformation_PayVendorID = new SeleniumControl( sDriver, "CheckSummary_PayVendorInformation_PayVendorID", "xpath", "//div[translate(@id,'0123456789','')='pr__APPCKA_CHKDETAILS_']/ancestor::form[1]/descendant::*[@id='PAY_VEND_ID']");
				Function.AssertEqual(true,APPCKA_CheckSummary_PayVendorInformation_PayVendorID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHECK DETAILS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing VerifyExists on CheckSummary_CheckDetailsLink...", Logger.MessageType.INF);
				SeleniumControl APPCKA_CheckSummary_CheckDetailsLink = new SeleniumControl( sDriver, "CheckSummary_CheckDetailsLink", "ID", "lnk_1003980_APPCKA_CHKDETAILS");
				Function.AssertEqual(true,APPCKA_CheckSummary_CheckDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing Click on CheckSummary_CheckDetailsLink...", Logger.MessageType.INF);
				SeleniumControl APPCKA_CheckSummary_CheckDetailsLink = new SeleniumControl( sDriver, "CheckSummary_CheckDetailsLink", "ID", "lnk_1003980_APPCKA_CHKDETAILS");
				Function.WaitControlDisplayed(APPCKA_CheckSummary_CheckDetailsLink);
APPCKA_CheckSummary_CheckDetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing VerifyExist on CheckSummary_CheckDetailsTable...", Logger.MessageType.INF);
				SeleniumControl APPCKA_CheckSummary_CheckDetailsTable = new SeleniumControl( sDriver, "CheckSummary_CheckDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APPCKA_CHECKDETAIL_VCHRHDRHS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APPCKA_CheckSummary_CheckDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing ClickButton on CheckSummary_CheckDetailsForm...", Logger.MessageType.INF);
				SeleniumControl APPCKA_CheckSummary_CheckDetailsForm = new SeleniumControl( sDriver, "CheckSummary_CheckDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APPCKA_CHECKDETAIL_VCHRHDRHS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APPCKA_CheckSummary_CheckDetailsForm);
IWebElement formBttn = APPCKA_CheckSummary_CheckDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APPCKA_CheckSummary_CheckDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APPCKA_CheckSummary_CheckDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing VerifyExists on CheckSummary_CheckDetailsForm...", Logger.MessageType.INF);
				SeleniumControl APPCKA_CheckSummary_CheckDetailsForm = new SeleniumControl( sDriver, "CheckSummary_CheckDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APPCKA_CHECKDETAIL_VCHRHDRHS_']/ancestor::form[1]");
				Function.AssertEqual(true,APPCKA_CheckSummary_CheckDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing VerifyExists on CheckSummary_CheckDetails_ApprovalInfo_UserID...", Logger.MessageType.INF);
				SeleniumControl APPCKA_CheckSummary_CheckDetails_ApprovalInfo_UserID = new SeleniumControl( sDriver, "CheckSummary_CheckDetails_ApprovalInfo_UserID", "xpath", "//div[translate(@id,'0123456789','')='pr__APPCKA_CHECKDETAIL_VCHRHDRHS_']/ancestor::form[1]/descendant::*[@id='APPRVR_USER_ID']");
				Function.AssertEqual(true,APPCKA_CheckSummary_CheckDetails_ApprovalInfo_UserID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing Close on CheckSummary_CheckDetailsForm...", Logger.MessageType.INF);
				SeleniumControl APPCKA_CheckSummary_CheckDetailsForm = new SeleniumControl( sDriver, "CheckSummary_CheckDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APPCKA_CHECKDETAIL_VCHRHDRHS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APPCKA_CheckSummary_CheckDetailsForm);
IWebElement formBttn = APPCKA_CheckSummary_CheckDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "APPCKA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPCKA] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APPCKA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APPCKA_MainForm);
IWebElement formBttn = APPCKA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

