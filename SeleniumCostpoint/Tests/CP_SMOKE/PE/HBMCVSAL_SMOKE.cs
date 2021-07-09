 
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
    public class HBMCVSAL_SMOKE : SeleniumTestScript
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
								try
				{
				this.ScriptLogger.WriteLine("START");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Benefits", "xpath","//div[@class='deptItem'][.='Benefits']").Click();
new SeleniumControl(sDriver,"Benefit Controls", "xpath","//div[@class='navItem'][.='Benefit Controls']").Click();
new SeleniumControl(sDriver,"Manage Coverage Amounts by Salary", "xpath","//div[@class='navItem'][.='Manage Coverage Amounts by Salary']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMCVSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMCVSAL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMCVSAL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HBMCVSAL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMCVSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMCVSAL] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMCVSAL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMCVSAL_MainForm);
IWebElement formBttn = HBMCVSAL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HBMCVSAL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HBMCVSAL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMCVSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMCVSAL] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HBMCVSAL_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMCVSAL_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMCVSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMCVSAL] Performing Click on CoverageAmountsBySalaryLink...", Logger.MessageType.INF);
				SeleniumControl HBMCVSAL_CoverageAmountsBySalaryLink = new SeleniumControl( sDriver, "CoverageAmountsBySalaryLink", "ID", "lnk_4022_HBMCVSAL_HBSALCVG_HDR");
				Function.WaitControlDisplayed(HBMCVSAL_CoverageAmountsBySalaryLink);
HBMCVSAL_CoverageAmountsBySalaryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMCVSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMCVSAL] Performing VerifyExists on CoverageAmountsBySalaryForm...", Logger.MessageType.INF);
				SeleniumControl HBMCVSAL_CoverageAmountsBySalaryForm = new SeleniumControl( sDriver, "CoverageAmountsBySalaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMCVSAL_HBSALCVGSCH_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,HBMCVSAL_CoverageAmountsBySalaryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMCVSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMCVSAL] Performing VerifyExist on CoverageAmountsBySalaryFormTable...", Logger.MessageType.INF);
				SeleniumControl HBMCVSAL_CoverageAmountsBySalaryFormTable = new SeleniumControl( sDriver, "CoverageAmountsBySalaryFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMCVSAL_HBSALCVGSCH_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMCVSAL_CoverageAmountsBySalaryFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMCVSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMCVSAL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMCVSAL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMCVSAL_MainForm);
IWebElement formBttn = HBMCVSAL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

