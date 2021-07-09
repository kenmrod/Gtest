 
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
    public class HAMSET_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Affirmative Action", "xpath","//div[@class='deptItem'][.='Affirmative Action']").Click();
new SeleniumControl(sDriver,"Affirmative Action Controls", "xpath","//div[@class='navItem'][.='Affirmative Action Controls']").Click();
new SeleniumControl(sDriver,"Configure Affirmative Action Settings", "xpath","//div[@class='navItem'][.='Configure Affirmative Action Settings']").Click();


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
				Function.CurrentComponent = "HAMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMSET] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HAMSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HAMSET_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMSET] Performing VerifyExists on Controls_DefaultAffirmativeActionPlan...", Logger.MessageType.INF);
				SeleniumControl HAMSET_Controls_DefaultAffirmativeActionPlan = new SeleniumControl( sDriver, "Controls_DefaultAffirmativeActionPlan", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DFLT_AFF_PLAN_CD']");
				Function.AssertEqual(true,HAMSET_Controls_DefaultAffirmativeActionPlan.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMSET] Performing VerifyExists on EEOSetupLink...", Logger.MessageType.INF);
				SeleniumControl HAMSET_EEOSetupLink = new SeleniumControl( sDriver, "EEOSetupLink", "ID", "lnk_4084_HAMSET_HAFFSETTINGS");
				Function.AssertEqual(true,HAMSET_EEOSetupLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMSET] Performing Click on EEOSetupLink...", Logger.MessageType.INF);
				SeleniumControl HAMSET_EEOSetupLink = new SeleniumControl( sDriver, "EEOSetupLink", "ID", "lnk_4084_HAMSET_HAFFSETTINGS");
				Function.WaitControlDisplayed(HAMSET_EEOSetupLink);
HAMSET_EEOSetupLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMSET] Performing VerifyExists on EEOSetupForm...", Logger.MessageType.INF);
				SeleniumControl HAMSET_EEOSetupForm = new SeleniumControl( sDriver, "EEOSetupForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HAMSET_EEOSETTINGS_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,HAMSET_EEOSetupForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMSET] Performing VerifyExists on EEOSetup_EEOReportingForm_EEO1Report...", Logger.MessageType.INF);
				SeleniumControl HAMSET_EEOSetup_EEOReportingForm_EEO1Report = new SeleniumControl( sDriver, "EEOSetup_EEOReportingForm_EEO1Report", "xpath", "//div[translate(@id,'0123456789','')='pr__HAMSET_EEOSETTINGS_CTW_']/ancestor::form[1]/descendant::*[@id='S_EEO_1OR4_CD' and @value='1']");
				Function.AssertEqual(true,HAMSET_EEOSetup_EEOReportingForm_EEO1Report.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMSET] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HAMSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HAMSET_MainForm);
IWebElement formBttn = HAMSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

