 
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
    public class GLMTAXA_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"View Tax Reporting Status by Tax Account", "xpath","//div[@class='navItem'][.='View Tax Reporting Status by Tax Account']").Click();


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
				Function.CurrentComponent = "GLMTAXA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXA] Performing VerifyExists on TransactionEntitiesForm...", Logger.MessageType.INF);
				SeleniumControl GLMTAXA_TransactionEntitiesForm = new SeleniumControl( sDriver, "TransactionEntitiesForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLMTAXA_TransactionEntitiesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXA] Performing VerifyExists on Account...", Logger.MessageType.INF);
				SeleniumControl GLMTAXA_Account = new SeleniumControl( sDriver, "Account", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,GLMTAXA_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXA] Performing VerifyExists on TransactionEntities_ChildOneForm...", Logger.MessageType.INF);
				SeleniumControl GLMTAXA_TransactionEntities_ChildOneForm = new SeleniumControl( sDriver, "TransactionEntities_ChildOneForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAXA_RPTTAXLNACCT_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMTAXA_TransactionEntities_ChildOneForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXA] Performing VerifyExist on TransactionEntities_ChildOneFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMTAXA_TransactionEntities_ChildOneFormTable = new SeleniumControl( sDriver, "TransactionEntities_ChildOneFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAXA_RPTTAXLNACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMTAXA_TransactionEntities_ChildOneFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXA] Performing VerifyExists on TransactionEntities_ChildTwoForm...", Logger.MessageType.INF);
				SeleniumControl GLMTAXA_TransactionEntities_ChildTwoForm = new SeleniumControl( sDriver, "TransactionEntities_ChildTwoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAX_RPTTAXLN_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMTAXA_TransactionEntities_ChildTwoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXA] Performing VerifyExist on TransactionEntities_ChildTwoFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMTAXA_TransactionEntities_ChildTwoFormTable = new SeleniumControl( sDriver, "TransactionEntities_ChildTwoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAX_RPTTAXLN_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMTAXA_TransactionEntities_ChildTwoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXA] Performing VerifyExists on TransactionEntities_ChildTwo_TaxAccountsLink...", Logger.MessageType.INF);
				SeleniumControl GLMTAXA_TransactionEntities_ChildTwo_TaxAccountsLink = new SeleniumControl( sDriver, "TransactionEntities_ChildTwo_TaxAccountsLink", "ID", "lnk_1003026_GLMTAX_RPTTAXLN_HDR");
				Function.AssertEqual(true,GLMTAXA_TransactionEntities_ChildTwo_TaxAccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXA] Performing Click on TransactionEntities_ChildTwo_TaxAccountsLink...", Logger.MessageType.INF);
				SeleniumControl GLMTAXA_TransactionEntities_ChildTwo_TaxAccountsLink = new SeleniumControl( sDriver, "TransactionEntities_ChildTwo_TaxAccountsLink", "ID", "lnk_1003026_GLMTAX_RPTTAXLN_HDR");
				Function.WaitControlDisplayed(GLMTAXA_TransactionEntities_ChildTwo_TaxAccountsLink);
GLMTAXA_TransactionEntities_ChildTwo_TaxAccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXA] Performing VerifyExists on TransactionEntities_ChildTwo_TaxAccountsForm...", Logger.MessageType.INF);
				SeleniumControl GLMTAXA_TransactionEntities_ChildTwo_TaxAccountsForm = new SeleniumControl( sDriver, "TransactionEntities_ChildTwo_TaxAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAX_RPTTAXLNACCT_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMTAXA_TransactionEntities_ChildTwo_TaxAccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXA] Performing VerifyExist on TransactionEntities_ChildTwo_TaxAccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMTAXA_TransactionEntities_ChildTwo_TaxAccountsFormTable = new SeleniumControl( sDriver, "TransactionEntities_ChildTwo_TaxAccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAX_RPTTAXLNACCT_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMTAXA_TransactionEntities_ChildTwo_TaxAccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXA] Performing Close on TransactionEntities_ChildTwo_TaxAccountsForm...", Logger.MessageType.INF);
				SeleniumControl GLMTAXA_TransactionEntities_ChildTwo_TaxAccountsForm = new SeleniumControl( sDriver, "TransactionEntities_ChildTwo_TaxAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMTAX_RPTTAXLNACCT_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMTAXA_TransactionEntities_ChildTwo_TaxAccountsForm);
IWebElement formBttn = GLMTAXA_TransactionEntities_ChildTwo_TaxAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMTAXA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMTAXA] Performing Close on TransactionEntitiesForm...", Logger.MessageType.INF);
				SeleniumControl GLMTAXA_TransactionEntitiesForm = new SeleniumControl( sDriver, "TransactionEntitiesForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMTAXA_TransactionEntitiesForm);
IWebElement formBttn = GLMTAXA_TransactionEntitiesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

