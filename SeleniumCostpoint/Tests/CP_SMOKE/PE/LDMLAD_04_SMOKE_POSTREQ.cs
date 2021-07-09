 
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
    public class LDMLAD_04_SMOKE_POSTREQ : SeleniumTestScript
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
new SeleniumControl(sDriver,"Labor Controls", "xpath","//div[@class='navItem'][.='Labor Controls']").Click();
new SeleniumControl(sDriver,"Configure Labor Settings", "xpath","//div[@class='navItem'][.='Configure Labor Settings']").Click();


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
				Function.CurrentComponent = "LDMLABOR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLABOR] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl LDMLABOR_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(LDMLABOR_MainFormTab);
IWebElement mTab = LDMLABOR_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Timesheet Options").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLABOR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLABOR] Performing Set on TimesheetOptions_EnableUnionFunctionality...", Logger.MessageType.INF);
				SeleniumControl LDMLABOR_TimesheetOptions_EnableUnionFunctionality = new SeleniumControl( sDriver, "TimesheetOptions_EnableUnionFunctionality", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='UNION_PR_FL']");
				Function.WaitControlDisplayed(LDMLABOR_TimesheetOptions_EnableUnionFunctionality);
LDMLABOR_TimesheetOptions_EnableUnionFunctionality.ScrollIntoViewUsingJavaScript();
if (Convert.ToBoolean(LDMLABOR_TimesheetOptions_EnableUnionFunctionality.GetAttributeValue("checked")) != false) LDMLABOR_TimesheetOptions_EnableUnionFunctionality.Click(4.3);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLABOR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLABOR] Performing Set on TimesheetOptions_EnableUnionFunctionality...", Logger.MessageType.INF);
				SeleniumControl LDMLABOR_TimesheetOptions_EnableUnionFunctionality = new SeleniumControl( sDriver, "TimesheetOptions_EnableUnionFunctionality", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='UNION_PR_FL']");
				Function.WaitControlDisplayed(LDMLABOR_TimesheetOptions_EnableUnionFunctionality);
LDMLABOR_TimesheetOptions_EnableUnionFunctionality.ScrollIntoViewUsingJavaScript();
if (Convert.ToBoolean(LDMLABOR_TimesheetOptions_EnableUnionFunctionality.GetAttributeValue("checked")) != true) LDMLABOR_TimesheetOptions_EnableUnionFunctionality.Click(4.3);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLABOR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLABOR] Performing Set on TimesheetOptions_EnableBatch...", Logger.MessageType.INF);
				SeleniumControl LDMLABOR_TimesheetOptions_EnableBatch = new SeleniumControl( sDriver, "TimesheetOptions_EnableBatch", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BATCH_CNTL_FL']");
				Function.WaitControlDisplayed(LDMLABOR_TimesheetOptions_EnableBatch);
LDMLABOR_TimesheetOptions_EnableBatch.ScrollIntoViewUsingJavaScript();
if (Convert.ToBoolean(LDMLABOR_TimesheetOptions_EnableBatch.GetAttributeValue("checked")) != true) LDMLABOR_TimesheetOptions_EnableBatch.Click(4.3);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMLABOR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMLABOR] Performing Set on TimesheetOptions_EnableMultiCurrencyFunctionality...", Logger.MessageType.INF);
				SeleniumControl LDMLABOR_TimesheetOptions_EnableMultiCurrencyFunctionality = new SeleniumControl( sDriver, "TimesheetOptions_EnableMultiCurrencyFunctionality", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MULTICURR_FL']");
				Function.WaitControlDisplayed(LDMLABOR_TimesheetOptions_EnableMultiCurrencyFunctionality);
LDMLABOR_TimesheetOptions_EnableMultiCurrencyFunctionality.ScrollIntoViewUsingJavaScript();
if (Convert.ToBoolean(LDMLABOR_TimesheetOptions_EnableMultiCurrencyFunctionality.GetAttributeValue("checked")) != false) LDMLABOR_TimesheetOptions_EnableMultiCurrencyFunctionality.Click(4.3);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SAVE AND CLOSE");


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
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Save.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SYPSTNG");


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
new SeleniumControl(sDriver,"Admin", "xpath","//div[@class='busItem'][.='Admin']").Click();
new SeleniumControl(sDriver,"System Administration", "xpath","//div[@class='deptItem'][.='System Administration']").Click();
new SeleniumControl(sDriver,"System Administration Utilities", "xpath","//div[@class='navItem'][.='System Administration Utilities']").Click();
new SeleniumControl(sDriver,"Rebuild Global Settings", "xpath","//div[@class='navItem'][.='Rebuild Global Settings']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Action Menu')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Action Menu~Reload Settings.");
tlbrBtn.Click();
CP7Main_MainToolBar.mElement.FindElements(By.XPath("//*[@class = 'tlbrDDItem' and contains(text(),'Reload Settings')]")).FirstOrDefault().Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ProcessProgress";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ProcessProgress] Performing Click on OK...", Logger.MessageType.INF);
				SeleniumControl ProcessProgress_OK = new SeleniumControl( sDriver, "OK", "ID", "progMtrBtn");
				Function.WaitControlDisplayed(ProcessProgress_OK);
if (ProcessProgress_OK.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
ProcessProgress_OK.Click(5,5);
else ProcessProgress_OK.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "SYPSTNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[SYPSTNG] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl SYPSTNG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(SYPSTNG_MainForm);
IWebElement formBttn = SYPSTNG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogWithMessage("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogWithMessage]" , ex.Message));
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

