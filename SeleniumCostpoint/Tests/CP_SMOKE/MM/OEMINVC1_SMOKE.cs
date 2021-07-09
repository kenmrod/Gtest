 
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
    public class OEMINVC1_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Invoices", "xpath","//div[@class='navItem'][.='Manage Invoices']").Click();


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
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEMINVC1_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMINVC1_MainForm);
IWebElement formBttn = OEMINVC1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEMINVC1_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEMINVC1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC1_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMINVC1_MainForm);
IWebElement formBttn = OEMINVC1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC1_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on MainForm_Identification_InvoiceNo...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_Identification_InvoiceNo = new SeleniumControl( sDriver, "MainForm_Identification_InvoiceNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SO_INVC_ID']");
				Function.AssertEqual(true,OEMINVC1_MainForm_Identification_InvoiceNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on MainForm_Details_Customer...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_Details_Customer = new SeleniumControl( sDriver, "MainForm_Details_Customer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,OEMINVC1_MainForm_Details_Customer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC1_MainFormTab);
IWebElement mTab = OEMINVC1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "A/R").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on MainForm_AR_AccountsReceivable_Account...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_AR_AccountsReceivable_Account = new SeleniumControl( sDriver, "MainForm_AR_AccountsReceivable_Account", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='AR_ACCT_ID']");
				Function.AssertEqual(true,OEMINVC1_MainForm_AR_AccountsReceivable_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC1_MainFormTab);
IWebElement mTab = OEMINVC1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Posting Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on MainForm_PostingInfo_PeriodToPost_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_PostingInfo_PeriodToPost_FiscalYear = new SeleniumControl( sDriver, "MainForm_PostingInfo_PeriodToPost_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,OEMINVC1_MainForm_PostingInfo_PeriodToPost_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC1_MainFormTab);
IWebElement mTab = OEMINVC1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Addresses").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on MainForm_Addresses_BillTo...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_Addresses_BillTo = new SeleniumControl( sDriver, "MainForm_Addresses_BillTo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_TO_ADDR_DC']");
				Function.AssertEqual(true,OEMINVC1_MainForm_Addresses_BillTo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC1_MainFormTab);
IWebElement mTab = OEMINVC1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Liquidation").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on MainForm_Liquidation_LiquidationAccounts_Account...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_Liquidation_LiquidationAccounts_Account = new SeleniumControl( sDriver, "MainForm_Liquidation_LiquidationAccounts_Account", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LIQ_ACCT_ID']");
				Function.AssertEqual(true,OEMINVC1_MainForm_Liquidation_LiquidationAccounts_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC1_MainFormTab);
IWebElement mTab = OEMINVC1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC1_MainFormTab);
IWebElement mTab = OEMINVC1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "iRAPT").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on MainForm_WAWF_ShipmentNo...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_WAWF_ShipmentNo = new SeleniumControl( sDriver, "MainForm_WAWF_ShipmentNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SHIPMENT_NO_ID']");
				Function.AssertEqual(true,OEMINVC1_MainForm_WAWF_ShipmentNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC1_MainFormTab);
IWebElement mTab = OEMINVC1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Print Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on MainForm_PrintInfo_PrintInvoice...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_PrintInfo_PrintInvoice = new SeleniumControl( sDriver, "MainForm_PrintInfo_PrintInvoice", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVC_FL']");
				Function.AssertEqual(true,OEMINVC1_MainForm_PrintInfo_PrintInvoice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Header Standard Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on MainForm_HeaderStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_HeaderStandardTextLink = new SeleniumControl( sDriver, "MainForm_HeaderStandardTextLink", "ID", "lnk_1003950_OEMINVC_SOINVCHDR_HDR");
				Function.AssertEqual(true,OEMINVC1_MainForm_HeaderStandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Click on MainForm_HeaderStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_HeaderStandardTextLink = new SeleniumControl( sDriver, "MainForm_HeaderStandardTextLink", "ID", "lnk_1003950_OEMINVC_SOINVCHDR_HDR");
				Function.WaitControlDisplayed(OEMINVC1_MainForm_HeaderStandardTextLink);
OEMINVC1_MainForm_HeaderStandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on HeaderStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_HeaderStandardTextForm = new SeleniumControl( sDriver, "HeaderStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCTEXT_HST_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC1_HeaderStandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExist on HeaderStandardTextTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_HeaderStandardTextTable = new SeleniumControl( sDriver, "HeaderStandardTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCTEXT_HST_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC1_HeaderStandardTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Close on HeaderStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_HeaderStandardTextForm = new SeleniumControl( sDriver, "HeaderStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCTEXT_HST_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_HeaderStandardTextForm);
IWebElement formBttn = OEMINVC1_HeaderStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on MainForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_ExchangeRatesLink = new SeleniumControl( sDriver, "MainForm_ExchangeRatesLink", "ID", "lnk_1004023_OEMINVC_SOINVCHDR_HDR");
				Function.AssertEqual(true,OEMINVC1_MainForm_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Click on MainForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_ExchangeRatesLink = new SeleniumControl( sDriver, "MainForm_ExchangeRatesLink", "ID", "lnk_1004023_OEMINVC_SOINVCHDR_HDR");
				Function.WaitControlDisplayed(OEMINVC1_MainForm_ExchangeRatesLink);
OEMINVC1_MainForm_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC1_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,OEMINVC1_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_ExchangeRatesForm);
IWebElement formBttn = OEMINVC1_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SO Header Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on MainForm_SOHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_SOHeaderDocumentsLink = new SeleniumControl( sDriver, "MainForm_SOHeaderDocumentsLink", "ID", "lnk_1007525_OEMINVC_SOINVCHDR_HDR");
				Function.AssertEqual(true,OEMINVC1_MainForm_SOHeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Click on MainForm_SOHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_SOHeaderDocumentsLink = new SeleniumControl( sDriver, "MainForm_SOHeaderDocumentsLink", "ID", "lnk_1007525_OEMINVC_SOINVCHDR_HDR");
				Function.WaitControlDisplayed(OEMINVC1_MainForm_SOHeaderDocumentsLink);
OEMINVC1_MainForm_SOHeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC1_SOHeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExist on SOHeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_SOHeaderDocumentsTable = new SeleniumControl( sDriver, "SOHeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC1_SOHeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing ClickButton on SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_SOHeaderDocumentsForm);
IWebElement formBttn = OEMINVC1_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC1_SOHeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC1_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on SOHeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_SOHeaderDocuments_Document = new SeleniumControl( sDriver, "SOHeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,OEMINVC1_SOHeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Close on SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_SOHeaderDocumentsForm);
IWebElement formBttn = OEMINVC1_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Totals");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on MainForm_TotalsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_TotalsLink = new SeleniumControl( sDriver, "MainForm_TotalsLink", "ID", "lnk_1007432_OEMINVC_SOINVCHDR_HDR");
				Function.AssertEqual(true,OEMINVC1_MainForm_TotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Click on MainForm_TotalsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm_TotalsLink = new SeleniumControl( sDriver, "MainForm_TotalsLink", "ID", "lnk_1007432_OEMINVC_SOINVCHDR_HDR");
				Function.WaitControlDisplayed(OEMINVC1_MainForm_TotalsLink);
OEMINVC1_MainForm_TotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOTO_SQ_TOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC1_TotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on Totals_Currency...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_Totals_Currency = new SeleniumControl( sDriver, "Totals_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOTO_SQ_TOTALS_']/ancestor::form[1]/descendant::*[@id='TRANS_CURR_CODE']");
				Function.AssertEqual(true,OEMINVC1_Totals_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Close on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOTO_SQ_TOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_TotalsForm);
IWebElement formBttn = OEMINVC1_TotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC1_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC1_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_ChildForm);
IWebElement formBttn = OEMINVC1_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC1_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC1_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC1_ChildFormTab);
IWebElement mTab = OEMINVC1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ChildForm_LineDetails_InvoiceQuantity...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_LineDetails_InvoiceQuantity = new SeleniumControl( sDriver, "ChildForm_LineDetails_InvoiceQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='INVC_QTY']");
				Function.AssertEqual(true,OEMINVC1_ChildForm_LineDetails_InvoiceQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC1_ChildFormTab);
IWebElement mTab = OEMINVC1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Amounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ChildForm_Amounts_GrossUnitPrice...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_Amounts_GrossUnitPrice = new SeleniumControl( sDriver, "ChildForm_Amounts_GrossUnitPrice", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='TRN_GR_UNIT_PR_AMT']");
				Function.AssertEqual(true,OEMINVC1_ChildForm_Amounts_GrossUnitPrice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC1_ChildFormTab);
IWebElement mTab = OEMINVC1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Billing").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ChildForm_Billing_Recurring_BillingCycle...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_Billing_Recurring_BillingCycle = new SeleniumControl( sDriver, "ChildForm_Billing_Recurring_BillingCycle", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='BILL_CYCLE_CD']");
				Function.AssertEqual(true,OEMINVC1_ChildForm_Billing_Recurring_BillingCycle.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMINVC1_ChildFormTab);
IWebElement mTab = OEMINVC1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "SO Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Accounts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ChildForm_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_AccountsLink = new SeleniumControl( sDriver, "ChildForm_AccountsLink", "ID", "lnk_1004007_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC1_ChildForm_AccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Click on ChildForm_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_AccountsLink = new SeleniumControl( sDriver, "ChildForm_AccountsLink", "ID", "lnk_1004007_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC1_ChildForm_AccountsLink);
OEMINVC1_ChildForm_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SALESGROUPACCTS_ACCT_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC1_AccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExist on AccountsTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_AccountsTable = new SeleniumControl( sDriver, "AccountsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SALESGROUPACCTS_ACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC1_AccountsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing ClickButton on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SALESGROUPACCTS_ACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_AccountsForm);
IWebElement formBttn = OEMINVC1_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC1_AccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC1_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on Accounts_Project...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_Accounts_Project = new SeleniumControl( sDriver, "Accounts_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SALESGROUPACCTS_ACCT_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,OEMINVC1_Accounts_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Close on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SALESGROUPACCTS_ACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_AccountsForm);
IWebElement formBttn = OEMINVC1_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Issue Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ChildForm_IssueDetailLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_IssueDetailLink = new SeleniumControl( sDriver, "ChildForm_IssueDetailLink", "ID", "lnk_1004008_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC1_ChildForm_IssueDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Click on ChildForm_IssueDetailLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_IssueDetailLink = new SeleniumControl( sDriver, "ChildForm_IssueDetailLink", "ID", "lnk_1004008_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC1_ChildForm_IssueDetailLink);
OEMINVC1_ChildForm_IssueDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on IssueDetailForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_IssueDetailForm = new SeleniumControl( sDriver, "IssueDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOISSUELN_ISSUE_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC1_IssueDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExist on IssueDetailTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_IssueDetailTable = new SeleniumControl( sDriver, "IssueDetailTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOISSUELN_ISSUE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC1_IssueDetailTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing ClickButton on IssueDetailForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_IssueDetailForm = new SeleniumControl( sDriver, "IssueDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOISSUELN_ISSUE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_IssueDetailForm);
IWebElement formBttn = OEMINVC1_IssueDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC1_IssueDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC1_IssueDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on IssueDetail_IssueDetails_Issue...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_IssueDetail_IssueDetails_Issue = new SeleniumControl( sDriver, "IssueDetail_IssueDetails_Issue", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOISSUELN_ISSUE_']/ancestor::form[1]/descendant::*[@id='SO_ISSUE_ID']");
				Function.AssertEqual(true,OEMINVC1_IssueDetail_IssueDetails_Issue.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Close on IssueDetailForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_IssueDetailForm = new SeleniumControl( sDriver, "IssueDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOISSUELN_ISSUE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_IssueDetailForm);
IWebElement formBttn = OEMINVC1_IssueDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Charges");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1004009_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC1_ChildForm_LineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Click on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1004009_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC1_ChildForm_LineChargesLink);
OEMINVC1_ChildForm_LineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNCHG_LC_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC1_LineChargesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing ClickButton on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNCHG_LC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_LineChargesForm);
IWebElement formBttn = OEMINVC1_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC1_LineChargesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC1_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on LineCharges_ChargeType...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_LineCharges_ChargeType = new SeleniumControl( sDriver, "LineCharges_ChargeType", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNCHG_LC_']/ancestor::form[1]/descendant::*[@id='LN_CHG_TYPE']");
				Function.AssertEqual(true,OEMINVC1_LineCharges_ChargeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Close on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNCHG_LC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_LineChargesForm);
IWebElement formBttn = OEMINVC1_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Standard Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ChildForm_LineStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_LineStandardTextLink = new SeleniumControl( sDriver, "ChildForm_LineStandardTextLink", "ID", "lnk_1004010_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC1_ChildForm_LineStandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Click on ChildForm_LineStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_LineStandardTextLink = new SeleniumControl( sDriver, "ChildForm_LineStandardTextLink", "ID", "lnk_1004010_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC1_ChildForm_LineStandardTextLink);
OEMINVC1_ChildForm_LineStandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_LineStandardTextForm = new SeleniumControl( sDriver, "LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNTEXT_LST_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC1_LineStandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing ClickButton on LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_LineStandardTextForm = new SeleniumControl( sDriver, "LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNTEXT_LST_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_LineStandardTextForm);
IWebElement formBttn = OEMINVC1_LineStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC1_LineStandardTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC1_LineStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on LineStandardText_Sequence...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_LineStandardText_Sequence = new SeleniumControl( sDriver, "LineStandardText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNTEXT_LST_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,OEMINVC1_LineStandardText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Close on LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_LineStandardTextForm = new SeleniumControl( sDriver, "LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNTEXT_LST_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_LineStandardTextForm);
IWebElement formBttn = OEMINVC1_LineStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Currency Line Information");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ChildForm_CurrencyLineInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_CurrencyLineInformationLink = new SeleniumControl( sDriver, "ChildForm_CurrencyLineInformationLink", "ID", "lnk_1004019_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC1_ChildForm_CurrencyLineInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Click on ChildForm_CurrencyLineInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_CurrencyLineInformationLink = new SeleniumControl( sDriver, "ChildForm_CurrencyLineInformationLink", "ID", "lnk_1004019_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC1_ChildForm_CurrencyLineInformationLink);
OEMINVC1_ChildForm_CurrencyLineInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on CurrencyLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_CurrencyLineInformationForm = new SeleniumControl( sDriver, "CurrencyLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC1_CurrencyLineInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on CurrencyLineInformation_LineAmounts_Transaction_Currency...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_CurrencyLineInformation_LineAmounts_Transaction_Currency = new SeleniumControl( sDriver, "CurrencyLineInformation_LineAmounts_Transaction_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]/descendant::*[@id='TRANS_CURR_CODE']");
				Function.AssertEqual(true,OEMINVC1_CurrencyLineInformation_LineAmounts_Transaction_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Close on CurrencyLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_CurrencyLineInformationForm = new SeleniumControl( sDriver, "CurrencyLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_CurrencyLineInformationForm);
IWebElement formBttn = OEMINVC1_CurrencyLineInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Customs Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ChildForm_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_CustomsInfoLink = new SeleniumControl( sDriver, "ChildForm_CustomsInfoLink", "ID", "lnk_1004021_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC1_ChildForm_CustomsInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Click on ChildForm_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_CustomsInfoLink = new SeleniumControl( sDriver, "ChildForm_CustomsInfoLink", "ID", "lnk_1004021_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC1_ChildForm_CustomsInfoLink);
OEMINVC1_ChildForm_CustomsInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on CustomsInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_CustomsInformationForm = new SeleniumControl( sDriver, "CustomsInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC1_CustomsInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on CustomsInformation_ValueAddedTaxInfo_TaxID...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_CustomsInformation_ValueAddedTaxInfo_TaxID = new SeleniumControl( sDriver, "CustomsInformation_ValueAddedTaxInfo_TaxID", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,OEMINVC1_CustomsInformation_ValueAddedTaxInfo_TaxID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Close on CustomsInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_CustomsInformationForm = new SeleniumControl( sDriver, "CustomsInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_CustomsInformationForm);
IWebElement formBttn = OEMINVC1_CustomsInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Amortization Schedule");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ChildForm_AmortizationScheduleLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_AmortizationScheduleLink = new SeleniumControl( sDriver, "ChildForm_AmortizationScheduleLink", "ID", "lnk_1004603_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC1_ChildForm_AmortizationScheduleLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Click on ChildForm_AmortizationScheduleLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_AmortizationScheduleLink = new SeleniumControl( sDriver, "ChildForm_AmortizationScheduleLink", "ID", "lnk_1004603_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC1_ChildForm_AmortizationScheduleLink);
OEMINVC1_ChildForm_AmortizationScheduleLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on AmortizationScheduleForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_AmortizationScheduleForm = new SeleniumControl( sDriver, "AmortizationScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNAMORT_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC1_AmortizationScheduleForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on AmortizationSchedule_Rate...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_AmortizationSchedule_Rate = new SeleniumControl( sDriver, "AmortizationSchedule_Rate", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNAMORT_HDR_']/ancestor::form[1]/descendant::*[@id='RATE']");
				Function.AssertEqual(true,OEMINVC1_AmortizationSchedule_Rate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExist on AmortizationSchedule2Table...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_AmortizationSchedule2Table = new SeleniumControl( sDriver, "AmortizationSchedule2Table", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNAMORT_LNAMORT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC1_AmortizationSchedule2Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing ClickButton on AmortizationSchedule2Form...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_AmortizationSchedule2Form = new SeleniumControl( sDriver, "AmortizationSchedule2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNAMORT_LNAMORT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_AmortizationSchedule2Form);
IWebElement formBttn = OEMINVC1_AmortizationSchedule2Form.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC1_AmortizationSchedule2Form.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC1_AmortizationSchedule2Form.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on AmortizationSchedule_AmortizationSchedule_AmortizationRate...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_AmortizationSchedule_AmortizationSchedule_AmortizationRate = new SeleniumControl( sDriver, "AmortizationSchedule_AmortizationSchedule_AmortizationRate", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNAMORT_LNAMORT_']/ancestor::form[1]/descendant::*[@id='AMORT_PCT_RT']");
				Function.AssertEqual(true,OEMINVC1_AmortizationSchedule_AmortizationSchedule_AmortizationRate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Close on AmortizationScheduleForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_AmortizationScheduleForm = new SeleniumControl( sDriver, "AmortizationScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMINVC_SOINVCLNAMORT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_AmortizationScheduleForm);
IWebElement formBttn = OEMINVC1_AmortizationScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007706_OEMINVC_SOINVCLN_CTW");
				Function.AssertEqual(true,OEMINVC1_ChildForm_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Click on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007706_OEMINVC_SOINVCLN_CTW");
				Function.WaitControlDisplayed(OEMINVC1_ChildForm_LineDocumentsLink);
OEMINVC1_ChildForm_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMINVC1_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExist on LineDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_LineDocumentsTable = new SeleniumControl( sDriver, "LineDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMINVC1_LineDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing ClickButton on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_LineDocumentsForm);
IWebElement formBttn = OEMINVC1_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMINVC1_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMINVC1_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing VerifyExists on LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_LineDocuments_Document = new SeleniumControl( sDriver, "LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,OEMINVC1_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Close on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMINVC1_LineDocumentsForm);
IWebElement formBttn = OEMINVC1_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMINVC1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMINVC1] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMINVC1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMINVC1_MainForm);
IWebElement formBttn = OEMINVC1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

