 
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
    public class OEMAPPSO_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Approve Sales Orders", "xpath","//div[@class='navItem'][.='Approve Sales Orders']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
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
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_MainForm);
IWebElement formBttn = OEMAPPSO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMAPPSO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMAPPSO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on MainForm_Identification_SO...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm_Identification_SO = new SeleniumControl( sDriver, "MainForm_Identification_SO", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SO_ID']");
				Function.AssertEqual(true,OEMAPPSO_MainForm_Identification_SO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEMAPPSO_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_MainForm);
IWebElement formBttn = OEMAPPSO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEMAPPSO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEMAPPSO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPSO_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ApprovalProcessLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on MainForm_ApprovalProcessLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm_ApprovalProcessLink = new SeleniumControl( sDriver, "MainForm_ApprovalProcessLink", "ID", "lnk_1003221_OEMAPPSO_SOHDRAPPRVL_HEADER");
				Function.AssertEqual(true,OEMAPPSO_MainForm_ApprovalProcessLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Click on MainForm_ApprovalProcessLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm_ApprovalProcessLink = new SeleniumControl( sDriver, "MainForm_ApprovalProcessLink", "ID", "lnk_1003221_OEMAPPSO_SOHDRAPPRVL_HEADER");
				Function.WaitControlDisplayed(OEMAPPSO_MainForm_ApprovalProcessLink);
OEMAPPSO_MainForm_ApprovalProcessLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExist on ApprovalProcessFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ApprovalProcessFormTable = new SeleniumControl( sDriver, "ApprovalProcessFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPSO_ApprovalProcessFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ApprovalProcessForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ApprovalProcessForm = new SeleniumControl( sDriver, "ApprovalProcessForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_ApprovalProcessForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing ClickButton on ApprovalProcessForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ApprovalProcessForm = new SeleniumControl( sDriver, "ApprovalProcessForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_ApprovalProcessForm);
IWebElement formBttn = OEMAPPSO_ApprovalProcessForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMAPPSO_ApprovalProcessForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMAPPSO_ApprovalProcessForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ApprovalProcess_Seq...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ApprovalProcess_Seq = new SeleniumControl( sDriver, "ApprovalProcess_Seq", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_HDR_']/ancestor::form[1]/descendant::*[@id='APPRVL_SEQ_NO']");
				Function.AssertEqual(true,OEMAPPSO_ApprovalProcess_Seq.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on ApprovalProcessForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ApprovalProcessForm = new SeleniumControl( sDriver, "ApprovalProcessForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_ApprovalProcessForm);
IWebElement formBttn = OEMAPPSO_ApprovalProcessForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on MainForm_TotalsLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm_TotalsLink = new SeleniumControl( sDriver, "MainForm_TotalsLink", "ID", "lnk_1003227_OEMAPPSO_SOHDRAPPRVL_HEADER");
				Function.AssertEqual(true,OEMAPPSO_MainForm_TotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Click on MainForm_TotalsLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm_TotalsLink = new SeleniumControl( sDriver, "MainForm_TotalsLink", "ID", "lnk_1003227_OEMAPPSO_SOHDRAPPRVL_HEADER");
				Function.WaitControlDisplayed(OEMAPPSO_MainForm_TotalsLink);
OEMAPPSO_MainForm_TotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SQ_TOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_TotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on Totals_Currency...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_Totals_Currency = new SeleniumControl( sDriver, "Totals_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SQ_TOTALS_']/ancestor::form[1]/descendant::*[@id='TRANS_CURR_CODE']");
				Function.AssertEqual(true,OEMAPPSO_Totals_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SQ_TOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_TotalsForm);
IWebElement formBttn = OEMAPPSO_TotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on MainForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm_ExchangeRatesLink = new SeleniumControl( sDriver, "MainForm_ExchangeRatesLink", "ID", "lnk_1003807_OEMAPPSO_SOHDRAPPRVL_HEADER");
				Function.AssertEqual(true,OEMAPPSO_MainForm_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Click on MainForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm_ExchangeRatesLink = new SeleniumControl( sDriver, "MainForm_ExchangeRatesLink", "ID", "lnk_1003807_OEMAPPSO_SOHDRAPPRVL_HEADER");
				Function.WaitControlDisplayed(OEMAPPSO_MainForm_ExchangeRatesLink);
OEMAPPSO_MainForm_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,OEMAPPSO_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_ExchangeRatesForm);
IWebElement formBttn = OEMAPPSO_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SODetailsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on MainForm_SODetailsLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm_SODetailsLink = new SeleniumControl( sDriver, "MainForm_SODetailsLink", "ID", "lnk_1003688_OEMAPPSO_SOHDRAPPRVL_HEADER");
				Function.AssertEqual(true,OEMAPPSO_MainForm_SODetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Click on MainForm_SODetailsLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm_SODetailsLink = new SeleniumControl( sDriver, "MainForm_SODetailsLink", "ID", "lnk_1003688_OEMAPPSO_SOHDRAPPRVL_HEADER");
				Function.WaitControlDisplayed(OEMAPPSO_MainForm_SODetailsLink);
OEMAPPSO_MainForm_SODetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on SODetailsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_SODetailsForm = new SeleniumControl( sDriver, "SODetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_HDRINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_SODetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SODetailsTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Select on SODetailsTab...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_SODetailsTab = new SeleniumControl( sDriver, "SODetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_HDRINFO_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMAPPSO_SODetailsTab);
IWebElement mTab = OEMAPPSO_SODetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Addresses").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on SODetails_Addresses_BillTo...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_SODetails_Addresses_BillTo = new SeleniumControl( sDriver, "SODetails_Addresses_BillTo", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_HDRINFO_']/ancestor::form[1]/descendant::*[@id='BILL_TO_ADDR_DC']");
				Function.AssertEqual(true,OEMAPPSO_SODetails_Addresses_BillTo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Select on SODetailsTab...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_SODetailsTab = new SeleniumControl( sDriver, "SODetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_HDRINFO_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMAPPSO_SODetailsTab);
IWebElement mTab = OEMAPPSO_SODetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Credit Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on SODetails_CreditInformation_Territory...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_SODetails_CreditInformation_Territory = new SeleniumControl( sDriver, "SODetails_CreditInformation_Territory", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_HDRINFO_']/ancestor::form[1]/descendant::*[@id='SALES_TERR_DC']");
				Function.AssertEqual(true,OEMAPPSO_SODetails_CreditInformation_Territory.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Select on SODetailsTab...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_SODetailsTab = new SeleniumControl( sDriver, "SODetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_HDRINFO_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMAPPSO_SODetailsTab);
IWebElement mTab = OEMAPPSO_SODetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on SODetails_HeaderInformation_CustomerInfo_LastName...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_SODetails_HeaderInformation_CustomerInfo_LastName = new SeleniumControl( sDriver, "SODetails_HeaderInformation_CustomerInfo_LastName", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_HDRINFO_']/ancestor::form[1]/descendant::*[@id='CNTACT_LAST_NAME']");
				Function.AssertEqual(true,OEMAPPSO_SODetails_HeaderInformation_CustomerInfo_LastName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on SODetailsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_SODetailsForm = new SeleniumControl( sDriver, "SODetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_HDRINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_SODetailsForm);
IWebElement formBttn = OEMAPPSO_SODetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("UDFInfoLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on MainForm_UDFInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm_UDFInfoLink = new SeleniumControl( sDriver, "MainForm_UDFInfoLink", "ID", "lnk_1007520_OEMAPPSO_SOHDRAPPRVL_HEADER");
				Function.AssertEqual(true,OEMAPPSO_MainForm_UDFInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Click on MainForm_UDFInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm_UDFInfoLink = new SeleniumControl( sDriver, "MainForm_UDFInfoLink", "ID", "lnk_1007520_OEMAPPSO_SOHDRAPPRVL_HEADER");
				Function.WaitControlDisplayed(OEMAPPSO_MainForm_UDFInfoLink);
OEMAPPSO_MainForm_UDFInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExist on UDFInfoTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_UDFInfoTable = new SeleniumControl( sDriver, "UDFInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPSO_UDFInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on UDFInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_UDFInfoForm = new SeleniumControl( sDriver, "UDFInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_UDFInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on UDFInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_UDFInfoForm = new SeleniumControl( sDriver, "UDFInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_UDFInfoForm);
IWebElement formBttn = OEMAPPSO_UDFInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SOHeaderDocumentsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on MainForm_SOHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm_SOHeaderDocumentsLink = new SeleniumControl( sDriver, "MainForm_SOHeaderDocumentsLink", "ID", "lnk_1007521_OEMAPPSO_SOHDRAPPRVL_HEADER");
				Function.AssertEqual(true,OEMAPPSO_MainForm_SOHeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Click on MainForm_SOHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm_SOHeaderDocumentsLink = new SeleniumControl( sDriver, "MainForm_SOHeaderDocumentsLink", "ID", "lnk_1007521_OEMAPPSO_SOHDRAPPRVL_HEADER");
				Function.WaitControlDisplayed(OEMAPPSO_MainForm_SOHeaderDocumentsLink);
OEMAPPSO_MainForm_SOHeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExist on SOHeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_SOHeaderDocumentsTable = new SeleniumControl( sDriver, "SOHeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPSO_SOHeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_SOHeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing ClickButton on SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_SOHeaderDocumentsForm);
IWebElement formBttn = OEMAPPSO_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMAPPSO_SOHeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMAPPSO_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on SOHeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_SOHeaderDocuments_Document = new SeleniumControl( sDriver, "SOHeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,OEMAPPSO_SOHeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_SOHeaderDocumentsForm);
IWebElement formBttn = OEMAPPSO_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Approval Sales Order Details Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPSO_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_ChildForm);
IWebElement formBttn = OEMAPPSO_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMAPPSO_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMAPPSO_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Approval Sales Order Details Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMAPPSO_ChildFormTab);
IWebElement mTab = OEMAPPSO_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Item Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm_ItemDetails_SOLine...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_ItemDetails_SOLine = new SeleniumControl( sDriver, "ChildForm_ItemDetails_SOLine", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]/descendant::*[@id='SO_LN_NO']");
				Function.AssertEqual(true,OEMAPPSO_ChildForm_ItemDetails_SOLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMAPPSO_ChildFormTab);
IWebElement mTab = OEMAPPSO_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Inventory").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm_Inventory_WAREHOUSEM...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_Inventory_WAREHOUSEM = new SeleniumControl( sDriver, "ChildForm_Inventory_WAREHOUSEM", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,OEMAPPSO_ChildForm_Inventory_WAREHOUSEM.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMAPPSO_ChildFormTab);
IWebElement mTab = OEMAPPSO_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Price Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm_PriceDetails_GrossUnitPrice...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_PriceDetails_GrossUnitPrice = new SeleniumControl( sDriver, "ChildForm_PriceDetails_GrossUnitPrice", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]/descendant::*[@id='TRN_GR_UNIT_PR_AMT']");
				Function.AssertEqual(true,OEMAPPSO_ChildForm_PriceDetails_GrossUnitPrice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMAPPSO_ChildFormTab);
IWebElement mTab = OEMAPPSO_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shipping").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm_Shipping_ShipID...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_Shipping_ShipID = new SeleniumControl( sDriver, "ChildForm_Shipping_ShipID", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]/descendant::*[@id='SHIP_ID']");
				Function.AssertEqual(true,OEMAPPSO_ChildForm_Shipping_ShipID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMAPPSO_ChildFormTab);
IWebElement mTab = OEMAPPSO_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Billing").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm_Billing_InstallmentBill...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_Billing_InstallmentBill = new SeleniumControl( sDriver, "ChildForm_Billing_InstallmentBill", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]/descendant::*[@id='INSTALL_BILL_FL']");
				Function.AssertEqual(true,OEMAPPSO_ChildForm_Billing_InstallmentBill.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMAPPSO_ChildFormTab);
IWebElement mTab = OEMAPPSO_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm_OtherInfo_NumberOfUsers...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_OtherInfo_NumberOfUsers = new SeleniumControl( sDriver, "ChildForm_OtherInfo_NumberOfUsers", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_DETAIL_']/ancestor::form[1]/descendant::*[@id='USERS_NO']");
				Function.AssertEqual(true,OEMAPPSO_ChildForm_OtherInfo_NumberOfUsers.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_AccountsLink = new SeleniumControl( sDriver, "ChildForm_AccountsLink", "ID", "lnk_1002949_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.AssertEqual(true,OEMAPPSO_ChildForm_AccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Click on ChildForm_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_AccountsLink = new SeleniumControl( sDriver, "ChildForm_AccountsLink", "ID", "lnk_1002949_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.WaitControlDisplayed(OEMAPPSO_ChildForm_AccountsLink);
OEMAPPSO_ChildForm_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExist on AccountsTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_AccountsTable = new SeleniumControl( sDriver, "AccountsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SALESGROUPACCTS_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPSO_AccountsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SALESGROUPACCTS_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_AccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing ClickButton on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SALESGROUPACCTS_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_AccountsForm);
IWebElement formBttn = OEMAPPSO_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMAPPSO_AccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMAPPSO_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on Accounts_TransactionDesc...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_Accounts_TransactionDesc = new SeleniumControl( sDriver, "Accounts_TransactionDesc", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SALESGROUPACCTS_DTL_']/ancestor::form[1]/descendant::*[@id='PROD_TRN_TYPE_DESC']");
				Function.AssertEqual(true,OEMAPPSO_Accounts_TransactionDesc.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SALESGROUPACCTS_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_AccountsForm);
IWebElement formBttn = OEMAPPSO_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm_ComponentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_ComponentsLink = new SeleniumControl( sDriver, "ChildForm_ComponentsLink", "ID", "lnk_1002980_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.AssertEqual(true,OEMAPPSO_ChildForm_ComponentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Click on ChildForm_ComponentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_ComponentsLink = new SeleniumControl( sDriver, "ChildForm_ComponentsLink", "ID", "lnk_1002980_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.WaitControlDisplayed(OEMAPPSO_ChildForm_ComponentsLink);
OEMAPPSO_ChildForm_ComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExist on ComponentsTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ComponentsTable = new SeleniumControl( sDriver, "ComponentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOLNCOMP_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPSO_ComponentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ComponentsForm = new SeleniumControl( sDriver, "ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOLNCOMP_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_ComponentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing ClickButton on ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ComponentsForm = new SeleniumControl( sDriver, "ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOLNCOMP_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_ComponentsForm);
IWebElement formBttn = OEMAPPSO_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMAPPSO_ComponentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMAPPSO_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on Components_Line...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_Components_Line = new SeleniumControl( sDriver, "Components_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOLNCOMP_DTL_']/ancestor::form[1]/descendant::*[@id='SO_LN_COMP_NO']");
				Function.AssertEqual(true,OEMAPPSO_Components_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ComponentsForm = new SeleniumControl( sDriver, "ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOLNCOMP_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_ComponentsForm);
IWebElement formBttn = OEMAPPSO_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1003016_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.AssertEqual(true,OEMAPPSO_ChildForm_LineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Click on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1003016_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.WaitControlDisplayed(OEMAPPSO_ChildForm_LineChargesLink);
OEMAPPSO_ChildForm_LineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExist on LineChargesTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_LineChargesTable = new SeleniumControl( sDriver, "LineChargesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOLNCHG_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPSO_LineChargesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOLNCHG_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_LineChargesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing ClickButton on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOLNCHG_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_LineChargesForm);
IWebElement formBttn = OEMAPPSO_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMAPPSO_LineChargesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMAPPSO_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on LineCharges_ChargeType...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_LineCharges_ChargeType = new SeleniumControl( sDriver, "LineCharges_ChargeType", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOLNCHG_DTL_']/ancestor::form[1]/descendant::*[@id='LN_CHG_TYPE']");
				Function.AssertEqual(true,OEMAPPSO_LineCharges_ChargeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOLNCHG_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_LineChargesForm);
IWebElement formBttn = OEMAPPSO_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CurrencyLine Information Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm_CurrencyLineInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_CurrencyLineInformationLink = new SeleniumControl( sDriver, "ChildForm_CurrencyLineInformationLink", "ID", "lnk_1003636_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.AssertEqual(true,OEMAPPSO_ChildForm_CurrencyLineInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Click on ChildForm_CurrencyLineInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_CurrencyLineInformationLink = new SeleniumControl( sDriver, "ChildForm_CurrencyLineInformationLink", "ID", "lnk_1003636_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.WaitControlDisplayed(OEMAPPSO_ChildForm_CurrencyLineInformationLink);
OEMAPPSO_ChildForm_CurrencyLineInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on CurrencyLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_CurrencyLineInformationForm = new SeleniumControl( sDriver, "CurrencyLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_CurrencyLineInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on CurrencyLineInformation_LineAmounts_Currency...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_CurrencyLineInformation_LineAmounts_Currency = new SeleniumControl( sDriver, "CurrencyLineInformation_LineAmounts_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]/descendant::*[@id='TRANS_CURR_CODE']");
				Function.AssertEqual(true,OEMAPPSO_CurrencyLineInformation_LineAmounts_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on CurrencyLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_CurrencyLineInformationForm = new SeleniumControl( sDriver, "CurrencyLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_CurrencyLineInformationForm);
IWebElement formBttn = OEMAPPSO_CurrencyLineInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Customs Information Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm_CustomsInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_CustomsInformationLink = new SeleniumControl( sDriver, "ChildForm_CustomsInformationLink", "ID", "lnk_1003689_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.AssertEqual(true,OEMAPPSO_ChildForm_CustomsInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Click on ChildForm_CustomsInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_CustomsInformationLink = new SeleniumControl( sDriver, "ChildForm_CustomsInformationLink", "ID", "lnk_1003689_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.WaitControlDisplayed(OEMAPPSO_ChildForm_CustomsInformationLink);
OEMAPPSO_ChildForm_CustomsInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on CustomsInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_CustomsInformationForm = new SeleniumControl( sDriver, "CustomsInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_CUSTLNDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_CustomsInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on CustomsInformation_ValueAddedTaxInfo_TaxID...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_CustomsInformation_ValueAddedTaxInfo_TaxID = new SeleniumControl( sDriver, "CustomsInformation_ValueAddedTaxInfo_TaxID", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_CUSTLNDTL_']/ancestor::form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,OEMAPPSO_CustomsInformation_ValueAddedTaxInfo_TaxID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on CustomsInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_CustomsInformationForm = new SeleniumControl( sDriver, "CustomsInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_SOHDRAPPRVL_CUSTLNDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_CustomsInformationForm);
IWebElement formBttn = OEMAPPSO_CustomsInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007702_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.AssertEqual(true,OEMAPPSO_ChildForm_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Click on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007702_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.WaitControlDisplayed(OEMAPPSO_ChildForm_LineDocumentsLink);
OEMAPPSO_ChildForm_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExist on LineDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_LineDocumentsTable = new SeleniumControl( sDriver, "LineDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPSO_LineDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing ClickButton on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_LineDocumentsForm);
IWebElement formBttn = OEMAPPSO_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMAPPSO_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMAPPSO_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_LineDocuments_Document = new SeleniumControl( sDriver, "LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,OEMAPPSO_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_LineDocumentsForm);
IWebElement formBttn = OEMAPPSO_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Consume Forecast Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ChildForm_ConsumeForecastLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_ConsumeForecastLink = new SeleniumControl( sDriver, "ChildForm_ConsumeForecastLink", "ID", "lnk_1007816_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.AssertEqual(true,OEMAPPSO_ChildForm_ConsumeForecastLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Click on ChildForm_ConsumeForecastLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ChildForm_ConsumeForecastLink = new SeleniumControl( sDriver, "ChildForm_ConsumeForecastLink", "ID", "lnk_1007816_OEMAPPSO_SOHDRAPPRVL_DETAIL");
				Function.WaitControlDisplayed(OEMAPPSO_ChildForm_ConsumeForecastLink);
OEMAPPSO_ChildForm_ConsumeForecastLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ConsumeForcastForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ConsumeForcastForm = new SeleniumControl( sDriver, "ConsumeForcastForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_MPSFORECASTSOLN_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_ConsumeForcastForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ConsumeForecast_Part...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ConsumeForecast_Part = new SeleniumControl( sDriver, "ConsumeForecast_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_MPSFORECASTSOLN_HDR_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,OEMAPPSO_ConsumeForecast_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Forecasts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExist on ForecastsTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ForecastsTable = new SeleniumControl( sDriver, "ForecastsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_MPSFORECASTSOLN_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPSO_ForecastsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on ForcastsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ForcastsForm = new SeleniumControl( sDriver, "ForcastsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_MPSFORECASTSOLN_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPSO_ForcastsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing ClickButton on ForcastsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ForcastsForm = new SeleniumControl( sDriver, "ForcastsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_MPSFORECASTSOLN_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_ForcastsForm);
IWebElement formBttn = OEMAPPSO_ForcastsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMAPPSO_ForcastsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMAPPSO_ForcastsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing VerifyExists on Forecasts_ForecastPart...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_Forecasts_ForecastPart = new SeleniumControl( sDriver, "Forecasts_ForecastPart", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_MPSFORECASTSOLN_DTL_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,OEMAPPSO_Forecasts_ForecastPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on ConsumeForcastForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_ConsumeForcastForm = new SeleniumControl( sDriver, "ConsumeForcastForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPSO_MPSFORECASTSOLN_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_ConsumeForcastForm);
IWebElement formBttn = OEMAPPSO_ConsumeForcastForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEMAPPSO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPSO] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPSO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMAPPSO_MainForm);
IWebElement formBttn = OEMAPPSO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

