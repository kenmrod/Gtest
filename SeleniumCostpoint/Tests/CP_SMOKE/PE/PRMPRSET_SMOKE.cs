 
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
    public class PRMPRSET_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Payroll", "xpath","//div[@class='deptItem'][.='Payroll']").Click();
new SeleniumControl(sDriver,"Payroll Controls", "xpath","//div[@class='navItem'][.='Payroll Controls']").Click();
new SeleniumControl(sDriver,"Configure Payroll Settings", "xpath","//div[@class='navItem'][.='Configure Payroll Settings']").Click();


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
				Function.CurrentComponent = "PRMPRSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPRSET] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMPRSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMPRSET_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPRSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPRSET] Performing VerifyExists on PostingAccounts_FederalIncomeTaxWH...", Logger.MessageType.INF);
				SeleniumControl PRMPRSET_PostingAccounts_FederalIncomeTaxWH = new SeleniumControl( sDriver, "PostingAccounts_FederalIncomeTaxWH", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FED_WH_ACCT_ID']");
				Function.AssertEqual(true,PRMPRSET_PostingAccounts_FederalIncomeTaxWH.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Direct Charge Options Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPRSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPRSET] Performing VerifyExists on PostingAccounts_DirectChargeOptionsLink...", Logger.MessageType.INF);
				SeleniumControl PRMPRSET_PostingAccounts_DirectChargeOptionsLink = new SeleniumControl( sDriver, "PostingAccounts_DirectChargeOptionsLink", "ID", "lnk_1729_PRMPRSET_PRSETTINGS");
				Function.AssertEqual(true,PRMPRSET_PostingAccounts_DirectChargeOptionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPRSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPRSET] Performing Click on PostingAccounts_DirectChargeOptionsLink...", Logger.MessageType.INF);
				SeleniumControl PRMPRSET_PostingAccounts_DirectChargeOptionsLink = new SeleniumControl( sDriver, "PostingAccounts_DirectChargeOptionsLink", "ID", "lnk_1729_PRMPRSET_PRSETTINGS");
				Function.WaitControlDisplayed(PRMPRSET_PostingAccounts_DirectChargeOptionsLink);
PRMPRSET_PostingAccounts_DirectChargeOptionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPRSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPRSET] Performing VerifyExists on DirectChargeOptionsForm...", Logger.MessageType.INF);
				SeleniumControl PRMPRSET_DirectChargeOptionsForm = new SeleniumControl( sDriver, "DirectChargeOptionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPRSET_PRSETTINGS_DIR_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPRSET_DirectChargeOptionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPRSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPRSET] Performing VerifyExists on DirectChargeOptions_DirectChargeSocialSecurityExpensePosting_SocialSecurityExpenseAccount...", Logger.MessageType.INF);
				SeleniumControl PRMPRSET_DirectChargeOptions_DirectChargeSocialSecurityExpensePosting_SocialSecurityExpenseAccount = new SeleniumControl( sDriver, "DirectChargeOptions_DirectChargeSocialSecurityExpensePosting_SocialSecurityExpenseAccount", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPRSET_PRSETTINGS_DIR_']/ancestor::form[1]/descendant::*[@id='DC_SS_EXP_ACCT_ID']");
				Function.AssertEqual(true,PRMPRSET_DirectChargeOptions_DirectChargeSocialSecurityExpensePosting_SocialSecurityExpenseAccount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPRSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPRSET] Performing Close on DirectChargeOptionsForm...", Logger.MessageType.INF);
				SeleniumControl PRMPRSET_DirectChargeOptionsForm = new SeleniumControl( sDriver, "DirectChargeOptionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPRSET_PRSETTINGS_DIR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPRSET_DirectChargeOptionsForm);
IWebElement formBttn = PRMPRSET_DirectChargeOptionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Reference Number Settings Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPRSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPRSET] Performing VerifyExists on PostingAccounts_ReferenceNumberSettingsLink...", Logger.MessageType.INF);
				SeleniumControl PRMPRSET_PostingAccounts_ReferenceNumberSettingsLink = new SeleniumControl( sDriver, "PostingAccounts_ReferenceNumberSettingsLink", "ID", "lnk_3835_PRMPRSET_PRSETTINGS");
				Function.AssertEqual(true,PRMPRSET_PostingAccounts_ReferenceNumberSettingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPRSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPRSET] Performing Click on PostingAccounts_ReferenceNumberSettingsLink...", Logger.MessageType.INF);
				SeleniumControl PRMPRSET_PostingAccounts_ReferenceNumberSettingsLink = new SeleniumControl( sDriver, "PostingAccounts_ReferenceNumberSettingsLink", "ID", "lnk_3835_PRMPRSET_PRSETTINGS");
				Function.WaitControlDisplayed(PRMPRSET_PostingAccounts_ReferenceNumberSettingsLink);
PRMPRSET_PostingAccounts_ReferenceNumberSettingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPRSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPRSET] Performing VerifyExists on PostingForm...", Logger.MessageType.INF);
				SeleniumControl PRMPRSET_PostingForm = new SeleniumControl( sDriver, "PostingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPRSET_PRSETTINGS_REFNUMBER_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPRSET_PostingForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPRSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPRSET] Performing VerifyExists on PostingAccounts_PayrollVariance...", Logger.MessageType.INF);
				SeleniumControl PRMPRSET_PostingAccounts_PayrollVariance = new SeleniumControl( sDriver, "PostingAccounts_PayrollVariance", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PR_VAR_ACCT_ID']");
				Function.AssertEqual(true,PRMPRSET_PostingAccounts_PayrollVariance.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPRSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPRSET] Performing Close on PostingForm...", Logger.MessageType.INF);
				SeleniumControl PRMPRSET_PostingForm = new SeleniumControl( sDriver, "PostingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPRSET_PRSETTINGS_REFNUMBER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPRSET_PostingForm);
IWebElement formBttn = PRMPRSET_PostingForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRMPRSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPRSET] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMPRSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMPRSET_MainForm);
IWebElement formBttn = PRMPRSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

