 
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
    public class PJMPYCST_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Project History", "xpath","//div[@class='navItem'][.='Project History']").Click();
new SeleniumControl(sDriver,"Manage Prior Year Cost and Revenue", "xpath","//div[@class='navItem'][.='Manage Prior Year Cost and Revenue']").Click();


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
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMPYCST_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing VerifyExists on FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_FiscalYear = new SeleniumControl( sDriver, "FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,PJMPYCST_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILD FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing VerifyExist on DetailsTable...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_DetailsTable = new SeleniumControl( sDriver, "DetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPYCST_PSRPYSUM_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPYCST_DetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing ClickButton on DetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_DetailsForm = new SeleniumControl( sDriver, "DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPYCST_PSRPYSUM_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPYCST_DetailsForm);
IWebElement formBttn = PJMPYCST_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMPYCST_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMPYCST_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing VerifyExists on DetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_DetailsForm = new SeleniumControl( sDriver, "DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPYCST_PSRPYSUM_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMPYCST_DetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing VerifyExists on Details_AccountName...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_Details_AccountName = new SeleniumControl( sDriver, "Details_AccountName", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPYCST_PSRPYSUM_CHILD_']/ancestor::form[1]/descendant::*[@id='ACCT_NAME']");
				Function.AssertEqual(true,PJMPYCST_Details_AccountName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing VerifyExists on Details_PriorYearPoolAmountsLink...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_Details_PriorYearPoolAmountsLink = new SeleniumControl( sDriver, "Details_PriorYearPoolAmountsLink", "ID", "lnk_1004508_PJMPYCST_PSRPYSUM_CHILD");
				Function.AssertEqual(true,PJMPYCST_Details_PriorYearPoolAmountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing Click on Details_PriorYearPoolAmountsLink...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_Details_PriorYearPoolAmountsLink = new SeleniumControl( sDriver, "Details_PriorYearPoolAmountsLink", "ID", "lnk_1004508_PJMPYCST_PSRPYSUM_CHILD");
				Function.WaitControlDisplayed(PJMPYCST_Details_PriorYearPoolAmountsLink);
PJMPYCST_Details_PriorYearPoolAmountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing VerifyExist on PriorYearPoolAmountsTable...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_PriorYearPoolAmountsTable = new SeleniumControl( sDriver, "PriorYearPoolAmountsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPYCST_PSRPYBURDSUM_TABLE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPYCST_PriorYearPoolAmountsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing ClickButton on PriorYearPoolAmountsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_PriorYearPoolAmountsForm = new SeleniumControl( sDriver, "PriorYearPoolAmountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPYCST_PSRPYBURDSUM_TABLE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPYCST_PriorYearPoolAmountsForm);
IWebElement formBttn = PJMPYCST_PriorYearPoolAmountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMPYCST_PriorYearPoolAmountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMPYCST_PriorYearPoolAmountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing VerifyExists on PriorYearPoolAmountsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_PriorYearPoolAmountsForm = new SeleniumControl( sDriver, "PriorYearPoolAmountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPYCST_PSRPYBURDSUM_TABLE_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMPYCST_PriorYearPoolAmountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing VerifyExists on PriorYearPoolAmounts_Pool...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_PriorYearPoolAmounts_Pool = new SeleniumControl( sDriver, "PriorYearPoolAmounts_Pool", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPYCST_PSRPYBURDSUM_TABLE_']/ancestor::form[1]/descendant::*[@id='POOL_NO']");
				Function.AssertEqual(true,PJMPYCST_PriorYearPoolAmounts_Pool.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing Close on PriorYearPoolAmountsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_PriorYearPoolAmountsForm = new SeleniumControl( sDriver, "PriorYearPoolAmountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPYCST_PSRPYBURDSUM_TABLE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPYCST_PriorYearPoolAmountsForm);
IWebElement formBttn = PJMPYCST_PriorYearPoolAmountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPYCST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPYCST] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPYCST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPYCST_MainForm);
IWebElement formBttn = PJMPYCST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogWithMessage("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogWithMessage]" , ex.Message));
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

