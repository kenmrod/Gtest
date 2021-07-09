 
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
    public class PJPCKAO_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Cost and Revenue Processing", "xpath","//div[@class='deptItem'][.='Cost and Revenue Processing']").Click();
new SeleniumControl(sDriver,"Cost and Revenue Processing Utilities", "xpath","//div[@class='navItem'][.='Cost and Revenue Processing Utilities']").Click();
new SeleniumControl(sDriver,"Validate Pool Acct/Org Setups", "xpath","//div[@class='navItem'][.='Validate Pool Acct/Org Setups']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKAO] Performing VerifyExists on SelectionRangesForm...", Logger.MessageType.INF);
				SeleniumControl PJPCKAO_SelectionRangesForm = new SeleniumControl( sDriver, "SelectionRangesForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJPCKAO_SelectionRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKAO] Performing VerifyExists on SelectionRanges_Option_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJPCKAO_SelectionRanges_Option_FiscalYear = new SeleniumControl( sDriver, "SelectionRanges_Option_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_RAN']");
				Function.AssertEqual(true,PJPCKAO_SelectionRanges_Option_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKAO] Performing Set on SelectionRanges_Start_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJPCKAO_SelectionRanges_Start_FiscalYear = new SeleniumControl( sDriver, "SelectionRanges_Start_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD_FR']");
				PJPCKAO_SelectionRanges_Start_FiscalYear.Click();
PJPCKAO_SelectionRanges_Start_FiscalYear.SendKeys("Y2010", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PJPCKAO_SelectionRanges_Start_FiscalYear.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKAO] Performing Set on SelectionRanges_End_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJPCKAO_SelectionRanges_End_FiscalYear = new SeleniumControl( sDriver, "SelectionRanges_End_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD_TO']");
				PJPCKAO_SelectionRanges_End_FiscalYear.Click();
PJPCKAO_SelectionRanges_End_FiscalYear.SendKeys("X2010", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PJPCKAO_SelectionRanges_End_FiscalYear.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKAO] Performing Set on SelectionRanges_Start_AllocationGroupNumber...", Logger.MessageType.INF);
				SeleniumControl PJPCKAO_SelectionRanges_Start_AllocationGroupNumber = new SeleniumControl( sDriver, "SelectionRanges_Start_AllocationGroupNumber", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ALLOC_GRP_NO']");
				PJPCKAO_SelectionRanges_Start_AllocationGroupNumber.Click();
PJPCKAO_SelectionRanges_Start_AllocationGroupNumber.SendKeys("1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PJPCKAO_SelectionRanges_Start_AllocationGroupNumber.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ErrorDetails");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKAO] Performing VerifyExist on SelectionRanges_ErrorDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJPCKAO_SelectionRanges_ErrorDetailsFormTable = new SeleniumControl( sDriver, "SelectionRanges_ErrorDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPCKAO_ZPJPTOOLERRORS_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJPCKAO_SelectionRanges_ErrorDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKAO] Performing ClickButton on SelectionRanges_ErrorDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJPCKAO_SelectionRanges_ErrorDetailsForm = new SeleniumControl( sDriver, "SelectionRanges_ErrorDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPCKAO_ZPJPTOOLERRORS_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJPCKAO_SelectionRanges_ErrorDetailsForm);
IWebElement formBttn = PJPCKAO_SelectionRanges_ErrorDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJPCKAO_SelectionRanges_ErrorDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJPCKAO_SelectionRanges_ErrorDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKAO] Performing VerifyExists on SelectionRanges_ErrorDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJPCKAO_SelectionRanges_ErrorDetailsForm = new SeleniumControl( sDriver, "SelectionRanges_ErrorDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPCKAO_ZPJPTOOLERRORS_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJPCKAO_SelectionRanges_ErrorDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKAO] Performing VerifyExists on SelectionRanges_ErrorDetails_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJPCKAO_SelectionRanges_ErrorDetails_FiscalYear = new SeleniumControl( sDriver, "SelectionRanges_ErrorDetails_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPCKAO_ZPJPTOOLERRORS_CHLD_']/ancestor::form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,PJPCKAO_SelectionRanges_ErrorDetails_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKAO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKAO] Performing Close on SelectionRangesForm...", Logger.MessageType.INF);
				SeleniumControl PJPCKAO_SelectionRangesForm = new SeleniumControl( sDriver, "SelectionRangesForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJPCKAO_SelectionRangesForm);
IWebElement formBttn = PJPCKAO_SelectionRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

