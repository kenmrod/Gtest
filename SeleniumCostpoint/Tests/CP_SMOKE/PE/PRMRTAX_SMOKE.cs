 
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
    public class PRMRTAX_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Payroll", "xpath","//div[@class='deptItem'][.='Payroll']").Click();
new SeleniumControl(sDriver,"State Taxes", "xpath","//div[@class='navItem'][.='State Taxes']").Click();
new SeleniumControl(sDriver,"Manage Reciprocal State Taxes", "xpath","//div[@class='navItem'][.='Manage Reciprocal State Taxes']").Click();


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
				Function.CurrentComponent = "PRMRTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMRTAX] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMRTAX_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMRTAX_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMRTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMRTAX] Performing VerifyExists on State...", Logger.MessageType.INF);
				SeleniumControl PRMRTAX_State = new SeleniumControl( sDriver, "State", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='STATE_CD']");
				Function.AssertEqual(true,PRMRTAX_State.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMRTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMRTAX] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMRTAX_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMRTAX_MainForm);
IWebElement formBttn = PRMRTAX_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMRTAX_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMRTAX_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMRTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMRTAX] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMRTAX_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMRTAX_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Reciprocal State Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMRTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMRTAX] Performing VerifyExists on ReciprocalStateLink...", Logger.MessageType.INF);
				SeleniumControl PRMRTAX_ReciprocalStateLink = new SeleniumControl( sDriver, "ReciprocalStateLink", "ID", "lnk_5439_PRMRTAX_STATERECPINFO_HDR");
				Function.AssertEqual(true,PRMRTAX_ReciprocalStateLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMRTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMRTAX] Performing Click on ReciprocalStateLink...", Logger.MessageType.INF);
				SeleniumControl PRMRTAX_ReciprocalStateLink = new SeleniumControl( sDriver, "ReciprocalStateLink", "ID", "lnk_5439_PRMRTAX_STATERECPINFO_HDR");
				Function.WaitControlDisplayed(PRMRTAX_ReciprocalStateLink);
PRMRTAX_ReciprocalStateLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMRTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMRTAX] Performing VerifyExists on ReciprocalStateForm...", Logger.MessageType.INF);
				SeleniumControl PRMRTAX_ReciprocalStateForm = new SeleniumControl( sDriver, "ReciprocalStateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMRTAX_STATERECPTBL_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMRTAX_ReciprocalStateForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMRTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMRTAX] Performing VerifyExist on ReciprocalState_ReciprocalStateTable...", Logger.MessageType.INF);
				SeleniumControl PRMRTAX_ReciprocalState_ReciprocalStateTable = new SeleniumControl( sDriver, "ReciprocalState_ReciprocalStateTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMRTAX_STATERECPTBL_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMRTAX_ReciprocalState_ReciprocalStateTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMRTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMRTAX] Performing Close on ReciprocalStateForm...", Logger.MessageType.INF);
				SeleniumControl PRMRTAX_ReciprocalStateForm = new SeleniumControl( sDriver, "ReciprocalStateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMRTAX_STATERECPTBL_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMRTAX_ReciprocalStateForm);
IWebElement formBttn = PRMRTAX_ReciprocalStateForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMRTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMRTAX] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMRTAX_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMRTAX_MainForm);
IWebElement formBttn = PRMRTAX_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

