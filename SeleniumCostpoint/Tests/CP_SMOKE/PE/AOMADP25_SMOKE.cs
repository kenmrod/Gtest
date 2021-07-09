 
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
    public class AOMADP25_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"ADP Interface", "xpath","//div[@class='navItem'][.='ADP Interface']").Click();
new SeleniumControl(sDriver,"Manage ADP 2.5 Mapping Values", "xpath","//div[@class='navItem'][.='Manage ADP 2.5 Mapping Values']").Click();


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
				Function.CurrentComponent = "AOMADP25";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMADP25] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMADP25_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,AOMADP25_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMADP25";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMADP25] Performing VerifyExists on ADPMapCode...", Logger.MessageType.INF);
				SeleniumControl AOMADP25_ADPMapCode = new SeleniumControl( sDriver, "ADPMapCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ADP_MAP_CD']");
				Function.AssertEqual(true,AOMADP25_ADPMapCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Child Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMADP25";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMADP25] Performing VerifyExists on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl AOMADP25_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[starts-with(@id,'pr__AOMADP25_XADPMAP25_CTW_')]/ancestor::form[1]");
				Function.AssertEqual(true,AOMADP25_TableWindowForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMADP25";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMADP25] Performing VerifyExist on TableWindowTable...", Logger.MessageType.INF);
				SeleniumControl AOMADP25_TableWindowTable = new SeleniumControl( sDriver, "TableWindowTable", "xpath", "//div[starts-with(@id,'pr__AOMADP25_XADPMAP25_CTW_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMADP25_TableWindowTable.Exists());

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
				Function.CurrentComponent = "AOMADP25";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMADP25] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMADP25_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMADP25_MainForm);
IWebElement formBttn = AOMADP25_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

