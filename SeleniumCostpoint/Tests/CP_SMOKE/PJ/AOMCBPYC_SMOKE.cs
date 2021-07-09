 
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
    public class AOMCBPYC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Prior Year Cobra Costs", "xpath","//div[@class='navItem'][.='Manage Prior Year Cobra Costs']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,AOMCBPYC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing VerifyExists on FiscalYear...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_FiscalYear = new SeleniumControl( sDriver, "FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,AOMCBPYC_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMCBPYC_MainForm);
IWebElement formBttn = AOMCBPYC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? AOMCBPYC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
AOMCBPYC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMCBPYC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PRIOR YEAR COST LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing VerifyExists on PriorYearCostsLink...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_PriorYearCostsLink = new SeleniumControl( sDriver, "PriorYearCostsLink", "ID", "lnk_5779_AOMCBPYC_PYCBSUM_MAINHDR");
				Function.AssertEqual(true,AOMCBPYC_PriorYearCostsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing Click on PriorYearCostsLink...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_PriorYearCostsLink = new SeleniumControl( sDriver, "PriorYearCostsLink", "ID", "lnk_5779_AOMCBPYC_PYCBSUM_MAINHDR");
				Function.WaitControlDisplayed(AOMCBPYC_PriorYearCostsLink);
AOMCBPYC_PriorYearCostsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing VerifyExist on PriorYearCostsFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_PriorYearCostsFormTable = new SeleniumControl( sDriver, "PriorYearCostsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCBPYC_PYCBSUM_MAINCHD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMCBPYC_PriorYearCostsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing ClickButton on PriorYearCostsForm...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_PriorYearCostsForm = new SeleniumControl( sDriver, "PriorYearCostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCBPYC_PYCBSUM_MAINCHD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMCBPYC_PriorYearCostsForm);
IWebElement formBttn = AOMCBPYC_PriorYearCostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? AOMCBPYC_PriorYearCostsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
AOMCBPYC_PriorYearCostsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing VerifyExists on PriorYearCosts_Account...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_PriorYearCosts_Account = new SeleniumControl( sDriver, "PriorYearCosts_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCBPYC_PYCBSUM_MAINCHD_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,AOMCBPYC_PriorYearCosts_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POOL AMOUNTS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing VerifyExists on PriorYearCosts_PoolAmountsLink...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_PriorYearCosts_PoolAmountsLink = new SeleniumControl( sDriver, "PriorYearCosts_PoolAmountsLink", "ID", "lnk_5780_AOMCBPYC_PYCBSUM_MAINCHD");
				Function.AssertEqual(true,AOMCBPYC_PriorYearCosts_PoolAmountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing Click on PriorYearCosts_PoolAmountsLink...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_PriorYearCosts_PoolAmountsLink = new SeleniumControl( sDriver, "PriorYearCosts_PoolAmountsLink", "ID", "lnk_5780_AOMCBPYC_PYCBSUM_MAINCHD");
				Function.WaitControlDisplayed(AOMCBPYC_PriorYearCosts_PoolAmountsLink);
AOMCBPYC_PriorYearCosts_PoolAmountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing VerifyExist on PoolAmountsFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_PoolAmountsFormTable = new SeleniumControl( sDriver, "PoolAmountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCBPYC_PYCBBURDSUM_GRANDCHD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMCBPYC_PoolAmountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing Close on PoolAmountsForm...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_PoolAmountsForm = new SeleniumControl( sDriver, "PoolAmountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCBPYC_PYCBBURDSUM_GRANDCHD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMCBPYC_PoolAmountsForm);
IWebElement formBttn = AOMCBPYC_PoolAmountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PRIOR YEAR COST LINK CLOSE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing Close on PriorYearCostsForm...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_PriorYearCostsForm = new SeleniumControl( sDriver, "PriorYearCostsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMCBPYC_PYCBSUM_MAINCHD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMCBPYC_PriorYearCostsForm);
IWebElement formBttn = AOMCBPYC_PriorYearCostsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "AOMCBPYC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMCBPYC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMCBPYC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMCBPYC_MainForm);
IWebElement formBttn = AOMCBPYC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

