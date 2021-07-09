 
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
    public class BLPAOBD_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Billing", "xpath","//div[@class='deptItem'][.='Billing']").Click();
new SeleniumControl(sDriver,"Standard Bill Adjustments", "xpath","//div[@class='navItem'][.='Standard Bill Adjustments']").Click();
new SeleniumControl(sDriver,"Adjust Open Billing Detail Records", "xpath","//div[@class='navItem'][.='Adjust Open Billing Detail Records']").Click();


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
				Function.CurrentComponent = "BLPAOBD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPAOBD] Performing Set on Identification_Project...", Logger.MessageType.INF);
				SeleniumControl BLPAOBD_Identification_Project = new SeleniumControl( sDriver, "Identification_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				BLPAOBD_Identification_Project.Click();
BLPAOBD_Identification_Project.SendKeys("1003", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
BLPAOBD_Identification_Project.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPAOBD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPAOBD] Performing Set on Identification_Identification_SelectSubperiodForAdjustment_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl BLPAOBD_Identification_Identification_SelectSubperiodForAdjustment_FiscalYear = new SeleniumControl( sDriver, "Identification_Identification_SelectSubperiodForAdjustment_FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				BLPAOBD_Identification_Identification_SelectSubperiodForAdjustment_FiscalYear.Click();
BLPAOBD_Identification_Identification_SelectSubperiodForAdjustment_FiscalYear.SendKeys("2040", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
BLPAOBD_Identification_Identification_SelectSubperiodForAdjustment_FiscalYear.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPAOBD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPAOBD] Performing Set on Identification_Identification_SelectSubperiodForAdjustment_Subperiod...", Logger.MessageType.INF);
				SeleniumControl BLPAOBD_Identification_Identification_SelectSubperiodForAdjustment_Subperiod = new SeleniumControl( sDriver, "Identification_Identification_SelectSubperiodForAdjustment_Subperiod", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SUB_PD']");
				BLPAOBD_Identification_Identification_SelectSubperiodForAdjustment_Subperiod.Click();
BLPAOBD_Identification_Identification_SelectSubperiodForAdjustment_Subperiod.SendKeys("1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
BLPAOBD_Identification_Identification_SelectSubperiodForAdjustment_Subperiod.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPAOBD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPAOBD] Performing Set on Identification_Identification_SelectSubperiodForAdjustment_Period...", Logger.MessageType.INF);
				SeleniumControl BLPAOBD_Identification_Identification_SelectSubperiodForAdjustment_Period = new SeleniumControl( sDriver, "Identification_Identification_SelectSubperiodForAdjustment_Period", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PD_NO']");
				BLPAOBD_Identification_Identification_SelectSubperiodForAdjustment_Period.Click();
BLPAOBD_Identification_Identification_SelectSubperiodForAdjustment_Period.SendKeys("1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
BLPAOBD_Identification_Identification_SelectSubperiodForAdjustment_Period.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Execute.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPAOBD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPAOBD] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLPAOBD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLPAOBD_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPAOBD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPAOBD] Performing VerifyExists on Identification_Project...", Logger.MessageType.INF);
				SeleniumControl BLPAOBD_Identification_Project = new SeleniumControl( sDriver, "Identification_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BLPAOBD_Identification_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILD FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPAOBD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPAOBD] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl BLPAOBD_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPAOBD_OPENBILLINGDETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLPAOBD_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPAOBD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPAOBD] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl BLPAOBD_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPAOBD_OPENBILLINGDETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLPAOBD_ChildForm);
IWebElement formBttn = BLPAOBD_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLPAOBD_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLPAOBD_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPAOBD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPAOBD] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl BLPAOBD_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPAOBD_OPENBILLINGDETL_']/ancestor::form[1]");
				Function.AssertEqual(true,BLPAOBD_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPAOBD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPAOBD] Performing VerifyExists on ChildForm_TransactionDetails_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl BLPAOBD_ChildForm_TransactionDetails_FiscalYear = new SeleniumControl( sDriver, "ChildForm_TransactionDetails_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPAOBD_OPENBILLINGDETL_']/ancestor::form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,BLPAOBD_ChildForm_TransactionDetails_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPAOBD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPAOBD] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl BLPAOBD_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPAOBD_OPENBILLINGDETL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLPAOBD_ChildFormTab);
IWebElement mTab = BLPAOBD_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Adjustment Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLPAOBD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPAOBD] Performing VerifyExists on ChildForm_AdjustmentDetails_AdjustmentProject...", Logger.MessageType.INF);
				SeleniumControl BLPAOBD_ChildForm_AdjustmentDetails_AdjustmentProject = new SeleniumControl( sDriver, "ChildForm_AdjustmentDetails_AdjustmentProject", "xpath", "//div[translate(@id,'0123456789','')='pr__BLPAOBD_OPENBILLINGDETL_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BLPAOBD_ChildForm_AdjustmentDetails_AdjustmentProject.Exists());

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
				Function.CurrentComponent = "BLPAOBD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLPAOBD] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLPAOBD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLPAOBD_MainForm);
IWebElement formBttn = BLPAOBD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

