 
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
    public class TMMMGRWORKSCH : SeleniumTestScript
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
								try
				{
				sDriver.SessionLogger.WriteLine("LOGIN");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[CP7Main] Perfoming SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"Time & Expense", "xpath","//div[@class='busItem'][.='Time & Expense']").Click();
new SeleniumControl(sDriver,"Time", "xpath","//div[@class='deptItem'][.='Time']").Click();
new SeleniumControl(sDriver,"Timesheets", "xpath","//div[@class='navItem'][.='Timesheets']").Click();
new SeleniumControl(sDriver,"Manage Resource Work Schedules", "xpath","//div[@class='navItem'][.='Manage Resource Work Schedules']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				sDriver.SessionLogger.WriteLine("MAIN MENU");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "TMMMGRWORKSCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[TMMMGRWORKSCH] Perfoming VerifyExists on Criteria_EmployeeID...", Logger.MessageType.INF);
				SeleniumControl TMMMGRWORKSCH_Criteria_EmployeeID = new SeleniumControl( sDriver, "Criteria_EmployeeID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,TMMMGRWORKSCH_Criteria_EmployeeID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "TMMMGRWORKSCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[TMMMGRWORKSCH] Perfoming VerifyReadOnly on Criteria_EmployeeID...", Logger.MessageType.INF);
				SeleniumControl TMMMGRWORKSCH_Criteria_EmployeeID = new SeleniumControl( sDriver, "Criteria_EmployeeID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual("false",TMMMGRWORKSCH_Criteria_EmployeeID.IsReadOnly().ToLower());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyReadOnly]" , ex.Message));
				}
								try
				{
				sDriver.SessionLogger.WriteLine("LOGOUT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[CP7Main] Perfoming Click on LogOut...", Logger.MessageType.INF);
				SeleniumControl CP7Main_LogOut = new SeleniumControl( sDriver, "LogOut", "ID", "lgoffBttn");
				Function.WaitControlDisplayed(CP7Main_LogOut);
if (CP7Main_LogOut.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
CP7Main_LogOut.Click(5,5);
else CP7Main_LogOut.Click(4.5);


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

