 
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
    public class BLMMNBIL_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Billing", "xpath","//div[@class='deptItem'][.='Billing']").Click();
new SeleniumControl(sDriver,"Manual Bills Processing", "xpath","//div[@class='navItem'][.='Manual Bills Processing']").Click();
new SeleniumControl(sDriver,"Manage Manual Bills", "xpath","//div[@class='navItem'][.='Manage Manual Bills']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMMNBIL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExists on PeriodInformation_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_PeriodInformation_FiscalYear = new SeleniumControl( sDriver, "PeriodInformation_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,BLMMNBIL_PeriodInformation_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMMNBIL_MainForm);
IWebElement formBttn = BLMMNBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BLMMNBIL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BLMMNBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMMNBIL_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExist on BillingInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformationFormTable = new SeleniumControl( sDriver, "BillingInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMNBIL_MANUALBILLEDIT_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMMNBIL_BillingInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing ClickButton on BillingInformationForm...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformationForm = new SeleniumControl( sDriver, "BillingInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMNBIL_MANUALBILLEDIT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMMNBIL_BillingInformationForm);
IWebElement formBttn = BLMMNBIL_BillingInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMMNBIL_BillingInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMMNBIL_BillingInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExists on BillingInformationForm...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformationForm = new SeleniumControl( sDriver, "BillingInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMNBIL_MANUALBILLEDIT_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMMNBIL_BillingInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExists on BillingInformation_InvoiceNumber...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_InvoiceNumber = new SeleniumControl( sDriver, "BillingInformation_InvoiceNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMNBIL_MANUALBILLEDIT_CHLD_']/ancestor::form[1]/descendant::*[@id='INVC_ID']");
				Function.AssertEqual(true,BLMMNBIL_BillingInformation_InvoiceNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EXCHANGE RATES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExists on BillingInformation_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_ExchangeRatesLink = new SeleniumControl( sDriver, "BillingInformation_ExchangeRatesLink", "ID", "lnk_1003407_BLMMNBIL_MANUALBILLEDIT_CHLD");
				Function.AssertEqual(true,BLMMNBIL_BillingInformation_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing Click on BillingInformation_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_ExchangeRatesLink = new SeleniumControl( sDriver, "BillingInformation_ExchangeRatesLink", "ID", "lnk_1003407_BLMMNBIL_MANUALBILLEDIT_CHLD");
				Function.WaitControlDisplayed(BLMMNBIL_BillingInformation_ExchangeRatesLink);
BLMMNBIL_BillingInformation_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExists on BillingInformation_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_ExchangeRatesForm = new SeleniumControl( sDriver, "BillingInformation_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMMNBIL_BillingInformation_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExists on BillingInformation_ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "BillingInformation_ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,BLMMNBIL_BillingInformation_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing Close on BillingInformation_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_ExchangeRatesForm = new SeleniumControl( sDriver, "BillingInformation_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMMNBIL_BillingInformation_ExchangeRatesForm);
IWebElement formBttn = BLMMNBIL_BillingInformation_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("INVOICE TOTALS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExists on BillingInformation_InvoiceTotalsLink...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_InvoiceTotalsLink = new SeleniumControl( sDriver, "BillingInformation_InvoiceTotalsLink", "ID", "lnk_1002865_BLMMNBIL_MANUALBILLEDIT_CHLD");
				Function.AssertEqual(true,BLMMNBIL_BillingInformation_InvoiceTotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing Click on BillingInformation_InvoiceTotalsLink...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_InvoiceTotalsLink = new SeleniumControl( sDriver, "BillingInformation_InvoiceTotalsLink", "ID", "lnk_1002865_BLMMNBIL_MANUALBILLEDIT_CHLD");
				Function.WaitControlDisplayed(BLMMNBIL_BillingInformation_InvoiceTotalsLink);
BLMMNBIL_BillingInformation_InvoiceTotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExists on BillingInformation_InvoiceTotalsForm...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_InvoiceTotalsForm = new SeleniumControl( sDriver, "BillingInformation_InvoiceTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPBLINVT_INVCTOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMMNBIL_BillingInformation_InvoiceTotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExists on BillingInformation_InvoiceTotals_InvoiceTotals_ExchangeRates_BillingToFunctional...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_InvoiceTotals_InvoiceTotals_ExchangeRates_BillingToFunctional = new SeleniumControl( sDriver, "BillingInformation_InvoiceTotals_InvoiceTotals_ExchangeRates_BillingToFunctional", "xpath", "//div[translate(@id,'0123456789','')='pr__CPBLINVT_INVCTOTALS_']/ancestor::form[1]/descendant::*[@id='TRANS_TO_FUNC_ER']");
				Function.AssertEqual(true,BLMMNBIL_BillingInformation_InvoiceTotals_InvoiceTotals_ExchangeRates_BillingToFunctional.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing Close on BillingInformation_InvoiceTotalsForm...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_InvoiceTotalsForm = new SeleniumControl( sDriver, "BillingInformation_InvoiceTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPBLINVT_INVCTOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMMNBIL_BillingInformation_InvoiceTotalsForm);
IWebElement formBttn = BLMMNBIL_BillingInformation_InvoiceTotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CUSTOMS INFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExists on BillingInformation_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_CustomsInfoLink = new SeleniumControl( sDriver, "BillingInformation_CustomsInfoLink", "ID", "lnk_1002866_BLMMNBIL_MANUALBILLEDIT_CHLD");
				Function.AssertEqual(true,BLMMNBIL_BillingInformation_CustomsInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing Click on BillingInformation_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_CustomsInfoLink = new SeleniumControl( sDriver, "BillingInformation_CustomsInfoLink", "ID", "lnk_1002866_BLMMNBIL_MANUALBILLEDIT_CHLD");
				Function.WaitControlDisplayed(BLMMNBIL_BillingInformation_CustomsInfoLink);
BLMMNBIL_BillingInformation_CustomsInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExists on BillingInformation_CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_CustomsInfoForm = new SeleniumControl( sDriver, "BillingInformation_CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMMNBIL_BillingInformation_CustomsInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing VerifyExists on BillingInformation_CustomsInfo_ValueAddedTaxInformation_TaxCode...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_CustomsInfo_ValueAddedTaxInformation_TaxCode = new SeleniumControl( sDriver, "BillingInformation_CustomsInfo_ValueAddedTaxInformation_TaxCode", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,BLMMNBIL_BillingInformation_CustomsInfo_ValueAddedTaxInformation_TaxCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing Close on BillingInformation_CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_BillingInformation_CustomsInfoForm = new SeleniumControl( sDriver, "BillingInformation_CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMMNBIL_BillingInformation_CustomsInfoForm);
IWebElement formBttn = BLMMNBIL_BillingInformation_CustomsInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMMNBIL_MainForm);
IWebElement formBttn = BLMMNBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).Count <= 0 ? BLMMNBIL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Delete')]")).FirstOrDefault() :
BLMMNBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Delete not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Save.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMNBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMNBIL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMMNBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMMNBIL_MainForm);
IWebElement formBttn = BLMMNBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

