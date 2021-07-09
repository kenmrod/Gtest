 
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
    public class HBMEBELC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Employee", "xpath","//div[@class='deptItem'][.='Employee']").Click();
new SeleniumControl(sDriver,"Employee Benefit Information", "xpath","//div[@class='navItem'][.='Employee Benefit Information']").Click();
new SeleniumControl(sDriver,"Manage Employee Benefit Elections", "xpath","//div[@class='navItem'][.='Manage Employee Benefit Elections']").Click();


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
				Function.CurrentComponent = "HBMEBELC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEBELC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMEBELC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HBMEBELC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEBELC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEBELC] Performing VerifyExists on BenefitPackage...", Logger.MessageType.INF);
				SeleniumControl HBMEBELC_BenefitPackage = new SeleniumControl( sDriver, "BenefitPackage", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BEN_PKG_CD']");
				Function.AssertEqual(true,HBMEBELC_BenefitPackage.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Table");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEBELC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEBELC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMEBELC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMEBELC_MainForm);
IWebElement formBttn = HBMEBELC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HBMEBELC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HBMEBELC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEBELC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEBELC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HBMEBELC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMEBELC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Benefit Elections Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEBELC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEBELC] Performing VerifyExists on BenefitElectionsDetailForm...", Logger.MessageType.INF);
				SeleniumControl HBMEBELC_BenefitElectionsDetailForm = new SeleniumControl( sDriver, "BenefitElectionsDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMEBELC_HBEMPLPKGELEC_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,HBMEBELC_BenefitElectionsDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEBELC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEBELC] Performing VerifyExist on BenefitElectionsDetailTable...", Logger.MessageType.INF);
				SeleniumControl HBMEBELC_BenefitElectionsDetailTable = new SeleniumControl( sDriver, "BenefitElectionsDetailTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMEBELC_HBEMPLPKGELEC_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMEBELC_BenefitElectionsDetailTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEBELC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEBELC] Performing ClickButton on BenefitElectionsDetailForm...", Logger.MessageType.INF);
				SeleniumControl HBMEBELC_BenefitElectionsDetailForm = new SeleniumControl( sDriver, "BenefitElectionsDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMEBELC_HBEMPLPKGELEC_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HBMEBELC_BenefitElectionsDetailForm);
IWebElement formBttn = HBMEBELC_BenefitElectionsDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HBMEBELC_BenefitElectionsDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HBMEBELC_BenefitElectionsDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEBELC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEBELC] Performing VerifyExists on BenefitElectionsDetails_BenefitPlan...", Logger.MessageType.INF);
				SeleniumControl HBMEBELC_BenefitElectionsDetails_BenefitPlan = new SeleniumControl( sDriver, "BenefitElectionsDetails_BenefitPlan", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMEBELC_HBEMPLPKGELEC_CTW_']/ancestor::form[1]/descendant::*[@id='BEN_PLAN_CD']");
				Function.AssertEqual(true,HBMEBELC_BenefitElectionsDetails_BenefitPlan.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close Application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEBELC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEBELC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMEBELC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMEBELC_MainForm);
IWebElement formBttn = HBMEBELC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

