 
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
    public class PJMMOD_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Project Master", "xpath","//div[@class='navItem'][.='Project Master']").Click();
new SeleniumControl(sDriver,"Manage Modifications", "xpath","//div[@class='navItem'][.='Manage Modifications']").Click();


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
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMMOD_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMMOD_Project.Exists());

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
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing VerifyExists on UnitInfoLink...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_UnitInfoLink = new SeleniumControl( sDriver, "UnitInfoLink", "ID", "lnk_1004439_PJM_PROJMOD_HDR");
				Function.AssertEqual(true,PJMMOD_UnitInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing Click on UnitInfoLink...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_UnitInfoLink = new SeleniumControl( sDriver, "UnitInfoLink", "ID", "lnk_1004439_PJM_PROJMOD_HDR");
				Function.WaitControlDisplayed(PJMMOD_UnitInfoLink);
PJMMOD_UnitInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing VerifyExists on UnitInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_UnitInfoForm = new SeleniumControl( sDriver, "UnitInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMODUNITS_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMMOD_UnitInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing VerifyExists on UnitInfo_CLIN...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_UnitInfo_CLIN = new SeleniumControl( sDriver, "UnitInfo_CLIN", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMODUNITS_CHILD_']/ancestor::form[1]/descendant::*[@id='CLIN_ID']");
				Function.AssertEqual(true,PJMMOD_UnitInfo_CLIN.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing Close on UnitInfoForm...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_UnitInfoForm = new SeleniumControl( sDriver, "UnitInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMODUNITS_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMMOD_UnitInfoForm);
IWebElement formBttn = PJMMOD_UnitInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing VerifyExists on NotesLink...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_NotesLink = new SeleniumControl( sDriver, "NotesLink", "ID", "lnk_1004440_PJM_PROJMOD_HDR");
				Function.AssertEqual(true,PJMMOD_NotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing Click on NotesLink...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_NotesLink = new SeleniumControl( sDriver, "NotesLink", "ID", "lnk_1004440_PJM_PROJMOD_HDR");
				Function.WaitControlDisplayed(PJMMOD_NotesLink);
PJMMOD_NotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing VerifyExists on NotesForm...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_NotesForm = new SeleniumControl( sDriver, "NotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMODNOTES_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMMOD_NotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing VerifyExists on Notes_Text...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_Notes_Text = new SeleniumControl( sDriver, "Notes_Text", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMODNOTES_CHILD_']/ancestor::form[1]/descendant::*[@id='NOTES']");
				Function.AssertEqual(true,PJMMOD_Notes_Text.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing Close on NotesForm...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_NotesForm = new SeleniumControl( sDriver, "NotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMODNOTES_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMMOD_NotesForm);
IWebElement formBttn = PJMMOD_NotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing VerifyExists on AwardFeeLink...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_AwardFeeLink = new SeleniumControl( sDriver, "AwardFeeLink", "ID", "lnk_3423_PJM_PROJMOD_HDR");
				Function.AssertEqual(true,PJMMOD_AwardFeeLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing Click on AwardFeeLink...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_AwardFeeLink = new SeleniumControl( sDriver, "AwardFeeLink", "ID", "lnk_3423_PJM_PROJMOD_HDR");
				Function.WaitControlDisplayed(PJMMOD_AwardFeeLink);
PJMMOD_AwardFeeLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing VerifyExist on AwardFeeTable...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_AwardFeeTable = new SeleniumControl( sDriver, "AwardFeeTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMOD_AWARDFEE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMMOD_AwardFeeTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing ClickButton on AwardFeeForm...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_AwardFeeForm = new SeleniumControl( sDriver, "AwardFeeForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMOD_AWARDFEE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMMOD_AwardFeeForm);
IWebElement formBttn = PJMMOD_AwardFeeForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMMOD_AwardFeeForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMMOD_AwardFeeForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing VerifyExists on AwardFeeForm...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_AwardFeeForm = new SeleniumControl( sDriver, "AwardFeeForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMOD_AWARDFEE_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMMOD_AwardFeeForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing VerifyExists on AwardFee_ModID...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_AwardFee_ModID = new SeleniumControl( sDriver, "AwardFee_ModID", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMOD_AWARDFEE_']/ancestor::form[1]/descendant::*[@id='PROJ_MOD_ID']");
				Function.AssertEqual(true,PJMMOD_AwardFee_ModID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing Close on AwardFeeForm...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_AwardFeeForm = new SeleniumControl( sDriver, "AwardFeeForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJM_PROJMOD_AWARDFEE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMMOD_AwardFeeForm);
IWebElement formBttn = PJMMOD_AwardFeeForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PJMMOD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMOD] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMMOD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMMOD_MainForm);
IWebElement formBttn = PJMMOD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

