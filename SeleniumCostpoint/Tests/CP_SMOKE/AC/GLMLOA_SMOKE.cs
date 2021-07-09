 
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
    public class GLMLOA_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"General Ledger", "xpath","//div[@class='deptItem'][.='General Ledger']").Click();
new SeleniumControl(sDriver,"Accounts", "xpath","//div[@class='navItem'][.='Accounts']").Click();
new SeleniumControl(sDriver,"Mass Link Accounts/Organizations", "xpath","//div[@class='navItem'][.='Mass Link Accounts/Organizations']").Click();


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
				Function.CurrentComponent = "GLMLOA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMLOA] Performing VerifyExist on AccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMLOA_AccountsFormTable = new SeleniumControl( sDriver, "AccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMLOA_ACCT_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMLOA_AccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMLOA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMLOA] Performing VerifyExist on OrganizationsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMLOA_OrganizationsFormTable = new SeleniumControl( sDriver, "OrganizationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMLOA_ORG_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMLOA_OrganizationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMLOA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMLOA] Performing VerifyExist on SelectedAccountsOrganizationsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMLOA_SelectedAccountsOrganizationsFormTable = new SeleniumControl( sDriver, "SelectedAccountsOrganizationsFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMLOA_SelectedAccountsOrganizationsFormTable.Exists());

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
				Function.CurrentComponent = "GLMLOA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMLOA] Performing ClickButton on OrganizationsForm...", Logger.MessageType.INF);
				SeleniumControl GLMLOA_OrganizationsForm = new SeleniumControl( sDriver, "OrganizationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMLOA_ORG_TBL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMLOA_OrganizationsForm);
IWebElement formBttn = GLMLOA_OrganizationsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Count <= 0 ? GLMLOA_OrganizationsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Close')]")).FirstOrDefault() :
GLMLOA_OrganizationsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Close not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
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

