 
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
    public class AOMESSST_SMOKE : SeleniumTestScript
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

				this.ScriptLogger.WriteLine("[CP7Main] Performing Set on SearchApplications...", Logger.MessageType.INF);
				SeleniumControl CP7Main_SearchApplications = new SeleniumControl( sDriver, "SearchApplications", "ID", "appFltrFld");
				CP7Main_SearchApplications.Click();
CP7Main_SearchApplications.SendKeys("AOMESSST", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
CP7Main_SearchApplications.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try
				{
				Function.SendKeys("Down");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SendKeys]" , ex.Message));
				}
								try
				{
				Function.SendKeys("Enter");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SendKeys]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSST] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,AOMESSST_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSST] Performing VerifyExists on State...", Logger.MessageType.INF);
				SeleniumControl AOMESSST_State = new SeleniumControl( sDriver, "State", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='STATE_CD']");
				Function.AssertEqual(true,AOMESSST_State.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSST] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMESSST_MainForm);
IWebElement formBttn = AOMESSST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? AOMESSST_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
AOMESSST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSST] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMESSST_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMESSST_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSST] Performing VerifyExists on FilingStatusForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSST_FilingStatusForm = new SeleniumControl( sDriver, "FilingStatusForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSST_ESSSTATETAXLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,AOMESSST_FilingStatusForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSST] Performing VerifyExist on FilingStatusFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMESSST_FilingStatusFormTable = new SeleniumControl( sDriver, "FilingStatusFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSST_ESSSTATETAXLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMESSST_FilingStatusFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSST] Performing ClickButton on FilingStatusForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSST_FilingStatusForm = new SeleniumControl( sDriver, "FilingStatusForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSST_ESSSTATETAXLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMESSST_FilingStatusForm);
IWebElement formBttn = AOMESSST_FilingStatusForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? AOMESSST_FilingStatusForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
AOMESSST_FilingStatusForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSST] Performing VerifyExists on FilingStatus_FilingStatus...", Logger.MessageType.INF);
				SeleniumControl AOMESSST_FilingStatus_FilingStatus = new SeleniumControl( sDriver, "FilingStatus_FilingStatus", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSST_ESSSTATETAXLN_CTW_']/ancestor::form[1]/descendant::*[@id='S_ST_FIL_STAT_CD']");
				Function.AssertEqual(true,AOMESSST_FilingStatus_FilingStatus.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSST] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMESSST_MainForm);
IWebElement formBttn = AOMESSST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

