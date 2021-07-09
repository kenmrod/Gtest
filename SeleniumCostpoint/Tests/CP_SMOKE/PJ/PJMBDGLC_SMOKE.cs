 
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
    public class PJMBDGLC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Total Budgets", "xpath","//div[@class='navItem'][.='Total Budgets']").Click();
new SeleniumControl(sDriver,"Manage GLC Total Budget", "xpath","//div[@class='navItem'][.='Manage GLC Total Budget']").Click();


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
				Function.CurrentComponent = "PJMBDGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDGLC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDGLC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMBDGLC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDGLC] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMBDGLC_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMBDGLC_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDGLC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDGLC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBDGLC_MainForm);
IWebElement formBttn = PJMBDGLC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMBDGLC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMBDGLC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDGLC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMBDGLC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBDGLC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("GLC BUDGET DETAILS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDGLC] Performing VerifyExists on GLCBudgetDetailsLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDGLC_GLCBudgetDetailsLink = new SeleniumControl( sDriver, "GLCBudgetDetailsLink", "ID", "lnk_3790_PJMBDGLC_PROJTOTBUDGLC_HDR");
				Function.AssertEqual(true,PJMBDGLC_GLCBudgetDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDGLC] Performing VerifyExist on GLCBudgetDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMBDGLC_GLCBudgetDetailsFormTable = new SeleniumControl( sDriver, "GLCBudgetDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDGLC_PROJTOTBUDGLC_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBDGLC_GLCBudgetDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDGLC] Performing ClickButton on GLCBudgetDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDGLC_GLCBudgetDetailsForm = new SeleniumControl( sDriver, "GLCBudgetDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDGLC_PROJTOTBUDGLC_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDGLC_GLCBudgetDetailsForm);
IWebElement formBttn = PJMBDGLC_GLCBudgetDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBDGLC_GLCBudgetDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBDGLC_GLCBudgetDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDGLC] Performing VerifyExists on GLCBudgetDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDGLC_GLCBudgetDetailsForm = new SeleniumControl( sDriver, "GLCBudgetDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDGLC_PROJTOTBUDGLC_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBDGLC_GLCBudgetDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDGLC] Performing VerifyExists on GLCBudgetDetails_GLC...", Logger.MessageType.INF);
				SeleniumControl PJMBDGLC_GLCBudgetDetails_GLC = new SeleniumControl( sDriver, "GLCBudgetDetails_GLC", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDGLC_PROJTOTBUDGLC_CHILD_']/ancestor::form[1]/descendant::*[@id='GENL_LAB_CAT_CD']");
				Function.AssertEqual(true,PJMBDGLC_GLCBudgetDetails_GLC.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PJMBDGLC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDGLC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDGLC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBDGLC_MainForm);
IWebElement formBttn = PJMBDGLC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

