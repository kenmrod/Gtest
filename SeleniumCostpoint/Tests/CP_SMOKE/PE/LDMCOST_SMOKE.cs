 
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
    public class LDMCOST_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Labor", "xpath","//div[@class='deptItem'][.='Labor']").Click();
new SeleniumControl(sDriver,"Overtime Controls", "xpath","//div[@class='navItem'][.='Overtime Controls']").Click();
new SeleniumControl(sDriver,"Configure Weighted Average Overtime Settings", "xpath","//div[@class='navItem'][.='Configure Weighted Average Overtime Settings']").Click();


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
				Function.CurrentComponent = "LDMCOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCOST] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMCOST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDMCOST_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCOST] Performing VerifyExists on TimesheetCycle...", Logger.MessageType.INF);
				SeleniumControl LDMCOST_TimesheetCycle = new SeleniumControl( sDriver, "TimesheetCycle", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TS_PD_CD']");
				Function.AssertEqual(true,LDMCOST_TimesheetCycle.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCOST] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMCOST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMCOST_MainForm);
IWebElement formBttn = LDMCOST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? LDMCOST_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
LDMCOST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCOST] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMCOST_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMCOST_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCOST] Performing VerifyExists on WeightedAveragePeriodsForm...", Logger.MessageType.INF);
				SeleniumControl LDMCOST_WeightedAveragePeriodsForm = new SeleniumControl( sDriver, "WeightedAveragePeriodsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCOST_WTAVGPDSCH_WEIGAVGPRD_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMCOST_WeightedAveragePeriodsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCOST] Performing VerifyExist on WeightedAveragePeriodsFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMCOST_WeightedAveragePeriodsFormTable = new SeleniumControl( sDriver, "WeightedAveragePeriodsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCOST_WTAVGPDSCH_WEIGAVGPRD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMCOST_WeightedAveragePeriodsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCOST] Performing ClickButton on WeightedAveragePeriodsForm...", Logger.MessageType.INF);
				SeleniumControl LDMCOST_WeightedAveragePeriodsForm = new SeleniumControl( sDriver, "WeightedAveragePeriodsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCOST_WTAVGPDSCH_WEIGAVGPRD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMCOST_WeightedAveragePeriodsForm);
IWebElement formBttn = LDMCOST_WeightedAveragePeriodsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? LDMCOST_WeightedAveragePeriodsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
LDMCOST_WeightedAveragePeriodsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCOST] Performing VerifyExists on WeightedAveragePeriods_StartDate...", Logger.MessageType.INF);
				SeleniumControl LDMCOST_WeightedAveragePeriods_StartDate = new SeleniumControl( sDriver, "WeightedAveragePeriods_StartDate", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCOST_WTAVGPDSCH_WEIGAVGPRD_']/ancestor::form[1]/descendant::*[@id='START_DT']");
				Function.AssertEqual(true,LDMCOST_WeightedAveragePeriods_StartDate.Exists());

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
				Function.CurrentComponent = "LDMCOST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCOST] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMCOST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMCOST_MainForm);
IWebElement formBttn = LDMCOST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

