 
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
    public class HSMNBPAY_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Compensation Budgeting", "xpath","//div[@class='navItem'][.='Compensation Budgeting']").Click();
new SeleniumControl(sDriver,"Manage Non-Budgeted Compensation Pay Types", "xpath","//div[@class='navItem'][.='Manage Non-Budgeted Compensation Pay Types']").Click();


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
				Function.CurrentComponent = "HSMNBPAY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMNBPAY] Performing VerifyExists on PayTypesForm...", Logger.MessageType.INF);
				SeleniumControl HSMNBPAY_PayTypesForm = new SeleniumControl( sDriver, "PayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMNBPAY_PAYTYPE_']/ancestor::form[1]");
				Function.AssertEqual(true,HSMNBPAY_PayTypesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMNBPAY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMNBPAY] Performing VerifyExist on PayTypesFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMNBPAY_PayTypesFormTable = new SeleniumControl( sDriver, "PayTypesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMNBPAY_PAYTYPE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMNBPAY_PayTypesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMNBPAY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMNBPAY] Performing VerifyExists on NonBudgetedCompensationPayTypesForm...", Logger.MessageType.INF);
				SeleniumControl HSMNBPAY_NonBudgetedCompensationPayTypesForm = new SeleniumControl( sDriver, "NonBudgetedCompensationPayTypesForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HSMNBPAY_NonBudgetedCompensationPayTypesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMNBPAY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMNBPAY] Performing VerifyExist on NonBudgetedCompensationPayTypesFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMNBPAY_NonBudgetedCompensationPayTypesFormTable = new SeleniumControl( sDriver, "NonBudgetedCompensationPayTypesFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMNBPAY_NonBudgetedCompensationPayTypesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "HSMNBPAY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMNBPAY] Performing Close on NonBudgetedCompensationPayTypesForm...", Logger.MessageType.INF);
				SeleniumControl HSMNBPAY_NonBudgetedCompensationPayTypesForm = new SeleniumControl( sDriver, "NonBudgetedCompensationPayTypesForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMNBPAY_NonBudgetedCompensationPayTypesForm);
IWebElement formBttn = HSMNBPAY_NonBudgetedCompensationPayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

