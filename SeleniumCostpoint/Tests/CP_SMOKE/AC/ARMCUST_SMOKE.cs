 
using System;
using System.Threading.Tasks;
using SeleniumCostpoint.Common;
using System.Collections.Generic;
using Core.Sys;
using Core.Sys.Selenium;
using System.Threading;
using System.Linq;
using OpenQA.Selenium;

namespace SeleniumCostpoint.Tests.CP_SMOKE.AC
{
    public class ARMCUST_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Customers", "xpath","//div[@class='navItem'][.='Customers']").Click();
new SeleniumControl(sDriver,"Manage Customers", "xpath","//div[@class='navItem'][.='Manage Customers']").Click();


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
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ARMCUST_MainForm);
IWebElement formBttn = ARMCUST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? ARMCUST_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
ARMCUST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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

				this.ScriptLogger.WriteLine("[Query] Performing Set on Find_CriteriaValue1...", Logger.MessageType.INF);
				SeleniumControl Query_Find_CriteriaValue1 = new SeleniumControl( sDriver, "Find_CriteriaValue1", "ID", "basicField0");
				Query_Find_CriteriaValue1.Click();
Query_Find_CriteriaValue1.SendKeys("4", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Query_Find_CriteriaValue1.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
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
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMCUST_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ARMCUST_MainForm);
IWebElement formBttn = ARMCUST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMCUST_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMCUST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExists on Customer_CustomerAccount...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Customer_CustomerAccount = new SeleniumControl( sDriver, "Customer_CustomerAccount", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,ARMCUST_Customer_CustomerAccount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ARMCUST_MainFormTab);
IWebElement mTab = ARMCUST_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Customer Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExists on Customer_CustomerDetails_Vendor...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Customer_CustomerDetails_Vendor = new SeleniumControl( sDriver, "Customer_CustomerDetails_Vendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,ARMCUST_Customer_CustomerDetails_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ARMCUST_MainFormTab);
IWebElement mTab = ARMCUST_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Credit Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExists on Customer_CreditInfo_CreditInformation_ApplyFinanceCharges...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Customer_CreditInfo_CreditInformation_ApplyFinanceCharges = new SeleniumControl( sDriver, "Customer_CreditInfo_CreditInformation_ApplyFinanceCharges", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='APPLY_FIN_CHG_FL']");
				Function.AssertEqual(true,ARMCUST_Customer_CreditInfo_CreditInformation_ApplyFinanceCharges.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ARMCUST_MainFormTab);
IWebElement mTab = ARMCUST_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Sales Order").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExists on Customer_SalesOrder_Pricing_Project...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Customer_SalesOrder_Pricing_Project = new SeleniumControl( sDriver, "Customer_SalesOrder_Pricing_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PRICE_PROJ_ID']");
				Function.AssertEqual(true,ARMCUST_Customer_SalesOrder_Pricing_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ARMCUST_MainFormTab);
IWebElement mTab = ARMCUST_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "SO Address/Contacts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExists on Customer_SOAddressContacts_SalesContactInformation_LastName...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Customer_SOAddressContacts_SalesContactInformation_LastName = new SeleniumControl( sDriver, "Customer_SOAddressContacts_SalesContactInformation_LastName", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SLS_CNT_LAST_NAME']");
				Function.AssertEqual(true,ARMCUST_Customer_SOAddressContacts_SalesContactInformation_LastName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Default Accts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Click on Customer_DefaultAcctsLink...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Customer_DefaultAcctsLink = new SeleniumControl( sDriver, "Customer_DefaultAcctsLink", "ID", "lnk_1002896_CPMCUST_CUST_HDR");
				Function.WaitControlDisplayed(ARMCUST_Customer_DefaultAcctsLink);
ARMCUST_Customer_DefaultAcctsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExist on DefaultAcctsTable...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_DefaultAcctsTable = new SeleniumControl( sDriver, "DefaultAcctsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTDFLTACCT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMCUST_DefaultAcctsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing ClickButton on DefaultAcctsForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_DefaultAcctsForm = new SeleniumControl( sDriver, "DefaultAcctsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTDFLTACCT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCUST_DefaultAcctsForm);
IWebElement formBttn = ARMCUST_DefaultAcctsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMCUST_DefaultAcctsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMCUST_DefaultAcctsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExists on DefaultAccts_TransactionType...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_DefaultAccts_TransactionType = new SeleniumControl( sDriver, "DefaultAccts_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTDFLTACCT_CTW_']/ancestor::form[1]/descendant::*[@id='CUSTTRNTYPE_DESC']");
				Function.AssertEqual(true,ARMCUST_DefaultAccts_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Close on DefaultAcctsForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_DefaultAcctsForm = new SeleniumControl( sDriver, "DefaultAcctsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTDFLTACCT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCUST_DefaultAcctsForm);
IWebElement formBttn = ARMCUST_DefaultAcctsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Notes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Click on Customer_NotesLink...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Customer_NotesLink = new SeleniumControl( sDriver, "Customer_NotesLink", "ID", "lnk_1002897_CPMCUST_CUST_HDR");
				Function.WaitControlDisplayed(ARMCUST_Customer_NotesLink);
ARMCUST_Customer_NotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExists on Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Notes_Notes = new SeleniumControl( sDriver, "Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTNOTES_CTW_']/ancestor::form[1]/descendant::*[@id='NOTES_TX']");
				Function.AssertEqual(true,ARMCUST_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Close on NotesForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_NotesForm = new SeleniumControl( sDriver, "NotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTNOTES_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCUST_NotesForm);
IWebElement formBttn = ARMCUST_NotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Multicurrency");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Click on Customer_MulticurrencyLink...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Customer_MulticurrencyLink = new SeleniumControl( sDriver, "Customer_MulticurrencyLink", "ID", "lnk_1002898_CPMCUST_CUST_HDR");
				Function.WaitControlDisplayed(ARMCUST_Customer_MulticurrencyLink);
ARMCUST_Customer_MulticurrencyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExists on Multicurrency_RateGroup...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Multicurrency_RateGroup = new SeleniumControl( sDriver, "Multicurrency_RateGroup", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_DEFCURR_CTW_']/ancestor::form[1]/descendant::*[@id='DFLT_RT_GRP_ID']");
				Function.AssertEqual(true,ARMCUST_Multicurrency_RateGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExist on Multicurrency_TransactionCurrenciesTable...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Multicurrency_TransactionCurrenciesTable = new SeleniumControl( sDriver, "Multicurrency_TransactionCurrenciesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_TRANSCURR_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMCUST_Multicurrency_TransactionCurrenciesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExist on Multicurrency_PayCurrenciesTable...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Multicurrency_PayCurrenciesTable = new SeleniumControl( sDriver, "Multicurrency_PayCurrenciesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_PAYCURR_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMCUST_Multicurrency_PayCurrenciesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Close on MulticurrencyForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_MulticurrencyForm = new SeleniumControl( sDriver, "MulticurrencyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_DEFCURR_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCUST_MulticurrencyForm);
IWebElement formBttn = ARMCUST_MulticurrencyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("VAT Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Click on Customer_VATInfoLink...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Customer_VATInfoLink = new SeleniumControl( sDriver, "Customer_VATInfoLink", "ID", "lnk_1002902_CPMCUST_CUST_HDR");
				Function.WaitControlDisplayed(ARMCUST_Customer_VATInfoLink);
ARMCUST_Customer_VATInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExist on VATInfoTable...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_VATInfoTable = new SeleniumControl( sDriver, "VATInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTVATINFO_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMCUST_VATInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Close on VATInfoForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_VATInfoForm = new SeleniumControl( sDriver, "VATInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTVATINFO_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCUST_VATInfoForm);
IWebElement formBttn = ARMCUST_VATInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("User Defined");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Click on Customer_UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Customer_UserDefinedInfoLink = new SeleniumControl( sDriver, "Customer_UserDefinedInfoLink", "ID", "lnk_1007191_CPMCUST_CUST_HDR");
				Function.WaitControlDisplayed(ARMCUST_Customer_UserDefinedInfoLink);
ARMCUST_Customer_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExist on UserDefinedInfoTable...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_UserDefinedInfoTable = new SeleniumControl( sDriver, "UserDefinedInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMCUST_UserDefinedInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing ClickButton on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCUST_UserDefinedInfoForm);
IWebElement formBttn = ARMCUST_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMCUST_UserDefinedInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMCUST_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExists on UserDefinedInfo_DataType...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_UserDefinedInfo_DataType = new SeleniumControl( sDriver, "UserDefinedInfo_DataType", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]/descendant::*[@id='S_DATA_TYPE']");
				Function.AssertEqual(true,ARMCUST_UserDefinedInfo_DataType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Close on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCUST_UserDefinedInfoForm);
IWebElement formBttn = ARMCUST_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Customer Alias");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Click on Customer_CustomerAliasLink...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Customer_CustomerAliasLink = new SeleniumControl( sDriver, "Customer_CustomerAliasLink", "ID", "lnk_3565_CPMCUST_CUST_HDR");
				Function.WaitControlDisplayed(ARMCUST_Customer_CustomerAliasLink);
ARMCUST_Customer_CustomerAliasLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExist on CustomerAliasTable...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_CustomerAliasTable = new SeleniumControl( sDriver, "CustomerAliasTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTALIAS_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMCUST_CustomerAliasTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Close on CustomerAliasForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_CustomerAliasForm = new SeleniumControl( sDriver, "CustomerAliasForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTALIAS_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCUST_CustomerAliasForm);
IWebElement formBttn = ARMCUST_CustomerAliasForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Customer Addrress");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExist on CustomerAddressTable...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_CustomerAddressTable = new SeleniumControl( sDriver, "CustomerAddressTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTADDR_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMCUST_CustomerAddressTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing ClickButton on CustomerAddressForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_CustomerAddressForm = new SeleniumControl( sDriver, "CustomerAddressForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTADDR_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCUST_CustomerAddressForm);
IWebElement formBttn = ARMCUST_CustomerAddressForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMCUST_CustomerAddressForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMCUST_CustomerAddressForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExists on CustomerAddress_AddressCode...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_CustomerAddress_AddressCode = new SeleniumControl( sDriver, "CustomerAddress_AddressCode", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTADDR_CTW_']/ancestor::form[1]/descendant::*[@id='ADDR_DC']");
				Function.AssertEqual(true,ARMCUST_CustomerAddress_AddressCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Contacts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Click on CustomerAddress_ContactsLink...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_CustomerAddress_ContactsLink = new SeleniumControl( sDriver, "CustomerAddress_ContactsLink", "ID", "lnk_1002906_CPMCUST_CUSTADDR_CTW");
				Function.WaitControlDisplayed(ARMCUST_CustomerAddress_ContactsLink);
ARMCUST_CustomerAddress_ContactsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExist on ContactsTable...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_ContactsTable = new SeleniumControl( sDriver, "ContactsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTADDRCNTACT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMCUST_ContactsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing ClickButton on ContactsForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_ContactsForm = new SeleniumControl( sDriver, "ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTADDRCNTACT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCUST_ContactsForm);
IWebElement formBttn = ARMCUST_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMCUST_ContactsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMCUST_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing VerifyExists on Contacts_ContactID...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_Contacts_ContactID = new SeleniumControl( sDriver, "Contacts_ContactID", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTADDRCNTACT_CTW_']/ancestor::form[1]/descendant::*[@id='CNTACT_ID']");
				Function.AssertEqual(true,ARMCUST_Contacts_ContactID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Close on ContactsForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_ContactsForm = new SeleniumControl( sDriver, "ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMCUST_CUSTADDRCNTACT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMCUST_ContactsForm);
IWebElement formBttn = ARMCUST_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "ARMCUST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMCUST] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARMCUST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ARMCUST_MainForm);
IWebElement formBttn = ARMCUST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

