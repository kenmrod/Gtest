 
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
    public class GLRTBAL_SMOKE : SeleniumTestScript
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
								try
				{
				this.ScriptLogger.WriteLine("START");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"General Ledger", "xpath","//div[@class='deptItem'][.='General Ledger']").Click();
new SeleniumControl(sDriver,"General Ledger Reports/Inquiries", "xpath","//div[@class='navItem'][.='General Ledger Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"Print Trial Balance Report", "xpath","//div[@class='navItem'][.='Print Trial Balance Report']").Click();


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
				Function.CurrentComponent = "GLRTBAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLRTBAL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLRTBAL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLRTBAL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLRTBAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLRTBAL] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl GLRTBAL_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,GLRTBAL_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLRTBAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLRTBAL] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLRTBAL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLRTBAL_MainForm);
IWebElement formBttn = GLRTBAL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? GLRTBAL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
GLRTBAL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLRTBAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLRTBAL] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl GLRTBAL_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLRTBAL_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLRTBAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLRTBAL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLRTBAL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLRTBAL_MainForm);
IWebElement formBttn = GLRTBAL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

