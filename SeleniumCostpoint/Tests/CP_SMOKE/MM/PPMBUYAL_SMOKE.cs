 
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
    public class PPMBUYAL_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Assign Purchase Requisition Lines to Buyers", "xpath","//div[@class='navItem'][.='Assign Purchase Requisition Lines to Buyers']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
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
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMBUYAL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on DefaultAssignmentDate...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_DefaultAssignmentDate = new SeleniumControl( sDriver, "DefaultAssignmentDate", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DEF_ASSIGN_DATE']");
				Function.AssertEqual(true,PPMBUYAL_DefaultAssignmentDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requisition Lines");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExist on RequisitionLines_Table...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_Table = new SeleniumControl( sDriver, "RequisitionLines_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAL_RQLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMBUYAL_RequisitionLines_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on RequisitionLines_Form...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_Form = new SeleniumControl( sDriver, "RequisitionLines_Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAL_RQLN_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMBUYAL_RequisitionLines_Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing ClickButton on RequisitionLines_Form...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_Form = new SeleniumControl( sDriver, "RequisitionLines_Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAL_RQLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAL_RequisitionLines_Form);
IWebElement formBttn = PPMBUYAL_RequisitionLines_Form.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMBUYAL_RequisitionLines_Form.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMBUYAL_RequisitionLines_Form.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requisition Lines Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing Select on RequisitionLines_RequisitionLineDetails_RequisitionLineTab...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_RequisitionLineDetails_RequisitionLineTab = new SeleniumControl( sDriver, "RequisitionLines_RequisitionLineDetails_RequisitionLineTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAL_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMBUYAL_RequisitionLines_RequisitionLineDetails_RequisitionLineTab);
IWebElement mTab = PPMBUYAL_RequisitionLines_RequisitionLineDetails_RequisitionLineTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Requisition Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on RequisitionLines_RequisitionLineDetails_Item...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_RequisitionLineDetails_Item = new SeleniumControl( sDriver, "RequisitionLines_RequisitionLineDetails_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAL_RQLN_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PPMBUYAL_RequisitionLines_RequisitionLineDetails_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing Select on RequisitionLines_RequisitionLineDetails_RequisitionLineTab...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_RequisitionLineDetails_RequisitionLineTab = new SeleniumControl( sDriver, "RequisitionLines_RequisitionLineDetails_RequisitionLineTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAL_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMBUYAL_RequisitionLines_RequisitionLineDetails_RequisitionLineTab);
IWebElement mTab = PPMBUYAL_RequisitionLines_RequisitionLineDetails_RequisitionLineTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on RequisitionLines_CostDetails_EstUnitCost...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_CostDetails_EstUnitCost = new SeleniumControl( sDriver, "RequisitionLines_CostDetails_EstUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAL_RQLN_']/ancestor::form[1]/descendant::*[@id='TRN_NET_UNIT_AMT']");
				Function.AssertEqual(true,PPMBUYAL_RequisitionLines_CostDetails_EstUnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing Select on RequisitionLines_RequisitionLineDetails_RequisitionLineTab...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_RequisitionLineDetails_RequisitionLineTab = new SeleniumControl( sDriver, "RequisitionLines_RequisitionLineDetails_RequisitionLineTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAL_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMBUYAL_RequisitionLines_RequisitionLineDetails_RequisitionLineTab);
IWebElement mTab = PPMBUYAL_RequisitionLines_RequisitionLineDetails_RequisitionLineTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Delivery Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on RequisitionLines_DeliveryInformation_ShipID...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_DeliveryInformation_ShipID = new SeleniumControl( sDriver, "RequisitionLines_DeliveryInformation_ShipID", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAL_RQLN_']/ancestor::form[1]/descendant::*[@id='SHIP_ID']");
				Function.AssertEqual(true,PPMBUYAL_RequisitionLines_DeliveryInformation_ShipID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on RequisitionLines_RequisitionLineDetails_ApprovalProcessLink...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_RequisitionLineDetails_ApprovalProcessLink = new SeleniumControl( sDriver, "RequisitionLines_RequisitionLineDetails_ApprovalProcessLink", "ID", "lnk_1007276_PPMBUYAL_RQLN");
				Function.AssertEqual(true,PPMBUYAL_RequisitionLines_RequisitionLineDetails_ApprovalProcessLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing Click on RequisitionLines_RequisitionLineDetails_ApprovalProcessLink...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_RequisitionLineDetails_ApprovalProcessLink = new SeleniumControl( sDriver, "RequisitionLines_RequisitionLineDetails_ApprovalProcessLink", "ID", "lnk_1007276_PPMBUYAL_RQLN");
				Function.WaitControlDisplayed(PPMBUYAL_RequisitionLines_RequisitionLineDetails_ApprovalProcessLink);
PPMBUYAL_RequisitionLines_RequisitionLineDetails_ApprovalProcessLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExist on RequisitionLines_ApprovalProcess_Table...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_ApprovalProcess_Table = new SeleniumControl( sDriver, "RequisitionLines_ApprovalProcess_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PP_APPRVL_COMMONDISABLED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMBUYAL_RequisitionLines_ApprovalProcess_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on RequisitionLines_ApprovalProcess_Form...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_ApprovalProcess_Form = new SeleniumControl( sDriver, "RequisitionLines_ApprovalProcess_Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PP_APPRVL_COMMONDISABLED_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMBUYAL_RequisitionLines_ApprovalProcess_Form.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing ClickButton on RequisitionLines_ApprovalProcess_Form...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_ApprovalProcess_Form = new SeleniumControl( sDriver, "RequisitionLines_ApprovalProcess_Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PP_APPRVL_COMMONDISABLED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAL_RequisitionLines_ApprovalProcess_Form);
IWebElement formBttn = PPMBUYAL_RequisitionLines_ApprovalProcess_Form.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMBUYAL_RequisitionLines_ApprovalProcess_Form.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMBUYAL_RequisitionLines_ApprovalProcess_Form.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on RequisitionLines_ApprovalProcess_ApprovalRevision...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_ApprovalProcess_ApprovalRevision = new SeleniumControl( sDriver, "RequisitionLines_ApprovalProcess_ApprovalRevision", "xpath", "//div[translate(@id,'0123456789','')='pr__PP_APPRVL_COMMONDISABLED_']/ancestor::form[1]/descendant::*[@id='RVSN_NO']");
				Function.AssertEqual(true,PPMBUYAL_RequisitionLines_ApprovalProcess_ApprovalRevision.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing Close on RequisitionLines_ApprovalProcess_Form...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_ApprovalProcess_Form = new SeleniumControl( sDriver, "RequisitionLines_ApprovalProcess_Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PP_APPRVL_COMMONDISABLED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAL_RequisitionLines_ApprovalProcess_Form);
IWebElement formBttn = PPMBUYAL_RequisitionLines_ApprovalProcess_Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on RequisitionLines_RequisitionLineDetails_HdrDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_RequisitionLineDetails_HdrDocumentsLink = new SeleniumControl( sDriver, "RequisitionLines_RequisitionLineDetails_HdrDocumentsLink", "ID", "lnk_1007760_PPMBUYAL_RQLN");
				Function.AssertEqual(true,PPMBUYAL_RequisitionLines_RequisitionLineDetails_HdrDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing Click on RequisitionLines_RequisitionLineDetails_HdrDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_RequisitionLineDetails_HdrDocumentsLink = new SeleniumControl( sDriver, "RequisitionLines_RequisitionLineDetails_HdrDocumentsLink", "ID", "lnk_1007760_PPMBUYAL_RQLN");
				Function.WaitControlDisplayed(PPMBUYAL_RequisitionLines_RequisitionLineDetails_HdrDocumentsLink);
PPMBUYAL_RequisitionLines_RequisitionLineDetails_HdrDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExist on HdrDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_HdrDocumentsTable = new SeleniumControl( sDriver, "HdrDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMBUYAL_HdrDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_HdrDocumentsForm = new SeleniumControl( sDriver, "HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMBUYAL_HdrDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing ClickButton on HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_HdrDocumentsForm = new SeleniumControl( sDriver, "HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAL_HdrDocumentsForm);
IWebElement formBttn = PPMBUYAL_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMBUYAL_HdrDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMBUYAL_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on HdrDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_HdrDocuments_Document = new SeleniumControl( sDriver, "HdrDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPMBUYAL_HdrDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing Close on HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_HdrDocumentsForm = new SeleniumControl( sDriver, "HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAL_HdrDocumentsForm);
IWebElement formBttn = PPMBUYAL_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on RequisitionLines_RequisitionLineDetails_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_RequisitionLineDetails_LineDocumentsLink = new SeleniumControl( sDriver, "RequisitionLines_RequisitionLineDetails_LineDocumentsLink", "ID", "lnk_1007754_PPMBUYAL_RQLN");
				Function.AssertEqual(true,PPMBUYAL_RequisitionLines_RequisitionLineDetails_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing Click on RequisitionLines_RequisitionLineDetails_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_RequisitionLines_RequisitionLineDetails_LineDocumentsLink = new SeleniumControl( sDriver, "RequisitionLines_RequisitionLineDetails_LineDocumentsLink", "ID", "lnk_1007754_PPMBUYAL_RQLN");
				Function.WaitControlDisplayed(PPMBUYAL_RequisitionLines_RequisitionLineDetails_LineDocumentsLink);
PPMBUYAL_RequisitionLines_RequisitionLineDetails_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExist on LineDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_LineDocumentsTable = new SeleniumControl( sDriver, "LineDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMBUYAL_LineDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMBUYAL_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing ClickButton on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAL_LineDocumentsForm);
IWebElement formBttn = PPMBUYAL_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMBUYAL_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMBUYAL_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing VerifyExists on LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_LineDocuments_Document = new SeleniumControl( sDriver, "LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPMBUYAL_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing Close on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAL_LineDocumentsForm);
IWebElement formBttn = PPMBUYAL_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMBUYAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMBUYAL_MainForm);
IWebElement formBttn = PPMBUYAL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

