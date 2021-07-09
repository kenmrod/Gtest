 
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
    public class GLQINQ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"General Ledger Reports/Inquiries", "xpath","//div[@class='navItem'][.='General Ledger Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View General Ledger Activity", "xpath","//div[@class='navItem'][.='View General Ledger Activity']").Click();


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
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLQINQ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on FiscalYear...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_FiscalYear = new SeleniumControl( sDriver, "FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,GLQINQ_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TableWindow Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_FSSUM_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQINQ_TableWindowForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExist on TableWindowTable...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindowTable = new SeleniumControl( sDriver, "TableWindowTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_FSSUM_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQINQ_TableWindowTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing ClickButton on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_FSSUM_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQINQ_TableWindowForm);
IWebElement formBttn = GLQINQ_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQINQ_TableWindowForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQINQ_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_FiscalYear = new SeleniumControl( sDriver, "TableWindow_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_FSSUM_DTL_']/ancestor::form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,GLQINQ_TableWindow_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing Set on FiscalYear...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_FiscalYear = new SeleniumControl( sDriver, "FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				GLQINQ_FiscalYear.Click();
GLQINQ_FiscalYear.SendKeys("2030", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
GLQINQ_FiscalYear.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Execute.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TableWindow Period Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_PeriodsLink...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_PeriodsLink = new SeleniumControl( sDriver, "TableWindow_PeriodsLink", "ID", "lnk_15059_GLQINQ_FSSUM_DTL");
				Function.AssertEqual(true,GLQINQ_TableWindow_PeriodsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing ClickButton on TableWindowForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindowForm = new SeleniumControl( sDriver, "TableWindowForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_FSSUM_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQINQ_TableWindowForm);
IWebElement formBttn = GLQINQ_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? GLQINQ_TableWindowForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
GLQINQ_TableWindowForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Account']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'begins with']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='00212']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("00212");}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SetSearchCriterion]" , ex.Message));
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
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing Click on TableWindow_PeriodsLink...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_PeriodsLink = new SeleniumControl( sDriver, "TableWindow_PeriodsLink", "ID", "lnk_15059_GLQINQ_FSSUM_DTL");
				Function.WaitControlDisplayed(GLQINQ_TableWindow_PeriodsLink);
GLQINQ_TableWindow_PeriodsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_PeriodsForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_PeriodsForm = new SeleniumControl( sDriver, "TableWindow_PeriodsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLPOSTSUM_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQINQ_TableWindow_PeriodsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Periods_TotalHours...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Periods_TotalHours = new SeleniumControl( sDriver, "TableWindow_Periods_TotalHours", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLPOSTSUM_HDR_']/ancestor::form[1]/descendant::*[@id='YTD_RUNHRS']");
				Function.AssertEqual(true,GLQINQ_TableWindow_Periods_TotalHours.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Periods_PeriodsForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Periods_PeriodsForm = new SeleniumControl( sDriver, "TableWindow_Periods_PeriodsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLPOSTSUM_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQINQ_TableWindow_Periods_PeriodsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExist on TableWindow_Periods_PeriodsTable...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Periods_PeriodsTable = new SeleniumControl( sDriver, "TableWindow_Periods_PeriodsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLPOSTSUM_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQINQ_TableWindow_Periods_PeriodsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing ClickButton on TableWindow_Periods_PeriodsForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Periods_PeriodsForm = new SeleniumControl( sDriver, "TableWindow_Periods_PeriodsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLPOSTSUM_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQINQ_TableWindow_Periods_PeriodsForm);
IWebElement formBttn = GLQINQ_TableWindow_Periods_PeriodsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQINQ_TableWindow_Periods_PeriodsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQINQ_TableWindow_Periods_PeriodsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Periods_Periods_Period...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Periods_Periods_Period = new SeleniumControl( sDriver, "TableWindow_Periods_Periods_Period", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLPOSTSUM_']/ancestor::form[1]/descendant::*[@id='PD_NO']");
				Function.AssertEqual(true,GLQINQ_TableWindow_Periods_Periods_Period.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Periods_Periods_PostingsLink...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Periods_Periods_PostingsLink = new SeleniumControl( sDriver, "TableWindow_Periods_Periods_PostingsLink", "ID", "lnk_15061_GLQINQ_GLPOSTSUM");
				Function.AssertEqual(true,GLQINQ_TableWindow_Periods_Periods_PostingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Periods_Periods_TransactionsLink...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Periods_Periods_TransactionsLink = new SeleniumControl( sDriver, "TableWindow_Periods_Periods_TransactionsLink", "ID", "lnk_15062_GLQINQ_GLPOSTSUM");
				Function.AssertEqual(true,GLQINQ_TableWindow_Periods_Periods_TransactionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing Close on TableWindow_PeriodsForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_PeriodsForm = new SeleniumControl( sDriver, "TableWindow_PeriodsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLPOSTSUM_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQINQ_TableWindow_PeriodsForm);
IWebElement formBttn = GLQINQ_TableWindow_PeriodsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TableWindow Transactions Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_TransactionsLink...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_TransactionsLink = new SeleniumControl( sDriver, "TableWindow_TransactionsLink", "ID", "lnk_5800_GLQINQ_FSSUM_DTL");
				Function.AssertEqual(true,GLQINQ_TableWindow_TransactionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing Click on TableWindow_TransactionsLink...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_TransactionsLink = new SeleniumControl( sDriver, "TableWindow_TransactionsLink", "ID", "lnk_5800_GLQINQ_FSSUM_DTL");
				Function.WaitControlDisplayed(GLQINQ_TableWindow_TransactionsLink);
GLQINQ_TableWindow_TransactionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_TransactionsForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_TransactionsForm = new SeleniumControl( sDriver, "TableWindow_TransactionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_TRANS_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQINQ_TableWindow_TransactionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Transactions_TransactionTotal...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Transactions_TransactionTotal = new SeleniumControl( sDriver, "TableWindow_Transactions_TransactionTotal", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_TRANS_HDR_']/ancestor::form[1]/descendant::*[@id='TOTAL_AMOUNT']");
				Function.AssertEqual(true,GLQINQ_TableWindow_Transactions_TransactionTotal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Transactions_TransactionsForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Transactions_TransactionsForm = new SeleniumControl( sDriver, "TableWindow_Transactions_TransactionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_TRANS_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQINQ_TableWindow_Transactions_TransactionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExist on TableWindow_Transactions_TransactionsTable...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Transactions_TransactionsTable = new SeleniumControl( sDriver, "TableWindow_Transactions_TransactionsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_TRANS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQINQ_TableWindow_Transactions_TransactionsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing ClickButton on TableWindow_Transactions_TransactionsForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Transactions_TransactionsForm = new SeleniumControl( sDriver, "TableWindow_Transactions_TransactionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_TRANS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQINQ_TableWindow_Transactions_TransactionsForm);
IWebElement formBttn = GLQINQ_TableWindow_Transactions_TransactionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQINQ_TableWindow_Transactions_TransactionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQINQ_TableWindow_Transactions_TransactionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Transactions_Transactions_TransactionsTab...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Transactions_Transactions_TransactionsTab = new SeleniumControl( sDriver, "TableWindow_Transactions_Transactions_TransactionsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_TRANS_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,GLQINQ_TableWindow_Transactions_Transactions_TransactionsTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing Select on TableWindow_Transactions_Transactions_TransactionsTab...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Transactions_Transactions_TransactionsTab = new SeleniumControl( sDriver, "TableWindow_Transactions_Transactions_TransactionsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_TRANS_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(GLQINQ_TableWindow_Transactions_Transactions_TransactionsTab);
IWebElement mTab = GLQINQ_TableWindow_Transactions_Transactions_TransactionsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Transaction Detail").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Transactions_Transactions_TransactionDetail_Period...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Transactions_Transactions_TransactionDetail_Period = new SeleniumControl( sDriver, "TableWindow_Transactions_Transactions_TransactionDetail_Period", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_TRANS_']/ancestor::form[1]/descendant::*[@id='PD_NO']");
				Function.AssertEqual(true,GLQINQ_TableWindow_Transactions_Transactions_TransactionDetail_Period.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing Select on TableWindow_Transactions_Transactions_TransactionsTab...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Transactions_Transactions_TransactionsTab = new SeleniumControl( sDriver, "TableWindow_Transactions_Transactions_TransactionsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_TRANS_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(GLQINQ_TableWindow_Transactions_Transactions_TransactionsTab);
IWebElement mTab = GLQINQ_TableWindow_Transactions_Transactions_TransactionsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Comments").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Transactions_Transactions_Comments_CommentsNotes...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Transactions_Transactions_Comments_CommentsNotes = new SeleniumControl( sDriver, "TableWindow_Transactions_Transactions_Comments_CommentsNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_TRANS_']/ancestor::form[1]/descendant::*[@id='COMMENTS_NT']");
				Function.AssertEqual(true,GLQINQ_TableWindow_Transactions_Transactions_Comments_CommentsNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing Close on TableWindow_TransactionsForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_TransactionsForm = new SeleniumControl( sDriver, "TableWindow_TransactionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_TRANS_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQINQ_TableWindow_TransactionsForm);
IWebElement formBttn = GLQINQ_TableWindow_TransactionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TableWindow Labor Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_LaborLink...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_LaborLink = new SeleniumControl( sDriver, "TableWindow_LaborLink", "ID", "lnk_5801_GLQINQ_FSSUM_DTL");
				Function.AssertEqual(true,GLQINQ_TableWindow_LaborLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing Click on TableWindow_LaborLink...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_LaborLink = new SeleniumControl( sDriver, "TableWindow_LaborLink", "ID", "lnk_5801_GLQINQ_FSSUM_DTL");
				Function.WaitControlDisplayed(GLQINQ_TableWindow_LaborLink);
GLQINQ_TableWindow_LaborLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_LaborForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_LaborForm = new SeleniumControl( sDriver, "TableWindow_LaborForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_LBRDETAIL_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQINQ_TableWindow_LaborForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Labor_TotalHours...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Labor_TotalHours = new SeleniumControl( sDriver, "TableWindow_Labor_TotalHours", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_LBRDETAIL_HDR_']/ancestor::form[1]/descendant::*[@id='TOT_HRS']");
				Function.AssertEqual(true,GLQINQ_TableWindow_Labor_TotalHours.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Labor_LaborForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Labor_LaborForm = new SeleniumControl( sDriver, "TableWindow_Labor_LaborForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_LBRDETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQINQ_TableWindow_Labor_LaborForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExist on TableWindow_Labor_LaborTable...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Labor_LaborTable = new SeleniumControl( sDriver, "TableWindow_Labor_LaborTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_LBRDETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQINQ_TableWindow_Labor_LaborTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing ClickButton on TableWindow_Labor_LaborForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Labor_LaborForm = new SeleniumControl( sDriver, "TableWindow_Labor_LaborForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_LBRDETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQINQ_TableWindow_Labor_LaborForm);
IWebElement formBttn = GLQINQ_TableWindow_Labor_LaborForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQINQ_TableWindow_Labor_LaborForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQINQ_TableWindow_Labor_LaborForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Labor_LaborTab...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Labor_LaborTab = new SeleniumControl( sDriver, "TableWindow_Labor_LaborTab", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_LBRDETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,GLQINQ_TableWindow_Labor_LaborTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing Select on TableWindow_Labor_LaborTab...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Labor_LaborTab = new SeleniumControl( sDriver, "TableWindow_Labor_LaborTab", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_LBRDETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(GLQINQ_TableWindow_Labor_LaborTab);
IWebElement mTab = GLQINQ_TableWindow_Labor_LaborTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Transaction Detail").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Labor_Labor_TransactionDetail_Period...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Labor_Labor_TransactionDetail_Period = new SeleniumControl( sDriver, "TableWindow_Labor_Labor_TransactionDetail_Period", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_LBRDETAIL_']/ancestor::form[1]/descendant::*[@id='PD_NO']");
				Function.AssertEqual(true,GLQINQ_TableWindow_Labor_Labor_TransactionDetail_Period.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing Select on TableWindow_Labor_LaborTab...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Labor_LaborTab = new SeleniumControl( sDriver, "TableWindow_Labor_LaborTab", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_LBRDETAIL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(GLQINQ_TableWindow_Labor_LaborTab);
IWebElement mTab = GLQINQ_TableWindow_Labor_LaborTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Comments").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing VerifyExists on TableWindow_Labor_Labor_Comments_CommentsNotes...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_Labor_Labor_Comments_CommentsNotes = new SeleniumControl( sDriver, "TableWindow_Labor_Labor_Comments_CommentsNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_LBRDETAIL_']/ancestor::form[1]/descendant::*[@id='COMMENTS_NT']");
				Function.AssertEqual(true,GLQINQ_TableWindow_Labor_Labor_Comments_CommentsNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing Close on TableWindow_LaborForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_TableWindow_LaborForm = new SeleniumControl( sDriver, "TableWindow_LaborForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQINQ_GLDETL_LBRDETAIL_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQINQ_TableWindow_LaborForm);
IWebElement formBttn = GLQINQ_TableWindow_LaborForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "GLQINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQINQ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLQINQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLQINQ_MainForm);
IWebElement formBttn = GLQINQ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

