 
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
    public class PPMNTRQ2_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Apply PO Info to Purchase Requisitions", "xpath","//div[@class='navItem'][.='Apply PO Info to Purchase Requisitions']").Click();


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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMNTRQ2_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_MainForm);
IWebElement formBttn = PPMNTRQ2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on Identification_RequisitionID...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_Identification_RequisitionID = new SeleniumControl( sDriver, "Identification_RequisitionID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQ_ID']");
				Function.AssertEqual(true,PPMNTRQ2_Identification_RequisitionID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_MainForm);
IWebElement formBttn = PPMNTRQ2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PPMNTRQ2_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PPMNTRQ2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_MainForm);
IWebElement formBttn = PPMNTRQ2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_MainFormTab);
IWebElement mTab = PPMNTRQ2_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on Header_Requisitioner_Requisitioner...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_Header_Requisitioner_Requisitioner = new SeleniumControl( sDriver, "Header_Requisitioner_Requisitioner", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQST_EMPL_ID']");
				Function.AssertEqual(true,PPMNTRQ2_Header_Requisitioner_Requisitioner.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_MainFormTab);
IWebElement mTab = PPMNTRQ2_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Accounting Defaults").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on AccountingDefaults_Project...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AccountingDefaults_Project = new SeleniumControl( sDriver, "AccountingDefaults_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PPMNTRQ2_AccountingDefaults_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_MainFormTab);
IWebElement mTab = PPMNTRQ2_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on OtherInformation_DeliveryDefaults_RequestedDate...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_OtherInformation_DeliveryDefaults_RequestedDate = new SeleniumControl( sDriver, "OtherInformation_DeliveryDefaults_RequestedDate", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQST_DT']");
				Function.AssertEqual(true,PPMNTRQ2_OtherInformation_DeliveryDefaults_RequestedDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_MainFormTab);
IWebElement mTab = PPMNTRQ2_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_MainFormTab);
IWebElement mTab = PPMNTRQ2_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Assign PO Defaults").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on AssignPODetails_Vendor...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPODetails_Vendor = new SeleniumControl( sDriver, "AssignPODetails_Vendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ASSIGN_VEND_ID']");
				Function.AssertEqual(true,PPMNTRQ2_AssignPODetails_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_MainFormTab);
IWebElement mTab = PPMNTRQ2_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header").FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on HeaderTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderTextLink = new SeleniumControl( sDriver, "HeaderTextLink", "ID", "lnk_1004752_PPMENTRQ_RQHDR");
				Function.AssertEqual(true,PPMNTRQ2_HeaderTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on HeaderTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderTextLink = new SeleniumControl( sDriver, "HeaderTextLink", "ID", "lnk_1004752_PPMENTRQ_RQHDR");
				Function.WaitControlDisplayed(PPMNTRQ2_HeaderTextLink);
PPMNTRQ2_HeaderTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on HeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderTextForm = new SeleniumControl( sDriver, "HeaderTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_HeaderTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on HeaderTextTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderTextTable = new SeleniumControl( sDriver, "HeaderTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_HeaderTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on HeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderTextForm = new SeleniumControl( sDriver, "HeaderTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_HeaderTextForm);
IWebElement formBttn = PPMNTRQ2_HeaderTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_HeaderTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_HeaderTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on HeaderText_Sequence...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderText_Sequence = new SeleniumControl( sDriver, "HeaderText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,PPMNTRQ2_HeaderText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on HeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderTextForm = new SeleniumControl( sDriver, "HeaderTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_HeaderTextForm);
IWebElement formBttn = PPMNTRQ2_HeaderTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on HeaderApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderApprovalsLink = new SeleniumControl( sDriver, "HeaderApprovalsLink", "ID", "lnk_2587_PPMENTRQ_RQHDR");
				Function.AssertEqual(true,PPMNTRQ2_HeaderApprovalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on HeaderApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderApprovalsLink = new SeleniumControl( sDriver, "HeaderApprovalsLink", "ID", "lnk_2587_PPMENTRQ_RQHDR");
				Function.WaitControlDisplayed(PPMNTRQ2_HeaderApprovalsLink);
PPMNTRQ2_HeaderApprovalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on HeaderApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderApprovalsForm = new SeleniumControl( sDriver, "HeaderApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_HeaderApprovalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on HeaderApprovalsTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderApprovalsTable = new SeleniumControl( sDriver, "HeaderApprovalsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_HeaderApprovalsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on HeaderApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderApprovalsForm = new SeleniumControl( sDriver, "HeaderApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_HeaderApprovalsForm);
IWebElement formBttn = PPMNTRQ2_HeaderApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_HeaderApprovalsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_HeaderApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on HeaderApprovals_ApprovalRevision...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderApprovals_ApprovalRevision = new SeleniumControl( sDriver, "HeaderApprovals_ApprovalRevision", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]/descendant::*[@id='RVSN_NO']");
				Function.AssertEqual(true,PPMNTRQ2_HeaderApprovals_ApprovalRevision.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on HeaderApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderApprovalsForm = new SeleniumControl( sDriver, "HeaderApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQHDRAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_HeaderApprovalsForm);
IWebElement formBttn = PPMNTRQ2_HeaderApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Ref Quotes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on RefQuotesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RefQuotesLink = new SeleniumControl( sDriver, "RefQuotesLink", "ID", "lnk_2744_PPMENTRQ_RQHDR");
				Function.AssertEqual(true,PPMNTRQ2_RefQuotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on RefQuotesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RefQuotesLink = new SeleniumControl( sDriver, "RefQuotesLink", "ID", "lnk_2744_PPMENTRQ_RQHDR");
				Function.WaitControlDisplayed(PPMNTRQ2_RefQuotesLink);
PPMNTRQ2_RefQuotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on RefQuotesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RefQuotesForm = new SeleniumControl( sDriver, "RefQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNQUOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_RefQuotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on RefQuotesTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RefQuotesTable = new SeleniumControl( sDriver, "RefQuotesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNQUOTES_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_RefQuotesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on RefQuotesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RefQuotesForm = new SeleniumControl( sDriver, "RefQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNQUOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_RefQuotesForm);
IWebElement formBttn = PPMNTRQ2_RefQuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_RefQuotesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_RefQuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on RefQuotes_ReqLine...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RefQuotes_ReqLine = new SeleniumControl( sDriver, "RefQuotes_ReqLine", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNQUOTES_']/ancestor::form[1]/descendant::*[@id='RQ_LN_NO']");
				Function.AssertEqual(true,PPMNTRQ2_RefQuotes_ReqLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on RefQuotes_ItemVendorLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RefQuotes_ItemVendorLink = new SeleniumControl( sDriver, "RefQuotes_ItemVendorLink", "ID", "lnk_2998_PPMENTRQ_RQLNQUOTES");
				Function.AssertEqual(true,PPMNTRQ2_RefQuotes_ItemVendorLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on RefQuotes_ItemVendorLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RefQuotes_ItemVendorLink = new SeleniumControl( sDriver, "RefQuotes_ItemVendorLink", "ID", "lnk_2998_PPMENTRQ_RQLNQUOTES");
				Function.WaitControlDisplayed(PPMNTRQ2_RefQuotes_ItemVendorLink);
PPMNTRQ2_RefQuotes_ItemVendorLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ItemVendorForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ItemVendorForm = new SeleniumControl( sDriver, "ItemVendorForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ITEMVEND_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_ItemVendorForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on ItemVendorTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ItemVendorTable = new SeleniumControl( sDriver, "ItemVendorTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ITEMVEND_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_ItemVendorTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on ItemVendorForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ItemVendorForm = new SeleniumControl( sDriver, "ItemVendorForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ITEMVEND_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_ItemVendorForm);
IWebElement formBttn = PPMNTRQ2_ItemVendorForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on RefQuotes_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RefQuotes_ExchangeRatesLink = new SeleniumControl( sDriver, "RefQuotes_ExchangeRatesLink", "ID", "lnk_2745_PPMENTRQ_RQLNQUOTES");
				Function.AssertEqual(true,PPMNTRQ2_RefQuotes_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on RefQuotes_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RefQuotes_ExchangeRatesLink = new SeleniumControl( sDriver, "RefQuotes_ExchangeRatesLink", "ID", "lnk_2745_PPMENTRQ_RQLNQUOTES");
				Function.WaitControlDisplayed(PPMNTRQ2_RefQuotes_ExchangeRatesLink);
PPMNTRQ2_RefQuotes_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMNTRQ2_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_ExchangeRatesForm);
IWebElement formBttn = PPMNTRQ2_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on RefQuotesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RefQuotesForm = new SeleniumControl( sDriver, "RefQuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNQUOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_RefQuotesForm);
IWebElement formBttn = PPMNTRQ2_RefQuotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assign PO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on AssignPOLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPOLink = new SeleniumControl( sDriver, "AssignPOLink", "ID", "lnk_2971_PPMENTRQ_RQHDR");
				Function.AssertEqual(true,PPMNTRQ2_AssignPOLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on AssignPOLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPOLink = new SeleniumControl( sDriver, "AssignPOLink", "ID", "lnk_2971_PPMENTRQ_RQHDR");
				Function.WaitControlDisplayed(PPMNTRQ2_AssignPOLink);
PPMNTRQ2_AssignPOLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on AssignPOTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPOTable = new SeleniumControl( sDriver, "AssignPOTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_AssignPOTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on AssignPOForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPOForm = new SeleniumControl( sDriver, "AssignPOForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_AssignPOForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on AssignPOForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPOForm = new SeleniumControl( sDriver, "AssignPOForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_AssignPOForm);
IWebElement formBttn = PPMNTRQ2_AssignPOForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_AssignPOForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_AssignPOForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on AssignPO_RequisitionLine...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPO_RequisitionLine = new SeleniumControl( sDriver, "AssignPO_RequisitionLine", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]/descendant::*[@id='RQ_LN_NO']");
				Function.AssertEqual(true,PPMNTRQ2_AssignPO_RequisitionLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on AssignPOTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPOTab = new SeleniumControl( sDriver, "AssignPOTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_AssignPOTab);
IWebElement mTab = PPMNTRQ2_AssignPOTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Purchase Order Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on AssignPO_PurchaseOrderInformation_Vendor...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPO_PurchaseOrderInformation_Vendor = new SeleniumControl( sDriver, "AssignPO_PurchaseOrderInformation_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,PPMNTRQ2_AssignPO_PurchaseOrderInformation_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on AssignPOTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPOTab = new SeleniumControl( sDriver, "AssignPOTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_AssignPOTab);
IWebElement mTab = PPMNTRQ2_AssignPOTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Functional Currency Amounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on AssignPO_FunctionalCurrencyAmounts_FunctionalCurrencyPOLineNegotiatedAmounts_GrossUnitCost...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPO_FunctionalCurrencyAmounts_FunctionalCurrencyPOLineNegotiatedAmounts_GrossUnitCost = new SeleniumControl( sDriver, "AssignPO_FunctionalCurrencyAmounts_FunctionalCurrencyPOLineNegotiatedAmounts_GrossUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]/descendant::*[@id='NEG_GROSS_UNIT_AMT']");
				Function.AssertEqual(true,PPMNTRQ2_AssignPO_FunctionalCurrencyAmounts_FunctionalCurrencyPOLineNegotiatedAmounts_GrossUnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on AssignPO_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPO_ExchangeRatesLink = new SeleniumControl( sDriver, "AssignPO_ExchangeRatesLink", "ID", "lnk_2972_PPMENTRQ_RQLNPO");
				Function.AssertEqual(true,PPMNTRQ2_AssignPO_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on AssignPO_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPO_ExchangeRatesLink = new SeleniumControl( sDriver, "AssignPO_ExchangeRatesLink", "ID", "lnk_2972_PPMENTRQ_RQLNPO");
				Function.WaitControlDisplayed(PPMNTRQ2_AssignPO_ExchangeRatesLink);
PPMNTRQ2_AssignPO_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_ExchangeRatesForm);
IWebElement formBttn = PPMNTRQ2_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on AssignPOForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AssignPOForm = new SeleniumControl( sDriver, "AssignPOForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNPO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_AssignPOForm);
IWebElement formBttn = PPMNTRQ2_AssignPOForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on TotalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_TotalsLink = new SeleniumControl( sDriver, "TotalsLink", "ID", "lnk_1005069_PPMENTRQ_RQHDR");
				Function.AssertEqual(true,PPMNTRQ2_TotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on TotalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_TotalsLink = new SeleniumControl( sDriver, "TotalsLink", "ID", "lnk_1005069_PPMENTRQ_RQHDR");
				Function.WaitControlDisplayed(PPMNTRQ2_TotalsLink);
PPMNTRQ2_TotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQ_TOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_TotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on Totals_CurrencyFunctional...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_Totals_CurrencyFunctional = new SeleniumControl( sDriver, "Totals_CurrencyFunctional", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQ_TOTALS_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMNTRQ2_Totals_CurrencyFunctional.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQ_TOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_TotalsForm);
IWebElement formBttn = PPMNTRQ2_TotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1005072_PPMENTRQ_RQHDR");
				Function.AssertEqual(true,PPMNTRQ2_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1005072_PPMENTRQ_RQHDR");
				Function.WaitControlDisplayed(PPMNTRQ2_ExchangeRatesLink);
PPMNTRQ2_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMNTRQ2_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_ExchangeRatesForm);
IWebElement formBttn = PPMNTRQ2_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007719_PPMENTRQ_RQHDR");
				Function.AssertEqual(true,PPMNTRQ2_HeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007719_PPMENTRQ_RQHDR");
				Function.WaitControlDisplayed(PPMNTRQ2_HeaderDocumentsLink);
PPMNTRQ2_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on HeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderDocumentsTable = new SeleniumControl( sDriver, "HeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_HeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_HeaderDocumentsForm);
IWebElement formBttn = PPMNTRQ2_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderDocuments_Document = new SeleniumControl( sDriver, "HeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPMNTRQ2_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_HDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_HeaderDocumentsForm);
IWebElement formBttn = PPMNTRQ2_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildForm);
IWebElement formBttn = PPMNTRQ2_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_Line...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_Line = new SeleniumControl( sDriver, "ChildForm_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='RQ_LN_NO']");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildFormTab);
IWebElement mTab = PPMNTRQ2_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_BasicInformation_Item...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_BasicInformation_Item = new SeleniumControl( sDriver, "ChildForm_BasicInformation_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_BasicInformation_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildFormTab);
IWebElement mTab = PPMNTRQ2_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Purchasing Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_PurchasingInformation_Buyer...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_PurchasingInformation_Buyer = new SeleniumControl( sDriver, "ChildForm_PurchasingInformation_Buyer", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='BUYER_ID']");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_PurchasingInformation_Buyer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildFormTab);
IWebElement mTab = PPMNTRQ2_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shipping & Receiving").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_ShippingAndReceiving_Warehouse...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_ShippingAndReceiving_Warehouse = new SeleniumControl( sDriver, "ChildForm_ShippingAndReceiving_Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_ShippingAndReceiving_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildFormTab);
IWebElement mTab = PPMNTRQ2_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_OtherInformation_Planner...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_OtherInformation_Planner = new SeleniumControl( sDriver, "ChildForm_OtherInformation_Planner", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='PLANNER_ID']");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_OtherInformation_Planner.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildFormTab);
IWebElement mTab = PPMNTRQ2_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildFormTab);
IWebElement mTab = PPMNTRQ2_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("ChildForm_SerialLotInfoForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_SerialLotLink = new SeleniumControl( sDriver, "ChildForm_SerialLotLink", "ID", "lnk_16762_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_SerialLotLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on ChildForm_SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_SerialLotLink = new SeleniumControl( sDriver, "ChildForm_SerialLotLink", "ID", "lnk_16762_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildForm_SerialLotLink);
PPMNTRQ2_ChildForm_SerialLotLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on ChildForm_SerialLotFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_SerialLotFormTable = new SeleniumControl( sDriver, "ChildForm_SerialLotFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_SERIALLOT_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_SerialLotFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_SerialLotForm = new SeleniumControl( sDriver, "ChildForm_SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_SERIALLOT_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_SerialLotForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on ChildForm_SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_SerialLotForm = new SeleniumControl( sDriver, "ChildForm_SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_SERIALLOT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildForm_SerialLotForm);
IWebElement formBttn = PPMNTRQ2_ChildForm_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_ChildForm_SerialLotForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_ChildForm_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_SerialLot_BasicInformation_Quantity...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_SerialLot_BasicInformation_Quantity = new SeleniumControl( sDriver, "ChildForm_SerialLot_BasicInformation_Quantity", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_SERIALLOT_DETL_']/ancestor::form[1]/descendant::*[@id='QTY']");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_SerialLot_BasicInformation_Quantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on ChildForm_SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_SerialLotForm = new SeleniumControl( sDriver, "ChildForm_SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_SERIALLOT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildForm_SerialLotForm);
IWebElement formBttn = PPMNTRQ2_ChildForm_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_AccountsLink = new SeleniumControl( sDriver, "ChildForm_AccountsLink", "ID", "lnk_1004758_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_AccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on ChildForm_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_AccountsLink = new SeleniumControl( sDriver, "ChildForm_AccountsLink", "ID", "lnk_1004758_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildForm_AccountsLink);
PPMNTRQ2_ChildForm_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_AccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on AccountsTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AccountsTable = new SeleniumControl( sDriver, "AccountsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_AccountsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_AccountsForm);
IWebElement formBttn = PPMNTRQ2_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_AccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on Accounts_Project...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_Accounts_Project = new SeleniumControl( sDriver, "Accounts_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PPMNTRQ2_Accounts_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_AccountsForm);
IWebElement formBttn = PPMNTRQ2_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1004757_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_LineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1004757_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildForm_LineChargesLink);
PPMNTRQ2_ChildForm_LineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_LineChargesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on LineChargesTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineChargesTable = new SeleniumControl( sDriver, "LineChargesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_LineChargesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_LineChargesForm);
IWebElement formBttn = PPMNTRQ2_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_LineChargesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on LineCharges_ChargeType...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineCharges_ChargeType = new SeleniumControl( sDriver, "LineCharges_ChargeType", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]/descendant::*[@id='LN_CHG_TYPE']");
				Function.AssertEqual(true,PPMNTRQ2_LineCharges_ChargeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_LineChargesForm);
IWebElement formBttn = PPMNTRQ2_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_LineTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_LineTextLink = new SeleniumControl( sDriver, "ChildForm_LineTextLink", "ID", "lnk_1004756_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_LineTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on ChildForm_LineTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_LineTextLink = new SeleniumControl( sDriver, "ChildForm_LineTextLink", "ID", "lnk_1004756_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildForm_LineTextLink);
PPMNTRQ2_ChildForm_LineTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on LineTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineTextForm = new SeleniumControl( sDriver, "LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_LineTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on LineTextTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineTextTable = new SeleniumControl( sDriver, "LineTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_LineTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on LineTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineTextForm = new SeleniumControl( sDriver, "LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_LineTextForm);
IWebElement formBttn = PPMNTRQ2_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_LineTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on LineText_Sequence...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineText_Sequence = new SeleniumControl( sDriver, "LineText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,PPMNTRQ2_LineText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on LineTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineTextForm = new SeleniumControl( sDriver, "LineTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_LineTextForm);
IWebElement formBttn = PPMNTRQ2_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("RFQs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_RFQsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_RFQsLink = new SeleniumControl( sDriver, "ChildForm_RFQsLink", "ID", "lnk_1004571_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_RFQsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on ChildForm_RFQsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_RFQsLink = new SeleniumControl( sDriver, "ChildForm_RFQsLink", "ID", "lnk_1004571_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildForm_RFQsLink);
PPMNTRQ2_ChildForm_RFQsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on RFQsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RFQsForm = new SeleniumControl( sDriver, "RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RFQLN_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_RFQsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on RFQsTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RFQsTable = new SeleniumControl( sDriver, "RFQsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RFQLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_RFQsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on RFQsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RFQsForm = new SeleniumControl( sDriver, "RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RFQLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_RFQsForm);
IWebElement formBttn = PPMNTRQ2_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_RFQsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on RFQs_RequestForQuote_RFQ...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RFQs_RequestForQuote_RFQ = new SeleniumControl( sDriver, "RFQs_RequestForQuote_RFQ", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RFQLN_']/ancestor::form[1]/descendant::*[@id='RFQ_ID']");
				Function.AssertEqual(true,PPMNTRQ2_RFQs_RequestForQuote_RFQ.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on RFQs_ItemVendorLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RFQs_ItemVendorLink = new SeleniumControl( sDriver, "RFQs_ItemVendorLink", "ID", "lnk_3021_PPMENTRQ_RFQLN");
				Function.AssertEqual(true,PPMNTRQ2_RFQs_ItemVendorLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on RFQsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_RFQsForm = new SeleniumControl( sDriver, "RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RFQLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_RFQsForm);
IWebElement formBttn = PPMNTRQ2_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_LineApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_LineApprovalsLink = new SeleniumControl( sDriver, "ChildForm_LineApprovalsLink", "ID", "lnk_1004576_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_LineApprovalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on ChildForm_LineApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_LineApprovalsLink = new SeleniumControl( sDriver, "ChildForm_LineApprovalsLink", "ID", "lnk_1004576_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildForm_LineApprovalsLink);
PPMNTRQ2_ChildForm_LineApprovalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on LineApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineApprovalsForm = new SeleniumControl( sDriver, "LineApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_LineApprovalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on LineApprovalsTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineApprovalsTable = new SeleniumControl( sDriver, "LineApprovalsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_LineApprovalsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on LineApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineApprovalsForm = new SeleniumControl( sDriver, "LineApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_LineApprovalsForm);
IWebElement formBttn = PPMNTRQ2_LineApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_LineApprovalsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_LineApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on LineApprovals_Sequence...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineApprovals_Sequence = new SeleniumControl( sDriver, "LineApprovals_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]/descendant::*[@id='APPRVL_SEQ_NO']");
				Function.AssertEqual(true,PPMNTRQ2_LineApprovals_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on LineApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineApprovalsForm = new SeleniumControl( sDriver, "LineApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMENTRQ_RQLNAPPRVL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_LineApprovalsForm);
IWebElement formBttn = PPMNTRQ2_LineApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007720_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007720_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildForm_LineDocumentsLink);
PPMNTRQ2_ChildForm_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on LineDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineDocumentsTable = new SeleniumControl( sDriver, "LineDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_LineDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_LineDocumentsForm);
IWebElement formBttn = PPMNTRQ2_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineDocuments_Document = new SeleniumControl( sDriver, "LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPMNTRQ2_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_LN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_LineDocumentsForm);
IWebElement formBttn = PPMNTRQ2_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_CurrencyLineLink = new SeleniumControl( sDriver, "ChildForm_CurrencyLineLink", "ID", "lnk_1004753_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_CurrencyLineLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on ChildForm_CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_CurrencyLineLink = new SeleniumControl( sDriver, "ChildForm_CurrencyLineLink", "ID", "lnk_1004753_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildForm_CurrencyLineLink);
PPMNTRQ2_ChildForm_CurrencyLineLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_CurrencyLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on CurrencyLine_LineAmounts_CurrencyFunctional...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_CurrencyLine_LineAmounts_CurrencyFunctional = new SeleniumControl( sDriver, "CurrencyLine_LineAmounts_CurrencyFunctional", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMNTRQ2_CurrencyLine_LineAmounts_CurrencyFunctional.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPRQCURL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_CurrencyLineForm);
IWebElement formBttn = PPMNTRQ2_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Substitutes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on ChildForm_SubstitutesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_SubstitutesLink = new SeleniumControl( sDriver, "ChildForm_SubstitutesLink", "ID", "lnk_16469_PPMENTRQ_RQLN");
				Function.AssertEqual(true,PPMNTRQ2_ChildForm_SubstitutesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Click on ChildForm_SubstitutesLink...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_ChildForm_SubstitutesLink = new SeleniumControl( sDriver, "ChildForm_SubstitutesLink", "ID", "lnk_16469_PPMENTRQ_RQLN");
				Function.WaitControlDisplayed(PPMNTRQ2_ChildForm_SubstitutesLink);
PPMNTRQ2_ChildForm_SubstitutesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on SubstitutesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_SubstitutesForm = new SeleniumControl( sDriver, "SubstitutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMNTRQ2_SubstitutesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExist on Substitutes_Table...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_Substitutes_Table = new SeleniumControl( sDriver, "Substitutes_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMNTRQ2_Substitutes_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing ClickButton on SubstitutesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_SubstitutesForm = new SeleniumControl( sDriver, "SubstitutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_SubstitutesForm);
IWebElement formBttn = PPMNTRQ2_SubstitutesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMNTRQ2_SubstitutesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMNTRQ2_SubstitutesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing VerifyExists on Substitutes_Sequence...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_Substitutes_Sequence = new SeleniumControl( sDriver, "Substitutes_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]/descendant::*[@id='USAGE_SEQ_NO']");
				Function.AssertEqual(true,PPMNTRQ2_Substitutes_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on SubstitutesForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_SubstitutesForm = new SeleniumControl( sDriver, "SubstitutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMMSUBSTPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_SubstitutesForm);
IWebElement formBttn = PPMNTRQ2_SubstitutesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PPMNTRQ2";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMNTRQ2] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMNTRQ2_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMNTRQ2_MainForm);
IWebElement formBttn = PPMNTRQ2_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

