 
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
    public class ADMUDT05_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage UDT05CP", "xpath","//div[@class='navItem'][.='Manage UDT05CP']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ADMUDT05";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[ADMUDT05] Perfoming VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ADMUDT05_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ADMUDT05_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ADMUDT05";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[ADMUDT05] Perfoming VerifyExists on UDT05_UDT05...", Logger.MessageType.INF);
				SeleniumControl ADMUDT05_UDT05_UDT05 = new SeleniumControl( sDriver, "UDT05_UDT05", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='UDT05_ID']");
				Function.AssertEqual(true,ADMUDT05_UDT05_UDT05.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ADMUDT05";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				sDriver.SessionLogger.WriteLine("[ADMUDT05] Perfoming Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ADMUDT05_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ADMUDT05_MainForm);
IWebElement formBttn = ADMUDT05_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

