 
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
    public class PPQRQSTS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Proc Planning Reports/Inquiries", "xpath","//div[@class='navItem'][.='Proc Planning Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Purchase Requisition Status", "xpath","//div[@class='navItem'][.='View Purchase Requisition Status']").Click();


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
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on Requisition...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_Requisition = new SeleniumControl( sDriver, "Requisition", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQ_ID']");
				Function.AssertEqual(true,PPQRQSTS_Requisition.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDR_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PPQRQSTS_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDR_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm);
IWebElement formBttn = PPQRQSTS_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PPQRQSTS_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PPQRQSTS_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Requisition']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath", ".//descendant::div[text() = 'is equal to']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='00-0002']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("00-0002");}


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
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDR_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPQRQSTS_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDR_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm);
IWebElement formBttn = PPQRQSTS_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPQRQSTS_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPQRQSTS_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDR_CHLD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPQRQSTS_ChildFormTab);
IWebElement mTab = PPQRQSTS_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Requisition Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_RequisitionDetails_Requisition...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_RequisitionDetails_Requisition = new SeleniumControl( sDriver, "ChildForm_RequisitionDetails_Requisition", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDR_CHLD_']/ancestor::form[1]/descendant::*[@id='RQ_ID']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_RequisitionDetails_Requisition.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDR_CHLD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPQRQSTS_ChildFormTab);
IWebElement mTab = PPQRQSTS_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_OtherInfo_Buyer...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_OtherInfo_Buyer = new SeleniumControl( sDriver, "ChildForm_OtherInfo_Buyer", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDR_CHLD_']/ancestor::form[1]/descendant::*[@id='BUYER_ID']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_OtherInfo_Buyer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDR_CHLD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPQRQSTS_ChildFormTab);
IWebElement mTab = PPQRQSTS_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_Notes_Notes = new SeleniumControl( sDriver, "ChildForm_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDR_CHLD_']/ancestor::form[1]/descendant::*[@id='RQ_NOTES']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Click on ChildForm_ReqHdrTextLink...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqHdrTextLink = new SeleniumControl( sDriver, "ChildForm_ReqHdrTextLink", "ID", "lnk_1006759_PPQRQSTS_RQHDR_CHLD");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqHdrTextLink);
PPQRQSTS_ChildForm_ReqHdrTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm_ReqHdrTextForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_ReqHdrTextForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqHdrTextForm = new SeleniumControl( sDriver, "ChildForm_ReqHdrTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDRTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqHdrTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExist on ChildForm_ReqHdrTextFormTable...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqHdrTextFormTable = new SeleniumControl( sDriver, "ChildForm_ReqHdrTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDRTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqHdrTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing ClickButton on ChildForm_ReqHdrTextForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqHdrTextForm = new SeleniumControl( sDriver, "ChildForm_ReqHdrTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDRTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqHdrTextForm);
IWebElement formBttn = PPQRQSTS_ChildForm_ReqHdrTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPQRQSTS_ChildForm_ReqHdrTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPQRQSTS_ChildForm_ReqHdrTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_ReqHdrText_Sequence...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqHdrText_Sequence = new SeleniumControl( sDriver, "ChildForm_ReqHdrText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDRTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqHdrText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Close on ChildForm_ReqHdrTextForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqHdrTextForm = new SeleniumControl( sDriver, "ChildForm_ReqHdrTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDRTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqHdrTextForm);
IWebElement formBttn = PPQRQSTS_ChildForm_ReqHdrTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Click on ChildForm_ReqHdrApprovalLink...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqHdrApprovalLink = new SeleniumControl( sDriver, "ChildForm_ReqHdrApprovalLink", "ID", "lnk_1006718_PPQRQSTS_RQHDR_CHLD");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqHdrApprovalLink);
PPQRQSTS_ChildForm_ReqHdrApprovalLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm_ReqHdrApprovalForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_ReqHdrApprovalForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqHdrApprovalForm = new SeleniumControl( sDriver, "ChildForm_ReqHdrApprovalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqHdrApprovalForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExist on ChildForm_ReqHdrApprovalFormTable...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqHdrApprovalFormTable = new SeleniumControl( sDriver, "ChildForm_ReqHdrApprovalFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDRAPPRVL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqHdrApprovalFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing ClickButton on ChildForm_ReqHdrApprovalForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqHdrApprovalForm = new SeleniumControl( sDriver, "ChildForm_ReqHdrApprovalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqHdrApprovalForm);
IWebElement formBttn = PPQRQSTS_ChildForm_ReqHdrApprovalForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPQRQSTS_ChildForm_ReqHdrApprovalForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPQRQSTS_ChildForm_ReqHdrApprovalForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_ReqHdrApproval_ApprovalRevision...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqHdrApproval_ApprovalRevision = new SeleniumControl( sDriver, "ChildForm_ReqHdrApproval_ApprovalRevision", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDRAPPRVL_']/ancestor::form[1]/descendant::*[@id='RVSN_NO']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqHdrApproval_ApprovalRevision.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Close on ChildForm_ReqHdrApprovalForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqHdrApprovalForm = new SeleniumControl( sDriver, "ChildForm_ReqHdrApprovalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqHdrApprovalForm);
IWebElement formBttn = PPQRQSTS_ChildForm_ReqHdrApprovalForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Click on ChildForm_HdrDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_HdrDocumentsLink = new SeleniumControl( sDriver, "ChildForm_HdrDocumentsLink", "ID", "lnk_1007771_PPQRQSTS_RQHDR_CHLD");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_HdrDocumentsLink);
PPQRQSTS_ChildForm_HdrDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm_HdrDocumentsForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_HdrDocumentsForm = new SeleniumControl( sDriver, "ChildForm_HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_HdrDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExist on ChildForm_HdrDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_HdrDocumentsFormTable = new SeleniumControl( sDriver, "ChildForm_HdrDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_HdrDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing ClickButton on ChildForm_HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_HdrDocumentsForm = new SeleniumControl( sDriver, "ChildForm_HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_HdrDocumentsForm);
IWebElement formBttn = PPQRQSTS_ChildForm_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPQRQSTS_ChildForm_HdrDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPQRQSTS_ChildForm_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_HdrDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_HdrDocuments_Document = new SeleniumControl( sDriver, "ChildForm_HdrDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_HdrDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Close on ChildForm_HdrDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_HdrDocumentsForm = new SeleniumControl( sDriver, "ChildForm_HdrDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_HdrDocumentsForm);
IWebElement formBttn = PPQRQSTS_ChildForm_HdrDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Click on ChildForm_RFQsLink...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_RFQsLink = new SeleniumControl( sDriver, "ChildForm_RFQsLink", "ID", "lnk_1006720_PPQRQSTS_RQHDR_CHLD");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_RFQsLink);
PPQRQSTS_ChildForm_RFQsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm_RFQsForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_RFQsForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_RFQsForm = new SeleniumControl( sDriver, "ChildForm_RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RFQHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_RFQsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExist on ChildForm_RFQsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_RFQsFormTable = new SeleniumControl( sDriver, "ChildForm_RFQsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RFQHDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_RFQsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing ClickButton on ChildForm_RFQsForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_RFQsForm = new SeleniumControl( sDriver, "ChildForm_RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RFQHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_RFQsForm);
IWebElement formBttn = PPQRQSTS_ChildForm_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPQRQSTS_ChildForm_RFQsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPQRQSTS_ChildForm_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_RFQs_RFQ...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_RFQs_RFQ = new SeleniumControl( sDriver, "ChildForm_RFQs_RFQ", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RFQHDR_']/ancestor::form[1]/descendant::*[@id='RFQ_ID']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_RFQs_RFQ.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Close on ChildForm_RFQsForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_RFQsForm = new SeleniumControl( sDriver, "ChildForm_RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RFQHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_RFQsForm);
IWebElement formBttn = PPQRQSTS_ChildForm_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Click on ChildForm_ReqLinesLink...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLinesLink = new SeleniumControl( sDriver, "ChildForm_ReqLinesLink", "ID", "lnk_1006719_PPQRQSTS_RQHDR_CHLD");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqLinesLink);
PPQRQSTS_ChildForm_ReqLinesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm_ReqLinesForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_ReqLinesForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLinesForm = new SeleniumControl( sDriver, "ChildForm_ReqLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQLN_']/ancestor::form[1]");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExist on ChildForm_ReqLinesFormTable...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLinesFormTable = new SeleniumControl( sDriver, "ChildForm_ReqLinesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqLinesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing ClickButton on ChildForm_ReqLinesForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLinesForm = new SeleniumControl( sDriver, "ChildForm_ReqLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqLinesForm);
IWebElement formBttn = PPQRQSTS_ChildForm_ReqLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPQRQSTS_ChildForm_ReqLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPQRQSTS_ChildForm_ReqLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Select on ChildForm_ReqLinesTab...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLinesTab = new SeleniumControl( sDriver, "ChildForm_ReqLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqLinesTab);
IWebElement mTab = PPQRQSTS_ChildForm_ReqLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Item Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_ReqLines_ItemInfo_Item...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLines_ItemInfo_Item = new SeleniumControl( sDriver, "ChildForm_ReqLines_ItemInfo_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQLN_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqLines_ItemInfo_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Select on ChildForm_ReqLinesTab...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLinesTab = new SeleniumControl( sDriver, "ChildForm_ReqLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqLinesTab);
IWebElement mTab = PPQRQSTS_ChildForm_ReqLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_ReqLines_CostInfo_EstExtAmount...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLines_CostInfo_EstExtAmount = new SeleniumControl( sDriver, "ChildForm_ReqLines_CostInfo_EstExtAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQLN_']/ancestor::form[1]/descendant::*[@id='TRN_RQ_LN_EXT_AMT']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqLines_CostInfo_EstExtAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Select on ChildForm_ReqLinesTab...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLinesTab = new SeleniumControl( sDriver, "ChildForm_ReqLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqLinesTab);
IWebElement mTab = PPQRQSTS_ChildForm_ReqLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_ReqLines_OtherInfo_ApprovalProcess...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLines_OtherInfo_ApprovalProcess = new SeleniumControl( sDriver, "ChildForm_ReqLines_OtherInfo_ApprovalProcess", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQLN_']/ancestor::form[1]/descendant::*[@id='APPR_PROC_CD']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqLines_OtherInfo_ApprovalProcess.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Select on ChildForm_ReqLinesTab...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLinesTab = new SeleniumControl( sDriver, "ChildForm_ReqLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqLinesTab);
IWebElement mTab = PPQRQSTS_ChildForm_ReqLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_ReqLines_Notes_InternalNotes...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLines_Notes_InternalNotes = new SeleniumControl( sDriver, "ChildForm_ReqLines_Notes_InternalNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQLN_']/ancestor::form[1]/descendant::*[@id='RQST_INT_NOTES']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqLines_Notes_InternalNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_ReqLines_SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLines_SerialLotLink = new SeleniumControl( sDriver, "ChildForm_ReqLines_SerialLotLink", "ID", "lnk_16795_PPQRQSTS_RQLN");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqLines_SerialLotLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Click on ChildForm_ReqLines_SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLines_SerialLotLink = new SeleniumControl( sDriver, "ChildForm_ReqLines_SerialLotLink", "ID", "lnk_16795_PPQRQSTS_RQLN");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqLines_SerialLotLink);
PPQRQSTS_ChildForm_ReqLines_SerialLotLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExist on ChildForm_ReqLines_SerialLotFormTable...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLines_SerialLotFormTable = new SeleniumControl( sDriver, "ChildForm_ReqLines_SerialLotFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_SERIALLOT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqLines_SerialLotFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing ClickButton on ChildForm_ReqLines_SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLines_SerialLotForm = new SeleniumControl( sDriver, "ChildForm_ReqLines_SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_SERIALLOT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqLines_SerialLotForm);
IWebElement formBttn = PPQRQSTS_ChildForm_ReqLines_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPQRQSTS_ChildForm_ReqLines_SerialLotForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPQRQSTS_ChildForm_ReqLines_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_ReqLines_SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLines_SerialLotForm = new SeleniumControl( sDriver, "ChildForm_ReqLines_SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_SERIALLOT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqLines_SerialLotForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Select on ChildForm_ReqLines_SerialLot_SerialLotTab...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLines_SerialLot_SerialLotTab = new SeleniumControl( sDriver, "ChildForm_ReqLines_SerialLot_SerialLotTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_SERIALLOT_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqLines_SerialLot_SerialLotTab);
IWebElement mTab = PPQRQSTS_ChildForm_ReqLines_SerialLot_SerialLotTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing VerifyExists on ChildForm_ReqLines_SerialLot_BasicInformation_Lot...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLines_SerialLot_BasicInformation_Lot = new SeleniumControl( sDriver, "ChildForm_ReqLines_SerialLot_BasicInformation_Lot", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_SERIALLOT_']/ancestor::form[1]/descendant::*[@id='LOT_ID']");
				Function.AssertEqual(true,PPQRQSTS_ChildForm_ReqLines_SerialLot_BasicInformation_Lot.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DATA DEPENDENT; FIND A RECORD IN ORDER TO ACCESS TABS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Close on ChildForm_ReqLinesForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_ChildForm_ReqLinesForm = new SeleniumControl( sDriver, "ChildForm_ReqLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQRQSTS_RQLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_ChildForm_ReqLinesForm);
IWebElement formBttn = PPQRQSTS_ChildForm_ReqLinesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQRQSTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQRQSTS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPQRQSTS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPQRQSTS_MainForm);
IWebElement formBttn = PPQRQSTS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

