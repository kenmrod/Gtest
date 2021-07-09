 
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
    public class MUMPRATE_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Multicurrency", "xpath","//div[@class='deptItem'][.='Multicurrency']").Click();
new SeleniumControl(sDriver,"Exchange Rates", "xpath","//div[@class='navItem'][.='Exchange Rates']").Click();
new SeleniumControl(sDriver,"Manage Period Exchange Rates", "xpath","//div[@class='navItem'][.='Manage Period Exchange Rates']").Click();


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
				Function.CurrentComponent = "MUMPRATE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMPRATE] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUMPRATE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MUMPRATE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMPRATE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMPRATE] Performing VerifyExists on RateGroupID...", Logger.MessageType.INF);
				SeleniumControl MUMPRATE_RateGroupID = new SeleniumControl( sDriver, "RateGroupID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RT_GRP_ID']");
				Function.AssertEqual(true,MUMPRATE_RateGroupID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMPRATE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMPRATE] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUMPRATE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MUMPRATE_MainForm);
IWebElement formBttn = MUMPRATE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? MUMPRATE_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
MUMPRATE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMPRATE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMPRATE] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl MUMPRATE_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MUMPRATE_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Period Exchange Rates Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMPRATE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMPRATE] Performing VerifyExists on PeriodExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl MUMPRATE_PeriodExchangeRatesForm = new SeleniumControl( sDriver, "PeriodExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMPRATE_RTBYPD_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,MUMPRATE_PeriodExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMPRATE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMPRATE] Performing VerifyExist on PeriodExchangeRatesFormTable...", Logger.MessageType.INF);
				SeleniumControl MUMPRATE_PeriodExchangeRatesFormTable = new SeleniumControl( sDriver, "PeriodExchangeRatesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMPRATE_RTBYPD_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MUMPRATE_PeriodExchangeRatesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMPRATE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMPRATE] Performing ClickButton on PeriodExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl MUMPRATE_PeriodExchangeRatesForm = new SeleniumControl( sDriver, "PeriodExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMPRATE_RTBYPD_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MUMPRATE_PeriodExchangeRatesForm);
IWebElement formBttn = MUMPRATE_PeriodExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MUMPRATE_PeriodExchangeRatesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MUMPRATE_PeriodExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMPRATE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMPRATE] Performing VerifyExists on PeriodExchangeRates_CurrencyFrom...", Logger.MessageType.INF);
				SeleniumControl MUMPRATE_PeriodExchangeRates_CurrencyFrom = new SeleniumControl( sDriver, "PeriodExchangeRates_CurrencyFrom", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMPRATE_RTBYPD_CHILD_']/ancestor::form[1]/descendant::*[@id='FR_S_CRNCY_CD']");
				Function.AssertEqual(true,MUMPRATE_PeriodExchangeRates_CurrencyFrom.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "MUMPRATE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMPRATE] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUMPRATE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MUMPRATE_MainForm);
IWebElement formBttn = MUMPRATE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

