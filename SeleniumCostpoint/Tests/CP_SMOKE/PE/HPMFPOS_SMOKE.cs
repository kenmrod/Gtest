 
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
    public class HPMFPOS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Functional Position Descriptions", "xpath","//div[@class='navItem'][.='Manage Functional Position Descriptions']").Click();


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
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HPMFPOS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing VerifyExists on FunctionalJobTitle...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_FunctionalJobTitle = new SeleniumControl( sDriver, "FunctionalJobTitle", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FUNC_JOB_CD']");
				Function.AssertEqual(true,HPMFPOS_FunctionalJobTitle.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HPMFPOS_MainForm);
IWebElement formBttn = HPMFPOS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HPMFPOS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HPMFPOS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMFPOS_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Skills Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing VerifyExists on SkillsLink...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_SkillsLink = new SeleniumControl( sDriver, "SkillsLink", "ID", "lnk_1001836_HPMFPOS_HFUNCPOSDESC_HDR");
				Function.AssertEqual(true,HPMFPOS_SkillsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing Click on SkillsLink...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_SkillsLink = new SeleniumControl( sDriver, "SkillsLink", "ID", "lnk_1001836_HPMFPOS_HFUNCPOSDESC_HDR");
				Function.WaitControlDisplayed(HPMFPOS_SkillsLink);
HPMFPOS_SkillsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing VerifyExists on SkillsForm...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_SkillsForm = new SeleniumControl( sDriver, "SkillsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMFPOS_HFUNCSKILL_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,HPMFPOS_SkillsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing VerifyExist on SkillsFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_SkillsFormTable = new SeleniumControl( sDriver, "SkillsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMFPOS_HFUNCSKILL_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMFPOS_SkillsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing Close on SkillsForm...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_SkillsForm = new SeleniumControl( sDriver, "SkillsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMFPOS_HFUNCSKILL_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMFPOS_SkillsForm);
IWebElement formBttn = HPMFPOS_SkillsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Degrees Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing VerifyExists on DegreesLink...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_DegreesLink = new SeleniumControl( sDriver, "DegreesLink", "ID", "lnk_1001837_HPMFPOS_HFUNCPOSDESC_HDR");
				Function.AssertEqual(true,HPMFPOS_DegreesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing Click on DegreesLink...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_DegreesLink = new SeleniumControl( sDriver, "DegreesLink", "ID", "lnk_1001837_HPMFPOS_HFUNCPOSDESC_HDR");
				Function.WaitControlDisplayed(HPMFPOS_DegreesLink);
HPMFPOS_DegreesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing VerifyExists on DegreesForm...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_DegreesForm = new SeleniumControl( sDriver, "DegreesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMFPOS_HFUNCDEGREE_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,HPMFPOS_DegreesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing VerifyExist on DegreesFormTable...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_DegreesFormTable = new SeleniumControl( sDriver, "DegreesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMFPOS_HFUNCDEGREE_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HPMFPOS_DegreesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing Close on DegreesForm...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_DegreesForm = new SeleniumControl( sDriver, "DegreesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HPMFPOS_HFUNCDEGREE_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HPMFPOS_DegreesForm);
IWebElement formBttn = HPMFPOS_DegreesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "HPMFPOS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMFPOS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMFPOS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HPMFPOS_MainForm);
IWebElement formBttn = HPMFPOS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

