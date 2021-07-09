 
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
    public class GLMSTMT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Cash Management", "xpath","//div[@class='deptItem'][.='Cash Management']").Click();
new SeleniumControl(sDriver,"Bank Account Management", "xpath","//div[@class='navItem'][.='Bank Account Management']").Click();
new SeleniumControl(sDriver,"Manage Bank Statement Information", "xpath","//div[@class='navItem'][.='Manage Bank Statement Information']").Click();


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
				Function.CurrentComponent = "GLMSTMT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSTMT] Performing VerifyExists on BankAbbr...", Logger.MessageType.INF);
				SeleniumControl GLMSTMT_BankAbbr = new SeleniumControl( sDriver, "BankAbbr", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BANK_ACCT_ABBRV']");
				Function.AssertEqual(true,GLMSTMT_BankAbbr.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSTMT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSTMT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMSTMT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMSTMT_MainForm);
IWebElement formBttn = GLMSTMT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? GLMSTMT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
GLMSTMT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSTMT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSTMT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMSTMT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMSTMT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Statement and Timing Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSTMT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSTMT] Performing VerifyExist on StatementAndTimingInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMSTMT_StatementAndTimingInfoFormTable = new SeleniumControl( sDriver, "StatementAndTimingInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSTMT_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMSTMT_StatementAndTimingInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSTMT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSTMT] Performing ClickButton on StatementAndTimingInfoForm...", Logger.MessageType.INF);
				SeleniumControl GLMSTMT_StatementAndTimingInfoForm = new SeleniumControl( sDriver, "StatementAndTimingInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSTMT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMSTMT_StatementAndTimingInfoForm);
IWebElement formBttn = GLMSTMT_StatementAndTimingInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMSTMT_StatementAndTimingInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMSTMT_StatementAndTimingInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSTMT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSTMT] Performing VerifyExists on StatementAndTimingInfo_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl GLMSTMT_StatementAndTimingInfo_FiscalYear = new SeleniumControl( sDriver, "StatementAndTimingInfo_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSTMT_DETL_']/ancestor::form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,GLMSTMT_StatementAndTimingInfo_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Bank Upload");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSTMT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSTMT] Performing Click on StatementAndTimingInfo_BankStatementDetailsLink...", Logger.MessageType.INF);
				SeleniumControl GLMSTMT_StatementAndTimingInfo_BankStatementDetailsLink = new SeleniumControl( sDriver, "StatementAndTimingInfo_BankStatementDetailsLink", "ID", "lnk_4197_GLMSTMT_DETL");
				Function.WaitControlDisplayed(GLMSTMT_StatementAndTimingInfo_BankStatementDetailsLink);
GLMSTMT_StatementAndTimingInfo_BankStatementDetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSTMT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSTMT] Performing VerifyExists on StatementAndTimingInfo_BankUploadTotals_BeginningBalance...", Logger.MessageType.INF);
				SeleniumControl GLMSTMT_StatementAndTimingInfo_BankUploadTotals_BeginningBalance = new SeleniumControl( sDriver, "StatementAndTimingInfo_BankUploadTotals_BeginningBalance", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSTMT_BANK_TOTALS_']/ancestor::form[1]/descendant::*[@id='BEGINING_BAL']");
				Function.AssertEqual(true,GLMSTMT_StatementAndTimingInfo_BankUploadTotals_BeginningBalance.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSTMT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSTMT] Performing VerifyExist on StatementAndTimingInfo_BankUploadTotals_BankStatementDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMSTMT_StatementAndTimingInfo_BankUploadTotals_BankStatementDetailFormTable = new SeleniumControl( sDriver, "StatementAndTimingInfo_BankUploadTotals_BankStatementDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSTMT_BANK_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMSTMT_StatementAndTimingInfo_BankUploadTotals_BankStatementDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSTMT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSTMT] Performing ClickButton on StatementAndTimingInfo_BankUploadTotals_BankStatementDetailForm...", Logger.MessageType.INF);
				SeleniumControl GLMSTMT_StatementAndTimingInfo_BankUploadTotals_BankStatementDetailForm = new SeleniumControl( sDriver, "StatementAndTimingInfo_BankUploadTotals_BankStatementDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSTMT_BANK_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMSTMT_StatementAndTimingInfo_BankUploadTotals_BankStatementDetailForm);
IWebElement formBttn = GLMSTMT_StatementAndTimingInfo_BankUploadTotals_BankStatementDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMSTMT_StatementAndTimingInfo_BankUploadTotals_BankStatementDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMSTMT_StatementAndTimingInfo_BankUploadTotals_BankStatementDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSTMT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSTMT] Performing VerifyExists on StatementAndTimingInfo_BankUploadTotals_BankStatementDetail_TransDate...", Logger.MessageType.INF);
				SeleniumControl GLMSTMT_StatementAndTimingInfo_BankUploadTotals_BankStatementDetail_TransDate = new SeleniumControl( sDriver, "StatementAndTimingInfo_BankUploadTotals_BankStatementDetail_TransDate", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSTMT_BANK_DETL_']/ancestor::form[1]/descendant::*[@id='TRN_DT']");
				Function.AssertEqual(true,GLMSTMT_StatementAndTimingInfo_BankUploadTotals_BankStatementDetail_TransDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSTMT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSTMT] Performing Close on StatementAndTimingInfo_BankUploadTotalsForm...", Logger.MessageType.INF);
				SeleniumControl GLMSTMT_StatementAndTimingInfo_BankUploadTotalsForm = new SeleniumControl( sDriver, "StatementAndTimingInfo_BankUploadTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSTMT_BANK_TOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMSTMT_StatementAndTimingInfo_BankUploadTotalsForm);
IWebElement formBttn = GLMSTMT_StatementAndTimingInfo_BankUploadTotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "GLMSTMT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSTMT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMSTMT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMSTMT_MainForm);
IWebElement formBttn = GLMSTMT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

