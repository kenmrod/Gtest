 
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
    public class PJMPOW_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Link Projects/Organizations", "xpath","//div[@class='navItem'][.='Link Projects/Organizations']").Click();


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
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing VerifyExist on ProjectOrgsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgsFormTable = new SeleniumControl( sDriver, "ProjectOrgsFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPOW_ProjectOrgsFormTable.Exists());

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
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing VerifyExists on ProjectOrgs_WildcardOptionLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgs_WildcardOptionLink = new SeleniumControl( sDriver, "ProjectOrgs_WildcardOptionLink", "ID", "lnk_1004365_PJM_PROJORGWILDCARD_CTW");
				Function.AssertEqual(true,PJMPOW_ProjectOrgs_WildcardOptionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing Click on ProjectOrgs_WildcardOptionLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgs_WildcardOptionLink = new SeleniumControl( sDriver, "ProjectOrgs_WildcardOptionLink", "ID", "lnk_1004365_PJM_PROJORGWILDCARD_CTW");
				Function.WaitControlDisplayed(PJMPOW_ProjectOrgs_WildcardOptionLink);
PJMPOW_ProjectOrgs_WildcardOptionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing VerifyExists on ProjectOrgs_WildCardOptionsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgs_WildCardOptionsForm = new SeleniumControl( sDriver, "ProjectOrgs_WildCardOptionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__WILD_CARD_OPTION_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMPOW_ProjectOrgs_WildCardOptionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing VerifyExists on ProjectOrgs_WildCardOptions_UseOr_AsWildcardExamplesAreShownBelowLabel...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgs_WildCardOptions_UseOr_AsWildcardExamplesAreShownBelowLabel = new SeleniumControl( sDriver, "ProjectOrgs_WildCardOptions_UseOr_AsWildcardExamplesAreShownBelowLabel", "xpath", "//span[@id='LBL1']/ancestor::form[1]/descendant::*[@id='LBL1']");
				Function.AssertEqual(true,PJMPOW_ProjectOrgs_WildCardOptions_UseOr_AsWildcardExamplesAreShownBelowLabel.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing Close on ProjectOrgs_WildCardOptionsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgs_WildCardOptionsForm = new SeleniumControl( sDriver, "ProjectOrgs_WildCardOptionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__WILD_CARD_OPTION_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPOW_ProjectOrgs_WildCardOptionsForm);
IWebElement formBttn = PJMPOW_ProjectOrgs_WildCardOptionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing VerifyExists on ProjectOrgs_SampleProjectsLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgs_SampleProjectsLink = new SeleniumControl( sDriver, "ProjectOrgs_SampleProjectsLink", "ID", "lnk_1006847_PJM_PROJORGWILDCARD_CTW");
				Function.AssertEqual(true,PJMPOW_ProjectOrgs_SampleProjectsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing Click on ProjectOrgs_SampleProjectsLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgs_SampleProjectsLink = new SeleniumControl( sDriver, "ProjectOrgs_SampleProjectsLink", "ID", "lnk_1006847_PJM_PROJORGWILDCARD_CTW");
				Function.WaitControlDisplayed(PJMPOW_ProjectOrgs_SampleProjectsLink);
PJMPOW_ProjectOrgs_SampleProjectsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing VerifyExist on ProjectOrgs_SampleProjectsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgs_SampleProjectsFormTable = new SeleniumControl( sDriver, "ProjectOrgs_SampleProjectsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_POWPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPOW_ProjectOrgs_SampleProjectsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing Close on ProjectOrgs_SampleProjectsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgs_SampleProjectsForm = new SeleniumControl( sDriver, "ProjectOrgs_SampleProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_POWPROJ_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPOW_ProjectOrgs_SampleProjectsForm);
IWebElement formBttn = PJMPOW_ProjectOrgs_SampleProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing VerifyExists on ProjectOrgs_SampleOrganizationsLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgs_SampleOrganizationsLink = new SeleniumControl( sDriver, "ProjectOrgs_SampleOrganizationsLink", "ID", "lnk_1006846_PJM_PROJORGWILDCARD_CTW");
				Function.AssertEqual(true,PJMPOW_ProjectOrgs_SampleOrganizationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing Click on ProjectOrgs_SampleOrganizationsLink...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgs_SampleOrganizationsLink = new SeleniumControl( sDriver, "ProjectOrgs_SampleOrganizationsLink", "ID", "lnk_1006846_PJM_PROJORGWILDCARD_CTW");
				Function.WaitControlDisplayed(PJMPOW_ProjectOrgs_SampleOrganizationsLink);
PJMPOW_ProjectOrgs_SampleOrganizationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing VerifyExist on ProjectOrgs_SampleOrganizationsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgs_SampleOrganizationsFormTable = new SeleniumControl( sDriver, "ProjectOrgs_SampleOrganizationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_POWORG_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPOW_ProjectOrgs_SampleOrganizationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing Close on ProjectOrgs_SampleOrganizationsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgs_SampleOrganizationsForm = new SeleniumControl( sDriver, "ProjectOrgs_SampleOrganizationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_POWORG_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPOW_ProjectOrgs_SampleOrganizationsForm);
IWebElement formBttn = PJMPOW_ProjectOrgs_SampleOrganizationsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PJMPOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPOW] Performing Close on ProjectOrgsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPOW_ProjectOrgsForm = new SeleniumControl( sDriver, "ProjectOrgsForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPOW_ProjectOrgsForm);
IWebElement formBttn = PJMPOW_ProjectOrgsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

