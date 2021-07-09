 
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
    public class GLMACT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Accounts", "xpath","//div[@class='navItem'][.='Manage Accounts']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN TABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMACT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMACT] Performing VerifyExists on Account_Account...", Logger.MessageType.INF);
				SeleniumControl GLMACT_Account_Account = new SeleniumControl( sDriver, "Account_Account", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,GLMACT_Account_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMACT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMACT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMACT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMACT_MainForm);
IWebElement formBttn = GLMACT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? GLMACT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
GLMACT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMACT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMACT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMACT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMACT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMACT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMACT] Performing VerifyExists on Account_LinkOrganizationsLink...", Logger.MessageType.INF);
				SeleniumControl GLMACT_Account_LinkOrganizationsLink = new SeleniumControl( sDriver, "Account_LinkOrganizationsLink", "ID", "lnk_1000861_GLMACT_ACCT_HDR");
				Function.AssertEqual(true,GLMACT_Account_LinkOrganizationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMACT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMACT] Performing Click on Account_LinkOrganizationsLink...", Logger.MessageType.INF);
				SeleniumControl GLMACT_Account_LinkOrganizationsLink = new SeleniumControl( sDriver, "Account_LinkOrganizationsLink", "ID", "lnk_1000861_GLMACT_ACCT_HDR");
				Function.WaitControlDisplayed(GLMACT_Account_LinkOrganizationsLink);
GLMACT_Account_LinkOrganizationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMACT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMACT] Performing VerifyExists on LinkToOrganizationsForm...", Logger.MessageType.INF);
				SeleniumControl GLMACT_LinkToOrganizationsForm = new SeleniumControl( sDriver, "LinkToOrganizationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMACT_LINKORGS_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMACT_LinkToOrganizationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMACT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMACT] Performing VerifyExists on LinkToOrganizations_Org...", Logger.MessageType.INF);
				SeleniumControl GLMACT_LinkToOrganizations_Org = new SeleniumControl( sDriver, "LinkToOrganizations_Org", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMACT_LINKORGS_']/ancestor::form[1]/descendant::*[@id='ORG_ID']");
				Function.AssertEqual(true,GLMACT_LinkToOrganizations_Org.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMACT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMACT] Performing Close on LinkToOrganizationsForm...", Logger.MessageType.INF);
				SeleniumControl GLMACT_LinkToOrganizationsForm = new SeleniumControl( sDriver, "LinkToOrganizationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMACT_LINKORGS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMACT_LinkToOrganizationsForm);
IWebElement formBttn = GLMACT_LinkToOrganizationsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "GLMACT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMACT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMACT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMACT_MainForm);
IWebElement formBttn = GLMACT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

