 
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
    public class BLMUHIST_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Projects", "xpath","//div[@class='busItem'][.='Projects']").Click();
new SeleniumControl(sDriver,"Billing", "xpath","//div[@class='deptItem'][.='Billing']").Click();
new SeleniumControl(sDriver,"Units Usage Processing", "xpath","//div[@class='navItem'][.='Units Usage Processing']").Click();
new SeleniumControl(sDriver,"Manage Units Usage History", "xpath","//div[@class='navItem'][.='Manage Units Usage History']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMUHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMUHIST] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMUHIST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMUHIST_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMUHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMUHIST] Performing VerifyExists on DocumentNo...", Logger.MessageType.INF);
				SeleniumControl BLMUHIST_DocumentNo = new SeleniumControl( sDriver, "DocumentNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='USAGE_DOC_ID']");
				Function.AssertEqual(true,BLMUHIST_DocumentNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMUHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMUHIST] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMUHIST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMUHIST_MainForm);
IWebElement formBttn = BLMUHIST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BLMUHIST_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BLMUHIST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMUHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMUHIST] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMUHIST_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMUHIST_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINE DETAILS FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMUHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMUHIST] Performing VerifyExist on LineDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMUHIST_LineDetailsFormTable = new SeleniumControl( sDriver, "LineDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMUHIST_UNITSUSAGELNHS_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMUHIST_LineDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMUHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMUHIST] Performing ClickButton on LineDetailsForm...", Logger.MessageType.INF);
				SeleniumControl BLMUHIST_LineDetailsForm = new SeleniumControl( sDriver, "LineDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMUHIST_UNITSUSAGELNHS_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMUHIST_LineDetailsForm);
IWebElement formBttn = BLMUHIST_LineDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMUHIST_LineDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMUHIST_LineDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMUHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMUHIST] Performing VerifyExists on LineDetailsForm...", Logger.MessageType.INF);
				SeleniumControl BLMUHIST_LineDetailsForm = new SeleniumControl( sDriver, "LineDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMUHIST_UNITSUSAGELNHS_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMUHIST_LineDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMUHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMUHIST] Performing VerifyExists on LineDetails_Line...", Logger.MessageType.INF);
				SeleniumControl BLMUHIST_LineDetails_Line = new SeleniumControl( sDriver, "LineDetails_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMUHIST_UNITSUSAGELNHS_CHLD_']/ancestor::form[1]/descendant::*[@id='LINE_NO']");
				Function.AssertEqual(true,BLMUHIST_LineDetails_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMUHIST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMUHIST] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMUHIST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMUHIST_MainForm);
IWebElement formBttn = BLMUHIST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

