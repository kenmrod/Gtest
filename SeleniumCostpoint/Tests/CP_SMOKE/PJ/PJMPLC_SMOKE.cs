 
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
    public class PJMPLC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Project Labor", "xpath","//div[@class='navItem'][.='Project Labor']").Click();
new SeleniumControl(sDriver,"Manage Project Labor Categories (PLC)", "xpath","//div[@class='navItem'][.='Manage Project Labor Categories (PLC)']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORMTABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLC] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl PJMPLC_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPLC_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("BILLING RATES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLC] Performing VerifyExists on BillingRatesLink...", Logger.MessageType.INF);
				SeleniumControl PJMPLC_BillingRatesLink = new SeleniumControl( sDriver, "BillingRatesLink", "ID", "lnk_1000642_PJMPLC_BILLLABCAT_PLC");
				Function.AssertEqual(true,PJMPLC_BillingRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLC] Performing Click on BillingRatesLink...", Logger.MessageType.INF);
				SeleniumControl PJMPLC_BillingRatesLink = new SeleniumControl( sDriver, "BillingRatesLink", "ID", "lnk_1000642_PJMPLC_BILLLABCAT_PLC");
				Function.WaitControlDisplayed(PJMPLC_BillingRatesLink);
PJMPLC_BillingRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLC] Performing VerifyExist on BillingRatesTable...", Logger.MessageType.INF);
				SeleniumControl PJMPLC_BillingRatesTable = new SeleniumControl( sDriver, "BillingRatesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPLC_LABCATRTSCH_BILL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPLC_BillingRatesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "PJMPLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPLC_MainForm);
IWebElement formBttn = PJMPLC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

