 
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
    public class POQSTAT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Purchasing Reports/Inquiries", "xpath","//div[@class='navItem'][.='Purchasing Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Purchase Order Status", "xpath","//div[@class='navItem'][.='View Purchase Order Status']").Click();


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
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,POQSTAT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on Vendor...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_Vendor = new SeleniumControl( sDriver, "Vendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,POQSTAT_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQSTAT_ChildForm);
IWebElement formBttn = POQSTAT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? POQSTAT_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
POQSTAT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
Query_Find_CriteriaValue1.SendKeys("A", true);
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
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POHDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQSTAT_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQSTAT_ChildForm);
IWebElement formBttn = POQSTAT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQSTAT_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQSTAT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,POQSTAT_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POHDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_ChildFormTab);
IWebElement mTab = POQSTAT_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "PO Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PODetails_PurchaseOrder...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PODetails_PurchaseOrder = new SeleniumControl( sDriver, "ChildForm_PODetails_PurchaseOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POHDR_']/ancestor::form[1]/descendant::*[@id='PO_ID']");
				Function.AssertEqual(true,POQSTAT_ChildForm_PODetails_PurchaseOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POHDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_ChildFormTab);
IWebElement mTab = POQSTAT_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Vendor Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_VendorDetails_Vendor_Vendor...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_VendorDetails_Vendor_Vendor = new SeleniumControl( sDriver, "ChildForm_VendorDetails_Vendor_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POHDR_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,POQSTAT_ChildForm_VendorDetails_Vendor_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Select on ChildForm_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POHDR_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_ChildFormTab);
IWebElement mTab = POQSTAT_ChildForm_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_Notes_HeaderNotes...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_Notes_HeaderNotes = new SeleniumControl( sDriver, "ChildForm_Notes_HeaderNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POHDR_']/ancestor::form[1]/descendant::*[@id='PO_HDR_TX']");
				Function.AssertEqual(true,POQSTAT_ChildForm_Notes_HeaderNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Header Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_HeaderTextLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderTextLink = new SeleniumControl( sDriver, "ChildForm_HeaderTextLink", "ID", "lnk_1006854_POQSTAT_POHDR");
				Function.AssertEqual(true,POQSTAT_ChildForm_HeaderTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Click on ChildForm_HeaderTextLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderTextLink = new SeleniumControl( sDriver, "ChildForm_HeaderTextLink", "ID", "lnk_1006854_POQSTAT_POHDR");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_HeaderTextLink);
POQSTAT_ChildForm_HeaderTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExist on ChildForm_HeaderTextFormTable...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderTextFormTable = new SeleniumControl( sDriver, "ChildForm_HeaderTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POTEXT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQSTAT_ChildForm_HeaderTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing ClickButton on ChildForm_HeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderTextForm = new SeleniumControl( sDriver, "ChildForm_HeaderTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POTEXT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_HeaderTextForm);
IWebElement formBttn = POQSTAT_ChildForm_HeaderTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQSTAT_ChildForm_HeaderTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQSTAT_ChildForm_HeaderTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_HeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderTextForm = new SeleniumControl( sDriver, "ChildForm_HeaderTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POTEXT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,POQSTAT_ChildForm_HeaderTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_HeaderText_Seq...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderText_Seq = new SeleniumControl( sDriver, "ChildForm_HeaderText_Seq", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POTEXT_CTW_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,POQSTAT_ChildForm_HeaderText_Seq.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Close on ChildForm_HeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderTextForm = new SeleniumControl( sDriver, "ChildForm_HeaderTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POTEXT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_HeaderTextForm);
IWebElement formBttn = POQSTAT_ChildForm_HeaderTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderDocumentsLink = new SeleniumControl( sDriver, "ChildForm_HeaderDocumentsLink", "ID", "lnk_1007738_POQSTAT_POHDR");
				Function.AssertEqual(true,POQSTAT_ChildForm_HeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Click on ChildForm_HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderDocumentsLink = new SeleniumControl( sDriver, "ChildForm_HeaderDocumentsLink", "ID", "lnk_1007738_POQSTAT_POHDR");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_HeaderDocumentsLink);
POQSTAT_ChildForm_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExist on ChildForm_HeaderDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderDocumentsFormTable = new SeleniumControl( sDriver, "ChildForm_HeaderDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQSTAT_ChildForm_HeaderDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing ClickButton on ChildForm_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderDocumentsForm = new SeleniumControl( sDriver, "ChildForm_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_HeaderDocumentsForm);
IWebElement formBttn = POQSTAT_ChildForm_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQSTAT_ChildForm_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQSTAT_ChildForm_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderDocumentsForm = new SeleniumControl( sDriver, "ChildForm_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POQSTAT_ChildForm_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderDocuments_Document = new SeleniumControl( sDriver, "ChildForm_HeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POQSTAT_ChildForm_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Close on ChildForm_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_HeaderDocumentsForm = new SeleniumControl( sDriver, "ChildForm_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_HeaderDocumentsForm);
IWebElement formBttn = POQSTAT_ChildForm_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Purchase Order Lines");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLinesLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLinesLink = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLinesLink", "ID", "lnk_1007311_POQSTAT_POHDR");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLinesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Click on ChildForm_PurchaseOrderLinesLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLinesLink = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLinesLink", "ID", "lnk_1007311_POQSTAT_POHDR");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_PurchaseOrderLinesLink);
POQSTAT_ChildForm_PurchaseOrderLinesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExist on ChildForm_PurchaseOrderLinesFormTable...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLinesFormTable = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLinesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLinesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing ClickButton on ChildForm_PurchaseOrderLinesForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLinesForm = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_PurchaseOrderLinesForm);
IWebElement formBttn = POQSTAT_ChildForm_PurchaseOrderLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQSTAT_ChildForm_PurchaseOrderLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQSTAT_ChildForm_PurchaseOrderLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLinesForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLinesForm = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Select on ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab);
IWebElement mTab = POQSTAT_ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Detail").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_LineDetail_Line...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_LineDetail_Line = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_LineDetail_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='PO_LN_NO']");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_LineDetail_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Select on ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab);
IWebElement mTab = POQSTAT_ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_OtherInfo_GrossUnitCost...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_OtherInfo_GrossUnitCost = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_OtherInfo_GrossUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='TRN_GR_UN_CST_AMT']");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_OtherInfo_GrossUnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Select on ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab);
IWebElement mTab = POQSTAT_ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_Notes_POHeaderExpeditingNotes...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_Notes_POHeaderExpeditingNotes = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_Notes_POHeaderExpeditingNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='PO_EXPDT_TX']");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_Notes_POHeaderExpeditingNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Select on ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab);
IWebElement mTab = POQSTAT_ChildForm_PurchaseOrderLines_PurchaseOrderLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Subcontract Retainage PO Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_SubcontractPOInfo_Amounts_Ordered...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_SubcontractPOInfo_Amounts_Ordered = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_SubcontractPOInfo_Amounts_Ordered", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='ORDERED_AMT_SUBPO']");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_SubcontractPOInfo_Amounts_Ordered.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm_SerialLotInfoForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_SerialLotLink = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_SerialLotLink", "ID", "lnk_16787_POQSTAT_POLN_CTW");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_SerialLotLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_POLineAcctsLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_POLineAcctsLink = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_POLineAcctsLink", "ID", "lnk_1007312_POQSTAT_POLN_CTW");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_POLineAcctsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_POLineChargesLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_POLineChargesLink = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_POLineChargesLink", "ID", "lnk_1007345_POQSTAT_POLN_CTW");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_POLineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_POLineTextCodesLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_POLineTextCodesLink = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_POLineTextCodesLink", "ID", "lnk_1007344_POQSTAT_POLN_CTW");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_POLineTextCodesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_POLineNotesLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_POLineNotesLink = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_POLineNotesLink", "ID", "lnk_1007343_POQSTAT_POLN_CTW");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_POLineNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_LineDocumentsLink", "ID", "lnk_1007739_POQSTAT_POLN_CTW");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_ReceiptsStatusUpdatesLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_ReceiptsStatusUpdatesLink = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_ReceiptsStatusUpdatesLink", "ID", "lnk_1006940_POQSTAT_POLN_CTW");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_ReceiptsStatusUpdatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_OpenVchrsLnLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_OpenVchrsLnLink = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_OpenVchrsLnLink", "ID", "lnk_1006860_POQSTAT_POLN_CTW");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_OpenVchrsLnLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_VchrHistLnLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_VchrHistLnLink = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_VchrHistLnLink", "ID", "lnk_1006861_POQSTAT_POLN_CTW");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_VchrHistLnLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing VerifyExists on ChildForm_PurchaseOrderLines_VendReturnsLink...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLines_VendReturnsLink = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLines_VendReturnsLink", "ID", "lnk_1006943_POQSTAT_POLN_CTW");
				Function.AssertEqual(true,POQSTAT_ChildForm_PurchaseOrderLines_VendReturnsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Close on ChildForm_PurchaseOrderLinesForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_ChildForm_PurchaseOrderLinesForm = new SeleniumControl( sDriver, "ChildForm_PurchaseOrderLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQSTAT_POLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQSTAT_ChildForm_PurchaseOrderLinesForm);
IWebElement formBttn = POQSTAT_ChildForm_PurchaseOrderLinesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQSTAT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl POQSTAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POQSTAT_MainForm);
IWebElement formBttn = POQSTAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

