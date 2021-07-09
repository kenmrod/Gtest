 
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
    public class PJMPAW_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Project Setup", "xpath","//div[@class='deptItem'][.='Project Setup']").Click();
new SeleniumControl(sDriver,"Charging Information", "xpath","//div[@class='navItem'][.='Charging Information']").Click();
new SeleniumControl(sDriver,"Link Projects/Accounts", "xpath","//div[@class='navItem'][.='Link Projects/Accounts']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing VerifyExist on ProjectAcctsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAcctsFormTable = new SeleniumControl( sDriver, "ProjectAcctsFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPAW_ProjectAcctsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Wild Card Option");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing VerifyExists on ProjectAccts_WildcardOptionLink...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAccts_WildcardOptionLink = new SeleniumControl( sDriver, "ProjectAccts_WildcardOptionLink", "ID", "lnk_1004306_PJM_PROJACCTWILDCARD_HDR");
				Function.AssertEqual(true,PJMPAW_ProjectAccts_WildcardOptionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing Click on ProjectAccts_WildcardOptionLink...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAccts_WildcardOptionLink = new SeleniumControl( sDriver, "ProjectAccts_WildcardOptionLink", "ID", "lnk_1004306_PJM_PROJACCTWILDCARD_HDR");
				Function.WaitControlDisplayed(PJMPAW_ProjectAccts_WildcardOptionLink);
PJMPAW_ProjectAccts_WildcardOptionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing VerifyExists on ProjectAccts_WildCardOptionsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAccts_WildCardOptionsForm = new SeleniumControl( sDriver, "ProjectAccts_WildCardOptionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__WILD_CARD_OPTION_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMPAW_ProjectAccts_WildCardOptionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing VerifyExists on ProjectAccts_WildCardOptions_UseOr_AsWildcardExamplesAreShownBelowLabel...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAccts_WildCardOptions_UseOr_AsWildcardExamplesAreShownBelowLabel = new SeleniumControl( sDriver, "ProjectAccts_WildCardOptions_UseOr_AsWildcardExamplesAreShownBelowLabel", "xpath", "//span[@id='LBL1']/ancestor::form[1]/descendant::*[@id='LBL1']");
				Function.AssertEqual(true,PJMPAW_ProjectAccts_WildCardOptions_UseOr_AsWildcardExamplesAreShownBelowLabel.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing Close on ProjectAccts_WildCardOptionsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAccts_WildCardOptionsForm = new SeleniumControl( sDriver, "ProjectAccts_WildCardOptionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__WILD_CARD_OPTION_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPAW_ProjectAccts_WildCardOptionsForm);
IWebElement formBttn = PJMPAW_ProjectAccts_WildCardOptionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Sample Projects");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing VerifyExists on ProjectAccts_SampleProjectsLink...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAccts_SampleProjectsLink = new SeleniumControl( sDriver, "ProjectAccts_SampleProjectsLink", "ID", "lnk_1006845_PJM_PROJACCTWILDCARD_HDR");
				Function.AssertEqual(true,PJMPAW_ProjectAccts_SampleProjectsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing Click on ProjectAccts_SampleProjectsLink...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAccts_SampleProjectsLink = new SeleniumControl( sDriver, "ProjectAccts_SampleProjectsLink", "ID", "lnk_1006845_PJM_PROJACCTWILDCARD_HDR");
				Function.WaitControlDisplayed(PJMPAW_ProjectAccts_SampleProjectsLink);
PJMPAW_ProjectAccts_SampleProjectsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing VerifyExist on ProjectAccts_SampleProjectsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAccts_SampleProjectsFormTable = new SeleniumControl( sDriver, "ProjectAccts_SampleProjectsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJPAW_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPAW_ProjectAccts_SampleProjectsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing Close on ProjectAccts_SampleProjectsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAccts_SampleProjectsForm = new SeleniumControl( sDriver, "ProjectAccts_SampleProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJPAW_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPAW_ProjectAccts_SampleProjectsForm);
IWebElement formBttn = PJMPAW_ProjectAccts_SampleProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Sample Accounts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing VerifyExists on ProjectAccts_SampleAccountsLink...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAccts_SampleAccountsLink = new SeleniumControl( sDriver, "ProjectAccts_SampleAccountsLink", "ID", "lnk_1006844_PJM_PROJACCTWILDCARD_HDR");
				Function.AssertEqual(true,PJMPAW_ProjectAccts_SampleAccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing Click on ProjectAccts_SampleAccountsLink...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAccts_SampleAccountsLink = new SeleniumControl( sDriver, "ProjectAccts_SampleAccountsLink", "ID", "lnk_1006844_PJM_PROJACCTWILDCARD_HDR");
				Function.WaitControlDisplayed(PJMPAW_ProjectAccts_SampleAccountsLink);
PJMPAW_ProjectAccts_SampleAccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing VerifyExist on ProjectAccts_SampleAccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAccts_SampleAccountsFormTable = new SeleniumControl( sDriver, "ProjectAccts_SampleAccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_ACCTPAW_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPAW_ProjectAccts_SampleAccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing Close on ProjectAccts_SampleAccountsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAccts_SampleAccountsForm = new SeleniumControl( sDriver, "ProjectAccts_SampleAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_ACCTPAW_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPAW_ProjectAccts_SampleAccountsForm);
IWebElement formBttn = PJMPAW_ProjectAccts_SampleAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPAW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPAW] Performing Close on ProjectAcctsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPAW_ProjectAcctsForm = new SeleniumControl( sDriver, "ProjectAcctsForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPAW_ProjectAcctsForm);
IWebElement formBttn = PJMPAW_ProjectAcctsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

