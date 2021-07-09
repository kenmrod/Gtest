 
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
    public class PJPCKUN_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Projects", "xpath","//div[@class='busItem'][.='Projects']").Click();
new SeleniumControl(sDriver,"Cost and Revenue Processing", "xpath","//div[@class='deptItem'][.='Cost and Revenue Processing']").Click();
new SeleniumControl(sDriver,"Cost and Revenue Processing Utilities", "xpath","//div[@class='navItem'][.='Cost and Revenue Processing Utilities']").Click();
new SeleniumControl(sDriver,"Check for Unposted Journals", "xpath","//div[@class='navItem'][.='Check for Unposted Journals']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Verify MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKUN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKUN] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJPCKUN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJPCKUN_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKUN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKUN] Performing VerifyExists on SelectSubperiod_AccountingPeriod...", Logger.MessageType.INF);
				SeleniumControl PJPCKUN_SelectSubperiod_AccountingPeriod = new SeleniumControl( sDriver, "SelectSubperiod_AccountingPeriod", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_RANGE']");
				Function.AssertEqual(true,PJPCKUN_SelectSubperiod_AccountingPeriod.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Set Fiscalyear (for DEFECT #471661)");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKUN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKUN] Performing Set on SelectSubperiod_FiscalYear_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJPCKUN_SelectSubperiod_FiscalYear_FiscalYear = new SeleniumControl( sDriver, "SelectSubperiod_FiscalYear_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				PJPCKUN_SelectSubperiod_FiscalYear_FiscalYear.Click();
PJPCKUN_SelectSubperiod_FiscalYear_FiscalYear.SendKeys("S2084", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PJPCKUN_SelectSubperiod_FiscalYear_FiscalYear.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKUN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKUN] Performing Set on SelectSubperiod_Period_Period...", Logger.MessageType.INF);
				SeleniumControl PJPCKUN_SelectSubperiod_Period_Period = new SeleniumControl( sDriver, "SelectSubperiod_Period_Period", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PD_NO']");
				PJPCKUN_SelectSubperiod_Period_Period.Click();
PJPCKUN_SelectSubperiod_Period_Period.SendKeys("1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PJPCKUN_SelectSubperiod_Period_Period.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKUN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKUN] Performing Set on SelectSubperiod_Subpd_Subpd...", Logger.MessageType.INF);
				SeleniumControl PJPCKUN_SelectSubperiod_Subpd_Subpd = new SeleniumControl( sDriver, "SelectSubperiod_Subpd_Subpd", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SUB_PD_NO']");
				PJPCKUN_SelectSubperiod_Subpd_Subpd.Click();
PJPCKUN_SelectSubperiod_Subpd_Subpd.SendKeys("1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PJPCKUN_SelectSubperiod_Subpd_Subpd.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Check for Open Journal (Action Button)");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Check for Open Journals')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Check for Open Journals.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Verify record");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKUN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKUN] Performing VerifyText on SelectSubperiod_FiscalYear_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJPCKUN_SelectSubperiod_FiscalYear_FiscalYear = new SeleniumControl( sDriver, "SelectSubperiod_FiscalYear_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual("S2084",PJPCKUN_SelectSubperiod_FiscalYear_FiscalYear.GetAttributeValue("value"));


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyText]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKUN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKUN] Performing VerifyText on SelectSubperiod_Period_Period...", Logger.MessageType.INF);
				SeleniumControl PJPCKUN_SelectSubperiod_Period_Period = new SeleniumControl( sDriver, "SelectSubperiod_Period_Period", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PD_NO']");
				Function.AssertEqual("1",PJPCKUN_SelectSubperiod_Period_Period.GetAttributeValue("value"));


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyText]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKUN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKUN] Performing VerifyText on SelectSubperiod_Subpd_Subpd...", Logger.MessageType.INF);
				SeleniumControl PJPCKUN_SelectSubperiod_Subpd_Subpd = new SeleniumControl( sDriver, "SelectSubperiod_Subpd_Subpd", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SUB_PD_NO']");
				Function.AssertEqual("1",PJPCKUN_SelectSubperiod_Subpd_Subpd.GetAttributeValue("value"));


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyText]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close the app");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPCKUN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPCKUN] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJPCKUN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJPCKUN_MainForm);
IWebElement formBttn = PJPCKUN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

