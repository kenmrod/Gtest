 
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
    public class RUMWCM_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials", "xpath","//div[@class='busItem'][.='Materials']").Click();
new SeleniumControl(sDriver,"Bills of Material", "xpath","//div[@class='deptItem'][.='Bills of Material']").Click();
new SeleniumControl(sDriver,"Work Centers", "xpath","//div[@class='navItem'][.='Work Centers']").Click();
new SeleniumControl(sDriver,"Manage Work Centers", "xpath","//div[@class='navItem'][.='Manage Work Centers']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMWCM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMWCM] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMWCM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,RUMWCM_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMWCM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMWCM] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMWCM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMWCM_MainForm);
IWebElement formBttn = RUMWCM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? RUMWCM_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
RUMWCM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMWCM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMWCM] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMWCM_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMWCM_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMWCM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMWCM] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMWCM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMWCM_MainForm);
IWebElement formBttn = RUMWCM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMWCM_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMWCM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMWCM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMWCM] Performing VerifyExists on WorkCenterID...", Logger.MessageType.INF);
				SeleniumControl RUMWCM_WorkCenterID = new SeleniumControl( sDriver, "WorkCenterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WC_ID']");
				Function.AssertEqual(true,RUMWCM_WorkCenterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TIMESHEET DEFAULTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CAPACITY&RATES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EQUIPMENT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LABOR");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINTENANCE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ALTERNATEWORKCENTERS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMWCM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMWCM] Performing Click on AlternateWorkCentersLink...", Logger.MessageType.INF);
				SeleniumControl RUMWCM_AlternateWorkCentersLink = new SeleniumControl( sDriver, "AlternateWorkCentersLink", "ID", "lnk_4404_RUMWCM_WORKCENTER_HDR");
				Function.WaitControlDisplayed(RUMWCM_AlternateWorkCentersLink);
RUMWCM_AlternateWorkCentersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMWCM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMWCM] Performing VerifyExist on AlternateWorkCentersFormTable...", Logger.MessageType.INF);
				SeleniumControl RUMWCM_AlternateWorkCentersFormTable = new SeleniumControl( sDriver, "AlternateWorkCentersFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMWCM_WCALTERNATES_ALTERNWC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,RUMWCM_AlternateWorkCentersFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMWCM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMWCM] Performing ClickButton on AlternateWorkCentersForm...", Logger.MessageType.INF);
				SeleniumControl RUMWCM_AlternateWorkCentersForm = new SeleniumControl( sDriver, "AlternateWorkCentersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMWCM_WCALTERNATES_ALTERNWC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(RUMWCM_AlternateWorkCentersForm);
IWebElement formBttn = RUMWCM_AlternateWorkCentersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? RUMWCM_AlternateWorkCentersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
RUMWCM_AlternateWorkCentersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMWCM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMWCM] Performing VerifyExists on AlternateWorkCenters_Sequence...", Logger.MessageType.INF);
				SeleniumControl RUMWCM_AlternateWorkCenters_Sequence = new SeleniumControl( sDriver, "AlternateWorkCenters_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMWCM_WCALTERNATES_ALTERNWC_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,RUMWCM_AlternateWorkCenters_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMWCM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMWCM] Performing VerifyExists on AlternateWorkCentersForm...", Logger.MessageType.INF);
				SeleniumControl RUMWCM_AlternateWorkCentersForm = new SeleniumControl( sDriver, "AlternateWorkCentersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__RUMWCM_WCALTERNATES_ALTERNWC_']/ancestor::form[1]");
				Function.AssertEqual(true,RUMWCM_AlternateWorkCentersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "RUMWCM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[RUMWCM] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl RUMWCM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(RUMWCM_MainForm);
IWebElement formBttn = RUMWCM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

