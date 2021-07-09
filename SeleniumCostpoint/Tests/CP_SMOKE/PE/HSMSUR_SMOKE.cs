 
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
    public class HSMSUR_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Compensation", "xpath","//div[@class='deptItem'][.='Compensation']").Click();
new SeleniumControl(sDriver,"Salary Surveys", "xpath","//div[@class='navItem'][.='Salary Surveys']").Click();
new SeleniumControl(sDriver,"Manage Salary Survey Data", "xpath","//div[@class='navItem'][.='Manage Salary Survey Data']").Click();


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
				Function.CurrentComponent = "HSMSUR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSUR] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMSUR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HSMSUR_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSUR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSUR] Performing VerifyExists on SurveyCompany...", Logger.MessageType.INF);
				SeleniumControl HSMSUR_SurveyCompany = new SeleniumControl( sDriver, "SurveyCompany", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SURVEY_CO_ID']");
				Function.AssertEqual(true,HSMSUR_SurveyCompany.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSUR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSUR] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMSUR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMSUR_MainForm);
IWebElement formBttn = HSMSUR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HSMSUR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HSMSUR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSUR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSUR] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMSUR_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMSUR_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSUR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSUR] Performing VerifyExists on SalaryInformationForm...", Logger.MessageType.INF);
				SeleniumControl HSMSUR_SalaryInformationForm = new SeleniumControl( sDriver, "SalaryInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMSUR_SURVEYSALRANGE_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,HSMSUR_SalaryInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSUR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSUR] Performing VerifyExist on SalaryInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMSUR_SalaryInformationFormTable = new SeleniumControl( sDriver, "SalaryInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMSUR_SURVEYSALRANGE_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMSUR_SalaryInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSUR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSUR] Performing ClickButton on SalaryInformationForm...", Logger.MessageType.INF);
				SeleniumControl HSMSUR_SalaryInformationForm = new SeleniumControl( sDriver, "SalaryInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMSUR_SURVEYSALRANGE_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HSMSUR_SalaryInformationForm);
IWebElement formBttn = HSMSUR_SalaryInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HSMSUR_SalaryInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HSMSUR_SalaryInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSUR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSUR] Performing VerifyExists on SalaryInformation_FunctionalJobTitle...", Logger.MessageType.INF);
				SeleniumControl HSMSUR_SalaryInformation_FunctionalJobTitle = new SeleniumControl( sDriver, "SalaryInformation_FunctionalJobTitle", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMSUR_SURVEYSALRANGE_CTW_']/ancestor::form[1]/descendant::*[@id='FUNC_JOB_CD']");
				Function.AssertEqual(true,HSMSUR_SalaryInformation_FunctionalJobTitle.Exists());

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
				Function.CurrentComponent = "HSMSUR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSUR] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMSUR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMSUR_MainForm);
IWebElement formBttn = HSMSUR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

