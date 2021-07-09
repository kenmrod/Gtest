 
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
    public class MRMSET_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Material Requirements Planning", "xpath","//div[@class='deptItem'][.='Material Requirements Planning']").Click();
new SeleniumControl(sDriver,"MRP Controls", "xpath","//div[@class='navItem'][.='MRP Controls']").Click();
new SeleniumControl(sDriver,"Configure Materials Requirements Planning Settings", "xpath","//div[@class='navItem'][.='Configure Materials Requirements Planning Settings']").Click();


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
				Function.CurrentComponent = "MRMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMSET] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRMSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MRMSET_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMSET] Performing VerifyExists on ExcludeCustomerRepairMOsAsSupply...", Logger.MessageType.INF);
				SeleniumControl MRMSET_ExcludeCustomerRepairMOsAsSupply = new SeleniumControl( sDriver, "ExcludeCustomerRepairMOsAsSupply", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EXCL_CUST_REP_FL']");
				Function.AssertEqual(true,MRMSET_ExcludeCustomerRepairMOsAsSupply.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CORPORTATESETTINGS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMSET] Performing VerifyExists on CorporateSettingsForm...", Logger.MessageType.INF);
				SeleniumControl MRMSET_CorporateSettingsForm = new SeleniumControl( sDriver, "CorporateSettingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMSET_MRPSETTINGSCORP_CLD_']/ancestor::form[1]");
				Function.AssertEqual(true,MRMSET_CorporateSettingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMSET] Performing VerifyExists on CorporateSettings_ProcessMRPByCompany...", Logger.MessageType.INF);
				SeleniumControl MRMSET_CorporateSettings_ProcessMRPByCompany = new SeleniumControl( sDriver, "CorporateSettings_ProcessMRPByCompany", "xpath", "//div[translate(@id,'0123456789','')='pr__MRMSET_MRPSETTINGSCORP_CLD_']/ancestor::form[1]/descendant::*[@id='RUN_MRP_COMP_FL']");
				Function.AssertEqual(true,MRMSET_CorporateSettings_ProcessMRPByCompany.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRMSET] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRMSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MRMSET_MainForm);
IWebElement formBttn = MRMSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

