 
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
    public class BLMSETNG_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Billing Controls", "xpath","//div[@class='navItem'][.='Billing Controls']").Click();
new SeleniumControl(sDriver,"Configure Billing Settings", "xpath","//div[@class='navItem'][.='Configure Billing Settings']").Click();


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
				Function.CurrentComponent = "BLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSETNG] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMSETNG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMSETNG_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSETNG] Performing VerifyExists on Settings_Options_LastCompanyWideInvoiceNo...", Logger.MessageType.INF);
				SeleniumControl BLMSETNG_Settings_Options_LastCompanyWideInvoiceNo = new SeleniumControl( sDriver, "Settings_Options_LastCompanyWideInvoiceNo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LAST_CW_INVC_ID']");
				Function.AssertEqual(true,BLMSETNG_Settings_Options_LastCompanyWideInvoiceNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSETNG] Performing VerifyExists on Settings_Options_SelectedBillingFormulasLink...", Logger.MessageType.INF);
				SeleniumControl BLMSETNG_Settings_Options_SelectedBillingFormulasLink = new SeleniumControl( sDriver, "Settings_Options_SelectedBillingFormulasLink", "ID", "lnk_1002353_BLMSETNG_BILLSETTINGS_HDR");
				Function.AssertEqual(true,BLMSETNG_Settings_Options_SelectedBillingFormulasLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSETNG] Performing Click on Settings_Options_SelectedBillingFormulasLink...", Logger.MessageType.INF);
				SeleniumControl BLMSETNG_Settings_Options_SelectedBillingFormulasLink = new SeleniumControl( sDriver, "Settings_Options_SelectedBillingFormulasLink", "ID", "lnk_1002353_BLMSETNG_BILLSETTINGS_HDR");
				Function.WaitControlDisplayed(BLMSETNG_Settings_Options_SelectedBillingFormulasLink);
BLMSETNG_Settings_Options_SelectedBillingFormulasLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINK TABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSETNG] Performing VerifyExist on BillingFormulas_Table...", Logger.MessageType.INF);
				SeleniumControl BLMSETNG_BillingFormulas_Table = new SeleniumControl( sDriver, "BillingFormulas_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMSETNG_SBILLFORMULA_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMSETNG_BillingFormulas_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSETNG] Performing VerifyExist on SelectedBillingFormulas_Table...", Logger.MessageType.INF);
				SeleniumControl BLMSETNG_SelectedBillingFormulas_Table = new SeleniumControl( sDriver, "SelectedBillingFormulas_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMSETNG_BILLFORMULACOMP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMSETNG_SelectedBillingFormulas_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "BLMSETNG";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSETNG] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMSETNG_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMSETNG_MainForm);
IWebElement formBttn = BLMSETNG_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

