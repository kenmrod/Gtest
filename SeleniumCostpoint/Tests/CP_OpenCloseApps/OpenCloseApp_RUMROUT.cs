 
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
    public class OpenCloseApp_RUMROUT : SeleniumTestScript
    {
        public override bool TestExecute(out string ErrorMessage, string TestEnvironment, IDriver Driver)
        {
			bool ret = true;
			ErrorMessage = string.Empty;
			SeleniumDriver sDriver = Driver as SeleniumDriver;
			Functions Function = new Functions(sDriver, this);

			SeleniumControl SearchApplications = new SeleniumControl( sDriver, "SearchApplications", "ID", "appFltrFld");
			SeleniumControl SearchAppResultList = new SeleniumControl( sDriver, "SearchAppResultList", "ID", "autoCompleteDiv");
			SeleniumControl MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
			SeleniumControl LogOut = new SeleniumControl( sDriver, "LogOut", "ID", "lgoffBttn");
            SeleniumControl QryBttn = new SeleniumControl(sDriver, "QryBttn", "ID", "CloseQry");

			try
			{
				Function.Login(TestEnvironment, out ErrorMessage);
				this.ScriptLogger.WriteLine("[RUMROUT] Opening app...", Logger.MessageType.INF);
				Thread.Sleep(3000);
				SearchApplications.SendKeys("RUMROUT",true);
				Thread.Sleep(500);
				SearchAppResultList.FindElement();
				SearchAppResultList.mElement.FindElements(By.XPath(".//div[@class='autoCItem'][contains(@style,'block')][contains(.,'(RUMROUT)')]")).FirstOrDefault().Click();
				Function.WaitControlDisplayed(MainForm,10);
				this.ScriptLogger.WriteLine("[RUMROUT] Performing Close on MainForm...", Logger.MessageType.INF);
				Function.WaitControlDisplayed(MainForm);
                Thread.Sleep(3000);
                if (QryBttn.Exists(1)) { QryBttn.Click(); }
				IWebElement formBttn = MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
				if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
					else throw new Exception("Close Button not found ");
				Thread.Sleep(1000);
			}
			catch (Exception ex)
			{
				ret = false;
				ErrorMessage = ex.Message;
				throw new Exception(ex.Message);
			}
			finally
			{
				//must attempt logout 
				if(LogOut.Exists(1)) LogOut.Click();
			}
			return ret;
        }
    }
	
}
