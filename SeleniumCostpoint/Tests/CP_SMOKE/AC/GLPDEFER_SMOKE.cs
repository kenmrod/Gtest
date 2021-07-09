 
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
    public class GLPDEFER_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"General Ledger", "xpath","//div[@class='deptItem'][.='General Ledger']").Click();
new SeleniumControl(sDriver,"General Ledger Utilities", "xpath","//div[@class='navItem'][.='General Ledger Utilities']").Click();
new SeleniumControl(sDriver,"Defer Unposted Transactions", "xpath","//div[@class='navItem'][.='Defer Unposted Transactions']").Click();


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
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLPDEFER_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,GLPDEFER_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLPDEFER_MainForm);
IWebElement formBttn = GLPDEFER_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? GLPDEFER_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
GLPDEFER_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLPDEFER_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("AP Voucher  Number  Non-Contiguous Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExists on APVoucherNumberNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_APVoucherNumberNonContiguousLink = new SeleniumControl( sDriver, "APVoucherNumberNonContiguousLink", "ID", "lnk_3784_GLPDEFER_PARAM");
				Function.AssertEqual(true,GLPDEFER_APVoucherNumberNonContiguousLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing Click on APVoucherNumberNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_APVoucherNumberNonContiguousLink = new SeleniumControl( sDriver, "APVoucherNumberNonContiguousLink", "ID", "lnk_3784_GLPDEFER_PARAM");
				Function.WaitControlDisplayed(GLPDEFER_APVoucherNumberNonContiguousLink);
GLPDEFER_APVoucherNumberNonContiguousLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExists on APVoucherNumberNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_APVoucherNumberNonContiguousForm = new SeleniumControl( sDriver, "APVoucherNumberNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPDEFER_NCRAPVCHRNO_']/ancestor::form[1]");
				Function.AssertEqual(true,GLPDEFER_APVoucherNumberNonContiguousForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExist on APVoucherNumberNonContiguousFormTable...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_APVoucherNumberNonContiguousFormTable = new SeleniumControl( sDriver, "APVoucherNumberNonContiguousFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPDEFER_NCRAPVCHRNO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLPDEFER_APVoucherNumberNonContiguousFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing Close on APVoucherNumberNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_APVoucherNumberNonContiguousForm = new SeleniumControl( sDriver, "APVoucherNumberNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPDEFER_NCRAPVCHRNO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLPDEFER_APVoucherNumberNonContiguousForm);
IWebElement formBttn = GLPDEFER_APVoucherNumberNonContiguousForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PO Voucher Number Non-Contiguous Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExists on POVoucherNumberNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_POVoucherNumberNonContiguousLink = new SeleniumControl( sDriver, "POVoucherNumberNonContiguousLink", "ID", "lnk_3785_GLPDEFER_PARAM");
				Function.AssertEqual(true,GLPDEFER_POVoucherNumberNonContiguousLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing Click on POVoucherNumberNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_POVoucherNumberNonContiguousLink = new SeleniumControl( sDriver, "POVoucherNumberNonContiguousLink", "ID", "lnk_3785_GLPDEFER_PARAM");
				Function.WaitControlDisplayed(GLPDEFER_POVoucherNumberNonContiguousLink);
GLPDEFER_POVoucherNumberNonContiguousLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExists on POVoucherNumberNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_POVoucherNumberNonContiguousForm = new SeleniumControl( sDriver, "POVoucherNumberNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPDEFER_NCRPOVCHRNO_']/ancestor::form[1]");
				Function.AssertEqual(true,GLPDEFER_POVoucherNumberNonContiguousForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExist on POVoucherNumberNonContiguousFormTable...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_POVoucherNumberNonContiguousFormTable = new SeleniumControl( sDriver, "POVoucherNumberNonContiguousFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPDEFER_NCRPOVCHRNO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLPDEFER_POVoucherNumberNonContiguousFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing Close on POVoucherNumberNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_POVoucherNumberNonContiguousForm = new SeleniumControl( sDriver, "POVoucherNumberNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPDEFER_NCRPOVCHRNO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLPDEFER_POVoucherNumberNonContiguousForm);
IWebElement formBttn = GLPDEFER_POVoucherNumberNonContiguousForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("JE Number Non-Contiguous Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExists on JENumberNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_JENumberNonContiguousLink = new SeleniumControl( sDriver, "JENumberNonContiguousLink", "ID", "lnk_3786_GLPDEFER_PARAM");
				Function.AssertEqual(true,GLPDEFER_JENumberNonContiguousLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing Click on JENumberNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_JENumberNonContiguousLink = new SeleniumControl( sDriver, "JENumberNonContiguousLink", "ID", "lnk_3786_GLPDEFER_PARAM");
				Function.WaitControlDisplayed(GLPDEFER_JENumberNonContiguousLink);
GLPDEFER_JENumberNonContiguousLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExists on JEVoucherNumberNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_JEVoucherNumberNonContiguousForm = new SeleniumControl( sDriver, "JEVoucherNumberNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPDEFER_NCRJENO_']/ancestor::form[1]");
				Function.AssertEqual(true,GLPDEFER_JEVoucherNumberNonContiguousForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExist on JEVoucherNumberNonContiguousFormTable...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_JEVoucherNumberNonContiguousFormTable = new SeleniumControl( sDriver, "JEVoucherNumberNonContiguousFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPDEFER_NCRJENO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLPDEFER_JEVoucherNumberNonContiguousFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing Close on JEVoucherNumberNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_JEVoucherNumberNonContiguousForm = new SeleniumControl( sDriver, "JEVoucherNumberNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPDEFER_NCRJENO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLPDEFER_JEVoucherNumberNonContiguousForm);
IWebElement formBttn = GLPDEFER_JEVoucherNumberNonContiguousForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Timesheet Date Non-Contiguous Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExists on TimesheetDateNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_TimesheetDateNonContiguousLink = new SeleniumControl( sDriver, "TimesheetDateNonContiguousLink", "ID", "lnk_3787_GLPDEFER_PARAM");
				Function.AssertEqual(true,GLPDEFER_TimesheetDateNonContiguousLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing Click on TimesheetDateNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_TimesheetDateNonContiguousLink = new SeleniumControl( sDriver, "TimesheetDateNonContiguousLink", "ID", "lnk_3787_GLPDEFER_PARAM");
				Function.WaitControlDisplayed(GLPDEFER_TimesheetDateNonContiguousLink);
GLPDEFER_TimesheetDateNonContiguousLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExists on TimesheetDateNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_TimesheetDateNonContiguousForm = new SeleniumControl( sDriver, "TimesheetDateNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPDEFER_NCRTSDT_']/ancestor::form[1]");
				Function.AssertEqual(true,GLPDEFER_TimesheetDateNonContiguousForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing VerifyExist on TimesheetDateNonContiguousFormTable...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_TimesheetDateNonContiguousFormTable = new SeleniumControl( sDriver, "TimesheetDateNonContiguousFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPDEFER_NCRTSDT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLPDEFER_TimesheetDateNonContiguousFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing Close on TimesheetDateNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_TimesheetDateNonContiguousForm = new SeleniumControl( sDriver, "TimesheetDateNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPDEFER_NCRTSDT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLPDEFER_TimesheetDateNonContiguousForm);
IWebElement formBttn = GLPDEFER_TimesheetDateNonContiguousForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "GLPDEFER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPDEFER] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLPDEFER_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLPDEFER_MainForm);
IWebElement formBttn = GLPDEFER_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

