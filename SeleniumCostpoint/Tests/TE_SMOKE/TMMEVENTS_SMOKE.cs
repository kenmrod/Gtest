 
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
    public class TMMEVENTS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Time", "xpath","//div[@class='deptItem'][.='Time']").Click();
new SeleniumControl(sDriver,"Time Controls", "xpath","//div[@class='navItem'][.='Time Controls']").Click();
new SeleniumControl(sDriver,"Manage Events", "xpath","//div[@class='navItem'][.='Manage Events']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				sDriver.SessionLogger.WriteLine("MAIN FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "TMMEVENTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[TMMEVENTS] Perfoming VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl TMMEVENTS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,TMMEVENTS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "TMMEVENTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[TMMEVENTS] Perfoming VerifyExists on Event...", Logger.MessageType.INF);
				SeleniumControl TMMEVENTS_Event = new SeleniumControl( sDriver, "Event", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EVENT_CD']");
				Function.AssertEqual(true,TMMEVENTS_Event.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				sDriver.SessionLogger.WriteLine("Close App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "TMMEVENTS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[TMMEVENTS] Perfoming Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl TMMEVENTS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(TMMEVENTS_MainForm);
IWebElement formBttn = TMMEVENTS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

