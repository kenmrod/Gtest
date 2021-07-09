 
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
    public class ECMAMAIN_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Engineering Change Processing", "xpath","//div[@class='navItem'][.='Engineering Change Processing']").Click();
new SeleniumControl(sDriver,"Update Approved Engineering Change Notices", "xpath","//div[@class='navItem'][.='Update Approved Engineering Change Notices']").Click();


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
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ECMAMAIN_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on ECNID...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ECNID = new SeleniumControl( sDriver, "ECNID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ECN_ID']");
				Function.AssertEqual(true,ECMAMAIN_ECNID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_MainForm);
IWebElement formBttn = ECMAMAIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? ECMAMAIN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
ECMAMAIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_MainForm);
IWebElement formBttn = ECMAMAIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ECMAMAIN_Tab);
IWebElement mTab = ECMAMAIN_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on BasicInfo_Type...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_BasicInfo_Type = new SeleniumControl( sDriver, "BasicInfo_Type", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EC_TYPE_CD']");
				Function.AssertEqual(true,ECMAMAIN_BasicInfo_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ECMAMAIN_Tab);
IWebElement mTab = ECMAMAIN_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on Details_Project...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Details_Project = new SeleniumControl( sDriver, "Details_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CHG_PROJ_ID']");
				Function.AssertEqual(true,ECMAMAIN_Details_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ECMAMAIN_Tab);
IWebElement mTab = ECMAMAIN_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Customer Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on CustomerInformation_ECP...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_CustomerInformation_ECP = new SeleniumControl( sDriver, "CustomerInformation_ECP", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ECP_ID']");
				Function.AssertEqual(true,ECMAMAIN_CustomerInformation_ECP.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ECMAMAIN_Tab);
IWebElement mTab = ECMAMAIN_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Customer Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on CustomerNotes_Notes...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_CustomerNotes_Notes = new SeleniumControl( sDriver, "CustomerNotes_Notes", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_NOTES']");
				Function.AssertEqual(true,ECMAMAIN_CustomerNotes_Notes.Exists());

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
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on ImpactedProjectsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ImpactedProjectsLink = new SeleniumControl( sDriver, "ImpactedProjectsLink", "ID", "lnk_15616_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.AssertEqual(true,ECMAMAIN_ImpactedProjectsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on ImpactedProjectsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ImpactedProjectsLink = new SeleniumControl( sDriver, "ImpactedProjectsLink", "ID", "lnk_15616_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.WaitControlDisplayed(ECMAMAIN_ImpactedProjectsLink);
ECMAMAIN_ImpactedProjectsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on ImpactedProjectsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ImpactedProjectsTable = new SeleniumControl( sDriver, "ImpactedProjectsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_ImpactedProjectsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on ImpactedProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ImpactedProjectsForm = new SeleniumControl( sDriver, "ImpactedProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_ImpactedProjectsForm);
IWebElement formBttn = ECMAMAIN_ImpactedProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_ImpactedProjectsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_ImpactedProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on ImpactedProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ImpactedProjectsForm = new SeleniumControl( sDriver, "ImpactedProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_ImpactedProjectsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on ImpactedProjects_Project...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ImpactedProjects_Project = new SeleniumControl( sDriver, "ImpactedProjects_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,ECMAMAIN_ImpactedProjects_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on ImpactedProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ImpactedProjectsForm = new SeleniumControl( sDriver, "ImpactedProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_ImpactedProjectsForm);
IWebElement formBttn = ECMAMAIN_ImpactedProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Approvals");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on ApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ApprovalsLink = new SeleniumControl( sDriver, "ApprovalsLink", "ID", "lnk_15617_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.AssertEqual(true,ECMAMAIN_ApprovalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on ApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ApprovalsLink = new SeleniumControl( sDriver, "ApprovalsLink", "ID", "lnk_15617_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.WaitControlDisplayed(ECMAMAIN_ApprovalsLink);
ECMAMAIN_ApprovalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on ApprovalsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ApprovalsTable = new SeleniumControl( sDriver, "ApprovalsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_ApprovalsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on ApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ApprovalsForm = new SeleniumControl( sDriver, "ApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_ApprovalsForm);
IWebElement formBttn = ECMAMAIN_ApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_ApprovalsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_ApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on ApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ApprovalsForm = new SeleniumControl( sDriver, "ApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_ApprovalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on Approvals_Revision...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Approvals_Revision = new SeleniumControl( sDriver, "Approvals_Revision", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]/descendant::*[@id='ECN_RVSN_NO']");
				Function.AssertEqual(true,ECMAMAIN_Approvals_Revision.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on ApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ApprovalsForm = new SeleniumControl( sDriver, "ApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_ApprovalsForm);
IWebElement formBttn = ECMAMAIN_ApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("General Notes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on GeneralNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_GeneralNotesLink = new SeleniumControl( sDriver, "GeneralNotesLink", "ID", "lnk_15618_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.AssertEqual(true,ECMAMAIN_GeneralNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on GeneralNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_GeneralNotesLink = new SeleniumControl( sDriver, "GeneralNotesLink", "ID", "lnk_15618_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.WaitControlDisplayed(ECMAMAIN_GeneralNotesLink);
ECMAMAIN_GeneralNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on GeneralNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_GeneralNotesForm = new SeleniumControl( sDriver, "GeneralNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_GeneralNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on GeneralNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_GeneralNotesForm = new SeleniumControl( sDriver, "GeneralNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_GeneralNotesForm);
IWebElement formBttn = ECMAMAIN_GeneralNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on TechnicalNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_TechnicalNotesLink = new SeleniumControl( sDriver, "TechnicalNotesLink", "ID", "lnk_15619_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.AssertEqual(true,ECMAMAIN_TechnicalNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on TechnicalNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_TechnicalNotesLink = new SeleniumControl( sDriver, "TechnicalNotesLink", "ID", "lnk_15619_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.WaitControlDisplayed(ECMAMAIN_TechnicalNotesLink);
ECMAMAIN_TechnicalNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on TechnicalNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_TechnicalNotesForm = new SeleniumControl( sDriver, "TechnicalNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTECHNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_TechnicalNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on TechnicalNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_TechnicalNotesForm = new SeleniumControl( sDriver, "TechnicalNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTECHNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_TechnicalNotesForm);
IWebElement formBttn = ECMAMAIN_TechnicalNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on ImplementationNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ImplementationNotesLink = new SeleniumControl( sDriver, "ImplementationNotesLink", "ID", "lnk_15620_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.AssertEqual(true,ECMAMAIN_ImplementationNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on ImplementationNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ImplementationNotesLink = new SeleniumControl( sDriver, "ImplementationNotesLink", "ID", "lnk_15620_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.WaitControlDisplayed(ECMAMAIN_ImplementationNotesLink);
ECMAMAIN_ImplementationNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on ImplementationNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ImplementationNotesForm = new SeleniumControl( sDriver, "ImplementationNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNIMPLNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_ImplementationNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on ImplementationNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ImplementationNotesForm = new SeleniumControl( sDriver, "ImplementationNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNIMPLNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_ImplementationNotesForm);
IWebElement formBttn = ECMAMAIN_ImplementationNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on TextLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_TextLink = new SeleniumControl( sDriver, "TextLink", "ID", "lnk_15621_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.AssertEqual(true,ECMAMAIN_TextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on TextLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_TextLink = new SeleniumControl( sDriver, "TextLink", "ID", "lnk_15621_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.WaitControlDisplayed(ECMAMAIN_TextLink);
ECMAMAIN_TextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on TextTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_TextTable = new SeleniumControl( sDriver, "TextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_TextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on TextForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_TextForm);
IWebElement formBttn = ECMAMAIN_TextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_TextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_TextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on TextForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_TextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on Text_Sequence...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Text_Sequence = new SeleniumControl( sDriver, "Text_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,ECMAMAIN_Text_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on TextForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_TextForm);
IWebElement formBttn = ECMAMAIN_TextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_DocumentsLink = new SeleniumControl( sDriver, "DocumentsLink", "ID", "lnk_15622_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.AssertEqual(true,ECMAMAIN_DocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_DocumentsLink = new SeleniumControl( sDriver, "DocumentsLink", "ID", "lnk_15622_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.WaitControlDisplayed(ECMAMAIN_DocumentsLink);
ECMAMAIN_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on DocumentsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_DocumentsTable = new SeleniumControl( sDriver, "DocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_DocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_DocumentsForm);
IWebElement formBttn = ECMAMAIN_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on Documents_Line...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Documents_Line = new SeleniumControl( sDriver, "Documents_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]/descendant::*[@id='LINE']");
				Function.AssertEqual(true,ECMAMAIN_Documents_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_DocumentsForm);
IWebElement formBttn = ECMAMAIN_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EC Impacted Groups");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on ECImpactedGroupsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ECImpactedGroupsLink = new SeleniumControl( sDriver, "ECImpactedGroupsLink", "ID", "lnk_15623_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.AssertEqual(true,ECMAMAIN_ECImpactedGroupsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on ECImpactedGroupsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ECImpactedGroupsLink = new SeleniumControl( sDriver, "ECImpactedGroupsLink", "ID", "lnk_15623_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.WaitControlDisplayed(ECMAMAIN_ECImpactedGroupsLink);
ECMAMAIN_ECImpactedGroupsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on ECImpactedGroups_ImpactedGroupTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ECImpactedGroups_ImpactedGroupTable = new SeleniumControl( sDriver, "ECImpactedGroups_ImpactedGroupTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_INPACTGRP_IMPACTEDGRP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_ECImpactedGroups_ImpactedGroupTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on ECImpactedGroups_SelectedGroupTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ECImpactedGroups_SelectedGroupTable = new SeleniumControl( sDriver, "ECImpactedGroups_SelectedGroupTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNIMPACTGRP_SELIMPGRP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_ECImpactedGroups_SelectedGroupTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on ECImpactedGroups_SelectedGroupForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_ECImpactedGroups_SelectedGroupForm = new SeleniumControl( sDriver, "ECImpactedGroups_SelectedGroupForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNIMPACTGRP_SELIMPGRP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_ECImpactedGroups_SelectedGroupForm);
IWebElement formBttn = ECMAMAIN_ECImpactedGroups_SelectedGroupForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("User Defined Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_15625_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.AssertEqual(true,ECMAMAIN_UserDefinedInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_15625_ECMMAIN_ECN_MAINTAPPROVEDECN");
				Function.WaitControlDisplayed(ECMAMAIN_UserDefinedInfoLink);
ECMAMAIN_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on UserDefinedInfoTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_UserDefinedInfoTable = new SeleniumControl( sDriver, "UserDefinedInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_UserDefinedInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_UserDefinedInfoForm);
IWebElement formBttn = ECMAMAIN_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_UserDefinedInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_UserDefinedInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on UserDefinedInfo_DataType...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_UserDefinedInfo_DataType = new SeleniumControl( sDriver, "UserDefinedInfo_DataType", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='DATA_TYPE']");
				Function.AssertEqual(true,ECMAMAIN_UserDefinedInfo_DataType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_UserDefinedInfoForm);
IWebElement formBttn = ECMAMAIN_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on PartsImpactedTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_PartsImpactedTable = new SeleniumControl( sDriver, "PartsImpactedTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPART_PARTSIMPACTED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_PartsImpactedTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on PartsImpactedForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_PartsImpactedForm = new SeleniumControl( sDriver, "PartsImpactedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPART_PARTSIMPACTED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_PartsImpactedForm);
IWebElement formBttn = ECMAMAIN_PartsImpactedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_PartsImpactedForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_PartsImpactedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on PartsImpactedForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_PartsImpactedForm = new SeleniumControl( sDriver, "PartsImpactedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPART_PARTSIMPACTED_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_PartsImpactedForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on PartsImpacted_Line...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_PartsImpacted_Line = new SeleniumControl( sDriver, "PartsImpacted_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPART_PARTSIMPACTED_']/ancestor::form[1]/descendant::*[@id='ECN_PART_LN_NO']");
				Function.AssertEqual(true,ECMAMAIN_PartsImpacted_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Part Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_15590_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMAMAIN_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_15590_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAMAIN_PartDocumentsLink);
ECMAMAIN_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on PartsImpacted_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_PartsImpacted_PartDocumentsForm = new SeleniumControl( sDriver, "PartsImpacted_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_PARTDOC_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_PartsImpacted_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on PartsImpacted_PartDocuments_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_PartsImpacted_PartDocuments_Part = new SeleniumControl( sDriver, "PartsImpacted_PartDocuments_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_PARTDOC_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMAMAIN_PartsImpacted_PartDocuments_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on PartDocuments_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_PartDocuments_DocumentsForm = new SeleniumControl( sDriver, "PartDocuments_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTDOCUMENT_PARTDO_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_PartDocuments_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on PartDocuments_DocumentsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_PartDocuments_DocumentsTable = new SeleniumControl( sDriver, "PartDocuments_DocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTDOCUMENT_PARTDO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_PartDocuments_DocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on PartDocuments_DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_PartDocuments_DocumentsForm = new SeleniumControl( sDriver, "PartDocuments_DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTDOCUMENT_PARTDO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_PartDocuments_DocumentsForm);
IWebElement formBttn = ECMAMAIN_PartDocuments_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_PartDocuments_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_PartDocuments_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on PartsImpacted_PartDocuments_Line...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_PartsImpacted_PartDocuments_Line = new SeleniumControl( sDriver, "PartsImpacted_PartDocuments_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTDOCUMENT_PARTDO_']/ancestor::form[1]/descendant::*[@id='LINE_NO']");
				Function.AssertEqual(true,ECMAMAIN_PartsImpacted_PartDocuments_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on PartsImpacted_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_PartsImpacted_PartDocumentsForm = new SeleniumControl( sDriver, "PartsImpacted_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_PARTDOC_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_PartsImpacted_PartDocumentsForm);
IWebElement formBttn = ECMAMAIN_PartsImpacted_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MBOM Components");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMComponentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMComponentsLink = new SeleniumControl( sDriver, "MBOMComponentsLink", "ID", "lnk_15593_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMAMAIN_MBOMComponentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on MBOMComponentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMComponentsLink = new SeleniumControl( sDriver, "MBOMComponentsLink", "ID", "lnk_15593_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAMAIN_MBOMComponentsLink);
ECMAMAIN_MBOMComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMAssemblyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMAssemblyForm = new SeleniumControl( sDriver, "MBOMAssemblyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCOMP_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_MBOMAssemblyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMComponents_MBOMAssembly_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMComponents_MBOMAssembly_Part = new SeleniumControl( sDriver, "MBOMComponents_MBOMAssembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCOMP_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMAMAIN_MBOMComponents_MBOMAssembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on MBOMComponents_MBOMAssembly_ComponentTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMComponents_MBOMAssembly_ComponentTable = new SeleniumControl( sDriver, "MBOMComponents_MBOMAssembly_ComponentTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMCOMP_MBOMCOMP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_MBOMComponents_MBOMAssembly_ComponentTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on MBOMComponents_MBOMAssembly_ComponentForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMComponents_MBOMAssembly_ComponentForm = new SeleniumControl( sDriver, "MBOMComponents_MBOMAssembly_ComponentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMCOMP_MBOMCOMP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_MBOMComponents_MBOMAssembly_ComponentForm);
IWebElement formBttn = ECMAMAIN_MBOMComponents_MBOMAssembly_ComponentForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_MBOMComponents_MBOMAssembly_ComponentForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_MBOMComponents_MBOMAssembly_ComponentForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMComponents_MBOMAssembly_ComponentForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMComponents_MBOMAssembly_ComponentForm = new SeleniumControl( sDriver, "MBOMComponents_MBOMAssembly_ComponentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMCOMP_MBOMCOMP_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_MBOMComponents_MBOMAssembly_ComponentForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMComponents_Component_ActionCode...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMComponents_Component_ActionCode = new SeleniumControl( sDriver, "MBOMComponents_Component_ActionCode", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMCOMP_MBOMCOMP_']/ancestor::form[1]/descendant::*[@id='S_ECN_ACTION_CD']");
				Function.AssertEqual(true,ECMAMAIN_MBOMComponents_Component_ActionCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on MBOMAssemblyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMAssemblyForm = new SeleniumControl( sDriver, "MBOMAssemblyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCOMP_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_MBOMAssemblyForm);
IWebElement formBttn = ECMAMAIN_MBOMAssemblyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MBOM Orig Assy");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMOrigAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMOrigAssyLink = new SeleniumControl( sDriver, "MBOMOrigAssyLink", "ID", "lnk_15597_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMAMAIN_MBOMOrigAssyLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on MBOMOrigAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMOrigAssyLink = new SeleniumControl( sDriver, "MBOMOrigAssyLink", "ID", "lnk_15597_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAMAIN_MBOMOrigAssyLink);
ECMAMAIN_MBOMOrigAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMOrigAssy_ComponentForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMOrigAssy_ComponentForm = new SeleniumControl( sDriver, "MBOMOrigAssy_ComponentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMORIG_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_MBOMOrigAssy_ComponentForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMOrigAssy_Component_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMOrigAssy_Component_Part = new SeleniumControl( sDriver, "MBOMOrigAssy_Component_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMORIG_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMAMAIN_MBOMOrigAssy_Component_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on MBOMOrigAssy_AssemblyTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMOrigAssy_AssemblyTable = new SeleniumControl( sDriver, "MBOMOrigAssy_AssemblyTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMORPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_MBOMOrigAssy_AssemblyTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on MBOMOrigAssy_AssemblyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMOrigAssy_AssemblyForm = new SeleniumControl( sDriver, "MBOMOrigAssy_AssemblyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMORPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_MBOMOrigAssy_AssemblyForm);
IWebElement formBttn = ECMAMAIN_MBOMOrigAssy_AssemblyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_MBOMOrigAssy_AssemblyForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_MBOMOrigAssy_AssemblyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMOrigAssy_Assembly_ActionCode...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMOrigAssy_Assembly_ActionCode = new SeleniumControl( sDriver, "MBOMOrigAssy_Assembly_ActionCode", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMORPART_']/ancestor::form[1]/descendant::*[@id='S_ECN_ACTION_CD']");
				Function.AssertEqual(true,ECMAMAIN_MBOMOrigAssy_Assembly_ActionCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on MBOMOrigAssy_ComponentForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMOrigAssy_ComponentForm = new SeleniumControl( sDriver, "MBOMOrigAssy_ComponentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMORIG_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_MBOMOrigAssy_ComponentForm);
IWebElement formBttn = ECMAMAIN_MBOMOrigAssy_ComponentForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MBOM Chng Assy");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMChngAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMChngAssyLink = new SeleniumControl( sDriver, "MBOMChngAssyLink", "ID", "lnk_15599_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMAMAIN_MBOMChngAssyLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on MBOMChngAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMChngAssyLink = new SeleniumControl( sDriver, "MBOMChngAssyLink", "ID", "lnk_15599_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAMAIN_MBOMChngAssyLink);
ECMAMAIN_MBOMChngAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMChngAssy_ComponentForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMChngAssy_ComponentForm = new SeleniumControl( sDriver, "MBOMChngAssy_ComponentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCHNG_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_MBOMChngAssy_ComponentForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMChngAssy_Component_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMChngAssy_Component_Part = new SeleniumControl( sDriver, "MBOMChngAssy_Component_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCHNG_HDR_']/ancestor::form[1]/descendant::*[@id='CHNG_PART_ID']");
				Function.AssertEqual(true,ECMAMAIN_MBOMChngAssy_Component_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on MBOMChngAssy_AssemblyTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMChngAssy_AssemblyTable = new SeleniumControl( sDriver, "MBOMChngAssy_AssemblyTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMCHGPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_MBOMChngAssy_AssemblyTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on MBOMChngAssy_AssemblyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMChngAssy_AssemblyForm = new SeleniumControl( sDriver, "MBOMChngAssy_AssemblyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMCHGPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_MBOMChngAssy_AssemblyForm);
IWebElement formBttn = ECMAMAIN_MBOMChngAssy_AssemblyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_MBOMChngAssy_AssemblyForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_MBOMChngAssy_AssemblyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMChngAssy_AssemblyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMChngAssy_AssemblyForm = new SeleniumControl( sDriver, "MBOMChngAssy_AssemblyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMCHGPART_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_MBOMChngAssy_AssemblyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on MBOMChngAssy_Assembly_ActionCode...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMChngAssy_Assembly_ActionCode = new SeleniumControl( sDriver, "MBOMChngAssy_Assembly_ActionCode", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMCHGPART_']/ancestor::form[1]/descendant::*[@id='S_ECN_ACTION_CD']");
				Function.AssertEqual(true,ECMAMAIN_MBOMChngAssy_Assembly_ActionCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on MBOMChngAssy_ComponentForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MBOMChngAssy_ComponentForm = new SeleniumControl( sDriver, "MBOMChngAssy_ComponentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCHNG_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_MBOMChngAssy_ComponentForm);
IWebElement formBttn = ECMAMAIN_MBOMChngAssy_ComponentForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EBOM Components");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMComponentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMComponentsLink = new SeleniumControl( sDriver, "EBOMComponentsLink", "ID", "lnk_15602_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMAMAIN_EBOMComponentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on EBOMComponentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMComponentsLink = new SeleniumControl( sDriver, "EBOMComponentsLink", "ID", "lnk_15602_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAMAIN_EBOMComponentsLink);
ECMAMAIN_EBOMComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMComponentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMComponentsForm = new SeleniumControl( sDriver, "EBOMComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCOMP_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_EBOMComponentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMComponents_Assembly_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMComponents_Assembly_Part = new SeleniumControl( sDriver, "EBOMComponents_Assembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCOMP_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMAMAIN_EBOMComponents_Assembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on EBOMComponents_ComponentTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMComponents_ComponentTable = new SeleniumControl( sDriver, "EBOMComponents_ComponentTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMCOMP_EBOMCOMP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_EBOMComponents_ComponentTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on EBOMComponents_ComponentForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMComponents_ComponentForm = new SeleniumControl( sDriver, "EBOMComponents_ComponentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMCOMP_EBOMCOMP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_EBOMComponents_ComponentForm);
IWebElement formBttn = ECMAMAIN_EBOMComponents_ComponentForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_EBOMComponents_ComponentForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_EBOMComponents_ComponentForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMComponents_ComponentForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMComponents_ComponentForm = new SeleniumControl( sDriver, "EBOMComponents_ComponentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMCOMP_EBOMCOMP_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_EBOMComponents_ComponentForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMComponents_Component_ActionCode...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMComponents_Component_ActionCode = new SeleniumControl( sDriver, "EBOMComponents_Component_ActionCode", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMCOMP_EBOMCOMP_']/ancestor::form[1]/descendant::*[@id='S_ECN_ACTION_CD']");
				Function.AssertEqual(true,ECMAMAIN_EBOMComponents_Component_ActionCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on EBOMComponentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMComponentsForm = new SeleniumControl( sDriver, "EBOMComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCOMP_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_EBOMComponentsForm);
IWebElement formBttn = ECMAMAIN_EBOMComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EBOM Orig Assy");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMOrigAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMOrigAssyLink = new SeleniumControl( sDriver, "EBOMOrigAssyLink", "ID", "lnk_15606_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMAMAIN_EBOMOrigAssyLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on EBOMOrigAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMOrigAssyLink = new SeleniumControl( sDriver, "EBOMOrigAssyLink", "ID", "lnk_15606_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAMAIN_EBOMOrigAssyLink);
ECMAMAIN_EBOMOrigAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMOrigAssy_ComponentForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMOrigAssy_ComponentForm = new SeleniumControl( sDriver, "EBOMOrigAssy_ComponentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMORIG_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_EBOMOrigAssy_ComponentForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMOrigAssy_Component_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMOrigAssy_Component_Part = new SeleniumControl( sDriver, "EBOMOrigAssy_Component_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMORIG_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMAMAIN_EBOMOrigAssy_Component_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on EBOMOrigAssy_AssemblyTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMOrigAssy_AssemblyTable = new SeleniumControl( sDriver, "EBOMOrigAssy_AssemblyTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMORPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_EBOMOrigAssy_AssemblyTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on EBOMOrigAssy_AssemblyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMOrigAssy_AssemblyForm = new SeleniumControl( sDriver, "EBOMOrigAssy_AssemblyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMORPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_EBOMOrigAssy_AssemblyForm);
IWebElement formBttn = ECMAMAIN_EBOMOrigAssy_AssemblyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_EBOMOrigAssy_AssemblyForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_EBOMOrigAssy_AssemblyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMOrigAssy_AssemblyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMOrigAssy_AssemblyForm = new SeleniumControl( sDriver, "EBOMOrigAssy_AssemblyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMORPART_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_EBOMOrigAssy_AssemblyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMOrigAssy_Assembly_ActionCode...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMOrigAssy_Assembly_ActionCode = new SeleniumControl( sDriver, "EBOMOrigAssy_Assembly_ActionCode", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMORPART_']/ancestor::form[1]/descendant::*[@id='S_ECN_ACTION_CD']");
				Function.AssertEqual(true,ECMAMAIN_EBOMOrigAssy_Assembly_ActionCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on EBOMOrigAssy_ComponentForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMOrigAssy_ComponentForm = new SeleniumControl( sDriver, "EBOMOrigAssy_ComponentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMORIG_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_EBOMOrigAssy_ComponentForm);
IWebElement formBttn = ECMAMAIN_EBOMOrigAssy_ComponentForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EBOM Chng Assy");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMChngAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMChngAssyLink = new SeleniumControl( sDriver, "EBOMChngAssyLink", "ID", "lnk_15609_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMAMAIN_EBOMChngAssyLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on EBOMChngAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMChngAssyLink = new SeleniumControl( sDriver, "EBOMChngAssyLink", "ID", "lnk_15609_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAMAIN_EBOMChngAssyLink);
ECMAMAIN_EBOMChngAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMChngAssy_ComponentForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMChngAssy_ComponentForm = new SeleniumControl( sDriver, "EBOMChngAssy_ComponentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCHNG_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_EBOMChngAssy_ComponentForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMChngAssy_Component_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMChngAssy_Component_Part = new SeleniumControl( sDriver, "EBOMChngAssy_Component_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCHNG_HDR_']/ancestor::form[1]/descendant::*[@id='CHNG_PART_ID']");
				Function.AssertEqual(true,ECMAMAIN_EBOMChngAssy_Component_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on EBOMChngAssy_AssemblyTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMChngAssy_AssemblyTable = new SeleniumControl( sDriver, "EBOMChngAssy_AssemblyTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMCHGPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_EBOMChngAssy_AssemblyTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on EBOMChngAssy_AssemblyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMChngAssy_AssemblyForm = new SeleniumControl( sDriver, "EBOMChngAssy_AssemblyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMCHGPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_EBOMChngAssy_AssemblyForm);
IWebElement formBttn = ECMAMAIN_EBOMChngAssy_AssemblyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_EBOMChngAssy_AssemblyForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_EBOMChngAssy_AssemblyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMChngAssy_AssemblyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMChngAssy_AssemblyForm = new SeleniumControl( sDriver, "EBOMChngAssy_AssemblyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMCHGPART_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_EBOMChngAssy_AssemblyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on EBOMChngAssy_Assembly_ActionCode...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMChngAssy_Assembly_ActionCode = new SeleniumControl( sDriver, "EBOMChngAssy_Assembly_ActionCode", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMCHGPART_']/ancestor::form[1]/descendant::*[@id='S_ECN_ACTION_CD']");
				Function.AssertEqual(true,ECMAMAIN_EBOMChngAssy_Assembly_ActionCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on EBOMChngAssy_ComponentForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_EBOMChngAssy_ComponentForm = new SeleniumControl( sDriver, "EBOMChngAssy_ComponentForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCHNG_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_EBOMChngAssy_ComponentForm);
IWebElement formBttn = ECMAMAIN_EBOMChngAssy_ComponentForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Routings");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_RoutingsLink = new SeleniumControl( sDriver, "RoutingsLink", "ID", "lnk_15612_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMAMAIN_RoutingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Click on RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_RoutingsLink = new SeleniumControl( sDriver, "RoutingsLink", "ID", "lnk_15612_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAMAIN_RoutingsLink);
ECMAMAIN_RoutingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on Routings_RoutingStepsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Routings_RoutingStepsForm = new SeleniumControl( sDriver, "Routings_RoutingStepsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ROUTING_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_Routings_RoutingStepsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on Routings_RoutingStep_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Routings_RoutingStep_Part = new SeleniumControl( sDriver, "Routings_RoutingStep_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ROUTING_HDR_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,ECMAMAIN_Routings_RoutingStep_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExist on Routings_RoutingLineTable...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Routings_RoutingLineTable = new SeleniumControl( sDriver, "Routings_RoutingLineTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTROUTING_ROUTING_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAMAIN_Routings_RoutingLineTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing ClickButton on Routings_RoutingLineForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Routings_RoutingLineForm = new SeleniumControl( sDriver, "Routings_RoutingLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTROUTING_ROUTING_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_Routings_RoutingLineForm);
IWebElement formBttn = ECMAMAIN_Routings_RoutingLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAMAIN_Routings_RoutingLineForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAMAIN_Routings_RoutingLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on Routings_RoutingLineForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Routings_RoutingLineForm = new SeleniumControl( sDriver, "Routings_RoutingLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTROUTING_ROUTING_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAMAIN_Routings_RoutingLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing VerifyExists on Routings_RoutingLine_ActionCode...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Routings_RoutingLine_ActionCode = new SeleniumControl( sDriver, "Routings_RoutingLine_ActionCode", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTROUTING_ROUTING_']/ancestor::form[1]/descendant::*[@id='S_ECN_ACTION_CD']");
				Function.AssertEqual(true,ECMAMAIN_Routings_RoutingLine_ActionCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on Routings_RoutingStepsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_Routings_RoutingStepsForm = new SeleniumControl( sDriver, "Routings_RoutingStepsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ROUTING_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_Routings_RoutingStepsForm);
IWebElement formBttn = ECMAMAIN_Routings_RoutingStepsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAMAIN] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMAMAIN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMAMAIN_MainForm);
IWebElement formBttn = ECMAMAIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

