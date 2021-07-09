 
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
    public class IWMEXPMP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Inter-Company Work Orders", "xpath","//div[@class='deptItem'][.='Inter-Company Work Orders']").Click();
new SeleniumControl(sDriver,"Inter-Company Work Orders Processing", "xpath","//div[@class='navItem'][.='Inter-Company Work Orders Processing']").Click();
new SeleniumControl(sDriver,"Manage IWO Expense Mappings", "xpath","//div[@class='navItem'][.='Manage IWO Expense Mappings']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(IWMEXPMP_MainForm);
IWebElement formBttn = IWMEXPMP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? IWMEXPMP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
IWMEXPMP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitControlDisplayed(new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel"));
Function.AssertEqual("Manage IWO Expense Mappings", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
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
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,IWMEXPMP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(IWMEXPMP_MainForm);
IWebElement formBttn = IWMEXPMP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? IWMEXPMP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
IWMEXPMP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,IWMEXPMP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing VerifyExists on ExpenseMappingCode...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_ExpenseMappingCode = new SeleniumControl( sDriver, "ExpenseMappingCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='IWO_EXP_MAP_CD']");
				Function.AssertEqual(true,IWMEXPMP_ExpenseMappingCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POSTING ACCOUNT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing VerifyExists on PostingAccountLink...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_PostingAccountLink = new SeleniumControl( sDriver, "PostingAccountLink", "ID", "lnk_1002328_IWMEXPMP_IWOEXPMAPPING_HDR");
				Function.AssertEqual(true,IWMEXPMP_PostingAccountLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing VerifyExists on PostingAccountForm...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_PostingAccountForm = new SeleniumControl( sDriver, "PostingAccountForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMEXPMP_IWOEXPACCT_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,IWMEXPMP_PostingAccountForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing VerifyExists on PostingAccount_Ok...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_PostingAccount_Ok = new SeleniumControl( sDriver, "PostingAccount_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMEXPMP_IWOEXPACCT_CHLD_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,IWMEXPMP_PostingAccount_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing VerifyExist on PostingAccountFormTable...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_PostingAccountFormTable = new SeleniumControl( sDriver, "PostingAccountFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMEXPMP_IWOEXPACCT_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,IWMEXPMP_PostingAccountFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINK EXPENSES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing VerifyExists on PostingAccount_LinkExpensesLink...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_PostingAccount_LinkExpensesLink = new SeleniumControl( sDriver, "PostingAccount_LinkExpensesLink", "ID", "lnk_3757_IWMEXPMP_IWOEXPACCT_CHLD");
				Function.AssertEqual(true,IWMEXPMP_PostingAccount_LinkExpensesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing Click on PostingAccount_LinkExpensesLink...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_PostingAccount_LinkExpensesLink = new SeleniumControl( sDriver, "PostingAccount_LinkExpensesLink", "ID", "lnk_3757_IWMEXPMP_IWOEXPACCT_CHLD");
				Function.WaitControlDisplayed(IWMEXPMP_PostingAccount_LinkExpensesLink);
IWMEXPMP_PostingAccount_LinkExpensesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing VerifyExist on PostingAccount_LinkExpensesFormTable...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_PostingAccount_LinkExpensesFormTable = new SeleniumControl( sDriver, "PostingAccount_LinkExpensesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMEXPMP_IWOEXPACCTLN_EXPENSE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,IWMEXPMP_PostingAccount_LinkExpensesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing ClickButton on PostingAccount_LinkExpensesForm...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_PostingAccount_LinkExpensesForm = new SeleniumControl( sDriver, "PostingAccount_LinkExpensesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMEXPMP_IWOEXPACCTLN_EXPENSE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(IWMEXPMP_PostingAccount_LinkExpensesForm);
IWebElement formBttn = IWMEXPMP_PostingAccount_LinkExpensesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? IWMEXPMP_PostingAccount_LinkExpensesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
IWMEXPMP_PostingAccount_LinkExpensesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing VerifyExists on PostingAccount_LinkExpenses_Account...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_PostingAccount_LinkExpenses_Account = new SeleniumControl( sDriver, "PostingAccount_LinkExpenses_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMEXPMP_IWOEXPACCTLN_EXPENSE_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,IWMEXPMP_PostingAccount_LinkExpenses_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing VerifyExists on PostingAccount_LinkExpensesForm...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_PostingAccount_LinkExpensesForm = new SeleniumControl( sDriver, "PostingAccount_LinkExpensesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMEXPMP_IWOEXPACCTLN_EXPENSE_']/ancestor::form[1]");
				Function.AssertEqual(true,IWMEXPMP_PostingAccount_LinkExpensesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing Close on PostingAccount_LinkExpensesForm...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_PostingAccount_LinkExpensesForm = new SeleniumControl( sDriver, "PostingAccount_LinkExpensesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMEXPMP_IWOEXPACCTLN_EXPENSE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(IWMEXPMP_PostingAccount_LinkExpensesForm);
IWebElement formBttn = IWMEXPMP_PostingAccount_LinkExpensesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "IWMEXPMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMEXPMP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl IWMEXPMP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(IWMEXPMP_MainForm);
IWebElement formBttn = IWMEXPMP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

