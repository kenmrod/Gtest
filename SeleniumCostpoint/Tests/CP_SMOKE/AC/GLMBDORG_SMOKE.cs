 
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
    public class GLMBDORG_SMOKE : SeleniumTestScript
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

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"General Ledger", "xpath","//div[@class='deptItem'][.='General Ledger']").Click();
new SeleniumControl(sDriver,"General Ledger Budgets", "xpath","//div[@class='navItem'][.='General Ledger Budgets']").Click();
new SeleniumControl(sDriver,"Manage Organization/Account Budgets", "xpath","//div[@class='navItem'][.='Manage Organization/Account Budgets']").Click();


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
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLMBDORG_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMBDORG_MainForm);
IWebElement formBttn = GLMBDORG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMBDORG_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMBDORG_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on Organization...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_Organization = new SeleniumControl( sDriver, "Organization", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ORG_ID']");
				Function.AssertEqual(true,GLMBDORG_Organization.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMBDORG_MainForm);
IWebElement formBttn = GLMBDORG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? GLMBDORG_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
GLMBDORG_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMBDORG_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExist on BudgetsByPeriodFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriodFormTable = new SeleniumControl( sDriver, "BudgetsByPeriodFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMBDORG_BudgetsByPeriodFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing ClickButtonIfExists on BudgetsByPeriodForm...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriodForm = new SeleniumControl( sDriver, "BudgetsByPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMBDORG_BudgetsByPeriodForm);
IWebElement formBttn = GLMBDORG_BudgetsByPeriodForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMBDORG_BudgetsByPeriodForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMBDORG_BudgetsByPeriodForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on BudgetsByPeriodForm...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriodForm = new SeleniumControl( sDriver, "BudgetsByPeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMBDORG_BudgetsByPeriodForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on BudgetsByPeriod_Account...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_Account = new SeleniumControl( sDriver, "BudgetsByPeriod_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_CTW_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,GLMBDORG_BudgetsByPeriod_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on BudgetsByPeriod_AdjustActualsLink...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_AdjustActualsLink = new SeleniumControl( sDriver, "BudgetsByPeriod_AdjustActualsLink", "ID", "lnk_1000923_GLMBDORG_ORGACCTBUD_CTW");
				Function.AssertEqual(true,GLMBDORG_BudgetsByPeriod_AdjustActualsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on BudgetsByPeriod_EscalateLink...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_EscalateLink = new SeleniumControl( sDriver, "BudgetsByPeriod_EscalateLink", "ID", "lnk_1000754_GLMBDORG_ORGACCTBUD_CTW");
				Function.AssertEqual(true,GLMBDORG_BudgetsByPeriod_EscalateLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on BudgetsByPeriod_FillLink...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_FillLink = new SeleniumControl( sDriver, "BudgetsByPeriod_FillLink", "ID", "lnk_1000756_GLMBDORG_ORGACCTBUD_CTW");
				Function.AssertEqual(true,GLMBDORG_BudgetsByPeriod_FillLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on BudgetsByPeriod_MoveLink...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_MoveLink = new SeleniumControl( sDriver, "BudgetsByPeriod_MoveLink", "ID", "lnk_1000755_GLMBDORG_ORGACCTBUD_CTW");
				Function.AssertEqual(true,GLMBDORG_BudgetsByPeriod_MoveLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on BudgetsByPeriod_SpreadLink...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_SpreadLink = new SeleniumControl( sDriver, "BudgetsByPeriod_SpreadLink", "ID", "lnk_1000757_GLMBDORG_ORGACCTBUD_CTW");
				Function.AssertEqual(true,GLMBDORG_BudgetsByPeriod_SpreadLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing Click on BudgetsByPeriod_AdjustActualsLink...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_AdjustActualsLink = new SeleniumControl( sDriver, "BudgetsByPeriod_AdjustActualsLink", "ID", "lnk_1000923_GLMBDORG_ORGACCTBUD_CTW");
				Function.WaitControlDisplayed(GLMBDORG_BudgetsByPeriod_AdjustActualsLink);
GLMBDORG_BudgetsByPeriod_AdjustActualsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on BudgetsByPeriod_AdjustActuals_AdjustToActualsPeriodRange_From...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_AdjustActuals_AdjustToActualsPeriodRange_From = new SeleniumControl( sDriver, "BudgetsByPeriod_AdjustActuals_AdjustToActualsPeriodRange_From", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_ACTUALS_']/ancestor::form[1]/descendant::*[@id='PD_FR']");
				Function.AssertEqual(true,GLMBDORG_BudgetsByPeriod_AdjustActuals_AdjustToActualsPeriodRange_From.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing Close on BudgetsByPeriod_AdjustActualsForm...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_AdjustActualsForm = new SeleniumControl( sDriver, "BudgetsByPeriod_AdjustActualsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_ACTUALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMBDORG_BudgetsByPeriod_AdjustActualsForm);
IWebElement formBttn = GLMBDORG_BudgetsByPeriod_AdjustActualsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing Click on BudgetsByPeriod_SpreadLink...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_SpreadLink = new SeleniumControl( sDriver, "BudgetsByPeriod_SpreadLink", "ID", "lnk_1000757_GLMBDORG_ORGACCTBUD_CTW");
				Function.WaitControlDisplayed(GLMBDORG_BudgetsByPeriod_SpreadLink);
GLMBDORG_BudgetsByPeriod_SpreadLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on BudgetsByPeriod_Spread_SelectAccounts_From...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_Spread_SelectAccounts_From = new SeleniumControl( sDriver, "BudgetsByPeriod_Spread_SelectAccounts_From", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_SPREAD_']/ancestor::form[1]/descendant::*[@id='ACCT_ID_FR']");
				Function.AssertEqual(true,GLMBDORG_BudgetsByPeriod_Spread_SelectAccounts_From.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing Close on BudgetsByPeriod_SpreadForm...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_SpreadForm = new SeleniumControl( sDriver, "BudgetsByPeriod_SpreadForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_SPREAD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMBDORG_BudgetsByPeriod_SpreadForm);
IWebElement formBttn = GLMBDORG_BudgetsByPeriod_SpreadForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing Click on BudgetsByPeriod_FillLink...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_FillLink = new SeleniumControl( sDriver, "BudgetsByPeriod_FillLink", "ID", "lnk_1000756_GLMBDORG_ORGACCTBUD_CTW");
				Function.WaitControlDisplayed(GLMBDORG_BudgetsByPeriod_FillLink);
GLMBDORG_BudgetsByPeriod_FillLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on BudgetsByPeriod_Fill_Fill_Amount...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_Fill_Fill_Amount = new SeleniumControl( sDriver, "BudgetsByPeriod_Fill_Fill_Amount", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_FILL_']/ancestor::form[1]/descendant::*[@id='FILL_AMT']");
				Function.AssertEqual(true,GLMBDORG_BudgetsByPeriod_Fill_Fill_Amount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing Close on BudgetsByPeriod_FillForm...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_FillForm = new SeleniumControl( sDriver, "BudgetsByPeriod_FillForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_FILL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMBDORG_BudgetsByPeriod_FillForm);
IWebElement formBttn = GLMBDORG_BudgetsByPeriod_FillForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing Click on BudgetsByPeriod_MoveLink...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_MoveLink = new SeleniumControl( sDriver, "BudgetsByPeriod_MoveLink", "ID", "lnk_1000755_GLMBDORG_ORGACCTBUD_CTW");
				Function.WaitControlDisplayed(GLMBDORG_BudgetsByPeriod_MoveLink);
GLMBDORG_BudgetsByPeriod_MoveLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on BudgetsByPeriod_Move_SelectAccounts_From...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_Move_SelectAccounts_From = new SeleniumControl( sDriver, "BudgetsByPeriod_Move_SelectAccounts_From", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_MOVE_']/ancestor::form[1]/descendant::*[@id='ACCT_ID_FR']");
				Function.AssertEqual(true,GLMBDORG_BudgetsByPeriod_Move_SelectAccounts_From.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing Close on BudgetsByPeriod_MoveForm...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_MoveForm = new SeleniumControl( sDriver, "BudgetsByPeriod_MoveForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_MOVE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMBDORG_BudgetsByPeriod_MoveForm);
IWebElement formBttn = GLMBDORG_BudgetsByPeriod_MoveForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing Click on BudgetsByPeriod_EscalateLink...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_EscalateLink = new SeleniumControl( sDriver, "BudgetsByPeriod_EscalateLink", "ID", "lnk_1000754_GLMBDORG_ORGACCTBUD_CTW");
				Function.WaitControlDisplayed(GLMBDORG_BudgetsByPeriod_EscalateLink);
GLMBDORG_BudgetsByPeriod_EscalateLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing VerifyExists on BudgetsByPeriod_Escalate_Escalation_Amount...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_Escalate_Escalation_Amount = new SeleniumControl( sDriver, "BudgetsByPeriod_Escalate_Escalation_Amount", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_ESCALATE_']/ancestor::form[1]/descendant::*[@id='ESC_PCT_AMT']");
				Function.AssertEqual(true,GLMBDORG_BudgetsByPeriod_Escalate_Escalation_Amount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing Close on BudgetsByPeriod_EscalateForm...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_BudgetsByPeriod_EscalateForm = new SeleniumControl( sDriver, "BudgetsByPeriod_EscalateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMBDORG_ORGACCTBUD_ESCALATE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMBDORG_BudgetsByPeriod_EscalateForm);
IWebElement formBttn = GLMBDORG_BudgetsByPeriod_EscalateForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMBDORG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMBDORG] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMBDORG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMBDORG_MainForm);
IWebElement formBttn = GLMBDORG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

