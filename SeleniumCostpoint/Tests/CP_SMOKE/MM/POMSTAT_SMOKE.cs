 
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
    public class POMSTAT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Purchasing", "xpath","//div[@class='deptItem'][.='Purchasing']").Click();
new SeleniumControl(sDriver,"Purchase Orders", "xpath","//div[@class='navItem'][.='Purchase Orders']").Click();
new SeleniumControl(sDriver,"Approve Pending Purchase Orders", "xpath","//div[@class='navItem'][.='Approve Pending Purchase Orders']").Click();


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
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMSTAT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,POMSTAT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMSTAT_MainForm);
IWebElement formBttn = POMSTAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMSTAT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMSTAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on Identification_PO...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_Identification_PO = new SeleniumControl( sDriver, "Identification_PO", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PO_ID']");
				Function.AssertEqual(true,POMSTAT_Identification_PO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1004349_POMSTAT_POHDR_HDR");
				Function.AssertEqual(true,POMSTAT_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1004349_POMSTAT_POHDR_HDR");
				Function.WaitControlDisplayed(POMSTAT_ExchangeRatesLink);
POMSTAT_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,POMSTAT_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,POMSTAT_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSTAT_ExchangeRatesForm);
IWebElement formBttn = POMSTAT_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007759_POMSTAT_POHDR_HDR");
				Function.AssertEqual(true,POMSTAT_HeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing Click on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007759_POMSTAT_POHDR_HDR");
				Function.WaitControlDisplayed(POMSTAT_HeaderDocumentsLink);
POMSTAT_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExist on HeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_HeaderDocumentsTable = new SeleniumControl( sDriver, "HeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMSTAT_HeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMSTAT_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing ClickButton on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSTAT_HeaderDocumentsForm);
IWebElement formBttn = POMSTAT_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMSTAT_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMSTAT_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_HeaderDocuments_Document = new SeleniumControl( sDriver, "HeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POMSTAT_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing Close on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSTAT_HeaderDocumentsForm);
IWebElement formBttn = POMSTAT_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POLine Information");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExist on POLineInformationTable...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_POLineInformationTable = new SeleniumControl( sDriver, "POLineInformationTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_POLN_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMSTAT_POLineInformationTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on POLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_POLineInformationForm = new SeleniumControl( sDriver, "POLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_POLN_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,POMSTAT_POLineInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing ClickButton on POLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_POLineInformationForm = new SeleniumControl( sDriver, "POLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_POLN_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSTAT_POLineInformationForm);
IWebElement formBttn = POMSTAT_POLineInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMSTAT_POLineInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMSTAT_POLineInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on POLineInformation_Line...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_POLineInformation_Line = new SeleniumControl( sDriver, "POLineInformation_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_POLN_DTL_']/ancestor::form[1]/descendant::*[@id='PO_LN_NO']");
				Function.AssertEqual(true,POMSTAT_POLineInformation_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Purchase Order Line Detail Inquiry");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on POLineInformation_PurchaseOrderLineDetailInquiryLink...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_POLineInformation_PurchaseOrderLineDetailInquiryLink = new SeleniumControl( sDriver, "POLineInformation_PurchaseOrderLineDetailInquiryLink", "ID", "lnk_1003277_POMSTAT_POLN_DTL");
				Function.AssertEqual(true,POMSTAT_POLineInformation_PurchaseOrderLineDetailInquiryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing Click on POLineInformation_PurchaseOrderLineDetailInquiryLink...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_POLineInformation_PurchaseOrderLineDetailInquiryLink = new SeleniumControl( sDriver, "POLineInformation_PurchaseOrderLineDetailInquiryLink", "ID", "lnk_1003277_POMSTAT_POLN_DTL");
				Function.WaitControlDisplayed(POMSTAT_POLineInformation_PurchaseOrderLineDetailInquiryLink);
POMSTAT_POLineInformation_PurchaseOrderLineDetailInquiryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExist on PurchaseOrderLineDetailInquiryTable...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_PurchaseOrderLineDetailInquiryTable = new SeleniumControl( sDriver, "PurchaseOrderLineDetailInquiryTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_POLINEDETAILINQUIRY_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMSTAT_PurchaseOrderLineDetailInquiryTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on PurchaseOrderLineDetailInquiryForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_PurchaseOrderLineDetailInquiryForm = new SeleniumControl( sDriver, "PurchaseOrderLineDetailInquiryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_POLINEDETAILINQUIRY_']/ancestor::form[1]");
				Function.AssertEqual(true,POMSTAT_PurchaseOrderLineDetailInquiryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing ClickButton on PurchaseOrderLineDetailInquiryForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_PurchaseOrderLineDetailInquiryForm = new SeleniumControl( sDriver, "PurchaseOrderLineDetailInquiryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_POLINEDETAILINQUIRY_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSTAT_PurchaseOrderLineDetailInquiryForm);
IWebElement formBttn = POMSTAT_PurchaseOrderLineDetailInquiryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMSTAT_PurchaseOrderLineDetailInquiryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMSTAT_PurchaseOrderLineDetailInquiryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on PurchaseOrderLineDetailInquiry_PROject...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_PurchaseOrderLineDetailInquiry_PROject = new SeleniumControl( sDriver, "PurchaseOrderLineDetailInquiry_PROject", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_POLINEDETAILINQUIRY_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,POMSTAT_PurchaseOrderLineDetailInquiry_PROject.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing Close on PurchaseOrderLineDetailInquiryForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_PurchaseOrderLineDetailInquiryForm = new SeleniumControl( sDriver, "PurchaseOrderLineDetailInquiryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_POLINEDETAILINQUIRY_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSTAT_PurchaseOrderLineDetailInquiryForm);
IWebElement formBttn = POMSTAT_PurchaseOrderLineDetailInquiryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Subcontract PO Line Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on POLineInformation_SubcontractPOLineDetailLink...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_POLineInformation_SubcontractPOLineDetailLink = new SeleniumControl( sDriver, "POLineInformation_SubcontractPOLineDetailLink", "ID", "lnk_1003278_POMSTAT_POLN_DTL");
				Function.AssertEqual(true,POMSTAT_POLineInformation_SubcontractPOLineDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing Click on POLineInformation_SubcontractPOLineDetailLink...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_POLineInformation_SubcontractPOLineDetailLink = new SeleniumControl( sDriver, "POLineInformation_SubcontractPOLineDetailLink", "ID", "lnk_1003278_POMSTAT_POLN_DTL");
				Function.WaitControlDisplayed(POMSTAT_POLineInformation_SubcontractPOLineDetailLink);
POMSTAT_POLineInformation_SubcontractPOLineDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExist on SubContractPOLineDetailTable...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_SubContractPOLineDetailTable = new SeleniumControl( sDriver, "SubContractPOLineDetailTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_SUBCONTRACTLINEDTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMSTAT_SubContractPOLineDetailTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on SubContractPOLineDetailForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_SubContractPOLineDetailForm = new SeleniumControl( sDriver, "SubContractPOLineDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_SUBCONTRACTLINEDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,POMSTAT_SubContractPOLineDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing ClickButton on SubContractPOLineDetailForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_SubContractPOLineDetailForm = new SeleniumControl( sDriver, "SubContractPOLineDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_SUBCONTRACTLINEDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSTAT_SubContractPOLineDetailForm);
IWebElement formBttn = POMSTAT_SubContractPOLineDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMSTAT_SubContractPOLineDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMSTAT_SubContractPOLineDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on SubcontractPOLineDetail_PROject...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_SubcontractPOLineDetail_PROject = new SeleniumControl( sDriver, "SubcontractPOLineDetail_PROject", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_SUBCONTRACTLINEDTL_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,POMSTAT_SubcontractPOLineDetail_PROject.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing Close on SubContractPOLineDetailForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_SubContractPOLineDetailForm = new SeleniumControl( sDriver, "SubContractPOLineDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMSTAT_SUBCONTRACTLINEDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSTAT_SubContractPOLineDetailForm);
IWebElement formBttn = POMSTAT_SubContractPOLineDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on POLineInformation_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_POLineInformation_LineDocumentsLink = new SeleniumControl( sDriver, "POLineInformation_LineDocumentsLink", "ID", "lnk_1007761_POMSTAT_POLN_DTL");
				Function.AssertEqual(true,POMSTAT_POLineInformation_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing Click on POLineInformation_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_POLineInformation_LineDocumentsLink = new SeleniumControl( sDriver, "POLineInformation_LineDocumentsLink", "ID", "lnk_1007761_POMSTAT_POLN_DTL");
				Function.WaitControlDisplayed(POMSTAT_POLineInformation_LineDocumentsLink);
POMSTAT_POLineInformation_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExist on LineDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_LineDocumentsTable = new SeleniumControl( sDriver, "LineDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMSTAT_LineDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMSTAT_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing ClickButton on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSTAT_LineDocumentsForm);
IWebElement formBttn = POMSTAT_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMSTAT_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMSTAT_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing VerifyExists on LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_LineDocuments_Document = new SeleniumControl( sDriver, "LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POMSTAT_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing Close on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMSTAT_LineDocumentsForm);
IWebElement formBttn = POMSTAT_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POMSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMSTAT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMSTAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMSTAT_MainForm);
IWebElement formBttn = POMSTAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

