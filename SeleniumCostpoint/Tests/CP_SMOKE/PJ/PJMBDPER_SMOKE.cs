 
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
    public class PJMBDPER_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Projects", "xpath","//div[@class='busItem'][.='Projects']").Click();
new SeleniumControl(sDriver,"Budgeting and ETC", "xpath","//div[@class='deptItem'][.='Budgeting and ETC']").Click();
new SeleniumControl(sDriver,"Period Budgets", "xpath","//div[@class='navItem'][.='Period Budgets']").Click();
new SeleniumControl(sDriver,"Manage Project Budgets By Period", "xpath","//div[@class='navItem'][.='Manage Project Budgets By Period']").Click();


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
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMBDPER_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMBDPER_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBDPER_MainForm);
IWebElement formBttn = PJMBDPER_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMBDPER_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMBDPER_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBDPER_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExist on DirectFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_DirectFormTable = new SeleniumControl( sDriver, "DirectFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_DIRECT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBDPER_DirectFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing ClickButton on DirectForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_DirectForm = new SeleniumControl( sDriver, "DirectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_DIRECT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDPER_DirectForm);
IWebElement formBttn = PJMBDPER_DirectForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBDPER_DirectForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBDPER_DirectForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on DirectForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_DirectForm = new SeleniumControl( sDriver, "DirectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_DIRECT_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBDPER_DirectForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_AccountInfo_Account...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_AccountInfo_Account = new SeleniumControl( sDriver, "Direct_AccountInfo_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_DIRECT_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,PJMBDPER_Direct_AccountInfo_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Indirect");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_IndirectLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_IndirectLink = new SeleniumControl( sDriver, "Direct_IndirectLink", "ID", "lnk_1001914_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.AssertEqual(true,PJMBDPER_Direct_IndirectLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Click on Direct_IndirectLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_IndirectLink = new SeleniumControl( sDriver, "Direct_IndirectLink", "ID", "lnk_1001914_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.WaitControlDisplayed(PJMBDPER_Direct_IndirectLink);
PJMBDPER_Direct_IndirectLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExist on Direct_IndirectFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_IndirectFormTable = new SeleniumControl( sDriver, "Direct_IndirectFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDIND_INDIRECT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBDPER_Direct_IndirectFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing ClickButton on Direct_IndirectForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_IndirectForm = new SeleniumControl( sDriver, "Direct_IndirectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDIND_INDIRECT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDPER_Direct_IndirectForm);
IWebElement formBttn = PJMBDPER_Direct_IndirectForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBDPER_Direct_IndirectForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBDPER_Direct_IndirectForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_IndirectForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_IndirectForm = new SeleniumControl( sDriver, "Direct_IndirectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDIND_INDIRECT_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBDPER_Direct_IndirectForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_Indirect_Identification_PoolNumber...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_Indirect_Identification_PoolNumber = new SeleniumControl( sDriver, "Direct_Indirect_Identification_PoolNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDIND_INDIRECT_']/ancestor::form[1]/descendant::*[@id='POOL_NO']");
				Function.AssertEqual(true,PJMBDPER_Direct_Indirect_Identification_PoolNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Close on Direct_IndirectForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_IndirectForm = new SeleniumControl( sDriver, "Direct_IndirectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDIND_INDIRECT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDPER_Direct_IndirectForm);
IWebElement formBttn = PJMBDPER_Direct_IndirectForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Total Budget");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_TotalBudgetLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_TotalBudgetLink = new SeleniumControl( sDriver, "Direct_TotalBudgetLink", "ID", "lnk_1001915_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.AssertEqual(true,PJMBDPER_Direct_TotalBudgetLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Click on Direct_TotalBudgetLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_TotalBudgetLink = new SeleniumControl( sDriver, "Direct_TotalBudgetLink", "ID", "lnk_1001915_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.WaitControlDisplayed(PJMBDPER_Direct_TotalBudgetLink);
PJMBDPER_Direct_TotalBudgetLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_TotalBudgetForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_TotalBudgetForm = new SeleniumControl( sDriver, "Direct_TotalBudgetForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDFEE_TOTALBUDG_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBDPER_Direct_TotalBudgetForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_TotalBudget_ManualFeeOverride_Fee...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_TotalBudget_ManualFeeOverride_Fee = new SeleniumControl( sDriver, "Direct_TotalBudget_ManualFeeOverride_Fee", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDFEE_TOTALBUDG_']/ancestor::form[1]/descendant::*[@id='DFLT_FEE_RT']");
				Function.AssertEqual(true,PJMBDPER_Direct_TotalBudget_ManualFeeOverride_Fee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Close on Direct_TotalBudgetForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_TotalBudgetForm = new SeleniumControl( sDriver, "Direct_TotalBudgetForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDFEE_TOTALBUDG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDPER_Direct_TotalBudgetForm);
IWebElement formBttn = PJMBDPER_Direct_TotalBudgetForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Adjust Actuals");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_AdjustActualsLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_AdjustActualsLink = new SeleniumControl( sDriver, "Direct_AdjustActualsLink", "ID", "lnk_1001920_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.AssertEqual(true,PJMBDPER_Direct_AdjustActualsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Click on Direct_AdjustActualsLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_AdjustActualsLink = new SeleniumControl( sDriver, "Direct_AdjustActualsLink", "ID", "lnk_1001920_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.WaitControlDisplayed(PJMBDPER_Direct_AdjustActualsLink);
PJMBDPER_Direct_AdjustActualsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_AdjustActualsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_AdjustActualsForm = new SeleniumControl( sDriver, "Direct_AdjustActualsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_ACTUALS_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBDPER_Direct_AdjustActualsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_AdjustActuals_SelectAccounts_RangeOption...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_AdjustActuals_SelectAccounts_RangeOption = new SeleniumControl( sDriver, "Direct_AdjustActuals_SelectAccounts_RangeOption", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_ACTUALS_']/ancestor::form[1]/descendant::*[@id='ACCT_RANGE_CD']");
				Function.AssertEqual(true,PJMBDPER_Direct_AdjustActuals_SelectAccounts_RangeOption.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Close on Direct_AdjustActualsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_AdjustActualsForm = new SeleniumControl( sDriver, "Direct_AdjustActualsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_ACTUALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDPER_Direct_AdjustActualsForm);
IWebElement formBttn = PJMBDPER_Direct_AdjustActualsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Spread");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_SpreadLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_SpreadLink = new SeleniumControl( sDriver, "Direct_SpreadLink", "ID", "lnk_1001921_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.AssertEqual(true,PJMBDPER_Direct_SpreadLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Click on Direct_SpreadLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_SpreadLink = new SeleniumControl( sDriver, "Direct_SpreadLink", "ID", "lnk_1001921_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.WaitControlDisplayed(PJMBDPER_Direct_SpreadLink);
PJMBDPER_Direct_SpreadLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_SpreadForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_SpreadForm = new SeleniumControl( sDriver, "Direct_SpreadForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_SPREAD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBDPER_Direct_SpreadForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_Spread_SelectAccounts_RangeOption...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_Spread_SelectAccounts_RangeOption = new SeleniumControl( sDriver, "Direct_Spread_SelectAccounts_RangeOption", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_SPREAD_']/ancestor::form[1]/descendant::*[@id='ACCT_RANGE_CD']");
				Function.AssertEqual(true,PJMBDPER_Direct_Spread_SelectAccounts_RangeOption.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Close on Direct_SpreadForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_SpreadForm = new SeleniumControl( sDriver, "Direct_SpreadForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_SPREAD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDPER_Direct_SpreadForm);
IWebElement formBttn = PJMBDPER_Direct_SpreadForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Fill");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_FillLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_FillLink = new SeleniumControl( sDriver, "Direct_FillLink", "ID", "lnk_1001922_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.AssertEqual(true,PJMBDPER_Direct_FillLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Click on Direct_FillLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_FillLink = new SeleniumControl( sDriver, "Direct_FillLink", "ID", "lnk_1001922_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.WaitControlDisplayed(PJMBDPER_Direct_FillLink);
PJMBDPER_Direct_FillLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_FillForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_FillForm = new SeleniumControl( sDriver, "Direct_FillForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_FILL_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBDPER_Direct_FillForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_Fill_SelectAccounts_RangeOption...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_Fill_SelectAccounts_RangeOption = new SeleniumControl( sDriver, "Direct_Fill_SelectAccounts_RangeOption", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_FILL_']/ancestor::form[1]/descendant::*[@id='ACCT_RANGE_CD']");
				Function.AssertEqual(true,PJMBDPER_Direct_Fill_SelectAccounts_RangeOption.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Close on Direct_FillForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_FillForm = new SeleniumControl( sDriver, "Direct_FillForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_FILL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDPER_Direct_FillForm);
IWebElement formBttn = PJMBDPER_Direct_FillForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Move");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_MoveLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_MoveLink = new SeleniumControl( sDriver, "Direct_MoveLink", "ID", "lnk_1001923_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.AssertEqual(true,PJMBDPER_Direct_MoveLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Click on Direct_MoveLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_MoveLink = new SeleniumControl( sDriver, "Direct_MoveLink", "ID", "lnk_1001923_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.WaitControlDisplayed(PJMBDPER_Direct_MoveLink);
PJMBDPER_Direct_MoveLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_MoveForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_MoveForm = new SeleniumControl( sDriver, "Direct_MoveForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_MOVE_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBDPER_Direct_MoveForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_Move_SelectAccounts_RangeOption...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_Move_SelectAccounts_RangeOption = new SeleniumControl( sDriver, "Direct_Move_SelectAccounts_RangeOption", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_MOVE_']/ancestor::form[1]/descendant::*[@id='ACCT_RANGE_CD']");
				Function.AssertEqual(true,PJMBDPER_Direct_Move_SelectAccounts_RangeOption.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Close on Direct_MoveForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_MoveForm = new SeleniumControl( sDriver, "Direct_MoveForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_MOVE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDPER_Direct_MoveForm);
IWebElement formBttn = PJMBDPER_Direct_MoveForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Escalate");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_EscalateLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_EscalateLink = new SeleniumControl( sDriver, "Direct_EscalateLink", "ID", "lnk_1001924_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.AssertEqual(true,PJMBDPER_Direct_EscalateLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Click on Direct_EscalateLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_EscalateLink = new SeleniumControl( sDriver, "Direct_EscalateLink", "ID", "lnk_1001924_PJMBDPER_PROJBUDDIR_DIRECT");
				Function.WaitControlDisplayed(PJMBDPER_Direct_EscalateLink);
PJMBDPER_Direct_EscalateLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_EscalateForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_EscalateForm = new SeleniumControl( sDriver, "Direct_EscalateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_ESCALATE_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBDPER_Direct_EscalateForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing VerifyExists on Direct_Escalate_SelectAccounts_RangeOption...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_Escalate_SelectAccounts_RangeOption = new SeleniumControl( sDriver, "Direct_Escalate_SelectAccounts_RangeOption", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_ESCALATE_']/ancestor::form[1]/descendant::*[@id='ACCT_RANGE_CD']");
				Function.AssertEqual(true,PJMBDPER_Direct_Escalate_SelectAccounts_RangeOption.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Close on Direct_EscalateForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_Direct_EscalateForm = new SeleniumControl( sDriver, "Direct_EscalateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDPER_PROJBUDDIR_ESCALATE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDPER_Direct_EscalateForm);
IWebElement formBttn = PJMBDPER_Direct_EscalateForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PJMBDPER";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDPER] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDPER_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBDPER_MainForm);
IWebElement formBttn = PJMBDPER_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

