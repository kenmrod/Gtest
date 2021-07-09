 
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
    public class SMOKE_0001 : SeleniumTestScript
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

				this.ScriptLogger.WriteLine("[CP7Main] Performing VerifyExists on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				Function.AssertEqual(true,CP7Main_NavMenu.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing VerifyExists on UserConfiguration...", Logger.MessageType.INF);
				SeleniumControl CP7Main_UserConfiguration = new SeleniumControl( sDriver, "UserConfiguration", "ID", "userConfigBttn");
				Function.AssertEqual(true,CP7Main_UserConfiguration.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing Click on UserConfiguration...", Logger.MessageType.INF);
				SeleniumControl CP7Main_UserConfiguration = new SeleniumControl( sDriver, "UserConfiguration", "ID", "userConfigBttn");
				Function.WaitControlDisplayed(CP7Main_UserConfiguration);
if (CP7Main_UserConfiguration.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
CP7Main_UserConfiguration.Click(5,5);
else CP7Main_UserConfiguration.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing Click on UserConfiguration...", Logger.MessageType.INF);
				SeleniumControl CP7Main_UserConfiguration = new SeleniumControl( sDriver, "UserConfiguration", "ID", "userConfigBttn");
				Function.WaitControlDisplayed(CP7Main_UserConfiguration);
if (CP7Main_UserConfiguration.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
CP7Main_UserConfiguration.Click(5,5);
else CP7Main_UserConfiguration.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
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

