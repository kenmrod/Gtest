 
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
    public class ECMECN_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Engineering Change Notices", "xpath","//div[@class='navItem'][.='Manage Engineering Change Notices']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMECN_MainForm);
IWebElement formBttn = ECMECN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? ECMECN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
ECMECN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMECN_MainForm);
IWebElement formBttn = ECMECN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on Identification_ECNID...", Logger.MessageType.INF);
				SeleniumControl ECMECN_Identification_ECNID = new SeleniumControl( sDriver, "Identification_ECNID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ECN_ID']");
				Function.AssertEqual(true,ECMECN_Identification_ECNID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ECMECN_MainFormTab);
IWebElement mTab = ECMECN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on BasicInfo_Type...", Logger.MessageType.INF);
				SeleniumControl ECMECN_BasicInfo_Type = new SeleniumControl( sDriver, "BasicInfo_Type", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EC_TYPE_CD']");
				Function.AssertEqual(true,ECMECN_BasicInfo_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ECMECN_MainFormTab);
IWebElement mTab = ECMECN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on Details_ECNRelatedCharges_Project...", Logger.MessageType.INF);
				SeleniumControl ECMECN_Details_ECNRelatedCharges_Project = new SeleniumControl( sDriver, "Details_ECNRelatedCharges_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CHG_PROJ_ID']");
				Function.AssertEqual(true,ECMECN_Details_ECNRelatedCharges_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ECMECN_MainFormTab);
IWebElement mTab = ECMECN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Customer Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ClientInformation_ECP...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ClientInformation_ECP = new SeleniumControl( sDriver, "ClientInformation_ECP", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ECP_ID']");
				Function.AssertEqual(true,ECMECN_ClientInformation_ECP.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(ECMECN_MainFormTab);
IWebElement mTab = ECMECN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Customer Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMECN_MainForm);
IWebElement formBttn = ECMECN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? ECMECN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
ECMECN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMECN_MainForm);
IWebElement formBttn = ECMECN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ImpactedProjectsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ImpactedProjectsLink = new SeleniumControl( sDriver, "ImpactedProjectsLink", "ID", "lnk_4610_ECMMAIN_ECN_MAINTECN");
				Function.AssertEqual(true,ECMECN_ImpactedProjectsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on ImpactedProjectsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ImpactedProjectsLink = new SeleniumControl( sDriver, "ImpactedProjectsLink", "ID", "lnk_4610_ECMMAIN_ECN_MAINTECN");
				Function.WaitControlDisplayed(ECMECN_ImpactedProjectsLink);
ECMECN_ImpactedProjectsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on ImpactedProjectsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ImpactedProjectsTable = new SeleniumControl( sDriver, "ImpactedProjectsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_ImpactedProjectsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ImpactedProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ImpactedProjectsForm = new SeleniumControl( sDriver, "ImpactedProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_ImpactedProjectsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on ImpactedProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ImpactedProjectsForm = new SeleniumControl( sDriver, "ImpactedProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_ImpactedProjectsForm);
IWebElement formBttn = ECMECN_ImpactedProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_ImpactedProjectsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_ImpactedProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ImpactedProjects_Project...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ImpactedProjects_Project = new SeleniumControl( sDriver, "ImpactedProjects_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,ECMECN_ImpactedProjects_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on ImpactedProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ImpactedProjectsForm = new SeleniumControl( sDriver, "ImpactedProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPROJ_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_ImpactedProjectsForm);
IWebElement formBttn = ECMECN_ImpactedProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ApprovalsLink = new SeleniumControl( sDriver, "ApprovalsLink", "ID", "lnk_1003515_ECMMAIN_ECN_MAINTECN");
				Function.AssertEqual(true,ECMECN_ApprovalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on ApprovalsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ApprovalsLink = new SeleniumControl( sDriver, "ApprovalsLink", "ID", "lnk_1003515_ECMMAIN_ECN_MAINTECN");
				Function.WaitControlDisplayed(ECMECN_ApprovalsLink);
ECMECN_ApprovalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on ApprovalsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ApprovalsTable = new SeleniumControl( sDriver, "ApprovalsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_ApprovalsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ApprovalsForm = new SeleniumControl( sDriver, "ApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_ApprovalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on ApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ApprovalsForm = new SeleniumControl( sDriver, "ApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_ApprovalsForm);
IWebElement formBttn = ECMECN_ApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_ApprovalsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_ApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on Approvals_Revision...", Logger.MessageType.INF);
				SeleniumControl ECMECN_Approvals_Revision = new SeleniumControl( sDriver, "Approvals_Revision", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]/descendant::*[@id='ECN_RVSN_NO']");
				Function.AssertEqual(true,ECMECN_Approvals_Revision.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on ApprovalsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ApprovalsForm = new SeleniumControl( sDriver, "ApprovalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNAPPRVL_APPROVDETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_ApprovalsForm);
IWebElement formBttn = ECMECN_ApprovalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on GeneralNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_GeneralNotesLink = new SeleniumControl( sDriver, "GeneralNotesLink", "ID", "lnk_1003514_ECMMAIN_ECN_MAINTECN");
				Function.AssertEqual(true,ECMECN_GeneralNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on GeneralNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_GeneralNotesLink = new SeleniumControl( sDriver, "GeneralNotesLink", "ID", "lnk_1003514_ECMMAIN_ECN_MAINTECN");
				Function.WaitControlDisplayed(ECMECN_GeneralNotesLink);
ECMECN_GeneralNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on GeneralNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_GeneralNotesForm = new SeleniumControl( sDriver, "GeneralNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_GeneralNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on GeneralNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_GeneralNotesForm = new SeleniumControl( sDriver, "GeneralNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_GeneralNotesForm);
IWebElement formBttn = ECMECN_GeneralNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on TechnicalNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_TechnicalNotesLink = new SeleniumControl( sDriver, "TechnicalNotesLink", "ID", "lnk_4607_ECMMAIN_ECN_MAINTECN");
				Function.AssertEqual(true,ECMECN_TechnicalNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on TechnicalNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_TechnicalNotesLink = new SeleniumControl( sDriver, "TechnicalNotesLink", "ID", "lnk_4607_ECMMAIN_ECN_MAINTECN");
				Function.WaitControlDisplayed(ECMECN_TechnicalNotesLink);
ECMECN_TechnicalNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on TechnicalNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_TechnicalNotesForm = new SeleniumControl( sDriver, "TechnicalNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTECHNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_TechnicalNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on TechnicalNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_TechnicalNotesForm = new SeleniumControl( sDriver, "TechnicalNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTECHNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_TechnicalNotesForm);
IWebElement formBttn = ECMECN_TechnicalNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ImplementationNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ImplementationNotesLink = new SeleniumControl( sDriver, "ImplementationNotesLink", "ID", "lnk_4606_ECMMAIN_ECN_MAINTECN");
				Function.AssertEqual(true,ECMECN_ImplementationNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on ImplementationNotesLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ImplementationNotesLink = new SeleniumControl( sDriver, "ImplementationNotesLink", "ID", "lnk_4606_ECMMAIN_ECN_MAINTECN");
				Function.WaitControlDisplayed(ECMECN_ImplementationNotesLink);
ECMECN_ImplementationNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ImplementationNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ImplementationNotesForm = new SeleniumControl( sDriver, "ImplementationNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNIMPLNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_ImplementationNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on ImplementationNotesForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ImplementationNotesForm = new SeleniumControl( sDriver, "ImplementationNotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNIMPLNOTES_ECNNOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_ImplementationNotesForm);
IWebElement formBttn = ECMECN_ImplementationNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on TextLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_TextLink = new SeleniumControl( sDriver, "TextLink", "ID", "lnk_1003511_ECMMAIN_ECN_MAINTECN");
				Function.AssertEqual(true,ECMECN_TextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on TextLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_TextLink = new SeleniumControl( sDriver, "TextLink", "ID", "lnk_1003511_ECMMAIN_ECN_MAINTECN");
				Function.WaitControlDisplayed(ECMECN_TextLink);
ECMECN_TextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on TextTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_TextTable = new SeleniumControl( sDriver, "TextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_TextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on TextForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_TextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on TextForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_TextForm);
IWebElement formBttn = ECMECN_TextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_TextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_TextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on Text_Sequence...", Logger.MessageType.INF);
				SeleniumControl ECMECN_Text_Sequence = new SeleniumControl( sDriver, "Text_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,ECMECN_Text_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on TextForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_TextForm = new SeleniumControl( sDriver, "TextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNTEXT_STDTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_TextForm);
IWebElement formBttn = ECMECN_TextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_DocumentsLink = new SeleniumControl( sDriver, "DocumentsLink", "ID", "lnk_1003512_ECMMAIN_ECN_MAINTECN");
				Function.AssertEqual(true,ECMECN_DocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on DocumentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_DocumentsLink = new SeleniumControl( sDriver, "DocumentsLink", "ID", "lnk_1003512_ECMMAIN_ECN_MAINTECN");
				Function.WaitControlDisplayed(ECMECN_DocumentsLink);
ECMECN_DocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on DocumentsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_DocumentsTable = new SeleniumControl( sDriver, "DocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_DocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_DocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_DocumentsForm);
IWebElement formBttn = ECMECN_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_DocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on Documents_Line...", Logger.MessageType.INF);
				SeleniumControl ECMECN_Documents_Line = new SeleniumControl( sDriver, "Documents_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]/descendant::*[@id='LINE']");
				Function.AssertEqual(true,ECMECN_Documents_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on DocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_DocumentsForm = new SeleniumControl( sDriver, "DocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNDOCUMENT_ECNDOC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_DocumentsForm);
IWebElement formBttn = ECMECN_DocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ECImpactedGroupsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ECImpactedGroupsLink = new SeleniumControl( sDriver, "ECImpactedGroupsLink", "ID", "lnk_1003516_ECMMAIN_ECN_MAINTECN");
				Function.AssertEqual(true,ECMECN_ECImpactedGroupsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on ECImpactedGroupsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ECImpactedGroupsLink = new SeleniumControl( sDriver, "ECImpactedGroupsLink", "ID", "lnk_1003516_ECMMAIN_ECN_MAINTECN");
				Function.WaitControlDisplayed(ECMECN_ECImpactedGroupsLink);
ECMECN_ECImpactedGroupsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on ECImpactedGroupsLookupTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ECImpactedGroupsLookupTable = new SeleniumControl( sDriver, "ECImpactedGroupsLookupTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_INPACTGRP_IMPACTEDGRP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_ECImpactedGroupsLookupTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on ECImpactedGroupsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ECImpactedGroupsTable = new SeleniumControl( sDriver, "ECImpactedGroupsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNIMPACTGRP_SELIMPGRP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_ECImpactedGroupsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ECImpactedGroupsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ECImpactedGroupsForm = new SeleniumControl( sDriver, "ECImpactedGroupsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNIMPACTGRP_SELIMPGRP_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_ECImpactedGroupsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ECImpactedGroupsLookupForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ECImpactedGroupsLookupForm = new SeleniumControl( sDriver, "ECImpactedGroupsLookupForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_INPACTGRP_IMPACTEDGRP_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_ECImpactedGroupsLookupForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on ECImpactedGroupsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ECImpactedGroupsForm = new SeleniumControl( sDriver, "ECImpactedGroupsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNIMPACTGRP_SELIMPGRP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_ECImpactedGroupsForm);
IWebElement formBttn = ECMECN_ECImpactedGroupsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_1003520_ECMMAIN_ECN_MAINTECN");
				Function.AssertEqual(true,ECMECN_UserDefinedInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_1003520_ECMMAIN_ECN_MAINTECN");
				Function.WaitControlDisplayed(ECMECN_UserDefinedInfoLink);
ECMECN_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on UserDefinedInfoTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_UserDefinedInfoTable = new SeleniumControl( sDriver, "UserDefinedInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_UserDefinedInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_UserDefinedInfoForm);
IWebElement formBttn = ECMECN_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_UserDefinedInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_UserDefinedInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on UserDefinedInfo_Value1...", Logger.MessageType.INF);
				SeleniumControl ECMECN_UserDefinedInfo_Value1 = new SeleniumControl( sDriver, "UserDefinedInfo_Value1", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='UDEF_TXT']");
				Function.AssertEqual(true,ECMECN_UserDefinedInfo_Value1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_UserDefinedInfoForm);
IWebElement formBttn = ECMECN_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPART_PARTSIMPACTED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPART_PARTSIMPACTED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_ChildForm);
IWebElement formBttn = ECMECN_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPART_PARTSIMPACTED_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ChildForm_Line...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_Line = new SeleniumControl( sDriver, "ChildForm_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPART_PARTSIMPACTED_']/ancestor::form[1]/descendant::*[@id='ECN_PART_LN_NO']");
				Function.AssertEqual(true,ECMECN_ChildForm_Line.Exists());

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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ChildForm_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_PartDocumentsLink = new SeleniumControl( sDriver, "ChildForm_PartDocumentsLink", "ID", "lnk_1004987_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMECN_ChildForm_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on ChildForm_PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_PartDocumentsLink = new SeleniumControl( sDriver, "ChildForm_PartDocumentsLink", "ID", "lnk_1004987_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMECN_ChildForm_PartDocumentsLink);
ECMECN_ChildForm_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on PartDocumentsDetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_PartDocumentsDetailsTable = new SeleniumControl( sDriver, "PartDocumentsDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTDOCUMENT_PARTDO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_PartDocumentsDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_PARTDOC_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on PartDocumentsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_PartDocumentsDetailsForm = new SeleniumControl( sDriver, "PartDocumentsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTDOCUMENT_PARTDO_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_PartDocumentsDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on PartDocumentsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_PartDocumentsDetailsForm = new SeleniumControl( sDriver, "PartDocumentsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTDOCUMENT_PARTDO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_PartDocumentsDetailsForm);
IWebElement formBttn = ECMECN_PartDocumentsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_PartDocumentsDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_PartDocumentsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on PartDocuments_Part...", Logger.MessageType.INF);
				SeleniumControl ECMECN_PartDocuments_Part = new SeleniumControl( sDriver, "PartDocuments_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_PARTDOC_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMECN_PartDocuments_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on PartDocumentsDetails_Line...", Logger.MessageType.INF);
				SeleniumControl ECMECN_PartDocumentsDetails_Line = new SeleniumControl( sDriver, "PartDocumentsDetails_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTDOCUMENT_PARTDO_']/ancestor::form[1]/descendant::*[@id='LINE_NO']");
				Function.AssertEqual(true,ECMECN_PartDocumentsDetails_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_PARTDOC_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_PartDocumentsForm);
IWebElement formBttn = ECMECN_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ChildForm_MBOMComponentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_MBOMComponentsLink = new SeleniumControl( sDriver, "ChildForm_MBOMComponentsLink", "ID", "lnk_1004992_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMECN_ChildForm_MBOMComponentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on ChildForm_MBOMComponentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_MBOMComponentsLink = new SeleniumControl( sDriver, "ChildForm_MBOMComponentsLink", "ID", "lnk_1004992_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMECN_ChildForm_MBOMComponentsLink);
ECMECN_ChildForm_MBOMComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on MBOMComponentsDetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMComponentsDetailsTable = new SeleniumControl( sDriver, "MBOMComponentsDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMCOMP_MBOMCOMP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_MBOMComponentsDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on MBOMComponentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMComponentsForm = new SeleniumControl( sDriver, "MBOMComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCOMP_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_MBOMComponentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on MBOMComponentsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMComponentsDetailsForm = new SeleniumControl( sDriver, "MBOMComponentsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMCOMP_MBOMCOMP_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_MBOMComponentsDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on MBOMComponentsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMComponentsDetailsForm = new SeleniumControl( sDriver, "MBOMComponentsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMCOMP_MBOMCOMP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_MBOMComponentsDetailsForm);
IWebElement formBttn = ECMECN_MBOMComponentsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_MBOMComponentsDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_MBOMComponentsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on MBOMComponents_MBOMAssembly_Part...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMComponents_MBOMAssembly_Part = new SeleniumControl( sDriver, "MBOMComponents_MBOMAssembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCOMP_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMECN_MBOMComponents_MBOMAssembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on MBOMComponentsDetails_FindNo...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMComponentsDetails_FindNo = new SeleniumControl( sDriver, "MBOMComponentsDetails_FindNo", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMCOMP_MBOMCOMP_']/ancestor::form[1]/descendant::*[@id='COMP_FIND_NO']");
				Function.AssertEqual(true,ECMECN_MBOMComponentsDetails_FindNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on MBOMComponentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMComponentsForm = new SeleniumControl( sDriver, "MBOMComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCOMP_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_MBOMComponentsForm);
IWebElement formBttn = ECMECN_MBOMComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ChildForm_MBOMOrigAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_MBOMOrigAssyLink = new SeleniumControl( sDriver, "ChildForm_MBOMOrigAssyLink", "ID", "lnk_1004999_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMECN_ChildForm_MBOMOrigAssyLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on ChildForm_MBOMOrigAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_MBOMOrigAssyLink = new SeleniumControl( sDriver, "ChildForm_MBOMOrigAssyLink", "ID", "lnk_1004999_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMECN_ChildForm_MBOMOrigAssyLink);
ECMECN_ChildForm_MBOMOrigAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on MBOMOrigAssyDetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMOrigAssyDetailsTable = new SeleniumControl( sDriver, "MBOMOrigAssyDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMORPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_MBOMOrigAssyDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on MBOMOrigAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMOrigAssyForm = new SeleniumControl( sDriver, "MBOMOrigAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMORIG_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_MBOMOrigAssyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on MBOMOrigAssyDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMOrigAssyDetailsForm = new SeleniumControl( sDriver, "MBOMOrigAssyDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMORPART_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_MBOMOrigAssyDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on MBOMOrigAssyDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMOrigAssyDetailsForm = new SeleniumControl( sDriver, "MBOMOrigAssyDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMORPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_MBOMOrigAssyDetailsForm);
IWebElement formBttn = ECMECN_MBOMOrigAssyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_MBOMOrigAssyDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_MBOMOrigAssyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on MBOMOrigAssy_Component_Part...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMOrigAssy_Component_Part = new SeleniumControl( sDriver, "MBOMOrigAssy_Component_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMORIG_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMECN_MBOMOrigAssy_Component_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on MBOMOrigAssyDetails_Assembly_Part...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMOrigAssyDetails_Assembly_Part = new SeleniumControl( sDriver, "MBOMOrigAssyDetails_Assembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMORPART_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,ECMECN_MBOMOrigAssyDetails_Assembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on MBOMOrigAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMOrigAssyForm = new SeleniumControl( sDriver, "MBOMOrigAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMORIG_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_MBOMOrigAssyForm);
IWebElement formBttn = ECMECN_MBOMOrigAssyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ChildForm_MBOMChngAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_MBOMChngAssyLink = new SeleniumControl( sDriver, "ChildForm_MBOMChngAssyLink", "ID", "lnk_1005001_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMECN_ChildForm_MBOMChngAssyLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on ChildForm_MBOMChngAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_MBOMChngAssyLink = new SeleniumControl( sDriver, "ChildForm_MBOMChngAssyLink", "ID", "lnk_1005001_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMECN_ChildForm_MBOMChngAssyLink);
ECMECN_ChildForm_MBOMChngAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on MBOMChngAssyDetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMChngAssyDetailsTable = new SeleniumControl( sDriver, "MBOMChngAssyDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMCHGPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_MBOMChngAssyDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on MBOMChngAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMChngAssyForm = new SeleniumControl( sDriver, "MBOMChngAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCHNG_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_MBOMChngAssyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on MBOMChngAssyDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMChngAssyDetailsForm = new SeleniumControl( sDriver, "MBOMChngAssyDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMCHGPART_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_MBOMChngAssyDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on MBOMChngAssyDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMChngAssyDetailsForm = new SeleniumControl( sDriver, "MBOMChngAssyDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMCHGPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_MBOMChngAssyDetailsForm);
IWebElement formBttn = ECMECN_MBOMChngAssyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_MBOMChngAssyDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_MBOMChngAssyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on MBOMChngAssy_Component_Part...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMChngAssy_Component_Part = new SeleniumControl( sDriver, "MBOMChngAssy_Component_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCHNG_HDR_']/ancestor::form[1]/descendant::*[@id='CHNG_PART_ID']");
				Function.AssertEqual(true,ECMECN_MBOMChngAssy_Component_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on MBOMChngAssyDetails_Assembly_Part...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMChngAssyDetails_Assembly_Part = new SeleniumControl( sDriver, "MBOMChngAssyDetails_Assembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNMBOMASY_MBOMCHGPART_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,ECMECN_MBOMChngAssyDetails_Assembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on MBOMChngAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MBOMChngAssyForm = new SeleniumControl( sDriver, "MBOMChngAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_MBOMCHNG_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_MBOMChngAssyForm);
IWebElement formBttn = ECMECN_MBOMChngAssyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ChildForm_EBOMComponentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_EBOMComponentsLink = new SeleniumControl( sDriver, "ChildForm_EBOMComponentsLink", "ID", "lnk_1005007_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMECN_ChildForm_EBOMComponentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on ChildForm_EBOMComponentsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_EBOMComponentsLink = new SeleniumControl( sDriver, "ChildForm_EBOMComponentsLink", "ID", "lnk_1005007_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMECN_ChildForm_EBOMComponentsLink);
ECMECN_ChildForm_EBOMComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on EBOMComponentsDetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMComponentsDetailsTable = new SeleniumControl( sDriver, "EBOMComponentsDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMCOMP_EBOMCOMP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_EBOMComponentsDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on EBOMComponentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMComponentsForm = new SeleniumControl( sDriver, "EBOMComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCOMP_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_EBOMComponentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on EBOMComponentsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMComponentsDetailsForm = new SeleniumControl( sDriver, "EBOMComponentsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMCOMP_EBOMCOMP_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_EBOMComponentsDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on EBOMComponentsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMComponentsDetailsForm = new SeleniumControl( sDriver, "EBOMComponentsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMCOMP_EBOMCOMP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_EBOMComponentsDetailsForm);
IWebElement formBttn = ECMECN_EBOMComponentsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_EBOMComponentsDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_EBOMComponentsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on EBOMComponents_EBOMAssembly_Part...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMComponents_EBOMAssembly_Part = new SeleniumControl( sDriver, "EBOMComponents_EBOMAssembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCOMP_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMECN_EBOMComponents_EBOMAssembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on EBOMComponentsDetails_Line...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMComponentsDetails_Line = new SeleniumControl( sDriver, "EBOMComponentsDetails_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMCOMP_EBOMCOMP_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,ECMECN_EBOMComponentsDetails_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on EBOMComponentsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMComponentsForm = new SeleniumControl( sDriver, "EBOMComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCOMP_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_EBOMComponentsForm);
IWebElement formBttn = ECMECN_EBOMComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ChildForm_EBOMOrigAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_EBOMOrigAssyLink = new SeleniumControl( sDriver, "ChildForm_EBOMOrigAssyLink", "ID", "lnk_1005011_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMECN_ChildForm_EBOMOrigAssyLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on ChildForm_EBOMOrigAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_EBOMOrigAssyLink = new SeleniumControl( sDriver, "ChildForm_EBOMOrigAssyLink", "ID", "lnk_1005011_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMECN_ChildForm_EBOMOrigAssyLink);
ECMECN_ChildForm_EBOMOrigAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on EBOMOrigAssyDetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMOrigAssyDetailsTable = new SeleniumControl( sDriver, "EBOMOrigAssyDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMORPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_EBOMOrigAssyDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on EBOMOrigAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMOrigAssyForm = new SeleniumControl( sDriver, "EBOMOrigAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMORIG_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_EBOMOrigAssyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on EBOMOrigAssyDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMOrigAssyDetailsForm = new SeleniumControl( sDriver, "EBOMOrigAssyDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMORPART_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_EBOMOrigAssyDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on EBOMOrigAssyDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMOrigAssyDetailsForm = new SeleniumControl( sDriver, "EBOMOrigAssyDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMORPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_EBOMOrigAssyDetailsForm);
IWebElement formBttn = ECMECN_EBOMOrigAssyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_EBOMOrigAssyDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_EBOMOrigAssyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on EBOMOrigAssy_Component_Part...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMOrigAssy_Component_Part = new SeleniumControl( sDriver, "EBOMOrigAssy_Component_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMORIG_HDR_']/ancestor::form[1]/descendant::*[@id='ORIG_PART_ID']");
				Function.AssertEqual(true,ECMECN_EBOMOrigAssy_Component_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on EBOMOrigAssyDetails_EBOMLine_Line...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMOrigAssyDetails_EBOMLine_Line = new SeleniumControl( sDriver, "EBOMOrigAssyDetails_EBOMLine_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMORPART_']/ancestor::form[1]/descendant::*[@id='COMP_LN_NO']");
				Function.AssertEqual(true,ECMECN_EBOMOrigAssyDetails_EBOMLine_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on EBOMOrigAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMOrigAssyForm = new SeleniumControl( sDriver, "EBOMOrigAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMORIG_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_EBOMOrigAssyForm);
IWebElement formBttn = ECMECN_EBOMOrigAssyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ChildForm_EBOMChngAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_EBOMChngAssyLink = new SeleniumControl( sDriver, "ChildForm_EBOMChngAssyLink", "ID", "lnk_1005013_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMECN_ChildForm_EBOMChngAssyLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on ChildForm_EBOMChngAssyLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_EBOMChngAssyLink = new SeleniumControl( sDriver, "ChildForm_EBOMChngAssyLink", "ID", "lnk_1005013_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMECN_ChildForm_EBOMChngAssyLink);
ECMECN_ChildForm_EBOMChngAssyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on EBOMChngAssyDetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMChngAssyDetailsTable = new SeleniumControl( sDriver, "EBOMChngAssyDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMCHGPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_EBOMChngAssyDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on EBOMChngAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMChngAssyForm = new SeleniumControl( sDriver, "EBOMChngAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCHNG_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_EBOMChngAssyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on EBOMChngAssyDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMChngAssyDetailsForm = new SeleniumControl( sDriver, "EBOMChngAssyDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMCHGPART_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_EBOMChngAssyDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on EBOMChngAssyDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMChngAssyDetailsForm = new SeleniumControl( sDriver, "EBOMChngAssyDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMCHGPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_EBOMChngAssyDetailsForm);
IWebElement formBttn = ECMECN_EBOMChngAssyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_EBOMChngAssyDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_EBOMChngAssyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on EBOMChngAssy_Component_Part...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMChngAssy_Component_Part = new SeleniumControl( sDriver, "EBOMChngAssy_Component_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCHNG_HDR_']/ancestor::form[1]/descendant::*[@id='CHNG_PART_ID']");
				Function.AssertEqual(true,ECMECN_EBOMChngAssy_Component_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on EBOMChngAssyDetails_Assembly_Part...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMChngAssyDetails_Assembly_Part = new SeleniumControl( sDriver, "EBOMChngAssyDetails_Assembly_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNEBOMASY_EBOMCHGPART_']/ancestor::form[1]/descendant::*[@id='ASY_PART_ID']");
				Function.AssertEqual(true,ECMECN_EBOMChngAssyDetails_Assembly_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on EBOMChngAssyForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_EBOMChngAssyForm = new SeleniumControl( sDriver, "EBOMChngAssyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_EBOMCHNG_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_EBOMChngAssyForm);
IWebElement formBttn = ECMECN_EBOMChngAssyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on ChildForm_RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_RoutingsLink = new SeleniumControl( sDriver, "ChildForm_RoutingsLink", "ID", "lnk_1003563_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.AssertEqual(true,ECMECN_ChildForm_RoutingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Click on ChildForm_RoutingsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECN_ChildForm_RoutingsLink = new SeleniumControl( sDriver, "ChildForm_RoutingsLink", "ID", "lnk_1003563_ECMMAIN_ECNPART_PARTSIMPACTED");
				Function.WaitControlDisplayed(ECMECN_ChildForm_RoutingsLink);
ECMECN_ChildForm_RoutingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExist on RoutingsDetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECN_RoutingsDetailsTable = new SeleniumControl( sDriver, "RoutingsDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTROUTING_ROUTING_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECN_RoutingsDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ROUTING_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_RoutingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on RoutingsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_RoutingsDetailsForm = new SeleniumControl( sDriver, "RoutingsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTROUTING_ROUTING_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECN_RoutingsDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing ClickButton on RoutingsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_RoutingsDetailsForm = new SeleniumControl( sDriver, "RoutingsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTROUTING_ROUTING_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_RoutingsDetailsForm);
IWebElement formBttn = ECMECN_RoutingsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECN_RoutingsDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECN_RoutingsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on Routings_Part...", Logger.MessageType.INF);
				SeleniumControl ECMECN_Routings_Part = new SeleniumControl( sDriver, "Routings_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ROUTING_HDR_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,ECMECN_Routings_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing VerifyExists on RoutingsDetails_RoutingLineDetails_OperationSequence...", Logger.MessageType.INF);
				SeleniumControl ECMECN_RoutingsDetails_RoutingLineDetails_OperationSequence = new SeleniumControl( sDriver, "RoutingsDetails_RoutingLineDetails_OperationSequence", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ECNPARTROUTING_ROUTING_']/ancestor::form[1]/descendant::*[@id='ROUT_OPER_SEQ_NO']");
				Function.AssertEqual(true,ECMECN_RoutingsDetails_RoutingLineDetails_OperationSequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on RoutingsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_RoutingsForm = new SeleniumControl( sDriver, "RoutingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMMAIN_ROUTING_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECN_RoutingsForm);
IWebElement formBttn = ECMECN_RoutingsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "ECMECN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECN] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMECN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMECN_MainForm);
IWebElement formBttn = ECMECN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

