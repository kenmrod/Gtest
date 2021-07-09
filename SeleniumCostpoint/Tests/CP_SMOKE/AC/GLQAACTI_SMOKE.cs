 
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
    public class GLQAACTI_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"View Account Activity", "xpath","//div[@class='navItem'][.='View Account Activity']").Click();


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
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExists on Account_Account...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_Account_Account = new SeleniumControl( sDriver, "Account_Account", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,GLQAACTI_Account_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExists on Account_Level...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_Account_Level = new SeleniumControl( sDriver, "Account_Level", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ACCT_LVL_NO']");
				Function.AssertEqual(true,GLQAACTI_Account_Level.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Child Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQAACTI_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQAACTI_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQAACTI_ChildForm);
IWebElement formBttn = GLQAACTI_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQAACTI_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQAACTI_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExists on ChildForm_Subperiod...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_Subperiod = new SeleniumControl( sDriver, "ChildForm_Subperiod", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_CTW_']/ancestor::form[1]/descendant::*[@id='SUB_PD_NO']");
				Function.AssertEqual(true,GLQAACTI_ChildForm_Subperiod.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing Set on Account_Account...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_Account_Account = new SeleniumControl( sDriver, "Account_Account", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ACCT_ID']");
				GLQAACTI_Account_Account.Click();
GLQAACTI_Account_Account.SendKeys("05000-010", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
GLQAACTI_Account_Account.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing Set on Account_Level...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_Account_Level = new SeleniumControl( sDriver, "Account_Level", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ACCT_LVL_NO']");
				GLQAACTI_Account_Level.Click();
GLQAACTI_Account_Level.SendKeys("2", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
GLQAACTI_Account_Level.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing Set on PeriodsToDisplay_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_PeriodsToDisplay_FiscalYear = new SeleniumControl( sDriver, "PeriodsToDisplay_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				GLQAACTI_PeriodsToDisplay_FiscalYear.Click();
GLQAACTI_PeriodsToDisplay_FiscalYear.SendKeys("2014", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
GLQAACTI_PeriodsToDisplay_FiscalYear.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing Set on PeriodsToDisplay_Period...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_PeriodsToDisplay_Period = new SeleniumControl( sDriver, "PeriodsToDisplay_Period", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PD_NO']");
				GLQAACTI_PeriodsToDisplay_Period.Click();
GLQAACTI_PeriodsToDisplay_Period.SendKeys("1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
GLQAACTI_PeriodsToDisplay_Period.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExists on ChildForm_PostingDetailLink...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetailLink = new SeleniumControl( sDriver, "ChildForm_PostingDetailLink", "ID", "lnk_1007301_GLQAACTI_GLDETL_CTW");
				Function.AssertEqual(true,GLQAACTI_ChildForm_PostingDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing Click on ChildForm_PostingDetailLink...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetailLink = new SeleniumControl( sDriver, "ChildForm_PostingDetailLink", "ID", "lnk_1007301_GLQAACTI_GLDETL_CTW");
				Function.WaitControlDisplayed(GLQAACTI_ChildForm_PostingDetailLink);
GLQAACTI_ChildForm_PostingDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Posting Detail Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExists on ChildForm_PostingDetailForm...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetailForm = new SeleniumControl( sDriver, "ChildForm_PostingDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_JNLDTL_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQAACTI_ChildForm_PostingDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExists on ChildForm_PostingDetail_TotalDebit...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetail_TotalDebit = new SeleniumControl( sDriver, "ChildForm_PostingDetail_TotalDebit", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_JNLDTL_HDR_']/ancestor::form[1]/descendant::*[@id='TOTAL_DB']");
				Function.AssertEqual(true,GLQAACTI_ChildForm_PostingDetail_TotalDebit.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Journal Detail Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExists on ChildForm_PostingDetail_JournalDetailForm...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetail_JournalDetailForm = new SeleniumControl( sDriver, "ChildForm_PostingDetail_JournalDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_JNLDETL_']/ancestor::form[1]");
				Function.AssertEqual(true,GLQAACTI_ChildForm_PostingDetail_JournalDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExist on ChildForm_PostingDetail_JournalDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetail_JournalDetailFormTable = new SeleniumControl( sDriver, "ChildForm_PostingDetail_JournalDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_JNLDETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQAACTI_ChildForm_PostingDetail_JournalDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing ClickButton on ChildForm_PostingDetail_JournalDetailForm...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetail_JournalDetailForm = new SeleniumControl( sDriver, "ChildForm_PostingDetail_JournalDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_JNLDETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQAACTI_ChildForm_PostingDetail_JournalDetailForm);
IWebElement formBttn = GLQAACTI_ChildForm_PostingDetail_JournalDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQAACTI_ChildForm_PostingDetail_JournalDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQAACTI_ChildForm_PostingDetail_JournalDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExists on ChildForm_PostingDetail_JournalDetail_Tab...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetail_JournalDetail_Tab = new SeleniumControl( sDriver, "ChildForm_PostingDetail_JournalDetail_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_JNLDETL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,GLQAACTI_ChildForm_PostingDetail_JournalDetail_Tab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing Select on ChildForm_PostingDetail_JournalDetail_Tab...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetail_JournalDetail_Tab = new SeleniumControl( sDriver, "ChildForm_PostingDetail_JournalDetail_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_JNLDETL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(GLQAACTI_ChildForm_PostingDetail_JournalDetail_Tab);
IWebElement mTab = GLQAACTI_ChildForm_PostingDetail_JournalDetail_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExists on ChildForm_PostingDetail_JournalDetail_Details_TransactionDescription...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetail_JournalDetail_Details_TransactionDescription = new SeleniumControl( sDriver, "ChildForm_PostingDetail_JournalDetail_Details_TransactionDescription", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_JNLDETL_']/ancestor::form[1]/descendant::*[@id='TRN_DESC']");
				Function.AssertEqual(true,GLQAACTI_ChildForm_PostingDetail_JournalDetail_Details_TransactionDescription.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing Select on ChildForm_PostingDetail_JournalDetail_Tab...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetail_JournalDetail_Tab = new SeleniumControl( sDriver, "ChildForm_PostingDetail_JournalDetail_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_JNLDETL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(GLQAACTI_ChildForm_PostingDetail_JournalDetail_Tab);
IWebElement mTab = GLQAACTI_ChildForm_PostingDetail_JournalDetail_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Amount/Other Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExists on ChildForm_PostingDetail_JournalDetail_AmountOtherDetails_TransDebit...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetail_JournalDetail_AmountOtherDetails_TransDebit = new SeleniumControl( sDriver, "ChildForm_PostingDetail_JournalDetail_AmountOtherDetails_TransDebit", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_JNLDETL_']/ancestor::form[1]/descendant::*[@id='TRN_DB_AMT']");
				Function.AssertEqual(true,GLQAACTI_ChildForm_PostingDetail_JournalDetail_AmountOtherDetails_TransDebit.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing Select on ChildForm_PostingDetail_JournalDetail_Tab...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetail_JournalDetail_Tab = new SeleniumControl( sDriver, "ChildForm_PostingDetail_JournalDetail_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_JNLDETL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(GLQAACTI_ChildForm_PostingDetail_JournalDetail_Tab);
IWebElement mTab = GLQAACTI_ChildForm_PostingDetail_JournalDetail_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Comments").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing VerifyExists on ChildForm_PostingDetail_JournalDetail_Comments_TextArea...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetail_JournalDetail_Comments_TextArea = new SeleniumControl( sDriver, "ChildForm_PostingDetail_JournalDetail_Comments_TextArea", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_GLDETL_JNLDETL_']/ancestor::form[1]/descendant::*[@id='COMMENTS_NT']");
				Function.AssertEqual(true,GLQAACTI_ChildForm_PostingDetail_JournalDetail_Comments_TextArea.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing Close on ChildForm_PostingDetailForm...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_ChildForm_PostingDetailForm = new SeleniumControl( sDriver, "ChildForm_PostingDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQAACTI_JNLDTL_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQAACTI_ChildForm_PostingDetailForm);
IWebElement formBttn = GLQAACTI_ChildForm_PostingDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "GLQAACTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQAACTI] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLQAACTI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLQAACTI_MainForm);
IWebElement formBttn = GLQAACTI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

