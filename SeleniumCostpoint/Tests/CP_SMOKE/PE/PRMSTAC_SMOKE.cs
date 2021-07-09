 
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
    public class PRMSTAC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"State Taxes", "xpath","//div[@class='navItem'][.='State Taxes']").Click();
new SeleniumControl(sDriver,"Manage State Tax Withholding Adjustments", "xpath","//div[@class='navItem'][.='Manage State Tax Withholding Adjustments']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
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
				Function.CurrentComponent = "PRMSTAC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTAC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMSTAC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMSTAC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTAC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTAC] Performing VerifyExists on State...", Logger.MessageType.INF);
				SeleniumControl PRMSTAC_State = new SeleniumControl( sDriver, "State", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='STATE_CD']");
				Function.AssertEqual(true,PRMSTAC_State.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTAC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTAC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMSTAC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMSTAC_MainForm);
IWebElement formBttn = PRMSTAC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMSTAC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMSTAC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTAC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTAC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMSTAC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMSTAC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TaxAllowancesAndCredits Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTAC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTAC] Performing VerifyExists on TaxAllowancesAndCreditsForm...", Logger.MessageType.INF);
				SeleniumControl PRMSTAC_TaxAllowancesAndCreditsForm = new SeleniumControl( sDriver, "TaxAllowancesAndCreditsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSTAC_STATETAXALLCR_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMSTAC_TaxAllowancesAndCreditsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTAC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTAC] Performing VerifyExist on TaxAllowancesAndCreditsTable...", Logger.MessageType.INF);
				SeleniumControl PRMSTAC_TaxAllowancesAndCreditsTable = new SeleniumControl( sDriver, "TaxAllowancesAndCreditsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSTAC_STATETAXALLCR_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMSTAC_TaxAllowancesAndCreditsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTAC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTAC] Performing ClickButton on TaxAllowancesAndCreditsForm...", Logger.MessageType.INF);
				SeleniumControl PRMSTAC_TaxAllowancesAndCreditsForm = new SeleniumControl( sDriver, "TaxAllowancesAndCreditsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSTAC_STATETAXALLCR_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMSTAC_TaxAllowancesAndCreditsForm);
IWebElement formBttn = PRMSTAC_TaxAllowancesAndCreditsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRMSTAC_TaxAllowancesAndCreditsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRMSTAC_TaxAllowancesAndCreditsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTAC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTAC] Performing VerifyExists on TaxAllowancesAndCredits_ForAnnualizedWageOver...", Logger.MessageType.INF);
				SeleniumControl PRMSTAC_TaxAllowancesAndCredits_ForAnnualizedWageOver = new SeleniumControl( sDriver, "TaxAllowancesAndCredits_ForAnnualizedWageOver", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSTAC_STATETAXALLCR_CTW_']/ancestor::form[1]/descendant::*[@id='GROSS_WGE_AMT']");
				Function.AssertEqual(true,PRMSTAC_TaxAllowancesAndCredits_ForAnnualizedWageOver.Exists());

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
				Function.CurrentComponent = "PRMSTAC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTAC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMSTAC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMSTAC_MainForm);
IWebElement formBttn = PRMSTAC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

