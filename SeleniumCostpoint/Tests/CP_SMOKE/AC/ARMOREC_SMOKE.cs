 
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
    public class ARMOREC_SMOKE : SeleniumTestScript
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
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ARMOREC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on MainForm_CustomerAccount...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_MainForm_CustomerAccount = new SeleniumControl( sDriver, "MainForm_CustomerAccount", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,ARMOREC_MainForm_CustomerAccount.Exists());

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
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on MainForm_CustomerNotesLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_MainForm_CustomerNotesLink = new SeleniumControl( sDriver, "MainForm_CustomerNotesLink", "ID", "lnk_3038_ARM_ARHDRHS_HDR");
				Function.AssertEqual(true,ARMOREC_MainForm_CustomerNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Click on MainForm_CustomerNotesLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_MainForm_CustomerNotesLink = new SeleniumControl( sDriver, "MainForm_CustomerNotesLink", "ID", "lnk_3038_ARM_ARHDRHS_HDR");
				Function.WaitControlDisplayed(ARMOREC_MainForm_CustomerNotesLink);
ARMOREC_MainForm_CustomerNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on CustomerNotesForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_CustomerNotesForm = new SeleniumControl( sDriver, "CustomerNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTNOTES_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ARMOREC_CustomerNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on CustomerNotes_NotesTextarea...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_CustomerNotes_NotesTextarea = new SeleniumControl( sDriver, "CustomerNotes_NotesTextarea", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTNOTES_DTL_']/ancestor::form[1]/descendant::*[@id='NOTES_TX']");
				Function.AssertEqual(true,ARMOREC_CustomerNotes_NotesTextarea.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Close on CustomerNotesForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_CustomerNotesForm = new SeleniumControl( sDriver, "CustomerNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTNOTES_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMOREC_CustomerNotesForm);
IWebElement formBttn = ARMOREC_CustomerNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExist on ChildForm_Table...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_Table = new SeleniumControl( sDriver, "ChildForm_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARHDRHS_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMOREC_ChildForm_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARHDRHS_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMOREC_ChildForm);
IWebElement formBttn = ARMOREC_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMOREC_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMOREC_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARHDRHS_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ARMOREC_ChildForm_Tab);
IWebElement mTab = ARMOREC_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on ChildForm_Details_InvoiceNumber...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_Details_InvoiceNumber = new SeleniumControl( sDriver, "ChildForm_Details_InvoiceNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARHDRHS_DTL_']/ancestor::form[1]/descendant::*[@id='INVC_ID']");
				Function.AssertEqual(true,ARMOREC_ChildForm_Details_InvoiceNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARHDRHS_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ARMOREC_ChildForm_Tab);
IWebElement mTab = ARMOREC_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Amount Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on ChildForm_AmountDetails_FuncDiscountAmount...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_AmountDetails_FuncDiscountAmount = new SeleniumControl( sDriver, "ChildForm_AmountDetails_FuncDiscountAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARHDRHS_DTL_']/ancestor::form[1]/descendant::*[@id='DISC_AMT']");
				Function.AssertEqual(true,ARMOREC_ChildForm_AmountDetails_FuncDiscountAmount.Exists());

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
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on ChildForm_ContactsLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_ContactsLink = new SeleniumControl( sDriver, "ChildForm_ContactsLink", "ID", "lnk_2500_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMOREC_ChildForm_ContactsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Click on ChildForm_ContactsLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_ContactsLink = new SeleniumControl( sDriver, "ChildForm_ContactsLink", "ID", "lnk_2500_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMOREC_ChildForm_ContactsLink);
ARMOREC_ChildForm_ContactsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExist on Contacts_Table...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_Contacts_Table = new SeleniumControl( sDriver, "Contacts_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTADDRCNTACT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMOREC_Contacts_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing ClickButton on ContactsForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ContactsForm = new SeleniumControl( sDriver, "ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTADDRCNTACT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMOREC_ContactsForm);
IWebElement formBttn = ARMOREC_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMOREC_ContactsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMOREC_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on ContactsForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ContactsForm = new SeleniumControl( sDriver, "ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTADDRCNTACT_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ARMOREC_ContactsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on Contacts_ContactID...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_Contacts_ContactID = new SeleniumControl( sDriver, "Contacts_ContactID", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTADDRCNTACT_DTL_']/ancestor::form[1]/descendant::*[@id='CNTACT_ID']");
				Function.AssertEqual(true,ARMOREC_Contacts_ContactID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Close on ContactsForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ContactsForm = new SeleniumControl( sDriver, "ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_CUSTADDRCNTACT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMOREC_ContactsForm);
IWebElement formBttn = ARMOREC_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_2508_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMOREC_ChildForm_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Click on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_2508_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMOREC_ChildForm_ExchangeRatesLink);
ARMOREC_ChildForm_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='ph__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,ARMOREC_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='ph__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,ARMOREC_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='ph__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMOREC_ExchangeRatesForm);
IWebElement formBttn = ARMOREC_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on ChildForm_InvoiceDetailLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_InvoiceDetailLink = new SeleniumControl( sDriver, "ChildForm_InvoiceDetailLink", "ID", "lnk_3005_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMOREC_ChildForm_InvoiceDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Click on ChildForm_InvoiceDetailLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_InvoiceDetailLink = new SeleniumControl( sDriver, "ChildForm_InvoiceDetailLink", "ID", "lnk_3005_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMOREC_ChildForm_InvoiceDetailLink);
ARMOREC_ChildForm_InvoiceDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExist on InvoiceDetail_Table...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_InvoiceDetail_Table = new SeleniumControl( sDriver, "InvoiceDetail_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARDETLHS_INVCDTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMOREC_InvoiceDetail_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing ClickButton on InvoiceDetailForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_InvoiceDetailForm = new SeleniumControl( sDriver, "InvoiceDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARDETLHS_INVCDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMOREC_InvoiceDetailForm);
IWebElement formBttn = ARMOREC_InvoiceDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMOREC_InvoiceDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMOREC_InvoiceDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on InvoiceDetailForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_InvoiceDetailForm = new SeleniumControl( sDriver, "InvoiceDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARDETLHS_INVCDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ARMOREC_InvoiceDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on InvoiceDetail_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_InvoiceDetail_FiscalYear = new SeleniumControl( sDriver, "InvoiceDetail_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARDETLHS_INVCDTL_']/ancestor::form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,ARMOREC_InvoiceDetail_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Close on InvoiceDetailForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_InvoiceDetailForm = new SeleniumControl( sDriver, "InvoiceDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARDETLHS_INVCDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMOREC_InvoiceDetailForm);
IWebElement formBttn = ARMOREC_InvoiceDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on ChildForm_InvoiceNotesLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_InvoiceNotesLink = new SeleniumControl( sDriver, "ChildForm_InvoiceNotesLink", "ID", "lnk_2513_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMOREC_ChildForm_InvoiceNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Click on ChildForm_InvoiceNotesLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_InvoiceNotesLink = new SeleniumControl( sDriver, "ChildForm_InvoiceNotesLink", "ID", "lnk_2513_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMOREC_ChildForm_InvoiceNotesLink);
ARMOREC_ChildForm_InvoiceNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExist on InvoiceNotes_Table...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_InvoiceNotes_Table = new SeleniumControl( sDriver, "InvoiceNotes_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARNOTESHS_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMOREC_InvoiceNotes_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Close on InvoiceNotesForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_InvoiceNotesForm = new SeleniumControl( sDriver, "InvoiceNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARNOTESHS_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMOREC_InvoiceNotesForm);
IWebElement formBttn = ARMOREC_InvoiceNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on ChildForm_SalesTaxLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_SalesTaxLink = new SeleniumControl( sDriver, "ChildForm_SalesTaxLink", "ID", "lnk_2514_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMOREC_ChildForm_SalesTaxLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Click on ChildForm_SalesTaxLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_SalesTaxLink = new SeleniumControl( sDriver, "ChildForm_SalesTaxLink", "ID", "lnk_2514_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMOREC_ChildForm_SalesTaxLink);
ARMOREC_ChildForm_SalesTaxLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExist on SalesTax_Table...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_SalesTax_Table = new SeleniumControl( sDriver, "SalesTax_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARSALESTAX_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMOREC_SalesTax_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Close on SalesTaxForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_SalesTaxForm = new SeleniumControl( sDriver, "SalesTaxForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_ARSALESTAX_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMOREC_SalesTaxForm);
IWebElement formBttn = ARMOREC_SalesTaxForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on ChildForm_FinanceChargesComputedLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_FinanceChargesComputedLink = new SeleniumControl( sDriver, "ChildForm_FinanceChargesComputedLink", "ID", "lnk_3297_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMOREC_ChildForm_FinanceChargesComputedLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Click on ChildForm_FinanceChargesComputedLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_FinanceChargesComputedLink = new SeleniumControl( sDriver, "ChildForm_FinanceChargesComputedLink", "ID", "lnk_3297_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMOREC_ChildForm_FinanceChargesComputedLink);
ARMOREC_ChildForm_FinanceChargesComputedLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExist on FinanceChargesComputed_Table...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_FinanceChargesComputed_Table = new SeleniumControl( sDriver, "FinanceChargesComputed_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_COMPUTED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMOREC_FinanceChargesComputed_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing ClickButton on FinanceChargesComputedForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_FinanceChargesComputedForm = new SeleniumControl( sDriver, "FinanceChargesComputedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_COMPUTED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMOREC_FinanceChargesComputedForm);
IWebElement formBttn = ARMOREC_FinanceChargesComputedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMOREC_FinanceChargesComputedForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMOREC_FinanceChargesComputedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on FinanceChargesComputedForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_FinanceChargesComputedForm = new SeleniumControl( sDriver, "FinanceChargesComputedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_COMPUTED_']/ancestor::form[1]");
				Function.AssertEqual(true,ARMOREC_FinanceChargesComputedForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on FinanceChargesComputed_FinanceChargeAmount...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_FinanceChargesComputed_FinanceChargeAmount = new SeleniumControl( sDriver, "FinanceChargesComputed_FinanceChargeAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_COMPUTED_']/ancestor::form[1]/descendant::*[@id='TRN_FINCHG_NET_AMT']");
				Function.AssertEqual(true,ARMOREC_FinanceChargesComputed_FinanceChargeAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Close on FinanceChargesComputedForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_FinanceChargesComputedForm = new SeleniumControl( sDriver, "FinanceChargesComputedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_COMPUTED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMOREC_FinanceChargesComputedForm);
IWebElement formBttn = ARMOREC_FinanceChargesComputedForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on ChildForm_FinanceChargesReceivedLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_FinanceChargesReceivedLink = new SeleniumControl( sDriver, "ChildForm_FinanceChargesReceivedLink", "ID", "lnk_3298_ARHISTCOM_ARHDRHS_DTL");
				Function.AssertEqual(true,ARMOREC_ChildForm_FinanceChargesReceivedLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Click on ChildForm_FinanceChargesReceivedLink...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_ChildForm_FinanceChargesReceivedLink = new SeleniumControl( sDriver, "ChildForm_FinanceChargesReceivedLink", "ID", "lnk_3298_ARHISTCOM_ARHDRHS_DTL");
				Function.WaitControlDisplayed(ARMOREC_ChildForm_FinanceChargesReceivedLink);
ARMOREC_ChildForm_FinanceChargesReceivedLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExist on FinanceChargesReceived_Table...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_FinanceChargesReceived_Table = new SeleniumControl( sDriver, "FinanceChargesReceived_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_RECEIVED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARMOREC_FinanceChargesReceived_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing ClickButton on FinanceChargesReceivedForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_FinanceChargesReceivedForm = new SeleniumControl( sDriver, "FinanceChargesReceivedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_RECEIVED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMOREC_FinanceChargesReceivedForm);
IWebElement formBttn = ARMOREC_FinanceChargesReceivedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARMOREC_FinanceChargesReceivedForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARMOREC_FinanceChargesReceivedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on FinanceChargesReceivedForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_FinanceChargesReceivedForm = new SeleniumControl( sDriver, "FinanceChargesReceivedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_RECEIVED_']/ancestor::form[1]");
				Function.AssertEqual(true,ARMOREC_FinanceChargesReceivedForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing VerifyExists on FinanceChargesReceived_FinanceChargeAmount...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_FinanceChargesReceived_FinanceChargeAmount = new SeleniumControl( sDriver, "FinanceChargesReceived_FinanceChargeAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_RECEIVED_']/ancestor::form[1]/descendant::*[@id='TRN_FINCHG_RCV_AMT']");
				Function.AssertEqual(true,ARMOREC_FinanceChargesReceived_FinanceChargeAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Close on FinanceChargesReceivedForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_FinanceChargesReceivedForm = new SeleniumControl( sDriver, "FinanceChargesReceivedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARHISTCOM_FINCHARGES_RECEIVED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARMOREC_FinanceChargesReceivedForm);
IWebElement formBttn = ARMOREC_FinanceChargesReceivedForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ARMOREC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARMOREC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARMOREC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ARMOREC_MainForm);
IWebElement formBttn = ARMOREC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

