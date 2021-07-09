 
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
    public class LDMELSET_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Labor", "xpath","//div[@class='deptItem'][.='Labor']").Click();
new SeleniumControl(sDriver,"Timesheet Defaults", "xpath","//div[@class='navItem'][.='Timesheet Defaults']").Click();
new SeleniumControl(sDriver,"Manage Employee Timesheet Line Type Defaults", "xpath","//div[@class='navItem'][.='Manage Employee Timesheet Line Type Defaults']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMELSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMELSET] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMELSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDMELSET_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMELSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMELSET] Performing VerifyExists on Employee...", Logger.MessageType.INF);
				SeleniumControl LDMELSET_Employee = new SeleniumControl( sDriver, "Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,LDMELSET_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMELSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMELSET] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMELSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMELSET_MainForm);
IWebElement formBttn = LDMELSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? LDMELSET_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
LDMELSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMELSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMELSET] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMELSET_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMELSET_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMELSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMELSET] Performing VerifyExists on DetailsForm...", Logger.MessageType.INF);
				SeleniumControl LDMELSET_DetailsForm = new SeleniumControl( sDriver, "DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMELSET_EMPLTSLNTYPE_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMELSET_DetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMELSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMELSET] Performing VerifyExist on DetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMELSET_DetailsFormTable = new SeleniumControl( sDriver, "DetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMELSET_EMPLTSLNTYPE_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMELSET_DetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMELSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMELSET] Performing ClickButton on DetailsForm...", Logger.MessageType.INF);
				SeleniumControl LDMELSET_DetailsForm = new SeleniumControl( sDriver, "DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMELSET_EMPLTSLNTYPE_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMELSET_DetailsForm);
IWebElement formBttn = LDMELSET_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? LDMELSET_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
LDMELSET_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMELSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMELSET] Performing VerifyExists on Details_PayType...", Logger.MessageType.INF);
				SeleniumControl LDMELSET_Details_PayType = new SeleniumControl( sDriver, "Details_PayType", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMELSET_EMPLTSLNTYPE_CHLD_']/ancestor::form[1]/descendant::*[@id='DFLT_PAY_TYPE']");
				Function.AssertEqual(true,LDMELSET_Details_PayType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMELSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMELSET] Performing Close on DetailsForm...", Logger.MessageType.INF);
				SeleniumControl LDMELSET_DetailsForm = new SeleniumControl( sDriver, "DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMELSET_EMPLTSLNTYPE_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMELSET_DetailsForm);
IWebElement formBttn = LDMELSET_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

