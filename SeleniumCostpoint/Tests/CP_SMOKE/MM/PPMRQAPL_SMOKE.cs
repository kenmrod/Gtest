 
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
    public class PPMRQAPL_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Approve Purchase Requisition Lines", "xpath","//div[@class='navItem'][.='Approve Purchase Requisition Lines']").Click();


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
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPL_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMRQAPL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_MainForm);
IWebElement formBttn = PPMRQAPL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on Requisition...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_Requisition = new SeleniumControl( sDriver, "Requisition", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQ_ID']");
				Function.AssertEqual(true,PPMRQAPL_Requisition.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on BasicInfo_RequisitionInfo_Requisitioner...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_BasicInfo_RequisitionInfo_Requisitioner = new SeleniumControl( sDriver, "BasicInfo_RequisitionInfo_Requisitioner", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQST_EMPL_ID']");
				Function.AssertEqual(true,PPMRQAPL_BasicInfo_RequisitionInfo_Requisitioner.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQAPL_MainTab);
IWebElement mTab = PPMRQAPL_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on LineDetails_InvAbbrev...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_LineDetails_InvAbbrev = new SeleniumControl( sDriver, "LineDetails_InvAbbrev", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVT_ABBRV_CD']");
				Function.AssertEqual(true,PPMRQAPL_LineDetails_InvAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQAPL_MainTab);
IWebElement mTab = PPMRQAPL_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Amounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on LineAmounts_EstCostType...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_LineAmounts_EstCostType = new SeleniumControl( sDriver, "LineAmounts_EstCostType", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQ_EST_CST_TYPE_CD']");
				Function.AssertEqual(true,PPMRQAPL_LineAmounts_EstCostType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQAPL_MainTab);
IWebElement mTab = PPMRQAPL_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Purchasing Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on ManufVendParts_ManufacturerPart...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_ManufVendParts_ManufacturerPart = new SeleniumControl( sDriver, "ManufVendParts_ManufacturerPart", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MANUF_PART_ID']");
				Function.AssertEqual(true,PPMRQAPL_ManufVendParts_ManufacturerPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRQAPL_MainTab);
IWebElement mTab = PPMRQAPL_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on Notes_ApprovalNotes...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_Notes_ApprovalNotes = new SeleniumControl( sDriver, "Notes_ApprovalNotes", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='APPRVL_NOTES']");
				Function.AssertEqual(true,PPMRQAPL_Notes_ApprovalNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_MainForm);
IWebElement formBttn = PPMRQAPL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PPMRQAPL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PPMRQAPL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Query] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
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
				this.ScriptLogger.WriteLine("Hdr Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Click on HdrDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_HdrDocumentsLink = new SeleniumControl( sDriver, "HdrDocumentsLink", "ID", "lnk_1007730_PPMRQAPL_RQLNAPPRVL_HDR");
				Function.WaitControlDisplayed(PPMRQAPL_HdrDocumentsLink);
PPMRQAPL_HdrDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_HdrDocumentsForm = new SeleniumControl( sDriver, "HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPL_HdrDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExist on HdrDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_HdrDocumentsFormTable = new SeleniumControl( sDriver, "HdrDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPL_HdrDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing ClickButtonIfExists on HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_HdrDocumentsForm = new SeleniumControl( sDriver, "HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_HdrDocumentsForm);
IWebElement formBttn = PPMRQAPL_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPL_HdrDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPL_HdrDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on HdrDocuments_CAGE...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_HdrDocuments_CAGE = new SeleniumControl( sDriver, "HdrDocuments_CAGE", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='CAGE_ID_FLD']");
				Function.AssertEqual(true,PPMRQAPL_HdrDocuments_CAGE.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Close on HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_HdrDocumentsForm = new SeleniumControl( sDriver, "HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_HdrDocumentsForm);
IWebElement formBttn = PPMRQAPL_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Click on LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_LineDocumentsLink = new SeleniumControl( sDriver, "LineDocumentsLink", "ID", "lnk_1007729_PPMRQAPL_RQLNAPPRVL_HDR");
				Function.WaitControlDisplayed(PPMRQAPL_LineDocumentsLink);
PPMRQAPL_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPL_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExist on LineDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_LineDocumentsFormTable = new SeleniumControl( sDriver, "LineDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPL_LineDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing ClickButtonIfExists on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_LineDocumentsForm);
IWebElement formBttn = PPMRQAPL_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPL_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPL_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on LineDocuments_CAGE...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_LineDocuments_CAGE = new SeleniumControl( sDriver, "LineDocuments_CAGE", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='CAGE_ID_FLD']");
				Function.AssertEqual(true,PPMRQAPL_LineDocuments_CAGE.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Close on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_LineDocumentsForm);
IWebElement formBttn = PPMRQAPL_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Click on CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_CurrencyLineLink = new SeleniumControl( sDriver, "CurrencyLineLink", "ID", "lnk_2736_PPMRQAPL_RQLNAPPRVL_HDR");
				Function.WaitControlDisplayed(PPMRQAPL_CurrencyLineLink);
PPMRQAPL_CurrencyLineLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPL_CurrencyLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on CurrencyLine_LineAmounts_Functional_Currency...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_CurrencyLine_LineAmounts_Functional_Currency = new SeleniumControl( sDriver, "CurrencyLine_LineAmounts_Functional_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMRQAPL_CurrencyLine_LineAmounts_Functional_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing ClickButtonIfExists on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_CurrencyLineForm);
IWebElement formBttn = PPMRQAPL_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PPMRQAPL_CurrencyLineForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PPMRQAPL_CurrencyLineForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExist on CurrencyLineFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_CurrencyLineFormTable = new SeleniumControl( sDriver, "CurrencyLineFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPL_CurrencyLineFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Close on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_CurrencyLineForm);
IWebElement formBttn = PPMRQAPL_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Approval Process");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Click on ApprovalProcessLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_ApprovalProcessLink = new SeleniumControl( sDriver, "ApprovalProcessLink", "ID", "lnk_1003961_PPMRQAPL_RQLNAPPRVL_HDR");
				Function.WaitControlDisplayed(PPMRQAPL_ApprovalProcessLink);
PPMRQAPL_ApprovalProcessLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on ApprovalProcessForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_ApprovalProcessForm = new SeleniumControl( sDriver, "ApprovalProcessForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPL_RQLNAPPRVL_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPL_ApprovalProcessForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExist on ApprovalProcessFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_ApprovalProcessFormTable = new SeleniumControl( sDriver, "ApprovalProcessFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPL_RQLNAPPRVL_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPL_ApprovalProcessFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing ClickButtonIfExists on ApprovalProcessForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_ApprovalProcessForm = new SeleniumControl( sDriver, "ApprovalProcessForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPL_RQLNAPPRVL_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_ApprovalProcessForm);
IWebElement formBttn = PPMRQAPL_ApprovalProcessForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPL_ApprovalProcessForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPL_ApprovalProcessForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on ApprovalProcess_ApprovalDateTime...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_ApprovalProcess_ApprovalDateTime = new SeleniumControl( sDriver, "ApprovalProcess_ApprovalDateTime", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPL_RQLNAPPRVL_CHILD_']/ancestor::form[1]/descendant::*[@id='APPRVL_DTT']");
				Function.AssertEqual(true,PPMRQAPL_ApprovalProcess_ApprovalDateTime.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Close on ApprovalProcessForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_ApprovalProcessForm = new SeleniumControl( sDriver, "ApprovalProcessForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPL_RQLNAPPRVL_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_ApprovalProcessForm);
IWebElement formBttn = PPMRQAPL_ApprovalProcessForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003968_PPMRQAPL_RQLNAPPRVL_HDR");
				Function.WaitControlDisplayed(PPMRQAPL_ExchangeRatesLink);
PPMRQAPL_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPL_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on ExchangeRate_RateGroup...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_ExchangeRate_RateGroup = new SeleniumControl( sDriver, "ExchangeRate_RateGroup", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='RATE_GRP_ID']");
				Function.AssertEqual(true,PPMRQAPL_ExchangeRate_RateGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_ExchangeRatesForm);
IWebElement formBttn = PPMRQAPL_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("QC Line Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Click on QCLineTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_QCLineTextLink = new SeleniumControl( sDriver, "QCLineTextLink", "ID", "lnk_1004503_PPMRQAPL_RQLNAPPRVL_HDR");
				Function.WaitControlDisplayed(PPMRQAPL_QCLineTextLink);
PPMRQAPL_QCLineTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Account");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Click on AccountsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_AccountsLink = new SeleniumControl( sDriver, "AccountsLink", "ID", "lnk_1003957_PPMRQAPL_RQLNAPPRVL_HDR");
				Function.WaitControlDisplayed(PPMRQAPL_AccountsLink);
PPMRQAPL_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on AccountDistributionForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_AccountDistributionForm = new SeleniumControl( sDriver, "AccountDistributionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPL_RQLNACCT_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPL_AccountDistributionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExist on AccountDistributionTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_AccountDistributionTable = new SeleniumControl( sDriver, "AccountDistributionTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPL_RQLNACCT_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPL_AccountDistributionTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing ClickButton on AccountDistributionForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_AccountDistributionForm = new SeleniumControl( sDriver, "AccountDistributionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPL_RQLNACCT_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_AccountDistributionForm);
IWebElement formBttn = PPMRQAPL_AccountDistributionForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPL_AccountDistributionForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPL_AccountDistributionForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing VerifyExists on AccountDistribution_Account...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_AccountDistribution_Account = new SeleniumControl( sDriver, "AccountDistribution_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPL_RQLNACCT_CHILD_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,PPMRQAPL_AccountDistribution_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Close on AccountDistributionForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_AccountDistributionForm = new SeleniumControl( sDriver, "AccountDistributionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPL_RQLNACCT_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_AccountDistributionForm);
IWebElement formBttn = PPMRQAPL_AccountDistributionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRQAPL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRQAPL_MainForm);
IWebElement formBttn = PPMRQAPL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

