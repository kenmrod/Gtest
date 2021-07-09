 
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
    public class INMWACCT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Configure Default Project Inventory Accounts", "xpath","//div[@class='navItem'][.='Configure Default Project Inventory Accounts']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWACCT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWACCT] Performing VerifyExists on AssetInventoryAbbreviations...", Logger.MessageType.INF);
				SeleniumControl INMWACCT_AssetInventoryAbbreviations = new SeleniumControl( sDriver, "AssetInventoryAbbreviations", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INMWACCT_AssetInventoryAbbreviations.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INMWACCT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWACCT] Performing VerifyExists on AssetInventoryAbbreviations_RMVarAcctID...", Logger.MessageType.INF);
				SeleniumControl INMWACCT_AssetInventoryAbbreviations_RMVarAcctID = new SeleniumControl( sDriver, "AssetInventoryAbbreviations_RMVarAcctID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RM_VAR_ACCT_ID']");
				Function.AssertEqual(true,INMWACCT_AssetInventoryAbbreviations_RMVarAcctID.Exists());

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
				Function.CurrentComponent = "INMWACCT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INMWACCT] Performing Close on AssetInventoryAbbreviations...", Logger.MessageType.INF);
				SeleniumControl INMWACCT_AssetInventoryAbbreviations = new SeleniumControl( sDriver, "AssetInventoryAbbreviations", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INMWACCT_AssetInventoryAbbreviations);
IWebElement formBttn = INMWACCT_AssetInventoryAbbreviations.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

