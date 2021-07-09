 
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
    public class HPMDPOS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Job Titles", "xpath","//div[@class='navItem'][.='Job Titles']").Click();
new SeleniumControl(sDriver,"Manage Detail Position Descriptions", "xpath","//div[@class='navItem'][.='Manage Detail Position Descriptions']").Click();


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
				Function.CurrentComponent = "HPMDPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMDPOS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMDPOS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HPMDPOS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMDPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMDPOS] Performing VerifyExists on DetailJobTitle...", Logger.MessageType.INF);
				SeleniumControl HPMDPOS_DetailJobTitle = new SeleniumControl( sDriver, "DetailJobTitle", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DETL_JOB_CD']");
				Function.AssertEqual(true,HPMDPOS_DetailJobTitle.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMDPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMDPOS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMDPOS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HPMDPOS_MainForm);
IWebElement formBttn = HPMDPOS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HPMDPOS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HPMDPOS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMDPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMDPOS] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMDPOS_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMDPOS_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMDPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMDPOS] Performing VerifyExists on SkillsForm...", Logger.MessageType.INF);
				SeleniumControl HPMDPOS_SkillsForm = new SeleniumControl( sDriver, "SkillsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMDPOS_HDETLSKILL_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,HPMDPOS_SkillsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMDPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMDPOS] Performing VerifyExist on SkillsFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMDPOS_SkillsFormTable = new SeleniumControl( sDriver, "SkillsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMDPOS_HDETLSKILL_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMDPOS_SkillsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMDPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMDPOS] Performing VerifyExists on DegreesForm...", Logger.MessageType.INF);
				SeleniumControl HPMDPOS_DegreesForm = new SeleniumControl( sDriver, "DegreesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMDPOS_HDETLDEGREE_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,HPMDPOS_DegreesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMDPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMDPOS] Performing VerifyExist on DegreesFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMDPOS_DegreesFormTable = new SeleniumControl( sDriver, "DegreesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMDPOS_HDETLDEGREE_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMDPOS_DegreesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "HPMDPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMDPOS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMDPOS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HPMDPOS_MainForm);
IWebElement formBttn = HPMDPOS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

