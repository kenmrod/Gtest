 
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
    public class GLPMCBAJ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Adjust Currency Balances", "xpath","//div[@class='navItem'][.='Adjust Currency Balances']").Click();


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
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLPMCBAJ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing VerifyExists on BankAbbreviation...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_BankAbbreviation = new SeleniumControl( sDriver, "BankAbbreviation", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BANK_ABBRV_CD']");
				Function.AssertEqual(true,GLPMCBAJ_BankAbbreviation.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing Set on BankAbbreviation...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_BankAbbreviation = new SeleniumControl( sDriver, "BankAbbreviation", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BANK_ABBRV_CD']");
				GLPMCBAJ_BankAbbreviation.Click();
GLPMCBAJ_BankAbbreviation.SendKeys("CAL", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
GLPMCBAJ_BankAbbreviation.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing Set on SelectionRanges_Start_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_SelectionRanges_Start_FiscalYear = new SeleniumControl( sDriver, "SelectionRanges_Start_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				GLPMCBAJ_SelectionRanges_Start_FiscalYear.Click();
GLPMCBAJ_SelectionRanges_Start_FiscalYear.SendKeys("1994", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
GLPMCBAJ_SelectionRanges_Start_FiscalYear.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing Select on SelectionRanges_Option_PeriodSubpd...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_SelectionRanges_Option_PeriodSubpd = new SeleniumControl( sDriver, "SelectionRanges_Option_PeriodSubpd", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PD_RANGE']");
				Function.WaitControlDisplayed(GLPMCBAJ_SelectionRanges_Option_PeriodSubpd);
GLPMCBAJ_SelectionRanges_Option_PeriodSubpd.ScrollIntoViewUsingJavaScript();
GLPMCBAJ_SelectionRanges_Option_PeriodSubpd.Click();
SeleniumControl comboBoxList = new SeleniumControl(sDriver,"ComboBoxList", "class_display", "tCCBV");
Function.WaitControlDisplayed(comboBoxList);
IWebElement mItem = comboBoxList.mElement.FindElements(By.CssSelector("div")).Where(x => x.Displayed && new SeleniumControl( sDriver, "x", x).GetValue().Trim().ToLower() == "one").FirstOrDefault();
if(mItem != null)
mItem.Click();
else
 throw new Exception("[One] not found in list.");

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing Set on SelectionRanges_Start_Period_PeriodSubpd...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_SelectionRanges_Start_Period_PeriodSubpd = new SeleniumControl( sDriver, "SelectionRanges_Start_Period_PeriodSubpd", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PD_NO_FROM']");
				GLPMCBAJ_SelectionRanges_Start_Period_PeriodSubpd.Click();
GLPMCBAJ_SelectionRanges_Start_Period_PeriodSubpd.SendKeys("1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
GLPMCBAJ_SelectionRanges_Start_Period_PeriodSubpd.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing Set on SelectionRanges_Start_PeriodSubpd_Subpd...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_SelectionRanges_Start_PeriodSubpd_Subpd = new SeleniumControl( sDriver, "SelectionRanges_Start_PeriodSubpd_Subpd", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SUBPD_NO_FROM']");
				GLPMCBAJ_SelectionRanges_Start_PeriodSubpd_Subpd.Click();
GLPMCBAJ_SelectionRanges_Start_PeriodSubpd_Subpd.SendKeys("1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
GLPMCBAJ_SelectionRanges_Start_PeriodSubpd_Subpd.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPMCBAJ_BANKTRNHS_']/ancestor::form[1]");
				Function.AssertEqual(true,GLPMCBAJ_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPMCBAJ_BANKTRNHS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLPMCBAJ_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing VerifyExists on ChildForm_AdjustRevalueLink...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_ChildForm_AdjustRevalueLink = new SeleniumControl( sDriver, "ChildForm_AdjustRevalueLink", "ID", "lnk_1004462_GLPMCBAJ_BANKTRNHS");
				Function.AssertEqual(true,GLPMCBAJ_ChildForm_AdjustRevalueLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing Click on ChildForm_AdjustRevalueLink...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_ChildForm_AdjustRevalueLink = new SeleniumControl( sDriver, "ChildForm_AdjustRevalueLink", "ID", "lnk_1004462_GLPMCBAJ_BANKTRNHS");
				Function.WaitControlDisplayed(GLPMCBAJ_ChildForm_AdjustRevalueLink);
GLPMCBAJ_ChildForm_AdjustRevalueLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing VerifyExists on ChildForm_AdjustRevalueForm...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_ChildForm_AdjustRevalueForm = new SeleniumControl( sDriver, "ChildForm_AdjustRevalueForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPMCBAJ_ADJREVAL_REVERSAL_']/ancestor::form[1]");
				Function.AssertEqual(true,GLPMCBAJ_ChildForm_AdjustRevalueForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing VerifyExists on AdjustRevalue_PeriodToPost_Period...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_AdjustRevalue_PeriodToPost_Period = new SeleniumControl( sDriver, "AdjustRevalue_PeriodToPost_Period", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPMCBAJ_ADJREVAL_REVERSAL_']/ancestor::form[1]/descendant::*[@id='TRN_PD_NO']");
				Function.AssertEqual(true,GLPMCBAJ_AdjustRevalue_PeriodToPost_Period.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing Close on ChildForm_AdjustRevalueForm...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_ChildForm_AdjustRevalueForm = new SeleniumControl( sDriver, "ChildForm_AdjustRevalueForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPMCBAJ_ADJREVAL_REVERSAL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLPMCBAJ_ChildForm_AdjustRevalueForm);
IWebElement formBttn = GLPMCBAJ_ChildForm_AdjustRevalueForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing VerifyExists on ChildForm_ReversalLink...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_ChildForm_ReversalLink = new SeleniumControl( sDriver, "ChildForm_ReversalLink", "ID", "lnk_1004468_GLPMCBAJ_BANKTRNHS");
				Function.AssertEqual(true,GLPMCBAJ_ChildForm_ReversalLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing Click on ChildForm_ReversalLink...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_ChildForm_ReversalLink = new SeleniumControl( sDriver, "ChildForm_ReversalLink", "ID", "lnk_1004468_GLPMCBAJ_BANKTRNHS");
				Function.WaitControlDisplayed(GLPMCBAJ_ChildForm_ReversalLink);
GLPMCBAJ_ChildForm_ReversalLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing VerifyExists on ChildForm_ReversalForm...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_ChildForm_ReversalForm = new SeleniumControl( sDriver, "ChildForm_ReversalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPMCBAJ_REVERSAL_']/ancestor::form[1]");
				Function.AssertEqual(true,GLPMCBAJ_ChildForm_ReversalForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing VerifyExists on Reversal_PeriodToPost_Period...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_Reversal_PeriodToPost_Period = new SeleniumControl( sDriver, "Reversal_PeriodToPost_Period", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPMCBAJ_REVERSAL_']/ancestor::form[1]/descendant::*[@id='TRN_PD_NO']");
				Function.AssertEqual(true,GLPMCBAJ_Reversal_PeriodToPost_Period.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing Close on ChildForm_ReversalForm...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_ChildForm_ReversalForm = new SeleniumControl( sDriver, "ChildForm_ReversalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLPMCBAJ_REVERSAL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLPMCBAJ_ChildForm_ReversalForm);
IWebElement formBttn = GLPMCBAJ_ChildForm_ReversalForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "GLPMCBAJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLPMCBAJ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLPMCBAJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLPMCBAJ_MainForm);
IWebElement formBttn = GLPMCBAJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

