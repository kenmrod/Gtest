 
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
    public class PJMBDTOT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Budgeting and ETC", "xpath","//div[@class='deptItem'][.='Budgeting and ETC']").Click();
new SeleniumControl(sDriver,"Total Budgets", "xpath","//div[@class='navItem'][.='Total Budgets']").Click();
new SeleniumControl(sDriver,"Manage Project Total Budget", "xpath","//div[@class='navItem'][.='Manage Project Total Budget']").Click();


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
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMBDTOT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMBDTOT_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBDTOT_MainForm);
IWebElement formBttn = PJMBDTOT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMBDTOT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMBDTOT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBDTOT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBDTOT_MainForm);
IWebElement formBttn = PJMBDTOT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBDTOT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBDTOT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing VerifyExists on TotalBudgetLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_TotalBudgetLink = new SeleniumControl( sDriver, "TotalBudgetLink", "ID", "lnk_3350_PJMBDTOT_PROJTOTBUDDIR_HEADER");
				Function.AssertEqual(true,PJMBDTOT_TotalBudgetLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Total Budget");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing Click on TotalBudgetLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_TotalBudgetLink = new SeleniumControl( sDriver, "TotalBudgetLink", "ID", "lnk_3350_PJMBDTOT_PROJTOTBUDDIR_HEADER");
				Function.WaitControlDisplayed(PJMBDTOT_TotalBudgetLink);
PJMBDTOT_TotalBudgetLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing VerifyExists on TotalBudgetForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_TotalBudgetForm = new SeleniumControl( sDriver, "TotalBudgetForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDTOT_PROJTOTBUDFEE_TOTAL_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBDTOT_TotalBudgetForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing VerifyExists on TotalBudget_ContractValue_TotalCosts...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_TotalBudget_ContractValue_TotalCosts = new SeleniumControl( sDriver, "TotalBudget_ContractValue_TotalCosts", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDTOT_PROJTOTBUDFEE_TOTAL_']/ancestor::form[1]/descendant::*[@id='CONTVALUECOSTS']");
				Function.AssertEqual(true,PJMBDTOT_TotalBudget_ContractValue_TotalCosts.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing Close on TotalBudgetForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_TotalBudgetForm = new SeleniumControl( sDriver, "TotalBudgetForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDTOT_PROJTOTBUDFEE_TOTAL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDTOT_TotalBudgetForm);
IWebElement formBttn = PJMBDTOT_TotalBudgetForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Direct Budget Information");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing VerifyExists on DirectBudgetInformationForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_DirectBudgetInformationForm = new SeleniumControl( sDriver, "DirectBudgetInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDTOT_PROJTOTBUDDIR_PROJECT_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBDTOT_DirectBudgetInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing VerifyExist on DirectBudgetInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_DirectBudgetInformationFormTable = new SeleniumControl( sDriver, "DirectBudgetInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDTOT_PROJTOTBUDDIR_PROJECT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBDTOT_DirectBudgetInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing ClickButton on DirectBudgetInformationForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_DirectBudgetInformationForm = new SeleniumControl( sDriver, "DirectBudgetInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDTOT_PROJTOTBUDDIR_PROJECT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDTOT_DirectBudgetInformationForm);
IWebElement formBttn = PJMBDTOT_DirectBudgetInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBDTOT_DirectBudgetInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBDTOT_DirectBudgetInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing VerifyExists on DirectBudgetInformation_AccountInformation_Account...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_DirectBudgetInformation_AccountInformation_Account = new SeleniumControl( sDriver, "DirectBudgetInformation_AccountInformation_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDTOT_PROJTOTBUDDIR_PROJECT_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,PJMBDTOT_DirectBudgetInformation_AccountInformation_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing Click on DirectBudgetInformation_IndirectLink...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_DirectBudgetInformation_IndirectLink = new SeleniumControl( sDriver, "DirectBudgetInformation_IndirectLink", "ID", "lnk_1001840_PJMBDTOT_PROJTOTBUDDIR_PROJECT");
				Function.WaitControlDisplayed(PJMBDTOT_DirectBudgetInformation_IndirectLink);
PJMBDTOT_DirectBudgetInformation_IndirectLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing VerifyExists on DirectBudgetInformation_IndirectForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_DirectBudgetInformation_IndirectForm = new SeleniumControl( sDriver, "DirectBudgetInformation_IndirectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDTOT_PROJTOTBUDIND_INDIREC_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMBDTOT_DirectBudgetInformation_IndirectForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing VerifyExist on DirectBudgetInformation_IndirectFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_DirectBudgetInformation_IndirectFormTable = new SeleniumControl( sDriver, "DirectBudgetInformation_IndirectFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDTOT_PROJTOTBUDIND_INDIREC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMBDTOT_DirectBudgetInformation_IndirectFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing ClickButton on DirectBudgetInformation_IndirectForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_DirectBudgetInformation_IndirectForm = new SeleniumControl( sDriver, "DirectBudgetInformation_IndirectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDTOT_PROJTOTBUDIND_INDIREC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDTOT_DirectBudgetInformation_IndirectForm);
IWebElement formBttn = PJMBDTOT_DirectBudgetInformation_IndirectForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMBDTOT_DirectBudgetInformation_IndirectForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMBDTOT_DirectBudgetInformation_IndirectForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing VerifyExists on Indirect_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_Indirect_FiscalYear = new SeleniumControl( sDriver, "Indirect_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDTOT_PROJTOTBUDIND_INDIREC_']/ancestor::form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,PJMBDTOT_Indirect_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing Close on DirectBudgetInformation_IndirectForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_DirectBudgetInformation_IndirectForm = new SeleniumControl( sDriver, "DirectBudgetInformation_IndirectForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMBDTOT_PROJTOTBUDIND_INDIREC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMBDTOT_DirectBudgetInformation_IndirectForm);
IWebElement formBttn = PJMBDTOT_DirectBudgetInformation_IndirectForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMBDTOT_MainForm.Exists());

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
				Function.CurrentComponent = "PJMBDTOT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMBDTOT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMBDTOT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMBDTOT_MainForm);
IWebElement formBttn = PJMBDTOT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

