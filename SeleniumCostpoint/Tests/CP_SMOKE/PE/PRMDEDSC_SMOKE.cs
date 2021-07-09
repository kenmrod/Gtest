 
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
    public class PRMDEDSC_SMOKE : SeleniumTestScript
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
								try
				{
				this.ScriptLogger.WriteLine("START");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Payroll", "xpath","//div[@class='deptItem'][.='Payroll']").Click();
new SeleniumControl(sDriver,"Deductions", "xpath","//div[@class='navItem'][.='Deductions']").Click();
new SeleniumControl(sDriver,"Manage Deduction Schedules", "xpath","//div[@class='navItem'][.='Manage Deduction Schedules']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMDEDSC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMDEDSC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMDEDSC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMDEDSC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMDEDSC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMDEDSC] Performing VerifyExists on DeductionScheduleCode...", Logger.MessageType.INF);
				SeleniumControl PRMDEDSC_DeductionScheduleCode = new SeleniumControl( sDriver, "DeductionScheduleCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DED_SCH_CD']");
				Function.AssertEqual(true,PRMDEDSC_DeductionScheduleCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMDEDSC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMDEDSC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMDEDSC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMDEDSC_MainForm);
IWebElement formBttn = PRMDEDSC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMDEDSC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMDEDSC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMDEDSC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMDEDSC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMDEDSC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMDEDSC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMDEDSC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMDEDSC] Performing Click on DeductionSchedulesLink...", Logger.MessageType.INF);
				SeleniumControl PRMDEDSC_DeductionSchedulesLink = new SeleniumControl( sDriver, "DeductionSchedulesLink", "ID", "lnk_3820_PRMDEDSC_DEDSCH_HDR");
				Function.WaitControlDisplayed(PRMDEDSC_DeductionSchedulesLink);
PRMDEDSC_DeductionSchedulesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMDEDSC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMDEDSC] Performing VerifyExists on DeductionSchedulesForm...", Logger.MessageType.INF);
				SeleniumControl PRMDEDSC_DeductionSchedulesForm = new SeleniumControl( sDriver, "DeductionSchedulesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMDEDSC_DEDSCHLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMDEDSC_DeductionSchedulesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMDEDSC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMDEDSC] Performing VerifyExist on DeductionSchedulesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMDEDSC_DeductionSchedulesFormTable = new SeleniumControl( sDriver, "DeductionSchedulesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMDEDSC_DEDSCHLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMDEDSC_DeductionSchedulesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMDEDSC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMDEDSC] Performing Close on DeductionSchedulesForm...", Logger.MessageType.INF);
				SeleniumControl PRMDEDSC_DeductionSchedulesForm = new SeleniumControl( sDriver, "DeductionSchedulesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMDEDSC_DEDSCHLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMDEDSC_DeductionSchedulesForm);
IWebElement formBttn = PRMDEDSC_DeductionSchedulesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

