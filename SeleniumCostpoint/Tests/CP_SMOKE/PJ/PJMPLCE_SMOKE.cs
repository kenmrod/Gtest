 
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
    public class PJMPLCE_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Estimate To Complete", "xpath","//div[@class='navItem'][.='Estimate To Complete']").Click();
new SeleniumControl(sDriver,"Manage Estimate to Complete PLC Hours", "xpath","//div[@class='navItem'][.='Manage Estimate to Complete PLC Hours']").Click();


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
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMPLCE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMPLCE_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPLCE_MainForm);
IWebElement formBttn = PJMPLCE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMPLCE_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMPLCE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPLCE_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PROJECT LABOR CATEGORY DETAILS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing VerifyExists on ProjectLaborCategoryDetailsLink...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_ProjectLaborCategoryDetailsLink = new SeleniumControl( sDriver, "ProjectLaborCategoryDetailsLink", "ID", "lnk_1002438_PJMPLCE_ETCPLCHRS_HDR");
				Function.AssertEqual(true,PJMPLCE_ProjectLaborCategoryDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing VerifyExist on ProjectLaborCategoryDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_ProjectLaborCategoryDetailsFormTable = new SeleniumControl( sDriver, "ProjectLaborCategoryDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPLCE_ETCPLCHRS_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPLCE_ProjectLaborCategoryDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing ClickButton on ProjectLaborCategoryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_ProjectLaborCategoryDetailsForm = new SeleniumControl( sDriver, "ProjectLaborCategoryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPLCE_ETCPLCHRS_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPLCE_ProjectLaborCategoryDetailsForm);
IWebElement formBttn = PJMPLCE_ProjectLaborCategoryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMPLCE_ProjectLaborCategoryDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMPLCE_ProjectLaborCategoryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing VerifyExists on ProjectLaborCategoryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_ProjectLaborCategoryDetailsForm = new SeleniumControl( sDriver, "ProjectLaborCategoryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPLCE_ETCPLCHRS_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMPLCE_ProjectLaborCategoryDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing VerifyExists on ProjectLaborCategoryDetails_PLC...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_ProjectLaborCategoryDetails_PLC = new SeleniumControl( sDriver, "ProjectLaborCategoryDetails_PLC", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPLCE_ETCPLCHRS_CHLD_']/ancestor::form[1]/descendant::*[@id='BILL_LAB_CAT_CD']");
				Function.AssertEqual(true,PJMPLCE_ProjectLaborCategoryDetails_PLC.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("REVISE ESTIMATE TO COMPLETE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing VerifyExists on ProjectLaborCategoryDetails_ReviseEstimatetoCompleteLink...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_ProjectLaborCategoryDetails_ReviseEstimatetoCompleteLink = new SeleniumControl( sDriver, "ProjectLaborCategoryDetails_ReviseEstimatetoCompleteLink", "ID", "lnk_1002439_PJMPLCE_ETCPLCHRS_CHLD");
				Function.AssertEqual(true,PJMPLCE_ProjectLaborCategoryDetails_ReviseEstimatetoCompleteLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing Click on ProjectLaborCategoryDetails_ReviseEstimatetoCompleteLink...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_ProjectLaborCategoryDetails_ReviseEstimatetoCompleteLink = new SeleniumControl( sDriver, "ProjectLaborCategoryDetails_ReviseEstimatetoCompleteLink", "ID", "lnk_1002439_PJMPLCE_ETCPLCHRS_CHLD");
				Function.WaitControlDisplayed(PJMPLCE_ProjectLaborCategoryDetails_ReviseEstimatetoCompleteLink);
PJMPLCE_ProjectLaborCategoryDetails_ReviseEstimatetoCompleteLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing VerifyExists on ProjectLaborCategoryDetails_ReviseEstimateToCompleteForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_ProjectLaborCategoryDetails_ReviseEstimateToCompleteForm = new SeleniumControl( sDriver, "ProjectLaborCategoryDetails_ReviseEstimateToCompleteForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPLCE_ETCPLCHRS_REVISE_ETC_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMPLCE_ProjectLaborCategoryDetails_ReviseEstimateToCompleteForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing VerifyExists on ProjectLaborCategoryDetails_ReviseEstimateToComplete_RevisionType_UpdateETCWithBudgetMinusIncurred...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_ProjectLaborCategoryDetails_ReviseEstimateToComplete_RevisionType_UpdateETCWithBudgetMinusIncurred = new SeleniumControl( sDriver, "ProjectLaborCategoryDetails_ReviseEstimateToComplete_RevisionType_UpdateETCWithBudgetMinusIncurred", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPLCE_ETCPLCHRS_REVISE_ETC_']/ancestor::form[1]/descendant::*[@id='REVISION_TYPE' and @value='E']");
				Function.AssertEqual(true,PJMPLCE_ProjectLaborCategoryDetails_ReviseEstimateToComplete_RevisionType_UpdateETCWithBudgetMinusIncurred.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing Close on ProjectLaborCategoryDetails_ReviseEstimateToCompleteForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_ProjectLaborCategoryDetails_ReviseEstimateToCompleteForm = new SeleniumControl( sDriver, "ProjectLaborCategoryDetails_ReviseEstimateToCompleteForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPLCE_ETCPLCHRS_REVISE_ETC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPLCE_ProjectLaborCategoryDetails_ReviseEstimateToCompleteForm);
IWebElement formBttn = PJMPLCE_ProjectLaborCategoryDetails_ReviseEstimateToCompleteForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PJMPLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPLCE] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPLCE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPLCE_MainForm);
IWebElement formBttn = PJMPLCE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

