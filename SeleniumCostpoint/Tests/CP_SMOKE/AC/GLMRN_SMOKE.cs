 
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
    public class GLMRN_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Reference Numbers", "xpath","//div[@class='navItem'][.='Reference Numbers']").Click();
new SeleniumControl(sDriver,"Manage Reference Elements", "xpath","//div[@class='navItem'][.='Manage Reference Elements']").Click();


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
				Function.CurrentComponent = "GLMRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRN] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMRN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLMRN_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRN] Performing VerifyExists on ReferenceNo...", Logger.MessageType.INF);
				SeleniumControl GLMRN_ReferenceNo = new SeleniumControl( sDriver, "ReferenceNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='REF_STRUC_ID']");
				Function.AssertEqual(true,GLMRN_ReferenceNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMRN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMRN_MainForm);
IWebElement formBttn = GLMRN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? GLMRN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
GLMRN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRN] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMRN_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMRN_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Link to accounts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRN] Performing VerifyExists on LinkToAcctOrgsLink...", Logger.MessageType.INF);
				SeleniumControl GLMRN_LinkToAcctOrgsLink = new SeleniumControl( sDriver, "LinkToAcctOrgsLink", "ID", "lnk_1000787_GLMRN_REFSTRUC_HDR");
				Function.AssertEqual(true,GLMRN_LinkToAcctOrgsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRN] Performing Click on LinkToAcctOrgsLink...", Logger.MessageType.INF);
				SeleniumControl GLMRN_LinkToAcctOrgsLink = new SeleniumControl( sDriver, "LinkToAcctOrgsLink", "ID", "lnk_1000787_GLMRN_REFSTRUC_HDR");
				Function.WaitControlDisplayed(GLMRN_LinkToAcctOrgsLink);
GLMRN_LinkToAcctOrgsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRN] Performing VerifyExists on LinkToAcctOrgsForm...", Logger.MessageType.INF);
				SeleniumControl GLMRN_LinkToAcctOrgsForm = new SeleniumControl( sDriver, "LinkToAcctOrgsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRN_ORGACCTREFSTRUC_TBL_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMRN_LinkToAcctOrgsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRN] Performing VerifyExist on LinkToAcctOrgsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMRN_LinkToAcctOrgsFormTable = new SeleniumControl( sDriver, "LinkToAcctOrgsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRN_ORGACCTREFSTRUC_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMRN_LinkToAcctOrgsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRN] Performing VerifyExists on LinkToAcctOrgs_Ok...", Logger.MessageType.INF);
				SeleniumControl GLMRN_LinkToAcctOrgs_Ok = new SeleniumControl( sDriver, "LinkToAcctOrgs_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRN_ORGACCTREFSTRUC_TBL_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,GLMRN_LinkToAcctOrgs_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRN] Performing Close on LinkToAcctOrgsForm...", Logger.MessageType.INF);
				SeleniumControl GLMRN_LinkToAcctOrgsForm = new SeleniumControl( sDriver, "LinkToAcctOrgsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMRN_ORGACCTREFSTRUC_TBL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMRN_LinkToAcctOrgsForm);
IWebElement formBttn = GLMRN_LinkToAcctOrgsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMRN] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMRN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMRN_MainForm);
IWebElement formBttn = GLMRN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

