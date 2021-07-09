 
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
    public class ECMAPPR_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Approve Engineering Change Notices", "xpath","//div[@class='navItem'][.='Approve Engineering Change Notices']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
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
				this.ScriptLogger.WriteLine("Impactedgrou");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ECMAPPR_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMAPPR_MainForm);
IWebElement formBttn = ECMAPPR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? ECMAPPR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
ECMAPPR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ECMAPPR_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMAPPR_MainForm);
IWebElement formBttn = ECMAPPR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on Description...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_Description = new SeleniumControl( sDriver, "Description", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ECN_DESC']");
				Function.AssertEqual(true,ECMAPPR_Description.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILDFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on PartsImpactedTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartsImpactedTable = new SeleniumControl( sDriver, "PartsImpactedTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPART_PARTSIMPACTED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_PartsImpactedTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButton on PartsImpacted...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartsImpacted = new SeleniumControl( sDriver, "PartsImpacted", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPART_PARTSIMPACTED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_PartsImpacted);
IWebElement formBttn = ECMAPPR_PartsImpacted.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_PartsImpacted.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_PartsImpacted.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on PartsImpacted...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartsImpacted = new SeleniumControl( sDriver, "PartsImpacted", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPART_PARTSIMPACTED_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_PartsImpacted.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("2 tables");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Select on InformationTab...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_InformationTab = new SeleniumControl( sDriver, "InformationTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ECMAPPR_InformationTab);
IWebElement mTab = ECMAPPR_InformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on BasicInfo_Type...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_BasicInfo_Type = new SeleniumControl( sDriver, "BasicInfo_Type", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EC_TYPE_CD']");
				Function.AssertEqual(true,ECMAPPR_BasicInfo_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Select on InformationTab...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_InformationTab = new SeleniumControl( sDriver, "InformationTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ECMAPPR_InformationTab);
IWebElement mTab = ECMAPPR_InformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("IMPACTEDPROJECTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on ImpactedProjectsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ImpactedProjectsLink = new SeleniumControl( sDriver, "ImpactedProjectsLink", "ID", "lnk_5640_ECMMAIN_ECN_APPROVECN");
				Function.WaitControlDisplayed(ECMAPPR_ImpactedProjectsLink);
ECMAPPR_ImpactedProjectsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on ImpactedProjectsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ImpactedProjectsTable = new SeleniumControl( sDriver, "ImpactedProjectsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_ImpactedProjectsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on ImpactedProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ImpactedProjectsForm = new SeleniumControl( sDriver, "ImpactedProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_ImpactedProjectsForm);
IWebElement formBttn = ECMAPPR_ImpactedProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_ImpactedProjectsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_ImpactedProjectsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on ImpactedProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ImpactedProjectsForm = new SeleniumControl( sDriver, "ImpactedProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_ImpactedProjectsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on ImpactedProjects_Project...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ImpactedProjects_Project = new SeleniumControl( sDriver, "ImpactedProjects_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,ECMAPPR_ImpactedProjects_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on ImpactedProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ImpactedProjectsForm = new SeleniumControl( sDriver, "ImpactedProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_ImpactedProjectsForm);
IWebElement formBttn = ECMAPPR_ImpactedProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("APPROVALS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on ApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ApprovalsLink = new SeleniumControl( sDriver, "ApprovalsLink", "ID", "lnk_5641_ECMMAIN_ECN_APPROVECN");
				Function.WaitControlDisplayed(ECMAPPR_ApprovalsLink);
ECMAPPR_ApprovalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on ApprovalsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ApprovalsTable = new SeleniumControl( sDriver, "ApprovalsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_ApprovalsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButton on ApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ApprovalsForm = new SeleniumControl( sDriver, "ApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_ApprovalsForm);
IWebElement formBttn = ECMAPPR_ApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_ApprovalsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_ApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on ApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ApprovalsForm = new SeleniumControl( sDriver, "ApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_ApprovalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on Approvals_ApprovalStatusInformation_User...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_Approvals_ApprovalStatusInformation_User = new SeleniumControl( sDriver, "Approvals_ApprovalStatusInformation_User", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]/descendant::*[@id='APPRVL_USER_ID']");
				Function.AssertEqual(true,ECMAPPR_Approvals_ApprovalStatusInformation_User.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on ApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ApprovalsForm = new SeleniumControl( sDriver, "ApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_ApprovalsForm);
IWebElement formBttn = ECMAPPR_ApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("GENERALNOTES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on GeneralNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_GeneralNotesLink = new SeleniumControl( sDriver, "GeneralNotesLink", "ID", "lnk_5642_ECMMAIN_ECN_APPROVECN");
				Function.WaitControlDisplayed(ECMAPPR_GeneralNotesLink);
ECMAPPR_GeneralNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on GeneralNotes_GeneralNotesTextArea...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_GeneralNotes_GeneralNotesTextArea = new SeleniumControl( sDriver, "GeneralNotes_GeneralNotesTextArea", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNNOTES_ECNNOTES_']/ancestor::form[1]/descendant::*[@id='ECN_TX']");
				Function.AssertEqual(true,ECMAPPR_GeneralNotes_GeneralNotesTextArea.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on GeneralNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_GeneralNotesForm = new SeleniumControl( sDriver, "GeneralNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_GeneralNotesForm);
IWebElement formBttn = ECMAPPR_GeneralNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TECHNICALNOTES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on TechnicalNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_TechnicalNotesLink = new SeleniumControl( sDriver, "TechnicalNotesLink", "ID", "lnk_5643_ECMMAIN_ECN_APPROVECN");
				Function.WaitControlDisplayed(ECMAPPR_TechnicalNotesLink);
ECMAPPR_TechnicalNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on TechnicalNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_TechnicalNotesForm = new SeleniumControl( sDriver, "TechnicalNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTECHNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_TechnicalNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on TechnicalNotes_TechnicalNotesTextArea...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_TechnicalNotes_TechnicalNotesTextArea = new SeleniumControl( sDriver, "TechnicalNotes_TechnicalNotesTextArea", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTECHNOTES_ECNNOTES_']/ancestor::form[1]/descendant::*[@id='ECN_TECH_TX']");
				Function.AssertEqual(true,ECMAPPR_TechnicalNotes_TechnicalNotesTextArea.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on TechnicalNotes_OK...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_TechnicalNotes_OK = new SeleniumControl( sDriver, "TechnicalNotes_OK", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTECHNOTES_ECNNOTES_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.WaitControlDisplayed(ECMAPPR_TechnicalNotes_OK);
if (ECMAPPR_TechnicalNotes_OK.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
ECMAPPR_TechnicalNotes_OK.Click(5,5);
else ECMAPPR_TechnicalNotes_OK.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("IMPLEMENTATIONNOTES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on ImplementationNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ImplementationNotesLink = new SeleniumControl( sDriver, "ImplementationNotesLink", "ID", "lnk_5644_ECMMAIN_ECN_APPROVECN");
				Function.WaitControlDisplayed(ECMAPPR_ImplementationNotesLink);
ECMAPPR_ImplementationNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on ImplementationNotes_ImplementationNotesTextArea...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ImplementationNotes_ImplementationNotesTextArea = new SeleniumControl( sDriver, "ImplementationNotes_ImplementationNotesTextArea", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNIMPLNOTES_ECNNOTES_']/ancestor::form[1]/descendant::*[@id='ECN_IMPL_TX']");
				Function.AssertEqual(true,ECMAPPR_ImplementationNotes_ImplementationNotesTextArea.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on ImplementationNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_ImplementationNotesForm = new SeleniumControl( sDriver, "ImplementationNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNIMPLNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_ImplementationNotesForm);
IWebElement formBttn = ECMAPPR_ImplementationNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TEXT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on TextLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_TextLink = new SeleniumControl( sDriver, "TextLink", "ID", "lnk_5645_ECMMAIN_ECN_APPROVECN");
				Function.WaitControlDisplayed(ECMAPPR_TextLink);
ECMAPPR_TextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on TextTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_TextTable = new SeleniumControl( sDriver, "TextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_TextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on TextForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_TextForm);
IWebElement formBttn = ECMAPPR_TextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_TextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_TextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on TextForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_TextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on Text_Sequence...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_Text_Sequence = new SeleniumControl( sDriver, "Text_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,ECMAPPR_Text_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on TextForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_TextForm);
IWebElement formBttn = ECMAPPR_TextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ECIMPACTEDGROUPS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DOCUMENTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_DocumentsLink = new SeleniumControl( sDriver, "DocumentsLink", "ID", "lnk_5646_ECMMAIN_ECN_APPROVECN");
				Function.WaitControlDisplayed(ECMAPPR_DocumentsLink);
ECMAPPR_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on DocumentsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_DocumentsTable = new SeleniumControl( sDriver, "DocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_DocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_DocumentsForm);
IWebElement formBttn = ECMAPPR_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on Documents_Line...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_Documents_Line = new SeleniumControl( sDriver, "Documents_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]/descendant::*[@id='LINE']");
				Function.AssertEqual(true,ECMAPPR_Documents_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_DocumentsForm);
IWebElement formBttn = ECMAPPR_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("USERDEFINEDINFo");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_5649_ECMMAIN_ECN_APPROVECN");
				Function.WaitControlDisplayed(ECMAPPR_UserDefinedInfoLink);
ECMAPPR_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on UserDefinedInfoTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_UserDefinedInfoTable = new SeleniumControl( sDriver, "UserDefinedInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_UserDefinedInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_UserDefinedInfoForm);
IWebElement formBttn = ECMAPPR_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_UserDefinedInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_UserDefinedInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_UserDefinedInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on UserDefinedInfo_Labels...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_UserDefinedInfo_Labels = new SeleniumControl( sDriver, "UserDefinedInfo_Labels", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='UDEF_LBL']");
				Function.AssertEqual(true,ECMAPPR_UserDefinedInfo_Labels.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_UserDefinedInfoForm);
IWebElement formBttn = ECMAPPR_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PARTSDOCUMENTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButton on PartsImpacted...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartsImpacted = new SeleniumControl( sDriver, "PartsImpacted", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPART_PARTSIMPACTED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_PartsImpacted);
IWebElement formBttn = ECMAPPR_PartsImpacted.mElement.FindElements(By.CssSelector("*[title*='New']")).Count <= 0 ? ECMAPPR_PartsImpacted.mElement.FindElements(By.XPath(".//*[contains(text(),'New')]")).FirstOrDefault() :
ECMAPPR_PartsImpacted.mElement.FindElements(By.CssSelector("*[title*='New']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" New not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Set on PartsImpacted_OriginalPart_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartsImpacted_OriginalPart_Part = new SeleniumControl( sDriver, "PartsImpacted_OriginalPart_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPART_PARTSIMPACTED_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				ECMAPPR_PartsImpacted_OriginalPart_Part.Click();
ECMAPPR_PartsImpacted_OriginalPart_Part.SendKeys("#2 THHN BLACK", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
ECMAPPR_PartsImpacted_OriginalPart_Part.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on PartsImpacted_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartsImpacted_PartDocumentsLink = new SeleniumControl( sDriver, "PartsImpacted_PartDocumentsLink", "ID", "lnk_5650_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAPPR_PartsImpacted_PartDocumentsLink);
ECMAPPR_PartsImpacted_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_PARTDOC_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on PartDocuments_DetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartDocuments_DetailsTable = new SeleniumControl( sDriver, "PartDocuments_DetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTDOCUMENT_PARTDO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_PartDocuments_DetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on PartDocuments_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartDocuments_Part = new SeleniumControl( sDriver, "PartDocuments_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_PARTDOC_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMAPPR_PartDocuments_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on PartDocuments_DetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartDocuments_DetailsForm = new SeleniumControl( sDriver, "PartDocuments_DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTDOCUMENT_PARTDO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_PartDocuments_DetailsForm);
IWebElement formBttn = ECMAPPR_PartDocuments_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_PartDocuments_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_PartDocuments_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on PartDocuments_Details_Line...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartDocuments_Details_Line = new SeleniumControl( sDriver, "PartDocuments_Details_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTDOCUMENT_PARTDO_']/ancestor::form[1]/descendant::*[@id='LINE_NO']");
				Function.AssertEqual(true,ECMAPPR_PartDocuments_Details_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButton on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_PARTDOC_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_PartDocumentsForm);
IWebElement formBttn = ECMAPPR_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='New']")).Count <= 0 ? ECMAPPR_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'New')]")).FirstOrDefault() :
ECMAPPR_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='New']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" New not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on PartDocuments_Details_CopyDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartDocuments_Details_CopyDocumentsLink = new SeleniumControl( sDriver, "PartDocuments_Details_CopyDocumentsLink", "ID", "lnk_18581_ECMMAIN_PARTDOC_HDR");
				Function.AssertEqual(true,ECMAPPR_PartDocuments_Details_CopyDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on PartDocuments_Details_CopyDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartDocuments_Details_CopyDocumentsLink = new SeleniumControl( sDriver, "PartDocuments_Details_CopyDocumentsLink", "ID", "lnk_18581_ECMMAIN_PARTDOC_HDR");
				Function.WaitControlDisplayed(ECMAPPR_PartDocuments_Details_CopyDocumentsLink);
ECMAPPR_PartDocuments_Details_CopyDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on PartDocuments_Details_CopyDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartDocuments_Details_CopyDocumentsForm = new SeleniumControl( sDriver, "PartDocuments_Details_CopyDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_PARTDOC_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_PartDocuments_Details_CopyDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on PartDocuments_Details_CopyDocuments_PartToCopy_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartDocuments_Details_CopyDocuments_PartToCopy_Part = new SeleniumControl( sDriver, "PartDocuments_Details_CopyDocuments_PartToCopy_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_PARTDOC_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,ECMAPPR_PartDocuments_Details_CopyDocuments_PartToCopy_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on PartDocuments_Details_CopyDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartDocuments_Details_CopyDocumentsForm = new SeleniumControl( sDriver, "PartDocuments_Details_CopyDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_PARTDOC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_PartDocuments_Details_CopyDocumentsForm);
IWebElement formBttn = ECMAPPR_PartDocuments_Details_CopyDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_PARTDOC_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_PartDocumentsForm);
IWebElement formBttn = ECMAPPR_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on PartsImpacted_MBOMComponentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartsImpacted_MBOMComponentsLink = new SeleniumControl( sDriver, "PartsImpacted_MBOMComponentsLink", "ID", "lnk_5654_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAPPR_PartsImpacted_MBOMComponentsLink);
ECMAPPR_PartsImpacted_MBOMComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMComponentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponentsForm = new SeleniumControl( sDriver, "MBOMComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCOMP_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_MBOMComponentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on MBOMComponents_DetailFormTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_DetailFormTable = new SeleniumControl( sDriver, "MBOMComponents_DetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMCOMP_MBOMCOMP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_MBOMComponents_DetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on MBOMComponents_DetailForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_DetailForm = new SeleniumControl( sDriver, "MBOMComponents_DetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMCOMP_MBOMCOMP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_MBOMComponents_DetailForm);
IWebElement formBttn = ECMAPPR_MBOMComponents_DetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_MBOMComponents_DetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_MBOMComponents_DetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMComponents_DetailForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_DetailForm = new SeleniumControl( sDriver, "MBOMComponents_DetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMCOMP_MBOMCOMP_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_MBOMComponents_DetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMComponents_MBOMAssembly_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_MBOMAssembly_Part = new SeleniumControl( sDriver, "MBOMComponents_MBOMAssembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCOMP_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMAPPR_MBOMComponents_MBOMAssembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMComponents_Details_Line...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_Details_Line = new SeleniumControl( sDriver, "MBOMComponents_Details_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMCOMP_MBOMCOMP_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,ECMAPPR_MBOMComponents_Details_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMComponents_Details_CopyMBOMLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_Details_CopyMBOMLink = new SeleniumControl( sDriver, "MBOMComponents_Details_CopyMBOMLink", "ID", "lnk_18467_ECMMAIN_MBOMCOMP_HDR");
				Function.AssertEqual(true,ECMAPPR_MBOMComponents_Details_CopyMBOMLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on MBOMComponents_Details_CopyMBOMLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_Details_CopyMBOMLink = new SeleniumControl( sDriver, "MBOMComponents_Details_CopyMBOMLink", "ID", "lnk_18467_ECMMAIN_MBOMCOMP_HDR");
				Function.WaitControlDisplayed(ECMAPPR_MBOMComponents_Details_CopyMBOMLink);
ECMAPPR_MBOMComponents_Details_CopyMBOMLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMComponents_Details_CopyMBOMForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_Details_CopyMBOMForm = new SeleniumControl( sDriver, "MBOMComponents_Details_CopyMBOMForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_MBOMCOPY_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_MBOMComponents_Details_CopyMBOMForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMComponents_Details_CopyMBOM_AssemblyPartToMBOMComponents_Details_Copy_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_Details_CopyMBOM_AssemblyPartToMBOMComponents_Details_Copy_Part = new SeleniumControl( sDriver, "MBOMComponents_Details_CopyMBOM_AssemblyPartToMBOMComponents_Details_Copy_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_MBOMCOPY_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,ECMAPPR_MBOMComponents_Details_CopyMBOM_AssemblyPartToMBOMComponents_Details_Copy_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on MBOMComponents_Details_CopyMBOMForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_Details_CopyMBOMForm = new SeleniumControl( sDriver, "MBOMComponents_Details_CopyMBOMForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_MBOMCOPY_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_MBOMComponents_Details_CopyMBOMForm);
IWebElement formBttn = ECMAPPR_MBOMComponents_Details_CopyMBOMForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMComponents_Details_CopyEBOMLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_Details_CopyEBOMLink = new SeleniumControl( sDriver, "MBOMComponents_Details_CopyEBOMLink", "ID", "lnk_18468_ECMMAIN_MBOMCOMP_HDR");
				Function.AssertEqual(true,ECMAPPR_MBOMComponents_Details_CopyEBOMLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on MBOMComponents_Details_CopyEBOMLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_Details_CopyEBOMLink = new SeleniumControl( sDriver, "MBOMComponents_Details_CopyEBOMLink", "ID", "lnk_18468_ECMMAIN_MBOMCOMP_HDR");
				Function.WaitControlDisplayed(ECMAPPR_MBOMComponents_Details_CopyEBOMLink);
ECMAPPR_MBOMComponents_Details_CopyEBOMLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMComponents_Details_CopyEBOMForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_Details_CopyEBOMForm = new SeleniumControl( sDriver, "MBOMComponents_Details_CopyEBOMForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_EBOMCOPY_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_MBOMComponents_Details_CopyEBOMForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMComponents_Details_CopyEBOM_AssemblyPartToMBOMComponents_Details_Copy_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_Details_CopyEBOM_AssemblyPartToMBOMComponents_Details_Copy_Part = new SeleniumControl( sDriver, "MBOMComponents_Details_CopyEBOM_AssemblyPartToMBOMComponents_Details_Copy_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_EBOMCOPY_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,ECMAPPR_MBOMComponents_Details_CopyEBOM_AssemblyPartToMBOMComponents_Details_Copy_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on MBOMComponents_Details_CopyEBOMForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponents_Details_CopyEBOMForm = new SeleniumControl( sDriver, "MBOMComponents_Details_CopyEBOMForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_EBOMCOPY_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_MBOMComponents_Details_CopyEBOMForm);
IWebElement formBttn = ECMAPPR_MBOMComponents_Details_CopyEBOMForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on MBOMComponentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMComponentsForm = new SeleniumControl( sDriver, "MBOMComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCOMP_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_MBOMComponentsForm);
IWebElement formBttn = ECMAPPR_MBOMComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on PartsImpacted_MBOMOrigAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartsImpacted_MBOMOrigAssyLink = new SeleniumControl( sDriver, "PartsImpacted_MBOMOrigAssyLink", "ID", "lnk_5658_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAPPR_PartsImpacted_MBOMOrigAssyLink);
ECMAPPR_PartsImpacted_MBOMOrigAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMOrigAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMOrigAssyForm = new SeleniumControl( sDriver, "MBOMOrigAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMORIG_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_MBOMOrigAssyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMOrigAssy_Component_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMOrigAssy_Component_Part = new SeleniumControl( sDriver, "MBOMOrigAssy_Component_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMORIG_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMAPPR_MBOMOrigAssy_Component_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on MBOMOrigAssy_DetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMOrigAssy_DetailsTable = new SeleniumControl( sDriver, "MBOMOrigAssy_DetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMORPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_MBOMOrigAssy_DetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on MBOMOrigAssy_DetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMOrigAssy_DetailsForm = new SeleniumControl( sDriver, "MBOMOrigAssy_DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMORPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_MBOMOrigAssy_DetailsForm);
IWebElement formBttn = ECMAPPR_MBOMOrigAssy_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_MBOMOrigAssy_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_MBOMOrigAssy_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMOrigAssy_DetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMOrigAssy_DetailsForm = new SeleniumControl( sDriver, "MBOMOrigAssy_DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMORPART_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_MBOMOrigAssy_DetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMOrigAssy_Details_Assembly_ItemDescription...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMOrigAssy_Details_Assembly_ItemDescription = new SeleniumControl( sDriver, "MBOMOrigAssy_Details_Assembly_ItemDescription", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMORPART_']/ancestor::form[1]/descendant::*[@id='ITEM_DESC']");
				Function.AssertEqual(true,ECMAPPR_MBOMOrigAssy_Details_Assembly_ItemDescription.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on MBOMOrigAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMOrigAssyForm = new SeleniumControl( sDriver, "MBOMOrigAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMORIG_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_MBOMOrigAssyForm);
IWebElement formBttn = ECMAPPR_MBOMOrigAssyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on PartsImpacted_MBOMChngAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartsImpacted_MBOMChngAssyLink = new SeleniumControl( sDriver, "PartsImpacted_MBOMChngAssyLink", "ID", "lnk_5660_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAPPR_PartsImpacted_MBOMChngAssyLink);
ECMAPPR_PartsImpacted_MBOMChngAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMChngAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMChngAssyForm = new SeleniumControl( sDriver, "MBOMChngAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCHNG_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_MBOMChngAssyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on MBOMChngAssy_DetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMChngAssy_DetailsTable = new SeleniumControl( sDriver, "MBOMChngAssy_DetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMCHGPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_MBOMChngAssy_DetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on MBOMChngAssy_DetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMChngAssy_DetailsForm = new SeleniumControl( sDriver, "MBOMChngAssy_DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMCHGPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_MBOMChngAssy_DetailsForm);
IWebElement formBttn = ECMAPPR_MBOMChngAssy_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_MBOMChngAssy_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_MBOMChngAssy_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMChngAssy_DetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMChngAssy_DetailsForm = new SeleniumControl( sDriver, "MBOMChngAssy_DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMCHGPART_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_MBOMChngAssy_DetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMChngAssy_Component_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMChngAssy_Component_Part = new SeleniumControl( sDriver, "MBOMChngAssy_Component_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCHNG_HDR_']/ancestor::form[1]/descendant::*[@id='CHNG_PART_ID']");
				Function.AssertEqual(true,ECMAPPR_MBOMChngAssy_Component_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMChngAssy_Details_Assembly_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMChngAssy_Details_Assembly_Part = new SeleniumControl( sDriver, "MBOMChngAssy_Details_Assembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMCHGPART_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,ECMAPPR_MBOMChngAssy_Details_Assembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on MBOMChngAssy_Details_CopyAssembliesLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMChngAssy_Details_CopyAssembliesLink = new SeleniumControl( sDriver, "MBOMChngAssy_Details_CopyAssembliesLink", "ID", "lnk_18475_ECMMAIN_MBOMCHNG_HDR");
				Function.AssertEqual(true,ECMAPPR_MBOMChngAssy_Details_CopyAssembliesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on MBOMChngAssy_Details_CopyAssembliesLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMChngAssy_Details_CopyAssembliesLink = new SeleniumControl( sDriver, "MBOMChngAssy_Details_CopyAssembliesLink", "ID", "lnk_18475_ECMMAIN_MBOMCHNG_HDR");
				Function.WaitControlDisplayed(ECMAPPR_MBOMChngAssy_Details_CopyAssembliesLink);
ECMAPPR_MBOMChngAssy_Details_CopyAssembliesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on CopyAssembliesForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_CopyAssembliesForm = new SeleniumControl( sDriver, "CopyAssembliesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_MBOMCHNG_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_CopyAssembliesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on CopyAssemblies_ComponentPartToCopy_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_CopyAssemblies_ComponentPartToCopy_Part = new SeleniumControl( sDriver, "CopyAssemblies_ComponentPartToCopy_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_MBOMCHNG_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,ECMAPPR_CopyAssemblies_ComponentPartToCopy_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on CopyAssembliesForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_CopyAssembliesForm = new SeleniumControl( sDriver, "CopyAssembliesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_MBOMCHNG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_CopyAssembliesForm);
IWebElement formBttn = ECMAPPR_CopyAssembliesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on MBOMChngAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MBOMChngAssyForm = new SeleniumControl( sDriver, "MBOMChngAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCHNG_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_MBOMChngAssyForm);
IWebElement formBttn = ECMAPPR_MBOMChngAssyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on PartsImpacted_EBOMComponentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartsImpacted_EBOMComponentsLink = new SeleniumControl( sDriver, "PartsImpacted_EBOMComponentsLink", "ID", "lnk_5663_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAPPR_PartsImpacted_EBOMComponentsLink);
ECMAPPR_PartsImpacted_EBOMComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMComponentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponentsForm = new SeleniumControl( sDriver, "EBOMComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCOMP_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_EBOMComponentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on EBOMComponents_DetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_DetailsTable = new SeleniumControl( sDriver, "EBOMComponents_DetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMCOMP_EBOMCOMP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_EBOMComponents_DetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on EBOMComponents_DetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_DetailsForm = new SeleniumControl( sDriver, "EBOMComponents_DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMCOMP_EBOMCOMP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_EBOMComponents_DetailsForm);
IWebElement formBttn = ECMAPPR_EBOMComponents_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_EBOMComponents_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_EBOMComponents_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMComponents_DetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_DetailsForm = new SeleniumControl( sDriver, "EBOMComponents_DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMCOMP_EBOMCOMP_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_EBOMComponents_DetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMComponents_Details_Line...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_Details_Line = new SeleniumControl( sDriver, "EBOMComponents_Details_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMCOMP_EBOMCOMP_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,ECMAPPR_EBOMComponents_Details_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMComponents_EBOMAssembly_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_EBOMAssembly_Part = new SeleniumControl( sDriver, "EBOMComponents_EBOMAssembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCOMP_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMAPPR_EBOMComponents_EBOMAssembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMComponents_Details_CopyMBOMLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_Details_CopyMBOMLink = new SeleniumControl( sDriver, "EBOMComponents_Details_CopyMBOMLink", "ID", "lnk_18469_ECMMAIN_EBOMCOMP_HDR");
				Function.AssertEqual(true,ECMAPPR_EBOMComponents_Details_CopyMBOMLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on EBOMComponents_Details_CopyMBOMLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_Details_CopyMBOMLink = new SeleniumControl( sDriver, "EBOMComponents_Details_CopyMBOMLink", "ID", "lnk_18469_ECMMAIN_EBOMCOMP_HDR");
				Function.WaitControlDisplayed(ECMAPPR_EBOMComponents_Details_CopyMBOMLink);
ECMAPPR_EBOMComponents_Details_CopyMBOMLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMComponents_CopyMBOMForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_CopyMBOMForm = new SeleniumControl( sDriver, "EBOMComponents_CopyMBOMForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_MBOMCOPY_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_EBOMComponents_CopyMBOMForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMComponents_CopyMBOM_AssemblyPartToCopy_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_CopyMBOM_AssemblyPartToCopy_Part = new SeleniumControl( sDriver, "EBOMComponents_CopyMBOM_AssemblyPartToCopy_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_MBOMCOPY_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,ECMAPPR_EBOMComponents_CopyMBOM_AssemblyPartToCopy_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on EBOMComponents_CopyMBOMForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_CopyMBOMForm = new SeleniumControl( sDriver, "EBOMComponents_CopyMBOMForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_MBOMCOPY_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_EBOMComponents_CopyMBOMForm);
IWebElement formBttn = ECMAPPR_EBOMComponents_CopyMBOMForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMComponents_Details_CopyEBOMLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_Details_CopyEBOMLink = new SeleniumControl( sDriver, "EBOMComponents_Details_CopyEBOMLink", "ID", "lnk_18470_ECMMAIN_EBOMCOMP_HDR");
				Function.AssertEqual(true,ECMAPPR_EBOMComponents_Details_CopyEBOMLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on EBOMComponents_Details_CopyEBOMLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_Details_CopyEBOMLink = new SeleniumControl( sDriver, "EBOMComponents_Details_CopyEBOMLink", "ID", "lnk_18470_ECMMAIN_EBOMCOMP_HDR");
				Function.WaitControlDisplayed(ECMAPPR_EBOMComponents_Details_CopyEBOMLink);
ECMAPPR_EBOMComponents_Details_CopyEBOMLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMComponents_CopyEBOMForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_CopyEBOMForm = new SeleniumControl( sDriver, "EBOMComponents_CopyEBOMForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_EBOMCOPY_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_EBOMComponents_CopyEBOMForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMComponents_CopyEBOM_AssemblyPartToCopy_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_CopyEBOM_AssemblyPartToCopy_Part = new SeleniumControl( sDriver, "EBOMComponents_CopyEBOM_AssemblyPartToCopy_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_EBOMCOPY_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,ECMAPPR_EBOMComponents_CopyEBOM_AssemblyPartToCopy_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on EBOMComponents_CopyEBOMForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponents_CopyEBOMForm = new SeleniumControl( sDriver, "EBOMComponents_CopyEBOMForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_EBOMCOPY_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_EBOMComponents_CopyEBOMForm);
IWebElement formBttn = ECMAPPR_EBOMComponents_CopyEBOMForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on EBOMComponentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMComponentsForm = new SeleniumControl( sDriver, "EBOMComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCOMP_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_EBOMComponentsForm);
IWebElement formBttn = ECMAPPR_EBOMComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on PartsImpacted_EBOMOrigAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartsImpacted_EBOMOrigAssyLink = new SeleniumControl( sDriver, "PartsImpacted_EBOMOrigAssyLink", "ID", "lnk_5667_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAPPR_PartsImpacted_EBOMOrigAssyLink);
ECMAPPR_PartsImpacted_EBOMOrigAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMOrigAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMOrigAssyForm = new SeleniumControl( sDriver, "EBOMOrigAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMORIG_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_EBOMOrigAssyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMOrigAssy_Component_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMOrigAssy_Component_Part = new SeleniumControl( sDriver, "EBOMOrigAssy_Component_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMORIG_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMAPPR_EBOMOrigAssy_Component_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on EBOMOrigAssy_DetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMOrigAssy_DetailsTable = new SeleniumControl( sDriver, "EBOMOrigAssy_DetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMORPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_EBOMOrigAssy_DetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on EBOMOrigAssy_DetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMOrigAssy_DetailsForm = new SeleniumControl( sDriver, "EBOMOrigAssy_DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMORPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_EBOMOrigAssy_DetailsForm);
IWebElement formBttn = ECMAPPR_EBOMOrigAssy_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_EBOMOrigAssy_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_EBOMOrigAssy_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMOrigAssy_DetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMOrigAssy_DetailsForm = new SeleniumControl( sDriver, "EBOMOrigAssy_DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMORPART_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_EBOMOrigAssy_DetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMOrigAssy_Details_Assembly_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMOrigAssy_Details_Assembly_Part = new SeleniumControl( sDriver, "EBOMOrigAssy_Details_Assembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMORPART_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,ECMAPPR_EBOMOrigAssy_Details_Assembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on EBOMOrigAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMOrigAssyForm = new SeleniumControl( sDriver, "EBOMOrigAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMORIG_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_EBOMOrigAssyForm);
IWebElement formBttn = ECMAPPR_EBOMOrigAssyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on PartsImpacted_EBOMChngAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartsImpacted_EBOMChngAssyLink = new SeleniumControl( sDriver, "PartsImpacted_EBOMChngAssyLink", "ID", "lnk_5669_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAPPR_PartsImpacted_EBOMChngAssyLink);
ECMAPPR_PartsImpacted_EBOMChngAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMChngAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMChngAssyForm = new SeleniumControl( sDriver, "EBOMChngAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCHNG_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_EBOMChngAssyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on EBOMChngAssy_DetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMChngAssy_DetailsTable = new SeleniumControl( sDriver, "EBOMChngAssy_DetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMCHGPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_EBOMChngAssy_DetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on EBOMChngAssy_DetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMChngAssy_DetailsForm = new SeleniumControl( sDriver, "EBOMChngAssy_DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMCHGPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_EBOMChngAssy_DetailsForm);
IWebElement formBttn = ECMAPPR_EBOMChngAssy_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_EBOMChngAssy_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_EBOMChngAssy_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMChngAssy_DetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMChngAssy_DetailsForm = new SeleniumControl( sDriver, "EBOMChngAssy_DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMCHGPART_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_EBOMChngAssy_DetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMChngAssy_Details_Assembly_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMChngAssy_Details_Assembly_Part = new SeleniumControl( sDriver, "EBOMChngAssy_Details_Assembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMCHGPART_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,ECMAPPR_EBOMChngAssy_Details_Assembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMChngAssy_Component_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMChngAssy_Component_Part = new SeleniumControl( sDriver, "EBOMChngAssy_Component_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCHNG_HDR_']/ancestor::form[1]/descendant::*[@id='CHNG_PART_ID']");
				Function.AssertEqual(true,ECMAPPR_EBOMChngAssy_Component_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMChngAssy_Details_CopyAssembliesLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMChngAssy_Details_CopyAssembliesLink = new SeleniumControl( sDriver, "EBOMChngAssy_Details_CopyAssembliesLink", "ID", "lnk_18476_ECMMAIN_EBOMCHNG_HDR");
				Function.AssertEqual(true,ECMAPPR_EBOMChngAssy_Details_CopyAssembliesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on EBOMChngAssy_Details_CopyAssembliesLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMChngAssy_Details_CopyAssembliesLink = new SeleniumControl( sDriver, "EBOMChngAssy_Details_CopyAssembliesLink", "ID", "lnk_18476_ECMMAIN_EBOMCHNG_HDR");
				Function.WaitControlDisplayed(ECMAPPR_EBOMChngAssy_Details_CopyAssembliesLink);
ECMAPPR_EBOMChngAssy_Details_CopyAssembliesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMChngAssy_CopyAssembliesForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMChngAssy_CopyAssembliesForm = new SeleniumControl( sDriver, "EBOMChngAssy_CopyAssembliesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_EBOMCHNG_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_EBOMChngAssy_CopyAssembliesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on EBOMChngAssy_CopyAssemblies_ComponentPartToCopy_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMChngAssy_CopyAssemblies_ComponentPartToCopy_Part = new SeleniumControl( sDriver, "EBOMChngAssy_CopyAssemblies_ComponentPartToCopy_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_EBOMCHNG_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,ECMAPPR_EBOMChngAssy_CopyAssemblies_ComponentPartToCopy_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on EBOMChngAssy_CopyAssembliesForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMChngAssy_CopyAssembliesForm = new SeleniumControl( sDriver, "EBOMChngAssy_CopyAssembliesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_EBOMCHNG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_EBOMChngAssy_CopyAssembliesForm);
IWebElement formBttn = ECMAPPR_EBOMChngAssy_CopyAssembliesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on EBOMChngAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_EBOMChngAssyForm = new SeleniumControl( sDriver, "EBOMChngAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCHNG_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_EBOMChngAssyForm);
IWebElement formBttn = ECMAPPR_EBOMChngAssyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on PartsImpacted_RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_PartsImpacted_RoutingsLink = new SeleniumControl( sDriver, "PartsImpacted_RoutingsLink", "ID", "lnk_5672_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMAPPR_PartsImpacted_RoutingsLink);
ECMAPPR_PartsImpacted_RoutingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ROUTING_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_RoutingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExist on Routing_DetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_Routing_DetailsTable = new SeleniumControl( sDriver, "Routing_DetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTROUTING_ROUTING_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMAPPR_Routing_DetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing ClickButtonIfExists on Routing_DetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_Routing_DetailsForm = new SeleniumControl( sDriver, "Routing_DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTROUTING_ROUTING_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_Routing_DetailsForm);
IWebElement formBttn = ECMAPPR_Routing_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMAPPR_Routing_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMAPPR_Routing_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on Routing_DetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_Routing_DetailsForm = new SeleniumControl( sDriver, "Routing_DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTROUTING_ROUTING_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_Routing_DetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on Routings_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_Routings_Part = new SeleniumControl( sDriver, "Routings_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ROUTING_HDR_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,ECMAPPR_Routings_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on Routings_Details_RoutingLineDetails_OperationSequence...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_Routings_Details_RoutingLineDetails_OperationSequence = new SeleniumControl( sDriver, "Routings_Details_RoutingLineDetails_OperationSequence", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTROUTING_ROUTING_']/ancestor::form[1]/descendant::*[@id='ROUT_OPER_SEQ_NO']");
				Function.AssertEqual(true,ECMAPPR_Routings_Details_RoutingLineDetails_OperationSequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on Routings_Details_CopyRoutingLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_Routings_Details_CopyRoutingLink = new SeleniumControl( sDriver, "Routings_Details_CopyRoutingLink", "ID", "lnk_18584_ECMMAIN_ROUTING_HDR");
				Function.AssertEqual(true,ECMAPPR_Routings_Details_CopyRoutingLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on Routings_Details_CopyRoutingLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_Routings_Details_CopyRoutingLink = new SeleniumControl( sDriver, "Routings_Details_CopyRoutingLink", "ID", "lnk_18584_ECMMAIN_ROUTING_HDR");
				Function.WaitControlDisplayed(ECMAPPR_Routings_Details_CopyRoutingLink);
ECMAPPR_Routings_Details_CopyRoutingLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on CopyRoutingForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_CopyRoutingForm = new SeleniumControl( sDriver, "CopyRoutingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_ROUTING_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_CopyRoutingForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on CopyRouting_PartRoutingLinesToCopy_Part...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_CopyRouting_PartRoutingLinesToCopy_Part = new SeleniumControl( sDriver, "CopyRouting_PartRoutingLinesToCopy_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_ROUTING_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,ECMAPPR_CopyRouting_PartRoutingLinesToCopy_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on CopyRoutingForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_CopyRoutingForm = new SeleniumControl( sDriver, "CopyRoutingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_COPYPART_ROUTING_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_CopyRoutingForm);
IWebElement formBttn = ECMAPPR_CopyRoutingForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on Routings_Details_UserDefinedFieldsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_Routings_Details_UserDefinedFieldsLink = new SeleniumControl( sDriver, "Routings_Details_UserDefinedFieldsLink", "ID", "lnk_5675_ECMMAIN_ECNPARTROUTING_ROUTING");
				Function.AssertEqual(true,ECMAPPR_Routings_Details_UserDefinedFieldsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Click on Routings_Details_UserDefinedFieldsLink...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_Routings_Details_UserDefinedFieldsLink = new SeleniumControl( sDriver, "Routings_Details_UserDefinedFieldsLink", "ID", "lnk_5675_ECMMAIN_ECNPARTROUTING_ROUTING");
				Function.WaitControlDisplayed(ECMAPPR_Routings_Details_UserDefinedFieldsLink);
ECMAPPR_Routings_Details_UserDefinedFieldsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on UserDefinedFieldsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_UserDefinedFieldsForm = new SeleniumControl( sDriver, "UserDefinedFieldsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__EC_UDEF_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMAPPR_UserDefinedFieldsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing VerifyExists on UserDefinedFields_UserDefinedField1...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_UserDefinedFields_UserDefinedField1 = new SeleniumControl( sDriver, "UserDefinedFields_UserDefinedField1", "xpath", "//div[translate(@id,'0123456789','')='pr__EC_UDEF_CTW_']/ancestor::form[1]/descendant::*[@id='UDEF_1']");
				Function.AssertEqual(true,ECMAPPR_UserDefinedFields_UserDefinedField1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on UserDefinedFieldsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_UserDefinedFieldsForm = new SeleniumControl( sDriver, "UserDefinedFieldsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__EC_UDEF_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_UserDefinedFieldsForm);
IWebElement formBttn = ECMAPPR_UserDefinedFieldsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ROUTING_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMAPPR_RoutingsForm);
IWebElement formBttn = ECMAPPR_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMAPPR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMAPPR] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMAPPR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMAPPR_MainForm);
IWebElement formBttn = ECMAPPR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

