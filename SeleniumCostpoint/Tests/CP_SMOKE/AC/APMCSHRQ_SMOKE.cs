 
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
    public class APMCSHRQ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounts Payable", "xpath","//div[@class='deptItem'][.='Accounts Payable']").Click();
new SeleniumControl(sDriver,"Accounts Payable Controls", "xpath","//div[@class='navItem'][.='Accounts Payable Controls']").Click();
new SeleniumControl(sDriver,"Manage Cash Requirements Rpt Supplemental Amounts", "xpath","//div[@class='navItem'][.='Manage Cash Requirements Rpt Supplemental Amounts']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN TABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing VerifyExists on SupplementalAmountsScheduleForm...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_SupplementalAmountsScheduleForm = new SeleniumControl( sDriver, "SupplementalAmountsScheduleForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APMCSHRQ_SupplementalAmountsScheduleForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing VerifyExists on Schedule...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_Schedule = new SeleniumControl( sDriver, "Schedule", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CREQ_SCH_CD']");
				Function.AssertEqual(true,APMCSHRQ_Schedule.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing ClickButton on SupplementalAmountsScheduleForm...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_SupplementalAmountsScheduleForm = new SeleniumControl( sDriver, "SupplementalAmountsScheduleForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMCSHRQ_SupplementalAmountsScheduleForm);
IWebElement formBttn = APMCSHRQ_SupplementalAmountsScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? APMCSHRQ_SupplementalAmountsScheduleForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
APMCSHRQ_SupplementalAmountsScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing VerifyExist on SupplementalAmountsScheduleFormTable...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_SupplementalAmountsScheduleFormTable = new SeleniumControl( sDriver, "SupplementalAmountsScheduleFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMCSHRQ_SupplementalAmountsScheduleFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing VerifyExist on CashRequirementsDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_CashRequirementsDetailsFormTable = new SeleniumControl( sDriver, "CashRequirementsDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMCSHRQ_SUPPLCASHREQSCH_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMCSHRQ_CashRequirementsDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing ClickButton on CashRequirementsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_CashRequirementsDetailsForm = new SeleniumControl( sDriver, "CashRequirementsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMCSHRQ_SUPPLCASHREQSCH_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMCSHRQ_CashRequirementsDetailsForm);
IWebElement formBttn = APMCSHRQ_CashRequirementsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMCSHRQ_CashRequirementsDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMCSHRQ_CashRequirementsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing VerifyExists on CashRequirementsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_CashRequirementsDetailsForm = new SeleniumControl( sDriver, "CashRequirementsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMCSHRQ_SUPPLCASHREQSCH_']/ancestor::form[1]");
				Function.AssertEqual(true,APMCSHRQ_CashRequirementsDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing VerifyExists on CashRequirementsDetails_Description...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_CashRequirementsDetails_Description = new SeleniumControl( sDriver, "CashRequirementsDetails_Description", "xpath", "//div[translate(@id,'0123456789','')='pr__APMCSHRQ_SUPPLCASHREQSCH_']/ancestor::form[1]/descendant::*[@id='SUPPL_AMT_DESC']");
				Function.AssertEqual(true,APMCSHRQ_CashRequirementsDetails_Description.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILDFORM LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing VerifyExists on CashRequirementsDetails_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_CashRequirementsDetails_ExchangeRatesLink = new SeleniumControl( sDriver, "CashRequirementsDetails_ExchangeRatesLink", "ID", "lnk_1003707_APMCSHRQ_SUPPLCASHREQSCH");
				Function.AssertEqual(true,APMCSHRQ_CashRequirementsDetails_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing Click on CashRequirementsDetails_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_CashRequirementsDetails_ExchangeRatesLink = new SeleniumControl( sDriver, "CashRequirementsDetails_ExchangeRatesLink", "ID", "lnk_1003707_APMCSHRQ_SUPPLCASHREQSCH");
				Function.WaitControlDisplayed(APMCSHRQ_CashRequirementsDetails_ExchangeRatesLink);
APMCSHRQ_CashRequirementsDetails_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing VerifyExists on CashRequirementsDetails_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_CashRequirementsDetails_ExchangeRatesForm = new SeleniumControl( sDriver, "CashRequirementsDetails_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,APMCSHRQ_CashRequirementsDetails_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing VerifyExists on CashRequirementsDetails_ExchangeRates_Currencies_Transaction...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_CashRequirementsDetails_ExchangeRates_Currencies_Transaction = new SeleniumControl( sDriver, "CashRequirementsDetails_ExchangeRates_Currencies_Transaction", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,APMCSHRQ_CashRequirementsDetails_ExchangeRates_Currencies_Transaction.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing Close on CashRequirementsDetails_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_CashRequirementsDetails_ExchangeRatesForm = new SeleniumControl( sDriver, "CashRequirementsDetails_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMCSHRQ_CashRequirementsDetails_ExchangeRatesForm);
IWebElement formBttn = APMCSHRQ_CashRequirementsDetails_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "APMCSHRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCSHRQ] Performing Close on SupplementalAmountsScheduleForm...", Logger.MessageType.INF);
				SeleniumControl APMCSHRQ_SupplementalAmountsScheduleForm = new SeleniumControl( sDriver, "SupplementalAmountsScheduleForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMCSHRQ_SupplementalAmountsScheduleForm);
IWebElement formBttn = APMCSHRQ_SupplementalAmountsScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

