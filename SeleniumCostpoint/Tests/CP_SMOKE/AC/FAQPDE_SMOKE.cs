 
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
    public class FAQPDE_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Fixed Assets", "xpath","//div[@class='deptItem'][.='Fixed Assets']").Click();
new SeleniumControl(sDriver,"Projections", "xpath","//div[@class='navItem'][.='Projections']").Click();
new SeleniumControl(sDriver,"View Projected Depreciation Expense", "xpath","//div[@class='navItem'][.='View Projected Depreciation Expense']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAQPDE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAQPDE] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAQPDE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,FAQPDE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAQPDE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAQPDE] Performing VerifyExists on BookNumber...", Logger.MessageType.INF);
				SeleniumControl FAQPDE_BookNumber = new SeleniumControl( sDriver, "BookNumber", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BOOK_NO']");
				Function.AssertEqual(true,FAQPDE_BookNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAQPDE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAQPDE] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl FAQPDE_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[starts-with(@id,'pr__FAQPDE_VFAFAQPDE3_CTW_')]/ancestor::form[1]");
				Function.AssertEqual(true,FAQPDE_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAQPDE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAQPDE] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl FAQPDE_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[starts-with(@id,'pr__FAQPDE_VFAFAQPDE3_CTW_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAQPDE_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAQPDE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAQPDE] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl FAQPDE_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[starts-with(@id,'pr__FAQPDE_VFAFAQPDE3_CTW_')]/ancestor::form[1]");
				Function.AssertEqual(true,FAQPDE_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAQPDE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAQPDE] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl FAQPDE_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[starts-with(@id,'pr__FAQPDE_VFAFAQPDE3_CTW_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(FAQPDE_ChildForm);
IWebElement formBttn = FAQPDE_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? FAQPDE_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
FAQPDE_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAQPDE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAQPDE] Performing VerifyExists on ChildForm_DepreciationExpenseInformation_BookNo...", Logger.MessageType.INF);
				SeleniumControl FAQPDE_ChildForm_DepreciationExpenseInformation_BookNo = new SeleniumControl( sDriver, "ChildForm_DepreciationExpenseInformation_BookNo", "xpath", "//div[starts-with(@id,'pr__FAQPDE_VFAFAQPDE3_CTW_')]/ancestor::form[1]");
				Function.AssertEqual(true,FAQPDE_ChildForm_DepreciationExpenseInformation_BookNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAQPDE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAQPDE] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAQPDE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAQPDE_MainForm);
IWebElement formBttn = FAQPDE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

