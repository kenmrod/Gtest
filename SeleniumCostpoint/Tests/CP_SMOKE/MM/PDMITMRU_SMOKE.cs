 
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
    public class PDMITMRU_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Product Definition", "xpath","//div[@class='deptItem'][.='Product Definition']").Click();
new SeleniumControl(sDriver,"Product Definition Controls", "xpath","//div[@class='navItem'][.='Product Definition Controls']").Click();
new SeleniumControl(sDriver,"Configure Product Definition Settings", "xpath","//div[@class='navItem'][.='Configure Product Definition Settings']").Click();


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
				Function.CurrentComponent = "PDMITMRU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMITMRU] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMITMRU_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PDMITMRU_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMITMRU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMITMRU] Performing VerifyExists on CompanyCAGECode...", Logger.MessageType.INF);
				SeleniumControl PDMITMRU_CompanyCAGECode = new SeleniumControl( sDriver, "CompanyCAGECode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CAGE_ID_FLD']");
				Function.AssertEqual(true,PDMITMRU_CompanyCAGECode.Exists());

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
				Function.CurrentComponent = "PDMITMRU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMITMRU] Performing VerifyExists on CorporateSettingForm...", Logger.MessageType.INF);
				SeleniumControl PDMITMRU_CorporateSettingForm = new SeleniumControl( sDriver, "CorporateSettingForm", "xpath", "//div[@class='gBxPIBHdrLabel' and contains(.,'Settings')]/ancestor::div[@class='rsltst']/descendant::form[1]");
				Function.AssertEqual(true,PDMITMRU_CorporateSettingForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMITMRU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMITMRU] Performing VerifyExists on CorporateSettings_SeparateItemsByCompanyLabel...", Logger.MessageType.INF);
				SeleniumControl PDMITMRU_CorporateSettings_SeparateItemsByCompanyLabel = new SeleniumControl( sDriver, "CorporateSettings_SeparateItemsByCompanyLabel", "xpath", "//input[@id='ITEMS_BY_COMP_FL']/ancestor::form[1]/descendant::*[@id='ITEMS_BY_COMP_FL']/preceding-sibling::span[1]");
				Function.AssertEqual(true,PDMITMRU_CorporateSettings_SeparateItemsByCompanyLabel.Exists());

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
				Function.CurrentComponent = "PDMITMRU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMITMRU] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMITMRU_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMITMRU_MainForm);
IWebElement formBttn = PDMITMRU_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

