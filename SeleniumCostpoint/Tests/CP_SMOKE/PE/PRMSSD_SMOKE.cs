 
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
    public class PRMSSD_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Payroll", "xpath","//div[@class='deptItem'][.='Payroll']").Click();
new SeleniumControl(sDriver,"State Taxes", "xpath","//div[@class='navItem'][.='State Taxes']").Click();
new SeleniumControl(sDriver,"Manage State Standard Deductions", "xpath","//div[@class='navItem'][.='Manage State Standard Deductions']").Click();


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
				Function.CurrentComponent = "PRMSSD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSSD] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMSSD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMSSD_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSSD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSSD] Performing VerifyExists on State...", Logger.MessageType.INF);
				SeleniumControl PRMSSD_State = new SeleniumControl( sDriver, "State", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='STATE_CD']");
				Function.AssertEqual(true,PRMSSD_State.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSSD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSSD] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMSSD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMSSD_MainForm);
IWebElement formBttn = PRMSSD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMSSD_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMSSD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSSD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSSD] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl PRMSSD_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMSSD_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("State Standard Deduction Table Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSSD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSSD] Performing VerifyExists on StateStandardDeductionTableLink...", Logger.MessageType.INF);
				SeleniumControl PRMSSD_StateStandardDeductionTableLink = new SeleniumControl( sDriver, "StateStandardDeductionTableLink", "ID", "lnk_3938_PRMSSD_STATESTDDED_HDR");
				Function.AssertEqual(true,PRMSSD_StateStandardDeductionTableLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSSD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSSD] Performing Click on StateStandardDeductionTableLink...", Logger.MessageType.INF);
				SeleniumControl PRMSSD_StateStandardDeductionTableLink = new SeleniumControl( sDriver, "StateStandardDeductionTableLink", "ID", "lnk_3938_PRMSSD_STATESTDDED_HDR");
				Function.WaitControlDisplayed(PRMSSD_StateStandardDeductionTableLink);
PRMSSD_StateStandardDeductionTableLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSSD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSSD] Performing VerifyExists on StateStandardDeductionTableForm...", Logger.MessageType.INF);
				SeleniumControl PRMSSD_StateStandardDeductionTableForm = new SeleniumControl( sDriver, "StateStandardDeductionTableForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSSD_STATESTDDED_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMSSD_StateStandardDeductionTableForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSSD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSSD] Performing VerifyExist on StateStandardDeductionTableTable...", Logger.MessageType.INF);
				SeleniumControl PRMSSD_StateStandardDeductionTableTable = new SeleniumControl( sDriver, "StateStandardDeductionTableTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSSD_STATESTDDED_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMSSD_StateStandardDeductionTableTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSSD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSSD] Performing Close on StateStandardDeductionTableForm...", Logger.MessageType.INF);
				SeleniumControl PRMSSD_StateStandardDeductionTableForm = new SeleniumControl( sDriver, "StateStandardDeductionTableForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSSD_STATESTDDED_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMSSD_StateStandardDeductionTableForm);
IWebElement formBttn = PRMSSD_StateStandardDeductionTableForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PRMSSD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSSD] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMSSD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMSSD_MainForm);
IWebElement formBttn = PRMSSD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

