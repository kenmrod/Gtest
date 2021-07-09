 
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
    public class ADMUDT15_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Configuration", "xpath","//div[@class='deptItem'][.='Configuration']").Click();
new SeleniumControl(sDriver,"Master Data", "xpath","//div[@class='navItem'][.='Master Data']").Click();
new SeleniumControl(sDriver,"Manage UDT15CP", "xpath","//div[@class='navItem'][.='Manage UDT15CP']").Click();


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
				Function.CurrentComponent = "ADMUDT15";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[ADMUDT15] Perfoming VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ADMUDT15_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ADMUDT15_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ADMUDT15";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[ADMUDT15] Perfoming VerifyExists on UDT15_UDT15...", Logger.MessageType.INF);
				SeleniumControl ADMUDT15_UDT15_UDT15 = new SeleniumControl( sDriver, "UDT15_UDT15", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='UDT15_ID']");
				Function.AssertEqual(true,ADMUDT15_UDT15_UDT15.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				sDriver.SessionLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ADMUDT15";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[ADMUDT15] Perfoming Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ADMUDT15_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ADMUDT15_MainForm);
IWebElement formBttn = ADMUDT15_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
