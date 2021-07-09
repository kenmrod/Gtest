 
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
    public class POPDM_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Voucher Processing", "xpath","//div[@class='navItem'][.='Voucher Processing']").Click();
new SeleniumControl(sDriver,"Create Debit Memos", "xpath","//div[@class='navItem'][.='Create Debit Memos']").Click();


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
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,POPDM_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on IncludeRejectedReplaceAmounts...", Logger.MessageType.INF);
				SeleniumControl POPDM_IncludeRejectedReplaceAmounts = new SeleniumControl( sDriver, "IncludeRejectedReplaceAmounts", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INCL_REJ_REP_FL']");
				Function.AssertEqual(true,POPDM_IncludeRejectedReplaceAmounts.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Creata Debit Memos");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing ClickButton on CreateDebitMemosForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemosForm = new SeleniumControl( sDriver, "CreateDebitMemosForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemosForm);
IWebElement formBttn = POPDM_CreateDebitMemosForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? POPDM_CreateDebitMemosForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
POPDM_CreateDebitMemosForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExist on CreateDebitMemosFormTable...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemosFormTable = new SeleniumControl( sDriver, "CreateDebitMemosFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POPDM_CreateDebitMemosFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing ClickButton on CreateDebitMemosForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemosForm = new SeleniumControl( sDriver, "CreateDebitMemosForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemosForm);
IWebElement formBttn = POPDM_CreateDebitMemosForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POPDM_CreateDebitMemosForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POPDM_CreateDebitMemosForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemosForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemosForm = new SeleniumControl( sDriver, "CreateDebitMemosForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,POPDM_CreateDebitMemosForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_Vendor...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_Vendor = new SeleniumControl( sDriver, "CreateDebitMemos_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_HDR_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Select on CreateDebitMemos_CreateDebitMemosTab...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_CreateDebitMemosTab = new SeleniumControl( sDriver, "CreateDebitMemos_CreateDebitMemosTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_CreateDebitMemosTab);
IWebElement mTab = POPDM_CreateDebitMemos_CreateDebitMemosTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Debit Memo Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_DebitMemoDetails_CreateDebitMemo...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_DebitMemoDetails_CreateDebitMemo = new SeleniumControl( sDriver, "CreateDebitMemos_DebitMemoDetails_CreateDebitMemo", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_HDR_']/ancestor::form[1]/descendant::*[@id='CREATE_DM']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_DebitMemoDetails_CreateDebitMemo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Select on CreateDebitMemos_CreateDebitMemosTab...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_CreateDebitMemosTab = new SeleniumControl( sDriver, "CreateDebitMemos_CreateDebitMemosTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_CreateDebitMemosTab);
IWebElement mTab = POPDM_CreateDebitMemos_CreateDebitMemosTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "PO Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_POLineDetails_Item...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POLineDetails_Item = new SeleniumControl( sDriver, "CreateDebitMemos_POLineDetails_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_HDR_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_POLineDetails_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Select on CreateDebitMemos_CreateDebitMemosTab...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_CreateDebitMemosTab = new SeleniumControl( sDriver, "CreateDebitMemos_CreateDebitMemosTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_HDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_CreateDebitMemosTab);
IWebElement mTab = POPDM_CreateDebitMemos_CreateDebitMemosTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "PO Line Quantities & Amounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_POLineQuantitiesAmounts_Quantities_Order...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POLineQuantitiesAmounts_Quantities_Order = new SeleniumControl( sDriver, "CreateDebitMemos_POLineQuantitiesAmounts_Quantities_Order", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_HDR_']/ancestor::form[1]/descendant::*[@id='ORD_QTY']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_POLineQuantitiesAmounts_Quantities_Order.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Header Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_HeaderDocumentsLink = new SeleniumControl( sDriver, "CreateDebitMemos_HeaderDocumentsLink", "ID", "lnk_1007823_POPDM_HDR");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_HeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Click on CreateDebitMemos_HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_HeaderDocumentsLink = new SeleniumControl( sDriver, "CreateDebitMemos_HeaderDocumentsLink", "ID", "lnk_1007823_POPDM_HDR");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_HeaderDocumentsLink);
POPDM_CreateDebitMemos_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExist on CreateDebitMemos_HeaderDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_HeaderDocumentsFormTable = new SeleniumControl( sDriver, "CreateDebitMemos_HeaderDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_HeaderDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing ClickButton on CreateDebitMemos_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_HeaderDocumentsForm = new SeleniumControl( sDriver, "CreateDebitMemos_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_HeaderDocumentsForm);
IWebElement formBttn = POPDM_CreateDebitMemos_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POPDM_CreateDebitMemos_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POPDM_CreateDebitMemos_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_HeaderDocumentsForm = new SeleniumControl( sDriver, "CreateDebitMemos_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_HeaderDocuments_Document = new SeleniumControl( sDriver, "CreateDebitMemos_HeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Close on CreateDebitMemos_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_HeaderDocumentsForm = new SeleniumControl( sDriver, "CreateDebitMemos_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_HeaderDocumentsForm);
IWebElement formBttn = POPDM_CreateDebitMemos_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PO Line Accounts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_POLineAccountsLink...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POLineAccountsLink = new SeleniumControl( sDriver, "CreateDebitMemos_POLineAccountsLink", "ID", "lnk_1006353_POPDM_HDR");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_POLineAccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Click on CreateDebitMemos_POLineAccountsLink...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POLineAccountsLink = new SeleniumControl( sDriver, "CreateDebitMemos_POLineAccountsLink", "ID", "lnk_1006353_POPDM_HDR");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_POLineAccountsLink);
POPDM_CreateDebitMemos_POLineAccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExist on CreateDebitMemos_POLineAccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POLineAccountsFormTable = new SeleniumControl( sDriver, "CreateDebitMemos_POLineAccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POLNACCT_POLNINFO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_POLineAccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing ClickButton on CreateDebitMemos_POLineAccountsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POLineAccountsForm = new SeleniumControl( sDriver, "CreateDebitMemos_POLineAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POLNACCT_POLNINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_POLineAccountsForm);
IWebElement formBttn = POPDM_CreateDebitMemos_POLineAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POPDM_CreateDebitMemos_POLineAccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POPDM_CreateDebitMemos_POLineAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_POLineAccountsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POLineAccountsForm = new SeleniumControl( sDriver, "CreateDebitMemos_POLineAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POLNACCT_POLNINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_POLineAccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_POLineAccounts_Project...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POLineAccounts_Project = new SeleniumControl( sDriver, "CreateDebitMemos_POLineAccounts_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POLNACCT_POLNINFO_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_POLineAccounts_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Close on CreateDebitMemos_POLineAccountsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POLineAccountsForm = new SeleniumControl( sDriver, "CreateDebitMemos_POLineAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POLNACCT_POLNINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_POLineAccountsForm);
IWebElement formBttn = POPDM_CreateDebitMemos_POLineAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_LineDocumentsLink = new SeleniumControl( sDriver, "CreateDebitMemos_LineDocumentsLink", "ID", "lnk_1007824_POPDM_HDR");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Click on CreateDebitMemos_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_LineDocumentsLink = new SeleniumControl( sDriver, "CreateDebitMemos_LineDocumentsLink", "ID", "lnk_1007824_POPDM_HDR");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_LineDocumentsLink);
POPDM_CreateDebitMemos_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExist on CreateDebitMemos_LineDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_LineDocumentsFormTable = new SeleniumControl( sDriver, "CreateDebitMemos_LineDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_LineDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing ClickButton on CreateDebitMemos_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_LineDocumentsForm = new SeleniumControl( sDriver, "CreateDebitMemos_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_LineDocumentsForm);
IWebElement formBttn = POPDM_CreateDebitMemos_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POPDM_CreateDebitMemos_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POPDM_CreateDebitMemos_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_LineDocumentsForm = new SeleniumControl( sDriver, "CreateDebitMemos_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_LineDocuments_Document = new SeleniumControl( sDriver, "CreateDebitMemos_LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Close on CreateDebitMemos_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_LineDocumentsForm = new SeleniumControl( sDriver, "CreateDebitMemos_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_LineDocumentsForm);
IWebElement formBttn = POPDM_CreateDebitMemos_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PO Receipts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_POReceiptsLink...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POReceiptsLink = new SeleniumControl( sDriver, "CreateDebitMemos_POReceiptsLink", "ID", "lnk_2634_POPDM_HDR");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_POReceiptsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Click on CreateDebitMemos_POReceiptsLink...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POReceiptsLink = new SeleniumControl( sDriver, "CreateDebitMemos_POReceiptsLink", "ID", "lnk_2634_POPDM_HDR");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_POReceiptsLink);
POPDM_CreateDebitMemos_POReceiptsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExist on CreateDebitMemos_POReceiptsFormTable...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POReceiptsFormTable = new SeleniumControl( sDriver, "CreateDebitMemos_POReceiptsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_RECEIPT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_POReceiptsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing ClickButton on CreateDebitMemos_POReceiptsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POReceiptsForm = new SeleniumControl( sDriver, "CreateDebitMemos_POReceiptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_RECEIPT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_POReceiptsForm);
IWebElement formBttn = POPDM_CreateDebitMemos_POReceiptsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POPDM_CreateDebitMemos_POReceiptsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POPDM_CreateDebitMemos_POReceiptsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_POReceiptsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POReceiptsForm = new SeleniumControl( sDriver, "CreateDebitMemos_POReceiptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_RECEIPT_']/ancestor::form[1]");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_POReceiptsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_POReceipts_Receipt...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POReceipts_Receipt = new SeleniumControl( sDriver, "CreateDebitMemos_POReceipts_Receipt", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_RECEIPT_']/ancestor::form[1]/descendant::*[@id='RECPT_ID']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_POReceipts_Receipt.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Close on CreateDebitMemos_POReceiptsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_POReceiptsForm = new SeleniumControl( sDriver, "CreateDebitMemos_POReceiptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_RECEIPT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_POReceiptsForm);
IWebElement formBttn = POPDM_CreateDebitMemos_POReceiptsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Inspections");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_InspectionsLink...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_InspectionsLink = new SeleniumControl( sDriver, "CreateDebitMemos_InspectionsLink", "ID", "lnk_1006355_POPDM_HDR");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_InspectionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Click on CreateDebitMemos_InspectionsLink...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_InspectionsLink = new SeleniumControl( sDriver, "CreateDebitMemos_InspectionsLink", "ID", "lnk_1006355_POPDM_HDR");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_InspectionsLink);
POPDM_CreateDebitMemos_InspectionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExist on CreateDebitMemos_InspectionsFormTable...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_InspectionsFormTable = new SeleniumControl( sDriver, "CreateDebitMemos_InspectionsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_INSPLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_InspectionsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing ClickButton on CreateDebitMemos_InspectionsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_InspectionsForm = new SeleniumControl( sDriver, "CreateDebitMemos_InspectionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_INSPLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_InspectionsForm);
IWebElement formBttn = POPDM_CreateDebitMemos_InspectionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POPDM_CreateDebitMemos_InspectionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POPDM_CreateDebitMemos_InspectionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_InspectionsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_InspectionsForm = new SeleniumControl( sDriver, "CreateDebitMemos_InspectionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_INSPLN_']/ancestor::form[1]");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_InspectionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_Inspections_Inspection...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_Inspections_Inspection = new SeleniumControl( sDriver, "CreateDebitMemos_Inspections_Inspection", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_INSPLN_']/ancestor::form[1]/descendant::*[@id='INSP_ID']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_Inspections_Inspection.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Close on CreateDebitMemos_InspectionsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_InspectionsForm = new SeleniumControl( sDriver, "CreateDebitMemos_InspectionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POPDM_INSPLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_InspectionsForm);
IWebElement formBttn = POPDM_CreateDebitMemos_InspectionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Vend Returns");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_VendorReturnsLink...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_VendorReturnsLink = new SeleniumControl( sDriver, "CreateDebitMemos_VendorReturnsLink", "ID", "lnk_2808_POPDM_HDR");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_VendorReturnsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Click on CreateDebitMemos_VendorReturnsLink...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_VendorReturnsLink = new SeleniumControl( sDriver, "CreateDebitMemos_VendorReturnsLink", "ID", "lnk_2808_POPDM_HDR");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_VendorReturnsLink);
POPDM_CreateDebitMemos_VendorReturnsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExist on CreateDebitMemos_VendReturnsFormTable...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_VendReturnsFormTable = new SeleniumControl( sDriver, "CreateDebitMemos_VendReturnsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_VENDRTRNLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_VendReturnsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing ClickButton on CreateDebitMemos_VendReturnsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_VendReturnsForm = new SeleniumControl( sDriver, "CreateDebitMemos_VendReturnsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_VENDRTRNLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_VendReturnsForm);
IWebElement formBttn = POPDM_CreateDebitMemos_VendReturnsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POPDM_CreateDebitMemos_VendReturnsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POPDM_CreateDebitMemos_VendReturnsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_VendReturnsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_VendReturnsForm = new SeleniumControl( sDriver, "CreateDebitMemos_VendReturnsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_VENDRTRNLN_']/ancestor::form[1]");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_VendReturnsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing VerifyExists on CreateDebitMemos_VendReturns_VendorReturn...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_VendReturns_VendorReturn = new SeleniumControl( sDriver, "CreateDebitMemos_VendReturns_VendorReturn", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_VENDRTRNLN_']/ancestor::form[1]/descendant::*[@id='RTRN_ID']");
				Function.AssertEqual(true,POPDM_CreateDebitMemos_VendReturns_VendorReturn.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Close on CreateDebitMemos_VendReturnsForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_CreateDebitMemos_VendReturnsForm = new SeleniumControl( sDriver, "CreateDebitMemos_VendReturnsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_VENDRTRNLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POPDM_CreateDebitMemos_VendReturnsForm);
IWebElement formBttn = POPDM_CreateDebitMemos_VendReturnsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POPDM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POPDM] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl POPDM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POPDM_MainForm);
IWebElement formBttn = POPDM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

