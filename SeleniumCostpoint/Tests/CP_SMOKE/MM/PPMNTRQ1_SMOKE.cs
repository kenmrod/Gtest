 
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
    public class PPMNTRQ1_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Purchase Requisitions", "xpath","//div[@class='navItem'][.='Manage Purchase Requisitions']").Click();


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
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMNTRQ1_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_MainForm);
IWebElement formBttn = PPMNTRQ1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PPMNTRQ1_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PPMNTRQ1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Requisition ID']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'begins with']").Click();
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
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on Identification_RequisitionID...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_Identification_RequisitionID = new SeleniumControl( sDriver, "Identification_RequisitionID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQ_ID']");
				Function.AssertEqual(true,PPMNTRQ1_Identification_RequisitionID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_MainForm);
IWebElement formBttn = PPMNTRQ1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PPMNTRQ1_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PPMNTRQ1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ1_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_MainForm);
IWebElement formBttn = PPMNTRQ1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ1_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ1_MainFormTab);
IWebElement mTab = PPMNTRQ1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on Header_Requisitioner_Requisitioner...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_Header_Requisitioner_Requisitioner = new SeleniumControl( sDriver, "Header_Requisitioner_Requisitioner", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQST_EMPL_ID']");
				Function.AssertEqual(true,PPMNTRQ1_Header_Requisitioner_Requisitioner.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ1_MainFormTab);
IWebElement mTab = PPMNTRQ1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Accounting Defaults").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on AccountingDefaults_Project...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_AccountingDefaults_Project = new SeleniumControl( sDriver, "AccountingDefaults_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PPMNTRQ1_AccountingDefaults_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ1_MainFormTab);
IWebElement mTab = PPMNTRQ1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on OtherInformation_DeliveryDefaults_RequestedDate...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_OtherInformation_DeliveryDefaults_RequestedDate = new SeleniumControl( sDriver, "OtherInformation_DeliveryDefaults_RequestedDate", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQST_DT']");
				Function.AssertEqual(true,PPMNTRQ1_OtherInformation_DeliveryDefaults_RequestedDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ1_MainFormTab);
IWebElement mTab = PPMNTRQ1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ1_MainFormTab);
IWebElement mTab = PPMNTRQ1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Assign PO Defaults").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on AssignPODetails_Vendor...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_AssignPODetails_Vendor = new SeleniumControl( sDriver, "AssignPODetails_Vendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ASSIGN_VEND_ID']");
				Function.AssertEqual(true,PPMNTRQ1_AssignPODetails_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ1_MainFormTab);
IWebElement mTab = PPMNTRQ1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("Hdr Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on HeaderTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderTextLink = new SeleniumControl( sDriver, "HeaderTextLink", "ID", "lnk_1004205_PPMENTRQ_RQHDR");
				Function.AssertEqual(true,PPMNTRQ1_HeaderTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Click on HeaderTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderTextLink = new SeleniumControl( sDriver, "HeaderTextLink", "ID", "lnk_1004205_PPMENTRQ_RQHDR");
				Function.WaitControlDisplayed(PPMNTRQ1_HeaderTextLink);
PPMNTRQ1_HeaderTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on HeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderTextForm = new SeleniumControl( sDriver, "HeaderTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ1_HeaderTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExist on HeaderTextTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderTextTable = new SeleniumControl( sDriver, "HeaderTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ1_HeaderTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing ClickButton on HeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderTextForm = new SeleniumControl( sDriver, "HeaderTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_HeaderTextForm);
IWebElement formBttn = PPMNTRQ1_HeaderTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ1_HeaderTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ1_HeaderTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on HeaderText_Sequence...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderText_Sequence = new SeleniumControl( sDriver, "HeaderText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,PPMNTRQ1_HeaderText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Close on HeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderTextForm = new SeleniumControl( sDriver, "HeaderTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_HeaderTextForm);
IWebElement formBttn = PPMNTRQ1_HeaderTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Hdr Approvals");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on HeaderApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderApprovalsLink = new SeleniumControl( sDriver, "HeaderApprovalsLink", "ID", "lnk_2532_PPMENTRQ_RQHDR");
				Function.AssertEqual(true,PPMNTRQ1_HeaderApprovalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Click on HeaderApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderApprovalsLink = new SeleniumControl( sDriver, "HeaderApprovalsLink", "ID", "lnk_2532_PPMENTRQ_RQHDR");
				Function.WaitControlDisplayed(PPMNTRQ1_HeaderApprovalsLink);
PPMNTRQ1_HeaderApprovalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on HeaderApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderApprovalsForm = new SeleniumControl( sDriver, "HeaderApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ1_HeaderApprovalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExist on HeaderApprovalsTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderApprovalsTable = new SeleniumControl( sDriver, "HeaderApprovalsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ1_HeaderApprovalsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing ClickButton on HeaderApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderApprovalsForm = new SeleniumControl( sDriver, "HeaderApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_HeaderApprovalsForm);
IWebElement formBttn = PPMNTRQ1_HeaderApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ1_HeaderApprovalsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ1_HeaderApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on HeaderApprovals_ApprovalRevision...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderApprovals_ApprovalRevision = new SeleniumControl( sDriver, "HeaderApprovals_ApprovalRevision", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]/descendant::*[@id='RVSN_NO']");
				Function.AssertEqual(true,PPMNTRQ1_HeaderApprovals_ApprovalRevision.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Close on HeaderApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderApprovalsForm = new SeleniumControl( sDriver, "HeaderApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_HeaderApprovalsForm);
IWebElement formBttn = PPMNTRQ1_HeaderApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Totals");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on TotalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_TotalsLink = new SeleniumControl( sDriver, "TotalsLink", "ID", "lnk_2530_PPMENTRQ_RQHDR");
				Function.AssertEqual(true,PPMNTRQ1_TotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Click on TotalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_TotalsLink = new SeleniumControl( sDriver, "TotalsLink", "ID", "lnk_2530_PPMENTRQ_RQHDR");
				Function.WaitControlDisplayed(PPMNTRQ1_TotalsLink);
PPMNTRQ1_TotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQ_TOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ1_TotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on Totals_CurrencyFunctional...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_Totals_CurrencyFunctional = new SeleniumControl( sDriver, "Totals_CurrencyFunctional", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQ_TOTALS_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMNTRQ1_Totals_CurrencyFunctional.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Close on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQ_TOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_TotalsForm);
IWebElement formBttn = PPMNTRQ1_TotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1005071_PPMENTRQ_RQHDR");
				Function.AssertEqual(true,PPMNTRQ1_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1005071_PPMENTRQ_RQHDR");
				Function.WaitControlDisplayed(PPMNTRQ1_ExchangeRatesLink);
PPMNTRQ1_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ1_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMNTRQ1_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_ExchangeRatesForm);
IWebElement formBttn = PPMNTRQ1_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007717_PPMENTRQ_RQHDR");
				Function.AssertEqual(true,PPMNTRQ1_HeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Click on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007717_PPMENTRQ_RQHDR");
				Function.WaitControlDisplayed(PPMNTRQ1_HeaderDocumentsLink);
PPMNTRQ1_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ1_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExist on HeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderDocumentsTable = new SeleniumControl( sDriver, "HeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ1_HeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing ClickButton on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_HeaderDocumentsForm);
IWebElement formBttn = PPMNTRQ1_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ1_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ1_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderDocuments_Document = new SeleniumControl( sDriver, "HeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPMNTRQ1_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Close on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_HeaderDocumentsForm);
IWebElement formBttn = PPMNTRQ1_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ1_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildForm);
IWebElement formBttn = PPMNTRQ1_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ1_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ1_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm_Line...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_Line = new SeleniumControl( sDriver, "ChildForm_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='RQ_LN_NO']");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildFormTab);
IWebElement mTab = PPMNTRQ1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm_BasicInformation_Item...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_BasicInformation_Item = new SeleniumControl( sDriver, "ChildForm_BasicInformation_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm_BasicInformation_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildFormTab);
IWebElement mTab = PPMNTRQ1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Purchasing Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm_PurchasingInformation_Buyer...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_PurchasingInformation_Buyer = new SeleniumControl( sDriver, "ChildForm_PurchasingInformation_Buyer", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='BUYER_ID']");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm_PurchasingInformation_Buyer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildFormTab);
IWebElement mTab = PPMNTRQ1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shipping & Receiving").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm_ShippingAndReceiving_Warehouse...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_ShippingAndReceiving_Warehouse = new SeleniumControl( sDriver, "ChildForm_ShippingAndReceiving_Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm_ShippingAndReceiving_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildFormTab);
IWebElement mTab = PPMNTRQ1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm_OtherInformation_Planner...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_OtherInformation_Planner = new SeleniumControl( sDriver, "ChildForm_OtherInformation_Planner", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='PLANNER_ID']");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm_OtherInformation_Planner.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildFormTab);
IWebElement mTab = PPMNTRQ1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildFormTab);
IWebElement mTab = PPMNTRQ1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("Accounts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_AccountsLink = new SeleniumControl( sDriver, "ChildForm_AccountsLink", "ID", "lnk_1004212_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm_AccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Click on ChildForm_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_AccountsLink = new SeleniumControl( sDriver, "ChildForm_AccountsLink", "ID", "lnk_1004212_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildForm_AccountsLink);
PPMNTRQ1_ChildForm_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ1_AccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExist on AccountsTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_AccountsTable = new SeleniumControl( sDriver, "AccountsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ1_AccountsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing ClickButton on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_AccountsForm);
IWebElement formBttn = PPMNTRQ1_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ1_AccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ1_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on Accounts_Project...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_Accounts_Project = new SeleniumControl( sDriver, "Accounts_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PPMNTRQ1_Accounts_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Close on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_AccountsForm);
IWebElement formBttn = PPMNTRQ1_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Charges");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1004211_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm_LineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Click on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1004211_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildForm_LineChargesLink);
PPMNTRQ1_ChildForm_LineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ1_LineChargesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExist on LineChargesTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineChargesTable = new SeleniumControl( sDriver, "LineChargesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ1_LineChargesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing ClickButton on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_LineChargesForm);
IWebElement formBttn = PPMNTRQ1_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ1_LineChargesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ1_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on LineCharges_ChargeType...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineCharges_ChargeType = new SeleniumControl( sDriver, "LineCharges_ChargeType", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]/descendant::*[@id='LN_CHG_TYPE']");
				Function.AssertEqual(true,PPMNTRQ1_LineCharges_ChargeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Close on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_LineChargesForm);
IWebElement formBttn = PPMNTRQ1_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm_LineTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_LineTextLink = new SeleniumControl( sDriver, "ChildForm_LineTextLink", "ID", "lnk_1004607_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm_LineTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Click on ChildForm_LineTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_LineTextLink = new SeleniumControl( sDriver, "ChildForm_LineTextLink", "ID", "lnk_1004607_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildForm_LineTextLink);
PPMNTRQ1_ChildForm_LineTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on LineTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineTextForm = new SeleniumControl( sDriver, "LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ1_LineTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExist on LineTextTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineTextTable = new SeleniumControl( sDriver, "LineTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ1_LineTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing ClickButton on LineTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineTextForm = new SeleniumControl( sDriver, "LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_LineTextForm);
IWebElement formBttn = PPMNTRQ1_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ1_LineTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ1_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on LineText_Sequence...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineText_Sequence = new SeleniumControl( sDriver, "LineText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,PPMNTRQ1_LineText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Close on LineTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineTextForm = new SeleniumControl( sDriver, "LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_LineTextForm);
IWebElement formBttn = PPMNTRQ1_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Approvals");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm_LineApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_LineApprovalsLink = new SeleniumControl( sDriver, "ChildForm_LineApprovalsLink", "ID", "lnk_1005073_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm_LineApprovalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Click on ChildForm_LineApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_LineApprovalsLink = new SeleniumControl( sDriver, "ChildForm_LineApprovalsLink", "ID", "lnk_1005073_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildForm_LineApprovalsLink);
PPMNTRQ1_ChildForm_LineApprovalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on LineApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineApprovalsForm = new SeleniumControl( sDriver, "LineApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ1_LineApprovalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExist on LineApprovalsTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineApprovalsTable = new SeleniumControl( sDriver, "LineApprovalsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ1_LineApprovalsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing ClickButton on LineApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineApprovalsForm = new SeleniumControl( sDriver, "LineApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_LineApprovalsForm);
IWebElement formBttn = PPMNTRQ1_LineApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ1_LineApprovalsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ1_LineApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on LineApprovals_Sequence...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineApprovals_Sequence = new SeleniumControl( sDriver, "LineApprovals_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]/descendant::*[@id='APPRVL_SEQ_NO']");
				Function.AssertEqual(true,PPMNTRQ1_LineApprovals_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Close on LineApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineApprovalsForm = new SeleniumControl( sDriver, "LineApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_LineApprovalsForm);
IWebElement formBttn = PPMNTRQ1_LineApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007718_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Click on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007718_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildForm_LineDocumentsLink);
PPMNTRQ1_ChildForm_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ1_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExist on LineDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineDocumentsTable = new SeleniumControl( sDriver, "LineDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ1_LineDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing ClickButton on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_LineDocumentsForm);
IWebElement formBttn = PPMNTRQ1_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ1_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ1_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineDocuments_Document = new SeleniumControl( sDriver, "LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPMNTRQ1_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Close on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_LineDocumentsForm);
IWebElement formBttn = PPMNTRQ1_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Currency Line");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm_CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_CurrencyLineLink = new SeleniumControl( sDriver, "ChildForm_CurrencyLineLink", "ID", "lnk_2529_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm_CurrencyLineLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Click on ChildForm_CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_CurrencyLineLink = new SeleniumControl( sDriver, "ChildForm_CurrencyLineLink", "ID", "lnk_2529_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildForm_CurrencyLineLink);
PPMNTRQ1_ChildForm_CurrencyLineLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ1_CurrencyLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on CurrencyLine_LineAmounts_CurrencyFunctional...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_CurrencyLine_LineAmounts_CurrencyFunctional = new SeleniumControl( sDriver, "CurrencyLine_LineAmounts_CurrencyFunctional", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMNTRQ1_CurrencyLine_LineAmounts_CurrencyFunctional.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Close on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_CurrencyLineForm);
IWebElement formBttn = PPMNTRQ1_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SERIAL LOT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm_SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_SerialLotLink = new SeleniumControl( sDriver, "ChildForm_SerialLotLink", "ID", "lnk_16760_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm_SerialLotLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Click on ChildForm_SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_SerialLotLink = new SeleniumControl( sDriver, "ChildForm_SerialLotLink", "ID", "lnk_16760_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ1_ChildForm_SerialLotLink);
PPMNTRQ1_ChildForm_SerialLotLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExist on SerialLotTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_SerialLotTable = new SeleniumControl( sDriver, "SerialLotTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_SERIALLOT_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ1_SerialLotTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing ClickButton on SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_SerialLotForm = new SeleniumControl( sDriver, "SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_SERIALLOT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_SerialLotForm);
IWebElement formBttn = PPMNTRQ1_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ1_SerialLotForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ1_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_SerialLotForm = new SeleniumControl( sDriver, "SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_SERIALLOT_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ1_SerialLotForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Select on SerialLot_SerialLotTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_SerialLot_SerialLotTab = new SeleniumControl( sDriver, "SerialLot_SerialLotTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_SERIALLOT_DETL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ1_SerialLot_SerialLotTab);
IWebElement mTab = PPMNTRQ1_SerialLot_SerialLotTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on SerialLot_BasicInformation_Quantity...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_SerialLot_BasicInformation_Quantity = new SeleniumControl( sDriver, "SerialLot_BasicInformation_Quantity", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_SERIALLOT_DETL_']/ancestor::form[1]/descendant::*[@id='QTY']");
				Function.AssertEqual(true,PPMNTRQ1_SerialLot_BasicInformation_Quantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Close on SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_SerialLotForm = new SeleniumControl( sDriver, "SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_SERIALLOT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_SerialLotForm);
IWebElement formBttn = PPMNTRQ1_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Substitute Parts ");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing VerifyExists on ChildForm_ProjSubPartsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_ChildForm_ProjSubPartsLink = new SeleniumControl( sDriver, "ChildForm_ProjSubPartsLink", "ID", "lnk_16470_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ1_ChildForm_ProjSubPartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ1] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMNTRQ1_MainForm);
IWebElement formBttn = PPMNTRQ1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogWithMessage("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogWithMessage]" , ex.Message));
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

