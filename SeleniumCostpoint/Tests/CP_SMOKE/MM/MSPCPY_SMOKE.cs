 
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
    public class MSPCPY_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials", "xpath","//div[@class='busItem'][.='Materials']").Click();
new SeleniumControl(sDriver,"Master Production Scheduling", "xpath","//div[@class='deptItem'][.='Master Production Scheduling']").Click();
new SeleniumControl(sDriver,"Master Production Schedules", "xpath","//div[@class='navItem'][.='Master Production Schedules']").Click();
new SeleniumControl(sDriver,"Copy Master Production Schedules", "xpath","//div[@class='navItem'][.='Copy Master Production Schedules']").Click();


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
				Function.CurrentComponent = "MSPCPY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSPCPY] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MSPCPY_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MSPCPY_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSPCPY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSPCPY] Performing VerifyExists on SelectionRanges_FromForecasts_ForecastNeedDateStart...", Logger.MessageType.INF);
				SeleniumControl MSPCPY_SelectionRanges_FromForecasts_ForecastNeedDateStart = new SeleniumControl( sDriver, "SelectionRanges_FromForecasts_ForecastNeedDateStart", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FROM_FORECAST']");
				Function.AssertEqual(true,MSPCPY_SelectionRanges_FromForecasts_ForecastNeedDateStart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Review form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSPCPY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSPCPY] Performing Click on SelectionRanges_ReviewCopiedMPSForecastsLink...", Logger.MessageType.INF);
				SeleniumControl MSPCPY_SelectionRanges_ReviewCopiedMPSForecastsLink = new SeleniumControl( sDriver, "SelectionRanges_ReviewCopiedMPSForecastsLink", "ID", "lnk_4990_MSPCPY_PARAM");
				Function.WaitControlDisplayed(MSPCPY_SelectionRanges_ReviewCopiedMPSForecastsLink);
MSPCPY_SelectionRanges_ReviewCopiedMPSForecastsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSPCPY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSPCPY] Performing VerifyExists on ReviewCopiedMPSForecastsForm...", Logger.MessageType.INF);
				SeleniumControl MSPCPY_ReviewCopiedMPSForecastsForm = new SeleniumControl( sDriver, "ReviewCopiedMPSForecastsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSPCPY_PREVIEW_']/ancestor::form[1]");
				Function.AssertEqual(true,MSPCPY_ReviewCopiedMPSForecastsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSPCPY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSPCPY] Performing VerifyExist on ReviewCopiedMPSForecastsFormTable...", Logger.MessageType.INF);
				SeleniumControl MSPCPY_ReviewCopiedMPSForecastsFormTable = new SeleniumControl( sDriver, "ReviewCopiedMPSForecastsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MSPCPY_PREVIEW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MSPCPY_ReviewCopiedMPSForecastsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSPCPY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSPCPY] Performing ClickButton on ReviewCopiedMPSForecastsForm...", Logger.MessageType.INF);
				SeleniumControl MSPCPY_ReviewCopiedMPSForecastsForm = new SeleniumControl( sDriver, "ReviewCopiedMPSForecastsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSPCPY_PREVIEW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSPCPY_ReviewCopiedMPSForecastsForm);
IWebElement formBttn = MSPCPY_ReviewCopiedMPSForecastsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MSPCPY_ReviewCopiedMPSForecastsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MSPCPY_ReviewCopiedMPSForecastsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSPCPY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSPCPY] Performing VerifyExists on ReviewCopiedMPSForecasts_ForecastNeedDate...", Logger.MessageType.INF);
				SeleniumControl MSPCPY_ReviewCopiedMPSForecasts_ForecastNeedDate = new SeleniumControl( sDriver, "ReviewCopiedMPSForecasts_ForecastNeedDate", "xpath", "//div[translate(@id,'0123456789','')='pr__MSPCPY_PREVIEW_']/ancestor::form[1]/descendant::*[@id='MPS_DT']");
				Function.AssertEqual(true,MSPCPY_ReviewCopiedMPSForecasts_ForecastNeedDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSPCPY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSPCPY] Performing Close on ReviewCopiedMPSForecastsForm...", Logger.MessageType.INF);
				SeleniumControl MSPCPY_ReviewCopiedMPSForecastsForm = new SeleniumControl( sDriver, "ReviewCopiedMPSForecastsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSPCPY_PREVIEW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSPCPY_ReviewCopiedMPSForecastsForm);
IWebElement formBttn = MSPCPY_ReviewCopiedMPSForecastsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close the application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSPCPY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSPCPY] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MSPCPY_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MSPCPY_MainForm);
IWebElement formBttn = MSPCPY_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

