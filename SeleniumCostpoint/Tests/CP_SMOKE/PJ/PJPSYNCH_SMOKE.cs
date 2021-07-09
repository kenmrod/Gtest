 
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
    public class PJPSYNCH_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Administrative Utilities", "xpath","//div[@class='navItem'][.='Administrative Utilities']").Click();
new SeleniumControl(sDriver,"Synchronize Project Master Data and Project Edit Data", "xpath","//div[@class='navItem'][.='Synchronize Project Master Data and Project Edit Data']").Click();


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
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Execute.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJPSYNCH_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing VerifyExists on SelectionRanges_Option_Projects...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_SelectionRanges_Option_Projects = new SeleniumControl( sDriver, "SelectionRanges_Option_Projects", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_RANGE']");
				Function.AssertEqual(true,PJPSYNCH_SelectionRanges_Option_Projects.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Discrepancies");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing VerifyExist on DiscrepanciesFormTable...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_DiscrepanciesFormTable = new SeleniumControl( sDriver, "DiscrepanciesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPSYNCH_ZPJPTOOLPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJPSYNCH_DiscrepanciesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing ClickButton on DiscrepanciesForm...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_DiscrepanciesForm = new SeleniumControl( sDriver, "DiscrepanciesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPSYNCH_ZPJPTOOLPROJ_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJPSYNCH_DiscrepanciesForm);
IWebElement formBttn = PJPSYNCH_DiscrepanciesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJPSYNCH_DiscrepanciesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJPSYNCH_DiscrepanciesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing VerifyExists on DiscrepanciesForm...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_DiscrepanciesForm = new SeleniumControl( sDriver, "DiscrepanciesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPSYNCH_ZPJPTOOLPROJ_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PJPSYNCH_DiscrepanciesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing VerifyExists on Discrepancies_Project...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_Discrepancies_Project = new SeleniumControl( sDriver, "Discrepancies_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPSYNCH_ZPJPTOOLPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJPSYNCH_Discrepancies_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing Select on Discrepancies_DiscrepanciesTab...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_Discrepancies_DiscrepanciesTab = new SeleniumControl( sDriver, "Discrepancies_DiscrepanciesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPSYNCH_ZPJPTOOLPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJPSYNCH_Discrepancies_DiscrepanciesTab);
IWebElement mTab = PJPSYNCH_Discrepancies_DiscrepanciesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Project Master").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing VerifyExists on Discrepancies_ProjectMaster_ProjectName...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_Discrepancies_ProjectMaster_ProjectName = new SeleniumControl( sDriver, "Discrepancies_ProjectMaster_ProjectName", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPSYNCH_ZPJPTOOLPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='P_PROJ_NAME']");
				Function.AssertEqual(true,PJPSYNCH_Discrepancies_ProjectMaster_ProjectName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing Select on Discrepancies_DiscrepanciesTab...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_Discrepancies_DiscrepanciesTab = new SeleniumControl( sDriver, "Discrepancies_DiscrepanciesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPSYNCH_ZPJPTOOLPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJPSYNCH_Discrepancies_DiscrepanciesTab);
IWebElement mTab = PJPSYNCH_Discrepancies_DiscrepanciesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Project Edit").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing VerifyExists on Discrepancies_ProjectEdit_ProjectName...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_Discrepancies_ProjectEdit_ProjectName = new SeleniumControl( sDriver, "Discrepancies_ProjectEdit_ProjectName", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPSYNCH_ZPJPTOOLPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='PE_PROJ_NAME']");
				Function.AssertEqual(true,PJPSYNCH_Discrepancies_ProjectEdit_ProjectName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Enter Synchrnization Password");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing VerifyExists on Discrepancies_EnterSynchronizationPasswordLink...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_Discrepancies_EnterSynchronizationPasswordLink = new SeleniumControl( sDriver, "Discrepancies_EnterSynchronizationPasswordLink", "ID", "lnk_3493_PJPSYNCH_ZPJPTOOLPROJ_CTW");
				Function.AssertEqual(true,PJPSYNCH_Discrepancies_EnterSynchronizationPasswordLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing Click on Discrepancies_EnterSynchronizationPasswordLink...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_Discrepancies_EnterSynchronizationPasswordLink = new SeleniumControl( sDriver, "Discrepancies_EnterSynchronizationPasswordLink", "ID", "lnk_3493_PJPSYNCH_ZPJPTOOLPROJ_CTW");
				Function.WaitControlDisplayed(PJPSYNCH_Discrepancies_EnterSynchronizationPasswordLink);
PJPSYNCH_Discrepancies_EnterSynchronizationPasswordLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing VerifyExists on Discrepancies_EnterSynchronizationPasswordForm...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_Discrepancies_EnterSynchronizationPasswordForm = new SeleniumControl( sDriver, "Discrepancies_EnterSynchronizationPasswordForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPSYNCH_SYNCH_PW_']/ancestor::form[1]");
				Function.AssertEqual(true,PJPSYNCH_Discrepancies_EnterSynchronizationPasswordForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing VerifyExists on Discrepancies_EnterSynchronizationPassword_FromProjectEditToProjectMasterPassword...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_Discrepancies_EnterSynchronizationPassword_FromProjectEditToProjectMasterPassword = new SeleniumControl( sDriver, "Discrepancies_EnterSynchronizationPassword_FromProjectEditToProjectMasterPassword", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPSYNCH_SYNCH_PW_']/ancestor::form[1]/descendant::*[@id='PE_TO_PM_PW']");
				Function.AssertEqual(true,PJPSYNCH_Discrepancies_EnterSynchronizationPassword_FromProjectEditToProjectMasterPassword.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing Close on Discrepancies_EnterSynchronizationPasswordForm...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_Discrepancies_EnterSynchronizationPasswordForm = new SeleniumControl( sDriver, "Discrepancies_EnterSynchronizationPasswordForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJPSYNCH_SYNCH_PW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJPSYNCH_Discrepancies_EnterSynchronizationPasswordForm);
IWebElement formBttn = PJPSYNCH_Discrepancies_EnterSynchronizationPasswordForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PJPSYNCH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJPSYNCH] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJPSYNCH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJPSYNCH_MainForm);
IWebElement formBttn = PJPSYNCH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

