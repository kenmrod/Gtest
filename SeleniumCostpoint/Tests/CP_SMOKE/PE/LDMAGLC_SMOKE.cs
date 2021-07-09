 
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
    public class LDMAGLC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Employee", "xpath","//div[@class='deptItem'][.='Employee']").Click();
new SeleniumControl(sDriver,"Basic Employee Information", "xpath","//div[@class='navItem'][.='Basic Employee Information']").Click();
new SeleniumControl(sDriver,"Assign GLCs to Employees", "xpath","//div[@class='navItem'][.='Assign GLCs to Employees']").Click();


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
				Function.CurrentComponent = "LDMAGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMAGLC] Performing VerifyExists on SelectGeneralLaborCategoriesForm...", Logger.MessageType.INF);
				SeleniumControl LDMAGLC_SelectGeneralLaborCategoriesForm = new SeleniumControl( sDriver, "SelectGeneralLaborCategoriesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMAGLC_GENLLABCAT_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMAGLC_SelectGeneralLaborCategoriesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMAGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMAGLC] Performing VerifyExist on SelectGeneralLaborCategoriesFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMAGLC_SelectGeneralLaborCategoriesFormTable = new SeleniumControl( sDriver, "SelectGeneralLaborCategoriesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMAGLC_GENLLABCAT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMAGLC_SelectGeneralLaborCategoriesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMAGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMAGLC] Performing VerifyExists on SelectEmployeesForm...", Logger.MessageType.INF);
				SeleniumControl LDMAGLC_SelectEmployeesForm = new SeleniumControl( sDriver, "SelectEmployeesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMAGLC_EMPL_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMAGLC_SelectEmployeesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMAGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMAGLC] Performing VerifyExist on SelectEmployeesFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMAGLC_SelectEmployeesFormTable = new SeleniumControl( sDriver, "SelectEmployeesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMAGLC_EMPL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMAGLC_SelectEmployeesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMAGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMAGLC] Performing VerifyExists on AssignGLCsToEmployeesForm...", Logger.MessageType.INF);
				SeleniumControl LDMAGLC_AssignGLCsToEmployeesForm = new SeleniumControl( sDriver, "AssignGLCsToEmployeesForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDMAGLC_AssignGLCsToEmployeesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMAGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMAGLC] Performing VerifyExist on AssignGLCsToEmployeesFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMAGLC_AssignGLCsToEmployeesFormTable = new SeleniumControl( sDriver, "AssignGLCsToEmployeesFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMAGLC_AssignGLCsToEmployeesFormTable.Exists());

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
				Function.CurrentComponent = "LDMAGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMAGLC] Performing Close on SelectEmployeesForm...", Logger.MessageType.INF);
				SeleniumControl LDMAGLC_SelectEmployeesForm = new SeleniumControl( sDriver, "SelectEmployeesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMAGLC_EMPL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMAGLC_SelectEmployeesForm);
IWebElement formBttn = LDMAGLC_SelectEmployeesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

