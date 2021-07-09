 
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
    public class GLQBKINQ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Cash Management Reports/Inquiries", "xpath","//div[@class='navItem'][.='Cash Management Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Bank Reconciliation Summary", "xpath","//div[@class='navItem'][.='View Bank Reconciliation Summary']").Click();


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
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLQBKINQ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on SelectBankAccount_BankAbbr...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_SelectBankAccount_BankAbbr = new SeleniumControl( sDriver, "SelectBankAccount_BankAbbr", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BANK_ACCT_ABBRV']");
				Function.AssertEqual(true,GLQBKINQ_SelectBankAccount_BankAbbr.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Set on SelectBankAccount_BankAbbr...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_SelectBankAccount_BankAbbr = new SeleniumControl( sDriver, "SelectBankAccount_BankAbbr", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BANK_ACCT_ABBRV']");
				GLQBKINQ_SelectBankAccount_BankAbbr.Click();
GLQBKINQ_SelectBankAccount_BankAbbr.SendKeys("TEST", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
GLQBKINQ_SelectBankAccount_BankAbbr.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Set on SelectTiming_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_SelectTiming_FiscalYear = new SeleniumControl( sDriver, "SelectTiming_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				GLQBKINQ_SelectTiming_FiscalYear.Click();
GLQBKINQ_SelectTiming_FiscalYear.SendKeys("1961", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
GLQBKINQ_SelectTiming_FiscalYear.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Set on SelectTiming_Period...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_SelectTiming_Period = new SeleniumControl( sDriver, "SelectTiming_Period", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PD_NO']");
				GLQBKINQ_SelectTiming_Period.Click();
GLQBKINQ_SelectTiming_Period.SendKeys("1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
GLQBKINQ_SelectTiming_Period.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				this.ScriptLogger.WriteLine("CHILD FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_GLPeriodEndingDate...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_GLPeriodEndingDate = new SeleniumControl( sDriver, "ChildForm_GLPeriodEndingDate", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_HDR_']/ancestor::form[1]/descendant::*[@id='PD_END_DT']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_GLPeriodEndingDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm);
IWebElement formBttn = GLQBKINQ_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? GLQBKINQ_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
GLQBKINQ_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQBKINQ_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("C/R PER BOOKS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_CRPerBooksLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CRPerBooksLink = new SeleniumControl( sDriver, "ChildForm_CRPerBooksLink", "ID", "lnk_1005612_GLQBKINQ_BANKTRNHS_HDR");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_CRPerBooksLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Click on ChildForm_CRPerBooksLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CRPerBooksLink = new SeleniumControl( sDriver, "ChildForm_CRPerBooksLink", "ID", "lnk_1005612_GLQBKINQ_BANKTRNHS_HDR");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_CRPerBooksLink);
GLQBKINQ_ChildForm_CRPerBooksLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_CRPerBooksForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CRPerBooksForm = new SeleniumControl( sDriver, "ChildForm_CRPerBooksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_CASHRECPTS_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_CRPerBooksForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_CRPerBooks_TransTotalGLAmount...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CRPerBooks_TransTotalGLAmount = new SeleniumControl( sDriver, "ChildForm_CRPerBooks_TransTotalGLAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_CASHRECPTS_CHLD_']/ancestor::form[1]/descendant::*[@id='TOT_TRN_AMT']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_CRPerBooks_TransTotalGLAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExist on ChildForm_CRPerBooks_CashReceiptsPerBooksFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CRPerBooks_CashReceiptsPerBooksFormTable = new SeleniumControl( sDriver, "ChildForm_CRPerBooks_CashReceiptsPerBooksFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_CASHRECPTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_CRPerBooks_CashReceiptsPerBooksFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing ClickButton on ChildForm_CRPerBooks_CashReceiptsPerBooksForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CRPerBooks_CashReceiptsPerBooksForm = new SeleniumControl( sDriver, "ChildForm_CRPerBooks_CashReceiptsPerBooksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_CASHRECPTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_CRPerBooks_CashReceiptsPerBooksForm);
IWebElement formBttn = GLQBKINQ_ChildForm_CRPerBooks_CashReceiptsPerBooksForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQBKINQ_ChildForm_CRPerBooks_CashReceiptsPerBooksForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQBKINQ_ChildForm_CRPerBooks_CashReceiptsPerBooksForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_CRPerBooks_CashReceiptsPerBooksForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CRPerBooks_CashReceiptsPerBooksForm = new SeleniumControl( sDriver, "ChildForm_CRPerBooks_CashReceiptsPerBooksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_CASHRECPTS_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_CRPerBooks_CashReceiptsPerBooksForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_CRPerBooks_CashReceiptsPerBooks_TransType...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CRPerBooks_CashReceiptsPerBooks_TransType = new SeleniumControl( sDriver, "ChildForm_CRPerBooks_CashReceiptsPerBooks_TransType", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_CASHRECPTS_']/ancestor::form[1]/descendant::*[@id='S_BANK_TRN_TYPE']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_CRPerBooks_CashReceiptsPerBooks_TransType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Close on ChildForm_CRPerBooksForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CRPerBooksForm = new SeleniumControl( sDriver, "ChildForm_CRPerBooksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_CASHRECPTS_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_CRPerBooksForm);
IWebElement formBttn = GLQBKINQ_ChildForm_CRPerBooksForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("C/R PER BOOKS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_CDPerBooksLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CDPerBooksLink = new SeleniumControl( sDriver, "ChildForm_CDPerBooksLink", "ID", "lnk_1005614_GLQBKINQ_BANKTRNHS_HDR");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_CDPerBooksLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Click on ChildForm_CDPerBooksLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CDPerBooksLink = new SeleniumControl( sDriver, "ChildForm_CDPerBooksLink", "ID", "lnk_1005614_GLQBKINQ_BANKTRNHS_HDR");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_CDPerBooksLink);
GLQBKINQ_ChildForm_CDPerBooksLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_CDPerBooksForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CDPerBooksForm = new SeleniumControl( sDriver, "ChildForm_CDPerBooksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_CASHDISB_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_CDPerBooksForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_CDPerBooks_TransTotalGLAmount...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CDPerBooks_TransTotalGLAmount = new SeleniumControl( sDriver, "ChildForm_CDPerBooks_TransTotalGLAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_CASHDISB_CHLD_']/ancestor::form[1]/descendant::*[@id='TOT_TRN_AMT']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_CDPerBooks_TransTotalGLAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExist on ChildForm_CDPerBooks_CashDisbursementsPerBooksFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CDPerBooks_CashDisbursementsPerBooksFormTable = new SeleniumControl( sDriver, "ChildForm_CDPerBooks_CashDisbursementsPerBooksFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_CASHDISB_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_CDPerBooks_CashDisbursementsPerBooksFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing ClickButton on ChildForm_CDPerBooks_CashDisbursementsPerBooksForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CDPerBooks_CashDisbursementsPerBooksForm = new SeleniumControl( sDriver, "ChildForm_CDPerBooks_CashDisbursementsPerBooksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_CASHDISB_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_CDPerBooks_CashDisbursementsPerBooksForm);
IWebElement formBttn = GLQBKINQ_ChildForm_CDPerBooks_CashDisbursementsPerBooksForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQBKINQ_ChildForm_CDPerBooks_CashDisbursementsPerBooksForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQBKINQ_ChildForm_CDPerBooks_CashDisbursementsPerBooksForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_CDPerBooks_CashDisbursementsPerBooksForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CDPerBooks_CashDisbursementsPerBooksForm = new SeleniumControl( sDriver, "ChildForm_CDPerBooks_CashDisbursementsPerBooksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_CASHDISB_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_CDPerBooks_CashDisbursementsPerBooksForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_CDPerBooks_CashDisbursementsPerBooks_TransType...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CDPerBooks_CashDisbursementsPerBooks_TransType = new SeleniumControl( sDriver, "ChildForm_CDPerBooks_CashDisbursementsPerBooks_TransType", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_CASHDISB_']/ancestor::form[1]/descendant::*[@id='S_BANK_TRN_TYPE']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_CDPerBooks_CashDisbursementsPerBooks_TransType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Close on ChildForm_CDPerBooksForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_CDPerBooksForm = new SeleniumControl( sDriver, "ChildForm_CDPerBooksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_CASHDISB_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_CDPerBooksForm);
IWebElement formBttn = GLQBKINQ_ChildForm_CDPerBooksForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MANUAL ADJ");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_ManualAdjLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_ManualAdjLink = new SeleniumControl( sDriver, "ChildForm_ManualAdjLink", "ID", "lnk_1005616_GLQBKINQ_BANKTRNHS_HDR");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_ManualAdjLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Click on ChildForm_ManualAdjLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_ManualAdjLink = new SeleniumControl( sDriver, "ChildForm_ManualAdjLink", "ID", "lnk_1005616_GLQBKINQ_BANKTRNHS_HDR");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_ManualAdjLink);
GLQBKINQ_ChildForm_ManualAdjLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_ManualAdjForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_ManualAdjForm = new SeleniumControl( sDriver, "ChildForm_ManualAdjForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_MANADJ_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_ManualAdjForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_ManualAdj_TransTotalGLAmount...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_ManualAdj_TransTotalGLAmount = new SeleniumControl( sDriver, "ChildForm_ManualAdj_TransTotalGLAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_MANADJ_CHLD_']/ancestor::form[1]/descendant::*[@id='TOT_TRN_AMT']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_ManualAdj_TransTotalGLAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExist on ChildForm_ManualAdj_ManualAdjustmentsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_ManualAdj_ManualAdjustmentsFormTable = new SeleniumControl( sDriver, "ChildForm_ManualAdj_ManualAdjustmentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_MANADJ_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_ManualAdj_ManualAdjustmentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing ClickButton on ChildForm_ManualAdj_ManualAdjustmentsForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_ManualAdj_ManualAdjustmentsForm = new SeleniumControl( sDriver, "ChildForm_ManualAdj_ManualAdjustmentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_MANADJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_ManualAdj_ManualAdjustmentsForm);
IWebElement formBttn = GLQBKINQ_ChildForm_ManualAdj_ManualAdjustmentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQBKINQ_ChildForm_ManualAdj_ManualAdjustmentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQBKINQ_ChildForm_ManualAdj_ManualAdjustmentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_ManualAdj_ManualAdjustmentsForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_ManualAdj_ManualAdjustmentsForm = new SeleniumControl( sDriver, "ChildForm_ManualAdj_ManualAdjustmentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_MANADJ_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_ManualAdj_ManualAdjustmentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_ManualAdj_ManualAdjustments_TransType...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_ManualAdj_ManualAdjustments_TransType = new SeleniumControl( sDriver, "ChildForm_ManualAdj_ManualAdjustments_TransType", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_MANADJ_']/ancestor::form[1]/descendant::*[@id='S_BANK_TRN_TYPE']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_ManualAdj_ManualAdjustments_TransType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Close on ChildForm_ManualAdjForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_ManualAdjForm = new SeleniumControl( sDriver, "ChildForm_ManualAdjForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_MANADJ_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_ManualAdjForm);
IWebElement formBttn = GLQBKINQ_ChildForm_ManualAdjForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DEPOSITS IN TRANSIT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_DepositsInTransitLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_DepositsInTransitLink = new SeleniumControl( sDriver, "ChildForm_DepositsInTransitLink", "ID", "lnk_1005619_GLQBKINQ_BANKTRNHS_HDR");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_DepositsInTransitLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Click on ChildForm_DepositsInTransitLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_DepositsInTransitLink = new SeleniumControl( sDriver, "ChildForm_DepositsInTransitLink", "ID", "lnk_1005619_GLQBKINQ_BANKTRNHS_HDR");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_DepositsInTransitLink);
GLQBKINQ_ChildForm_DepositsInTransitLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_DepositsInTransitForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_DepositsInTransitForm = new SeleniumControl( sDriver, "ChildForm_DepositsInTransitForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_TRNDEP_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_DepositsInTransitForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_DepositsInTransit_FuncTotalReceiptAmount...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_DepositsInTransit_FuncTotalReceiptAmount = new SeleniumControl( sDriver, "ChildForm_DepositsInTransit_FuncTotalReceiptAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_TRNDEP_CHLD_']/ancestor::form[1]/descendant::*[@id='TOT_FUNC_AMT']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_DepositsInTransit_FuncTotalReceiptAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExist on ChildForm_DepositsInTransit_DepositsInTransitFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_DepositsInTransit_DepositsInTransitFormTable = new SeleniumControl( sDriver, "ChildForm_DepositsInTransit_DepositsInTransitFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_TRNDEP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_DepositsInTransit_DepositsInTransitFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing ClickButton on ChildForm_DepositsInTransit_DepositsInTransitForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_DepositsInTransit_DepositsInTransitForm = new SeleniumControl( sDriver, "ChildForm_DepositsInTransit_DepositsInTransitForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_TRNDEP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_DepositsInTransit_DepositsInTransitForm);
IWebElement formBttn = GLQBKINQ_ChildForm_DepositsInTransit_DepositsInTransitForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQBKINQ_ChildForm_DepositsInTransit_DepositsInTransitForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQBKINQ_ChildForm_DepositsInTransit_DepositsInTransitForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_DepositsInTransit_DepositsInTransitForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_DepositsInTransit_DepositsInTransitForm = new SeleniumControl( sDriver, "ChildForm_DepositsInTransit_DepositsInTransitForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_TRNDEP_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_DepositsInTransit_DepositsInTransitForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_DepositsInTransit_DepositsInTransit_TransType...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_DepositsInTransit_DepositsInTransit_TransType = new SeleniumControl( sDriver, "ChildForm_DepositsInTransit_DepositsInTransit_TransType", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_TRNDEP_']/ancestor::form[1]/descendant::*[@id='S_BANK_TRN_TYPE']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_DepositsInTransit_DepositsInTransit_TransType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Close on ChildForm_DepositsInTransitForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_DepositsInTransitForm = new SeleniumControl( sDriver, "ChildForm_DepositsInTransitForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_TRNDEP_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_DepositsInTransitForm);
IWebElement formBttn = GLQBKINQ_ChildForm_DepositsInTransitForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("OUTSTANDING CHKS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_OutstandingChksLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingChksLink = new SeleniumControl( sDriver, "ChildForm_OutstandingChksLink", "ID", "lnk_1005621_GLQBKINQ_BANKTRNHS_HDR");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_OutstandingChksLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Click on ChildForm_OutstandingChksLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingChksLink = new SeleniumControl( sDriver, "ChildForm_OutstandingChksLink", "ID", "lnk_1005621_GLQBKINQ_BANKTRNHS_HDR");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_OutstandingChksLink);
GLQBKINQ_ChildForm_OutstandingChksLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_OutstandingChksForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingChksForm = new SeleniumControl( sDriver, "ChildForm_OutstandingChksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_OUTCHK_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_OutstandingChksForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_OutstandingChks_FuncTotalCheckAmount...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingChks_FuncTotalCheckAmount = new SeleniumControl( sDriver, "ChildForm_OutstandingChks_FuncTotalCheckAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_OUTCHK_CHLD_']/ancestor::form[1]/descendant::*[@id='TOT_FUNC_AMT']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_OutstandingChks_FuncTotalCheckAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExist on ChildForm_OutstandingChks_OutstandingChecksFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingChks_OutstandingChecksFormTable = new SeleniumControl( sDriver, "ChildForm_OutstandingChks_OutstandingChecksFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_OUTCHK_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_OutstandingChks_OutstandingChecksFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing ClickButton on ChildForm_OutstandingChks_OutstandingChecksForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingChks_OutstandingChecksForm = new SeleniumControl( sDriver, "ChildForm_OutstandingChks_OutstandingChecksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_OUTCHK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_OutstandingChks_OutstandingChecksForm);
IWebElement formBttn = GLQBKINQ_ChildForm_OutstandingChks_OutstandingChecksForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQBKINQ_ChildForm_OutstandingChks_OutstandingChecksForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQBKINQ_ChildForm_OutstandingChks_OutstandingChecksForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_OutstandingChks_OutstandingChecksForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingChks_OutstandingChecksForm = new SeleniumControl( sDriver, "ChildForm_OutstandingChks_OutstandingChecksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_OUTCHK_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_OutstandingChks_OutstandingChecksForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_OutstandingChks_OutstandingChecks_TransType...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingChks_OutstandingChecks_TransType = new SeleniumControl( sDriver, "ChildForm_OutstandingChks_OutstandingChecks_TransType", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_OUTCHK_']/ancestor::form[1]/descendant::*[@id='S_BANK_TRN_TYPE']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_OutstandingChks_OutstandingChecks_TransType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Close on ChildForm_OutstandingChksForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingChksForm = new SeleniumControl( sDriver, "ChildForm_OutstandingChksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_OUTCHK_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_OutstandingChksForm);
IWebElement formBttn = GLQBKINQ_ChildForm_OutstandingChksForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("OUTSTANDING ADJ");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_OutstandingAdjLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingAdjLink = new SeleniumControl( sDriver, "ChildForm_OutstandingAdjLink", "ID", "lnk_1005623_GLQBKINQ_BANKTRNHS_HDR");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_OutstandingAdjLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Click on ChildForm_OutstandingAdjLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingAdjLink = new SeleniumControl( sDriver, "ChildForm_OutstandingAdjLink", "ID", "lnk_1005623_GLQBKINQ_BANKTRNHS_HDR");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_OutstandingAdjLink);
GLQBKINQ_ChildForm_OutstandingAdjLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_OutstandingAdjForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingAdjForm = new SeleniumControl( sDriver, "ChildForm_OutstandingAdjForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_OUTADJ_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_OutstandingAdjForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_OutstandingAdj_FuncTotalAdjustedAmount...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingAdj_FuncTotalAdjustedAmount = new SeleniumControl( sDriver, "ChildForm_OutstandingAdj_FuncTotalAdjustedAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_OUTADJ_CHLD_']/ancestor::form[1]/descendant::*[@id='TOT_FUNC_AMT']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_OutstandingAdj_FuncTotalAdjustedAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExist on ChildForm_OutstandingAdj_OutstandingManualAdjustmentsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingAdj_OutstandingManualAdjustmentsFormTable = new SeleniumControl( sDriver, "ChildForm_OutstandingAdj_OutstandingManualAdjustmentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_OUTADJ_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_OutstandingAdj_OutstandingManualAdjustmentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing ClickButton on ChildForm_OutstandingAdj_OutstandingManualAdjustmentsForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingAdj_OutstandingManualAdjustmentsForm = new SeleniumControl( sDriver, "ChildForm_OutstandingAdj_OutstandingManualAdjustmentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_OUTADJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_OutstandingAdj_OutstandingManualAdjustmentsForm);
IWebElement formBttn = GLQBKINQ_ChildForm_OutstandingAdj_OutstandingManualAdjustmentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQBKINQ_ChildForm_OutstandingAdj_OutstandingManualAdjustmentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQBKINQ_ChildForm_OutstandingAdj_OutstandingManualAdjustmentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_OutstandingAdj_OutstandingManualAdjustmentsForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingAdj_OutstandingManualAdjustmentsForm = new SeleniumControl( sDriver, "ChildForm_OutstandingAdj_OutstandingManualAdjustmentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_OUTADJ_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_OutstandingAdj_OutstandingManualAdjustmentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_OutstandingAdj_OutstandingManualAdjustments_TransType...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingAdj_OutstandingManualAdjustments_TransType = new SeleniumControl( sDriver, "ChildForm_OutstandingAdj_OutstandingManualAdjustments_TransType", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_OUTADJ_']/ancestor::form[1]/descendant::*[@id='S_BANK_TRN_TYPE']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_OutstandingAdj_OutstandingManualAdjustments_TransType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Close on ChildForm_OutstandingAdjForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_OutstandingAdjForm = new SeleniumControl( sDriver, "ChildForm_OutstandingAdjForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_OUTADJ_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_OutstandingAdjForm);
IWebElement formBttn = GLQBKINQ_ChildForm_OutstandingAdjForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("BANK STMT O/I");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_BankStmtOILink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_BankStmtOILink = new SeleniumControl( sDriver, "ChildForm_BankStmtOILink", "ID", "lnk_1005625_GLQBKINQ_BANKTRNHS_HDR");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_BankStmtOILink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Click on ChildForm_BankStmtOILink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_BankStmtOILink = new SeleniumControl( sDriver, "ChildForm_BankStmtOILink", "ID", "lnk_1005625_GLQBKINQ_BANKTRNHS_HDR");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_BankStmtOILink);
GLQBKINQ_ChildForm_BankStmtOILink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_BankStmtOIForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_BankStmtOIForm = new SeleniumControl( sDriver, "ChildForm_BankStmtOIForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BKSMT_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_BankStmtOIForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_BankStmtOI_TotalDepositAmt...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_BankStmtOI_TotalDepositAmt = new SeleniumControl( sDriver, "ChildForm_BankStmtOI_TotalDepositAmt", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BKSMT_CHLD_']/ancestor::form[1]/descendant::*[@id='TOT_DEPT_AMT']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_BankStmtOI_TotalDepositAmt.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExist on ChildForm_BankStmtOI_BankStatementOutstandingItemsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_BankStmtOI_BankStatementOutstandingItemsFormTable = new SeleniumControl( sDriver, "ChildForm_BankStmtOI_BankStatementOutstandingItemsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKACCTSTMTDTL_BKSMT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_BankStmtOI_BankStatementOutstandingItemsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing ClickButton on ChildForm_BankStmtOI_BankStatementOutstandingItemsForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_BankStmtOI_BankStatementOutstandingItemsForm = new SeleniumControl( sDriver, "ChildForm_BankStmtOI_BankStatementOutstandingItemsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKACCTSTMTDTL_BKSMT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_BankStmtOI_BankStatementOutstandingItemsForm);
IWebElement formBttn = GLQBKINQ_ChildForm_BankStmtOI_BankStatementOutstandingItemsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQBKINQ_ChildForm_BankStmtOI_BankStatementOutstandingItemsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQBKINQ_ChildForm_BankStmtOI_BankStatementOutstandingItemsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_BankStmtOI_BankStatementOutstandingItemsForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_BankStmtOI_BankStatementOutstandingItemsForm = new SeleniumControl( sDriver, "ChildForm_BankStmtOI_BankStatementOutstandingItemsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKACCTSTMTDTL_BKSMT_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_BankStmtOI_BankStatementOutstandingItemsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_BankStmtOI_BankStatementOutstandingItems_TransDate...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_BankStmtOI_BankStatementOutstandingItems_TransDate = new SeleniumControl( sDriver, "ChildForm_BankStmtOI_BankStatementOutstandingItems_TransDate", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKACCTSTMTDTL_BKSMT_']/ancestor::form[1]/descendant::*[@id='TRN_DT']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_BankStmtOI_BankStatementOutstandingItems_TransDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Close on ChildForm_BankStmtOIForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_BankStmtOIForm = new SeleniumControl( sDriver, "ChildForm_BankStmtOIForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BKSMT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_BankStmtOIForm);
IWebElement formBttn = GLQBKINQ_ChildForm_BankStmtOIForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("UNMATCHED CR");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedCRLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCRLink = new SeleniumControl( sDriver, "ChildForm_UnmatchedCRLink", "ID", "lnk_1005627_GLQBKINQ_BANKTRNHS_HDR");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedCRLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Click on ChildForm_UnmatchedCRLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCRLink = new SeleniumControl( sDriver, "ChildForm_UnmatchedCRLink", "ID", "lnk_1005627_GLQBKINQ_BANKTRNHS_HDR");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_UnmatchedCRLink);
GLQBKINQ_ChildForm_UnmatchedCRLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedCRForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCRForm = new SeleniumControl( sDriver, "ChildForm_UnmatchedCRForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_UNMREC_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedCRForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedCR_FuncTotalGLAmount...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCR_FuncTotalGLAmount = new SeleniumControl( sDriver, "ChildForm_UnmatchedCR_FuncTotalGLAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_UNMREC_CHLD_']/ancestor::form[1]/descendant::*[@id='TOT_FUNC_AMT']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedCR_FuncTotalGLAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExist on ChildForm_UnmatchedCR_UnmatchedCashReceiptsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCR_UnmatchedCashReceiptsFormTable = new SeleniumControl( sDriver, "ChildForm_UnmatchedCR_UnmatchedCashReceiptsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_UNMREC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedCR_UnmatchedCashReceiptsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing ClickButton on ChildForm_UnmatchedCR_UnmatchedCashReceiptsForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCR_UnmatchedCashReceiptsForm = new SeleniumControl( sDriver, "ChildForm_UnmatchedCR_UnmatchedCashReceiptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_UNMREC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_UnmatchedCR_UnmatchedCashReceiptsForm);
IWebElement formBttn = GLQBKINQ_ChildForm_UnmatchedCR_UnmatchedCashReceiptsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQBKINQ_ChildForm_UnmatchedCR_UnmatchedCashReceiptsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQBKINQ_ChildForm_UnmatchedCR_UnmatchedCashReceiptsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedCR_UnmatchedCashReceiptsForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCR_UnmatchedCashReceiptsForm = new SeleniumControl( sDriver, "ChildForm_UnmatchedCR_UnmatchedCashReceiptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_UNMREC_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedCR_UnmatchedCashReceiptsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedCR_UnmatchedCashReceipts_TransType...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCR_UnmatchedCashReceipts_TransType = new SeleniumControl( sDriver, "ChildForm_UnmatchedCR_UnmatchedCashReceipts_TransType", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_UNMREC_']/ancestor::form[1]/descendant::*[@id='S_BANK_TRN_TYPE']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedCR_UnmatchedCashReceipts_TransType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Close on ChildForm_UnmatchedCRForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCRForm = new SeleniumControl( sDriver, "ChildForm_UnmatchedCRForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_UNMREC_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_UnmatchedCRForm);
IWebElement formBttn = GLQBKINQ_ChildForm_UnmatchedCRForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("UNMATCHED CD");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedCDLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCDLink = new SeleniumControl( sDriver, "ChildForm_UnmatchedCDLink", "ID", "lnk_1005629_GLQBKINQ_BANKTRNHS_HDR");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedCDLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Click on ChildForm_UnmatchedCDLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCDLink = new SeleniumControl( sDriver, "ChildForm_UnmatchedCDLink", "ID", "lnk_1005629_GLQBKINQ_BANKTRNHS_HDR");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_UnmatchedCDLink);
GLQBKINQ_ChildForm_UnmatchedCDLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedCDForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCDForm = new SeleniumControl( sDriver, "ChildForm_UnmatchedCDForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_UNMDISP_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedCDForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedCD_TransTotalGLAmount...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCD_TransTotalGLAmount = new SeleniumControl( sDriver, "ChildForm_UnmatchedCD_TransTotalGLAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_UNMDISP_CHLD_']/ancestor::form[1]/descendant::*[@id='TOT_TRN_AMT']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedCD_TransTotalGLAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExist on ChildForm_UnmatchedCD_UnmatchedCashDisbursementsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCD_UnmatchedCashDisbursementsFormTable = new SeleniumControl( sDriver, "ChildForm_UnmatchedCD_UnmatchedCashDisbursementsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_UNMDISP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedCD_UnmatchedCashDisbursementsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing ClickButton on ChildForm_UnmatchedCD_UnmatchedCashDisbursementsForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCD_UnmatchedCashDisbursementsForm = new SeleniumControl( sDriver, "ChildForm_UnmatchedCD_UnmatchedCashDisbursementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_UNMDISP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_UnmatchedCD_UnmatchedCashDisbursementsForm);
IWebElement formBttn = GLQBKINQ_ChildForm_UnmatchedCD_UnmatchedCashDisbursementsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQBKINQ_ChildForm_UnmatchedCD_UnmatchedCashDisbursementsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQBKINQ_ChildForm_UnmatchedCD_UnmatchedCashDisbursementsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedCD_UnmatchedCashDisbursementsForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCD_UnmatchedCashDisbursementsForm = new SeleniumControl( sDriver, "ChildForm_UnmatchedCD_UnmatchedCashDisbursementsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_UNMDISP_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedCD_UnmatchedCashDisbursementsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedCD_UnmatchedCashDisbursements_TransType...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCD_UnmatchedCashDisbursements_TransType = new SeleniumControl( sDriver, "ChildForm_UnmatchedCD_UnmatchedCashDisbursements_TransType", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_UNMDISP_']/ancestor::form[1]/descendant::*[@id='S_BANK_TRN_TYPE']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedCD_UnmatchedCashDisbursements_TransType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Close on ChildForm_UnmatchedCDForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedCDForm = new SeleniumControl( sDriver, "ChildForm_UnmatchedCDForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_UNMDISP_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_UnmatchedCDForm);
IWebElement formBttn = GLQBKINQ_ChildForm_UnmatchedCDForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("UNMATCHED ADJ");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedAdjLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedAdjLink = new SeleniumControl( sDriver, "ChildForm_UnmatchedAdjLink", "ID", "lnk_1005631_GLQBKINQ_BANKTRNHS_HDR");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedAdjLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Click on ChildForm_UnmatchedAdjLink...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedAdjLink = new SeleniumControl( sDriver, "ChildForm_UnmatchedAdjLink", "ID", "lnk_1005631_GLQBKINQ_BANKTRNHS_HDR");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_UnmatchedAdjLink);
GLQBKINQ_ChildForm_UnmatchedAdjLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedAdjForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedAdjForm = new SeleniumControl( sDriver, "ChildForm_UnmatchedAdjForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_UNMMANADJ_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedAdjForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedAdj_TransTotalGLAmount...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedAdj_TransTotalGLAmount = new SeleniumControl( sDriver, "ChildForm_UnmatchedAdj_TransTotalGLAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_UNMMANADJ_CHLD_']/ancestor::form[1]/descendant::*[@id='TOT_TRN_AMT']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedAdj_TransTotalGLAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExist on ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsFormTable = new SeleniumControl( sDriver, "ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_UNMMANADJ_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing ClickButton on ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsForm = new SeleniumControl( sDriver, "ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_UNMMANADJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsForm);
IWebElement formBttn = GLQBKINQ_ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQBKINQ_ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQBKINQ_ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsForm = new SeleniumControl( sDriver, "ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_UNMMANADJ_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedAdj_UnmatchedManualAdjustmentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing VerifyExists on ChildForm_UnmatchedAdj_UnmatchedManualAdjustments_TransType...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedAdj_UnmatchedManualAdjustments_TransType = new SeleniumControl( sDriver, "ChildForm_UnmatchedAdj_UnmatchedManualAdjustments_TransType", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_BANKTRNHS_UNMMANADJ_']/ancestor::form[1]/descendant::*[@id='S_BANK_TRN_TYPE']");
				Function.AssertEqual(true,GLQBKINQ_ChildForm_UnmatchedAdj_UnmatchedManualAdjustments_TransType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Close on ChildForm_UnmatchedAdjForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_ChildForm_UnmatchedAdjForm = new SeleniumControl( sDriver, "ChildForm_UnmatchedAdjForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQBKINQ_UNMMANADJ_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_ChildForm_UnmatchedAdjForm);
IWebElement formBttn = GLQBKINQ_ChildForm_UnmatchedAdjForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "GLQBKINQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQBKINQ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLQBKINQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLQBKINQ_MainForm);
IWebElement formBttn = GLQBKINQ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

