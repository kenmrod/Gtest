 
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
    public class HSMPERR_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Compensation Budgeting", "xpath","//div[@class='navItem'][.='Compensation Budgeting']").Click();
new SeleniumControl(sDriver,"Manage Projected Performance Ratings", "xpath","//div[@class='navItem'][.='Manage Projected Performance Ratings']").Click();


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
				Function.CurrentComponent = "HSMPERR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMPERR] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMPERR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HSMPERR_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMPERR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMPERR] Performing VerifyExists on FiscalYear...", Logger.MessageType.INF);
				SeleniumControl HSMPERR_FiscalYear = new SeleniumControl( sDriver, "FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,HSMPERR_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMPERR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMPERR] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMPERR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMPERR_MainForm);
IWebElement formBttn = HSMPERR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HSMPERR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HSMPERR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMPERR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMPERR] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMPERR_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMPERR_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMPERR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMPERR] Performing VerifyExists on ProjectedPerformanceRatingPercentDetailLink...", Logger.MessageType.INF);
				SeleniumControl HSMPERR_ProjectedPerformanceRatingPercentDetailLink = new SeleniumControl( sDriver, "ProjectedPerformanceRatingPercentDetailLink", "ID", "lnk_1001778_HSMPERR_PLANRATINGBYGRD_HDR");
				Function.AssertEqual(true,HSMPERR_ProjectedPerformanceRatingPercentDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMPERR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMPERR] Performing Click on ProjectedPerformanceRatingPercentDetailLink...", Logger.MessageType.INF);
				SeleniumControl HSMPERR_ProjectedPerformanceRatingPercentDetailLink = new SeleniumControl( sDriver, "ProjectedPerformanceRatingPercentDetailLink", "ID", "lnk_1001778_HSMPERR_PLANRATINGBYGRD_HDR");
				Function.WaitControlDisplayed(HSMPERR_ProjectedPerformanceRatingPercentDetailLink);
HSMPERR_ProjectedPerformanceRatingPercentDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMPERR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMPERR] Performing VerifyExist on ProjectedPerformanceRatingPercentDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMPERR_ProjectedPerformanceRatingPercentDetailFormTable = new SeleniumControl( sDriver, "ProjectedPerformanceRatingPercentDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMPERR_PLANRATINGBYGRD_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMPERR_ProjectedPerformanceRatingPercentDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMPERR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMPERR] Performing ClickButton on ProjectedPerformanceRatingPercentDetailForm...", Logger.MessageType.INF);
				SeleniumControl HSMPERR_ProjectedPerformanceRatingPercentDetailForm = new SeleniumControl( sDriver, "ProjectedPerformanceRatingPercentDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMPERR_PLANRATINGBYGRD_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HSMPERR_ProjectedPerformanceRatingPercentDetailForm);
IWebElement formBttn = HSMPERR_ProjectedPerformanceRatingPercentDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HSMPERR_ProjectedPerformanceRatingPercentDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HSMPERR_ProjectedPerformanceRatingPercentDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMPERR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMPERR] Performing VerifyExists on ProjectedPerformanceRatingPercentDetailForm...", Logger.MessageType.INF);
				SeleniumControl HSMPERR_ProjectedPerformanceRatingPercentDetailForm = new SeleniumControl( sDriver, "ProjectedPerformanceRatingPercentDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMPERR_PLANRATINGBYGRD_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,HSMPERR_ProjectedPerformanceRatingPercentDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMPERR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMPERR] Performing VerifyExists on ProjectedPerformanceRatingPercentDetail_CompensationPlan...", Logger.MessageType.INF);
				SeleniumControl HSMPERR_ProjectedPerformanceRatingPercentDetail_CompensationPlan = new SeleniumControl( sDriver, "ProjectedPerformanceRatingPercentDetail_CompensationPlan", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMPERR_PLANRATINGBYGRD_DTL_']/ancestor::form[1]/descendant::*[@id='COMP_PLAN_CD']");
				Function.AssertEqual(true,HSMPERR_ProjectedPerformanceRatingPercentDetail_CompensationPlan.Exists());

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
				Function.CurrentComponent = "HSMPERR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMPERR] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMPERR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMPERR_MainForm);
IWebElement formBttn = HSMPERR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

