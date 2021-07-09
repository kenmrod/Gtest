 
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
    public class HSMCPSAL_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Compensation Plans", "xpath","//div[@class='navItem'][.='Compensation Plans']").Click();
new SeleniumControl(sDriver,"Manage Compensation Plan Salary Ranges", "xpath","//div[@class='navItem'][.='Manage Compensation Plan Salary Ranges']").Click();


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
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HSMCPSAL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing VerifyExists on CompensationPlan...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_CompensationPlan = new SeleniumControl( sDriver, "CompensationPlan", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='COMP_PLAN_CD']");
				Function.AssertEqual(true,HSMCPSAL_CompensationPlan.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMCPSAL_MainForm);
IWebElement formBttn = HSMCPSAL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HSMCPSAL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HSMCPSAL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMCPSAL_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing VerifyExists on AutoFillPercentCriteria_SalaryRangesLink...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_AutoFillPercentCriteria_SalaryRangesLink = new SeleniumControl( sDriver, "AutoFillPercentCriteria_SalaryRangesLink", "ID", "lnk_1000673_HSMCPSAL_COMPPLANHRD_HDR");
				Function.AssertEqual(true,HSMCPSAL_AutoFillPercentCriteria_SalaryRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing Click on AutoFillPercentCriteria_SalaryRangesLink...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_AutoFillPercentCriteria_SalaryRangesLink = new SeleniumControl( sDriver, "AutoFillPercentCriteria_SalaryRangesLink", "ID", "lnk_1000673_HSMCPSAL_COMPPLANHRD_HDR");
				Function.WaitControlDisplayed(HSMCPSAL_AutoFillPercentCriteria_SalaryRangesLink);
HSMCPSAL_AutoFillPercentCriteria_SalaryRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing VerifyExist on SalaryRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_SalaryRangesFormTable = new SeleniumControl( sDriver, "SalaryRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMCPSAL_COMPLANLN_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMCPSAL_SalaryRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing ClickButton on SalaryRangesForm...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_SalaryRangesForm = new SeleniumControl( sDriver, "SalaryRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMCPSAL_COMPLANLN_TBL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HSMCPSAL_SalaryRangesForm);
IWebElement formBttn = HSMCPSAL_SalaryRangesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HSMCPSAL_SalaryRangesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HSMCPSAL_SalaryRangesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing VerifyExists on SalaryRanges_GradeStep...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_SalaryRanges_GradeStep = new SeleniumControl( sDriver, "SalaryRanges_GradeStep", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMCPSAL_COMPLANLN_TBL_']/ancestor::form[1]/descendant::*[@id='SAL_GRADE_CD']");
				Function.AssertEqual(true,HSMCPSAL_SalaryRanges_GradeStep.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing VerifyExists on SalaryRanges_RecalculationLink...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_SalaryRanges_RecalculationLink = new SeleniumControl( sDriver, "SalaryRanges_RecalculationLink", "ID", "lnk_1001416_HSMCPSAL_COMPLANLN_TBL");
				Function.AssertEqual(true,HSMCPSAL_SalaryRanges_RecalculationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing Click on SalaryRanges_RecalculationLink...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_SalaryRanges_RecalculationLink = new SeleniumControl( sDriver, "SalaryRanges_RecalculationLink", "ID", "lnk_1001416_HSMCPSAL_COMPLANLN_TBL");
				Function.WaitControlDisplayed(HSMCPSAL_SalaryRanges_RecalculationLink);
HSMCPSAL_SalaryRanges_RecalculationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing VerifyExists on SalaryRanges_RecalculationForm...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_SalaryRanges_RecalculationForm = new SeleniumControl( sDriver, "SalaryRanges_RecalculationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMCPSAL_RECALC_SUBTASK_']/ancestor::form[1]");
				Function.AssertEqual(true,HSMCPSAL_SalaryRanges_RecalculationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing VerifyExists on SalaryRanges_Recalculation_StartAtRowPosition...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_SalaryRanges_Recalculation_StartAtRowPosition = new SeleniumControl( sDriver, "SalaryRanges_Recalculation_StartAtRowPosition", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMCPSAL_RECALC_SUBTASK_']/ancestor::form[1]/descendant::*[@id='ROW_POSITION']");
				Function.AssertEqual(true,HSMCPSAL_SalaryRanges_Recalculation_StartAtRowPosition.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing Close on SalaryRanges_RecalculationForm...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_SalaryRanges_RecalculationForm = new SeleniumControl( sDriver, "SalaryRanges_RecalculationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMCPSAL_RECALC_SUBTASK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HSMCPSAL_SalaryRanges_RecalculationForm);
IWebElement formBttn = HSMCPSAL_SalaryRanges_RecalculationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "HSMCPSAL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMCPSAL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMCPSAL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMCPSAL_MainForm);
IWebElement formBttn = HSMCPSAL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

