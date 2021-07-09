 
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
    public class ARMCR_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounts Receivable", "xpath","//div[@class='deptItem'][.='Accounts Receivable']").Click();
new SeleniumControl(sDriver,"Cash Receipts Processing", "xpath","//div[@class='navItem'][.='Cash Receipts Processing']").Click();
new SeleniumControl(sDriver,"Manage Cash Receipts", "xpath","//div[@class='navItem'][.='Manage Cash Receipts']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing VerifyExists on Identification_Receipt_Date...", Logger.MessageType.INF);
				SeleniumControl ARMCR_Identification_Receipt_Date = new SeleniumControl( sDriver, "Identification_Receipt_Date", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RECPT_DT']");
				Function.AssertEqual(true,ARMCR_Identification_Receipt_Date.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARMCR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ARMCR_MainForm);
IWebElement formBttn = ARMCR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? ARMCR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
ARMCR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing VerifyExist on MainForm_Table...", Logger.MessageType.INF);
				SeleniumControl ARMCR_MainForm_Table = new SeleniumControl( sDriver, "MainForm_Table", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMCR_MainForm_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Invoice Information");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing Click on Identification_InvoiceInformationLink...", Logger.MessageType.INF);
				SeleniumControl ARMCR_Identification_InvoiceInformationLink = new SeleniumControl( sDriver, "Identification_InvoiceInformationLink", "ID", "lnk_1001886_ARMCR_CASH_RECPT_HDR");
				Function.WaitControlDisplayed(ARMCR_Identification_InvoiceInformationLink);
ARMCR_Identification_InvoiceInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing VerifyExists on InvoiceInformation_CashAccount...", Logger.MessageType.INF);
				SeleniumControl ARMCR_InvoiceInformation_CashAccount = new SeleniumControl( sDriver, "InvoiceInformation_CashAccount", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_INVOICE_HDR_']/ancestor::form[1]/descendant::*[@id='TRNSF_ACCT_DC']");
				Function.AssertEqual(true,ARMCR_InvoiceInformation_CashAccount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing VerifyExist on InvoiceInformationDetail_Table...", Logger.MessageType.INF);
				SeleniumControl ARMCR_InvoiceInformationDetail_Table = new SeleniumControl( sDriver, "InvoiceInformationDetail_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_INVOICE_TRN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMCR_InvoiceInformationDetail_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing ClickButton on InvoiceInformationDetailForm...", Logger.MessageType.INF);
				SeleniumControl ARMCR_InvoiceInformationDetailForm = new SeleniumControl( sDriver, "InvoiceInformationDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_INVOICE_TRN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCR_InvoiceInformationDetailForm);
IWebElement formBttn = ARMCR_InvoiceInformationDetailForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? ARMCR_InvoiceInformationDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
ARMCR_InvoiceInformationDetailForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing ClickButton on InvoiceInformationDetailForm...", Logger.MessageType.INF);
				SeleniumControl ARMCR_InvoiceInformationDetailForm = new SeleniumControl( sDriver, "InvoiceInformationDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_INVOICE_TRN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCR_InvoiceInformationDetailForm);
IWebElement formBttn = ARMCR_InvoiceInformationDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMCR_InvoiceInformationDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMCR_InvoiceInformationDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing VerifyExists on InvoiceInformationDetail_Invoice...", Logger.MessageType.INF);
				SeleniumControl ARMCR_InvoiceInformationDetail_Invoice = new SeleniumControl( sDriver, "InvoiceInformationDetail_Invoice", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_INVOICE_TRN_']/ancestor::form[1]/descendant::*[@id='INVC_ID']");
				Function.AssertEqual(true,ARMCR_InvoiceInformationDetail_Invoice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing Select on InvoiceInformationDetail_Tab...", Logger.MessageType.INF);
				SeleniumControl ARMCR_InvoiceInformationDetail_Tab = new SeleniumControl( sDriver, "InvoiceInformationDetail_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_INVOICE_TRN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ARMCR_InvoiceInformationDetail_Tab);
IWebElement mTab = ARMCR_InvoiceInformationDetail_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Charge Distribution").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing Select on InvoiceInformationDetail_Tab...", Logger.MessageType.INF);
				SeleniumControl ARMCR_InvoiceInformationDetail_Tab = new SeleniumControl( sDriver, "InvoiceInformationDetail_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_INVOICE_TRN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ARMCR_InvoiceInformationDetail_Tab);
IWebElement mTab = ARMCR_InvoiceInformationDetail_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Functional Amounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing Close on InvoiceInformationForm...", Logger.MessageType.INF);
				SeleniumControl ARMCR_InvoiceInformationForm = new SeleniumControl( sDriver, "InvoiceInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_INVOICE_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCR_InvoiceInformationForm);
IWebElement formBttn = ARMCR_InvoiceInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Transfers");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing Click on Identification_TransfersLink...", Logger.MessageType.INF);
				SeleniumControl ARMCR_Identification_TransfersLink = new SeleniumControl( sDriver, "Identification_TransfersLink", "ID", "lnk_1001888_ARMCR_CASH_RECPT_HDR");
				Function.WaitControlDisplayed(ARMCR_Identification_TransfersLink);
ARMCR_Identification_TransfersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing VerifyExists on Transfers_TransferAmount...", Logger.MessageType.INF);
				SeleniumControl ARMCR_Transfers_TransferAmount = new SeleniumControl( sDriver, "Transfers_TransferAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_TRANSFER_']/ancestor::form[1]/descendant::*[@id='PAY_TRN_AMT']");
				Function.AssertEqual(true,ARMCR_Transfers_TransferAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Exchange Rates");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing Click on Identification_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl ARMCR_Identification_ExchangeRatesLink = new SeleniumControl( sDriver, "Identification_ExchangeRatesLink", "ID", "lnk_1003297_ARMCR_CASH_RECPT_HDR");
				Function.WaitControlDisplayed(ARMCR_Identification_ExchangeRatesLink);
ARMCR_Identification_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing VerifyExists on ExchangeRates_PayCurrency...", Logger.MessageType.INF);
				SeleniumControl ARMCR_ExchangeRates_PayCurrency = new SeleniumControl( sDriver, "ExchangeRates_PayCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,ARMCR_ExchangeRates_PayCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing Click on ExchangeRates_Apply...", Logger.MessageType.INF);
				SeleniumControl ARMCR_ExchangeRates_Apply = new SeleniumControl( sDriver, "ExchangeRates_Apply", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bApply']");
				Function.WaitControlDisplayed(ARMCR_ExchangeRates_Apply);
if (ARMCR_ExchangeRates_Apply.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
ARMCR_ExchangeRates_Apply.Click(5,5);
else ARMCR_ExchangeRates_Apply.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Cash Receipt Details");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMCR_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_CASH_RECPT_TRN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMCR_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing ClickButton on CashReceiptDetailForm...", Logger.MessageType.INF);
				SeleniumControl ARMCR_CashReceiptDetailForm = new SeleniumControl( sDriver, "CashReceiptDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_CASH_RECPT_TRN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCR_CashReceiptDetailForm);
IWebElement formBttn = ARMCR_CashReceiptDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMCR_CashReceiptDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMCR_CashReceiptDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing VerifyExists on CashReceiptDetail_Line...", Logger.MessageType.INF);
				SeleniumControl ARMCR_CashReceiptDetail_Line = new SeleniumControl( sDriver, "CashReceiptDetail_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_CASH_RECPT_TRN_']/ancestor::form[1]/descendant::*[@id='LN_NO']");
				Function.AssertEqual(true,ARMCR_CashReceiptDetail_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing Select on CashReceiptDetail_Tab...", Logger.MessageType.INF);
				SeleniumControl ARMCR_CashReceiptDetail_Tab = new SeleniumControl( sDriver, "CashReceiptDetail_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_CASH_RECPT_TRN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ARMCR_CashReceiptDetail_Tab);
IWebElement mTab = ARMCR_CashReceiptDetail_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Charge Distribution").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing VerifyExists on CashReceiptDetail_ChargeDistribution_Account...", Logger.MessageType.INF);
				SeleniumControl ARMCR_CashReceiptDetail_ChargeDistribution_Account = new SeleniumControl( sDriver, "CashReceiptDetail_ChargeDistribution_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_CASH_RECPT_TRN_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,ARMCR_CashReceiptDetail_ChargeDistribution_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing Select on CashReceiptDetail_Tab...", Logger.MessageType.INF);
				SeleniumControl ARMCR_CashReceiptDetail_Tab = new SeleniumControl( sDriver, "CashReceiptDetail_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_CASH_RECPT_TRN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ARMCR_CashReceiptDetail_Tab);
IWebElement mTab = ARMCR_CashReceiptDetail_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Miscellaneous").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing VerifyExists on CashReceiptDetail_Miscellaneous_Check...", Logger.MessageType.INF);
				SeleniumControl ARMCR_CashReceiptDetail_Miscellaneous_Check = new SeleniumControl( sDriver, "CashReceiptDetail_Miscellaneous_Check", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_CASH_RECPT_TRN_']/ancestor::form[1]/descendant::*[@id='CHK_NO']");
				Function.AssertEqual(true,ARMCR_CashReceiptDetail_Miscellaneous_Check.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing Select on CashReceiptDetail_Tab...", Logger.MessageType.INF);
				SeleniumControl ARMCR_CashReceiptDetail_Tab = new SeleniumControl( sDriver, "CashReceiptDetail_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_CASH_RECPT_TRN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ARMCR_CashReceiptDetail_Tab);
IWebElement mTab = ARMCR_CashReceiptDetail_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Functional Amounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing VerifyExists on CashReceiptDetail_FunctionalAmounts_FuncAmountRecvd...", Logger.MessageType.INF);
				SeleniumControl ARMCR_CashReceiptDetail_FunctionalAmounts_FuncAmountRecvd = new SeleniumControl( sDriver, "CashReceiptDetail_FunctionalAmounts_FuncAmountRecvd", "xpath", "//div[translate(@id,'0123456789','')='pr__ARMCR_CASH_RECPT_TRN_']/ancestor::form[1]/descendant::*[@id='TRN_AMT']");
				Function.AssertEqual(true,ARMCR_CashReceiptDetail_FunctionalAmounts_FuncAmountRecvd.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCR] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARMCR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ARMCR_MainForm);
IWebElement formBttn = ARMCR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

