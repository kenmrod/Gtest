 
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
    public class ECMECAPP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Engineering Change Controls", "xpath","//div[@class='navItem'][.='Engineering Change Controls']").Click();
new SeleniumControl(sDriver,"Manage Engineering Change Approval Processes", "xpath","//div[@class='navItem'][.='Manage Engineering Change Approval Processes']").Click();


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
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ECMECAPP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on ECApprovalProcessCode...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ECApprovalProcessCode = new SeleniumControl( sDriver, "ECApprovalProcessCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EC_APP_PROC_CD']");
				Function.AssertEqual(true,ECMECAPP_ECApprovalProcessCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMECAPP_MainForm);
IWebElement formBttn = ECMECAPP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? ECMECAPP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
ECMECAPP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECAPP_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChangeTypeLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on ChangeTypeLink...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ChangeTypeLink = new SeleniumControl( sDriver, "ChangeTypeLink", "ID", "lnk_1005723_ECMECAPP_ECAPPPROC_HDR");
				Function.AssertEqual(true,ECMECAPP_ChangeTypeLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing Click on ChangeTypeLink...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ChangeTypeLink = new SeleniumControl( sDriver, "ChangeTypeLink", "ID", "lnk_1005723_ECMECAPP_ECAPPPROC_HDR");
				Function.WaitControlDisplayed(ECMECAPP_ChangeTypeLink);
ECMECAPP_ChangeTypeLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExist on EngineeringChangeTypesTableWindowTable...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_EngineeringChangeTypesTableWindowTable = new SeleniumControl( sDriver, "EngineeringChangeTypesTableWindowTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECTYPE_ECT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECAPP_EngineeringChangeTypesTableWindowTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on EngineeringChangeTypesTableWindowForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_EngineeringChangeTypesTableWindowForm = new SeleniumControl( sDriver, "EngineeringChangeTypesTableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECTYPE_ECT_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECAPP_EngineeringChangeTypesTableWindowForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExist on SelectedEngineeringChangeTypesTableWindowTable...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_SelectedEngineeringChangeTypesTableWindowTable = new SeleniumControl( sDriver, "SelectedEngineeringChangeTypesTableWindowTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECTYPE_SECT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECAPP_SelectedEngineeringChangeTypesTableWindowTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on SelectedEngineeringChangeTypesTableWindowForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_SelectedEngineeringChangeTypesTableWindowForm = new SeleniumControl( sDriver, "SelectedEngineeringChangeTypesTableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECTYPE_SECT_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECAPP_SelectedEngineeringChangeTypesTableWindowForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing Close on SelectedEngineeringChangeTypesTableWindowForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_SelectedEngineeringChangeTypesTableWindowForm = new SeleniumControl( sDriver, "SelectedEngineeringChangeTypesTableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECTYPE_SECT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECAPP_SelectedEngineeringChangeTypesTableWindowForm);
IWebElement formBttn = ECMECAPP_SelectedEngineeringChangeTypesTableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LinkOrgsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on LinkOrgsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_LinkOrgsLink = new SeleniumControl( sDriver, "LinkOrgsLink", "ID", "lnk_1005725_ECMECAPP_ECAPPPROC_HDR");
				Function.AssertEqual(true,ECMECAPP_LinkOrgsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing Click on LinkOrgsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_LinkOrgsLink = new SeleniumControl( sDriver, "LinkOrgsLink", "ID", "lnk_1005725_ECMECAPP_ECAPPPROC_HDR");
				Function.WaitControlDisplayed(ECMECAPP_LinkOrgsLink);
ECMECAPP_LinkOrgsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExist on OrganizationTableWindowTable...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_OrganizationTableWindowTable = new SeleniumControl( sDriver, "OrganizationTableWindowTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ORG_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECAPP_OrganizationTableWindowTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on OrganizationTableWindowForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_OrganizationTableWindowForm = new SeleniumControl( sDriver, "OrganizationTableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ORG_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECAPP_OrganizationTableWindowForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExist on SelectedOrganizationsTableWindowTable...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_SelectedOrganizationsTableWindowTable = new SeleniumControl( sDriver, "SelectedOrganizationsTableWindowTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ORG_SECI_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECAPP_SelectedOrganizationsTableWindowTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on SelectedOrganizationsTableWindowForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_SelectedOrganizationsTableWindowForm = new SeleniumControl( sDriver, "SelectedOrganizationsTableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ORG_SECI_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECAPP_SelectedOrganizationsTableWindowForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing Close on SelectedOrganizationsTableWindowForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_SelectedOrganizationsTableWindowForm = new SeleniumControl( sDriver, "SelectedOrganizationsTableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ORG_SECI_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECAPP_SelectedOrganizationsTableWindowForm);
IWebElement formBttn = ECMECAPP_SelectedOrganizationsTableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ApproverDetailsForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExist on ApproverDetailsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetailsTable = new SeleniumControl( sDriver, "ApproverDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECAPPPROCTITLE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECAPP_ApproverDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing ClickButton on ApproverDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetailsForm = new SeleniumControl( sDriver, "ApproverDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECAPPPROCTITLE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECAPP_ApproverDetailsForm);
IWebElement formBttn = ECMECAPP_ApproverDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECAPP_ApproverDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECAPP_ApproverDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on ApproverDetailsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetailsForm = new SeleniumControl( sDriver, "ApproverDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECAPPPROCTITLE_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECAPP_ApproverDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on ApproverDetails_PrefSequence...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_PrefSequence = new SeleniumControl( sDriver, "ApproverDetails_PrefSequence", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECAPPPROCTITLE_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,ECMECAPP_ApproverDetails_PrefSequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("UsersLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on ApproverDetails_UsersLink...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_UsersLink = new SeleniumControl( sDriver, "ApproverDetails_UsersLink", "ID", "lnk_1002316_ECMECAPP_ECAPPPROCTITLE");
				Function.AssertEqual(true,ECMECAPP_ApproverDetails_UsersLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing Click on ApproverDetails_UsersLink...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_UsersLink = new SeleniumControl( sDriver, "ApproverDetails_UsersLink", "ID", "lnk_1002316_ECMECAPP_ECAPPPROCTITLE");
				Function.WaitControlDisplayed(ECMECAPP_ApproverDetails_UsersLink);
ECMECAPP_ApproverDetails_UsersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExist on ApproverDetails_UsersTable...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_UsersTable = new SeleniumControl( sDriver, "ApproverDetails_UsersTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECAPPTITLEUSER_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECAPP_ApproverDetails_UsersTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing ClickButton on ApproverDetails_UsersForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_UsersForm = new SeleniumControl( sDriver, "ApproverDetails_UsersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECAPPTITLEUSER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECAPP_ApproverDetails_UsersForm);
IWebElement formBttn = ECMECAPP_ApproverDetails_UsersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECAPP_ApproverDetails_UsersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECAPP_ApproverDetails_UsersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on ApproverDetails_UsersForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_UsersForm = new SeleniumControl( sDriver, "ApproverDetails_UsersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECAPPTITLEUSER_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECAPP_ApproverDetails_UsersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on ApproverDetails_Users_PrefSeq...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_Users_PrefSeq = new SeleniumControl( sDriver, "ApproverDetails_Users_PrefSeq", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECAPPTITLEUSER_']/ancestor::form[1]/descendant::*[@id='PREF_SEQ_NO']");
				Function.AssertEqual(true,ECMECAPP_ApproverDetails_Users_PrefSeq.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing Close on ApproverDetails_UsersForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_UsersForm = new SeleniumControl( sDriver, "ApproverDetails_UsersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_ECAPPTITLEUSER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECAPP_ApproverDetails_UsersForm);
IWebElement formBttn = ECMECAPP_ApproverDetails_UsersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("UsersProjectsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on ApproverDetails_UserProjectsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_UserProjectsLink = new SeleniumControl( sDriver, "ApproverDetails_UserProjectsLink", "ID", "lnk_1002321_ECMECAPP_ECAPPPROCTITLE");
				Function.AssertEqual(true,ECMECAPP_ApproverDetails_UserProjectsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing Click on ApproverDetails_UserProjectsLink...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_UserProjectsLink = new SeleniumControl( sDriver, "ApproverDetails_UserProjectsLink", "ID", "lnk_1002321_ECMECAPP_ECAPPPROCTITLE");
				Function.WaitControlDisplayed(ECMECAPP_ApproverDetails_UserProjectsLink);
ECMECAPP_ApproverDetails_UserProjectsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExist on ApproverDetails_UserProjectsTable...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_UserProjectsTable = new SeleniumControl( sDriver, "ApproverDetails_UserProjectsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_USERPROJ_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ECMECAPP_ApproverDetails_UserProjectsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing ClickButton on ApproverDetails_UserProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_UserProjectsForm = new SeleniumControl( sDriver, "ApproverDetails_UserProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_USERPROJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECAPP_ApproverDetails_UserProjectsForm);
IWebElement formBttn = ECMECAPP_ApproverDetails_UserProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ECMECAPP_ApproverDetails_UserProjectsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ECMECAPP_ApproverDetails_UserProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on ApproverDetails_UserProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_UserProjectsForm = new SeleniumControl( sDriver, "ApproverDetails_UserProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_USERPROJ_']/ancestor::form[1]");
				Function.AssertEqual(true,ECMECAPP_ApproverDetails_UserProjectsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing VerifyExists on ApproverDetails_UserProjects_User...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_UserProjects_User = new SeleniumControl( sDriver, "ApproverDetails_UserProjects_User", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_USERPROJ_']/ancestor::form[1]/descendant::*[@id='USER_ID']");
				Function.AssertEqual(true,ECMECAPP_ApproverDetails_UserProjects_User.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing Close on ApproverDetails_UserProjectsForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_ApproverDetails_UserProjectsForm = new SeleniumControl( sDriver, "ApproverDetails_UserProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ECMECAPP_USERPROJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ECMECAPP_ApproverDetails_UserProjectsForm);
IWebElement formBttn = ECMECAPP_ApproverDetails_UserProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "ECMECAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ECMECAPP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ECMECAPP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ECMECAPP_MainForm);
IWebElement formBttn = ECMECAPP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

