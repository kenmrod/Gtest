 
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
    public class AOMESSCS_SMOKE : SeleniumTestScript
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

				this.ScriptLogger.WriteLine("[CP7Main] Performing Set on SearchApplications...", Logger.MessageType.INF);
				SeleniumControl CP7Main_SearchApplications = new SeleniumControl( sDriver, "SearchApplications", "ID", "appFltrFld");
				CP7Main_SearchApplications.Click();
CP7Main_SearchApplications.SendKeys("AOMESSCS", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
CP7Main_SearchApplications.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try
				{
				Function.SendKeys("Down");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SendKeys]" , ex.Message));
				}
								try
				{
				Function.SendKeys("Enter");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SendKeys]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,AOMESSCS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing VerifyExists on TaxableEntity...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_TaxableEntity = new SeleniumControl( sDriver, "TaxableEntity", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TAXBLE_ENTITY_ID']");
				Function.AssertEqual(true,AOMESSCS_TaxableEntity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMESSCS_MainForm);
IWebElement formBttn = AOMESSCS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? AOMESSCS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
AOMESSCS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMESSCS_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Severance Pay Types");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing VerifyExists on SeverancePayTypesLink...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_SeverancePayTypesLink = new SeleniumControl( sDriver, "SeverancePayTypesLink", "ID", "lnk_4875_AOMESSCS_ESSSETTINGS_HDR");
				Function.AssertEqual(true,AOMESSCS_SeverancePayTypesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing Click on SeverancePayTypesLink...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_SeverancePayTypesLink = new SeleniumControl( sDriver, "SeverancePayTypesLink", "ID", "lnk_4875_AOMESSCS_ESSSETTINGS_HDR");
				Function.WaitControlDisplayed(AOMESSCS_SeverancePayTypesLink);
AOMESSCS_SeverancePayTypesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing VerifyExists on SeverancePayTypesForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_SeverancePayTypesForm = new SeleniumControl( sDriver, "SeverancePayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSCS_ESSSEVPAYTP_TBL_']/ancestor::form[1]");
				Function.AssertEqual(true,AOMESSCS_SeverancePayTypesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing VerifyExist on SeverancePayTypesFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_SeverancePayTypesFormTable = new SeleniumControl( sDriver, "SeverancePayTypesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSCS_ESSSEVPAYTP_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMESSCS_SeverancePayTypesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Deferred Compensation Settings");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing VerifyExists on DeferredCompensationSettingsLink...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_DeferredCompensationSettingsLink = new SeleniumControl( sDriver, "DeferredCompensationSettingsLink", "ID", "lnk_4874_AOMESSCS_ESSSETTINGS_HDR");
				Function.AssertEqual(true,AOMESSCS_DeferredCompensationSettingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing Click on DeferredCompensationSettingsLink...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_DeferredCompensationSettingsLink = new SeleniumControl( sDriver, "DeferredCompensationSettingsLink", "ID", "lnk_4874_AOMESSCS_ESSSETTINGS_HDR");
				Function.WaitControlDisplayed(AOMESSCS_DeferredCompensationSettingsLink);
AOMESSCS_DeferredCompensationSettingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing VerifyExists on DefferedCompensationSettingsForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_DefferedCompensationSettingsForm = new SeleniumControl( sDriver, "DefferedCompensationSettingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSCS_DEFRCOMPSETNG_TBL_']/ancestor::form[1]");
				Function.AssertEqual(true,AOMESSCS_DefferedCompensationSettingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing VerifyExists on DefferedCompensationSettings_MinimumPercent...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_DefferedCompensationSettings_MinimumPercent = new SeleniumControl( sDriver, "DefferedCompensationSettings_MinimumPercent", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSCS_DEFRCOMPSETNG_TBL_']/ancestor::form[1]/descendant::*[@id='MIN_DC_PCT']");
				Function.AssertEqual(true,AOMESSCS_DefferedCompensationSettings_MinimumPercent.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Open Change Periods");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing VerifyExists on DefferedCompensationSettings_OpenChangePeriodsForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_DefferedCompensationSettings_OpenChangePeriodsForm = new SeleniumControl( sDriver, "DefferedCompensationSettings_OpenChangePeriodsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSCS_ESSSETTINGSDT_TBL_']/ancestor::form[1]");
				Function.AssertEqual(true,AOMESSCS_DefferedCompensationSettings_OpenChangePeriodsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing VerifyExist on DefferedCompensationSettings_OpenChangePeriodsFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_DefferedCompensationSettings_OpenChangePeriodsFormTable = new SeleniumControl( sDriver, "DefferedCompensationSettings_OpenChangePeriodsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSCS_ESSSETTINGSDT_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMESSCS_DefferedCompensationSettings_OpenChangePeriodsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Deductions/Methods");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing VerifyExists on DefferedCompensationSettings_DeductionsMethodsForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_DefferedCompensationSettings_DeductionsMethodsForm = new SeleniumControl( sDriver, "DefferedCompensationSettings_DeductionsMethodsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSCS_ESSSETTINGSDED_TBL_']/ancestor::form[1]");
				Function.AssertEqual(true,AOMESSCS_DefferedCompensationSettings_DeductionsMethodsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing VerifyExist on DefferedCompensationSettings_DeductionsMethodsFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_DefferedCompensationSettings_DeductionsMethodsFormTable = new SeleniumControl( sDriver, "DefferedCompensationSettings_DeductionsMethodsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSCS_ESSSETTINGSDED_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMESSCS_DefferedCompensationSettings_DeductionsMethodsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSCS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSCS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSCS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMESSCS_MainForm);
IWebElement formBttn = AOMESSCS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

