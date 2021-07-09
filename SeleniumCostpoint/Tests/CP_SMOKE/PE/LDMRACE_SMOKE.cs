 
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
    public class LDMRACE_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Employee", "xpath","//div[@class='deptItem'][.='Employee']").Click();
new SeleniumControl(sDriver,"Employee Controls", "xpath","//div[@class='navItem'][.='Employee Controls']").Click();
new SeleniumControl(sDriver,"Manage Race and Ethnicity Codes", "xpath","//div[@class='navItem'][.='Manage Race and Ethnicity Codes']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
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
				Function.CurrentComponent = "LDMRACE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMRACE] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMRACE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDMRACE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMRACE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMRACE] Performing VerifyExist on RaceEthnicityCodes_RaceEthnicityCodesTable...", Logger.MessageType.INF);
				SeleniumControl LDMRACE_RaceEthnicityCodes_RaceEthnicityCodesTable = new SeleniumControl( sDriver, "RaceEthnicityCodes_RaceEthnicityCodesTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMRACE_RaceEthnicityCodes_RaceEthnicityCodesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Affirmative Action Code Mappings");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMRACE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMRACE] Performing VerifyExists on RaceEthnicityCodes_AffirmativeActionCodeMappingsLink...", Logger.MessageType.INF);
				SeleniumControl LDMRACE_RaceEthnicityCodes_AffirmativeActionCodeMappingsLink = new SeleniumControl( sDriver, "RaceEthnicityCodes_AffirmativeActionCodeMappingsLink", "ID", "lnk_4300_LDMRACE_HDR");
				Function.AssertEqual(true,LDMRACE_RaceEthnicityCodes_AffirmativeActionCodeMappingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMRACE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMRACE] Performing Click on RaceEthnicityCodes_AffirmativeActionCodeMappingsLink...", Logger.MessageType.INF);
				SeleniumControl LDMRACE_RaceEthnicityCodes_AffirmativeActionCodeMappingsLink = new SeleniumControl( sDriver, "RaceEthnicityCodes_AffirmativeActionCodeMappingsLink", "ID", "lnk_4300_LDMRACE_HDR");
				Function.WaitControlDisplayed(LDMRACE_RaceEthnicityCodes_AffirmativeActionCodeMappingsLink);
LDMRACE_RaceEthnicityCodes_AffirmativeActionCodeMappingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMRACE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMRACE] Performing VerifyExist on AffirmativeActionCodeMappingsTable...", Logger.MessageType.INF);
				SeleniumControl LDMRACE_AffirmativeActionCodeMappingsTable = new SeleniumControl( sDriver, "AffirmativeActionCodeMappingsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMRACE_AFF_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMRACE_AffirmativeActionCodeMappingsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMRACE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMRACE] Performing Close on AffirmativeActionCodeMappingsForm...", Logger.MessageType.INF);
				SeleniumControl LDMRACE_AffirmativeActionCodeMappingsForm = new SeleniumControl( sDriver, "AffirmativeActionCodeMappingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMRACE_AFF_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMRACE_AffirmativeActionCodeMappingsForm);
IWebElement formBttn = LDMRACE_AffirmativeActionCodeMappingsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EEO-1 Code Mappings");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMRACE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMRACE] Performing VerifyExists on RaceEthnicityCodes_EEO1CodeMappingsLink...", Logger.MessageType.INF);
				SeleniumControl LDMRACE_RaceEthnicityCodes_EEO1CodeMappingsLink = new SeleniumControl( sDriver, "RaceEthnicityCodes_EEO1CodeMappingsLink", "ID", "lnk_4302_LDMRACE_HDR");
				Function.AssertEqual(true,LDMRACE_RaceEthnicityCodes_EEO1CodeMappingsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMRACE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMRACE] Performing Click on RaceEthnicityCodes_EEO1CodeMappingsLink...", Logger.MessageType.INF);
				SeleniumControl LDMRACE_RaceEthnicityCodes_EEO1CodeMappingsLink = new SeleniumControl( sDriver, "RaceEthnicityCodes_EEO1CodeMappingsLink", "ID", "lnk_4302_LDMRACE_HDR");
				Function.WaitControlDisplayed(LDMRACE_RaceEthnicityCodes_EEO1CodeMappingsLink);
LDMRACE_RaceEthnicityCodes_EEO1CodeMappingsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMRACE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMRACE] Performing VerifyExist on EEO1CodeMappingsTable...", Logger.MessageType.INF);
				SeleniumControl LDMRACE_EEO1CodeMappingsTable = new SeleniumControl( sDriver, "EEO1CodeMappingsTable", "xpath", "//div[starts-with(@id,'pr__LDMRACE_EEO1_CHILD_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMRACE_EEO1CodeMappingsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close Application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMRACE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMRACE] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMRACE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMRACE_MainForm);
IWebElement formBttn = LDMRACE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

