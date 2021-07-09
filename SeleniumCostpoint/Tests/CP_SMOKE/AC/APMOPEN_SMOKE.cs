 
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
    public class APMOPEN_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounts Payable", "xpath","//div[@class='deptItem'][.='Accounts Payable']").Click();
new SeleniumControl(sDriver,"Payment Processing", "xpath","//div[@class='navItem'][.='Payment Processing']").Click();
new SeleniumControl(sDriver,"Edit Voucher Payment Status", "xpath","//div[@class='navItem'][.='Edit Voucher Payment Status']").Click();


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
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Execute.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APMOPEN_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on PayVendor...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_PayVendor = new SeleniumControl( sDriver, "PayVendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PAY_VEND_ID']");
				Function.AssertEqual(true,APMOPEN_PayVendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_OPENAP_']/ancestor::form[1]");
				Function.AssertEqual(true,APMOPEN_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExist on ChildTable...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildTable = new SeleniumControl( sDriver, "ChildTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_OPENAP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMOPEN_ChildTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_OPENAP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMOPEN_ChildForm);
IWebElement formBttn = APMOPEN_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMOPEN_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMOPEN_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_OPENAP_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMOPEN_ChildForm_ChildFormTab);
IWebElement mTab = APMOPEN_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Accounts Payable").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on ChildForm_AccountsPayable_VendorInfo_VoucherVendor...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_AccountsPayable_VendorInfo_VoucherVendor = new SeleniumControl( sDriver, "ChildForm_AccountsPayable_VendorInfo_VoucherVendor", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_OPENAP_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,APMOPEN_ChildForm_AccountsPayable_VendorInfo_VoucherVendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_OPENAP_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMOPEN_ChildForm_ChildFormTab);
IWebElement mTab = APMOPEN_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Voucher Header Detail").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on ChildForm_VoucherHeaderDetail_InvoiceDetail_InvoiceNumber...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_VoucherHeaderDetail_InvoiceDetail_InvoiceNumber = new SeleniumControl( sDriver, "ChildForm_VoucherHeaderDetail_InvoiceDetail_InvoiceNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_OPENAP_']/ancestor::form[1]/descendant::*[@id='INVC_ID']");
				Function.AssertEqual(true,APMOPEN_ChildForm_VoucherHeaderDetail_InvoiceDetail_InvoiceNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on ChildForm_TotalsLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_TotalsLink = new SeleniumControl( sDriver, "ChildForm_TotalsLink", "ID", "lnk_1007263_APMOPEN_OPENAP");
				Function.AssertEqual(true,APMOPEN_ChildForm_TotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Click on ChildForm_TotalsLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_TotalsLink = new SeleniumControl( sDriver, "ChildForm_TotalsLink", "ID", "lnk_1007263_APMOPEN_OPENAP");
				Function.WaitControlDisplayed(APMOPEN_ChildForm_TotalsLink);
APMOPEN_ChildForm_TotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on Totals_FunctionalCurrencyTotals_AmountPaid...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_Totals_FunctionalCurrencyTotals_AmountPaid = new SeleniumControl( sDriver, "Totals_FunctionalCurrencyTotals_AmountPaid", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_FCTOTALS_']/ancestor::form[1]/descendant::*[@id='PAID_AMT']");
				Function.AssertEqual(true,APMOPEN_Totals_FunctionalCurrencyTotals_AmountPaid.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_FCTOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,APMOPEN_TotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Close on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_FCTOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMOPEN_TotalsForm);
IWebElement formBttn = APMOPEN_TotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on ChildForm_VendorTotalsLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_VendorTotalsLink = new SeleniumControl( sDriver, "ChildForm_VendorTotalsLink", "ID", "lnk_1007266_APMOPEN_OPENAP");
				Function.AssertEqual(true,APMOPEN_ChildForm_VendorTotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Click on ChildForm_VendorTotalsLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_VendorTotalsLink = new SeleniumControl( sDriver, "ChildForm_VendorTotalsLink", "ID", "lnk_1007266_APMOPEN_OPENAP");
				Function.WaitControlDisplayed(APMOPEN_ChildForm_VendorTotalsLink);
APMOPEN_ChildForm_VendorTotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on VendorTotals_FunctionalCurrencyTotals_DiscountAmount...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_VendorTotals_FunctionalCurrencyTotals_DiscountAmount = new SeleniumControl( sDriver, "VendorTotals_FunctionalCurrencyTotals_DiscountAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__AP_FUNCCRNCY_TOTALS_']/ancestor::form[1]/descendant::*[@id='DISC_AMT']");
				Function.AssertEqual(true,APMOPEN_VendorTotals_FunctionalCurrencyTotals_DiscountAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on VendorTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_VendorTotalsForm = new SeleniumControl( sDriver, "VendorTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AP_FUNCCRNCY_TOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,APMOPEN_VendorTotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Close on VendorTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_VendorTotalsForm = new SeleniumControl( sDriver, "VendorTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AP_FUNCCRNCY_TOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMOPEN_VendorTotalsForm);
IWebElement formBttn = APMOPEN_VendorTotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on ChildForm_VoucherTotalsLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_VoucherTotalsLink = new SeleniumControl( sDriver, "ChildForm_VoucherTotalsLink", "ID", "lnk_1007269_APMOPEN_OPENAP");
				Function.AssertEqual(true,APMOPEN_ChildForm_VoucherTotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Click on ChildForm_VoucherTotalsLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_VoucherTotalsLink = new SeleniumControl( sDriver, "ChildForm_VoucherTotalsLink", "ID", "lnk_1007269_APMOPEN_OPENAP");
				Function.WaitControlDisplayed(APMOPEN_ChildForm_VoucherTotalsLink);
APMOPEN_ChildForm_VoucherTotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on VoucherTotals_VoucherTotals_CostAmountLabel...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_VoucherTotals_VoucherTotals_CostAmountLabel = new SeleniumControl( sDriver, "VoucherTotals_VoucherTotals_CostAmountLabel", "xpath", "//input[@id='PAY_ADDR_DC']/ancestor::div[@class='rsltst']/following-sibling::div[@class='rsltst']/form/descendant::*[@id='TRN_CST_AMT']/preceding-sibling::span[1]");
				Function.AssertEqual(true,APMOPEN_VoucherTotals_VoucherTotals_CostAmountLabel.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on VoucherTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_VoucherTotalsForm = new SeleniumControl( sDriver, "VoucherTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]");
				Function.AssertEqual(true,APMOPEN_VoucherTotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Close on VoucherTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_VoucherTotalsForm = new SeleniumControl( sDriver, "VoucherTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMOPEN_VoucherTotalsForm);
IWebElement formBttn = APMOPEN_VoucherTotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_1003203_APMOPEN_OPENAP");
				Function.AssertEqual(true,APMOPEN_ChildForm_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Click on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_1003203_APMOPEN_OPENAP");
				Function.WaitControlDisplayed(APMOPEN_ChildForm_ExchangeRatesLink);
APMOPEN_ChildForm_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on ExchangeRates_Currencies_Pay...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ExchangeRates_Currencies_Pay = new SeleniumControl( sDriver, "ExchangeRates_Currencies_Pay", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]/descendant::*[@id='PAY_CRNCY_CD']");
				Function.AssertEqual(true,APMOPEN_ExchangeRates_Currencies_Pay.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,APMOPEN_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMOPEN_ExchangeRatesForm);
IWebElement formBttn = APMOPEN_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on ChildForm_VoucherDetailLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_VoucherDetailLink = new SeleniumControl( sDriver, "ChildForm_VoucherDetailLink", "ID", "lnk_1003204_APMOPEN_OPENAP");
				Function.AssertEqual(true,APMOPEN_ChildForm_VoucherDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Click on ChildForm_VoucherDetailLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_VoucherDetailLink = new SeleniumControl( sDriver, "ChildForm_VoucherDetailLink", "ID", "lnk_1003204_APMOPEN_OPENAP");
				Function.WaitControlDisplayed(APMOPEN_ChildForm_VoucherDetailLink);
APMOPEN_ChildForm_VoucherDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on VoucherTotalForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_VoucherTotalForm = new SeleniumControl( sDriver, "VoucherTotalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_VOUCHERTOT_']/ancestor::form[1]");
				Function.AssertEqual(true,APMOPEN_VoucherTotalForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on VoucherTotal_AmountPaid...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_VoucherTotal_AmountPaid = new SeleniumControl( sDriver, "VoucherTotal_AmountPaid", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_VOUCHERTOT_']/ancestor::form[1]/descendant::*[@id='PAID_AMT']");
				Function.AssertEqual(true,APMOPEN_VoucherTotal_AmountPaid.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on VoucherDetailForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_VoucherDetailForm = new SeleniumControl( sDriver, "VoucherDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_LN_']/ancestor::form[1]");
				Function.AssertEqual(true,APMOPEN_VoucherDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExist on VoucherDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_VoucherDetailFormTable = new SeleniumControl( sDriver, "VoucherDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_LN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMOPEN_VoucherDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing ClickButton on VoucherDetailForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_VoucherDetailForm = new SeleniumControl( sDriver, "VoucherDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_LN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMOPEN_VoucherDetailForm);
IWebElement formBttn = APMOPEN_VoucherDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMOPEN_VoucherDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMOPEN_VoucherDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on VoucherDetail_LineDetails_OrgName...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_VoucherDetail_LineDetails_OrgName = new SeleniumControl( sDriver, "VoucherDetail_LineDetails_OrgName", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_LN_']/ancestor::form[1]/descendant::*[@id='ORG_NAME']");
				Function.AssertEqual(true,APMOPEN_VoucherDetail_LineDetails_OrgName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Close on VoucherTotalForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_VoucherTotalForm = new SeleniumControl( sDriver, "VoucherTotalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_VOUCHERTOT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMOPEN_VoucherTotalForm);
IWebElement formBttn = APMOPEN_VoucherTotalForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on ChildForm_PODetailsLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_PODetailsLink = new SeleniumControl( sDriver, "ChildForm_PODetailsLink", "ID", "lnk_1003206_APMOPEN_OPENAP");
				Function.AssertEqual(true,APMOPEN_ChildForm_PODetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Click on ChildForm_PODetailsLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_PODetailsLink = new SeleniumControl( sDriver, "ChildForm_PODetailsLink", "ID", "lnk_1003206_APMOPEN_OPENAP");
				Function.WaitControlDisplayed(APMOPEN_ChildForm_PODetailsLink);
APMOPEN_ChildForm_PODetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExist on PODetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_PODetailsFormTable = new SeleniumControl( sDriver, "PODetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_POLN_PODTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMOPEN_PODetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on PODetailsForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_PODetailsForm = new SeleniumControl( sDriver, "PODetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_POLN_PODTL_']/ancestor::form[1]");
				Function.AssertEqual(true,APMOPEN_PODetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing ClickButton on PODetailsForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_PODetailsForm = new SeleniumControl( sDriver, "PODetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_POLN_PODTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMOPEN_PODetailsForm);
IWebElement formBttn = APMOPEN_PODetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMOPEN_PODetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMOPEN_PODetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on PODetails_ItemDetails_Line...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_PODetails_ItemDetails_Line = new SeleniumControl( sDriver, "PODetails_ItemDetails_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_POLN_PODTL_']/ancestor::form[1]/descendant::*[@id='PO_LN_NO']");
				Function.AssertEqual(true,APMOPEN_PODetails_ItemDetails_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Close on PODetailsForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_PODetailsForm = new SeleniumControl( sDriver, "PODetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_POLN_PODTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMOPEN_PODetailsForm);
IWebElement formBttn = APMOPEN_PODetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on ChildForm_PayWhenPaidLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_PayWhenPaidLink = new SeleniumControl( sDriver, "ChildForm_PayWhenPaidLink", "ID", "lnk_1007291_APMOPEN_OPENAP");
				Function.AssertEqual(true,APMOPEN_ChildForm_PayWhenPaidLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Click on ChildForm_PayWhenPaidLink...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_ChildForm_PayWhenPaidLink = new SeleniumControl( sDriver, "ChildForm_PayWhenPaidLink", "ID", "lnk_1007291_APMOPEN_OPENAP");
				Function.WaitControlDisplayed(APMOPEN_ChildForm_PayWhenPaidLink);
APMOPEN_ChildForm_PayWhenPaidLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on PayWhenPaidForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_PayWhenPaidForm = new SeleniumControl( sDriver, "PayWhenPaidForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_PWPDTOT_']/ancestor::form[1]");
				Function.AssertEqual(true,APMOPEN_PayWhenPaidForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on PayWhenPaid_TotalsBilledAmount...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_PayWhenPaid_TotalsBilledAmount = new SeleniumControl( sDriver, "PayWhenPaid_TotalsBilledAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_PWPDTOT_']/ancestor::form[1]/descendant::*[@id='BILLED_AMT']");
				Function.AssertEqual(true,APMOPEN_PayWhenPaid_TotalsBilledAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on PayWhenPaidChildForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_PayWhenPaidChildForm = new SeleniumControl( sDriver, "PayWhenPaidChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_PAYWPDVCHRHS_PAYWPD_']/ancestor::form[1]");
				Function.AssertEqual(true,APMOPEN_PayWhenPaidChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExist on PayWhenPaidChildFormTable...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_PayWhenPaidChildFormTable = new SeleniumControl( sDriver, "PayWhenPaidChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_PAYWPDVCHRHS_PAYWPD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMOPEN_PayWhenPaidChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing ClickButton on PayWhenPaidChildForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_PayWhenPaidChildForm = new SeleniumControl( sDriver, "PayWhenPaidChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_PAYWPDVCHRHS_PAYWPD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMOPEN_PayWhenPaidChildForm);
IWebElement formBttn = APMOPEN_PayWhenPaidChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMOPEN_PayWhenPaidChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMOPEN_PayWhenPaidChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing VerifyExists on PayWhenPaidChildForm_TotalBillAmount...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_PayWhenPaidChildForm_TotalBillAmount = new SeleniumControl( sDriver, "PayWhenPaidChildForm_TotalBillAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_PAYWPDVCHRHS_PAYWPD_']/ancestor::form[1]/descendant::*[@id='BILLED_AMT']");
				Function.AssertEqual(true,APMOPEN_PayWhenPaidChildForm_TotalBillAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Close on PayWhenPaidForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_PayWhenPaidForm = new SeleniumControl( sDriver, "PayWhenPaidForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMOPEN_PWPDTOT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMOPEN_PayWhenPaidForm);
IWebElement formBttn = APMOPEN_PayWhenPaidForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMOPEN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMOPEN] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMOPEN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMOPEN_MainForm);
IWebElement formBttn = APMOPEN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

