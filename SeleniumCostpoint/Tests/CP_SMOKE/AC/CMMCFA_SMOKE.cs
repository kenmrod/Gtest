 
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
    public class CMMCFA_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Cash Management Controls", "xpath","//div[@class='navItem'][.='Cash Management Controls']").Click();
new SeleniumControl(sDriver,"Manage Cash Forecast Accounts", "xpath","//div[@class='navItem'][.='Manage Cash Forecast Accounts']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Find...", Logger.MessageType.INF);
				SeleniumControl Query_Find = new SeleniumControl( sDriver, "Find", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Find);
if (Query_Find.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Find.Click(5,5);
else Query_Find.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
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
				Function.CurrentComponent = "CMMCFA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCFA] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl CMMCFA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,CMMCFA_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCFA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCFA] Performing VerifyExists on LinkCashForecastTemplate...", Logger.MessageType.INF);
				SeleniumControl CMMCFA_LinkCashForecastTemplate = new SeleniumControl( sDriver, "LinkCashForecastTemplate", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TMPLT_CD']");
				Function.AssertEqual(true,CMMCFA_LinkCashForecastTemplate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCFA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCFA] Performing VerifyExists on CashForecastAccountsLink...", Logger.MessageType.INF);
				SeleniumControl CMMCFA_CashForecastAccountsLink = new SeleniumControl( sDriver, "CashForecastAccountsLink", "ID", "lnk_3630_CMMCFA_CFTTMPLT_HDR");
				Function.AssertEqual(true,CMMCFA_CashForecastAccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCFA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCFA] Performing VerifyExists on CashForecastAccountsForm...", Logger.MessageType.INF);
				SeleniumControl CMMCFA_CashForecastAccountsForm = new SeleniumControl( sDriver, "CashForecastAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CMMCFA_CFTCASHACCTS_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,CMMCFA_CashForecastAccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCFA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCFA] Performing VerifyExist on CashForecastAccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl CMMCFA_CashForecastAccountsFormTable = new SeleniumControl( sDriver, "CashForecastAccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CMMCFA_CFTCASHACCTS_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,CMMCFA_CashForecastAccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCFA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCFA] Performing VerifyExists on CashForecastAccounts_Ok...", Logger.MessageType.INF);
				SeleniumControl CMMCFA_CashForecastAccounts_Ok = new SeleniumControl( sDriver, "CashForecastAccounts_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__CMMCFA_CFTCASHACCTS_CHILD_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,CMMCFA_CashForecastAccounts_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CMMCFA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CMMCFA] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl CMMCFA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(CMMCFA_MainForm);
IWebElement formBttn = CMMCFA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

