 
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
    public class PPMQTV_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Procurement Planning", "xpath","//div[@class='deptItem'][.='Procurement Planning']").Click();
new SeleniumControl(sDriver,"Vendor Quotes", "xpath","//div[@class='navItem'][.='Vendor Quotes']").Click();
new SeleniumControl(sDriver,"Manage Vendor Quotes By Vendor", "xpath","//div[@class='navItem'][.='Manage Vendor Quotes By Vendor']").Click();


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
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMQTV_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on VENDORQuote...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_VENDORQuote = new SeleniumControl( sDriver, "VENDORQuote", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='QUOTE_ID']");
				Function.AssertEqual(true,PPMQTV_VENDORQuote.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMQTV_MainTab);
IWebElement mTab = PPMQTV_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on Details_RFQ...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_Details_RFQ = new SeleniumControl( sDriver, "Details_RFQ", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ORIG_RFQ_ID']");
				Function.AssertEqual(true,PPMQTV_Details_RFQ.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMQTV_MainTab);
IWebElement mTab = PPMQTV_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "RFQ Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on RFQInfo_RFQInformation_Proposal...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_RFQInfo_RFQInformation_Proposal = new SeleniumControl( sDriver, "RFQInfo_RFQInformation_Proposal", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='REF_PROPOSAL_ID']");
				Function.AssertEqual(true,PPMQTV_RFQInfo_RFQInformation_Proposal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMQTV_MainTab);
IWebElement mTab = PPMQTV_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_Notes_Notes = new SeleniumControl( sDriver, "Notes_Notes", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='QT_HDR_NOTES']");
				Function.AssertEqual(true,PPMQTV_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMQTV_MainForm);
IWebElement formBttn = PPMQTV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PPMQTV_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PPMQTV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMQTV_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003426_PPMQTV_QTHDR");
				Function.AssertEqual(true,PPMQTV_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003426_PPMQTV_QTHDR");
				Function.WaitControlDisplayed(PPMQTV_ExchangeRatesLink);
PPMQTV_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMQTV_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMQTV_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMQTV_ExchangeRatesForm);
IWebElement formBttn = PPMQTV_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMQTV_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLN_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMQTV_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLN_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMQTV_ChildForm);
IWebElement formBttn = PPMQTV_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMQTV_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMQTV_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("childFormTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing Select on ChildForm_LineDetails_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ChildForm_LineDetails_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_LineDetails_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMQTV_ChildForm_LineDetails_ChildFormTab);
IWebElement mTab = PPMQTV_ChildForm_LineDetails_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on ChildForm_LineDetails_QuoteLine...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ChildForm_LineDetails_QuoteLine = new SeleniumControl( sDriver, "ChildForm_LineDetails_QuoteLine", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='QT_LN_NO']");
				Function.AssertEqual(true,PPMQTV_ChildForm_LineDetails_QuoteLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing Select on ChildForm_LineDetails_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ChildForm_LineDetails_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_LineDetails_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMQTV_ChildForm_LineDetails_ChildFormTab);
IWebElement mTab = PPMQTV_ChildForm_LineDetails_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manuf/Vend Parts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on ChildForm_ManufVendxParts_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ChildForm_ManufVendxParts_Manufacturer = new SeleniumControl( sDriver, "ChildForm_ManufVendxParts_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,PPMQTV_ChildForm_ManufVendxParts_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing Select on ChildForm_LineDetails_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ChildForm_LineDetails_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_LineDetails_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMQTV_ChildForm_LineDetails_ChildFormTab);
IWebElement mTab = PPMQTV_ChildForm_LineDetails_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on ChildForm_LineNotes_Notes...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ChildForm_LineNotes_Notes = new SeleniumControl( sDriver, "ChildForm_LineNotes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='QT_LN_NOTES']");
				Function.AssertEqual(true,PPMQTV_ChildForm_LineNotes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1003432_PPMQTV_QTLN_CHILD");
				Function.AssertEqual(true,PPMQTV_ChildForm_LineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing Click on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1003432_PPMQTV_QTLN_CHILD");
				Function.WaitControlDisplayed(PPMQTV_ChildForm_LineChargesLink);
PPMQTV_ChildForm_LineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExist on LineChargesTable...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_LineChargesTable = new SeleniumControl( sDriver, "LineChargesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNCHG_LINE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMQTV_LineChargesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNCHG_LINE_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMQTV_LineChargesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing Close on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNCHG_LINE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMQTV_LineChargesForm);
IWebElement formBttn = PPMQTV_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Quantity Breakpoints");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on ChildForm_QuantityBreakpointsLink...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ChildForm_QuantityBreakpointsLink = new SeleniumControl( sDriver, "ChildForm_QuantityBreakpointsLink", "ID", "lnk_1003433_PPMQTV_QTLN_CHILD");
				Function.AssertEqual(true,PPMQTV_ChildForm_QuantityBreakpointsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing Click on ChildForm_QuantityBreakpointsLink...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_ChildForm_QuantityBreakpointsLink = new SeleniumControl( sDriver, "ChildForm_QuantityBreakpointsLink", "ID", "lnk_1003433_PPMQTV_QTLN_CHILD");
				Function.WaitControlDisplayed(PPMQTV_ChildForm_QuantityBreakpointsLink);
PPMQTV_ChildForm_QuantityBreakpointsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExist on QuantityBreakpointsTable...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_QuantityBreakpointsTable = new SeleniumControl( sDriver, "QuantityBreakpointsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLNBRK_QBRK_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMQTV_QuantityBreakpointsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on QuantityBreakpointsForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_QuantityBreakpointsForm = new SeleniumControl( sDriver, "QuantityBreakpointsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLNBRK_QBRK_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMQTV_QuantityBreakpointsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing ClickButton on QuantityBreakpointsForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_QuantityBreakpointsForm = new SeleniumControl( sDriver, "QuantityBreakpointsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLNBRK_QBRK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMQTV_QuantityBreakpointsForm);
IWebElement formBttn = PPMQTV_QuantityBreakpointsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMQTV_QuantityBreakpointsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMQTV_QuantityBreakpointsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing VerifyExists on QuantityBreakpoints_MinimumQuantity...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_QuantityBreakpoints_MinimumQuantity = new SeleniumControl( sDriver, "QuantityBreakpoints_MinimumQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLNBRK_QBRK_']/ancestor::form[1]/descendant::*[@id='MIN_QTY']");
				Function.AssertEqual(true,PPMQTV_QuantityBreakpoints_MinimumQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing Close on QuantityBreakpointsForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_QuantityBreakpointsForm = new SeleniumControl( sDriver, "QuantityBreakpointsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTV_QTLNBRK_QBRK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMQTV_QuantityBreakpointsForm);
IWebElement formBttn = PPMQTV_QuantityBreakpointsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close the application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTV] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMQTV_MainForm);
IWebElement formBttn = PPMQTV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

