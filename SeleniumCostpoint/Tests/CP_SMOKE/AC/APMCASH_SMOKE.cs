 
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
    public class APMCASH_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounts Payable", "xpath","//div[@class='deptItem'][.='Accounts Payable']").Click();
new SeleniumControl(sDriver,"Accounts Payable Controls", "xpath","//div[@class='navItem'][.='Accounts Payable Controls']").Click();
new SeleniumControl(sDriver,"Manage Cash Accounts", "xpath","//div[@class='navItem'][.='Manage Cash Accounts']").Click();


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
				Function.CurrentComponent = "APMCASH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCASH] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl APMCASH_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMCASH_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCASH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCASH] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMCASH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APMCASH_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCASH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCASH] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMCASH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMCASH_MainForm);
IWebElement formBttn = APMCASH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMCASH_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMCASH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCASH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCASH] Performing VerifyExists on CashAccountDesc...", Logger.MessageType.INF);
				SeleniumControl APMCASH_CashAccountDesc = new SeleniumControl( sDriver, "CashAccountDesc", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CASH_ACCTS_DESC']");
				Function.AssertEqual(true,APMCASH_CashAccountDesc.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCASH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCASH] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMCASH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMCASH_MainForm);
IWebElement formBttn = APMCASH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
