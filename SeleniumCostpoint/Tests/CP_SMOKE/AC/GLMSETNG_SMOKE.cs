 
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
    public class GLMSETNG_SMOKE : SeleniumTestScript
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
								try
				{
				this.ScriptLogger.WriteLine("START");


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
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"General Ledger", "xpath","//div[@class='deptItem'][.='General Ledger']").Click();
new SeleniumControl(sDriver,"General Ledger Controls", "xpath","//div[@class='navItem'][.='General Ledger Controls']").Click();
new SeleniumControl(sDriver,"Configure General Ledger Settings", "xpath","//div[@class='navItem'][.='Configure General Ledger Settings']").Click();


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
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLMSETNG_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing VerifyExists on Company...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_Company = new SeleniumControl( sDriver, "Company", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='COMPANY_ID']");
				Function.AssertEqual(true,GLMSETNG_Company.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing VerifyExists on CorporateSettingsLink...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_CorporateSettingsLink = new SeleniumControl( sDriver, "CorporateSettingsLink", "ID", "lnk_1001470_GLMSETNG_GLCONFIG_HDR");
				Function.AssertEqual(true,GLMSETNG_CorporateSettingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing Click on CorporateSettingsLink...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_CorporateSettingsLink = new SeleniumControl( sDriver, "CorporateSettingsLink", "ID", "lnk_1001470_GLMSETNG_GLCONFIG_HDR");
				Function.WaitControlDisplayed(GLMSETNG_CorporateSettingsLink);
GLMSETNG_CorporateSettingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing VerifyExists on CorporateGLSettingForm...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_CorporateGLSettingForm = new SeleniumControl( sDriver, "CorporateGLSettingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSETNG_GLCONFIGCORP_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMSETNG_CorporateGLSettingForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing VerifyExists on CorporateGLSettings_AccountStructure_NoOfLevels...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_CorporateGLSettings_AccountStructure_NoOfLevels = new SeleniumControl( sDriver, "CorporateGLSettings_AccountStructure_NoOfLevels", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSETNG_GLCONFIGCORP_HDR_']/ancestor::form[1]/descendant::*[@id='ACCT_LVLS_NO']");
				Function.AssertEqual(true,GLMSETNG_CorporateGLSettings_AccountStructure_NoOfLevels.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing VerifyExist on CorporateFLSettingChildFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_CorporateFLSettingChildFormTable = new SeleniumControl( sDriver, "CorporateFLSettingChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSETNG_GLCONFIGCORP_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMSETNG_CorporateFLSettingChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing VerifyExists on CorporateFLSettingChildForm...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_CorporateFLSettingChildForm = new SeleniumControl( sDriver, "CorporateFLSettingChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSETNG_GLCONFIGCORP_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMSETNG_CorporateFLSettingChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing Close on CorporateGLSettingForm...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_CorporateGLSettingForm = new SeleniumControl( sDriver, "CorporateGLSettingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSETNG_GLCONFIGCORP_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMSETNG_CorporateGLSettingForm);
IWebElement formBttn = GLMSETNG_CorporateGLSettingForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing VerifyExists on ApprovalSettingsLink...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_ApprovalSettingsLink = new SeleniumControl( sDriver, "ApprovalSettingsLink", "ID", "lnk_3473_GLMSETNG_GLCONFIG_HDR");
				Function.AssertEqual(true,GLMSETNG_ApprovalSettingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing Click on ApprovalSettingsLink...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_ApprovalSettingsLink = new SeleniumControl( sDriver, "ApprovalSettingsLink", "ID", "lnk_3473_GLMSETNG_GLCONFIG_HDR");
				Function.WaitControlDisplayed(GLMSETNG_ApprovalSettingsLink);
GLMSETNG_ApprovalSettingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing VerifyExists on ApprovalSettingForm...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_ApprovalSettingForm = new SeleniumControl( sDriver, "ApprovalSettingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSETNG_GLCONFIGAPPRVL_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMSETNG_ApprovalSettingForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing VerifyExist on ApprovalSettingFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_ApprovalSettingFormTable = new SeleniumControl( sDriver, "ApprovalSettingFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSETNG_GLCONFIGAPPRVL_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMSETNG_ApprovalSettingFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing Close on ApprovalSettingForm...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_ApprovalSettingForm = new SeleniumControl( sDriver, "ApprovalSettingForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMSETNG_GLCONFIGAPPRVL_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMSETNG_ApprovalSettingForm);
IWebElement formBttn = GLMSETNG_ApprovalSettingForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMSETNG] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMSETNG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMSETNG_MainForm);
IWebElement formBttn = GLMSETNG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

