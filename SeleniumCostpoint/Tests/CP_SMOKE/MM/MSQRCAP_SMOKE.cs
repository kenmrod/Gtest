 
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
    public class MSQRCAP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Master Production Scheduling", "xpath","//div[@class='deptItem'][.='Master Production Scheduling']").Click();
new SeleniumControl(sDriver,"Rough-Cut Capacity Plan", "xpath","//div[@class='navItem'][.='Rough-Cut Capacity Plan']").Click();
new SeleniumControl(sDriver,"View Rough-Cut Capacity Plan", "xpath","//div[@class='navItem'][.='View Rough-Cut Capacity Plan']").Click();


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
				Function.CurrentComponent = "MSQRCAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSQRCAP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MSQRCAP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MSQRCAP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSQRCAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSQRCAP] Performing VerifyExists on MainForm_MPSPlan...", Logger.MessageType.INF);
				SeleniumControl MSQRCAP_MainForm_MPSPlan = new SeleniumControl( sDriver, "MainForm_MPSPlan", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MPS_PLAN']");
				Function.AssertEqual(true,MSQRCAP_MainForm_MPSPlan.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("KeyResourceLoad");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSQRCAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSQRCAP] Performing VerifyExists on KeyResourceLoadForm...", Logger.MessageType.INF);
				SeleniumControl MSQRCAP_KeyResourceLoadForm = new SeleniumControl( sDriver, "KeyResourceLoadForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSQRCAP_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,MSQRCAP_KeyResourceLoadForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSQRCAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSQRCAP] Performing VerifyExists on KeyResourceLoad_WeekEnding...", Logger.MessageType.INF);
				SeleniumControl MSQRCAP_KeyResourceLoad_WeekEnding = new SeleniumControl( sDriver, "KeyResourceLoad_WeekEnding", "xpath", "//div[translate(@id,'0123456789','')='pr__MSQRCAP_DTL_']/ancestor::form[1]/descendant::*[@id='WEEK_ENDING_DT']");
				Function.AssertEqual(true,MSQRCAP_KeyResourceLoad_WeekEnding.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Key Resource");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSQRCAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSQRCAP] Performing VerifyExists on KeyResourceLoad_KeyResourceLink...", Logger.MessageType.INF);
				SeleniumControl MSQRCAP_KeyResourceLoad_KeyResourceLink = new SeleniumControl( sDriver, "KeyResourceLoad_KeyResourceLink", "ID", "lnk_5121_MSQRCAP_DTL");
				Function.AssertEqual(true,MSQRCAP_KeyResourceLoad_KeyResourceLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSQRCAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSQRCAP] Performing Click on KeyResourceLoad_KeyResourceLink...", Logger.MessageType.INF);
				SeleniumControl MSQRCAP_KeyResourceLoad_KeyResourceLink = new SeleniumControl( sDriver, "KeyResourceLoad_KeyResourceLink", "ID", "lnk_5121_MSQRCAP_DTL");
				Function.WaitControlDisplayed(MSQRCAP_KeyResourceLoad_KeyResourceLink);
MSQRCAP_KeyResourceLoad_KeyResourceLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogIfExists("You must query and select a record before performing this action.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogIfExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Weekly Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSQRCAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSQRCAP] Performing VerifyExists on KeyResourceLoad_WeeklyDetailLink...", Logger.MessageType.INF);
				SeleniumControl MSQRCAP_KeyResourceLoad_WeeklyDetailLink = new SeleniumControl( sDriver, "KeyResourceLoad_WeeklyDetailLink", "ID", "lnk_5129_MSQRCAP_DTL");
				Function.AssertEqual(true,MSQRCAP_KeyResourceLoad_WeeklyDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSQRCAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSQRCAP] Performing Click on KeyResourceLoad_WeeklyDetailLink...", Logger.MessageType.INF);
				SeleniumControl MSQRCAP_KeyResourceLoad_WeeklyDetailLink = new SeleniumControl( sDriver, "KeyResourceLoad_WeeklyDetailLink", "ID", "lnk_5129_MSQRCAP_DTL");
				Function.WaitControlDisplayed(MSQRCAP_KeyResourceLoad_WeeklyDetailLink);
MSQRCAP_KeyResourceLoad_WeeklyDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogIfExists("You must query and select a record before performing this action.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogIfExists]" , ex.Message));
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
				Function.CurrentComponent = "MSQRCAP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSQRCAP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MSQRCAP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MSQRCAP_MainForm);
IWebElement formBttn = MSQRCAP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

