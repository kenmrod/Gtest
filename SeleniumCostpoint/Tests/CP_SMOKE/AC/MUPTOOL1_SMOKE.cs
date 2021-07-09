 
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
    public class MUPTOOL1_SMOKE : SeleniumTestScript
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
								try
				{
				this.ScriptLogger.WriteLine("START");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"Multicurrency", "xpath","//div[@class='deptItem'][.='Multicurrency']").Click();
new SeleniumControl(sDriver,"Multicurrency Utilities", "xpath","//div[@class='navItem'][.='Multicurrency Utilities']").Click();
new SeleniumControl(sDriver,"Update Currency Codes for Current Version", "xpath","//div[@class='navItem'][.='Update Currency Codes for Current Version']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUPTOOL1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUPTOOL1] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUPTOOL1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MUPTOOL1_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUPTOOL1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUPTOOL1] Performing VerifyExists on ThisToolkitShouldBeUsedWhenConvertingToTheCurrentVersionFromAnyPriorVersionItSetsTheTransactionAndPayCurrenciesToTheFunctionalCurrencyForTransactionsCreatedInVersionsBeforeTheCurrentVersionLabel...", Logger.MessageType.INF);
				SeleniumControl MUPTOOL1_ThisToolkitShouldBeUsedWhenConvertingToTheCurrentVersionFromAnyPriorVersionItSetsTheTransactionAndPayCurrenciesToTheFunctionalCurrencyForTransactionsCreatedInVersionsBeforeTheCurrentVersionLabel = new SeleniumControl( sDriver, "ThisToolkitShouldBeUsedWhenConvertingToTheCurrentVersionFromAnyPriorVersionItSetsTheTransactionAndPayCurrenciesToTheFunctionalCurrencyForTransactionsCreatedInVersionsBeforeTheCurrentVersionLabel", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LABEL_INFO1']");
				Function.AssertEqual(true,MUPTOOL1_ThisToolkitShouldBeUsedWhenConvertingToTheCurrentVersionFromAnyPriorVersionItSetsTheTransactionAndPayCurrenciesToTheFunctionalCurrencyForTransactionsCreatedInVersionsBeforeTheCurrentVersionLabel.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUPTOOL1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUPTOOL1] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUPTOOL1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MUPTOOL1_MainForm);
IWebElement formBttn = MUPTOOL1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

