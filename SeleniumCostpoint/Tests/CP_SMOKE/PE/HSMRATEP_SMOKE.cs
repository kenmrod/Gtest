 
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
    public class HSMRATEP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Compensation", "xpath","//div[@class='deptItem'][.='Compensation']").Click();
new SeleniumControl(sDriver,"Performance Reviews", "xpath","//div[@class='navItem'][.='Performance Reviews']").Click();
new SeleniumControl(sDriver,"Manage Performance Ratings by Plan", "xpath","//div[@class='navItem'][.='Manage Performance Ratings by Plan']").Click();


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
				Function.CurrentComponent = "HSMRATEP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMRATEP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMRATEP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HSMRATEP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMRATEP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMRATEP] Performing VerifyExists on Options_CompensationPlan...", Logger.MessageType.INF);
				SeleniumControl HSMRATEP_Options_CompensationPlan = new SeleniumControl( sDriver, "Options_CompensationPlan", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DFSCOMPPLAN']");
				Function.AssertEqual(true,HSMRATEP_Options_CompensationPlan.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMRATEP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMRATEP] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMRATEP_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMRATEP_RATINGBYPLAN_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMRATEP_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMRATEP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMRATEP] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl HSMRATEP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMRATEP_RATINGBYPLAN_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HSMRATEP_ChildForm);
IWebElement formBttn = HSMRATEP_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HSMRATEP_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HSMRATEP_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMRATEP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMRATEP] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl HSMRATEP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMRATEP_RATINGBYPLAN_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,HSMRATEP_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMRATEP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMRATEP] Performing VerifyExists on CompensationPlanInformation_CompensationPlan...", Logger.MessageType.INF);
				SeleniumControl HSMRATEP_CompensationPlanInformation_CompensationPlan = new SeleniumControl( sDriver, "CompensationPlanInformation_CompensationPlan", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMRATEP_RATINGBYPLAN_CHLD_']/ancestor::form[1]/descendant::*[@id='COMP_PLAN_CD']");
				Function.AssertEqual(true,HSMRATEP_CompensationPlanInformation_CompensationPlan.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMRATEP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMRATEP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMRATEP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMRATEP_MainForm);
IWebElement formBttn = HSMRATEP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

