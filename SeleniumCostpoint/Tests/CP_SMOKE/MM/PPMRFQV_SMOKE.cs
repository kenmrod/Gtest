 
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
    public class PPMRFQV_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Request for Quotes By Vendor", "xpath","//div[@class='navItem'][.='Manage Request for Quotes By Vendor']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExists on Identification_RequestForQuoteID...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_Identification_RequestForQuoteID = new SeleniumControl( sDriver, "Identification_RequestForQuoteID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RFQ_ID']");
				Function.AssertEqual(true,PPMRFQV_Identification_RequestForQuoteID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMRFQV_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRFQV_MainForm);
IWebElement formBttn = PPMRFQV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PPMRFQV_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PPMRFQV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRFQV_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("HEADER STANDARD");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing Click on HeaderStandardTextFormLink...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_HeaderStandardTextFormLink = new SeleniumControl( sDriver, "HeaderStandardTextFormLink", "ID", "lnk_1003647_PPMRFQV_RFQHDR_VENDOR");
				Function.WaitControlDisplayed(PPMRFQV_HeaderStandardTextFormLink);
PPMRFQV_HeaderStandardTextFormLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExists on HeaderStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_HeaderStandardTextForm = new SeleniumControl( sDriver, "HeaderStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQV_HDRTXT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRFQV_HeaderStandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExist on HeaderStandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_HeaderStandardTextFormTable = new SeleniumControl( sDriver, "HeaderStandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQV_HDRTXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRFQV_HeaderStandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing Close on HeaderStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_HeaderStandardTextForm = new SeleniumControl( sDriver, "HeaderStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQV_HDRTXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQV_HeaderStandardTextForm);
IWebElement formBttn = PPMRFQV_HeaderStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("header documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing Click on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007842_PPMRFQV_RFQHDR_VENDOR");
				Function.WaitControlDisplayed(PPMRFQV_HeaderDocumentsLink);
PPMRFQV_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExists on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQHDR_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRFQV_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExist on HeaderDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_HeaderDocumentsFormTable = new SeleniumControl( sDriver, "HeaderDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQHDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRFQV_HeaderDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing ClickButton on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQHDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQV_HeaderDocumentsForm);
IWebElement formBttn = PPMRFQV_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRFQV_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRFQV_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExists on HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_HeaderDocuments_Document = new SeleniumControl( sDriver, "HeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQHDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPMRFQV_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing Close on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQHDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQV_HeaderDocumentsForm);
IWebElement formBttn = PPMRFQV_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("cf_line standard text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRFQV_MainForm);
IWebElement formBttn = PPMRFQV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PPMRFQV_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PPMRFQV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQV_RFQLN_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRFQV_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing Click on ChildForm_LineStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm_LineStandardTextLink = new SeleniumControl( sDriver, "ChildForm_LineStandardTextLink", "ID", "lnk_1003651_PPMRFQV_RFQLN_CHILD");
				Function.WaitControlDisplayed(PPMRFQV_ChildForm_LineStandardTextLink);
PPMRFQV_ChildForm_LineStandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExists on ChildForm_LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm_LineStandardTextForm = new SeleniumControl( sDriver, "ChildForm_LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQV_RFQLNTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRFQV_ChildForm_LineStandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExist on ChildForm_LineStandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm_LineStandardTextFormTable = new SeleniumControl( sDriver, "ChildForm_LineStandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQV_RFQLNTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRFQV_ChildForm_LineStandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing Close on ChildForm_LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm_LineStandardTextForm = new SeleniumControl( sDriver, "ChildForm_LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQV_RFQLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQV_ChildForm_LineStandardTextForm);
IWebElement formBttn = PPMRFQV_ChildForm_LineStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("cf_line quantity");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing Click on ChildForm_LineQuantityBreakpointsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm_LineQuantityBreakpointsLink = new SeleniumControl( sDriver, "ChildForm_LineQuantityBreakpointsLink", "ID", "lnk_1004479_PPMRFQV_RFQLN_CHILD");
				Function.WaitControlDisplayed(PPMRFQV_ChildForm_LineQuantityBreakpointsLink);
PPMRFQV_ChildForm_LineQuantityBreakpointsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExists on ChildForm_LineQuantityBreakpointsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm_LineQuantityBreakpointsForm = new SeleniumControl( sDriver, "ChildForm_LineQuantityBreakpointsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQV_RFQLNBRK_QUBR_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRFQV_ChildForm_LineQuantityBreakpointsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExist on ChildForm_LineQuantityBreakpointsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm_LineQuantityBreakpointsFormTable = new SeleniumControl( sDriver, "ChildForm_LineQuantityBreakpointsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQV_RFQLNBRK_QUBR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRFQV_ChildForm_LineQuantityBreakpointsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing Close on ChildForm_LineQuantityBreakpointsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm_LineQuantityBreakpointsForm = new SeleniumControl( sDriver, "ChildForm_LineQuantityBreakpointsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQV_RFQLNBRK_QUBR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQV_ChildForm_LineQuantityBreakpointsForm);
IWebElement formBttn = PPMRFQV_ChildForm_LineQuantityBreakpointsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("cf_line documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing Click on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007843_PPMRFQV_RFQLN_CHILD");
				Function.WaitControlDisplayed(PPMRFQV_ChildForm_LineDocumentsLink);
PPMRFQV_ChildForm_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExist on ChildForm_LineDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm_LineDocumentsFormTable = new SeleniumControl( sDriver, "ChildForm_LineDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRFQV_ChildForm_LineDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExists on ChildForm_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm_LineDocumentsForm = new SeleniumControl( sDriver, "ChildForm_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQLN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRFQV_ChildForm_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing ClickButton on ChildForm_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm_LineDocumentsForm = new SeleniumControl( sDriver, "ChildForm_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQV_ChildForm_LineDocumentsForm);
IWebElement formBttn = PPMRFQV_ChildForm_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRFQV_ChildForm_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRFQV_ChildForm_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing VerifyExists on ChildForm_LineDocuments_Rev...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_ChildForm_LineDocuments_Rev = new SeleniumControl( sDriver, "ChildForm_LineDocuments_Rev", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_RVSN_ID']");
				Function.AssertEqual(true,PPMRFQV_ChildForm_LineDocuments_Rev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PPMRFQV";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQV] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQV_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRFQV_MainForm);
IWebElement formBttn = PPMRFQV_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

