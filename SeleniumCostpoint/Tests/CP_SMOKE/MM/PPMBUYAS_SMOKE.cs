 
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
    public class PPMBUYAS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Assign Purchase Requisitions to Buyers", "xpath","//div[@class='navItem'][.='Assign Purchase Requisitions to Buyers']").Click();


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
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMBUYAS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on DefaultAssignmentDate...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_DefaultAssignmentDate = new SeleniumControl( sDriver, "DefaultAssignmentDate", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DEFAULT_ASSIGNMENT_DATE']");
				Function.AssertEqual(true,PPMBUYAS_DefaultAssignmentDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Details");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExist on DetailsTable...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_DetailsTable = new SeleniumControl( sDriver, "DetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQHDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMBUYAS_DetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on DetailsForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_DetailsForm = new SeleniumControl( sDriver, "DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMBUYAS_DetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing ClickButton on DetailsForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_DetailsForm = new SeleniumControl( sDriver, "DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAS_DetailsForm);
IWebElement formBttn = PPMBUYAS_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMBUYAS_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMBUYAS_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on Details_Requisition...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_Details_Requisition = new SeleniumControl( sDriver, "Details_Requisition", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQHDR_']/ancestor::form[1]/descendant::*[@id='RQ_ID']");
				Function.AssertEqual(true,PPMBUYAS_Details_Requisition.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing ClickButtonIfExists on DetailsForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_DetailsForm = new SeleniumControl( sDriver, "DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAS_DetailsForm);
IWebElement formBttn = PPMBUYAS_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Next']")).Count <= 0 ? PPMBUYAS_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Next')]")).FirstOrDefault() :
PPMBUYAS_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(@title,'Next')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Next] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
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
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on Details_ApprovalProcessLink...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_Details_ApprovalProcessLink = new SeleniumControl( sDriver, "Details_ApprovalProcessLink", "ID", "lnk_1007277_PPMBUYAS_RQHDR");
				Function.AssertEqual(true,PPMBUYAS_Details_ApprovalProcessLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing Click on Details_ApprovalProcessLink...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_Details_ApprovalProcessLink = new SeleniumControl( sDriver, "Details_ApprovalProcessLink", "ID", "lnk_1007277_PPMBUYAS_RQHDR");
				Function.WaitControlDisplayed(PPMBUYAS_Details_ApprovalProcessLink);
PPMBUYAS_Details_ApprovalProcessLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExist on ApprovalProcessTable...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_ApprovalProcessTable = new SeleniumControl( sDriver, "ApprovalProcessTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PP_APPRVL_COMMONDISABLED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMBUYAS_ApprovalProcessTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on ApprovalProcessForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_ApprovalProcessForm = new SeleniumControl( sDriver, "ApprovalProcessForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PP_APPRVL_COMMONDISABLED_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMBUYAS_ApprovalProcessForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing ClickButton on ApprovalProcessForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_ApprovalProcessForm = new SeleniumControl( sDriver, "ApprovalProcessForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PP_APPRVL_COMMONDISABLED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAS_ApprovalProcessForm);
IWebElement formBttn = PPMBUYAS_ApprovalProcessForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMBUYAS_ApprovalProcessForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMBUYAS_ApprovalProcessForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on ApprovalProcess_ApprovalRevision...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_ApprovalProcess_ApprovalRevision = new SeleniumControl( sDriver, "ApprovalProcess_ApprovalRevision", "xpath", "//div[translate(@id,'0123456789','')='pr__PP_APPRVL_COMMONDISABLED_']/ancestor::form[1]/descendant::*[@id='RVSN_NO']");
				Function.AssertEqual(true,PPMBUYAS_ApprovalProcess_ApprovalRevision.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing Close on ApprovalProcessForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_ApprovalProcessForm = new SeleniumControl( sDriver, "ApprovalProcessForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PP_APPRVL_COMMONDISABLED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAS_ApprovalProcessForm);
IWebElement formBttn = PPMBUYAS_ApprovalProcessForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assign Lines");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on Details_AssignLinesLink...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_Details_AssignLinesLink = new SeleniumControl( sDriver, "Details_AssignLinesLink", "ID", "lnk_1007262_PPMBUYAS_RQHDR");
				Function.AssertEqual(true,PPMBUYAS_Details_AssignLinesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing Click on Details_AssignLinesLink...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_Details_AssignLinesLink = new SeleniumControl( sDriver, "Details_AssignLinesLink", "ID", "lnk_1007262_PPMBUYAS_RQHDR");
				Function.WaitControlDisplayed(PPMBUYAS_Details_AssignLinesLink);
PPMBUYAS_Details_AssignLinesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExist on AssignLinesTable...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_AssignLinesTable = new SeleniumControl( sDriver, "AssignLinesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQLN_ASSIGNLINES_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMBUYAS_AssignLinesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on AssignLinesForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_AssignLinesForm = new SeleniumControl( sDriver, "AssignLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQLN_ASSIGNLINES_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMBUYAS_AssignLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing ClickButton on AssignLinesForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_AssignLinesForm = new SeleniumControl( sDriver, "AssignLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQLN_ASSIGNLINES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAS_AssignLinesForm);
IWebElement formBttn = PPMBUYAS_AssignLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMBUYAS_AssignLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMBUYAS_AssignLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assign Lines Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing Select on AssignLinesTab...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_AssignLinesTab = new SeleniumControl( sDriver, "AssignLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQLN_ASSIGNLINES_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMBUYAS_AssignLinesTab);
IWebElement mTab = PPMBUYAS_AssignLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Requisition Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on AssignLines_RequisitionLineDetails_LineStatus...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_AssignLines_RequisitionLineDetails_LineStatus = new SeleniumControl( sDriver, "AssignLines_RequisitionLineDetails_LineStatus", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQLN_ASSIGNLINES_']/ancestor::form[1]/descendant::*[@id='S_RQ_STATUS_CD']");
				Function.AssertEqual(true,PPMBUYAS_AssignLines_RequisitionLineDetails_LineStatus.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing Select on AssignLinesTab...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_AssignLinesTab = new SeleniumControl( sDriver, "AssignLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQLN_ASSIGNLINES_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMBUYAS_AssignLinesTab);
IWebElement mTab = PPMBUYAS_AssignLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on AssignLines_CostDetails_EstUnitCost...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_AssignLines_CostDetails_EstUnitCost = new SeleniumControl( sDriver, "AssignLines_CostDetails_EstUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQLN_ASSIGNLINES_']/ancestor::form[1]/descendant::*[@id='TRN_NET_UNIT_AMT']");
				Function.AssertEqual(true,PPMBUYAS_AssignLines_CostDetails_EstUnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing Select on AssignLinesTab...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_AssignLinesTab = new SeleniumControl( sDriver, "AssignLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQLN_ASSIGNLINES_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMBUYAS_AssignLinesTab);
IWebElement mTab = PPMBUYAS_AssignLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Delivery Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on AssignLines_DeliveryInfo_ShipID...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_AssignLines_DeliveryInfo_ShipID = new SeleniumControl( sDriver, "AssignLines_DeliveryInfo_ShipID", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQLN_ASSIGNLINES_']/ancestor::form[1]/descendant::*[@id='SHIP_ID']");
				Function.AssertEqual(true,PPMBUYAS_AssignLines_DeliveryInfo_ShipID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing Close on AssignLinesForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_AssignLinesForm = new SeleniumControl( sDriver, "AssignLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMBUYAS_RQLN_ASSIGNLINES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAS_AssignLinesForm);
IWebElement formBttn = PPMBUYAS_AssignLinesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on Details_HdrDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_Details_HdrDocumentsLink = new SeleniumControl( sDriver, "Details_HdrDocumentsLink", "ID", "lnk_1007785_PPMBUYAS_RQHDR");
				Function.AssertEqual(true,PPMBUYAS_Details_HdrDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing Click on Details_HdrDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_Details_HdrDocumentsLink = new SeleniumControl( sDriver, "Details_HdrDocumentsLink", "ID", "lnk_1007785_PPMBUYAS_RQHDR");
				Function.WaitControlDisplayed(PPMBUYAS_Details_HdrDocumentsLink);
PPMBUYAS_Details_HdrDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExist on HdrDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_HdrDocumentsTable = new SeleniumControl( sDriver, "HdrDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMBUYAS_HdrDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_HdrDocumentsForm = new SeleniumControl( sDriver, "HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMBUYAS_HdrDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing ClickButton on HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_HdrDocumentsForm = new SeleniumControl( sDriver, "HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAS_HdrDocumentsForm);
IWebElement formBttn = PPMBUYAS_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMBUYAS_HdrDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMBUYAS_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing VerifyExists on HdrDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_HdrDocuments_Document = new SeleniumControl( sDriver, "HdrDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPMBUYAS_HdrDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing Close on HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_HdrDocumentsForm = new SeleniumControl( sDriver, "HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMBUYAS_HdrDocumentsForm);
IWebElement formBttn = PPMBUYAS_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMBUYAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMBUYAS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMBUYAS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMBUYAS_MainForm);
IWebElement formBttn = PPMBUYAS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

