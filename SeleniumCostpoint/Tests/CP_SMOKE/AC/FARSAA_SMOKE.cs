 
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
    public class FARSAA_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"Fixed Assets", "xpath","//div[@class='deptItem'][.='Fixed Assets']").Click();
new SeleniumControl(sDriver,"Fixed Assets Reports", "xpath","//div[@class='navItem'][.='Fixed Assets Reports']").Click();
new SeleniumControl(sDriver,"Print Schedule of Asset Activity Report", "xpath","//div[@class='navItem'][.='Print Schedule of Asset Activity Report']").Click();


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
				Function.CurrentComponent = "FARSAA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FARSAA] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl FARSAA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,FARSAA_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FARSAA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FARSAA] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl FARSAA_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,FARSAA_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FARSAA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FARSAA] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl FARSAA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FARSAA_MainForm);
IWebElement formBttn = FARSAA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? FARSAA_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
FARSAA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FARSAA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FARSAA] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl FARSAA_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FARSAA_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FARSAA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FARSAA] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl FARSAA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FARSAA_MainForm);
IWebElement formBttn = FARSAA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

