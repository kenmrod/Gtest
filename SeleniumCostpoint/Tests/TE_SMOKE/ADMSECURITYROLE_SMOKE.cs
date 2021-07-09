 
using System;
using System.Threading.Tasks;
using SeleniumCostpoint.Common;
using Core.Sys;
using Core.Sys.Selenium;
using System.Threading;
using System.Linq;
using OpenQA.Selenium;

namespace SeleniumCostpoint.Tests
{
    public class ADMSECURITYROLE_SMOKE : SeleniumTestScript
    {
        public override bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {
			bool ret = true;
			ErrorMessage = string.Empty;
			SeleniumDriver sDriver = Driver as SeleniumDriver;
			Functions Function = new Functions(sDriver);

			try
			{
				Function.Login( TestEnvironment, out ErrorMessage);
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[CP7Main] Perfoming SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"Time & Expense", "xpath","//div[@class='busItem'][.='Time & Expense']").Click();
new SeleniumControl(sDriver,"Configuration", "xpath","//div[@class='deptItem'][.='Configuration']").Click();
new SeleniumControl(sDriver,"Resources", "xpath","//div[@class='navItem'][.='Resources']").Click();
new SeleniumControl(sDriver,"Manage Security Roles", "xpath","//div[@class='navItem'][.='Manage Security Roles']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				sDriver.SessionLogger.WriteLine("Enter required fields");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ADMSECURITYROLE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[ADMSECURITYROLE] Perfoming VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ADMSECURITYROLE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ADMSECURITYROLE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ADMSECURITYROLE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[ADMSECURITYROLE] Perfoming VerifyExists on SecurityRoles_Description...", Logger.MessageType.INF);
				SeleniumControl ADMSECURITYROLE_SecurityRoles_Description = new SeleniumControl( sDriver, "SecurityRoles_Description", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ROLE_NAME']");
				Function.AssertEqual(true,ADMSECURITYROLE_SecurityRoles_Description.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				sDriver.SessionLogger.WriteLine("Close app");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ADMSECURITYROLE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[ADMSECURITYROLE] Perfoming Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ADMSECURITYROLE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ADMSECURITYROLE_MainForm);
IWebElement formBttn = ADMSECURITYROLE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) formBttn.Click();
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

