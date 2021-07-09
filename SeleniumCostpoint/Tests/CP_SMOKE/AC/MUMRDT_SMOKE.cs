 
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
    public class MUMRDT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Exchange Rates by Date", "xpath","//div[@class='navItem'][.='Manage Exchange Rates by Date']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Find...", Logger.MessageType.INF);
				SeleniumControl Query_Find = new SeleniumControl( sDriver, "Find", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Find);
if (Query_Find.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Find.Click(5,5);
else Query_Find.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
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
				Function.CurrentComponent = "MUMRDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRDT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUMRDT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MUMRDT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRDT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl MUMRDT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MUMRDT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRDT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUMRDT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MUMRDT_MainForm);
IWebElement formBttn = MUMRDT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MUMRDT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MUMRDT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRDT] Performing VerifyExists on RateGroup...", Logger.MessageType.INF);
				SeleniumControl MUMRDT_RateGroup = new SeleniumControl( sDriver, "RateGroup", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RT_GRP_ID']");
				Function.AssertEqual(true,MUMRDT_RateGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Exchange Rate By Date Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRDT] Performing VerifyExists on ExchangeRateByDateForm...", Logger.MessageType.INF);
				SeleniumControl MUMRDT_ExchangeRateByDateForm = new SeleniumControl( sDriver, "ExchangeRateByDateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMRDT_RTBYDT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MUMRDT_ExchangeRateByDateForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRDT] Performing VerifyExist on ExchangeRateByDateFormTable...", Logger.MessageType.INF);
				SeleniumControl MUMRDT_ExchangeRateByDateFormTable = new SeleniumControl( sDriver, "ExchangeRateByDateFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMRDT_RTBYDT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MUMRDT_ExchangeRateByDateFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRDT] Performing ClickButton on ExchangeRateByDateForm...", Logger.MessageType.INF);
				SeleniumControl MUMRDT_ExchangeRateByDateForm = new SeleniumControl( sDriver, "ExchangeRateByDateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMRDT_RTBYDT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MUMRDT_ExchangeRateByDateForm);
IWebElement formBttn = MUMRDT_ExchangeRateByDateForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MUMRDT_ExchangeRateByDateForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MUMRDT_ExchangeRateByDateForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRDT] Performing VerifyExists on ExchangeRateByDate_RateAmount...", Logger.MessageType.INF);
				SeleniumControl MUMRDT_ExchangeRateByDate_RateAmount = new SeleniumControl( sDriver, "ExchangeRateByDate_RateAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMRDT_RTBYDT_CTW_']/ancestor::form[1]/descendant::*[@id='EXCH_RT']");
				Function.AssertEqual(true,MUMRDT_ExchangeRateByDate_RateAmount.Exists());

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
				Function.CurrentComponent = "MUMRDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRDT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUMRDT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MUMRDT_MainForm);
IWebElement formBttn = MUMRDT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

