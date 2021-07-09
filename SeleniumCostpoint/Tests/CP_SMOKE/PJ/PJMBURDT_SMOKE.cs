 
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
    public class PJMBURDT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Advanced Project Budgeting", "xpath","//div[@class='deptItem'][.='Advanced Project Budgeting']").Click();
new SeleniumControl(sDriver,"Burden Templates", "xpath","//div[@class='navItem'][.='Burden Templates']").Click();
new SeleniumControl(sDriver,"Manage Burden Templates", "xpath","//div[@class='navItem'][.='Manage Burden Templates']").Click();


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
				Function.CurrentComponent = "PJMBURDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBURDT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBURDT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMBURDT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBURDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBURDT] Performing VerifyExists on MainForm_Template...", Logger.MessageType.INF);
				SeleniumControl PJMBURDT_MainForm_Template = new SeleniumControl( sDriver, "MainForm_Template", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TEMP_ID']");
				Function.AssertEqual(true,PJMBURDT_MainForm_Template.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBURDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBURDT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBURDT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBURDT_MainForm);
IWebElement formBttn = PJMBURDT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMBURDT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMBURDT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBURDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBURDT] Performing VerifyExist on MainForm_Table...", Logger.MessageType.INF);
				SeleniumControl PJMBURDT_MainForm_Table = new SeleniumControl( sDriver, "MainForm_Table", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBURDT_MainForm_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILD FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBURDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBURDT] Performing Close on BurdenDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBURDT_BurdenDetailsForm = new SeleniumControl( sDriver, "BurdenDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBURDT_BURDTEMP_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBURDT_BurdenDetailsForm);
IWebElement formBttn = PJMBURDT_BurdenDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBURDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBURDT] Performing VerifyExists on MainForm_BurdenTemplatesDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJMBURDT_MainForm_BurdenTemplatesDetailLink = new SeleniumControl( sDriver, "MainForm_BurdenTemplatesDetailLink", "ID", "lnk_1002341_PJMBURDT_BURDTEMP");
				Function.AssertEqual(true,PJMBURDT_MainForm_BurdenTemplatesDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBURDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBURDT] Performing Click on MainForm_BurdenTemplatesDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJMBURDT_MainForm_BurdenTemplatesDetailLink = new SeleniumControl( sDriver, "MainForm_BurdenTemplatesDetailLink", "ID", "lnk_1002341_PJMBURDT_BURDTEMP");
				Function.WaitControlDisplayed(PJMBURDT_MainForm_BurdenTemplatesDetailLink);
PJMBURDT_MainForm_BurdenTemplatesDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBURDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBURDT] Performing VerifyExist on BurdenTemplatesDetail_Table...", Logger.MessageType.INF);
				SeleniumControl PJMBURDT_BurdenTemplatesDetail_Table = new SeleniumControl( sDriver, "BurdenTemplatesDetail_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBURDT_BURDTEMP_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBURDT_BurdenTemplatesDetail_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBURDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBURDT] Performing ClickButton on BurdenDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBURDT_BurdenDetailsForm = new SeleniumControl( sDriver, "BurdenDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBURDT_BURDTEMP_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBURDT_BurdenDetailsForm);
IWebElement formBttn = PJMBURDT_BurdenDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBURDT_BurdenDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBURDT_BurdenDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBURDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBURDT] Performing VerifyExists on BurdenDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMBURDT_BurdenDetailsForm = new SeleniumControl( sDriver, "BurdenDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBURDT_BURDTEMP_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBURDT_BurdenDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBURDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBURDT] Performing VerifyExists on BurdenDetails_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJMBURDT_BurdenDetails_FiscalYear = new SeleniumControl( sDriver, "BurdenDetails_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBURDT_BURDTEMP_CHLD_']/ancestor::form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,PJMBURDT_BurdenDetails_FiscalYear.Exists());

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
				Function.CurrentComponent = "PJMBURDT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBURDT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBURDT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBURDT_MainForm);
IWebElement formBttn = PJMBURDT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

