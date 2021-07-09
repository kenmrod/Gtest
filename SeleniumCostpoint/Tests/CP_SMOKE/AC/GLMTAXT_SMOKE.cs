 
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
    public class GLMTAXT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Sales and Value Added Tax Processing", "xpath","//div[@class='navItem'][.='Sales and Value Added Tax Processing']").Click();
new SeleniumControl(sDriver,"View Tax Reporting Status by Transaction", "xpath","//div[@class='navItem'][.='View Tax Reporting Status by Transaction']").Click();


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
				Function.CurrentComponent = "GLMTAXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXT] Performing VerifyExists on TransactiontypeForm...", Logger.MessageType.INF);
				SeleniumControl GLMTAXT_TransactiontypeForm = new SeleniumControl( sDriver, "TransactiontypeForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLMTAXT_TransactiontypeForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXT] Performing VerifyExists on Output_InvoiceDate_Ending...", Logger.MessageType.INF);
				SeleniumControl GLMTAXT_Output_InvoiceDate_Ending = new SeleniumControl( sDriver, "Output_InvoiceDate_Ending", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='I_END_DATE']");
				Function.AssertEqual(true,GLMTAXT_Output_InvoiceDate_Ending.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXT] Performing VerifyExists on Transactiontype_ChildOneForm...", Logger.MessageType.INF);
				SeleniumControl GLMTAXT_Transactiontype_ChildOneForm = new SeleniumControl( sDriver, "Transactiontype_ChildOneForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAXT_RPTTAXHDR_TBL_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMTAXT_Transactiontype_ChildOneForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXT] Performing VerifyExist on Transactiontype_ChildOneFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMTAXT_Transactiontype_ChildOneFormTable = new SeleniumControl( sDriver, "Transactiontype_ChildOneFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAXT_RPTTAXHDR_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMTAXT_Transactiontype_ChildOneFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXT] Performing VerifyExists on Transactiontype_ChildTwoForm...", Logger.MessageType.INF);
				SeleniumControl GLMTAXT_Transactiontype_ChildTwoForm = new SeleniumControl( sDriver, "Transactiontype_ChildTwoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAX_RPTTAXLN_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMTAXT_Transactiontype_ChildTwoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXT] Performing VerifyExist on Transactiontype_ChildTwoFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMTAXT_Transactiontype_ChildTwoFormTable = new SeleniumControl( sDriver, "Transactiontype_ChildTwoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAX_RPTTAXLN_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMTAXT_Transactiontype_ChildTwoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXT] Performing VerifyExists on Transactiontype_ChildTwo_TaxAccountsLink...", Logger.MessageType.INF);
				SeleniumControl GLMTAXT_Transactiontype_ChildTwo_TaxAccountsLink = new SeleniumControl( sDriver, "Transactiontype_ChildTwo_TaxAccountsLink", "ID", "lnk_1001788_GLMTAX_RPTTAXLN_HDR");
				Function.AssertEqual(true,GLMTAXT_Transactiontype_ChildTwo_TaxAccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXT] Performing Click on Transactiontype_ChildTwo_TaxAccountsLink...", Logger.MessageType.INF);
				SeleniumControl GLMTAXT_Transactiontype_ChildTwo_TaxAccountsLink = new SeleniumControl( sDriver, "Transactiontype_ChildTwo_TaxAccountsLink", "ID", "lnk_1001788_GLMTAX_RPTTAXLN_HDR");
				Function.WaitControlDisplayed(GLMTAXT_Transactiontype_ChildTwo_TaxAccountsLink);
GLMTAXT_Transactiontype_ChildTwo_TaxAccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXT] Performing VerifyExists on Transactiontype_ChildTwo_TaxAccountsForm...", Logger.MessageType.INF);
				SeleniumControl GLMTAXT_Transactiontype_ChildTwo_TaxAccountsForm = new SeleniumControl( sDriver, "Transactiontype_ChildTwo_TaxAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAX_RPTTAXLNACCT_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMTAXT_Transactiontype_ChildTwo_TaxAccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXT] Performing VerifyExist on Transactiontype_ChildTwo_TaxAccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMTAXT_Transactiontype_ChildTwo_TaxAccountsFormTable = new SeleniumControl( sDriver, "Transactiontype_ChildTwo_TaxAccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAX_RPTTAXLNACCT_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMTAXT_Transactiontype_ChildTwo_TaxAccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXT] Performing Close on Transactiontype_ChildTwo_TaxAccountsForm...", Logger.MessageType.INF);
				SeleniumControl GLMTAXT_Transactiontype_ChildTwo_TaxAccountsForm = new SeleniumControl( sDriver, "Transactiontype_ChildTwo_TaxAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAX_RPTTAXLNACCT_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMTAXT_Transactiontype_ChildTwo_TaxAccountsForm);
IWebElement formBttn = GLMTAXT_Transactiontype_ChildTwo_TaxAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXT] Performing Close on TransactiontypeForm...", Logger.MessageType.INF);
				SeleniumControl GLMTAXT_TransactiontypeForm = new SeleniumControl( sDriver, "TransactiontypeForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMTAXT_TransactiontypeForm);
IWebElement formBttn = GLMTAXT_TransactiontypeForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

