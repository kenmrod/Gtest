 
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
    public class ARMHIST_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounts Receivable Utilities", "xpath","//div[@class='navItem'][.='Accounts Receivable Utilities']").Click();
new SeleniumControl(sDriver,"Manage Accounts Receivable History", "xpath","//div[@class='navItem'][.='Manage Accounts Receivable History']").Click();


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
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ARMHIST_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on CustomerAccount...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_CustomerAccount = new SeleniumControl( sDriver, "CustomerAccount", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,ARMHIST_CustomerAccount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Customer Notes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on CustomerNotesLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_CustomerNotesLink = new SeleniumControl( sDriver, "CustomerNotesLink", "ID", "lnk_3038_ARM_ARHDRHS_HDR");
				Function.AssertEqual(true,ARMHIST_CustomerNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Click on CustomerNotesLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_CustomerNotesLink = new SeleniumControl( sDriver, "CustomerNotesLink", "ID", "lnk_3038_ARM_ARHDRHS_HDR");
				Function.WaitControlDisplayed(ARMHIST_CustomerNotesLink);
ARMHIST_CustomerNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on CustomerNotesForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_CustomerNotesForm = new SeleniumControl( sDriver, "CustomerNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTNOTES_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ARMHIST_CustomerNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on CustomerNotes_CustomerNotes...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_CustomerNotes_CustomerNotes = new SeleniumControl( sDriver, "CustomerNotes_CustomerNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTNOTES_DTL_']/ancestor::form[1]/descendant::*[@id='NOTES_TX']");
				Function.AssertEqual(true,ARMHIST_CustomerNotes_CustomerNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Close on CustomerNotesForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_CustomerNotesForm = new SeleniumControl( sDriver, "CustomerNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTNOTES_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMHIST_CustomerNotesForm);
IWebElement formBttn = ARMHIST_CustomerNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARHDRHS_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMHIST_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARHDRHS_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMHIST_ChildForm);
IWebElement formBttn = ARMHIST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMHIST_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMHIST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARHDRHS_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_ChildFormTab);
IWebElement mTab = ARMHIST_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_Details_InvoiceNumber...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_Details_InvoiceNumber = new SeleniumControl( sDriver, "ChildForm_Details_InvoiceNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARHDRHS_DTL_']/ancestor::form[1]/descendant::*[@id='INVC_ID']");
				Function.AssertEqual(true,ARMHIST_ChildForm_Details_InvoiceNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARHDRHS_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_ChildFormTab);
IWebElement mTab = ARMHIST_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Amount Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_AmountDetails_FuncDiscountAmount...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_AmountDetails_FuncDiscountAmount = new SeleniumControl( sDriver, "ChildForm_AmountDetails_FuncDiscountAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARHDRHS_DTL_']/ancestor::form[1]/descendant::*[@id='DISC_AMT']");
				Function.AssertEqual(true,ARMHIST_ChildForm_AmountDetails_FuncDiscountAmount.Exists());

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
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_ContactsLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_ContactsLink = new SeleniumControl( sDriver, "ChildForm_ContactsLink", "ID", "lnk_2500_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMHIST_ChildForm_ContactsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Click on ChildForm_ContactsLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_ContactsLink = new SeleniumControl( sDriver, "ChildForm_ContactsLink", "ID", "lnk_2500_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_ContactsLink);
ARMHIST_ChildForm_ContactsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExist on ChildForm_ContactsFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_ContactsFormTable = new SeleniumControl( sDriver, "ChildForm_ContactsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTADDRCNTACT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMHIST_ChildForm_ContactsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing ClickButton on ChildForm_ContactsForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_ContactsForm = new SeleniumControl( sDriver, "ChildForm_ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTADDRCNTACT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_ContactsForm);
IWebElement formBttn = ARMHIST_ChildForm_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMHIST_ChildForm_ContactsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMHIST_ChildForm_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_ContactsForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_ContactsForm = new SeleniumControl( sDriver, "ChildForm_ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTADDRCNTACT_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ARMHIST_ChildForm_ContactsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_Contacts_ContactID...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_Contacts_ContactID = new SeleniumControl( sDriver, "ChildForm_Contacts_ContactID", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTADDRCNTACT_DTL_']/ancestor::form[1]/descendant::*[@id='CNTACT_ID']");
				Function.AssertEqual(true,ARMHIST_ChildForm_Contacts_ContactID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Close on ChildForm_ContactsForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_ContactsForm = new SeleniumControl( sDriver, "ChildForm_ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTADDRCNTACT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_ContactsForm);
IWebElement formBttn = ARMHIST_ChildForm_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_2508_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMHIST_ChildForm_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Click on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_2508_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_ExchangeRatesLink);
ARMHIST_ChildForm_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_ExchangeRatesForm = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,ARMHIST_ChildForm_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ChildForm_ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,ARMHIST_ChildForm_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Close on ChildForm_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_ExchangeRatesForm = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_ExchangeRatesForm);
IWebElement formBttn = ARMHIST_ChildForm_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Invoice Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_InvoiceDetailLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_InvoiceDetailLink = new SeleniumControl( sDriver, "ChildForm_InvoiceDetailLink", "ID", "lnk_3005_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMHIST_ChildForm_InvoiceDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Click on ChildForm_InvoiceDetailLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_InvoiceDetailLink = new SeleniumControl( sDriver, "ChildForm_InvoiceDetailLink", "ID", "lnk_3005_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_InvoiceDetailLink);
ARMHIST_ChildForm_InvoiceDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExist on ChildForm_InvoiceDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_InvoiceDetailFormTable = new SeleniumControl( sDriver, "ChildForm_InvoiceDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARDETLHS_INVCDTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMHIST_ChildForm_InvoiceDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing ClickButton on ChildForm_InvoiceDetailForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_InvoiceDetailForm = new SeleniumControl( sDriver, "ChildForm_InvoiceDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARDETLHS_INVCDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_InvoiceDetailForm);
IWebElement formBttn = ARMHIST_ChildForm_InvoiceDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMHIST_ChildForm_InvoiceDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMHIST_ChildForm_InvoiceDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_InvoiceDetailForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_InvoiceDetailForm = new SeleniumControl( sDriver, "ChildForm_InvoiceDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARDETLHS_INVCDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ARMHIST_ChildForm_InvoiceDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_InvoiceDetail_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_InvoiceDetail_FiscalYear = new SeleniumControl( sDriver, "ChildForm_InvoiceDetail_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARDETLHS_INVCDTL_']/ancestor::form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,ARMHIST_ChildForm_InvoiceDetail_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Close on ChildForm_InvoiceDetailForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_InvoiceDetailForm = new SeleniumControl( sDriver, "ChildForm_InvoiceDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARDETLHS_INVCDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_InvoiceDetailForm);
IWebElement formBttn = ARMHIST_ChildForm_InvoiceDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Invoice Notes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_InvoiceNotesLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_InvoiceNotesLink = new SeleniumControl( sDriver, "ChildForm_InvoiceNotesLink", "ID", "lnk_2513_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMHIST_ChildForm_InvoiceNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Click on ChildForm_InvoiceNotesLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_InvoiceNotesLink = new SeleniumControl( sDriver, "ChildForm_InvoiceNotesLink", "ID", "lnk_2513_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_InvoiceNotesLink);
ARMHIST_ChildForm_InvoiceNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExist on ChildForm_InvoiceNotesFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_InvoiceNotesFormTable = new SeleniumControl( sDriver, "ChildForm_InvoiceNotesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARNOTESHS_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMHIST_ChildForm_InvoiceNotesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Close on ChildForm_InvoiceNotesForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_InvoiceNotesForm = new SeleniumControl( sDriver, "ChildForm_InvoiceNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARNOTESHS_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_InvoiceNotesForm);
IWebElement formBttn = ARMHIST_ChildForm_InvoiceNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Sales Tax");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_SalesTaxLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_SalesTaxLink = new SeleniumControl( sDriver, "ChildForm_SalesTaxLink", "ID", "lnk_2514_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMHIST_ChildForm_SalesTaxLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Click on ChildForm_SalesTaxLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_SalesTaxLink = new SeleniumControl( sDriver, "ChildForm_SalesTaxLink", "ID", "lnk_2514_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_SalesTaxLink);
ARMHIST_ChildForm_SalesTaxLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExist on ChildForm_SalesTaxFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_SalesTaxFormTable = new SeleniumControl( sDriver, "ChildForm_SalesTaxFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARSALESTAX_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMHIST_ChildForm_SalesTaxFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Close on ChildForm_SalesTaxForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_SalesTaxForm = new SeleniumControl( sDriver, "ChildForm_SalesTaxForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARSALESTAX_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_SalesTaxForm);
IWebElement formBttn = ARMHIST_ChildForm_SalesTaxForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Finance Charges Computed");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_FinanceChargesComputedLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesComputedLink = new SeleniumControl( sDriver, "ChildForm_FinanceChargesComputedLink", "ID", "lnk_3297_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMHIST_ChildForm_FinanceChargesComputedLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Click on ChildForm_FinanceChargesComputedLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesComputedLink = new SeleniumControl( sDriver, "ChildForm_FinanceChargesComputedLink", "ID", "lnk_3297_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_FinanceChargesComputedLink);
ARMHIST_ChildForm_FinanceChargesComputedLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExist on ChildForm_FinanceChargesComputedFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesComputedFormTable = new SeleniumControl( sDriver, "ChildForm_FinanceChargesComputedFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_COMPUTED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMHIST_ChildForm_FinanceChargesComputedFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing ClickButton on ChildForm_FinanceChargesComputedForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesComputedForm = new SeleniumControl( sDriver, "ChildForm_FinanceChargesComputedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_COMPUTED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_FinanceChargesComputedForm);
IWebElement formBttn = ARMHIST_ChildForm_FinanceChargesComputedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMHIST_ChildForm_FinanceChargesComputedForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMHIST_ChildForm_FinanceChargesComputedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_FinanceChargesComputedForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesComputedForm = new SeleniumControl( sDriver, "ChildForm_FinanceChargesComputedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_COMPUTED_']/ancestor::form[1]");
				Function.AssertEqual(true,ARMHIST_ChildForm_FinanceChargesComputedForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_FinanceChargesComputed_FinanceChargeAmount...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesComputed_FinanceChargeAmount = new SeleniumControl( sDriver, "ChildForm_FinanceChargesComputed_FinanceChargeAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_COMPUTED_']/ancestor::form[1]/descendant::*[@id='TRN_FINCHG_NET_AMT']");
				Function.AssertEqual(true,ARMHIST_ChildForm_FinanceChargesComputed_FinanceChargeAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Close on ChildForm_FinanceChargesComputedForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesComputedForm = new SeleniumControl( sDriver, "ChildForm_FinanceChargesComputedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_COMPUTED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_FinanceChargesComputedForm);
IWebElement formBttn = ARMHIST_ChildForm_FinanceChargesComputedForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Finance Charges Received");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_FinanceChargesReceivedLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesReceivedLink = new SeleniumControl( sDriver, "ChildForm_FinanceChargesReceivedLink", "ID", "lnk_3298_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMHIST_ChildForm_FinanceChargesReceivedLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Click on ChildForm_FinanceChargesReceivedLink...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesReceivedLink = new SeleniumControl( sDriver, "ChildForm_FinanceChargesReceivedLink", "ID", "lnk_3298_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_FinanceChargesReceivedLink);
ARMHIST_ChildForm_FinanceChargesReceivedLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExist on ChildForm_FinanceChargesReceivedFormTable...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesReceivedFormTable = new SeleniumControl( sDriver, "ChildForm_FinanceChargesReceivedFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_RECEIVED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMHIST_ChildForm_FinanceChargesReceivedFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing ClickButton on ChildForm_FinanceChargesReceivedForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesReceivedForm = new SeleniumControl( sDriver, "ChildForm_FinanceChargesReceivedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_RECEIVED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_FinanceChargesReceivedForm);
IWebElement formBttn = ARMHIST_ChildForm_FinanceChargesReceivedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMHIST_ChildForm_FinanceChargesReceivedForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMHIST_ChildForm_FinanceChargesReceivedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_FinanceChargesReceivedForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesReceivedForm = new SeleniumControl( sDriver, "ChildForm_FinanceChargesReceivedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_RECEIVED_']/ancestor::form[1]");
				Function.AssertEqual(true,ARMHIST_ChildForm_FinanceChargesReceivedForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing VerifyExists on ChildForm_FinanceChargesReceived_FinanceChargeAmount...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesReceived_FinanceChargeAmount = new SeleniumControl( sDriver, "ChildForm_FinanceChargesReceived_FinanceChargeAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_RECEIVED_']/ancestor::form[1]/descendant::*[@id='TRN_FINCHG_RCV_AMT']");
				Function.AssertEqual(true,ARMHIST_ChildForm_FinanceChargesReceived_FinanceChargeAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Close on ChildForm_FinanceChargesReceivedForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_ChildForm_FinanceChargesReceivedForm = new SeleniumControl( sDriver, "ChildForm_FinanceChargesReceivedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_RECEIVED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMHIST_ChildForm_FinanceChargesReceivedForm);
IWebElement formBttn = ARMHIST_ChildForm_FinanceChargesReceivedForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ARMHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMHIST] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARMHIST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ARMHIST_MainForm);
IWebElement formBttn = ARMHIST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

