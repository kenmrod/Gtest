 
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
    public class HSMMGMR_02_SMOKE_POSTREQ : SeleniumTestScript
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
new SeleniumControl(sDriver,"Personnel", "xpath","//div[@class='deptItem'][.='Personnel']").Click();
new SeleniumControl(sDriver,"Personnel Controls", "xpath","//div[@class='navItem'][.='Personnel Controls']").Click();
new SeleniumControl(sDriver,"Configure Personnel Settings", "xpath","//div[@class='navItem'][.='Configure Personnel Settings']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMSET] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HPMSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HPMSET_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMSET] Performing VerifyExists on ManagerHRRepresentativeDefaults_ByHROrganization...", Logger.MessageType.INF);
				SeleniumControl HPMSET_ManagerHRRepresentativeDefaults_ByHROrganization = new SeleniumControl( sDriver, "ManagerHRRepresentativeDefaults_ByHROrganization", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_MGR_DFT_MTHD_CD' and @value='H']");
				Function.AssertEqual(true,HPMSET_ManagerHRRepresentativeDefaults_ByHROrganization.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMSET] Performing Select on ManagerHRRepresentativeDefaults_ByCompanyWideOrganization...", Logger.MessageType.INF);
				SeleniumControl HPMSET_ManagerHRRepresentativeDefaults_ByCompanyWideOrganization = new SeleniumControl( sDriver, "ManagerHRRepresentativeDefaults_ByCompanyWideOrganization", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_MGR_DFT_MTHD_CD' and @value='M']");
				Function.WaitControlDisplayed(HPMSET_ManagerHRRepresentativeDefaults_ByCompanyWideOrganization);
HPMSET_ManagerHRRepresentativeDefaults_ByCompanyWideOrganization.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HPMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HPMSET] Performing Select on ManagerHRRepresentativeDefaults_ByHROrganization...", Logger.MessageType.INF);
				SeleniumControl HPMSET_ManagerHRRepresentativeDefaults_ByHROrganization = new SeleniumControl( sDriver, "ManagerHRRepresentativeDefaults_ByHROrganization", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_MGR_DFT_MTHD_CD' and @value='H']");
				Function.WaitControlDisplayed(HPMSET_ManagerHRRepresentativeDefaults_ByHROrganization);
HPMSET_ManagerHRRepresentativeDefaults_ByHROrganization.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Save.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(true));

				this.ScriptLogger.WriteLine("[CP7Main] Performing VerifyMessageExists on MessagesArea...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MessagesArea = new SeleniumControl( sDriver, "MessagesArea", "XPATH", "//div[contains(@class,'msg') and contains(@style,'visible')]");
				Function.WaitControlDisplayed(CP7Main_MessagesArea);
IList<IWebElement> msgElements = sDriver.Instance.FindElements(By.XPath("//span[contains(@class,'msgTextHdr')]/following-sibling::span[not(contains(@class,'msgTextHdr'))]"));
Function.AssertEqual(true, msgElements.ToList().Select(x => new SeleniumControl( sDriver, "x", x).GetValue().Trim()).Any(x => x == "Record modifications successfully completed."));


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyMessageExists]" , ex.Message));
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

