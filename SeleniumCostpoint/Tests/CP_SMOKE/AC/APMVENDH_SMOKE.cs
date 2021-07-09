 
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
    public class APMVENDH_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounts Payable Utilities", "xpath","//div[@class='navItem'][.='Accounts Payable Utilities']").Click();
new SeleniumControl(sDriver,"Manage Vendor History", "xpath","//div[@class='navItem'][.='Manage Vendor History']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APMVENDH_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on Identification_VoucherNo...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_Identification_VoucherNo = new SeleniumControl( sDriver, "Identification_VoucherNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VCHR_NO']");
				Function.AssertEqual(true,APMVENDH_Identification_VoucherNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMVENDH_MainForm);
IWebElement formBttn = APMVENDH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? APMVENDH_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
APMVENDH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVENDH_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMVENDH_MainForm);
IWebElement formBttn = APMVENDH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMVENDH_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMVENDH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on MainTab...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,APMVENDH_MainTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVENDH_MainTab);
IWebElement mTab = APMVENDH_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Vendor History").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on VendorHistory_Invoice_Number...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_VendorHistory_Invoice_Number = new SeleniumControl( sDriver, "VendorHistory_Invoice_Number", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVC_ID']");
				Function.AssertEqual(true,APMVENDH_VendorHistory_Invoice_Number.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVENDH_MainTab);
IWebElement mTab = APMVENDH_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on HeaderInfo_VATInfo_TaxID...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_HeaderInfo_VATInfo_TaxID = new SeleniumControl( sDriver, "HeaderInfo_VATInfo_TaxID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,APMVENDH_HeaderInfo_VATInfo_TaxID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVENDH_MainTab);
IWebElement mTab = APMVENDH_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Address").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on Address_Select_PayVendor...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_Address_Select_PayVendor = new SeleniumControl( sDriver, "Address_Select_PayVendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PAY_VEND_ID']");
				Function.AssertEqual(true,APMVENDH_Address_Select_PayVendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVENDH_MainTab);
IWebElement mTab = APMVENDH_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Subcontractor Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on SubcontractorInfo_SubcontractorPaymentControl_InvoicePeriodOfPerformanceDate...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_SubcontractorInfo_SubcontractorPaymentControl_InvoicePeriodOfPerformanceDate = new SeleniumControl( sDriver, "SubcontractorInfo_SubcontractorPaymentControl_InvoicePeriodOfPerformanceDate", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVC_POP_DT']");
				Function.AssertEqual(true,APMVENDH_SubcontractorInfo_SubcontractorPaymentControl_InvoicePeriodOfPerformanceDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVENDH_MainTab);
IWebElement mTab = APMVENDH_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes/Doc Loc").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on NotesDocLoc_PrintNoteOnCheck...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_NotesDocLoc_PrintNoteOnCheck = new SeleniumControl( sDriver, "NotesDocLoc_PrintNoteOnCheck", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PRINT_NOTE_FL']");
				Function.AssertEqual(true,APMVENDH_NotesDocLoc_PrintNoteOnCheck.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVENDH_MainTab);
IWebElement mTab = APMVENDH_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Recalculate Lines").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on RecalculateLines_RecalculationMethod...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_RecalculateLines_RecalculationMethod = new SeleniumControl( sDriver, "RecalculateLines_RecalculationMethod", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RECAL_METH']");
				Function.AssertEqual(true,APMVENDH_RecalculateLines_RecalculationMethod.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1004176_APMVENDH_VCHRHDRHS_HDR");
				Function.AssertEqual(true,APMVENDH_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on VoucherTotalsLink...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_VoucherTotalsLink = new SeleniumControl( sDriver, "VoucherTotalsLink", "ID", "lnk_5457_APMVENDH_VCHRHDRHS_HDR");
				Function.AssertEqual(true,APMVENDH_VoucherTotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1004176_APMVENDH_VCHRHDRHS_HDR");
				Function.WaitControlDisplayed(APMVENDH_ExchangeRatesLink);
APMVENDH_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVENDH_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ExchangeRates_Currencies_Transaction...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ExchangeRates_Currencies_Transaction = new SeleniumControl( sDriver, "ExchangeRates_Currencies_Transaction", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,APMVENDH_ExchangeRates_Currencies_Transaction.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVENDH_ExchangeRatesForm);
IWebElement formBttn = APMVENDH_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Click on VoucherTotalsLink...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_VoucherTotalsLink = new SeleniumControl( sDriver, "VoucherTotalsLink", "ID", "lnk_5457_APMVENDH_VCHRHDRHS_HDR");
				Function.WaitControlDisplayed(APMVENDH_VoucherTotalsLink);
APMVENDH_VoucherTotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on VoucherTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_VoucherTotalsForm = new SeleniumControl( sDriver, "VoucherTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVENDH_VoucherTotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on VoucherTotals_VoucherTotals_CostAmountTransaction...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_VoucherTotals_VoucherTotals_CostAmountTransaction = new SeleniumControl( sDriver, "VoucherTotals_VoucherTotals_CostAmountTransaction", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]/descendant::*[@id='TRN_CST_AMT']");
				Function.AssertEqual(true,APMVENDH_VoucherTotals_VoucherTotals_CostAmountTransaction.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Close on VoucherTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_VoucherTotalsForm = new SeleniumControl( sDriver, "VoucherTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVENDH_VoucherTotalsForm);
IWebElement formBttn = APMVENDH_VoucherTotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_LN_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVENDH_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_LN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVENDH_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_LN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVENDH_ChildForm);
IWebElement formBttn = APMVENDH_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMVENDH_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMVENDH_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_LN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,APMVENDH_ChildFormTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_LN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVENDH_ChildFormTab);
IWebElement mTab = APMVENDH_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Account Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildForm_AccountInfo_LineNo...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_AccountInfo_LineNo = new SeleniumControl( sDriver, "ChildForm_AccountInfo_LineNo", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_LN_']/ancestor::form[1]/descendant::*[@id='VCHR_LN_NO']");
				Function.AssertEqual(true,APMVENDH_ChildForm_AccountInfo_LineNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_LN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVENDH_ChildFormTab);
IWebElement mTab = APMVENDH_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildForm_OtherInfo_Vendor1099s_1099...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_OtherInfo_Vendor1099s_1099 = new SeleniumControl( sDriver, "ChildForm_OtherInfo_Vendor1099s_1099", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_LN_']/ancestor::form[1]/descendant::*[@id='AP_1099_FL']");
				Function.AssertEqual(true,APMVENDH_ChildForm_OtherInfo_Vendor1099s_1099.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_LN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVENDH_ChildFormTab);
IWebElement mTab = APMVENDH_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildForm_LineNotes_Notes...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_LineNotes_Notes = new SeleniumControl( sDriver, "ChildForm_LineNotes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_LN_']/ancestor::form[1]/descendant::*[@id='NOTES']");
				Function.AssertEqual(true,APMVENDH_ChildForm_LineNotes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildForm_VendorLaborLink...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_VendorLaborLink = new SeleniumControl( sDriver, "ChildForm_VendorLaborLink", "ID", "lnk_5453_APMVENDH_LN");
				Function.AssertEqual(true,APMVENDH_ChildForm_VendorLaborLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildForm_CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_CurrencyLineLink = new SeleniumControl( sDriver, "ChildForm_CurrencyLineLink", "ID", "lnk_5454_APMVENDH_LN");
				Function.AssertEqual(true,APMVENDH_ChildForm_CurrencyLineLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildForm_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_CustomsInfoLink = new SeleniumControl( sDriver, "ChildForm_CustomsInfoLink", "ID", "lnk_5456_APMVENDH_LN");
				Function.AssertEqual(true,APMVENDH_ChildForm_CustomsInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildForm_LineNotes_Notes...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_LineNotes_Notes = new SeleniumControl( sDriver, "ChildForm_LineNotes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_LN_']/ancestor::form[1]/descendant::*[@id='NOTES']");
				Function.AssertEqual(true,APMVENDH_ChildForm_LineNotes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Click on ChildForm_VendorLaborLink...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_VendorLaborLink = new SeleniumControl( sDriver, "ChildForm_VendorLaborLink", "ID", "lnk_5453_APMVENDH_LN");
				Function.WaitControlDisplayed(APMVENDH_ChildForm_VendorLaborLink);
APMVENDH_ChildForm_VendorLaborLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on Childform_VendorLaborForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_Childform_VendorLaborForm = new SeleniumControl( sDriver, "Childform_VendorLaborForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_VCHRLABVENDHS_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVENDH_Childform_VendorLaborForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExist on Childform_VendorLaborFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_Childform_VendorLaborFormTable = new SeleniumControl( sDriver, "Childform_VendorLaborFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_VCHRLABVENDHS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVENDH_Childform_VendorLaborFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing ClickButton on Childform_VendorLaborForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_Childform_VendorLaborForm = new SeleniumControl( sDriver, "Childform_VendorLaborForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_VCHRLABVENDHS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVENDH_Childform_VendorLaborForm);
IWebElement formBttn = APMVENDH_Childform_VendorLaborForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMVENDH_Childform_VendorLaborForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMVENDH_Childform_VendorLaborForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildForm_VendorLabor_SubLine...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_VendorLabor_SubLine = new SeleniumControl( sDriver, "ChildForm_VendorLabor_SubLine", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_VCHRLABVENDHS_']/ancestor::form[1]/descendant::*[@id='SUB_LN_NO']");
				Function.AssertEqual(true,APMVENDH_ChildForm_VendorLabor_SubLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Close on Childform_VendorLaborForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_Childform_VendorLaborForm = new SeleniumControl( sDriver, "Childform_VendorLaborForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDH_VCHRLABVENDHS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVENDH_Childform_VendorLaborForm);
IWebElement formBttn = APMVENDH_Childform_VendorLaborForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Click on ChildForm_CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_CurrencyLineLink = new SeleniumControl( sDriver, "ChildForm_CurrencyLineLink", "ID", "lnk_5454_APMVENDH_LN");
				Function.WaitControlDisplayed(APMVENDH_ChildForm_CurrencyLineLink);
APMVENDH_ChildForm_CurrencyLineLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildForm_CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_CurrencyLineForm = new SeleniumControl( sDriver, "ChildForm_CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPCURLN_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVENDH_ChildForm_CurrencyLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildForm_CurrencyLine_LineAmounts_Transaction_Currency...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_CurrencyLine_LineAmounts_Transaction_Currency = new SeleniumControl( sDriver, "ChildForm_CurrencyLine_LineAmounts_Transaction_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPCURLN_']/ancestor::form[1]/descendant::*[@id='T_CURRENCY']");
				Function.AssertEqual(true,APMVENDH_ChildForm_CurrencyLine_LineAmounts_Transaction_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Close on ChildForm_CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_CurrencyLineForm = new SeleniumControl( sDriver, "ChildForm_CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPCURLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVENDH_ChildForm_CurrencyLineForm);
IWebElement formBttn = APMVENDH_ChildForm_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Click on ChildForm_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_CustomsInfoLink = new SeleniumControl( sDriver, "ChildForm_CustomsInfoLink", "ID", "lnk_5456_APMVENDH_LN");
				Function.WaitControlDisplayed(APMVENDH_ChildForm_CustomsInfoLink);
APMVENDH_ChildForm_CustomsInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildForm_CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_CustomsInfoForm = new SeleniumControl( sDriver, "ChildForm_CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVENDH_ChildForm_CustomsInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing VerifyExists on ChildForm_CustomsInfo_ValueAddedTaxInformation_TaxCode...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_CustomsInfo_ValueAddedTaxInformation_TaxCode = new SeleniumControl( sDriver, "ChildForm_CustomsInfo_ValueAddedTaxInformation_TaxCode", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,APMVENDH_ChildForm_CustomsInfo_ValueAddedTaxInformation_TaxCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Close on ChildForm_CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_ChildForm_CustomsInfoForm = new SeleniumControl( sDriver, "ChildForm_CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVENDH_ChildForm_CustomsInfoForm);
IWebElement formBttn = APMVENDH_ChildForm_CustomsInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMVENDH_MainForm);
IWebElement formBttn = APMVENDH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).Count <= 0 ? APMVENDH_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Delete')]")).FirstOrDefault() :
APMVENDH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).FirstOrDefault();
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
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogIfExists("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDH] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMVENDH_MainForm);
IWebElement formBttn = APMVENDH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

