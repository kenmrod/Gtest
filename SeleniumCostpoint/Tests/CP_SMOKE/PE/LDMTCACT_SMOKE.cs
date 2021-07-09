 
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
    public class LDMTCACT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Labor", "xpath","//div[@class='deptItem'][.='Labor']").Click();
new SeleniumControl(sDriver,"Timesheet Interface", "xpath","//div[@class='navItem'][.='Timesheet Interface']").Click();
new SeleniumControl(sDriver,"Manage Accounts for Export", "xpath","//div[@class='navItem'][.='Manage Accounts for Export']").Click();


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
				Function.CurrentComponent = "LDMTCACT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTCACT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMTCACT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTCACT_ACCT_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMTCACT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTCACT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTCACT] Performing VerifyExists on MassUpdateAccounts_DeltekTimeAndExpenseAccountType...", Logger.MessageType.INF);
				SeleniumControl LDMTCACT_MassUpdateAccounts_DeltekTimeAndExpenseAccountType = new SeleniumControl( sDriver, "MassUpdateAccounts_DeltekTimeAndExpenseAccountType", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TC_ACCT_TYPE_CD']");
				Function.AssertEqual(true,LDMTCACT_MassUpdateAccounts_DeltekTimeAndExpenseAccountType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTCACT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTCACT] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl LDMTCACT_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTCACT_ACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMTCACT_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on MainMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainMenu = new SeleniumControl( sDriver, "MainMenu", "ID", "wMnuBar");
				new SeleniumControl(sDriver,"File", "xpath","//span[@class='wMnuHead'][.='FILE']").Click();
new SeleniumControl(sDriver,"Close Application", "xpath","//*[@class='wMnuPickLbl'][.='Close Application']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
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

