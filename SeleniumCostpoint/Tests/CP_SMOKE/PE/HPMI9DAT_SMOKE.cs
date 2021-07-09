 
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
    public class HPMI9DAT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Employee", "xpath","//div[@class='deptItem'][.='Employee']").Click();
new SeleniumControl(sDriver,"Employee HR Information", "xpath","//div[@class='navItem'][.='Employee HR Information']").Click();
new SeleniumControl(sDriver,"Manage Employee I-9 Data", "xpath","//div[@class='navItem'][.='Manage Employee I-9 Data']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMI9DAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMI9DAT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMI9DAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HPMI9DAT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMI9DAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMI9DAT] Performing VerifyExists on EmployeeName...", Logger.MessageType.INF);
				SeleniumControl HPMI9DAT_EmployeeName = new SeleniumControl( sDriver, "EmployeeName", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LAST_FIRST_NAME']");
				Function.AssertEqual(true,HPMI9DAT_EmployeeName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMI9DAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMI9DAT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMI9DAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HPMI9DAT_MainForm);
IWebElement formBttn = HPMI9DAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HPMI9DAT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HPMI9DAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMI9DAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMI9DAT] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl HPMI9DAT_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMI9DAT_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMI9DAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMI9DAT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMI9DAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HPMI9DAT_MainForm);
IWebElement formBttn = HPMI9DAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMI9DAT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMI9DAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EMPLOYEE I-9 Data Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMI9DAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMI9DAT] Performing VerifyExist on EMPLOYEEI9DataTable...", Logger.MessageType.INF);
				SeleniumControl HPMI9DAT_EMPLOYEEI9DataTable = new SeleniumControl( sDriver, "EMPLOYEEI9DataTable", "xpath", "//div[starts-with(@id,'pr__HPMI9DAT_HI9DATA_I9DATA_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMI9DAT_EMPLOYEEI9DataTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMI9DAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMI9DAT] Performing ClickButton on EMPLOYEEI9DataForm...", Logger.MessageType.INF);
				SeleniumControl HPMI9DAT_EMPLOYEEI9DataForm = new SeleniumControl( sDriver, "EMPLOYEEI9DataForm", "xpath", "//div[starts-with(@id,'pr__HPMI9DAT_HI9DATA_I9DATA_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMI9DAT_EMPLOYEEI9DataForm);
IWebElement formBttn = HPMI9DAT_EMPLOYEEI9DataForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HPMI9DAT_EMPLOYEEI9DataForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HPMI9DAT_EMPLOYEEI9DataForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMI9DAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMI9DAT] Performing VerifyExists on EMPLOYEEI9DataForm...", Logger.MessageType.INF);
				SeleniumControl HPMI9DAT_EMPLOYEEI9DataForm = new SeleniumControl( sDriver, "EMPLOYEEI9DataForm", "xpath", "//div[starts-with(@id,'pr__HPMI9DAT_HI9DATA_I9DATA_')]/ancestor::form[1]");
				Function.AssertEqual(true,HPMI9DAT_EMPLOYEEI9DataForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMI9DAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMI9DAT] Performing ClickButton on EMPLOYEEI9DataForm...", Logger.MessageType.INF);
				SeleniumControl HPMI9DAT_EMPLOYEEI9DataForm = new SeleniumControl( sDriver, "EMPLOYEEI9DataForm", "xpath", "//div[starts-with(@id,'pr__HPMI9DAT_HI9DATA_I9DATA_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMI9DAT_EMPLOYEEI9DataForm);
IWebElement formBttn = HPMI9DAT_EMPLOYEEI9DataForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HPMI9DAT_EMPLOYEEI9DataForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HPMI9DAT_EMPLOYEEI9DataForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMI9DAT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMI9DAT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMI9DAT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HPMI9DAT_MainForm);
IWebElement formBttn = HPMI9DAT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

