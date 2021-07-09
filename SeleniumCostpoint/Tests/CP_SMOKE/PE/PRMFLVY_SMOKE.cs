 
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
    public class PRMFLVY_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Garnishments", "xpath","//div[@class='navItem'][.='Garnishments']").Click();
new SeleniumControl(sDriver,"Manage Federal Tax Levy Exemptions", "xpath","//div[@class='navItem'][.='Manage Federal Tax Levy Exemptions']").Click();


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
				Function.CurrentComponent = "PRMFLVY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFLVY] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMFLVY_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMFLVY_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFLVY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFLVY] Performing VerifyExists on FilingStatus...", Logger.MessageType.INF);
				SeleniumControl PRMFLVY_FilingStatus = new SeleniumControl( sDriver, "FilingStatus", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_LVY_FIL_ST_DESC']");
				Function.AssertEqual(true,PRMFLVY_FilingStatus.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFLVY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFLVY] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMFLVY_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMFLVY_MainForm);
IWebElement formBttn = PRMFLVY_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMFLVY_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMFLVY_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFLVY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFLVY] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMFLVY_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMFLVY_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFLVY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFLVY] Performing VerifyExists on WeeklyExemptionAmountsForm...", Logger.MessageType.INF);
				SeleniumControl PRMFLVY_WeeklyExemptionAmountsForm = new SeleniumControl( sDriver, "WeeklyExemptionAmountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMFLVY_FEDTAXLVYEXEMPT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMFLVY_WeeklyExemptionAmountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFLVY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFLVY] Performing VerifyExist on WeeklyExemptionAmountsFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMFLVY_WeeklyExemptionAmountsFormTable = new SeleniumControl( sDriver, "WeeklyExemptionAmountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMFLVY_FEDTAXLVYEXEMPT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMFLVY_WeeklyExemptionAmountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFLVY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFLVY] Performing ClickButton on WeeklyExemptionAmountsForm...", Logger.MessageType.INF);
				SeleniumControl PRMFLVY_WeeklyExemptionAmountsForm = new SeleniumControl( sDriver, "WeeklyExemptionAmountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMFLVY_FEDTAXLVYEXEMPT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMFLVY_WeeklyExemptionAmountsForm);
IWebElement formBttn = PRMFLVY_WeeklyExemptionAmountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRMFLVY_WeeklyExemptionAmountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRMFLVY_WeeklyExemptionAmountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFLVY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFLVY] Performing VerifyExists on WeeklyExemptionAmounts_EffectiveDate...", Logger.MessageType.INF);
				SeleniumControl PRMFLVY_WeeklyExemptionAmounts_EffectiveDate = new SeleniumControl( sDriver, "WeeklyExemptionAmounts_EffectiveDate", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMFLVY_FEDTAXLVYEXEMPT_CTW_']/ancestor::form[1]/descendant::*[@id='EFFECT_DT']");
				Function.AssertEqual(true,PRMFLVY_WeeklyExemptionAmounts_EffectiveDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PRMFLVY";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFLVY] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMFLVY_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMFLVY_MainForm);
IWebElement formBttn = PRMFLVY_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

