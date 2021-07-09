 
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
    public class LDMUNPRO_01_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Labor", "xpath","//div[@class='deptItem'][.='Labor']").Click();
new SeleniumControl(sDriver,"Union Information Controls", "xpath","//div[@class='navItem'][.='Union Information Controls']").Click();
new SeleniumControl(sDriver,"Manage Union Profile Setup", "xpath","//div[@class='navItem'][.='Manage Union Profile Setup']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing VerifyExists on UnionProfilesForm...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_UnionProfilesForm = new SeleniumControl( sDriver, "UnionProfilesForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDMUNPRO_UnionProfilesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing VerifyExists on UnionProfiles_Union...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_UnionProfiles_Union = new SeleniumControl( sDriver, "UnionProfiles_Union", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='UNION_ID']");
				Function.AssertEqual(true,LDMUNPRO_UnionProfiles_Union.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing ClickButton on UnionProfilesForm...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_UnionProfilesForm = new SeleniumControl( sDriver, "UnionProfilesForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMUNPRO_UnionProfilesForm);
IWebElement formBttn = LDMUNPRO_UnionProfilesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? LDMUNPRO_UnionProfilesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
LDMUNPRO_UnionProfilesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing VerifyExist on UnionProfilesFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_UnionProfilesFormTable = new SeleniumControl( sDriver, "UnionProfilesFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMUNPRO_UnionProfilesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing VerifyExists on ProjectInformationLink...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_ProjectInformationLink = new SeleniumControl( sDriver, "ProjectInformationLink", "ID", "lnk_4560_LDMUNPRO_UNIONPROFLE_HDR");
				Function.AssertEqual(true,LDMUNPRO_ProjectInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing Click on ProjectInformationLink...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_ProjectInformationLink = new SeleniumControl( sDriver, "ProjectInformationLink", "ID", "lnk_4560_LDMUNPRO_UNIONPROFLE_HDR");
				Function.WaitControlDisplayed(LDMUNPRO_ProjectInformationLink);
LDMUNPRO_ProjectInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing VerifyExist on ProjectInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_ProjectInformationFormTable = new SeleniumControl( sDriver, "ProjectInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMUNPRO_UNIONPROFLEPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMUNPRO_ProjectInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing Close on ProjectInformationForm...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_ProjectInformationForm = new SeleniumControl( sDriver, "ProjectInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMUNPRO_UNIONPROFLEPROJ_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMUNPRO_ProjectInformationForm);
IWebElement formBttn = LDMUNPRO_ProjectInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing VerifyExists on FringeInformationLink...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_FringeInformationLink = new SeleniumControl( sDriver, "FringeInformationLink", "ID", "lnk_4562_LDMUNPRO_UNIONPROFLE_HDR");
				Function.AssertEqual(true,LDMUNPRO_FringeInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing Click on FringeInformationLink...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_FringeInformationLink = new SeleniumControl( sDriver, "FringeInformationLink", "ID", "lnk_4562_LDMUNPRO_UNIONPROFLE_HDR");
				Function.WaitControlDisplayed(LDMUNPRO_FringeInformationLink);
LDMUNPRO_FringeInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing VerifyExist on FringeInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_FringeInformationFormTable = new SeleniumControl( sDriver, "FringeInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMUNPRO_UNIONPROFLEFRN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMUNPRO_FringeInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing Close on FringeInformationForm...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_FringeInformationForm = new SeleniumControl( sDriver, "FringeInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMUNPRO_UNIONPROFLEFRN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMUNPRO_FringeInformationForm);
IWebElement formBttn = LDMUNPRO_FringeInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing VerifyExists on DeductionsLink...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_DeductionsLink = new SeleniumControl( sDriver, "DeductionsLink", "ID", "lnk_4564_LDMUNPRO_UNIONPROFLE_HDR");
				Function.AssertEqual(true,LDMUNPRO_DeductionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing Click on DeductionsLink...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_DeductionsLink = new SeleniumControl( sDriver, "DeductionsLink", "ID", "lnk_4564_LDMUNPRO_UNIONPROFLE_HDR");
				Function.WaitControlDisplayed(LDMUNPRO_DeductionsLink);
LDMUNPRO_DeductionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing VerifyExist on DeductionsFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_DeductionsFormTable = new SeleniumControl( sDriver, "DeductionsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMUNPRO_UNIONPROFLEDED_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMUNPRO_DeductionsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMUNPRO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMUNPRO] Performing Close on UnionProfilesForm...", Logger.MessageType.INF);
				SeleniumControl LDMUNPRO_UnionProfilesForm = new SeleniumControl( sDriver, "UnionProfilesForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMUNPRO_UnionProfilesForm);
IWebElement formBttn = LDMUNPRO_UnionProfilesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

