 
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
    public class PJMGLCE_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Estimate To Complete GLC Hours", "xpath","//div[@class='navItem'][.='Manage Estimate To Complete GLC Hours']").Click();


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
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMGLCE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMGLCE_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMGLCE_MainForm);
IWebElement formBttn = PJMGLCE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMGLCE_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMGLCE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMGLCE_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("GENERAL CATEGORY DETAILS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing VerifyExists on GeneralLaborCategoryDetailsLink...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_GeneralLaborCategoryDetailsLink = new SeleniumControl( sDriver, "GeneralLaborCategoryDetailsLink", "ID", "lnk_1001700_PJMGLCE_ETCGLCHRS_HDR");
				Function.AssertEqual(true,PJMGLCE_GeneralLaborCategoryDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing ClickButton on GeneralLaborCategoryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_GeneralLaborCategoryDetailsForm = new SeleniumControl( sDriver, "GeneralLaborCategoryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMGLCE_ETCGLCHRS_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMGLCE_GeneralLaborCategoryDetailsForm);
IWebElement formBttn = PJMGLCE_GeneralLaborCategoryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMGLCE_GeneralLaborCategoryDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMGLCE_GeneralLaborCategoryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing VerifyExists on GeneralLaborCategoryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_GeneralLaborCategoryDetailsForm = new SeleniumControl( sDriver, "GeneralLaborCategoryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMGLCE_ETCGLCHRS_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMGLCE_GeneralLaborCategoryDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing VerifyExists on GeneralLaborCategoryDetails_GLC...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_GeneralLaborCategoryDetails_GLC = new SeleniumControl( sDriver, "GeneralLaborCategoryDetails_GLC", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMGLCE_ETCGLCHRS_CHLD_']/ancestor::form[1]/descendant::*[@id='GENL_LAB_CAT_CD']");
				Function.AssertEqual(true,PJMGLCE_GeneralLaborCategoryDetails_GLC.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing ClickButton on GeneralLaborCategoryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_GeneralLaborCategoryDetailsForm = new SeleniumControl( sDriver, "GeneralLaborCategoryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMGLCE_ETCGLCHRS_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMGLCE_GeneralLaborCategoryDetailsForm);
IWebElement formBttn = PJMGLCE_GeneralLaborCategoryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMGLCE_GeneralLaborCategoryDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMGLCE_GeneralLaborCategoryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing VerifyExist on GeneralLaborCategoryDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_GeneralLaborCategoryDetailsFormTable = new SeleniumControl( sDriver, "GeneralLaborCategoryDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMGLCE_ETCGLCHRS_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMGLCE_GeneralLaborCategoryDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing VerifyExists on GeneralLaborCategoryDetails_ReviseEstimatetoCompleteLink...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_GeneralLaborCategoryDetails_ReviseEstimatetoCompleteLink = new SeleniumControl( sDriver, "GeneralLaborCategoryDetails_ReviseEstimatetoCompleteLink", "ID", "lnk_1001701_PJMGLCE_ETCGLCHRS_CHLD");
				Function.AssertEqual(true,PJMGLCE_GeneralLaborCategoryDetails_ReviseEstimatetoCompleteLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing Click on GeneralLaborCategoryDetails_ReviseEstimatetoCompleteLink...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_GeneralLaborCategoryDetails_ReviseEstimatetoCompleteLink = new SeleniumControl( sDriver, "GeneralLaborCategoryDetails_ReviseEstimatetoCompleteLink", "ID", "lnk_1001701_PJMGLCE_ETCGLCHRS_CHLD");
				Function.WaitControlDisplayed(PJMGLCE_GeneralLaborCategoryDetails_ReviseEstimatetoCompleteLink);
PJMGLCE_GeneralLaborCategoryDetails_ReviseEstimatetoCompleteLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing VerifyExists on GeneralLaborCategoryDetails_ReviseEstimateToCompleteForm...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_GeneralLaborCategoryDetails_ReviseEstimateToCompleteForm = new SeleniumControl( sDriver, "GeneralLaborCategoryDetails_ReviseEstimateToCompleteForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMGLCE_ETCGLCHRS_REVISE_ETC_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMGLCE_GeneralLaborCategoryDetails_ReviseEstimateToCompleteForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing VerifyExists on GeneralLaborCategoryDetails_ReviseEstimateToComplete_RevisionType_UpdateETCWithBudgetMinusIncurred...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_GeneralLaborCategoryDetails_ReviseEstimateToComplete_RevisionType_UpdateETCWithBudgetMinusIncurred = new SeleniumControl( sDriver, "GeneralLaborCategoryDetails_ReviseEstimateToComplete_RevisionType_UpdateETCWithBudgetMinusIncurred", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMGLCE_ETCGLCHRS_REVISE_ETC_']/ancestor::form[1]/descendant::*[@id='REVISION_TYPE' and @value='E']");
				Function.AssertEqual(true,PJMGLCE_GeneralLaborCategoryDetails_ReviseEstimateToComplete_RevisionType_UpdateETCWithBudgetMinusIncurred.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing Close on GeneralLaborCategoryDetails_ReviseEstimateToCompleteForm...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_GeneralLaborCategoryDetails_ReviseEstimateToCompleteForm = new SeleniumControl( sDriver, "GeneralLaborCategoryDetails_ReviseEstimateToCompleteForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMGLCE_ETCGLCHRS_REVISE_ETC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMGLCE_GeneralLaborCategoryDetails_ReviseEstimateToCompleteForm);
IWebElement formBttn = PJMGLCE_GeneralLaborCategoryDetails_ReviseEstimateToCompleteForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PJMGLCE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMGLCE] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMGLCE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMGLCE_MainForm);
IWebElement formBttn = PJMGLCE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

