 
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
    public class LDMPAYTP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Labor", "xpath","//div[@class='deptItem'][.='Labor']").Click();
new SeleniumControl(sDriver,"Labor Rate Controls", "xpath","//div[@class='navItem'][.='Labor Rate Controls']").Click();
new SeleniumControl(sDriver,"Manage Pay Types", "xpath","//div[@class='navItem'][.='Manage Pay Types']").Click();


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
				Function.CurrentComponent = "LDMPAYTP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMPAYTP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMPAYTP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDMPAYTP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMPAYTP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMPAYTP] Performing VerifyExists on PayTypeCode...", Logger.MessageType.INF);
				SeleniumControl LDMPAYTP_PayTypeCode = new SeleniumControl( sDriver, "PayTypeCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PAY_TYPE']");
				Function.AssertEqual(true,LDMPAYTP_PayTypeCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMPAYTP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMPAYTP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMPAYTP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMPAYTP_MainForm);
IWebElement formBttn = LDMPAYTP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? LDMPAYTP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
LDMPAYTP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMPAYTP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMPAYTP] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl LDMPAYTP_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMPAYTP_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Transaction Currency Overrides Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMPAYTP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMPAYTP] Performing VerifyExists on TransactionCurrencyOverridesLink...", Logger.MessageType.INF);
				SeleniumControl LDMPAYTP_TransactionCurrencyOverridesLink = new SeleniumControl( sDriver, "TransactionCurrencyOverridesLink", "ID", "lnk_16739_LDMPAYTP_PAYTYPE");
				Function.AssertEqual(true,LDMPAYTP_TransactionCurrencyOverridesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMPAYTP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMPAYTP] Performing Click on TransactionCurrencyOverridesLink...", Logger.MessageType.INF);
				SeleniumControl LDMPAYTP_TransactionCurrencyOverridesLink = new SeleniumControl( sDriver, "TransactionCurrencyOverridesLink", "ID", "lnk_16739_LDMPAYTP_PAYTYPE");
				Function.WaitControlDisplayed(LDMPAYTP_TransactionCurrencyOverridesLink);
LDMPAYTP_TransactionCurrencyOverridesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMPAYTP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMPAYTP] Performing VerifyExists on TransactionCurrencyOverridesForm...", Logger.MessageType.INF);
				SeleniumControl LDMPAYTP_TransactionCurrencyOverridesForm = new SeleniumControl( sDriver, "TransactionCurrencyOverridesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMPAYTP_PAYTYPE_CURR_OVRD_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMPAYTP_TransactionCurrencyOverridesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMPAYTP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMPAYTP] Performing VerifyExist on TransactionCurrencyOverridesFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMPAYTP_TransactionCurrencyOverridesFormTable = new SeleniumControl( sDriver, "TransactionCurrencyOverridesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMPAYTP_PAYTYPE_CURR_OVRD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMPAYTP_TransactionCurrencyOverridesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMPAYTP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMPAYTP] Performing Close on TransactionCurrencyOverridesForm...", Logger.MessageType.INF);
				SeleniumControl LDMPAYTP_TransactionCurrencyOverridesForm = new SeleniumControl( sDriver, "TransactionCurrencyOverridesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMPAYTP_PAYTYPE_CURR_OVRD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMPAYTP_TransactionCurrencyOverridesForm);
IWebElement formBttn = LDMPAYTP_TransactionCurrencyOverridesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "LDMPAYTP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMPAYTP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMPAYTP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMPAYTP_MainForm);
IWebElement formBttn = LDMPAYTP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

