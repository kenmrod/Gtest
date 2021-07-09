 
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
    public class POMPOVCH_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Voucher Processing", "xpath","//div[@class='navItem'][.='Voucher Processing']").Click();
new SeleniumControl(sDriver,"Manage Purchase Order Vouchers", "xpath","//div[@class='navItem'][.='Manage Purchase Order Vouchers']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMPOVCH_MainForm);
IWebElement formBttn = POMPOVCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Maximize']")).Count <= 0 ? POMPOVCH_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Maximize')]")).FirstOrDefault() :
POMPOVCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Maximize']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Maximize not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,POMPOVCH_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMPOVCH_MainForm);
IWebElement formBttn = POMPOVCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? POMPOVCH_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
POMPOVCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
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
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMPOVCH_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMPOVCH_MainForm);
IWebElement formBttn = POMPOVCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMPOVCH_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMPOVCH_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMPOVCH_MainForm);
IWebElement formBttn = POMPOVCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='New']")).Count <= 0 ? POMPOVCH_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'New')]")).FirstOrDefault() :
POMPOVCH_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'New')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [New] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on Identification_VoucherNo...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_Identification_VoucherNo = new SeleniumControl( sDriver, "Identification_VoucherNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VCHR_NO']");
				Function.AssertEqual(true,POMPOVCH_Identification_VoucherNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMPOVCH_MainFormTab);
IWebElement mTab = POMPOVCH_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on HeaderInfo_Invoice_Number...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_HeaderInfo_Invoice_Number = new SeleniumControl( sDriver, "HeaderInfo_Invoice_Number", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVC_ID']");
				Function.AssertEqual(true,POMPOVCH_HeaderInfo_Invoice_Number.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMPOVCH_MainFormTab);
IWebElement mTab = POMPOVCH_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on Details_SalesTaxVATInfo_Taxable...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_Details_SalesTaxVATInfo_Taxable = new SeleniumControl( sDriver, "Details_SalesTaxVATInfo_Taxable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_SALES_TAX_SRC_CD']");
				Function.AssertEqual(true,POMPOVCH_Details_SalesTaxVATInfo_Taxable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMPOVCH_MainFormTab);
IWebElement mTab = POMPOVCH_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Address").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on Address_Select_PayVendor...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_Address_Select_PayVendor = new SeleniumControl( sDriver, "Address_Select_PayVendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PAY_VEND_ID']");
				Function.AssertEqual(true,POMPOVCH_Address_Select_PayVendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMPOVCH_MainFormTab);
IWebElement mTab = POMPOVCH_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Check").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on Check_PayVendor...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_Check_PayVendor = new SeleniumControl( sDriver, "Check_PayVendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PAY___VEND___ID___CHECKSUBTASK']");
				Function.AssertEqual(true,POMPOVCH_Check_PayVendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMPOVCH_MainFormTab);
IWebElement mTab = POMPOVCH_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Subcontractor Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on SubcontractorInfo_SubcontractorPaymentControl_InvoicePeriodOfPerformaceDate...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_SubcontractorInfo_SubcontractorPaymentControl_InvoicePeriodOfPerformaceDate = new SeleniumControl( sDriver, "SubcontractorInfo_SubcontractorPaymentControl_InvoicePeriodOfPerformaceDate", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVC_POP_DT']");
				Function.AssertEqual(true,POMPOVCH_SubcontractorInfo_SubcontractorPaymentControl_InvoicePeriodOfPerformaceDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMPOVCH_MainFormTab);
IWebElement mTab = POMPOVCH_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes/Doc Loc").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on NotesDocLoc_PrintNoteOnCheck...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_NotesDocLoc_PrintNoteOnCheck = new SeleniumControl( sDriver, "NotesDocLoc_PrintNoteOnCheck", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PRINT_NOTE_FL']");
				Function.AssertEqual(true,POMPOVCH_NotesDocLoc_PrintNoteOnCheck.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMPOVCH_MainFormTab);
IWebElement mTab = POMPOVCH_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Actions").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on Actions_InvoiceAmountDiscrepancy_AdjustHeaderInvoiceAmount...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_Actions_InvoiceAmountDiscrepancy_AdjustHeaderInvoiceAmount = new SeleniumControl( sDriver, "Actions_InvoiceAmountDiscrepancy_AdjustHeaderInvoiceAmount", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVCHDR_ADJUST_CB']");
				Function.AssertEqual(true,POMPOVCH_Actions_InvoiceAmountDiscrepancy_AdjustHeaderInvoiceAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Click on AutoAllocateChargesLink...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_AutoAllocateChargesLink = new SeleniumControl( sDriver, "AutoAllocateChargesLink", "ID", "lnk_1003768_POMPOVCH_VCHRHDR");
				Function.WaitControlDisplayed(POMPOVCH_AutoAllocateChargesLink);
POMPOVCH_AutoAllocateChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on AutoAllocateCharges_ChargeType...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_AutoAllocateCharges_ChargeType = new SeleniumControl( sDriver, "AutoAllocateCharges_ChargeType", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_AUTOALLOCCHG_']/ancestor::form[1]/descendant::*[@id='LN___CHG___TYPE']");
				Function.AssertEqual(true,POMPOVCH_AutoAllocateCharges_ChargeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Close on AutoAllocateChargesForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_AutoAllocateChargesForm = new SeleniumControl( sDriver, "AutoAllocateChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_AUTOALLOCCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_AutoAllocateChargesForm);
IWebElement formBttn = POMPOVCH_AutoAllocateChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003754_POMPOVCH_VCHRHDR");
				Function.WaitControlDisplayed(POMPOVCH_ExchangeRatesLink);
POMPOVCH_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on ExchangeRates_Currencies_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ExchangeRates_Currencies_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_Currencies_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,POMPOVCH_ExchangeRates_Currencies_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_ExchangeRatesForm);
IWebElement formBttn = POMPOVCH_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Click on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007813_POMPOVCH_VCHRHDR");
				Function.WaitControlDisplayed(POMPOVCH_HeaderDocumentsLink);
POMPOVCH_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExist on HeaderDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_HeaderDocumentsFormTable = new SeleniumControl( sDriver, "HeaderDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMPOVCH_HeaderDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButtonIfExists on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_HeaderDocumentsForm);
IWebElement formBttn = POMPOVCH_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMPOVCH_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMPOVCH_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_HeaderDocuments_Document = new SeleniumControl( sDriver, "HeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POMPOVCH_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Close on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_HeaderDocumentsForm);
IWebElement formBttn = POMPOVCH_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_POLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMPOVCH_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButtonIfExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_POLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_ChildForm);
IWebElement formBttn = POMPOVCH_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMPOVCH_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMPOVCH_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on ChildForm_VchrLine...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm_VchrLine = new SeleniumControl( sDriver, "ChildForm_VchrLine", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_POLN_']/ancestor::form[1]/descendant::*[@id='VCHR_LN_NO']");
				Function.AssertEqual(true,POMPOVCH_ChildForm_VchrLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				Function.ScrollDown();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollDown]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_POLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMPOVCH_ChildFormTab);
IWebElement mTab = POMPOVCH_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on ChildForm_VoucherLineDetails_InvQty...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm_VoucherLineDetails_InvQty = new SeleniumControl( sDriver, "ChildForm_VoucherLineDetails_InvQty", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_POLN_']/ancestor::form[1]/descendant::*[@id='QTY']");
				Function.AssertEqual(true,POMPOVCH_ChildForm_VoucherLineDetails_InvQty.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_POLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMPOVCH_ChildFormTab);
IWebElement mTab = POMPOVCH_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "PO Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on ChildForm_POLineDetails_Item...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm_POLineDetails_Item = new SeleniumControl( sDriver, "ChildForm_POLineDetails_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_POLN_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,POMPOVCH_ChildForm_POLineDetails_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_POLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMPOVCH_ChildFormTab);
IWebElement mTab = POMPOVCH_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on ChildForm_Notes...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm_Notes = new SeleniumControl( sDriver, "ChildForm_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_POLN_']/ancestor::form[1]/descendant::*[@id='NOTES']");
				Function.AssertEqual(true,POMPOVCH_ChildForm_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Child Form Links");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				Function.ScrollDown();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollDown]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Click on ChildForm_ReceiptsLink...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm_ReceiptsLink = new SeleniumControl( sDriver, "ChildForm_ReceiptsLink", "ID", "lnk_2818_POMPOVCH_POLN");
				Function.WaitControlDisplayed(POMPOVCH_ChildForm_ReceiptsLink);
POMPOVCH_ChildForm_ReceiptsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButtonIfExists on ReceiptsForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ReceiptsForm = new SeleniumControl( sDriver, "ReceiptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_RECPTLN_RECEIPT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_ReceiptsForm);
IWebElement formBttn = POMPOVCH_ReceiptsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMPOVCH_ReceiptsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMPOVCH_ReceiptsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on Receipts_Receipt...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_Receipts_Receipt = new SeleniumControl( sDriver, "Receipts_Receipt", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_RECPTLN_RECEIPT_']/ancestor::form[1]/descendant::*[@id='RECPT_ID']");
				Function.AssertEqual(true,POMPOVCH_Receipts_Receipt.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButtonIfExists on ReceiptsForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ReceiptsForm = new SeleniumControl( sDriver, "ReceiptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_RECPTLN_RECEIPT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_ReceiptsForm);
IWebElement formBttn = POMPOVCH_ReceiptsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? POMPOVCH_ReceiptsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
POMPOVCH_ReceiptsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExist on ReceiptsFormTable...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ReceiptsFormTable = new SeleniumControl( sDriver, "ReceiptsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_RECPTLN_RECEIPT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMPOVCH_ReceiptsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButtonIfExists on ReceiptsForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ReceiptsForm = new SeleniumControl( sDriver, "ReceiptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_RECPTLN_RECEIPT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_ReceiptsForm);
IWebElement formBttn = POMPOVCH_ReceiptsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMPOVCH_ReceiptsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMPOVCH_ReceiptsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Close on ReceiptsForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ReceiptsForm = new SeleniumControl( sDriver, "ReceiptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_RECPTLN_RECEIPT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_ReceiptsForm);
IWebElement formBttn = POMPOVCH_ReceiptsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				Function.ScrollDown();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollDown]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Click on ChildForm_VendorReturnsLink...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm_VendorReturnsLink = new SeleniumControl( sDriver, "ChildForm_VendorReturnsLink", "ID", "lnk_2819_POMPOVCH_POLN");
				Function.WaitControlDisplayed(POMPOVCH_ChildForm_VendorReturnsLink);
POMPOVCH_ChildForm_VendorReturnsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExist on VendorReturnsFormTable...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_VendorReturnsFormTable = new SeleniumControl( sDriver, "VendorReturnsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VENDRTRNLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMPOVCH_VendorReturnsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButtonIfExists on VendorReturnsForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_VendorReturnsForm = new SeleniumControl( sDriver, "VendorReturnsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VENDRTRNLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_VendorReturnsForm);
IWebElement formBttn = POMPOVCH_VendorReturnsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMPOVCH_VendorReturnsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMPOVCH_VendorReturnsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on VendorReturns_VendorReturn...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_VendorReturns_VendorReturn = new SeleniumControl( sDriver, "VendorReturns_VendorReturn", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VENDRTRNLN_']/ancestor::form[1]/descendant::*[@id='RTRN_ID']");
				Function.AssertEqual(true,POMPOVCH_VendorReturns_VendorReturn.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Close on VendorReturnsForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_VendorReturnsForm = new SeleniumControl( sDriver, "VendorReturnsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VENDRTRNLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_VendorReturnsForm);
IWebElement formBttn = POMPOVCH_VendorReturnsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				Function.ScrollDown();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollDown]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Click on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_2820_POMPOVCH_POLN");
				Function.WaitControlDisplayed(POMPOVCH_ChildForm_LineChargesLink);
POMPOVCH_ChildForm_LineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExist on LineChargesFormTable...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_LineChargesFormTable = new SeleniumControl( sDriver, "LineChargesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VCHRLNCHG_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMPOVCH_LineChargesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButtonIfExists on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VCHRLNCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_LineChargesForm);
IWebElement formBttn = POMPOVCH_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMPOVCH_LineChargesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMPOVCH_LineChargesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on LineCharges_ChargeType...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_LineCharges_ChargeType = new SeleniumControl( sDriver, "LineCharges_ChargeType", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VCHRLNCHG_']/ancestor::form[1]/descendant::*[@id='LN_CHG_TYPE']");
				Function.AssertEqual(true,POMPOVCH_LineCharges_ChargeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Close on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VCHRLNCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_LineChargesForm);
IWebElement formBttn = POMPOVCH_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				Function.ScrollDown();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollDown]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Click on ChildForm_AccountsDistributionLink...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm_AccountsDistributionLink = new SeleniumControl( sDriver, "ChildForm_AccountsDistributionLink", "ID", "lnk_2821_POMPOVCH_POLN");
				Function.WaitControlDisplayed(POMPOVCH_ChildForm_AccountsDistributionLink);
POMPOVCH_ChildForm_AccountsDistributionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExist on AccountDistributionFormTable...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_AccountDistributionFormTable = new SeleniumControl( sDriver, "AccountDistributionFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VCHRLNACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMPOVCH_AccountDistributionFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButtonIfExists on AccountsDistributionForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_AccountsDistributionForm = new SeleniumControl( sDriver, "AccountsDistributionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VCHRLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_AccountsDistributionForm);
IWebElement formBttn = POMPOVCH_AccountsDistributionForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMPOVCH_AccountsDistributionForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMPOVCH_AccountsDistributionForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on AccountsDistribution_Account...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_AccountsDistribution_Account = new SeleniumControl( sDriver, "AccountsDistribution_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VCHRLNACCT_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,POMPOVCH_AccountsDistribution_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Close on AccountsDistributionForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_AccountsDistributionForm = new SeleniumControl( sDriver, "AccountsDistributionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VCHRLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_AccountsDistributionForm);
IWebElement formBttn = POMPOVCH_AccountsDistributionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				Function.ScrollDown();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollDown]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Click on ChildForm_VendorLaborLink...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm_VendorLaborLink = new SeleniumControl( sDriver, "ChildForm_VendorLaborLink", "ID", "lnk_2822_POMPOVCH_POLN");
				Function.WaitControlDisplayed(POMPOVCH_ChildForm_VendorLaborLink);
POMPOVCH_ChildForm_VendorLaborLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExist on VendorLaborTable...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_VendorLaborTable = new SeleniumControl( sDriver, "VendorLaborTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VCHRLABVEND_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMPOVCH_VendorLaborTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButtonIfExists on VendorLaborForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_VendorLaborForm = new SeleniumControl( sDriver, "VendorLaborForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VCHRLABVEND_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_VendorLaborForm);
IWebElement formBttn = POMPOVCH_VendorLaborForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMPOVCH_VendorLaborForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMPOVCH_VendorLaborForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on VendorLabor_SubLine...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_VendorLabor_SubLine = new SeleniumControl( sDriver, "VendorLabor_SubLine", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VCHRLABVEND_']/ancestor::form[1]/descendant::*[@id='SUB_LN_NO']");
				Function.AssertEqual(true,POMPOVCH_VendorLabor_SubLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Close on VendorLaborForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_VendorLaborForm = new SeleniumControl( sDriver, "VendorLaborForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_VCHRLABVEND_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_VendorLaborForm);
IWebElement formBttn = POMPOVCH_VendorLaborForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				Function.ScrollDown();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollDown]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Click on ChildForm_CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm_CurrencyLineLink = new SeleniumControl( sDriver, "ChildForm_CurrencyLineLink", "ID", "lnk_19868_POMPOVCH_POLN");
				Function.WaitControlDisplayed(POMPOVCH_ChildForm_CurrencyLineLink);
POMPOVCH_ChildForm_CurrencyLineLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on CurrencyLine_LineAmounts_CurrencyTransaction...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_CurrencyLine_LineAmounts_CurrencyTransaction = new SeleniumControl( sDriver, "CurrencyLine_LineAmounts_CurrencyTransaction", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_CURRENCYLN_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,POMPOVCH_CurrencyLine_LineAmounts_CurrencyTransaction.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Close on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_CURRENCYLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_CurrencyLineForm);
IWebElement formBttn = POMPOVCH_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				Function.ScrollDown();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollDown]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Click on ChildForm_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm_CustomsInfoLink = new SeleniumControl( sDriver, "ChildForm_CustomsInfoLink", "ID", "lnk_2824_POMPOVCH_POLN");
				Function.WaitControlDisplayed(POMPOVCH_ChildForm_CustomsInfoLink);
POMPOVCH_ChildForm_CustomsInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on CustomsInfo_ValueAddedTaxInformation_TaxCode...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_CustomsInfo_ValueAddedTaxInformation_TaxCode = new SeleniumControl( sDriver, "CustomsInfo_ValueAddedTaxInformation_TaxCode", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,POMPOVCH_CustomsInfo_ValueAddedTaxInformation_TaxCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Close on CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_CustomsInfoForm = new SeleniumControl( sDriver, "CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_CustomsInfoForm);
IWebElement formBttn = POMPOVCH_CustomsInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				Function.ScrollDown();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollDown]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Click on ChildForm_SubPOLineLink...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm_SubPOLineLink = new SeleniumControl( sDriver, "ChildForm_SubPOLineLink", "ID", "lnk_2825_POMPOVCH_POLN");
				Function.WaitControlDisplayed(POMPOVCH_ChildForm_SubPOLineLink);
POMPOVCH_ChildForm_SubPOLineLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on SubPOLine_POLine...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_SubPOLine_POLine = new SeleniumControl( sDriver, "SubPOLine_POLine", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_SUBPOLNINFO_']/ancestor::form[1]/descendant::*[@id='PO___LN___NO']");
				Function.AssertEqual(true,POMPOVCH_SubPOLine_POLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Close on SubPOLineForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_SubPOLineForm = new SeleniumControl( sDriver, "SubPOLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMPOVCH_SUBPOLNINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_SubPOLineForm);
IWebElement formBttn = POMPOVCH_SubPOLineForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				Function.ScrollDown();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollDown]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Click on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007815_POMPOVCH_POLN");
				Function.WaitControlDisplayed(POMPOVCH_ChildForm_LineDocumentsLink);
POMPOVCH_ChildForm_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExist on LineDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_LineDocumentsFormTable = new SeleniumControl( sDriver, "LineDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMPOVCH_LineDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing ClickButtonIfExists on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_LineDocumentsForm);
IWebElement formBttn = POMPOVCH_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMPOVCH_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMPOVCH_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing VerifyExists on LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_LineDocuments_Document = new SeleniumControl( sDriver, "LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POMPOVCH_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Close on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMPOVCH_LineDocumentsForm);
IWebElement formBttn = POMPOVCH_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMPOVCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMPOVCH] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMPOVCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMPOVCH_MainForm);
IWebElement formBttn = POMPOVCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogIfExists("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogIfExists]" , ex.Message));
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

