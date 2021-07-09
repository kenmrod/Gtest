 
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
    public class PRPAPVCH_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Payroll", "xpath","//div[@class='deptItem'][.='Payroll']").Click();
new SeleniumControl(sDriver,"Payroll Closing", "xpath","//div[@class='navItem'][.='Payroll Closing']").Click();
new SeleniumControl(sDriver,"Create Accounts Payable Vouchers", "xpath","//div[@class='navItem'][.='Create Accounts Payable Vouchers']").Click();


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
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRPAPVCH_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,PRPAPVCH_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing VerifyExists on StateNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_StateNonContiguousLink = new SeleniumControl( sDriver, "StateNonContiguousLink", "ID", "lnk_15110_PRPAPVCH_PARAM");
				Function.AssertEqual(true,PRPAPVCH_StateNonContiguousLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing Click on StateNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_StateNonContiguousLink = new SeleniumControl( sDriver, "StateNonContiguousLink", "ID", "lnk_15110_PRPAPVCH_PARAM");
				Function.WaitControlDisplayed(PRPAPVCH_StateNonContiguousLink);
PRPAPVCH_StateNonContiguousLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing VerifyExists on StateNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_StateNonContiguousForm = new SeleniumControl( sDriver, "StateNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRPAPVCH_NCR_STATECD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRPAPVCH_StateNonContiguousForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing VerifyExist on StateNonContiguousTable...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_StateNonContiguousTable = new SeleniumControl( sDriver, "StateNonContiguousTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRPAPVCH_NCR_STATECD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRPAPVCH_StateNonContiguousTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing Close on StateNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_StateNonContiguousForm = new SeleniumControl( sDriver, "StateNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRPAPVCH_NCR_STATECD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRPAPVCH_StateNonContiguousForm);
IWebElement formBttn = PRPAPVCH_StateNonContiguousForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing VerifyExists on LocalitiesNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_LocalitiesNonContiguousLink = new SeleniumControl( sDriver, "LocalitiesNonContiguousLink", "ID", "lnk_15111_PRPAPVCH_PARAM");
				Function.AssertEqual(true,PRPAPVCH_LocalitiesNonContiguousLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing Click on LocalitiesNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_LocalitiesNonContiguousLink = new SeleniumControl( sDriver, "LocalitiesNonContiguousLink", "ID", "lnk_15111_PRPAPVCH_PARAM");
				Function.WaitControlDisplayed(PRPAPVCH_LocalitiesNonContiguousLink);
PRPAPVCH_LocalitiesNonContiguousLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing VerifyExists on LocalitiesNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_LocalitiesNonContiguousForm = new SeleniumControl( sDriver, "LocalitiesNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRPAPVCH_NCR_LOCALCD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRPAPVCH_LocalitiesNonContiguousForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing VerifyExist on LocalitiesNonContiguousTable...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_LocalitiesNonContiguousTable = new SeleniumControl( sDriver, "LocalitiesNonContiguousTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRPAPVCH_NCR_LOCALCD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRPAPVCH_LocalitiesNonContiguousTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing Close on LocalitiesNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_LocalitiesNonContiguousForm = new SeleniumControl( sDriver, "LocalitiesNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRPAPVCH_NCR_LOCALCD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRPAPVCH_LocalitiesNonContiguousForm);
IWebElement formBttn = PRPAPVCH_LocalitiesNonContiguousForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing VerifyExists on DeductionsContributionsNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_DeductionsContributionsNonContiguousLink = new SeleniumControl( sDriver, "DeductionsContributionsNonContiguousLink", "ID", "lnk_15112_PRPAPVCH_PARAM");
				Function.AssertEqual(true,PRPAPVCH_DeductionsContributionsNonContiguousLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing Click on DeductionsContributionsNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_DeductionsContributionsNonContiguousLink = new SeleniumControl( sDriver, "DeductionsContributionsNonContiguousLink", "ID", "lnk_15112_PRPAPVCH_PARAM");
				Function.WaitControlDisplayed(PRPAPVCH_DeductionsContributionsNonContiguousLink);
PRPAPVCH_DeductionsContributionsNonContiguousLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing VerifyExists on DeductionsContributionsNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_DeductionsContributionsNonContiguousForm = new SeleniumControl( sDriver, "DeductionsContributionsNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRPAPVCH_NCR_DEDCD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRPAPVCH_DeductionsContributionsNonContiguousForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing VerifyExist on DeductionsContributionsNonContiguousTable...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_DeductionsContributionsNonContiguousTable = new SeleniumControl( sDriver, "DeductionsContributionsNonContiguousTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRPAPVCH_NCR_DEDCD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRPAPVCH_DeductionsContributionsNonContiguousTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing Close on DeductionsContributionsNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_DeductionsContributionsNonContiguousForm = new SeleniumControl( sDriver, "DeductionsContributionsNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRPAPVCH_NCR_DEDCD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRPAPVCH_DeductionsContributionsNonContiguousForm);
IWebElement formBttn = PRPAPVCH_DeductionsContributionsNonContiguousForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRPAPVCH_MainForm);
IWebElement formBttn = PRPAPVCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRPAPVCH_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRPAPVCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRPAPVCH_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRPAPVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRPAPVCH] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRPAPVCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRPAPVCH_MainForm);
IWebElement formBttn = PRPAPVCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

