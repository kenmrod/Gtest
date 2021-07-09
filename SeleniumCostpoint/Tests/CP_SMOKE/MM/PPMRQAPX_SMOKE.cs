 
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
    public class PPMRQAPX_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Purchase Requisitions", "xpath","//div[@class='navItem'][.='Purchase Requisitions']").Click();
new SeleniumControl(sDriver,"Approve Purchase Requisitions", "xpath","//div[@class='navItem'][.='Approve Purchase Requisitions']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Main");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
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
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMRQAPX_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPX_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_MainForm);
IWebElement formBttn = PPMRQAPX_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPX_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPX_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on Identification_Requisition...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_Identification_Requisition = new SeleniumControl( sDriver, "Identification_Requisition", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQ_ID']");
				Function.AssertEqual(true,PPMRQAPX_Identification_Requisition.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requisition Header Documents Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on RequisitionHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_RequisitionHeaderDocumentsLink = new SeleniumControl( sDriver, "RequisitionHeaderDocumentsLink", "ID", "lnk_3232_PPMRQAPX_RQHDR_HDR");
				Function.AssertEqual(true,PPMRQAPX_RequisitionHeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Click on RequisitionHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_RequisitionHeaderDocumentsLink = new SeleniumControl( sDriver, "RequisitionHeaderDocumentsLink", "ID", "lnk_3232_PPMRQAPX_RQHDR_HDR");
				Function.WaitControlDisplayed(PPMRQAPX_RequisitionHeaderDocumentsLink);
PPMRQAPX_RequisitionHeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on RequisitionHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_RequisitionHeaderDocumentsForm = new SeleniumControl( sDriver, "RequisitionHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQHDR_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPX_RequisitionHeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExist on RequisitionHeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_RequisitionHeaderDocumentsTable = new SeleniumControl( sDriver, "RequisitionHeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQHDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPX_RequisitionHeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing ClickButton on RequisitionHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_RequisitionHeaderDocumentsForm = new SeleniumControl( sDriver, "RequisitionHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQHDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_RequisitionHeaderDocumentsForm);
IWebElement formBttn = PPMRQAPX_RequisitionHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPX_RequisitionHeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPX_RequisitionHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on RequisitionHeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_RequisitionHeaderDocuments_Document = new SeleniumControl( sDriver, "RequisitionHeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQHDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPMRQAPX_RequisitionHeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Close on RequisitionHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_RequisitionHeaderDocumentsForm = new SeleniumControl( sDriver, "RequisitionHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQHDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_RequisitionHeaderDocumentsForm);
IWebElement formBttn = PPMRQAPX_RequisitionHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Approvals");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on ApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_ApprovalsLink = new SeleniumControl( sDriver, "ApprovalsLink", "ID", "lnk_1007074_PPMRQAPX_RQHDR_HDR");
				Function.AssertEqual(true,PPMRQAPX_ApprovalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Click on ApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_ApprovalsLink = new SeleniumControl( sDriver, "ApprovalsLink", "ID", "lnk_1007074_PPMRQAPX_RQHDR_HDR");
				Function.WaitControlDisplayed(PPMRQAPX_ApprovalsLink);
PPMRQAPX_ApprovalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on ApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_ApprovalsForm = new SeleniumControl( sDriver, "ApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPX_ApprovalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExist on ApprovalsTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_ApprovalsTable = new SeleniumControl( sDriver, "ApprovalsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQHDRAPPRVL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPX_ApprovalsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing ClickButton on ApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_ApprovalsForm = new SeleniumControl( sDriver, "ApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_ApprovalsForm);
IWebElement formBttn = PPMRQAPX_ApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPX_ApprovalsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPX_ApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on Approvals_ApprovalRevision...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_Approvals_ApprovalRevision = new SeleniumControl( sDriver, "Approvals_ApprovalRevision", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQHDRAPPRVL_']/ancestor::form[1]/descendant::*[@id='RQ_LN_RVSN_NO']");
				Function.AssertEqual(true,PPMRQAPX_Approvals_ApprovalRevision.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Close on ApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_ApprovalsForm = new SeleniumControl( sDriver, "ApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_ApprovalsForm);
IWebElement formBttn = PPMRQAPX_ApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on AccountsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_AccountsLink = new SeleniumControl( sDriver, "AccountsLink", "ID", "lnk_1007087_PPMRQAPX_RQHDR_HDR");
				Function.AssertEqual(true,PPMRQAPX_AccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Click on AccountsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_AccountsLink = new SeleniumControl( sDriver, "AccountsLink", "ID", "lnk_1007087_PPMRQAPX_RQHDR_HDR");
				Function.WaitControlDisplayed(PPMRQAPX_AccountsLink);
PPMRQAPX_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLNACCT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPX_AccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExist on AccountsTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_AccountsTable = new SeleniumControl( sDriver, "AccountsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLNACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPX_AccountsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing ClickButton on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_AccountsForm);
IWebElement formBttn = PPMRQAPX_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPX_AccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPX_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on Accounts_Project...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_Accounts_Project = new SeleniumControl( sDriver, "Accounts_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLNACCT_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PPMRQAPX_Accounts_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Close on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_AccountsForm);
IWebElement formBttn = PPMRQAPX_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1006016_PPMRQAPX_RQHDR_HDR");
				Function.AssertEqual(true,PPMRQAPX_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1006016_PPMRQAPX_RQHDR_HDR");
				Function.WaitControlDisplayed(PPMRQAPX_ExchangeRatesLink);
PPMRQAPX_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPX_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMRQAPX_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_ExchangeRatesForm);
IWebElement formBttn = PPMRQAPX_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on TotalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TotalsLink = new SeleniumControl( sDriver, "TotalsLink", "ID", "lnk_3279_PPMRQAPX_RQHDR_HDR");
				Function.AssertEqual(true,PPMRQAPX_TotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Click on TotalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TotalsLink = new SeleniumControl( sDriver, "TotalsLink", "ID", "lnk_3279_PPMRQAPX_RQHDR_HDR");
				Function.WaitControlDisplayed(PPMRQAPX_TotalsLink);
PPMRQAPX_TotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQ_TOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPX_TotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on Totals_Totals_Currency...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_Totals_Totals_Currency = new SeleniumControl( sDriver, "Totals_Totals_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQ_TOTALS_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMRQAPX_Totals_Totals_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Close on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQ_TOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_TotalsForm);
IWebElement formBttn = PPMRQAPX_TotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPX_TableWindowForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExist on TableWindowTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindowTable = new SeleniumControl( sDriver, "TableWindowTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPX_TableWindowTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing ClickButton on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_TableWindowForm);
IWebElement formBttn = PPMRQAPX_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPX_TableWindowForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPX_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on TableWindow_Line...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindow_Line = new SeleniumControl( sDriver, "TableWindow_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_CHILD_']/ancestor::form[1]/descendant::*[@id='RQ_LN_NO']");
				Function.AssertEqual(true,PPMRQAPX_TableWindow_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Select on TableWindowTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindowTab = new SeleniumControl( sDriver, "TableWindowTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQAPX_TableWindowTab);
IWebElement mTab = PPMRQAPX_TableWindowTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on TableWindow_BasicInformation_Item...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindow_BasicInformation_Item = new SeleniumControl( sDriver, "TableWindow_BasicInformation_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_CHILD_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PPMRQAPX_TableWindow_BasicInformation_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Select on TableWindowTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindowTab = new SeleniumControl( sDriver, "TableWindowTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQAPX_TableWindowTab);
IWebElement mTab = PPMRQAPX_TableWindowTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Purchasing Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on TableWindow_PurchasingInformation_AlternatePartNumbers_PreferredVendor...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindow_PurchasingInformation_AlternatePartNumbers_PreferredVendor = new SeleniumControl( sDriver, "TableWindow_PurchasingInformation_AlternatePartNumbers_PreferredVendor", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_CHILD_']/ancestor::form[1]/descendant::*[@id='PREF_VEND_ID']");
				Function.AssertEqual(true,PPMRQAPX_TableWindow_PurchasingInformation_AlternatePartNumbers_PreferredVendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Select on TableWindowTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindowTab = new SeleniumControl( sDriver, "TableWindowTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQAPX_TableWindowTab);
IWebElement mTab = PPMRQAPX_TableWindowTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shipping & Receiving").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on TableWindow_ShippingReceiving_Quality_SourceInspectionRequired...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindow_ShippingReceiving_Quality_SourceInspectionRequired = new SeleniumControl( sDriver, "TableWindow_ShippingReceiving_Quality_SourceInspectionRequired", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_CHILD_']/ancestor::form[1]/descendant::*[@id='SRCE_INSP_FL']");
				Function.AssertEqual(true,PPMRQAPX_TableWindow_ShippingReceiving_Quality_SourceInspectionRequired.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Select on TableWindowTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindowTab = new SeleniumControl( sDriver, "TableWindowTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQAPX_TableWindowTab);
IWebElement mTab = PPMRQAPX_TableWindowTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("Requisition Line Documents ");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on TableWindow_RequisitionLineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindow_RequisitionLineDocumentsLink = new SeleniumControl( sDriver, "TableWindow_RequisitionLineDocumentsLink", "ID", "lnk_3236_PPMRQAPX_RQLN_CHILD");
				Function.AssertEqual(true,PPMRQAPX_TableWindow_RequisitionLineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Click on TableWindow_RequisitionLineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindow_RequisitionLineDocumentsLink = new SeleniumControl( sDriver, "TableWindow_RequisitionLineDocumentsLink", "ID", "lnk_3236_PPMRQAPX_RQLN_CHILD");
				Function.WaitControlDisplayed(PPMRQAPX_TableWindow_RequisitionLineDocumentsLink);
PPMRQAPX_TableWindow_RequisitionLineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on RequisitionLineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_RequisitionLineDocumentsForm = new SeleniumControl( sDriver, "RequisitionLineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPX_RequisitionLineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExist on RequisitionLineDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_RequisitionLineDocumentsTable = new SeleniumControl( sDriver, "RequisitionLineDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPX_RequisitionLineDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing ClickButton on RequisitionLineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_RequisitionLineDocumentsForm = new SeleniumControl( sDriver, "RequisitionLineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_RequisitionLineDocumentsForm);
IWebElement formBttn = PPMRQAPX_RequisitionLineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPX_RequisitionLineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPX_RequisitionLineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on RequisitionLineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_RequisitionLineDocuments_Document = new SeleniumControl( sDriver, "RequisitionLineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPMRQAPX_RequisitionLineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Close on RequisitionLineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_RequisitionLineDocumentsForm = new SeleniumControl( sDriver, "RequisitionLineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_RequisitionLineDocumentsForm);
IWebElement formBttn = PPMRQAPX_RequisitionLineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Currency Line");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on TableWindow_CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindow_CurrencyLineLink = new SeleniumControl( sDriver, "TableWindow_CurrencyLineLink", "ID", "lnk_3280_PPMRQAPX_RQLN_CHILD");
				Function.AssertEqual(true,PPMRQAPX_TableWindow_CurrencyLineLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Click on TableWindow_CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindow_CurrencyLineLink = new SeleniumControl( sDriver, "TableWindow_CurrencyLineLink", "ID", "lnk_3280_PPMRQAPX_RQLN_CHILD");
				Function.WaitControlDisplayed(PPMRQAPX_TableWindow_CurrencyLineLink);
PPMRQAPX_TableWindow_CurrencyLineLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPX_CurrencyLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on CurrencyLine_LineAmounts_Currency...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_CurrencyLine_LineAmounts_Currency = new SeleniumControl( sDriver, "CurrencyLine_LineAmounts_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMRQAPX_CurrencyLine_LineAmounts_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Close on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_CurrencyLineForm);
IWebElement formBttn = PPMRQAPX_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requisition Line Documents ");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on TableWindow_QCLineTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindow_QCLineTextLink = new SeleniumControl( sDriver, "TableWindow_QCLineTextLink", "ID", "lnk_1005354_PPMRQAPX_RQLN_CHILD");
				Function.AssertEqual(true,PPMRQAPX_TableWindow_QCLineTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Click on TableWindow_QCLineTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_TableWindow_QCLineTextLink = new SeleniumControl( sDriver, "TableWindow_QCLineTextLink", "ID", "lnk_1005354_PPMRQAPX_RQLN_CHILD");
				Function.WaitControlDisplayed(PPMRQAPX_TableWindow_QCLineTextLink);
PPMRQAPX_TableWindow_QCLineTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on QCLineTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_QCLineTextForm = new SeleniumControl( sDriver, "QCLineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLNTXT_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPX_QCLineTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on QCLineText_LineTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_QCLineText_LineTextForm = new SeleniumControl( sDriver, "QCLineText_LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPX_QCLineText_LineTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing ClickButton on QCLineText_LineTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_QCLineText_LineTextForm = new SeleniumControl( sDriver, "QCLineText_LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_QCLineText_LineTextForm);
IWebElement formBttn = PPMRQAPX_QCLineText_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPX_QCLineText_LineTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPX_QCLineText_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing VerifyExists on QCLineText_LineText_Sequence...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_QCLineText_LineText_Sequence = new SeleniumControl( sDriver, "QCLineText_LineText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,PPMRQAPX_QCLineText_LineText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Close on QCLineTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_QCLineTextForm = new SeleniumControl( sDriver, "QCLineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPX_RQLNTXT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_QCLineTextForm);
IWebElement formBttn = PPMRQAPX_QCLineTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing Main");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPX] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPX_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRQAPX_MainForm);
IWebElement formBttn = PPMRQAPX_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

