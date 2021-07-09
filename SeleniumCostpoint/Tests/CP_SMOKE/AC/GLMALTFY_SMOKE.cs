 
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
    public class GLMALTFY_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Company Calendar", "xpath","//div[@class='navItem'][.='Company Calendar']").Click();
new SeleniumControl(sDriver,"Manage Alternate Fiscal Year Mapping", "xpath","//div[@class='navItem'][.='Manage Alternate Fiscal Year Mapping']").Click();


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
				Function.CurrentComponent = "GLMALTFY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMALTFY] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMALTFY_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLMALTFY_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMALTFY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMALTFY] Performing VerifyExists on AlternateFiscalYear...", Logger.MessageType.INF);
				SeleniumControl GLMALTFY_AlternateFiscalYear = new SeleniumControl( sDriver, "AlternateFiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ALT_FY_CD']");
				Function.AssertEqual(true,GLMALTFY_AlternateFiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMALTFY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMALTFY] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMALTFY_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMALTFY_MainForm);
IWebElement formBttn = GLMALTFY_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? GLMALTFY_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
GLMALTFY_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMALTFY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMALTFY] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMALTFY_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMALTFY_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMALTFY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMALTFY] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl GLMALTFY_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMALTFY_FYPDSUBPD_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMALTFY_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMALTFY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMALTFY] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMALTFY_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMALTFY_FYPDSUBPD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMALTFY_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMALTFY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMALTFY] Performing VerifyExists on AlternateFYBeginningBalancesLink...", Logger.MessageType.INF);
				SeleniumControl GLMALTFY_AlternateFYBeginningBalancesLink = new SeleniumControl( sDriver, "AlternateFYBeginningBalancesLink", "ID", "lnk_16852_GLMALTFY_FY");
				Function.AssertEqual(true,GLMALTFY_AlternateFYBeginningBalancesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMALTFY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMALTFY] Performing Click on AlternateFYBeginningBalancesLink...", Logger.MessageType.INF);
				SeleniumControl GLMALTFY_AlternateFYBeginningBalancesLink = new SeleniumControl( sDriver, "AlternateFYBeginningBalancesLink", "ID", "lnk_16852_GLMALTFY_FY");
				Function.WaitControlDisplayed(GLMALTFY_AlternateFYBeginningBalancesLink);
GLMALTFY_AlternateFYBeginningBalancesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMALTFY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMALTFY] Performing VerifyExists on AlternateFYBeginningBalancesForm...", Logger.MessageType.INF);
				SeleniumControl GLMALTFY_AlternateFYBeginningBalancesForm = new SeleniumControl( sDriver, "AlternateFYBeginningBalancesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMALTFY_BEGBAL_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMALTFY_AlternateFYBeginningBalancesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMALTFY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMALTFY] Performing VerifyExist on AlternateFYBeginningBalancesFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMALTFY_AlternateFYBeginningBalancesFormTable = new SeleniumControl( sDriver, "AlternateFYBeginningBalancesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMALTFY_BEGBAL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMALTFY_AlternateFYBeginningBalancesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMALTFY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMALTFY] Performing Close on AlternateFYBeginningBalancesForm...", Logger.MessageType.INF);
				SeleniumControl GLMALTFY_AlternateFYBeginningBalancesForm = new SeleniumControl( sDriver, "AlternateFYBeginningBalancesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMALTFY_BEGBAL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMALTFY_AlternateFYBeginningBalancesForm);
IWebElement formBttn = GLMALTFY_AlternateFYBeginningBalancesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMALTFY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMALTFY] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMALTFY_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMALTFY_MainForm);
IWebElement formBttn = GLMALTFY_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

