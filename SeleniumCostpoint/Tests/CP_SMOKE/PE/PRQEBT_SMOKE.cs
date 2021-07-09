 
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
    public class PRQEBT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Payroll", "xpath","//div[@class='deptItem'][.='Payroll']").Click();
new SeleniumControl(sDriver,"Payroll Reports/Inquiries", "xpath","//div[@class='navItem'][.='Payroll Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Bank Information", "xpath","//div[@class='navItem'][.='View Bank Information']").Click();


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
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRQEBT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing VerifyExists on Identification_Employee...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_Identification_Employee = new SeleniumControl( sDriver, "Identification_Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PRQEBT_Identification_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Employee Bank Header Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing VerifyExists on EmployeeBankHeaderForm...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeaderForm = new SeleniumControl( sDriver, "EmployeeBankHeaderForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKHDRADT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQEBT_EmployeeBankHeaderForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing VerifyExist on EmployeeBankHeaderFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeaderFormTable = new SeleniumControl( sDriver, "EmployeeBankHeaderFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKHDRADT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQEBT_EmployeeBankHeaderFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing ClickButton on EmployeeBankHeaderForm...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeaderForm = new SeleniumControl( sDriver, "EmployeeBankHeaderForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKHDRADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQEBT_EmployeeBankHeaderForm);
IWebElement formBttn = PRQEBT_EmployeeBankHeaderForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQEBT_EmployeeBankHeaderForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQEBT_EmployeeBankHeaderForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing VerifyExists on EmployeeBankHeader_Transaction_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_Transaction_TransactionType = new SeleniumControl( sDriver, "EmployeeBankHeader_Transaction_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKHDRADT_CTW_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQEBT_EmployeeBankHeader_Transaction_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				this.ScriptLogger.WriteLine("Active Bank Acct Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing VerifyExists on EmployeeBankHeader_ActiveBankAcctLink...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_ActiveBankAcctLink = new SeleniumControl( sDriver, "EmployeeBankHeader_ActiveBankAcctLink", "ID", "lnk_5472_PRQEBT_EMPLBANKHDRADT_CTW");
				Function.AssertEqual(true,PRQEBT_EmployeeBankHeader_ActiveBankAcctLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing Click on EmployeeBankHeader_ActiveBankAcctLink...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_ActiveBankAcctLink = new SeleniumControl( sDriver, "EmployeeBankHeader_ActiveBankAcctLink", "ID", "lnk_5472_PRQEBT_EMPLBANKHDRADT_CTW");
				Function.WaitControlDisplayed(PRQEBT_EmployeeBankHeader_ActiveBankAcctLink);
PRQEBT_EmployeeBankHeader_ActiveBankAcctLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing VerifyExists on EmployeeBankHeader_ActiveBankAccountsForm...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_ActiveBankAccountsForm = new SeleniumControl( sDriver, "EmployeeBankHeader_ActiveBankAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKLNADT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQEBT_EmployeeBankHeader_ActiveBankAccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing VerifyExist on EmployeeBankHeader_ActiveBankAccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_ActiveBankAccountsFormTable = new SeleniumControl( sDriver, "EmployeeBankHeader_ActiveBankAccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKLNADT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQEBT_EmployeeBankHeader_ActiveBankAccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing ClickButton on EmployeeBankHeader_ActiveBankAccountsForm...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_ActiveBankAccountsForm = new SeleniumControl( sDriver, "EmployeeBankHeader_ActiveBankAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKLNADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQEBT_EmployeeBankHeader_ActiveBankAccountsForm);
IWebElement formBttn = PRQEBT_EmployeeBankHeader_ActiveBankAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQEBT_EmployeeBankHeader_ActiveBankAccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQEBT_EmployeeBankHeader_ActiveBankAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing VerifyExists on EmployeeBankHeader_ActiveBankAccounts_Transaction_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_ActiveBankAccounts_Transaction_TransactionType = new SeleniumControl( sDriver, "EmployeeBankHeader_ActiveBankAccounts_Transaction_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKLNADT_CTW_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQEBT_EmployeeBankHeader_ActiveBankAccounts_Transaction_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing Close on EmployeeBankHeader_ActiveBankAccountsForm...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_ActiveBankAccountsForm = new SeleniumControl( sDriver, "EmployeeBankHeader_ActiveBankAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKLNADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQEBT_EmployeeBankHeader_ActiveBankAccountsForm);
IWebElement formBttn = PRQEBT_EmployeeBankHeader_ActiveBankAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Pending Bank Acct Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing VerifyExists on EmployeeBankHeader_PendingBankAcctLink...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_PendingBankAcctLink = new SeleniumControl( sDriver, "EmployeeBankHeader_PendingBankAcctLink", "ID", "lnk_5473_PRQEBT_EMPLBANKHDRADT_CTW");
				Function.AssertEqual(true,PRQEBT_EmployeeBankHeader_PendingBankAcctLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing Click on EmployeeBankHeader_PendingBankAcctLink...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_PendingBankAcctLink = new SeleniumControl( sDriver, "EmployeeBankHeader_PendingBankAcctLink", "ID", "lnk_5473_PRQEBT_EMPLBANKHDRADT_CTW");
				Function.WaitControlDisplayed(PRQEBT_EmployeeBankHeader_PendingBankAcctLink);
PRQEBT_EmployeeBankHeader_PendingBankAcctLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing VerifyExists on EmployeeBankHeader_PendingBankAccountsForm...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_PendingBankAccountsForm = new SeleniumControl( sDriver, "EmployeeBankHeader_PendingBankAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKPENDADT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQEBT_EmployeeBankHeader_PendingBankAccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing VerifyExist on EmployeeBankHeader_PendingBankAccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_PendingBankAccountsFormTable = new SeleniumControl( sDriver, "EmployeeBankHeader_PendingBankAccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKPENDADT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQEBT_EmployeeBankHeader_PendingBankAccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing ClickButton on EmployeeBankHeader_PendingBankAccountsForm...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_PendingBankAccountsForm = new SeleniumControl( sDriver, "EmployeeBankHeader_PendingBankAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKPENDADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQEBT_EmployeeBankHeader_PendingBankAccountsForm);
IWebElement formBttn = PRQEBT_EmployeeBankHeader_PendingBankAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQEBT_EmployeeBankHeader_PendingBankAccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQEBT_EmployeeBankHeader_PendingBankAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing VerifyExists on EmployeeBankHeader_PendingBankAccounts_Transaction_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_PendingBankAccounts_Transaction_TransactionType = new SeleniumControl( sDriver, "EmployeeBankHeader_PendingBankAccounts_Transaction_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKPENDADT_CTW_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQEBT_EmployeeBankHeader_PendingBankAccounts_Transaction_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing Close on EmployeeBankHeader_PendingBankAccountsForm...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_EmployeeBankHeader_PendingBankAccountsForm = new SeleniumControl( sDriver, "EmployeeBankHeader_PendingBankAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEBT_EMPLBANKPENDADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQEBT_EmployeeBankHeader_PendingBankAccountsForm);
IWebElement formBttn = PRQEBT_EmployeeBankHeader_PendingBankAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRQEBT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEBT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRQEBT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRQEBT_MainForm);
IWebElement formBttn = PRQEBT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

