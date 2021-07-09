 
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
    public class INMACCT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Inventory", "xpath","//div[@class='deptItem'][.='Inventory']").Click();
new SeleniumControl(sDriver,"Inventory Controls", "xpath","//div[@class='navItem'][.='Inventory Controls']").Click();
new SeleniumControl(sDriver,"Configure Inventory Accounts", "xpath","//div[@class='navItem'][.='Configure Inventory Accounts']").Click();


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
				Function.CurrentComponent = "INMACCT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMACCT] Performing VerifyExists on AdjustmentAccountOrgsForm...", Logger.MessageType.INF);
				SeleniumControl INMACCT_AdjustmentAccountOrgsForm = new SeleniumControl( sDriver, "AdjustmentAccountOrgsForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMACCT_AdjustmentAccountOrgsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMACCT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMACCT] Performing VerifyExists on AdjustmentAccountOrgs_AllocatedInventory_Account...", Logger.MessageType.INF);
				SeleniumControl INMACCT_AdjustmentAccountOrgs_AllocatedInventory_Account = new SeleniumControl( sDriver, "AdjustmentAccountOrgs_AllocatedInventory_Account", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VAR_PROJ_ACCT_ID']");
				Function.AssertEqual(true,INMACCT_AdjustmentAccountOrgs_AllocatedInventory_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close the application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMACCT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMACCT] Performing Close on AdjustmentAccountOrgsForm...", Logger.MessageType.INF);
				SeleniumControl INMACCT_AdjustmentAccountOrgsForm = new SeleniumControl( sDriver, "AdjustmentAccountOrgsForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMACCT_AdjustmentAccountOrgsForm);
IWebElement formBttn = INMACCT_AdjustmentAccountOrgsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

