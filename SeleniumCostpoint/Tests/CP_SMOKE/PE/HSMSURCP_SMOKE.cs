 
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
    public class HSMSURCP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Salary Surveys", "xpath","//div[@class='navItem'][.='Salary Surveys']").Click();
new SeleniumControl(sDriver,"Manage Survey Region Mappings", "xpath","//div[@class='navItem'][.='Manage Survey Region Mappings']").Click();


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
				Function.CurrentComponent = "HSMSURCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSURCP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMSURCP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HSMSURCP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSURCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSURCP] Performing VerifyExists on SurveyCompany...", Logger.MessageType.INF);
				SeleniumControl HSMSURCP_SurveyCompany = new SeleniumControl( sDriver, "SurveyCompany", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SURVEY_CO_ID']");
				Function.AssertEqual(true,HSMSURCP_SurveyCompany.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSURCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSURCP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMSURCP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMSURCP_MainForm);
IWebElement formBttn = HSMSURCP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HSMSURCP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HSMSURCP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSURCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSURCP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMSURCP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMSURCP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSURCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSURCP] Performing VerifyExists on SurveyRegionCompensationPlanForm...", Logger.MessageType.INF);
				SeleniumControl HSMSURCP_SurveyRegionCompensationPlanForm = new SeleniumControl( sDriver, "SurveyRegionCompensationPlanForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMSURCP_SURVEYCOMPPLANCD_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,HSMSURCP_SurveyRegionCompensationPlanForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSURCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSURCP] Performing VerifyExist on SurveyRegionCompensationPlanFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMSURCP_SurveyRegionCompensationPlanFormTable = new SeleniumControl( sDriver, "SurveyRegionCompensationPlanFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMSURCP_SURVEYCOMPPLANCD_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMSURCP_SurveyRegionCompensationPlanFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSURCP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSURCP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMSURCP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMSURCP_MainForm);
IWebElement formBttn = HSMSURCP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

