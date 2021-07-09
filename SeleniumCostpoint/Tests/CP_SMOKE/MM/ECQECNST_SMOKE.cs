 
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
    public class ECQECNST_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Engineering Change Notices", "xpath","//div[@class='deptItem'][.='Engineering Change Notices']").Click();
new SeleniumControl(sDriver,"ECN Reports/Inquiries", "xpath","//div[@class='navItem'][.='ECN Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Engineering Change Notice Status", "xpath","//div[@class='navItem'][.='View Engineering Change Notice Status']").Click();


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
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ECQECNST_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on MainForm_ECN...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_MainForm_ECN = new SeleniumControl( sDriver, "MainForm_ECN", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ECN_ID']");
				Function.AssertEqual(true,ECQECNST_MainForm_ECN.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ECQECNST_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm);
IWebElement formBttn = ECQECNST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? ECQECNST_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
ECQECNST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECQECNST_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm);
IWebElement formBttn = ECQECNST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECQECNST_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECQECNST_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_ECN...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ECN = new SeleniumControl( sDriver, "ChildForm_ECN", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_DTL_']/ancestor::form[1]/descendant::*[@id='ECN_ID']");
				Function.AssertEqual(true,ECQECNST_ChildForm_ECN.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_BasicECNInfo_Class...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_BasicECNInfo_Class = new SeleniumControl( sDriver, "ChildForm_BasicECNInfo_Class", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_DTL_']/ancestor::form[1]/descendant::*[@id='S_ECN_CLASS_CD']");
				Function.AssertEqual(true,ECQECNST_ChildForm_BasicECNInfo_Class.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Select on ChildForm_tab1...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_tab1 = new SeleniumControl( sDriver, "ChildForm_tab1", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_tab1);
IWebElement mTab = ECQECNST_ChildForm_tab1.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "ECN Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_ECNDetails_EntryLastChangeInfo_LastChangeUser...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ECNDetails_EntryLastChangeInfo_LastChangeUser = new SeleniumControl( sDriver, "ChildForm_ECNDetails_EntryLastChangeInfo_LastChangeUser", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_DTL_']/ancestor::form[1]/descendant::*[@id='CHNG_USER_ID']");
				Function.AssertEqual(true,ECQECNST_ChildForm_ECNDetails_EntryLastChangeInfo_LastChangeUser.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Select on ChildForm_tab1...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_tab1 = new SeleniumControl( sDriver, "ChildForm_tab1", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_tab1);
IWebElement mTab = ECQECNST_ChildForm_tab1.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Customer Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_CustomerInfo_Customer...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_CustomerInfo_Customer = new SeleniumControl( sDriver, "ChildForm_CustomerInfo_Customer", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_DTL_']/ancestor::form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,ECQECNST_ChildForm_CustomerInfo_Customer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Select on ChildForm_tab1...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_tab1 = new SeleniumControl( sDriver, "ChildForm_tab1", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_tab1);
IWebElement mTab = ECQECNST_ChildForm_tab1.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Customer Address").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_CustomerAddress_Address_AddressLine1...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_CustomerAddress_Address_AddressLine1 = new SeleniumControl( sDriver, "ChildForm_CustomerAddress_Address_AddressLine1", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_DTL_']/ancestor::form[1]/descendant::*[@id='LN_1_ADDR']");
				Function.AssertEqual(true,ECQECNST_ChildForm_CustomerAddress_Address_AddressLine1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Impacted Projects");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Click on ChildForm_ImpactedProjectsLink...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ImpactedProjectsLink = new SeleniumControl( sDriver, "ChildForm_ImpactedProjectsLink", "ID", "lnk_1006333_ECQECNST_DTL");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_ImpactedProjectsLink);
ECQECNST_ChildForm_ImpactedProjectsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_ImpactedProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ImpactedProjectsForm = new SeleniumControl( sDriver, "ChildForm_ImpactedProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNDETAIL_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ECQECNST_ChildForm_ImpactedProjectsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExist on ChildForm_ImpactedProjectsFormTable...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ImpactedProjectsFormTable = new SeleniumControl( sDriver, "ChildForm_ImpactedProjectsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNDETAIL_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECQECNST_ChildForm_ImpactedProjectsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing ClickButton on ChildForm_ImpactedProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ImpactedProjectsForm = new SeleniumControl( sDriver, "ChildForm_ImpactedProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNDETAIL_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_ImpactedProjectsForm);
IWebElement formBttn = ECQECNST_ChildForm_ImpactedProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECQECNST_ChildForm_ImpactedProjectsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECQECNST_ChildForm_ImpactedProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_ImpactedProjects_Project...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ImpactedProjects_Project = new SeleniumControl( sDriver, "ChildForm_ImpactedProjects_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNDETAIL_DTL_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,ECQECNST_ChildForm_ImpactedProjects_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Close on ChildForm_ImpactedProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ImpactedProjectsForm = new SeleniumControl( sDriver, "ChildForm_ImpactedProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNDETAIL_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_ImpactedProjectsForm);
IWebElement formBttn = ECQECNST_ChildForm_ImpactedProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Approval");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Click on ChildForm_ApprovalLink...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ApprovalLink = new SeleniumControl( sDriver, "ChildForm_ApprovalLink", "ID", "lnk_4484_ECQECNST_DTL");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_ApprovalLink);
ECQECNST_ChildForm_ApprovalLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_ApprovalForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ApprovalForm = new SeleniumControl( sDriver, "ChildForm_ApprovalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNAPPRVL_APPROVDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ECQECNST_ChildForm_ApprovalForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExist on ChildForm_ApprovalFormTable...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ApprovalFormTable = new SeleniumControl( sDriver, "ChildForm_ApprovalFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNAPPRVL_APPROVDTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECQECNST_ChildForm_ApprovalFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing ClickButton on ChildForm_ApprovalForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ApprovalForm = new SeleniumControl( sDriver, "ChildForm_ApprovalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNAPPRVL_APPROVDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_ApprovalForm);
IWebElement formBttn = ECQECNST_ChildForm_ApprovalForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECQECNST_ChildForm_ApprovalForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECQECNST_ChildForm_ApprovalForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_Approval_Revision...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_Approval_Revision = new SeleniumControl( sDriver, "ChildForm_Approval_Revision", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNAPPRVL_APPROVDTL_']/ancestor::form[1]/descendant::*[@id='ECN_RVSN_NO']");
				Function.AssertEqual(true,ECQECNST_ChildForm_Approval_Revision.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Close on ChildForm_ApprovalForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ApprovalForm = new SeleniumControl( sDriver, "ChildForm_ApprovalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNAPPRVL_APPROVDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_ApprovalForm);
IWebElement formBttn = ECQECNST_ChildForm_ApprovalForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Groups");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Click on ChildForm_GroupsLink...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_GroupsLink = new SeleniumControl( sDriver, "ChildForm_GroupsLink", "ID", "lnk_4486_ECQECNST_DTL");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_GroupsLink);
ECQECNST_ChildForm_GroupsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_GroupsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_GroupsForm = new SeleniumControl( sDriver, "ChildForm_GroupsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_INPACTGRP_IMPACTEDGRP_']/ancestor::form[1]");
				Function.AssertEqual(true,ECQECNST_ChildForm_GroupsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExist on ChildForm_GroupsFormTable...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_GroupsFormTable = new SeleniumControl( sDriver, "ChildForm_GroupsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_INPACTGRP_IMPACTEDGRP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECQECNST_ChildForm_GroupsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing ClickButton on ChildForm_GroupsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_GroupsForm = new SeleniumControl( sDriver, "ChildForm_GroupsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_INPACTGRP_IMPACTEDGRP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_GroupsForm);
IWebElement formBttn = ECQECNST_ChildForm_GroupsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECQECNST_ChildForm_GroupsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECQECNST_ChildForm_GroupsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_Groups_ImpactedGroup...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_Groups_ImpactedGroup = new SeleniumControl( sDriver, "ChildForm_Groups_ImpactedGroup", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_INPACTGRP_IMPACTEDGRP_']/ancestor::form[1]/descendant::*[@id='IMPACT_GRP_CD']");
				Function.AssertEqual(true,ECQECNST_ChildForm_Groups_ImpactedGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Close on ChildForm_GroupsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_GroupsForm = new SeleniumControl( sDriver, "ChildForm_GroupsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_INPACTGRP_IMPACTEDGRP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_GroupsForm);
IWebElement formBttn = ECQECNST_ChildForm_GroupsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Parts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Click on ChildForm_PartsLink...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_PartsLink = new SeleniumControl( sDriver, "ChildForm_PartsLink", "ID", "lnk_4499_ECQECNST_DTL");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_PartsLink);
ECQECNST_ChildForm_PartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_PartsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_PartsForm = new SeleniumControl( sDriver, "ChildForm_PartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNPART_PARTSIMPACTED_']/ancestor::form[1]");
				Function.AssertEqual(true,ECQECNST_ChildForm_PartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExist on ChildForm_PartsFormTable...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_PartsFormTable = new SeleniumControl( sDriver, "ChildForm_PartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNPART_PARTSIMPACTED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECQECNST_ChildForm_PartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing ClickButton on ChildForm_PartsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_PartsForm = new SeleniumControl( sDriver, "ChildForm_PartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNPART_PARTSIMPACTED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_PartsForm);
IWebElement formBttn = ECQECNST_ChildForm_PartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECQECNST_ChildForm_PartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECQECNST_ChildForm_PartsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_Parts_OriginalPart_Active...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_Parts_OriginalPart_Active = new SeleniumControl( sDriver, "ChildForm_Parts_OriginalPart_Active", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNPART_PARTSIMPACTED_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ACT_FL']");
				Function.AssertEqual(true,ECQECNST_ChildForm_Parts_OriginalPart_Active.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Close on ChildForm_PartsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_PartsForm = new SeleniumControl( sDriver, "ChildForm_PartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNPART_PARTSIMPACTED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_PartsForm);
IWebElement formBttn = ECQECNST_ChildForm_PartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Click on ChildForm_DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_DocumentsLink = new SeleniumControl( sDriver, "ChildForm_DocumentsLink", "ID", "lnk_4516_ECQECNST_DTL");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_DocumentsLink);
ECQECNST_ChildForm_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_DocumentsForm = new SeleniumControl( sDriver, "ChildForm_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]");
				Function.AssertEqual(true,ECQECNST_ChildForm_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExist on ChildForm_DocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_DocumentsFormTable = new SeleniumControl( sDriver, "ChildForm_DocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECQECNST_ChildForm_DocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing ClickButton on ChildForm_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_DocumentsForm = new SeleniumControl( sDriver, "ChildForm_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_DocumentsForm);
IWebElement formBttn = ECQECNST_ChildForm_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECQECNST_ChildForm_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECQECNST_ChildForm_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_Documents_ChangeToDocument_CAGE...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_Documents_ChangeToDocument_CAGE = new SeleniumControl( sDriver, "ChildForm_Documents_ChangeToDocument_CAGE", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]/descendant::*[@id='CAGE_ID_FLD']");
				Function.AssertEqual(true,ECQECNST_ChildForm_Documents_ChangeToDocument_CAGE.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Close on ChildForm_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_DocumentsForm = new SeleniumControl( sDriver, "ChildForm_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_DocumentsForm);
IWebElement formBttn = ECQECNST_ChildForm_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("User-Defined Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Click on ChildForm_UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_UserDefinedInfoLink = new SeleniumControl( sDriver, "ChildForm_UserDefinedInfoLink", "ID", "lnk_4779_ECQECNST_DTL");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_UserDefinedInfoLink);
ECQECNST_ChildForm_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_UserDefinedInfoForm = new SeleniumControl( sDriver, "ChildForm_UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,ECQECNST_ChildForm_UserDefinedInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExist on ChildForm_UserDefinedInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_UserDefinedInfoFormTable = new SeleniumControl( sDriver, "ChildForm_UserDefinedInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECQECNST_ChildForm_UserDefinedInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Close on ChildForm_UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_UserDefinedInfoForm = new SeleniumControl( sDriver, "ChildForm_UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_UserDefinedInfoForm);
IWebElement formBttn = ECQECNST_ChildForm_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Notes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Click on ChildForm_NotesLink...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_NotesLink = new SeleniumControl( sDriver, "ChildForm_NotesLink", "ID", "lnk_4575_ECQECNST_DTL");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_NotesLink);
ECQECNST_ChildForm_NotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_NotesForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_NotesForm = new SeleniumControl( sDriver, "ChildForm_NotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNTX_NOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,ECQECNST_ChildForm_NotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_Notes_Notes = new SeleniumControl( sDriver, "ChildForm_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNTX_NOTES_']/ancestor::form[1]/descendant::*[@id='ECN_TX']");
				Function.AssertEqual(true,ECQECNST_ChildForm_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Close on ChildForm_NotesForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_NotesForm = new SeleniumControl( sDriver, "ChildForm_NotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNTX_NOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_NotesForm);
IWebElement formBttn = ECQECNST_ChildForm_NotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Implementation Notes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Click on ChildForm_ImplmentationNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ImplmentationNotesLink = new SeleniumControl( sDriver, "ChildForm_ImplmentationNotesLink", "ID", "lnk_4568_ECQECNST_DTL");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_ImplmentationNotesLink);
ECQECNST_ChildForm_ImplmentationNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_ImplementationNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ImplementationNotesForm = new SeleniumControl( sDriver, "ChildForm_ImplementationNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNIMPLTX_NOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,ECQECNST_ChildForm_ImplementationNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_ImplementationNotes_Notes...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ImplementationNotes_Notes = new SeleniumControl( sDriver, "ChildForm_ImplementationNotes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNIMPLTX_NOTES_']/ancestor::form[1]/descendant::*[@id='ECN_IMPL_TX']");
				Function.AssertEqual(true,ECQECNST_ChildForm_ImplementationNotes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Close on ChildForm_ImplementationNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ImplementationNotesForm = new SeleniumControl( sDriver, "ChildForm_ImplementationNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNIMPLTX_NOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_ImplementationNotesForm);
IWebElement formBttn = ECQECNST_ChildForm_ImplementationNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Technical Notes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Click on ChildForm_TechnicalNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_TechnicalNotesLink = new SeleniumControl( sDriver, "ChildForm_TechnicalNotesLink", "ID", "lnk_4569_ECQECNST_DTL");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_TechnicalNotesLink);
ECQECNST_ChildForm_TechnicalNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_TechnicalNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_TechnicalNotesForm = new SeleniumControl( sDriver, "ChildForm_TechnicalNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNTECHTX_NOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,ECQECNST_ChildForm_TechnicalNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_TechnicalNotes_Notes...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_TechnicalNotes_Notes = new SeleniumControl( sDriver, "ChildForm_TechnicalNotes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNTECHTX_NOTES_']/ancestor::form[1]/descendant::*[@id='ECN_TECH_TX']");
				Function.AssertEqual(true,ECQECNST_ChildForm_TechnicalNotes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Close on ChildForm_TechnicalNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_TechnicalNotesForm = new SeleniumControl( sDriver, "ChildForm_TechnicalNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNTECHTX_NOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_TechnicalNotesForm);
IWebElement formBttn = ECQECNST_ChildForm_TechnicalNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Customer Details");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Click on ChildForm_CustomerDetailsLink...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_CustomerDetailsLink = new SeleniumControl( sDriver, "ChildForm_CustomerDetailsLink", "ID", "lnk_4864_ECQECNST_DTL");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_CustomerDetailsLink);
ECQECNST_ChildForm_CustomerDetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_CustomerDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_CustomerDetailsForm = new SeleniumControl( sDriver, "ChildForm_CustomerDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_CUSTADDRCNTACT_DETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,ECQECNST_ChildForm_CustomerDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExist on ChildForm_CustomerDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_CustomerDetailsFormTable = new SeleniumControl( sDriver, "ChildForm_CustomerDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_CUSTADDRCNTACT_DETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECQECNST_ChildForm_CustomerDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing ClickButton on ChildForm_CustomerDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_CustomerDetailsForm = new SeleniumControl( sDriver, "ChildForm_CustomerDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_CUSTADDRCNTACT_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_CustomerDetailsForm);
IWebElement formBttn = ECQECNST_ChildForm_CustomerDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECQECNST_ChildForm_CustomerDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECQECNST_ChildForm_CustomerDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_CustomerDetails_ContactID...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_CustomerDetails_ContactID = new SeleniumControl( sDriver, "ChildForm_CustomerDetails_ContactID", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_CUSTADDRCNTACT_DETAIL_']/ancestor::form[1]/descendant::*[@id='CNTACT_ID']");
				Function.AssertEqual(true,ECQECNST_ChildForm_CustomerDetails_ContactID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Close on ChildForm_CustomerDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_CustomerDetailsForm = new SeleniumControl( sDriver, "ChildForm_CustomerDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_CUSTADDRCNTACT_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_CustomerDetailsForm);
IWebElement formBttn = ECQECNST_ChildForm_CustomerDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Standard Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Click on ChildForm_StandardTextLink...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_StandardTextLink = new SeleniumControl( sDriver, "ChildForm_StandardTextLink", "ID", "lnk_5371_ECQECNST_DTL");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_StandardTextLink);
ECQECNST_ChildForm_StandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_StandardTextForm = new SeleniumControl( sDriver, "ChildForm_StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_TEXTCODES_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ECQECNST_ChildForm_StandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExist on ChildForm_StandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_StandardTextFormTable = new SeleniumControl( sDriver, "ChildForm_StandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_TEXTCODES_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECQECNST_ChildForm_StandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing ClickButton on ChildForm_StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_StandardTextForm = new SeleniumControl( sDriver, "ChildForm_StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_TEXTCODES_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_StandardTextForm);
IWebElement formBttn = ECQECNST_ChildForm_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECQECNST_ChildForm_StandardTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECQECNST_ChildForm_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_StandardText_Sequence...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_StandardText_Sequence = new SeleniumControl( sDriver, "ChildForm_StandardText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_TEXTCODES_DTL_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,ECQECNST_ChildForm_StandardText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Close on ChildForm_StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_StandardTextForm = new SeleniumControl( sDriver, "ChildForm_StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_TEXTCODES_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_StandardTextForm);
IWebElement formBttn = ECQECNST_ChildForm_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ECN Workflow");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Click on ChildForm_ECNWorkFlowLink...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ECNWorkFlowLink = new SeleniumControl( sDriver, "ChildForm_ECNWorkFlowLink", "ID", "lnk_5372_ECQECNST_DTL");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_ECNWorkFlowLink);
ECQECNST_ChildForm_ECNWorkFlowLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_ECNWorkFlowForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ECNWorkFlowForm = new SeleniumControl( sDriver, "ChildForm_ECNWorkFlowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNWORKFLOW_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ECQECNST_ChildForm_ECNWorkFlowForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExist on ChildForm_ECNWorkFlowFormTable...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ECNWorkFlowFormTable = new SeleniumControl( sDriver, "ChildForm_ECNWorkFlowFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNWORKFLOW_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECQECNST_ChildForm_ECNWorkFlowFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing ClickButton on ChildForm_ECNWorkFlowForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ECNWorkFlowForm = new SeleniumControl( sDriver, "ChildForm_ECNWorkFlowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNWORKFLOW_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_ECNWorkFlowForm);
IWebElement formBttn = ECQECNST_ChildForm_ECNWorkFlowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECQECNST_ChildForm_ECNWorkFlowForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECQECNST_ChildForm_ECNWorkFlowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing VerifyExists on ChildForm_ECNWorkFlow_Activity...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ECNWorkFlow_Activity = new SeleniumControl( sDriver, "ChildForm_ECNWorkFlow_Activity", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNWORKFLOW_DTL_']/ancestor::form[1]/descendant::*[@id='ACTVTY_NAME']");
				Function.AssertEqual(true,ECQECNST_ChildForm_ECNWorkFlow_Activity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Close on ChildForm_ECNWorkFlowForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_ChildForm_ECNWorkFlowForm = new SeleniumControl( sDriver, "ChildForm_ECNWorkFlowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECQECNST_ECNWORKFLOW_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECQECNST_ChildForm_ECNWorkFlowForm);
IWebElement formBttn = ECQECNST_ChildForm_ECNWorkFlowForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECQECNST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECQECNST] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECQECNST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECQECNST_MainForm);
IWebElement formBttn = ECQECNST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

