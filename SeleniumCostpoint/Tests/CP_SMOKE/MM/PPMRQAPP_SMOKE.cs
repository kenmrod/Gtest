 
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
    public class PPMRQAPP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Procurement Planning Controls", "xpath","//div[@class='navItem'][.='Procurement Planning Controls']").Click();
new SeleniumControl(sDriver,"Manage Purchase Requisition Approval Processes", "xpath","//div[@class='navItem'][.='Manage Purchase Requisition Approval Processes']").Click();


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
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMRQAPP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing VerifyExists on RequisitionApprovalProcessCode...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_RequisitionApprovalProcessCode = new SeleniumControl( sDriver, "RequisitionApprovalProcessCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQ_APPR_PROC_CD']");
				Function.AssertEqual(true,PPMRQAPP_RequisitionApprovalProcessCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRQAPP_MainForm);
IWebElement formBttn = PPMRQAPP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PPMRQAPP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PPMRQAPP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Approval Titles");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing VerifyExists on ApprovalTitlesLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_ApprovalTitlesLink = new SeleniumControl( sDriver, "ApprovalTitlesLink", "ID", "lnk_1001588_PPMRQAPP_RQAPPRVLPROC_HDR");
				Function.AssertEqual(true,PPMRQAPP_ApprovalTitlesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing Click on ApprovalTitlesLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_ApprovalTitlesLink = new SeleniumControl( sDriver, "ApprovalTitlesLink", "ID", "lnk_1001588_PPMRQAPP_RQAPPRVLPROC_HDR");
				Function.WaitControlDisplayed(PPMRQAPP_ApprovalTitlesLink);
PPMRQAPP_ApprovalTitlesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing VerifyExist on RequisitionApprovalProcessDetailsTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_RequisitionApprovalProcessDetailsTable = new SeleniumControl( sDriver, "RequisitionApprovalProcessDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPP_APPRVLPROCTITLE_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPP_RequisitionApprovalProcessDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing ClickButton on RequisitionApprovalProcessDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_RequisitionApprovalProcessDetailsForm = new SeleniumControl( sDriver, "RequisitionApprovalProcessDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPP_APPRVLPROCTITLE_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPP_RequisitionApprovalProcessDetailsForm);
IWebElement formBttn = PPMRQAPP_RequisitionApprovalProcessDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPP_RequisitionApprovalProcessDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPP_RequisitionApprovalProcessDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing VerifyExists on RequisitionApprovalProcessDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_RequisitionApprovalProcessDetailsForm = new SeleniumControl( sDriver, "RequisitionApprovalProcessDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPP_APPRVLPROCTITLE_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPP_RequisitionApprovalProcessDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing VerifyExists on RequisitionApprovalProcessDetails_Sequence...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_RequisitionApprovalProcessDetails_Sequence = new SeleniumControl( sDriver, "RequisitionApprovalProcessDetails_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPP_APPRVLPROCTITLE_DTL_']/ancestor::form[1]/descendant::*[@id='SEQUENCE_NO']");
				Function.AssertEqual(true,PPMRQAPP_RequisitionApprovalProcessDetails_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing Close on RequisitionApprovalProcessDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_RequisitionApprovalProcessDetailsForm = new SeleniumControl( sDriver, "RequisitionApprovalProcessDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPP_APPRVLPROCTITLE_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPP_RequisitionApprovalProcessDetailsForm);
IWebElement formBttn = PPMRQAPP_RequisitionApprovalProcessDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Link Acct/Org");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing VerifyExists on LinkAcctOrgLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_LinkAcctOrgLink = new SeleniumControl( sDriver, "LinkAcctOrgLink", "ID", "lnk_1002401_PPMRQAPP_RQAPPRVLPROC_HDR");
				Function.AssertEqual(true,PPMRQAPP_LinkAcctOrgLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing Click on LinkAcctOrgLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_LinkAcctOrgLink = new SeleniumControl( sDriver, "LinkAcctOrgLink", "ID", "lnk_1002401_PPMRQAPP_RQAPPRVLPROC_HDR");
				Function.WaitControlDisplayed(PPMRQAPP_LinkAcctOrgLink);
PPMRQAPP_LinkAcctOrgLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing VerifyExist on LinkAcctOrg_OrgTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_LinkAcctOrg_OrgTable = new SeleniumControl( sDriver, "LinkAcctOrg_OrgTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPP_ORGACCT_DESELECT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPP_LinkAcctOrg_OrgTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing VerifyExist on LinkAcctOrg_AcctTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_LinkAcctOrg_AcctTable = new SeleniumControl( sDriver, "LinkAcctOrg_AcctTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPP_ORGACCT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPP_LinkAcctOrg_AcctTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing Close on LinkAcctOrg_AcctForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_LinkAcctOrg_AcctForm = new SeleniumControl( sDriver, "LinkAcctOrg_AcctForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPP_ORGACCT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPP_LinkAcctOrg_AcctForm);
IWebElement formBttn = PPMRQAPP_LinkAcctOrg_AcctForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Link Project");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing VerifyExists on LinkProjectLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_LinkProjectLink = new SeleniumControl( sDriver, "LinkProjectLink", "ID", "lnk_1002403_PPMRQAPP_RQAPPRVLPROC_HDR");
				Function.AssertEqual(true,PPMRQAPP_LinkProjectLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing Click on LinkProjectLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_LinkProjectLink = new SeleniumControl( sDriver, "LinkProjectLink", "ID", "lnk_1002403_PPMRQAPP_RQAPPRVLPROC_HDR");
				Function.WaitControlDisplayed(PPMRQAPP_LinkProjectLink);
PPMRQAPP_LinkProjectLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing VerifyExist on LinkProject_Project1Table...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_LinkProject_Project1Table = new SeleniumControl( sDriver, "LinkProject_Project1Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPP_PROJ_DESELECT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPP_LinkProject_Project1Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing VerifyExist on LinkProject_Project2Table...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_LinkProject_Project2Table = new SeleniumControl( sDriver, "LinkProject_Project2Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPP_PROJ_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPP_LinkProject_Project2Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing Close on LinkProject_Project2Form...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_LinkProject_Project2Form = new SeleniumControl( sDriver, "LinkProject_Project2Form", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPP_PROJ_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPP_LinkProject_Project2Form);
IWebElement formBttn = PPMRQAPP_LinkProject_Project2Form.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRQAPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRQAPP_MainForm);
IWebElement formBttn = PPMRQAPP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

