 
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
    public class HARNHIRE_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Affirmative Action", "xpath","//div[@class='deptItem'][.='Affirmative Action']").Click();
new SeleniumControl(sDriver,"Affirmative Action Reports", "xpath","//div[@class='navItem'][.='Affirmative Action Reports']").Click();
new SeleniumControl(sDriver,"Print New Hire Analysis Report", "xpath","//div[@class='navItem'][.='Print New Hire Analysis Report']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HARNHIRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HARNHIRE] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HARNHIRE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HARNHIRE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HARNHIRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HARNHIRE] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl HARNHIRE_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,HARNHIRE_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HARNHIRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HARNHIRE] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HARNHIRE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HARNHIRE_MainForm);
IWebElement formBttn = HARNHIRE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HARNHIRE_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HARNHIRE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HARNHIRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HARNHIRE] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HARNHIRE_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HARNHIRE_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HARNHIRE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HARNHIRE] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HARNHIRE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HARNHIRE_MainForm);
IWebElement formBttn = HARNHIRE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

