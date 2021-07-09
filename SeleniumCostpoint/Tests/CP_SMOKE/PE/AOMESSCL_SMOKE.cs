 
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
    public class AOMESSCL_SMOKE : SeleniumTestScript
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

				this.ScriptLogger.WriteLine("[CP7Main] Performing Set on SearchApplications...", Logger.MessageType.INF);
				SeleniumControl CP7Main_SearchApplications = new SeleniumControl( sDriver, "SearchApplications", "ID", "appFltrFld");
				CP7Main_SearchApplications.Click();
CP7Main_SearchApplications.SendKeys("AOMESSCL", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
CP7Main_SearchApplications.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try
				{
				Function.SendKeys("Down");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SendKeys]" , ex.Message));
				}
								try
				{
				Function.SendKeys("Enter");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SendKeys]" , ex.Message));
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
				Function.CurrentComponent = "AOMESSCL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSCL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,AOMESSCL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCL] Performing VerifyExists on TaxableEntity...", Logger.MessageType.INF);
				SeleniumControl AOMESSCL_TaxableEntity = new SeleniumControl( sDriver, "TaxableEntity", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TAXBLE_ENTITY']");
				Function.AssertEqual(true,AOMESSCL_TaxableEntity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCL] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSCL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMESSCL_MainForm);
IWebElement formBttn = AOMESSCL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? AOMESSCL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
AOMESSCL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCL] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMESSCL_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMESSCL_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("COMPANY LINKS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCL] Performing VerifyExist on CompanyLinksFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMESSCL_CompanyLinksFormTable = new SeleniumControl( sDriver, "CompanyLinksFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSCL_ESS_COMP_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMESSCL_CompanyLinksFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCL] Performing ClickButton on CompanyLinksForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSCL_CompanyLinksForm = new SeleniumControl( sDriver, "CompanyLinksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSCL_ESS_COMP_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMESSCL_CompanyLinksForm);
IWebElement formBttn = AOMESSCL_CompanyLinksForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? AOMESSCL_CompanyLinksForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
AOMESSCL_CompanyLinksForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCL] Performing VerifyExists on CompanyLinksForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSCL_CompanyLinksForm = new SeleniumControl( sDriver, "CompanyLinksForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSCL_ESS_COMP_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,AOMESSCL_CompanyLinksForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCL] Performing VerifyExists on CompanyLinks_Order...", Logger.MessageType.INF);
				SeleniumControl AOMESSCL_CompanyLinks_Order = new SeleniumControl( sDriver, "CompanyLinks_Order", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSCL_ESS_COMP_CHILD_']/ancestor::form[1]/descendant::*[@id='LINK_ORDER']");
				Function.AssertEqual(true,AOMESSCL_CompanyLinks_Order.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "AOMESSCL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSCL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMESSCL_MainForm);
IWebElement formBttn = AOMESSCL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

