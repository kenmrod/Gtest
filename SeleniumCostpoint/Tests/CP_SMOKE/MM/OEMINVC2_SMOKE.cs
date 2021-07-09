 
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
    public class OEMINVC2_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials", "xpath","//div[@class='busItem'][.='Materials']").Click();
new SeleniumControl(sDriver,"Sales Order Entry", "xpath","//div[@class='deptItem'][.='Sales Order Entry']").Click();
new SeleniumControl(sDriver,"Sales Order Invoices", "xpath","//div[@class='navItem'][.='Sales Order Invoices']").Click();
new SeleniumControl(sDriver,"Manage Invoices Supervisor Screen", "xpath","//div[@class='navItem'][.='Manage Invoices Supervisor Screen']").Click();


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
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEMINVC2_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on InvoiceNo...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_InvoiceNo = new SeleniumControl( sDriver, "InvoiceNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SO_INVC_ID']");
				Function.AssertEqual(true,OEMINVC2_InvoiceNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on Details_Customer...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_Details_Customer = new SeleniumControl( sDriver, "Details_Customer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,OEMINVC2_Details_Customer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC2_Tab);
IWebElement mTab = OEMINVC2_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "A/R").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on AR_AccountsReceivable_Account...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_AR_AccountsReceivable_Account = new SeleniumControl( sDriver, "AR_AccountsReceivable_Account", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='AR_ACCT_ID']");
				Function.AssertEqual(true,OEMINVC2_AR_AccountsReceivable_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC2_Tab);
IWebElement mTab = OEMINVC2_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Posting Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on PostingInfo_PeriodToPost_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_PostingInfo_PeriodToPost_FiscalYear = new SeleniumControl( sDriver, "PostingInfo_PeriodToPost_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,OEMINVC2_PostingInfo_PeriodToPost_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC2_Tab);
IWebElement mTab = OEMINVC2_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Addresses").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on Addresses_BillTo...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_Addresses_BillTo = new SeleniumControl( sDriver, "Addresses_BillTo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_TO_ADDR_DC']");
				Function.AssertEqual(true,OEMINVC2_Addresses_BillTo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC2_Tab);
IWebElement mTab = OEMINVC2_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Liquidation").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on Liquidation_LiquidationAccounts_Account...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_Liquidation_LiquidationAccounts_Account = new SeleniumControl( sDriver, "Liquidation_LiquidationAccounts_Account", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LIQ_ACCT_ID']");
				Function.AssertEqual(true,OEMINVC2_Liquidation_LiquidationAccounts_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC2_Tab);
IWebElement mTab = OEMINVC2_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_Notes_Notes = new SeleniumControl( sDriver, "Notes_Notes", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SO_INVC_NT']");
				Function.AssertEqual(true,OEMINVC2_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC2_Tab);
IWebElement mTab = OEMINVC2_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "iRAPT").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on WAWF_ShipmentNo...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_WAWF_ShipmentNo = new SeleniumControl( sDriver, "WAWF_ShipmentNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SHIPMENT_NO_ID']");
				Function.AssertEqual(true,OEMINVC2_WAWF_ShipmentNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC2_Tab);
IWebElement mTab = OEMINVC2_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Print Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on PrintInfo_PrintInvoice...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_PrintInfo_PrintInvoice = new SeleniumControl( sDriver, "PrintInfo_PrintInvoice", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVC_FL']");
				Function.AssertEqual(true,OEMINVC2_PrintInfo_PrintInvoice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM HEADERS STANDARD TEXT LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on HeaderStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_HeaderStandardTextLink = new SeleniumControl( sDriver, "HeaderStandardTextLink", "ID", "lnk_1003950_OEMINVC_SOINVCHDR_HDR");
				Function.AssertEqual(true,OEMINVC2_HeaderStandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Click on HeaderStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_HeaderStandardTextLink = new SeleniumControl( sDriver, "HeaderStandardTextLink", "ID", "lnk_1003950_OEMINVC_SOINVCHDR_HDR");
				Function.WaitControlDisplayed(OEMINVC2_HeaderStandardTextLink);
OEMINVC2_HeaderStandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExist on HeaderStandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_HeaderStandardTextFormTable = new SeleniumControl( sDriver, "HeaderStandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCTEXT_HST_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC2_HeaderStandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Close on HeaderStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_HeaderStandardTextForm = new SeleniumControl( sDriver, "HeaderStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCTEXT_HST_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_HeaderStandardTextForm);
IWebElement formBttn = OEMINVC2_HeaderStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM EXCHANGE RATES LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1004023_OEMINVC_SOINVCHDR_HDR");
				Function.AssertEqual(true,OEMINVC2_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1004023_OEMINVC_SOINVCHDR_HDR");
				Function.WaitControlDisplayed(OEMINVC2_ExchangeRatesLink);
OEMINVC2_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC2_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,OEMINVC2_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_ExchangeRatesForm);
IWebElement formBttn = OEMINVC2_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM SO HEADER DOCUMENTS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on SOHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_SOHeaderDocumentsLink = new SeleniumControl( sDriver, "SOHeaderDocumentsLink", "ID", "lnk_1007525_OEMINVC_SOINVCHDR_HDR");
				Function.AssertEqual(true,OEMINVC2_SOHeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Click on SOHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_SOHeaderDocumentsLink = new SeleniumControl( sDriver, "SOHeaderDocumentsLink", "ID", "lnk_1007525_OEMINVC_SOINVCHDR_HDR");
				Function.WaitControlDisplayed(OEMINVC2_SOHeaderDocumentsLink);
OEMINVC2_SOHeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExist on SOHeaderDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_SOHeaderDocumentsFormTable = new SeleniumControl( sDriver, "SOHeaderDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC2_SOHeaderDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing ClickButton on SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_SOHeaderDocumentsForm);
IWebElement formBttn = OEMINVC2_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC2_SOHeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC2_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC2_SOHeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on SOHeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_SOHeaderDocuments_Document = new SeleniumControl( sDriver, "SOHeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,OEMINVC2_SOHeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Close on SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_SOHeaderDocumentsForm);
IWebElement formBttn = OEMINVC2_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM TOTALS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on TotalsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_TotalsLink = new SeleniumControl( sDriver, "TotalsLink", "ID", "lnk_1007432_OEMINVC_SOINVCHDR_HDR");
				Function.AssertEqual(true,OEMINVC2_TotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Click on TotalsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_TotalsLink = new SeleniumControl( sDriver, "TotalsLink", "ID", "lnk_1007432_OEMINVC_SOINVCHDR_HDR");
				Function.WaitControlDisplayed(OEMINVC2_TotalsLink);
OEMINVC2_TotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOTO_SQ_TOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC2_TotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on Totals_Totals_Transaction_Currency...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_Totals_Totals_Transaction_Currency = new SeleniumControl( sDriver, "Totals_Totals_Transaction_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOTO_SQ_TOTALS_']/ancestor::form[1]/descendant::*[@id='TRANS_CURR_CODE']");
				Function.AssertEqual(true,OEMINVC2_Totals_Totals_Transaction_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Close on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOTO_SQ_TOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_TotalsForm);
IWebElement formBttn = OEMINVC2_TotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINTAIN INVOICES LINE DETAILS FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExist on MaintainInvoicesLineDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetailsFormTable = new SeleniumControl( sDriver, "MaintainInvoicesLineDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing ClickButton on MaintainInvoicesLineDetailsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetailsForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetailsForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC2_MaintainInvoicesLineDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC2_MaintainInvoicesLineDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINTAIN INVOICES LINE DETAILS TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_LineDetails_InvcLine...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineDetails_InvcLine = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineDetails_InvcLine", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='SO_INVC_LN_NO']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_LineDetails_InvcLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Select on MaintainInvoicesLineDetails_Tab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_Tab = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_Tab);
IWebElement mTab = OEMINVC2_MaintainInvoicesLineDetails_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Amounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_Amounts_VolumeDiscount...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_Amounts_VolumeDiscount = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_Amounts_VolumeDiscount", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='DISC_PCT_RT']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_Amounts_VolumeDiscount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Select on MaintainInvoicesLineDetails_Tab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_Tab = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_Tab);
IWebElement mTab = OEMINVC2_MaintainInvoicesLineDetails_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Billing").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_Billing_Recurring_BillingCycle...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_Billing_Recurring_BillingCycle = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_Billing_Recurring_BillingCycle", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='BILL_CYCLE_CD']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_Billing_Recurring_BillingCycle.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Select on MaintainInvoicesLineDetails_Tab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_Tab = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_Tab);
IWebElement mTab = OEMINVC2_MaintainInvoicesLineDetails_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "SO Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_SOLineNotes_SOLineNotes...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_SOLineNotes_SOLineNotes = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_SOLineNotes_SOLineNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='SO_INVC_LN_NOTES']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_SOLineNotes_SOLineNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINTAIN INVOICES LINE DETAILS ACCOUNTS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_AccountsLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_AccountsLink", "ID", "lnk_1004007_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_AccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Click on MaintainInvoicesLineDetails_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_AccountsLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_AccountsLink", "ID", "lnk_1004007_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_AccountsLink);
OEMINVC2_MaintainInvoicesLineDetails_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExist on MaintainInvoicesLineDetails_AccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_AccountsFormTable = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_AccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SALESGROUPACCTS_ACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_AccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing ClickButton on MaintainInvoicesLineDetails_AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_AccountsForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SALESGROUPACCTS_ACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_AccountsForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetails_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC2_MaintainInvoicesLineDetails_AccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC2_MaintainInvoicesLineDetails_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_AccountsForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SALESGROUPACCTS_ACCT_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_AccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_Accounts_Project...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_Accounts_Project = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_Accounts_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SALESGROUPACCTS_ACCT_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_Accounts_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Close on MaintainInvoicesLineDetails_AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_AccountsForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SALESGROUPACCTS_ACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_AccountsForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetails_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINTAIN INVOICES LINE DETAILS ISSUE DETAIL LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_IssueDetailLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_IssueDetailLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_IssueDetailLink", "ID", "lnk_1004008_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_IssueDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Click on MaintainInvoicesLineDetails_IssueDetailLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_IssueDetailLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_IssueDetailLink", "ID", "lnk_1004008_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_IssueDetailLink);
OEMINVC2_MaintainInvoicesLineDetails_IssueDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExist on MaintainInvoicesLineDetails_IssueDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_IssueDetailFormTable = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_IssueDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOISSUELN_ISSUE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_IssueDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing ClickButton on MaintainInvoicesLineDetails_IssueDetailForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_IssueDetailForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_IssueDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOISSUELN_ISSUE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_IssueDetailForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetails_IssueDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC2_MaintainInvoicesLineDetails_IssueDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC2_MaintainInvoicesLineDetails_IssueDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_IssueDetailForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_IssueDetailForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_IssueDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOISSUELN_ISSUE_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_IssueDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_IssueDetail_IssueDetails_Issue...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_IssueDetail_IssueDetails_Issue = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_IssueDetail_IssueDetails_Issue", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOISSUELN_ISSUE_']/ancestor::form[1]/descendant::*[@id='SO_ISSUE_ID']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_IssueDetail_IssueDetails_Issue.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Close on MaintainInvoicesLineDetails_IssueDetailForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_IssueDetailForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_IssueDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOISSUELN_ISSUE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_IssueDetailForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetails_IssueDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINTAIN INVOICES LINE DETAILS LINE CHARGES LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineChargesLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineChargesLink", "ID", "lnk_1004009_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_LineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Click on MaintainInvoicesLineDetails_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineChargesLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineChargesLink", "ID", "lnk_1004009_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_LineChargesLink);
OEMINVC2_MaintainInvoicesLineDetails_LineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExist on MaintainInvoicesLineDetails_LineChargesFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineChargesFormTable = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineChargesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNCHG_LC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_LineChargesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing ClickButton on MaintainInvoicesLineDetails_LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineChargesForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNCHG_LC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_LineChargesForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetails_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC2_MaintainInvoicesLineDetails_LineChargesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC2_MaintainInvoicesLineDetails_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineChargesForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNCHG_LC_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_LineChargesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_LineCharges_ChargeType...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineCharges_ChargeType = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineCharges_ChargeType", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNCHG_LC_']/ancestor::form[1]/descendant::*[@id='LN_CHG_TYPE']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_LineCharges_ChargeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Close on MaintainInvoicesLineDetails_LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineChargesForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNCHG_LC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_LineChargesForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetails_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINTAIN INVOICES LINE DETAILS LINE STANDARD TEXT LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_LineStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineStandardTextLink", "ID", "lnk_1004010_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Click on MaintainInvoicesLineDetails_LineStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineStandardTextLink", "ID", "lnk_1004010_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextLink);
OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExist on MaintainInvoicesLineDetails_LineStandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextFormTable = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineStandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNTEXT_LST_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing ClickButton on MaintainInvoicesLineDetails_LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNTEXT_LST_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNTEXT_LST_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_LineStandardText_Sequence...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineStandardText_Sequence = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineStandardText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNTEXT_LST_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_LineStandardText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Close on MaintainInvoicesLineDetails_LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNTEXT_LST_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetails_LineStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINTAIN INVOICES LINE DETAILS CURRENCY LINE INFORMATION LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_CurrencyLineInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_CurrencyLineInformationLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_CurrencyLineInformationLink", "ID", "lnk_1004019_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_CurrencyLineInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Click on MaintainInvoicesLineDetails_CurrencyLineInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_CurrencyLineInformationLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_CurrencyLineInformationLink", "ID", "lnk_1004019_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_CurrencyLineInformationLink);
OEMINVC2_MaintainInvoicesLineDetails_CurrencyLineInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_CurrencyLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_CurrencyLineInformationForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_CurrencyLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_CurrencyLineInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_CurrencyLineInformation_LineAmounts_Transaction_Currency...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_CurrencyLineInformation_LineAmounts_Transaction_Currency = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_CurrencyLineInformation_LineAmounts_Transaction_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]/descendant::*[@id='TRANS_CURR_CODE']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_CurrencyLineInformation_LineAmounts_Transaction_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Close on MaintainInvoicesLineDetails_CurrencyLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_CurrencyLineInformationForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_CurrencyLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_CurrencyLineInformationForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetails_CurrencyLineInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINTAIN INVOICES LINE DETAILS CUSTOMS INFO LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_CustomsInfoLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_CustomsInfoLink", "ID", "lnk_1004021_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_CustomsInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Click on MaintainInvoicesLineDetails_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_CustomsInfoLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_CustomsInfoLink", "ID", "lnk_1004021_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_CustomsInfoLink);
OEMINVC2_MaintainInvoicesLineDetails_CustomsInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_CustomsInfoForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_CustomsInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_CustomsInfo_ValueAddedTaxInformation_TaxCode...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_CustomsInfo_ValueAddedTaxInformation_TaxCode = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_CustomsInfo_ValueAddedTaxInformation_TaxCode", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_CustomsInfo_ValueAddedTaxInformation_TaxCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Close on MaintainInvoicesLineDetails_CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_CustomsInfoForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_CustomsInfoForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetails_CustomsInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINTAIN INVOICES LINE DETAILS AMORTIZATION SCHEDULE LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_AmortizationScheduleLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_AmortizationScheduleLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_AmortizationScheduleLink", "ID", "lnk_1004603_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_AmortizationScheduleLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Click on MaintainInvoicesLineDetails_AmortizationScheduleLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_AmortizationScheduleLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_AmortizationScheduleLink", "ID", "lnk_1004603_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_AmortizationScheduleLink);
OEMINVC2_MaintainInvoicesLineDetails_AmortizationScheduleLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_AmortizationScheduleForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_AmortizationScheduleForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_AmortizationScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNAMORT_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_AmortizationScheduleForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_AmortizationSchedule_CumulativeAmortization_Rate...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_AmortizationSchedule_CumulativeAmortization_Rate = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_AmortizationSchedule_CumulativeAmortization_Rate", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNAMORT_HDR_']/ancestor::form[1]/descendant::*[@id='RATE']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_AmortizationSchedule_CumulativeAmortization_Rate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Close on MaintainInvoicesLineDetails_AmortizationScheduleForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_AmortizationScheduleForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_AmortizationScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNAMORT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_AmortizationScheduleForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetails_AmortizationScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINTAIN INVOICES LINE DOCUMENTS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineDocumentsLink", "ID", "lnk_1007706_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Click on MaintainInvoicesLineDetails_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsLink = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineDocumentsLink", "ID", "lnk_1007706_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsLink);
OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExist on MaintainInvoicesLineDetails_LineDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsFormTable = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing ClickButton on MaintainInvoicesLineDetails_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing VerifyExists on MaintainInvoicesLineDetails_LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineDocuments_Document = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,OEMINVC2_MaintainInvoicesLineDetails_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Close on MaintainInvoicesLineDetails_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsForm = new SeleniumControl( sDriver, "MaintainInvoicesLineDetails_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsForm);
IWebElement formBttn = OEMINVC2_MaintainInvoicesLineDetails_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEMINVC2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC2] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMINVC2_MainForm);
IWebElement formBttn = OEMINVC2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
Function.ClickOkDialogWithMessage("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogWithMessage]" , ex.Message));
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

