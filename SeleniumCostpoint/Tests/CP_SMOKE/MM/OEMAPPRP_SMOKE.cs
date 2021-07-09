 
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
    public class OEMAPPRP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Sales Order Entry Controls", "xpath","//div[@class='navItem'][.='Sales Order Entry Controls']").Click();
new SeleniumControl(sDriver,"Manage Sales Order Approval Processes", "xpath","//div[@class='navItem'][.='Manage Sales Order Approval Processes']").Click();


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
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEMAPPRP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing VerifyExists on ApprovalProcessCode...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_ApprovalProcessCode = new SeleniumControl( sDriver, "ApprovalProcessCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='OE_APPR_PROC_CD']");
				Function.AssertEqual(true,OEMAPPRP_ApprovalProcessCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMAPPRP_MainForm);
IWebElement formBttn = OEMAPPRP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEMAPPRP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEMAPPRP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPRP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("APPROVALTITLES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing VerifyExist on ApprovalTitlesTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_ApprovalTitlesTable = new SeleniumControl( sDriver, "ApprovalTitlesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPRP_OEAPPRPROCTITLE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPRP_ApprovalTitlesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing ClickButton on ApprovalTitlesForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_ApprovalTitlesForm = new SeleniumControl( sDriver, "ApprovalTitlesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPRP_OEAPPRPROCTITLE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPRP_ApprovalTitlesForm);
IWebElement formBttn = OEMAPPRP_ApprovalTitlesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMAPPRP_ApprovalTitlesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMAPPRP_ApprovalTitlesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing VerifyExists on ApprovalTitlesForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_ApprovalTitlesForm = new SeleniumControl( sDriver, "ApprovalTitlesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPRP_OEAPPRPROCTITLE_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPRP_ApprovalTitlesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing VerifyExists on ApprovalTitles_Sequence...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_ApprovalTitles_Sequence = new SeleniumControl( sDriver, "ApprovalTitles_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPRP_OEAPPRPROCTITLE_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,OEMAPPRP_ApprovalTitles_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("VIEWEMPLOYEEAPPROVAL");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing Click on ApprovalTitles_ViewEmployeeApprovalLink...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_ApprovalTitles_ViewEmployeeApprovalLink = new SeleniumControl( sDriver, "ApprovalTitles_ViewEmployeeApprovalLink", "ID", "lnk_1001117_OEMAPPRP_OEAPPRPROCTITLE");
				Function.WaitControlDisplayed(OEMAPPRP_ApprovalTitles_ViewEmployeeApprovalLink);
OEMAPPRP_ApprovalTitles_ViewEmployeeApprovalLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing VerifyExists on TableWindow_ViewEmployeeApprovalForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_TableWindow_ViewEmployeeApprovalForm = new SeleniumControl( sDriver, "TableWindow_ViewEmployeeApprovalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPRP_OEAPPRTITLEUSER_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPRP_TableWindow_ViewEmployeeApprovalForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing VerifyExists on TableWindow_ViewEmployeeApproval_PreferSeq...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_TableWindow_ViewEmployeeApproval_PreferSeq = new SeleniumControl( sDriver, "TableWindow_ViewEmployeeApproval_PreferSeq", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPRP_OEAPPRTITLEUSER_']/ancestor::form[1]/descendant::*[@id='PREF_SEQ_NO']");
				Function.AssertEqual(true,OEMAPPRP_TableWindow_ViewEmployeeApproval_PreferSeq.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing ClickButton on TableWindow_ViewEmployeeApprovalForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_TableWindow_ViewEmployeeApprovalForm = new SeleniumControl( sDriver, "TableWindow_ViewEmployeeApprovalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPRP_OEAPPRTITLEUSER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPRP_TableWindow_ViewEmployeeApprovalForm);
IWebElement formBttn = OEMAPPRP_TableWindow_ViewEmployeeApprovalForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEMAPPRP_TableWindow_ViewEmployeeApprovalForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEMAPPRP_TableWindow_ViewEmployeeApprovalForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing VerifyExist on TableWindow_ViewEmployeeApprovalTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_TableWindow_ViewEmployeeApprovalTable = new SeleniumControl( sDriver, "TableWindow_ViewEmployeeApprovalTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPRP_OEAPPRTITLEUSER_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPRP_TableWindow_ViewEmployeeApprovalTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing Close on TableWindow_ViewEmployeeApprovalForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_TableWindow_ViewEmployeeApprovalForm = new SeleniumControl( sDriver, "TableWindow_ViewEmployeeApprovalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPRP_OEAPPRTITLEUSER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPRP_TableWindow_ViewEmployeeApprovalForm);
IWebElement formBttn = OEMAPPRP_TableWindow_ViewEmployeeApprovalForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMAPPRP_MainForm);
IWebElement formBttn = OEMAPPRP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

