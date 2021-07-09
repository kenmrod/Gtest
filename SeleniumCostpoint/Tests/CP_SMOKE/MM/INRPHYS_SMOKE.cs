 
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
    public class INRPHYS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials", "xpath","//div[@class='busItem'][.='Materials']").Click();
new SeleniumControl(sDriver,"Inventory", "xpath","//div[@class='deptItem'][.='Inventory']").Click();
new SeleniumControl(sDriver,"Physical Counts", "xpath","//div[@class='navItem'][.='Physical Counts']").Click();
new SeleniumControl(sDriver,"Print Physical Count Sheets", "xpath","//div[@class='navItem'][.='Print Physical Count Sheets']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INRPHYS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INRPHYS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl INRPHYS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,INRPHYS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INRPHYS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INRPHYS] Performing VerifyExists on MainForm_ParameterID...", Logger.MessageType.INF);
				SeleniumControl INRPHYS_MainForm_ParameterID = new SeleniumControl( sDriver, "MainForm_ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,INRPHYS_MainForm_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INRPHYS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INRPHYS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl INRPHYS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INRPHYS_MainForm);
IWebElement formBttn = INRPHYS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? INRPHYS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
INRPHYS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INRPHYS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INRPHYS] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl INRPHYS_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,INRPHYS_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close the application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "INRPHYS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[INRPHYS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl INRPHYS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(INRPHYS_MainForm);
IWebElement formBttn = INRPHYS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

