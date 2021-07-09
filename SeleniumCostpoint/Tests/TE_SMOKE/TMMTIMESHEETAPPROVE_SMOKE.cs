 
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
    public class TMMTIMESHEETAPPROVE_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Timesheets", "xpath","//div[@class='navItem'][.='Timesheets']").Click();
new SeleniumControl(sDriver,"Manage/Approve Timesheets", "xpath","//div[@class='navItem'][.='Manage/Approve Timesheets']").Click();


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
				Function.CurrentComponent = "TMMTIMESHEET_APPROVE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[TMMTIMESHEET_APPROVE] Perfoming VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl TMMTIMESHEET_APPROVE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,TMMTIMESHEET_APPROVE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "TMMTIMESHEET_APPROVE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[TMMTIMESHEET_APPROVE] Perfoming VerifyExists on ApproveTimesheet_Criteria_Schedule...", Logger.MessageType.INF);
				SeleniumControl TMMTIMESHEET_APPROVE_ApproveTimesheet_Criteria_Schedule = new SeleniumControl( sDriver, "ApproveTimesheet_Criteria_Schedule", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TS_SCHEDULE_DESC']");
				Function.AssertEqual(true,TMMTIMESHEET_APPROVE_ApproveTimesheet_Criteria_Schedule.Exists());

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
				Function.CurrentComponent = "TMMTIMESHEET_APPROVE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[TMMTIMESHEET_APPROVE] Perfoming Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl TMMTIMESHEET_APPROVE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(TMMTIMESHEET_APPROVE_MainForm);
IWebElement formBttn = TMMTIMESHEET_APPROVE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

