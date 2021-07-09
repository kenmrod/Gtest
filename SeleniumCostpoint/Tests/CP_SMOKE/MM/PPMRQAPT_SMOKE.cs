 
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
    public class PPMRQAPT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Purchase Requisition Approval Titles", "xpath","//div[@class='navItem'][.='Manage Purchase Requisition Approval Titles']").Click();


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
				Function.CurrentComponent = "PPMRQAPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMRQAPT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPT] Performing VerifyExists on ApprovalTitle...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPT_ApprovalTitle = new SeleniumControl( sDriver, "ApprovalTitle", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RQ_APPR_TITLE_DC']");
				Function.AssertEqual(true,PPMRQAPT_ApprovalTitle.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRQAPT_MainForm);
IWebElement formBttn = PPMRQAPT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PPMRQAPT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PPMRQAPT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Approvers details");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPT] Performing Click on UsersLink...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPT_UsersLink = new SeleniumControl( sDriver, "UsersLink", "ID", "lnk_1007251_PPMRQAPT_RQAPPRVLTITLE_REQAP");
				Function.WaitControlDisplayed(PPMRQAPT_UsersLink);
PPMRQAPT_UsersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPT] Performing VerifyExists on ApproverDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPT_ApproverDetailsForm = new SeleniumControl( sDriver, "ApproverDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPT_RQAPPRTITLEUSER_APROV_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRQAPT_ApproverDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPT] Performing VerifyExist on ApproverDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPT_ApproverDetailsFormTable = new SeleniumControl( sDriver, "ApproverDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPT_RQAPPRTITLEUSER_APROV_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRQAPT_ApproverDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPT] Performing ClickButton on ApproverDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPT_ApproverDetailsForm = new SeleniumControl( sDriver, "ApproverDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPT_RQAPPRTITLEUSER_APROV_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPT_ApproverDetailsForm);
IWebElement formBttn = PPMRQAPT_ApproverDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRQAPT_ApproverDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRQAPT_ApproverDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPT] Performing VerifyExists on ApproverDetails_PreferredSeq...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPT_ApproverDetails_PreferredSeq = new SeleniumControl( sDriver, "ApproverDetails_PreferredSeq", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPT_RQAPPRTITLEUSER_APROV_']/ancestor::form[1]/descendant::*[@id='PREF_SEQ_NO']");
				Function.AssertEqual(true,PPMRQAPT_ApproverDetails_PreferredSeq.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRQAPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPT] Performing Close on ApproverDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPT_ApproverDetailsForm = new SeleniumControl( sDriver, "ApproverDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRQAPT_RQAPPRTITLEUSER_APROV_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRQAPT_ApproverDetailsForm);
IWebElement formBttn = PPMRQAPT_ApproverDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRQAPT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRQAPT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRQAPT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRQAPT_MainForm);
IWebElement formBttn = PPMRQAPT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

