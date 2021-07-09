 
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
    public class MUMRGRP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Exchange Rate Groups", "xpath","//div[@class='navItem'][.='Manage Exchange Rate Groups']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRGRP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUMRGRP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MUMRGRP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRGRP] Performing VerifyExists on RateGroup...", Logger.MessageType.INF);
				SeleniumControl MUMRGRP_RateGroup = new SeleniumControl( sDriver, "RateGroup", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RT_GRP_ID']");
				Function.AssertEqual(true,MUMRGRP_RateGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRGRP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUMRGRP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MUMRGRP_MainForm);
IWebElement formBttn = MUMRGRP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? MUMRGRP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
MUMRGRP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRGRP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl MUMRGRP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MUMRGRP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRGRP] Performing VerifyExist on CurrencyExchangeRateToleranceFormTable...", Logger.MessageType.INF);
				SeleniumControl MUMRGRP_CurrencyExchangeRateToleranceFormTable = new SeleniumControl( sDriver, "CurrencyExchangeRateToleranceFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMRGRP_RTGRPCRNCY_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MUMRGRP_CurrencyExchangeRateToleranceFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRGRP] Performing ClickButton on CurrencyExchangeRateToleranceForm...", Logger.MessageType.INF);
				SeleniumControl MUMRGRP_CurrencyExchangeRateToleranceForm = new SeleniumControl( sDriver, "CurrencyExchangeRateToleranceForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMRGRP_RTGRPCRNCY_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MUMRGRP_CurrencyExchangeRateToleranceForm);
IWebElement formBttn = MUMRGRP_CurrencyExchangeRateToleranceForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MUMRGRP_CurrencyExchangeRateToleranceForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MUMRGRP_CurrencyExchangeRateToleranceForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRGRP] Performing VerifyExists on CurrencyExchangeRateToleranceForm...", Logger.MessageType.INF);
				SeleniumControl MUMRGRP_CurrencyExchangeRateToleranceForm = new SeleniumControl( sDriver, "CurrencyExchangeRateToleranceForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMRGRP_RTGRPCRNCY_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MUMRGRP_CurrencyExchangeRateToleranceForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRGRP] Performing VerifyExists on CurrencyExchangeRateTolerance_CurrencyFrom...", Logger.MessageType.INF);
				SeleniumControl MUMRGRP_CurrencyExchangeRateTolerance_CurrencyFrom = new SeleniumControl( sDriver, "CurrencyExchangeRateTolerance_CurrencyFrom", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMRGRP_RTGRPCRNCY_CTW_']/ancestor::form[1]/descendant::*[@id='FR_S_CRNCY_CD']");
				Function.AssertEqual(true,MUMRGRP_CurrencyExchangeRateTolerance_CurrencyFrom.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "MUMRGRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRGRP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUMRGRP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MUMRGRP_MainForm);
IWebElement formBttn = MUMRGRP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

