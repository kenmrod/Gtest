 
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
    public class RCMINSP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Receiving", "xpath","//div[@class='deptItem'][.='Receiving']").Click();
new SeleniumControl(sDriver,"Receiving", "xpath","//div[@class='navItem'][.='Receiving']").Click();
new SeleniumControl(sDriver,"Manage Quality Control Inspections", "xpath","//div[@class='navItem'][.='Manage Quality Control Inspections']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,RCMINSP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on MainForm_Identification_Warehouse...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_MainForm_Identification_Warehouse = new SeleniumControl( sDriver, "MainForm_Identification_Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,RCMINSP_MainForm_Identification_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RCMINSP_MainForm);
IWebElement formBttn = RCMINSP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? RCMINSP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
RCMINSP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMINSP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RCMINSP_MainForm);
IWebElement formBttn = RCMINSP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMINSP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMINSP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POHEADERDOCUMENTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Click on MainForm_POHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_MainForm_POHeaderDocumentsLink = new SeleniumControl( sDriver, "MainForm_POHeaderDocumentsLink", "id", "lnk_1007809_RCMINSP_INSPHDR_QCINSPECTIONS");
				Function.WaitControlDisplayed(RCMINSP_MainForm_POHeaderDocumentsLink);
RCMINSP_MainForm_POHeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on POHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POHeaderDocumentsForm = new SeleniumControl( sDriver, "POHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_PODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMINSP_POHeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on POHeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POHeaderDocuments_Document = new SeleniumControl( sDriver, "POHeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,RCMINSP_POHeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing ClickButton on POHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POHeaderDocumentsForm = new SeleniumControl( sDriver, "POHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_POHeaderDocumentsForm);
IWebElement formBttn = RCMINSP_POHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? RCMINSP_POHeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
RCMINSP_POHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExist on POHeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POHeaderDocumentsTable = new SeleniumControl( sDriver, "POHeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMINSP_POHeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Close on POHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POHeaderDocumentsForm = new SeleniumControl( sDriver, "POHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_POHeaderDocumentsForm);
IWebElement formBttn = RCMINSP_POHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLN_INSPDETAILS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMINSP_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLN_INSPDETAILS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_ChildForm);
IWebElement formBttn = RCMINSP_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMINSP_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMINSP_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLN_INSPDETAILS_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMINSP_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on ChildForm_POLine...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm_POLine = new SeleniumControl( sDriver, "ChildForm_POLine", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLN_INSPDETAILS_']/ancestor::form[1]/descendant::*[@id='PO_LN_NO']");
				Function.AssertEqual(true,RCMINSP_ChildForm_POLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLN_INSPDETAILS_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_ChildFormTab);
IWebElement mTab = RCMINSP_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "QC Inspection Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on ChildForm_QCInspectionDetails_InspectionReportID...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm_QCInspectionDetails_InspectionReportID = new SeleniumControl( sDriver, "ChildForm_QCInspectionDetails_InspectionReportID", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLN_INSPDETAILS_']/ancestor::form[1]/descendant::*[@id='INSP_RPT_ID']");
				Function.AssertEqual(true,RCMINSP_ChildForm_QCInspectionDetails_InspectionReportID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLN_INSPDETAILS_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_ChildFormTab);
IWebElement mTab = RCMINSP_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Rejections").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on ChildForm_Rejections_RejectedQtyInvUM...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm_Rejections_RejectedQtyInvUM = new SeleniumControl( sDriver, "ChildForm_Rejections_RejectedQtyInvUM", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLN_INSPDETAILS_']/ancestor::form[1]/descendant::*[@id='REJ_QTY_INV']");
				Function.AssertEqual(true,RCMINSP_ChildForm_Rejections_RejectedQtyInvUM.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLN_INSPDETAILS_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_ChildFormTab);
IWebElement mTab = RCMINSP_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "PO Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on ChildForm_POLineDetails_QCInspectionReqd...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm_POLineDetails_QCInspectionReqd = new SeleniumControl( sDriver, "ChildForm_POLineDetails_QCInspectionReqd", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLN_INSPDETAILS_']/ancestor::form[1]/descendant::*[@id='QC_REQD_FL_RC']");
				Function.AssertEqual(true,RCMINSP_ChildForm_POLineDetails_QCInspectionReqd.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLN_INSPDETAILS_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_ChildFormTab);
IWebElement mTab = RCMINSP_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Inspection Line Notes").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("REJECTIONINFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Click on ChildForm_RejectionInfoLink...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm_RejectionInfoLink = new SeleniumControl( sDriver, "ChildForm_RejectionInfoLink", "ID", "lnk_1004107_RCMINSP_INSPLN_INSPDETAILS");
				Function.WaitControlDisplayed(RCMINSP_ChildForm_RejectionInfoLink);
RCMINSP_ChildForm_RejectionInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExist on RejectionInfoTable...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_RejectionInfoTable = new SeleniumControl( sDriver, "RejectionInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLNREJ_REJECTIONINF_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMINSP_RejectionInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing ClickButton on RejectionInfoForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_RejectionInfoForm = new SeleniumControl( sDriver, "RejectionInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLNREJ_REJECTIONINF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_RejectionInfoForm);
IWebElement formBttn = RCMINSP_RejectionInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMINSP_RejectionInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMINSP_RejectionInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on RejectionInfoForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_RejectionInfoForm = new SeleniumControl( sDriver, "RejectionInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLNREJ_REJECTIONINF_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMINSP_RejectionInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on RejectionInfo_RejectedQtyPOUM...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_RejectionInfo_RejectedQtyPOUM = new SeleniumControl( sDriver, "RejectionInfo_RejectedQtyPOUM", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLNREJ_REJECTIONINF_']/ancestor::form[1]/descendant::*[@id='REJ_QTY']");
				Function.AssertEqual(true,RCMINSP_RejectionInfo_RejectedQtyPOUM.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Close on RejectionInfoForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_RejectionInfoForm = new SeleniumControl( sDriver, "RejectionInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_INSPLNREJ_REJECTIONINF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_RejectionInfoForm);
IWebElement formBttn = RCMINSP_RejectionInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SERIAL/LOTINFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Click on ChildForm_SerialLotInfoLink...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm_SerialLotInfoLink = new SeleniumControl( sDriver, "ChildForm_SerialLotInfoLink", "ID", "lnk_1004108_RCMINSP_INSPLN_INSPDETAILS");
				Function.WaitControlDisplayed(RCMINSP_ChildForm_SerialLotInfoLink);
RCMINSP_ChildForm_SerialLotInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExist on SerialLotInfoTable...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfoTable = new SeleniumControl( sDriver, "SerialLotInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMINSP_SerialLotInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing ClickButton on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_SerialLotInfoForm);
IWebElement formBttn = RCMINSP_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMINSP_SerialLotInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMINSP_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMINSP_SerialLotInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on SerialLotInfo_SerialNumber...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfo_SerialNumber = new SeleniumControl( sDriver, "SerialLotInfo_SerialNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='SERIAL_ID']");
				Function.AssertEqual(true,RCMINSP_SerialLotInfo_SerialNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfoTab = new SeleniumControl( sDriver, "SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_SerialLotInfoTab);
IWebElement mTab = RCMINSP_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on SerialLotInfo_BasicInformation_ReceiptQuantity...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfo_BasicInformation_ReceiptQuantity = new SeleniumControl( sDriver, "SerialLotInfo_BasicInformation_ReceiptQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='TRN_QTY']");
				Function.AssertEqual(true,RCMINSP_SerialLotInfo_BasicInformation_ReceiptQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfoTab = new SeleniumControl( sDriver, "SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_SerialLotInfoTab);
IWebElement mTab = RCMINSP_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manufacturer/Vendor Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer = new SeleniumControl( sDriver, "SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,RCMINSP_SerialLotInfo_ManufacturerVendorInformation_Manufacturer_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfoTab = new SeleniumControl( sDriver, "SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_SerialLotInfoTab);
IWebElement mTab = RCMINSP_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Sales Order/Warranty Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder = new SeleniumControl( sDriver, "SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='MAINT_SO_ID']");
				Function.AssertEqual(true,RCMINSP_SerialLotInfo_SalesOrderWarrantyInformation_SalesOrderInformation_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfoTab = new SeleniumControl( sDriver, "SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_SerialLotInfoTab);
IWebElement mTab = RCMINSP_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "User-Defined Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on SerialLotInfo_UID_UIDDetails_UID...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfo_UID_UIDDetails_UID = new SeleniumControl( sDriver, "SerialLotInfo_UID_UIDDetails_UID", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='UID_CD']");
				Function.AssertEqual(false,RCMINSP_SerialLotInfo_UID_UIDDetails_UID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfoTab = new SeleniumControl( sDriver, "SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_SerialLotInfoTab);
IWebElement mTab = RCMINSP_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on SerialLotInfo_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfo_Notes_Notes = new SeleniumControl( sDriver, "SerialLotInfo_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='NOTES_NT']");
				Function.AssertEqual(true,RCMINSP_SerialLotInfo_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on SerialLotInfoTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfoTab = new SeleniumControl( sDriver, "SerialLotInfoTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_SerialLotInfoTab);
IWebElement mTab = RCMINSP_SerialLotInfoTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shelf Life").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType = new SeleniumControl( sDriver, "ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]/descendant::*[@id='S_SHELF_LIFE_TYPE']");
				Function.AssertEqual(true,RCMINSP_ChildForm_SerialLotInfo_ShelfLife_ShelfLife_ShelfLifeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Close on SerialLotInfoForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_SerialLotInfoForm = new SeleniumControl( sDriver, "SerialLotInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSRLT_INVTTRNLNSRLT_COMMON_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_SerialLotInfoForm);
IWebElement formBttn = RCMINSP_SerialLotInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("FIXEDASSETS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Click on ChildForm_FixedAssetsLink...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm_FixedAssetsLink = new SeleniumControl( sDriver, "ChildForm_FixedAssetsLink", "ID", "lnk_1004109_RCMINSP_INSPLN_INSPDETAILS");
				Function.WaitControlDisplayed(RCMINSP_ChildForm_FixedAssetsLink);
RCMINSP_ChildForm_FixedAssetsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExist on FixedAssetsTable...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_FixedAssetsTable = new SeleniumControl( sDriver, "FixedAssetsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMINSP_FixedAssetsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing ClickButton on FixedAssetsForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_FixedAssetsForm = new SeleniumControl( sDriver, "FixedAssetsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_FixedAssetsForm);
IWebElement formBttn = RCMINSP_FixedAssetsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMINSP_FixedAssetsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMINSP_FixedAssetsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on FixedAssetsForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_FixedAssetsForm = new SeleniumControl( sDriver, "FixedAssetsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMINSP_FixedAssetsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on FixedAssetsTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_FixedAssetsTab = new SeleniumControl( sDriver, "FixedAssetsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_FixedAssetsTab);
IWebElement mTab = RCMINSP_FixedAssetsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Desc/Purch Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on FixedAssets_DescPurchInfo_PurchaseInformation_UnitOfMeasure...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_FixedAssets_DescPurchInfo_PurchaseInformation_UnitOfMeasure = new SeleniumControl( sDriver, "FixedAssets_DescPurchInfo_PurchaseInformation_UnitOfMeasure", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='UM_S']");
				Function.AssertEqual(true,RCMINSP_FixedAssets_DescPurchInfo_PurchaseInformation_UnitOfMeasure.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on FixedAssetsTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_FixedAssetsTab = new SeleniumControl( sDriver, "FixedAssetsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_FixedAssetsTab);
IWebElement mTab = RCMINSP_FixedAssetsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Location Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on FixedAssets_LocationInfo_LocationGroupInfo_LocationGroup...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_FixedAssets_LocationInfo_LocationGroupInfo_LocationGroup = new SeleniumControl( sDriver, "FixedAssets_LocationInfo_LocationGroupInfo_LocationGroup", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='FA_LOC_GRP_CD']");
				Function.AssertEqual(true,RCMINSP_FixedAssets_LocationInfo_LocationGroupInfo_LocationGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on FixedAssetsTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_FixedAssetsTab = new SeleniumControl( sDriver, "FixedAssetsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_FixedAssetsTab);
IWebElement mTab = RCMINSP_FixedAssetsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Govt Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on FixedAssets_GovtInfo_TagNo...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_FixedAssets_GovtInfo_TagNo = new SeleniumControl( sDriver, "FixedAssets_GovtInfo_TagNo", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='TAG_NO_S']");
				Function.AssertEqual(true,RCMINSP_FixedAssets_GovtInfo_TagNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Select on FixedAssetsTab...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_FixedAssetsTab = new SeleniumControl( sDriver, "FixedAssetsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(RCMINSP_FixedAssetsTab);
IWebElement mTab = RCMINSP_FixedAssetsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "UID").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on FixedAssets_UID_UIDDetails_UID...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_FixedAssets_UID_UIDDetails_UID = new SeleniumControl( sDriver, "FixedAssets_UID_UIDDetails_UID", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]/descendant::*[@id='UID_CD']");
				Function.AssertEqual(true,RCMINSP_FixedAssets_UID_UIDDetails_UID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Close on FixedAssetsForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_FixedAssetsForm = new SeleniumControl( sDriver, "FixedAssetsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMAUTOC_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_FixedAssetsForm);
IWebElement formBttn = RCMINSP_FixedAssetsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ACCOUNTDISTRIBUTION");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Click on ChildForm_AccountDistributionLink...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm_AccountDistributionLink = new SeleniumControl( sDriver, "ChildForm_AccountDistributionLink", "ID", "lnk_1004110_RCMINSP_INSPLN_INSPDETAILS");
				Function.WaitControlDisplayed(RCMINSP_ChildForm_AccountDistributionLink);
RCMINSP_ChildForm_AccountDistributionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExist on AccountDistributionTable...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_AccountDistributionTable = new SeleniumControl( sDriver, "AccountDistributionTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_POLNACCT_ACCTDISTRIBUT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMINSP_AccountDistributionTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing ClickButton on AccountDistributionForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_AccountDistributionForm = new SeleniumControl( sDriver, "AccountDistributionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_POLNACCT_ACCTDISTRIBUT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_AccountDistributionForm);
IWebElement formBttn = RCMINSP_AccountDistributionForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMINSP_AccountDistributionForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMINSP_AccountDistributionForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on AccountDistributionForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_AccountDistributionForm = new SeleniumControl( sDriver, "AccountDistributionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_POLNACCT_ACCTDISTRIBUT_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMINSP_AccountDistributionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on AccountDistribution_Project...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_AccountDistribution_Project = new SeleniumControl( sDriver, "AccountDistribution_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_POLNACCT_ACCTDISTRIBUT_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,RCMINSP_AccountDistribution_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Close on AccountDistributionForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_AccountDistributionForm = new SeleniumControl( sDriver, "AccountDistributionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_POLNACCT_ACCTDISTRIBUT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_AccountDistributionForm);
IWebElement formBttn = RCMINSP_AccountDistributionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POLINETEXT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Click on ChildForm_POLineTextLink...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm_POLineTextLink = new SeleniumControl( sDriver, "ChildForm_POLineTextLink", "ID", "lnk_1004111_RCMINSP_INSPLN_INSPDETAILS");
				Function.WaitControlDisplayed(RCMINSP_ChildForm_POLineTextLink);
RCMINSP_ChildForm_POLineTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExist on POLineTextTable...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POLineTextTable = new SeleniumControl( sDriver, "POLineTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_POLNTEXT_POLINESTDTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMINSP_POLineTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing ClickButton on POLineTextForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POLineTextForm = new SeleniumControl( sDriver, "POLineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_POLNTEXT_POLINESTDTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_POLineTextForm);
IWebElement formBttn = RCMINSP_POLineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMINSP_POLineTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMINSP_POLineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on POLineTextForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POLineTextForm = new SeleniumControl( sDriver, "POLineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_POLNTEXT_POLINESTDTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMINSP_POLineTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on POLineText_TextCode...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POLineText_TextCode = new SeleniumControl( sDriver, "POLineText_TextCode", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_POLNTEXT_POLINESTDTEXT_']/ancestor::form[1]/descendant::*[@id='TEXT_CD']");
				Function.AssertEqual(true,RCMINSP_POLineText_TextCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Close on POLineTextForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POLineTextForm = new SeleniumControl( sDriver, "POLineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCMINSP_POLNTEXT_POLINESTDTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_POLineTextForm);
IWebElement formBttn = RCMINSP_POLineTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POLINEDOCUMENTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Click on ChildForm_POLineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm_POLineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_POLineDocumentsLink", "ID", "lnk_1007808_RCMINSP_INSPLN_INSPDETAILS");
				Function.WaitControlDisplayed(RCMINSP_ChildForm_POLineDocumentsLink);
RCMINSP_ChildForm_POLineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on POLineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POLineDocumentsForm = new SeleniumControl( sDriver, "POLineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMINSP_POLineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on POLineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POLineDocuments_Document = new SeleniumControl( sDriver, "POLineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,RCMINSP_POLineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing ClickButton on POLineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POLineDocumentsForm = new SeleniumControl( sDriver, "POLineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_POLineDocumentsForm);
IWebElement formBttn = RCMINSP_POLineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? RCMINSP_POLineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
RCMINSP_POLineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExist on POLineDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POLineDocumentsTable = new SeleniumControl( sDriver, "POLineDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMINSP_POLineDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Close on POLineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_POLineDocumentsForm = new SeleniumControl( sDriver, "POLineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RCM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_POLineDocumentsForm);
IWebElement formBttn = RCMINSP_POLineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PARTDOCUMENTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Click on ChildForm_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm_PartDocumentsLink = new SeleniumControl( sDriver, "ChildForm_PartDocumentsLink", "ID", "lnk_1004112_RCMINSP_INSPLN_INSPDETAILS");
				Function.WaitControlDisplayed(RCMINSP_ChildForm_PartDocumentsLink);
RCMINSP_ChildForm_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExist on PartDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_PartDocumentsTable = new SeleniumControl( sDriver, "PartDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMINSP_PartDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_PartDocumentsForm);
IWebElement formBttn = RCMINSP_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMINSP_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMINSP_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMINSP_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on PartDocuments_Type...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_PartDocuments_Type = new SeleniumControl( sDriver, "PartDocuments_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOC_TYPE_CD']");
				Function.AssertEqual(true,RCMINSP_PartDocuments_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_PartDocumentsForm);
IWebElement formBttn = RCMINSP_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("BACKORDERS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Click on ChildForm_BackOrdersLink...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_ChildForm_BackOrdersLink = new SeleniumControl( sDriver, "ChildForm_BackOrdersLink", "ID", "lnk_2905_RCMINSP_INSPLN_INSPDETAILS");
				Function.WaitControlDisplayed(RCMINSP_ChildForm_BackOrdersLink);
RCMINSP_ChildForm_BackOrdersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExist on BackOrdersTable...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_BackOrdersTable = new SeleniumControl( sDriver, "BackOrdersTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RCMINSP_BackOrdersTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing ClickButton on BackOrdersForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_BackOrdersForm = new SeleniumControl( sDriver, "BackOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_BackOrdersForm);
IWebElement formBttn = RCMINSP_BackOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RCMINSP_BackOrdersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RCMINSP_BackOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on BackOrdersForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_BackOrdersForm = new SeleniumControl( sDriver, "BackOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,RCMINSP_BackOrdersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing VerifyExists on BackOrders_NeedDate...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_BackOrders_NeedDate = new SeleniumControl( sDriver, "BackOrders_NeedDate", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]/descendant::*[@id='NEED_DT']");
				Function.AssertEqual(true,RCMINSP_BackOrders_NeedDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Close on BackOrdersForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_BackOrdersForm = new SeleniumControl( sDriver, "BackOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGBKORD_RESLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RCMINSP_BackOrdersForm);
IWebElement formBttn = RCMINSP_BackOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RCMINSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RCMINSP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl RCMINSP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RCMINSP_MainForm);
IWebElement formBttn = RCMINSP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

