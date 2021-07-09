 
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
    public class POMEXPD_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Expedite Purchase Orders", "xpath","//div[@class='navItem'][.='Expedite Purchase Orders']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,POMEXPD_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on Buyer...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_Buyer = new SeleniumControl( sDriver, "Buyer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BUYER_ID']");
				Function.AssertEqual(true,POMEXPD_Buyer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POHDR_POLNHEADER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMEXPD_ChildForm);
IWebElement formBttn = POMEXPD_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? POMEXPD_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
POMEXPD_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("QUERY");


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
								try
				{
				this.ScriptLogger.WriteLine("CHILD FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POHDR_POLNHEADER_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMEXPD_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POHDR_POLNHEADER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMEXPD_ChildForm);
IWebElement formBttn = POMEXPD_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMEXPD_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMEXPD_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POHDR_POLNHEADER_']/ancestor::form[1]");
				Function.AssertEqual(true,POMEXPD_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_PurchaseOrder...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_PurchaseOrder = new SeleniumControl( sDriver, "ChildForm_PurchaseOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POHDR_POLNHEADER_']/ancestor::form[1]/descendant::*[@id='PO_ID']");
				Function.AssertEqual(true,POMEXPD_ChildForm_PurchaseOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_LineDetails_LineType...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_LineDetails_LineType = new SeleniumControl( sDriver, "ChildForm_LineDetails_LineType", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POHDR_POLNHEADER_']/ancestor::form[1]/descendant::*[@id='S_PO_LN_TYPE']");
				Function.AssertEqual(true,POMEXPD_ChildForm_LineDetails_LineType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POHDR_POLNHEADER_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_Tab);
IWebElement mTab = POMEXPD_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Quantities and Amounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_QuantitiesAndAmounts_LineAmounts_ExtendedAmt...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_QuantitiesAndAmounts_LineAmounts_ExtendedAmt = new SeleniumControl( sDriver, "ChildForm_QuantitiesAndAmounts_LineAmounts_ExtendedAmt", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POHDR_POLNHEADER_']/ancestor::form[1]/descendant::*[@id='TRN_PO_LN_EXT_AMT']");
				Function.AssertEqual(true,POMEXPD_ChildForm_QuantitiesAndAmounts_LineAmounts_ExtendedAmt.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POHDR_POLNHEADER_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_Tab);
IWebElement mTab = POMEXPD_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Vendor").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_Vendor_Vendor...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_Vendor_Vendor = new SeleniumControl( sDriver, "ChildForm_Vendor_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POHDR_POLNHEADER_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,POMEXPD_ChildForm_Vendor_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POHDR_POLNHEADER_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_Tab);
IWebElement mTab = POMEXPD_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_Notes_POLineExpeditingNotes...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_Notes_POLineExpeditingNotes = new SeleniumControl( sDriver, "ChildForm_Notes_POLineExpeditingNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POHDR_POLNHEADER_']/ancestor::form[1]/descendant::*[@id='PO_LN_EXPDT_NOTES']");
				Function.AssertEqual(true,POMEXPD_ChildForm_Notes_POLineExpeditingNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PO HEADER EXPEDITE NOTES LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_POHeaderExpediteNotesLink...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_POHeaderExpediteNotesLink = new SeleniumControl( sDriver, "ChildForm_POHeaderExpediteNotesLink", "ID", "lnk_1003333_POMEXPD_POHDR_POLNHEADER");
				Function.AssertEqual(true,POMEXPD_ChildForm_POHeaderExpediteNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Click on ChildForm_POHeaderExpediteNotesLink...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_POHeaderExpediteNotesLink = new SeleniumControl( sDriver, "ChildForm_POHeaderExpediteNotesLink", "ID", "lnk_1003333_POMEXPD_POHDR_POLNHEADER");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_POHeaderExpediteNotesLink);
POMEXPD_ChildForm_POHeaderExpediteNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_POHeaderExpediteNotesForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_POHeaderExpediteNotesForm = new SeleniumControl( sDriver, "ChildForm_POHeaderExpediteNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POEXPDTNOTE_SUBTASK_']/ancestor::form[1]");
				Function.AssertEqual(true,POMEXPD_ChildForm_POHeaderExpediteNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_POHeaderExpediteNotes_POHeaderExpediteNotes...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_POHeaderExpediteNotes_POHeaderExpediteNotes = new SeleniumControl( sDriver, "ChildForm_POHeaderExpediteNotes_POHeaderExpediteNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POEXPDTNOTE_SUBTASK_']/ancestor::form[1]/descendant::*[@id='PO_EXPDT_TX']");
				Function.AssertEqual(true,POMEXPD_ChildForm_POHeaderExpediteNotes_POHeaderExpediteNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Close on ChildForm_POHeaderExpediteNotesForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_POHeaderExpediteNotesForm = new SeleniumControl( sDriver, "ChildForm_POHeaderExpediteNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POEXPDTNOTE_SUBTASK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_POHeaderExpediteNotesForm);
IWebElement formBttn = POMEXPD_ChildForm_POHeaderExpediteNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("HEADER DOCUMENT LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_HeaderDocumentsLink = new SeleniumControl( sDriver, "ChildForm_HeaderDocumentsLink", "ID", "lnk_1007833_POMEXPD_POHDR_POLNHEADER");
				Function.AssertEqual(true,POMEXPD_ChildForm_HeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Click on ChildForm_HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_HeaderDocumentsLink = new SeleniumControl( sDriver, "ChildForm_HeaderDocumentsLink", "ID", "lnk_1007833_POMEXPD_POHDR_POLNHEADER");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_HeaderDocumentsLink);
POMEXPD_ChildForm_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExist on ChildForm_HeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_HeaderDocumentsTable = new SeleniumControl( sDriver, "ChildForm_HeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMEXPD_ChildForm_HeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing ClickButton on ChildForm_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_HeaderDocumentsForm = new SeleniumControl( sDriver, "ChildForm_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_HeaderDocumentsForm);
IWebElement formBttn = POMEXPD_ChildForm_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMEXPD_ChildForm_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMEXPD_ChildForm_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_HeaderDocumentsForm = new SeleniumControl( sDriver, "ChildForm_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMEXPD_ChildForm_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_HeaderDocuments_Document = new SeleniumControl( sDriver, "ChildForm_HeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POMEXPD_ChildForm_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Close on ChildForm_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_HeaderDocumentsForm = new SeleniumControl( sDriver, "ChildForm_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_HeaderDocumentsForm);
IWebElement formBttn = POMEXPD_ChildForm_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PO LINE ACCOUNTS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_POLineAccountsLink...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_POLineAccountsLink = new SeleniumControl( sDriver, "ChildForm_POLineAccountsLink", "ID", "lnk_1003350_POMEXPD_POHDR_POLNHEADER");
				Function.AssertEqual(true,POMEXPD_ChildForm_POLineAccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Click on ChildForm_POLineAccountsLink...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_POLineAccountsLink = new SeleniumControl( sDriver, "ChildForm_POLineAccountsLink", "ID", "lnk_1003350_POMEXPD_POHDR_POLNHEADER");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_POLineAccountsLink);
POMEXPD_ChildForm_POLineAccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExist on ChildForm_POLineAccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_POLineAccountsFormTable = new SeleniumControl( sDriver, "ChildForm_POLineAccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POLNACCT_POLNINFO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMEXPD_ChildForm_POLineAccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing ClickButton on ChildForm_POLineAccountsForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_POLineAccountsForm = new SeleniumControl( sDriver, "ChildForm_POLineAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POLNACCT_POLNINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_POLineAccountsForm);
IWebElement formBttn = POMEXPD_ChildForm_POLineAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMEXPD_ChildForm_POLineAccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMEXPD_ChildForm_POLineAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_POLineAccountsForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_POLineAccountsForm = new SeleniumControl( sDriver, "ChildForm_POLineAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POLNACCT_POLNINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,POMEXPD_ChildForm_POLineAccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_POLineAccounts_Project...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_POLineAccounts_Project = new SeleniumControl( sDriver, "ChildForm_POLineAccounts_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POLNACCT_POLNINFO_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,POMEXPD_ChildForm_POLineAccounts_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Close on ChildForm_POLineAccountsForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_POLineAccountsForm = new SeleniumControl( sDriver, "ChildForm_POLineAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_POLNACCT_POLNINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_POLineAccountsForm);
IWebElement formBttn = POMEXPD_ChildForm_POLineAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINE DOCUMENTS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007835_POMEXPD_POHDR_POLNHEADER");
				Function.AssertEqual(true,POMEXPD_ChildForm_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Click on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007835_POMEXPD_POHDR_POLNHEADER");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_LineDocumentsLink);
POMEXPD_ChildForm_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExist on ChildForm_LineDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_LineDocumentsTable = new SeleniumControl( sDriver, "ChildForm_LineDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMEXPD_ChildForm_LineDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing ClickButton on ChildForm_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_LineDocumentsForm = new SeleniumControl( sDriver, "ChildForm_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_LineDocumentsForm);
IWebElement formBttn = POMEXPD_ChildForm_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMEXPD_ChildForm_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMEXPD_ChildForm_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_LineDocumentsForm = new SeleniumControl( sDriver, "ChildForm_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMEXPD_ChildForm_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_LineDocuments_Document = new SeleniumControl( sDriver, "ChildForm_LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POMEXPD_ChildForm_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Close on ChildForm_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_LineDocumentsForm = new SeleniumControl( sDriver, "ChildForm_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_LineDocumentsForm);
IWebElement formBttn = POMEXPD_ChildForm_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("VENDOR INFO LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_VendorInfoLink...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_VendorInfoLink = new SeleniumControl( sDriver, "ChildForm_VendorInfoLink", "ID", "lnk_1003359_POMEXPD_POHDR_POLNHEADER");
				Function.AssertEqual(true,POMEXPD_ChildForm_VendorInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Click on ChildForm_VendorInfoLink...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_VendorInfoLink = new SeleniumControl( sDriver, "ChildForm_VendorInfoLink", "ID", "lnk_1003359_POMEXPD_POHDR_POLNHEADER");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_VendorInfoLink);
POMEXPD_ChildForm_VendorInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_VendorInfoForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_VendorInfoForm = new SeleniumControl( sDriver, "ChildForm_VendorInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_VENDADDR_HDRINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,POMEXPD_ChildForm_VendorInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_VendorInfo_Vendor...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_VendorInfo_Vendor = new SeleniumControl( sDriver, "ChildForm_VendorInfo_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_VENDADDR_HDRINFO_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,POMEXPD_ChildForm_VendorInfo_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Close on ChildForm_VendorInfoForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_VendorInfoForm = new SeleniumControl( sDriver, "ChildForm_VendorInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POMEXPD_VENDADDR_HDRINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_VendorInfoForm);
IWebElement formBttn = POMEXPD_ChildForm_VendorInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EXCHANGE RATES LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_1003357_POMEXPD_POHDR_POLNHEADER");
				Function.AssertEqual(true,POMEXPD_ChildForm_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Click on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_1003357_POMEXPD_POHDR_POLNHEADER");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_ExchangeRatesLink);
POMEXPD_ChildForm_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_ExchangeRatesForm = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,POMEXPD_ChildForm_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing VerifyExists on ChildForm_ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ChildForm_ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,POMEXPD_ChildForm_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Close on ChildForm_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_ChildForm_ExchangeRatesForm = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMEXPD_ChildForm_ExchangeRatesForm);
IWebElement formBttn = POMEXPD_ChildForm_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMEXPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMEXPD] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMEXPD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMEXPD_MainForm);
IWebElement formBttn = POMEXPD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

