 
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
    public class FARRECON_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Fixed Assets", "xpath","//div[@class='deptItem'][.='Fixed Assets']").Click();
new SeleniumControl(sDriver,"Fixed Assets Reports", "xpath","//div[@class='navItem'][.='Fixed Assets Reports']").Click();
new SeleniumControl(sDriver,"Print Fixed Assets/General Ledger Reconciliation Report", "xpath","//div[@class='navItem'][.='Print Fixed Assets/General Ledger Reconciliation Report']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FARRECON";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FARRECON] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl FARRECON_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,FARRECON_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FARRECON";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FARRECON] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl FARRECON_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,FARRECON_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FARRECON";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FARRECON] Performing VerifyExists on SelectByOptions_PrintReconciliationFor_FACost...", Logger.MessageType.INF);
				SeleniumControl FARRECON_SelectByOptions_PrintReconciliationFor_FACost = new SeleniumControl( sDriver, "SelectByOptions_PrintReconciliationFor_FACost", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INCL_ASSET_ACCTS']");
				Function.AssertEqual(true,FARRECON_SelectByOptions_PrintReconciliationFor_FACost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FARRECON";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FARRECON] Performing VerifyExists on SelectionRange_Option_AssetAccountSNM...", Logger.MessageType.INF);
				SeleniumControl FARRECON_SelectionRange_Option_AssetAccountSNM = new SeleniumControl( sDriver, "SelectionRange_Option_AssetAccountSNM", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ACCT_RANGE_OPT']");
				Function.AssertEqual(true,FARRECON_SelectionRange_Option_AssetAccountSNM.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FARRECON";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FARRECON] Performing VerifyExists on Options_Include_FACurrentPeriod...", Logger.MessageType.INF);
				SeleniumControl FARRECON_Options_Include_FACurrentPeriod = new SeleniumControl( sDriver, "Options_Include_FACurrentPeriod", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INCL_CURPD_DEPR']");
				Function.AssertEqual(true,FARRECON_Options_Include_FACurrentPeriod.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FARRECON";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FARRECON] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl FARRECON_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FARRECON_MainForm);
IWebElement formBttn = FARRECON_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

