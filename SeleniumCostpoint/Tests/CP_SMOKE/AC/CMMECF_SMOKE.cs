 
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
    public class CMMECF_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Cash Management", "xpath","//div[@class='deptItem'][.='Cash Management']").Click();
new SeleniumControl(sDriver,"Cash Forecasting", "xpath","//div[@class='navItem'][.='Cash Forecasting']").Click();
new SeleniumControl(sDriver,"Manage Preliminary Cash Forecasts", "xpath","//div[@class='navItem'][.='Manage Preliminary Cash Forecasts']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Query");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Close...", Logger.MessageType.INF);
				SeleniumControl Query_Close = new SeleniumControl( sDriver, "Close", "ID", "closeQ");
				Function.WaitControlDisplayed(Query_Close);
if (Query_Close.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Close.Click(5,5);
else Query_Close.Click(4.5);


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
				Function.CurrentComponent = "CMMECF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMECF] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl CMMECF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,CMMECF_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMECF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMECF] Performing VerifyExists on TemplateCode...", Logger.MessageType.INF);
				SeleniumControl CMMECF_TemplateCode = new SeleniumControl( sDriver, "TemplateCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TMPLT_CD']");
				Function.AssertEqual(true,CMMECF_TemplateCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMECF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMECF] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl CMMECF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(CMMECF_MainForm);
IWebElement formBttn = CMMECF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? CMMECF_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
CMMECF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMECF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMECF] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl CMMECF_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,CMMECF_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Child Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMECF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMECF] Performing VerifyExists on PerliminaryCashForecastsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl CMMECF_PerliminaryCashForecastsDetailsForm = new SeleniumControl( sDriver, "PerliminaryCashForecastsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CMMECF_CFTRPTDETL_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,CMMECF_PerliminaryCashForecastsDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMECF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMECF] Performing VerifyExist on PerliminaryCashForecastsDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl CMMECF_PerliminaryCashForecastsDetailsFormTable = new SeleniumControl( sDriver, "PerliminaryCashForecastsDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CMMECF_CFTRPTDETL_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,CMMECF_PerliminaryCashForecastsDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMECF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMECF] Performing ClickButton on PerliminaryCashForecastsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl CMMECF_PerliminaryCashForecastsDetailsForm = new SeleniumControl( sDriver, "PerliminaryCashForecastsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CMMECF_CFTRPTDETL_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(CMMECF_PerliminaryCashForecastsDetailsForm);
IWebElement formBttn = CMMECF_PerliminaryCashForecastsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? CMMECF_PerliminaryCashForecastsDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
CMMECF_PerliminaryCashForecastsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMECF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMECF] Performing VerifyExists on CashForecastLineTitles...", Logger.MessageType.INF);
				SeleniumControl CMMECF_CashForecastLineTitles = new SeleniumControl( sDriver, "CashForecastLineTitles", "xpath", "//div[translate(@id,'0123456789','')='pr__CMMECF_CFTRPTDETL_DETL_']/ancestor::form[1]/descendant::*[@id='CFT_LN_DESC']");
				Function.AssertEqual(true,CMMECF_CashForecastLineTitles.Exists());

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
				Function.CurrentComponent = "CMMECF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMECF] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl CMMECF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(CMMECF_MainForm);
IWebElement formBttn = CMMECF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

