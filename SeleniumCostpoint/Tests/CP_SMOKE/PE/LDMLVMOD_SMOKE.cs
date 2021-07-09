 
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
    public class LDMLVMOD_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Leave", "xpath","//div[@class='deptItem'][.='Leave']").Click();
new SeleniumControl(sDriver,"Leave Controls", "xpath","//div[@class='navItem'][.='Leave Controls']").Click();
new SeleniumControl(sDriver,"Manage Leave Modify Codes", "xpath","//div[@class='navItem'][.='Manage Leave Modify Codes']").Click();


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
				Function.CurrentComponent = "LDMLVMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVMOD] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMLVMOD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDMLVMOD_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVMOD] Performing VerifyExists on LeaveModifierCode...", Logger.MessageType.INF);
				SeleniumControl LDMLVMOD_LeaveModifierCode = new SeleniumControl( sDriver, "LeaveModifierCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LV_MOD_CD']");
				Function.AssertEqual(true,LDMLVMOD_LeaveModifierCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVMOD] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMLVMOD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMLVMOD_MainForm);
IWebElement formBttn = LDMLVMOD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? LDMLVMOD_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
LDMLVMOD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVMOD] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMLVMOD_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMLVMOD_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Leave Modifer Details Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVMOD] Performing VerifyExists on LeaveModifierDetailsLink...", Logger.MessageType.INF);
				SeleniumControl LDMLVMOD_LeaveModifierDetailsLink = new SeleniumControl( sDriver, "LeaveModifierDetailsLink", "ID", "lnk_5634_LDMLVMOD_LVMODIFIER_HDR");
				Function.AssertEqual(true,LDMLVMOD_LeaveModifierDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVMOD] Performing Click on LeaveModifierDetailsLink...", Logger.MessageType.INF);
				SeleniumControl LDMLVMOD_LeaveModifierDetailsLink = new SeleniumControl( sDriver, "LeaveModifierDetailsLink", "ID", "lnk_5634_LDMLVMOD_LVMODIFIER_HDR");
				Function.WaitControlDisplayed(LDMLVMOD_LeaveModifierDetailsLink);
LDMLVMOD_LeaveModifierDetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVMOD] Performing VerifyExists on LeaveModifierDetailsForm...", Logger.MessageType.INF);
				SeleniumControl LDMLVMOD_LeaveModifierDetailsForm = new SeleniumControl( sDriver, "LeaveModifierDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMLVMOD_LVMODTBL_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMLVMOD_LeaveModifierDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVMOD] Performing VerifyExist on LeaveModifierDetails_Table...", Logger.MessageType.INF);
				SeleniumControl LDMLVMOD_LeaveModifierDetails_Table = new SeleniumControl( sDriver, "LeaveModifierDetails_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMLVMOD_LVMODTBL_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMLVMOD_LeaveModifierDetails_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLVMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVMOD] Performing Close on LeaveModifierDetailsForm...", Logger.MessageType.INF);
				SeleniumControl LDMLVMOD_LeaveModifierDetailsForm = new SeleniumControl( sDriver, "LeaveModifierDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMLVMOD_LVMODTBL_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMLVMOD_LeaveModifierDetailsForm);
IWebElement formBttn = LDMLVMOD_LeaveModifierDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "LDMLVMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLVMOD] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMLVMOD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMLVMOD_MainForm);
IWebElement formBttn = LDMLVMOD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

