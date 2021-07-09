 
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
    public class PJMALJNL_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Cost and Revenue Processing", "xpath","//div[@class='deptItem'][.='Cost and Revenue Processing']").Click();
new SeleniumControl(sDriver,"Cost Pool Processing", "xpath","//div[@class='navItem'][.='Cost Pool Processing']").Click();
new SeleniumControl(sDriver,"Manage Allocation Journals", "xpath","//div[@class='navItem'][.='Manage Allocation Journals']").Click();


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
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMALJNL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing VerifyExists on Identification_AllocationGroup...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_Identification_AllocationGroup = new SeleniumControl( sDriver, "Identification_AllocationGroup", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ALLOC_GRP_NO']");
				Function.AssertEqual(true,PJMALJNL_Identification_AllocationGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("IMPORT LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing VerifyExists on ImportLink...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_ImportLink = new SeleniumControl( sDriver, "ImportLink", "ID", "lnk_1002873_PJMALJNL_ALLOCBASISJNL_HDR");
				Function.AssertEqual(true,PJMALJNL_ImportLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing Click on ImportLink...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_ImportLink = new SeleniumControl( sDriver, "ImportLink", "ID", "lnk_1002873_PJMALJNL_ALLOCBASISJNL_HDR");
				Function.WaitControlDisplayed(PJMALJNL_ImportLink);
PJMALJNL_ImportLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing VerifyExists on ImportForm...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_ImportForm = new SeleniumControl( sDriver, "ImportForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALJNL_IMPORT_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMALJNL_ImportForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing VerifyExists on Import_SelectPeriods_FiscalYear_Starting...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_Import_SelectPeriods_FiscalYear_Starting = new SeleniumControl( sDriver, "Import_SelectPeriods_FiscalYear_Starting", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALJNL_IMPORT_']/ancestor::form[1]/descendant::*[@id='FISCAL_YEAR']");
				Function.AssertEqual(true,PJMALJNL_Import_SelectPeriods_FiscalYear_Starting.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM TABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing Close on ImportForm...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_ImportForm = new SeleniumControl( sDriver, "ImportForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALJNL_IMPORT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMALJNL_ImportForm);
IWebElement formBttn = PJMALJNL_ImportForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMALJNL_MainForm);
IWebElement formBttn = PJMALJNL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMALJNL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMALJNL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMALJNL_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DETAILS FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing VerifyExist on DetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_DetailsFormTable = new SeleniumControl( sDriver, "DetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALJNL_ALLOCBASISJNL_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMALJNL_DetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing ClickButton on DetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_DetailsForm = new SeleniumControl( sDriver, "DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALJNL_ALLOCBASISJNL_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMALJNL_DetailsForm);
IWebElement formBttn = PJMALJNL_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMALJNL_DetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMALJNL_DetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing VerifyExists on DetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_DetailsForm = new SeleniumControl( sDriver, "DetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALJNL_ALLOCBASISJNL_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMALJNL_DetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing VerifyExists on Details_Line...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_Details_Line = new SeleniumControl( sDriver, "Details_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALJNL_ALLOCBASISJNL_CHILD_']/ancestor::form[1]/descendant::*[@id='LN_NO']");
				Function.AssertEqual(true,PJMALJNL_Details_Line.Exists());

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
				Function.CurrentComponent = "PJMALJNL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALJNL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMALJNL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMALJNL_MainForm);
IWebElement formBttn = PJMALJNL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogWithMessage("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogWithMessage]" , ex.Message));
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

