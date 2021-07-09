 
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
    public class OEMNTSO2_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Sales Orders", "xpath","//div[@class='navItem'][.='Sales Orders']").Click();
new SeleniumControl(sDriver,"Manage Sales Orders Supervisor Screen", "xpath","//div[@class='navItem'][.='Manage Sales Orders Supervisor Screen']").Click();


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
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEMNTSO2_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on Identification_SO...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_Identification_SO = new SeleniumControl( sDriver, "Identification_SO", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SO_ID']");
				Function.AssertEqual(true,OEMNTSO2_Identification_SO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainFormTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO2_MainFormTab);
IWebElement mTab = OEMNTSO2_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on HeaderInfo_Customer...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_HeaderInfo_Customer = new SeleniumControl( sDriver, "HeaderInfo_Customer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,OEMNTSO2_HeaderInfo_Customer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO2_MainFormTab);
IWebElement mTab = OEMNTSO2_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Addresses").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on Addresses_BillTo...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_Addresses_BillTo = new SeleniumControl( sDriver, "Addresses_BillTo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_TO_ADDR_DC']");
				Function.AssertEqual(true,OEMNTSO2_Addresses_BillTo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO2_MainFormTab);
IWebElement mTab = OEMNTSO2_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Accounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on Accounts_SalesGroupAbbrev...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_Accounts_SalesGroupAbbrev = new SeleniumControl( sDriver, "Accounts_SalesGroupAbbrev", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SALES_ABBRV_CD']");
				Function.AssertEqual(true,OEMNTSO2_Accounts_SalesGroupAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO2_MainFormTab);
IWebElement mTab = OEMNTSO2_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Order Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on OrderDetails_Terms...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_OrderDetails_Terms = new SeleniumControl( sDriver, "OrderDetails_Terms", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_TERMS_DC']");
				Function.AssertEqual(true,OEMNTSO2_OrderDetails_Terms.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO2_MainFormTab);
IWebElement mTab = OEMNTSO2_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "iRAPT").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on WAWF_DoDAACs_InspectBy...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_WAWF_DoDAACs_InspectBy = new SeleniumControl( sDriver, "WAWF_DoDAACs_InspectBy", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INSPECT_BY_ADDR_CD']");
				Function.AssertEqual(true,OEMNTSO2_WAWF_DoDAACs_InspectBy.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO2_MainFormTab);
IWebElement mTab = OEMNTSO2_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on Notes_SONotes...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_Notes_SONotes = new SeleniumControl( sDriver, "Notes_SONotes", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SO_NOTES_NT']");
				Function.AssertEqual(true,OEMNTSO2_Notes_SONotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_MainForm);
IWebElement formBttn = OEMNTSO2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEMNTSO2_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEMNTSO2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO2_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("HeaderStandardTextLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on HeaderStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_HeaderStandardTextLink = new SeleniumControl( sDriver, "HeaderStandardTextLink", "ID", "lnk_1004586_OEMENTSO_SOHDR_HDR");
				Function.AssertEqual(true,OEMNTSO2_HeaderStandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on HeaderStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_HeaderStandardTextLink = new SeleniumControl( sDriver, "HeaderStandardTextLink", "ID", "lnk_1004586_OEMENTSO_SOHDR_HDR");
				Function.WaitControlDisplayed(OEMNTSO2_HeaderStandardTextLink);
OEMNTSO2_HeaderStandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExist on HeaderStandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_HeaderStandardTextFormTable = new SeleniumControl( sDriver, "HeaderStandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOTEXT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO2_HeaderStandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on HeaderStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_HeaderStandardTextForm = new SeleniumControl( sDriver, "HeaderStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOTEXT_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_HeaderStandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on HeaderStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_HeaderStandardTextForm = new SeleniumControl( sDriver, "HeaderStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_HeaderStandardTextForm);
IWebElement formBttn = OEMNTSO2_HeaderStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TotalsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TotalsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TotalsLink = new SeleniumControl( sDriver, "TotalsLink", "ID", "lnk_1004588_OEMENTSO_SOHDR_HDR");
				Function.AssertEqual(true,OEMNTSO2_TotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on TotalsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TotalsLink = new SeleniumControl( sDriver, "TotalsLink", "ID", "lnk_1004588_OEMENTSO_SOHDR_HDR");
				Function.WaitControlDisplayed(OEMNTSO2_TotalsLink);
OEMNTSO2_TotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOTO_SQ_TOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_TotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on Totals_Currency...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_Totals_Currency = new SeleniumControl( sDriver, "Totals_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOTO_SQ_TOTALS_']/ancestor::form[1]/descendant::*[@id='TRANS_CURR_CODE']");
				Function.AssertEqual(true,OEMNTSO2_Totals_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOTO_SQ_TOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TotalsForm);
IWebElement formBttn = OEMNTSO2_TotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ExchangeRatesLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1004589_OEMENTSO_SOHDR_HDR");
				Function.AssertEqual(true,OEMNTSO2_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1004589_OEMENTSO_SOHDR_HDR");
				Function.WaitControlDisplayed(OEMNTSO2_ExchangeRatesLink);
OEMNTSO2_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,OEMNTSO2_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_ExchangeRatesForm);
IWebElement formBttn = OEMNTSO2_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("UserDefinedInfoLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_15735_OEMENTSO_SOHDR_HDR");
				Function.AssertEqual(true,OEMNTSO2_UserDefinedInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_15735_OEMENTSO_SOHDR_HDR");
				Function.WaitControlDisplayed(OEMNTSO2_UserDefinedInfoLink);
OEMNTSO2_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExist on UserDefinedInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_UserDefinedInfoFormTable = new SeleniumControl( sDriver, "UserDefinedInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO2_UserDefinedInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_UserDefinedInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing ClickButton on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_UserDefinedInfoForm);
IWebElement formBttn = OEMNTSO2_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO2_UserDefinedInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO2_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on UserDefinedInfo_DataType...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_UserDefinedInfo_DataType = new SeleniumControl( sDriver, "UserDefinedInfo_DataType", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='DATA_TYPE']");
				Function.AssertEqual(true,OEMNTSO2_UserDefinedInfo_DataType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_UserDefinedInfoForm);
IWebElement formBttn = OEMNTSO2_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("HeaderDocumentsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007374_OEMENTSO_SOHDR_HDR");
				Function.AssertEqual(true,OEMNTSO2_HeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007374_OEMENTSO_SOHDR_HDR");
				Function.WaitControlDisplayed(OEMNTSO2_HeaderDocumentsLink);
OEMNTSO2_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExist on HeaderDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_HeaderDocumentsFormTable = new SeleniumControl( sDriver, "HeaderDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO2_HeaderDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing ClickButton on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_HeaderDocumentsForm);
IWebElement formBttn = OEMNTSO2_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO2_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO2_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on HeaderDocuments_ReferenceDoc...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_HeaderDocuments_ReferenceDoc = new SeleniumControl( sDriver, "HeaderDocuments_ReferenceDoc", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SODOCUMENT_']/ancestor::form[1]/descendant::*[@id='REF_DOC_FL']");
				Function.AssertEqual(true,OEMNTSO2_HeaderDocuments_ReferenceDoc.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_HeaderDocumentsForm);
IWebElement formBttn = OEMNTSO2_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExist on TableWindowTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindowTable = new SeleniumControl( sDriver, "TableWindowTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO2_TableWindowTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_TableWindowForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing ClickButton on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindowForm);
IWebElement formBttn = OEMNTSO2_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO2_TableWindowForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO2_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_Line...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_Line = new SeleniumControl( sDriver, "TableWindow_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='SO_LN_NO']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildFormTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Select on TableWindow_Tab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_Tab = new SeleniumControl( sDriver, "TableWindow_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_Tab);
IWebElement mTab = OEMNTSO2_TableWindow_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_LineDetails_LineType...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineDetails_LineType = new SeleniumControl( sDriver, "TableWindow_LineDetails_LineType", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='S_SO_LN_TYPE']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_LineDetails_LineType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Select on TableWindow_Tab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_Tab = new SeleniumControl( sDriver, "TableWindow_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_Tab);
IWebElement mTab = OEMNTSO2_TableWindow_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Order Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_OrderDetails_Warehouse...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_OrderDetails_Warehouse = new SeleniumControl( sDriver, "TableWindow_OrderDetails_Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_OrderDetails_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Select on TableWindow_Tab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_Tab = new SeleniumControl( sDriver, "TableWindow_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_Tab);
IWebElement mTab = OEMNTSO2_TableWindow_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Price Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_PriceDetails_TransCurrencyGrossUnitPrice...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_PriceDetails_TransCurrencyGrossUnitPrice = new SeleniumControl( sDriver, "TableWindow_PriceDetails_TransCurrencyGrossUnitPrice", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='TRN_GR_UNIT_PR_AMT']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_PriceDetails_TransCurrencyGrossUnitPrice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Select on TableWindow_Tab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_Tab = new SeleniumControl( sDriver, "TableWindow_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_Tab);
IWebElement mTab = OEMNTSO2_TableWindow_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shipping").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_Shipping_ShipID...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_Shipping_ShipID = new SeleniumControl( sDriver, "TableWindow_Shipping_ShipID", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='SHIP_ID']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_Shipping_ShipID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Select on TableWindow_Tab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_Tab = new SeleniumControl( sDriver, "TableWindow_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_Tab);
IWebElement mTab = OEMNTSO2_TableWindow_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Billing").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_Billing_SalesGroupAbbrev...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_Billing_SalesGroupAbbrev = new SeleniumControl( sDriver, "TableWindow_Billing_SalesGroupAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='SALES_ABBRV_CD']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_Billing_SalesGroupAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Select on TableWindow_Tab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_Tab = new SeleniumControl( sDriver, "TableWindow_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_Tab);
IWebElement mTab = OEMNTSO2_TableWindow_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_OtherInfo_NumberOfUsers...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_OtherInfo_NumberOfUsers = new SeleniumControl( sDriver, "TableWindow_OtherInfo_NumberOfUsers", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='USERS_NO']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_OtherInfo_NumberOfUsers.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Select on TableWindow_Tab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_Tab = new SeleniumControl( sDriver, "TableWindow_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_Tab);
IWebElement mTab = OEMNTSO2_TableWindow_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "SO Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_SOLineNotes_Text...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_SOLineNotes_Text = new SeleniumControl( sDriver, "TableWindow_SOLineNotes_Text", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='SO_LN_TX']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_SOLineNotes_Text.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SubcontractLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_SubcontractLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_SubcontractLink = new SeleniumControl( sDriver, "TableWindow_SubcontractLink", "ID", "lnk_1004595_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_SubcontractLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on TableWindow_SubcontractLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_SubcontractLink = new SeleniumControl( sDriver, "TableWindow_SubcontractLink", "ID", "lnk_1004595_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_SubcontractLink);
OEMNTSO2_TableWindow_SubcontractLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExist on TableWindow_SubcontractFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_SubcontractFormTable = new SeleniumControl( sDriver, "TableWindow_SubcontractFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNSUBCTCST_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_SubcontractFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_SubcontractForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_SubcontractForm = new SeleniumControl( sDriver, "TableWindow_SubcontractForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNSUBCTCST_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_SubcontractForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				Function.ScrollUp();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollUp]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing ClickButton on TableWindow_SubcontractForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_SubcontractForm = new SeleniumControl( sDriver, "TableWindow_SubcontractForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNSUBCTCST_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_SubcontractForm);
IWebElement formBttn = OEMNTSO2_TableWindow_SubcontractForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO2_TableWindow_SubcontractForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO2_TableWindow_SubcontractForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_Subcontract_Line...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_Subcontract_Line = new SeleniumControl( sDriver, "TableWindow_Subcontract_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNSUBCTCST_DTL_']/ancestor::form[1]/descendant::*[@id='SUBCT_CST_LN_NO']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_Subcontract_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on TableWindow_SubcontractForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_SubcontractForm = new SeleniumControl( sDriver, "TableWindow_SubcontractForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNSUBCTCST_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_SubcontractForm);
IWebElement formBttn = OEMNTSO2_TableWindow_SubcontractForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("AccountsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_AccountsLink = new SeleniumControl( sDriver, "TableWindow_AccountsLink", "ID", "lnk_1004606_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_AccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on TableWindow_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_AccountsLink = new SeleniumControl( sDriver, "TableWindow_AccountsLink", "ID", "lnk_1004606_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_AccountsLink);
OEMNTSO2_TableWindow_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExist on TableWindow_AccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_AccountsFormTable = new SeleniumControl( sDriver, "TableWindow_AccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SALESGROUPACCTS_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_AccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_AccountsForm = new SeleniumControl( sDriver, "TableWindow_AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SALESGROUPACCTS_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_AccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing ClickButton on TableWindow_AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_AccountsForm = new SeleniumControl( sDriver, "TableWindow_AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SALESGROUPACCTS_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_AccountsForm);
IWebElement formBttn = OEMNTSO2_TableWindow_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO2_TableWindow_AccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO2_TableWindow_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_Accounts_TransactionType...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_Accounts_TransactionType = new SeleniumControl( sDriver, "TableWindow_Accounts_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SALESGROUPACCTS_CHLD_']/ancestor::form[1]/descendant::*[@id='PROD_TRN_TYPE_DESC']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_Accounts_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on TableWindow_AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_AccountsForm = new SeleniumControl( sDriver, "TableWindow_AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SALESGROUPACCTS_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_AccountsForm);
IWebElement formBttn = OEMNTSO2_TableWindow_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ComponentsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_ComponentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ComponentsLink = new SeleniumControl( sDriver, "TableWindow_ComponentsLink", "ID", "lnk_1004592_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_ComponentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on TableWindow_ComponentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ComponentsLink = new SeleniumControl( sDriver, "TableWindow_ComponentsLink", "ID", "lnk_1004592_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_ComponentsLink);
OEMNTSO2_TableWindow_ComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExist on TableWindow_ComponentsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ComponentsFormTable = new SeleniumControl( sDriver, "TableWindow_ComponentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCOMP_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_ComponentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ComponentsForm = new SeleniumControl( sDriver, "TableWindow_ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCOMP_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_ComponentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing ClickButton on TableWindow_ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ComponentsForm = new SeleniumControl( sDriver, "TableWindow_ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCOMP_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_ComponentsForm);
IWebElement formBttn = OEMNTSO2_TableWindow_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO2_TableWindow_ComponentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO2_TableWindow_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_Components_Line...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_Components_Line = new SeleniumControl( sDriver, "TableWindow_Components_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCOMP_DTL_']/ancestor::form[1]/descendant::*[@id='SO_LN_COMP_NO']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_Components_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on TableWindow_ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ComponentsForm = new SeleniumControl( sDriver, "TableWindow_ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCOMP_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_ComponentsForm);
IWebElement formBttn = OEMNTSO2_TableWindow_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LineChargesLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineChargesLink = new SeleniumControl( sDriver, "TableWindow_LineChargesLink", "ID", "lnk_1004593_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_LineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on TableWindow_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineChargesLink = new SeleniumControl( sDriver, "TableWindow_LineChargesLink", "ID", "lnk_1004593_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_LineChargesLink);
OEMNTSO2_TableWindow_LineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExist on TableWindow_LineChargesFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineChargesFormTable = new SeleniumControl( sDriver, "TableWindow_LineChargesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCHG_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_LineChargesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineChargesForm = new SeleniumControl( sDriver, "TableWindow_LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCHG_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_LineChargesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing ClickButton on TableWindow_LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineChargesForm = new SeleniumControl( sDriver, "TableWindow_LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCHG_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_LineChargesForm);
IWebElement formBttn = OEMNTSO2_TableWindow_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO2_TableWindow_LineChargesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO2_TableWindow_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_LineCharges_ChargeType...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineCharges_ChargeType = new SeleniumControl( sDriver, "TableWindow_LineCharges_ChargeType", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCHG_DTL_']/ancestor::form[1]/descendant::*[@id='LN_CHG_TYPE']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_LineCharges_ChargeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on TableWindow_LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineChargesForm = new SeleniumControl( sDriver, "TableWindow_LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCHG_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_LineChargesForm);
IWebElement formBttn = OEMNTSO2_TableWindow_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LineStandardTextLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_LineStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineStandardTextLink = new SeleniumControl( sDriver, "TableWindow_LineStandardTextLink", "ID", "lnk_1004594_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_LineStandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on TableWindow_LineStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineStandardTextLink = new SeleniumControl( sDriver, "TableWindow_LineStandardTextLink", "ID", "lnk_1004594_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_LineStandardTextLink);
OEMNTSO2_TableWindow_LineStandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExist on TableWindow_LineStandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineStandardTextFormTable = new SeleniumControl( sDriver, "TableWindow_LineStandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNTEXT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_LineStandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineStandardTextForm = new SeleniumControl( sDriver, "TableWindow_LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNTEXT_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_LineStandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing ClickButton on TableWindow_LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineStandardTextForm = new SeleniumControl( sDriver, "TableWindow_LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_LineStandardTextForm);
IWebElement formBttn = OEMNTSO2_TableWindow_LineStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO2_TableWindow_LineStandardTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO2_TableWindow_LineStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_LineStandardText_Sequence...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineStandardText_Sequence = new SeleniumControl( sDriver, "TableWindow_LineStandardText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNTEXT_DTL_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_LineStandardText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on TableWindow_LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineStandardTextForm = new SeleniumControl( sDriver, "TableWindow_LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_LineStandardTextForm);
IWebElement formBttn = OEMNTSO2_TableWindow_LineStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CurrencyLineInformationLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_CurrencyLineInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_CurrencyLineInformationLink = new SeleniumControl( sDriver, "TableWindow_CurrencyLineInformationLink", "ID", "lnk_1004596_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_CurrencyLineInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on TableWindow_CurrencyLineInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_CurrencyLineInformationLink = new SeleniumControl( sDriver, "TableWindow_CurrencyLineInformationLink", "ID", "lnk_1004596_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_CurrencyLineInformationLink);
OEMNTSO2_TableWindow_CurrencyLineInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_CurrencyLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_CurrencyLineInformationForm = new SeleniumControl( sDriver, "TableWindow_CurrencyLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_CurrencyLineInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_CurrencyLineInformation_LineAmounts_Transaction_Currency...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_CurrencyLineInformation_LineAmounts_Transaction_Currency = new SeleniumControl( sDriver, "TableWindow_CurrencyLineInformation_LineAmounts_Transaction_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]/descendant::*[@id='TRANS_CURR_CODE']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_CurrencyLineInformation_LineAmounts_Transaction_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on TableWindow_CurrencyLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_CurrencyLineInformationForm = new SeleniumControl( sDriver, "TableWindow_CurrencyLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_CurrencyLineInformationForm);
IWebElement formBttn = OEMNTSO2_TableWindow_CurrencyLineInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CustomsInformationLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_CustomsInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_CustomsInformationLink = new SeleniumControl( sDriver, "TableWindow_CustomsInformationLink", "ID", "lnk_1007440_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_CustomsInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on TableWindow_CustomsInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_CustomsInformationLink = new SeleniumControl( sDriver, "TableWindow_CustomsInformationLink", "ID", "lnk_1007440_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_CustomsInformationLink);
OEMNTSO2_TableWindow_CustomsInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_CustomsInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_CustomsInformationForm = new SeleniumControl( sDriver, "TableWindow_CustomsInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOHDRAPPRVL_CUSTLNDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_CustomsInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_CustomsInformation_ValueAddedTaxInfo_TaxID...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_CustomsInformation_ValueAddedTaxInfo_TaxID = new SeleniumControl( sDriver, "TableWindow_CustomsInformation_ValueAddedTaxInfo_TaxID", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOHDRAPPRVL_CUSTLNDTL_']/ancestor::form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_CustomsInformation_ValueAddedTaxInfo_TaxID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on TableWindow_CustomsInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_CustomsInformationForm = new SeleniumControl( sDriver, "TableWindow_CustomsInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOHDRAPPRVL_CUSTLNDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_CustomsInformationForm);
IWebElement formBttn = OEMNTSO2_TableWindow_CustomsInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LineDocumentsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineDocumentsLink = new SeleniumControl( sDriver, "TableWindow_LineDocumentsLink", "ID", "lnk_1007697_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on TableWindow_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineDocumentsLink = new SeleniumControl( sDriver, "TableWindow_LineDocumentsLink", "ID", "lnk_1007697_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_LineDocumentsLink);
OEMNTSO2_TableWindow_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExist on TableWindow_LineDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineDocumentsFormTable = new SeleniumControl( sDriver, "TableWindow_LineDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_LineDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineDocumentsForm = new SeleniumControl( sDriver, "TableWindow_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing ClickButton on TableWindow_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineDocumentsForm = new SeleniumControl( sDriver, "TableWindow_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_LineDocumentsForm);
IWebElement formBttn = OEMNTSO2_TableWindow_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO2_TableWindow_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO2_TableWindow_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_LineDocuments_ReferenceDoc...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineDocuments_ReferenceDoc = new SeleniumControl( sDriver, "TableWindow_LineDocuments_ReferenceDoc", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='REF_DOC_FL']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_LineDocuments_ReferenceDoc.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on TableWindow_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_LineDocumentsForm = new SeleniumControl( sDriver, "TableWindow_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_LineDocumentsForm);
IWebElement formBttn = OEMNTSO2_TableWindow_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ConsumeForecastLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_ConsumeForecastLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ConsumeForecastLink = new SeleniumControl( sDriver, "TableWindow_ConsumeForecastLink", "ID", "lnk_1007750_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_ConsumeForecastLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Click on TableWindow_ConsumeForecastLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ConsumeForecastLink = new SeleniumControl( sDriver, "TableWindow_ConsumeForecastLink", "ID", "lnk_1007750_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_ConsumeForecastLink);
OEMNTSO2_TableWindow_ConsumeForecastLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_ConsumeForecastForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ConsumeForecastForm = new SeleniumControl( sDriver, "TableWindow_ConsumeForecastForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_MPSFORECASTSOLN_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_ConsumeForecastForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_ConsumeForecast_Part...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ConsumeForecast_Part = new SeleniumControl( sDriver, "TableWindow_ConsumeForecast_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_MPSFORECASTSOLN_HDR_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_ConsumeForecast_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Forecast");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExist on TableWindow_ConsumeForecast_ForecastFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ConsumeForecast_ForecastFormTable = new SeleniumControl( sDriver, "TableWindow_ConsumeForecast_ForecastFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_MPSFORECASTSOLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_ConsumeForecast_ForecastFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_ConsumeForecast_ForecastForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ConsumeForecast_ForecastForm = new SeleniumControl( sDriver, "TableWindow_ConsumeForecast_ForecastForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_MPSFORECASTSOLN_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_ConsumeForecast_ForecastForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing ClickButton on TableWindow_ConsumeForecast_ForecastForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ConsumeForecast_ForecastForm = new SeleniumControl( sDriver, "TableWindow_ConsumeForecast_ForecastForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_MPSFORECASTSOLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_ConsumeForecast_ForecastForm);
IWebElement formBttn = OEMNTSO2_TableWindow_ConsumeForecast_ForecastForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO2_TableWindow_ConsumeForecast_ForecastForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO2_TableWindow_ConsumeForecast_ForecastForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing VerifyExists on TableWindow_ConsumeForecast_Part...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ConsumeForecast_Part = new SeleniumControl( sDriver, "TableWindow_ConsumeForecast_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_MPSFORECASTSOLN_HDR_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,OEMNTSO2_TableWindow_ConsumeForecast_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on TableWindow_ConsumeForecastForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_TableWindow_ConsumeForecastForm = new SeleniumControl( sDriver, "TableWindow_ConsumeForecastForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_MPSFORECASTSOLN_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_TableWindow_ConsumeForecastForm);
IWebElement formBttn = OEMNTSO2_TableWindow_ConsumeForecastForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEMNTSO2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO2] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMNTSO2_MainForm);
IWebElement formBttn = OEMNTSO2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

