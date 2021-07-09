 
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
    public class OEQSTAT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Sales Order Entry", "xpath","//div[@class='deptItem'][.='Sales Order Entry']").Click();
new SeleniumControl(sDriver,"Sales Order Entry Reports/Inquiries", "xpath","//div[@class='navItem'][.='Sales Order Entry Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Sales Order Status Information", "xpath","//div[@class='navItem'][.='View Sales Order Status Information']").Click();


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
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEQSTAT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,OEQSTAT_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Execute.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
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
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOHDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEQSTAT_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing ClickButtonIfExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm);
IWebElement formBttn = OEQSTAT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEQSTAT_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEQSTAT_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEQSTAT_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrder = new SeleniumControl( sDriver, "ChildForm_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOHDR_']/ancestor::form[1]/descendant::*[@id='SO_ID']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("HEADER DETAIL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm);
IWebElement formBttn = OEQSTAT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? OEQSTAT_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
OEQSTAT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitControlDisplayed(new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel"));
Function.AssertEqual("Sales Order Status Inquiry Details", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Sales  Order']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'begins with']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='P020507-20']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("P020507-20");}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SetSearchCriterion]" , ex.Message));
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
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SOHeaderTextLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SOHeaderTextLink = new SeleniumControl( sDriver, "ChildForm_SOHeaderTextLink", "ID", "lnk_19935_OEQSTAT_SOHDR");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SOHeaderTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Click on ChildForm_SOHeaderTextLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SOHeaderTextLink = new SeleniumControl( sDriver, "ChildForm_SOHeaderTextLink", "ID", "lnk_19935_OEQSTAT_SOHDR");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SOHeaderTextLink);
OEQSTAT_ChildForm_SOHeaderTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExist on SOHeaderTextFormTable...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_SOHeaderTextFormTable = new SeleniumControl( sDriver, "SOHeaderTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_STDTEXT_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEQSTAT_SOHeaderTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on SOHeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_SOHeaderTextForm = new SeleniumControl( sDriver, "SOHeaderTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_STDTEXT_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEQSTAT_SOHeaderTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Close on SOHeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_SOHeaderTextForm = new SeleniumControl( sDriver, "SOHeaderTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_STDTEXT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_SOHeaderTextForm);
IWebElement formBttn = OEQSTAT_SOHeaderTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SALES ORDER APPROVALS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrderApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderApprovalsLink = new SeleniumControl( sDriver, "ChildForm_SalesOrderApprovalsLink", "ID", "lnk_1005481_OEQSTAT_SOHDR");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderApprovalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Click on ChildForm_SalesOrderApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderApprovalsLink = new SeleniumControl( sDriver, "ChildForm_SalesOrderApprovalsLink", "ID", "lnk_1005481_OEQSTAT_SOHDR");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderApprovalsLink);
OEQSTAT_ChildForm_SalesOrderApprovalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExist on ChildForm_SalesOrderApprovalsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderApprovalsFormTable = new SeleniumControl( sDriver, "ChildForm_SalesOrderApprovalsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOHDRAPPRVL_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderApprovalsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing ClickButton on ChildForm_SalesOrderApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderApprovalsForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOHDRAPPRVL_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderApprovalsForm);
IWebElement formBttn = OEQSTAT_ChildForm_SalesOrderApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEQSTAT_ChildForm_SalesOrderApprovalsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEQSTAT_ChildForm_SalesOrderApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrderApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderApprovalsForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOHDRAPPRVL_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderApprovalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrderApprovals_Seq...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderApprovals_Seq = new SeleniumControl( sDriver, "ChildForm_SalesOrderApprovals_Seq", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOHDRAPPRVL_HDR_']/ancestor::form[1]/descendant::*[@id='APPRVL_SEQ_NO']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderApprovals_Seq.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Close on ChildForm_SalesOrderApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderApprovalsForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOHDRAPPRVL_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderApprovalsForm);
IWebElement formBttn = OEQSTAT_ChildForm_SalesOrderApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SALES ORDER LINES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrderLinesLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLinesLink = new SeleniumControl( sDriver, "ChildForm_SalesOrderLinesLink", "ID", "lnk_1005497_OEQSTAT_SOHDR");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderLinesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Click on ChildForm_SalesOrderLinesLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLinesLink = new SeleniumControl( sDriver, "ChildForm_SalesOrderLinesLink", "ID", "lnk_1005497_OEQSTAT_SOHDR");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLinesLink);
OEQSTAT_ChildForm_SalesOrderLinesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm);
IWebElement formBttn = OEQSTAT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Minimize']")).Count <= 0 ? OEQSTAT_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Minimize')]")).FirstOrDefault() :
OEQSTAT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Minimize']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Minimize not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExist on ChildForm_SalesOrderLinesFormTable...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLinesFormTable = new SeleniumControl( sDriver, "ChildForm_SalesOrderLinesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderLinesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrderLinesForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLinesForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing ClickButtonIfExists on ChildForm_SalesOrderLinesForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLinesForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLinesForm);
IWebElement formBttn = OEQSTAT_ChildForm_SalesOrderLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEQSTAT_ChildForm_SalesOrderLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEQSTAT_ChildForm_SalesOrderLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Select on ChildForm_SalesOrderLines_SalesOrderLinesTab...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_SalesOrderLinesTab = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_SalesOrderLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLines_SalesOrderLinesTab);
IWebElement mTab = OEQSTAT_ChildForm_SalesOrderLines_SalesOrderLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrderLines_LineDetails_SOLine...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_LineDetails_SOLine = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_LineDetails_SOLine", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOLN_CTW_']/ancestor::form[1]/descendant::*[@id='SO_LN_NO']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderLines_LineDetails_SOLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrderLines_OrderStatus_QuantitySalesUM_Issued...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_OrderStatus_QuantitySalesUM_Issued = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_OrderStatus_QuantitySalesUM_Issued", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOLN_CTW_']/ancestor::form[1]/descendant::*[@id='ISSUE_QTY']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderLines_OrderStatus_QuantitySalesUM_Issued.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Click on ChildForm_SalesOrderLines_IssuesLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_IssuesLink = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_IssuesLink", "ID", "lnk_1005560_OEQSTAT_SOLN_CTW");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLines_IssuesLink);
OEQSTAT_ChildForm_SalesOrderLines_IssuesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing ClickButtonIfExists on ChildForm_SalesOrderLines_IssuesForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_IssuesForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_IssuesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OE_SOISSUEHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLines_IssuesForm);
IWebElement formBttn = OEQSTAT_ChildForm_SalesOrderLines_IssuesForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? OEQSTAT_ChildForm_SalesOrderLines_IssuesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
OEQSTAT_ChildForm_SalesOrderLines_IssuesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault();
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
								Function.WaitControlDisplayed(new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel"));
Function.AssertEqual("Issues", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Query...", Logger.MessageType.INF);
				SeleniumControl Query_Query = new SeleniumControl( sDriver, "Query", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Query);
if (Query_Query.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Query.Click(5,5);
else Query_Query.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Click on ChildForm_SalesOrderLines_Issues_SerialNumbersLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersLink = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_Issues_SerialNumbersLink", "ID", "lnk_1005598_OE_SOISSUEHDR");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersLink);
OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExist on ChildForm_SalesOrderLines_Issues_SerialNumbersFormTable...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersFormTable = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_Issues_SerialNumbersFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SERIALLOT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing ClickButton on ChildForm_SalesOrderLines_Issues_SerialNumbersForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_Issues_SerialNumbersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SERIALLOT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersForm);
IWebElement formBttn = OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrderLines_Issues_SerialNumbersForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_Issues_SerialNumbersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SERIALLOT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrderLines_Issues_SerialNumbers_SerialNumberDetails_SerialLot_SerialNumber...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbers_SerialNumberDetails_SerialLot_SerialNumber = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_Issues_SerialNumbers_SerialNumberDetails_SerialLot_SerialNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SERIALLOT_CTW_']/ancestor::form[1]/descendant::*[@id='SERIAL_ID']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbers_SerialNumberDetails_SerialLot_SerialNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Select on ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SERIALLOT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab);
IWebElement mTab = OEQSTAT_ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Warranty").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrderLines_Issues_SerialNumbers_Warranty_CustomerWarranty_WarrantyCode...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbers_Warranty_CustomerWarranty_WarrantyCode = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_Issues_SerialNumbers_Warranty_CustomerWarranty_WarrantyCode", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SERIALLOT_CTW_']/ancestor::form[1]/descendant::*[@id='CUST_WARR_CD']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbers_Warranty_CustomerWarranty_WarrantyCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Select on ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SERIALLOT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab);
IWebElement mTab = OEQSTAT_ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrderLines_Issues_SerialNumbers_OtherInformation_Maintenance_Purchased...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbers_OtherInformation_Maintenance_Purchased = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_Issues_SerialNumbers_OtherInformation_Maintenance_Purchased", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SERIALLOT_CTW_']/ancestor::form[1]/descendant::*[@id='MAINT_FL']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbers_OtherInformation_Maintenance_Purchased.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Select on ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SERIALLOT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab);
IWebElement mTab = OEQSTAT_ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "User-Defined Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrderLines_Issues_SerialNumbers_OtherInformation_UserDefinedLabels_UserDef1...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbers_OtherInformation_UserDefinedLabels_UserDef1 = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_Issues_SerialNumbers_OtherInformation_UserDefinedLabels_UserDef1", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SERIALLOT_CTW_']/ancestor::form[1]/descendant::*[@id='UDEF_DESC_1']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbers_OtherInformation_UserDefinedLabels_UserDef1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Select on ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SERIALLOT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab);
IWebElement mTab = OEQSTAT_ChildForm_SalesOrderLines_ShipInfo_Issues_SerialNumbers_SerialNumbersTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shelf Life").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SalesOrderLines_Issues_SerialNumbers_ShelfLife_ShelfLife_LastExtensionDate...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbers_ShelfLife_ShelfLife_LastExtensionDate = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_Issues_SerialNumbers_ShelfLife_ShelfLife_LastExtensionDate", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SERIALLOT_CTW_']/ancestor::form[1]/descendant::*[@id='LAST_EXT_DT']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbers_ShelfLife_ShelfLife_LastExtensionDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Close on ChildForm_SalesOrderLines_Issues_SerialNumbersForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_Issues_SerialNumbersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SERIALLOT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersForm);
IWebElement formBttn = OEQSTAT_ChildForm_SalesOrderLines_Issues_SerialNumbersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Close on ChildForm_SalesOrderLines_IssuesForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLines_IssuesForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderLines_IssuesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OE_SOISSUEHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLines_IssuesForm);
IWebElement formBttn = OEQSTAT_ChildForm_SalesOrderLines_IssuesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Close on ChildForm_SalesOrderLinesForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SalesOrderLinesForm = new SeleniumControl( sDriver, "ChildForm_SalesOrderLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SalesOrderLinesForm);
IWebElement formBttn = OEQSTAT_ChildForm_SalesOrderLinesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_SOHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm);
IWebElement formBttn = OEQSTAT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Restore']")).Count <= 0 ? OEQSTAT_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Restore')]")).FirstOrDefault() :
OEQSTAT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Restore']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Restore not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SO HEADER DOCUMENTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SOHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SOHeaderDocumentsLink = new SeleniumControl( sDriver, "ChildForm_SOHeaderDocumentsLink", "ID", "lnk_1007513_OEQSTAT_SOHDR");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SOHeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Click on ChildForm_SOHeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SOHeaderDocumentsLink = new SeleniumControl( sDriver, "ChildForm_SOHeaderDocumentsLink", "ID", "lnk_1007513_OEQSTAT_SOHDR");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SOHeaderDocumentsLink);
OEQSTAT_ChildForm_SOHeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExist on ChildForm_SOHeaderDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SOHeaderDocumentsFormTable = new SeleniumControl( sDriver, "ChildForm_SOHeaderDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SOHeaderDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing ClickButton on ChildForm_SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "ChildForm_SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SOHeaderDocumentsForm);
IWebElement formBttn = OEQSTAT_ChildForm_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEQSTAT_ChildForm_SOHeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEQSTAT_ChildForm_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_SOHeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SOHeaderDocuments_Document = new SeleniumControl( sDriver, "ChildForm_SOHeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_SOHeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Close on ChildForm_SOHeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_SOHeaderDocumentsForm = new SeleniumControl( sDriver, "ChildForm_SOHeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_SOHeaderDocumentsForm);
IWebElement formBttn = OEQSTAT_ChildForm_SOHeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("USER DEFINED INFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_UserDefinedInfoLink = new SeleniumControl( sDriver, "ChildForm_UserDefinedInfoLink", "ID", "lnk_1007519_OEQSTAT_SOHDR");
				Function.AssertEqual(true,OEQSTAT_ChildForm_UserDefinedInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Click on ChildForm_UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_UserDefinedInfoLink = new SeleniumControl( sDriver, "ChildForm_UserDefinedInfoLink", "ID", "lnk_1007519_OEQSTAT_SOHDR");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_UserDefinedInfoLink);
OEQSTAT_ChildForm_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_UserDefinedInfoForm = new SeleniumControl( sDriver, "ChildForm_UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,OEQSTAT_ChildForm_UserDefinedInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExist on ChildForm_UserDefinedInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_UserDefinedInfoFormTable = new SeleniumControl( sDriver, "ChildForm_UserDefinedInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_UserDefinedInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Close on ChildForm_UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_UserDefinedInfoForm = new SeleniumControl( sDriver, "ChildForm_UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEQSTAT_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_UserDefinedInfoForm);
IWebElement formBttn = OEQSTAT_ChildForm_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EXCHANGE RATES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_1005489_OEQSTAT_SOHDR");
				Function.AssertEqual(true,OEQSTAT_ChildForm_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Click on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_1005489_OEQSTAT_SOHDR");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_ExchangeRatesLink);
OEQSTAT_ChildForm_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_ExchangeRatesForm = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEQSTAT_ChildForm_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing VerifyExists on ChildForm_ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ChildForm_ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,OEQSTAT_ChildForm_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Close on ChildForm_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_ChildForm_ExchangeRatesForm = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEQSTAT_ChildForm_ExchangeRatesForm);
IWebElement formBttn = OEQSTAT_ChildForm_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEQSTAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEQSTAT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEQSTAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEQSTAT_MainForm);
IWebElement formBttn = OEQSTAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

