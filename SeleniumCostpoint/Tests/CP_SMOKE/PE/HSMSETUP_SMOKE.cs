 
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
    public class HSMSETUP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Compensation", "xpath","//div[@class='deptItem'][.='Compensation']").Click();
new SeleniumControl(sDriver,"Performance Reviews", "xpath","//div[@class='navItem'][.='Performance Reviews']").Click();
new SeleniumControl(sDriver,"Manage Performance Review Forms", "xpath","//div[@class='navItem'][.='Manage Performance Review Forms']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HSMSETUP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on ReviewFormID...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_ReviewFormID = new SeleniumControl( sDriver, "ReviewFormID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='REVIEW_FORM_ID']");
				Function.AssertEqual(true,HSMSETUP_ReviewFormID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing Click on EmployeeEvaluationLink...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeEvaluationLink = new SeleniumControl( sDriver, "EmployeeEvaluationLink", "ID", "lnk_1002158_HSMSETUP_RFS1CONFIG");
				Function.WaitControlDisplayed(HSMSETUP_EmployeeEvaluationLink);
HSMSETUP_EmployeeEvaluationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on EmployeeEvaluationForm...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeEvaluationForm = new SeleniumControl( sDriver, "EmployeeEvaluationForm", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS2HDRCONFIG_')]/ancestor::form[1]");
				Function.AssertEqual(true,HSMSETUP_EmployeeEvaluationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on EmployeeEvaluation_PrintingOption_PageBreak...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeEvaluation_PrintingOption_PageBreak = new SeleniumControl( sDriver, "EmployeeEvaluation_PrintingOption_PageBreak", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS2HDRCONFIG_')]/ancestor::form[1]/descendant::*[@id='S_BRK_CRIT_CD' and @value='P']");
				Function.AssertEqual(true,HSMSETUP_EmployeeEvaluation_PrintingOption_PageBreak.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on EmployeeEvaluation_EmployeeEvaluationDetailsForm...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeEvaluation_EmployeeEvaluationDetailsForm = new SeleniumControl( sDriver, "EmployeeEvaluation_EmployeeEvaluationDetailsForm", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS2LNCONFIG_')]/ancestor::form[1]");
				Function.AssertEqual(true,HSMSETUP_EmployeeEvaluation_EmployeeEvaluationDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExist on EmployeeEvaluation_EmployeeEvaluationDetailsTable...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeEvaluation_EmployeeEvaluationDetailsTable = new SeleniumControl( sDriver, "EmployeeEvaluation_EmployeeEvaluationDetailsTable", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS2LNCONFIG_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMSETUP_EmployeeEvaluation_EmployeeEvaluationDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing Close on EmployeeEvaluationForm...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeEvaluationForm = new SeleniumControl( sDriver, "EmployeeEvaluationForm", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS2HDRCONFIG_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HSMSETUP_EmployeeEvaluationForm);
IWebElement formBttn = HSMSETUP_EmployeeEvaluationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on EmployeeDevelopmentLink...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeDevelopmentLink = new SeleniumControl( sDriver, "EmployeeDevelopmentLink", "ID", "lnk_1002160_HSMSETUP_RFS1CONFIG");
				Function.AssertEqual(true,HSMSETUP_EmployeeDevelopmentLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing Click on EmployeeDevelopmentLink...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeDevelopmentLink = new SeleniumControl( sDriver, "EmployeeDevelopmentLink", "ID", "lnk_1002160_HSMSETUP_RFS1CONFIG");
				Function.WaitControlDisplayed(HSMSETUP_EmployeeDevelopmentLink);
HSMSETUP_EmployeeDevelopmentLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on EmployeeDevelopment_PrintingOption_PageBreak...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeDevelopment_PrintingOption_PageBreak = new SeleniumControl( sDriver, "EmployeeDevelopment_PrintingOption_PageBreak", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS3CONFIG_')]/ancestor::form[1]/descendant::*[@id='S_BRK_CRIT_CD' and @value='P']");
				Function.AssertEqual(true,HSMSETUP_EmployeeDevelopment_PrintingOption_PageBreak.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on EmployeeDevelopmentForm...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeDevelopmentForm = new SeleniumControl( sDriver, "EmployeeDevelopmentForm", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS3CONFIG_')]/ancestor::form[1]");
				Function.AssertEqual(true,HSMSETUP_EmployeeDevelopmentForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing Close on EmployeeDevelopmentForm...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeDevelopmentForm = new SeleniumControl( sDriver, "EmployeeDevelopmentForm", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS3CONFIG_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HSMSETUP_EmployeeDevelopmentForm);
IWebElement formBttn = HSMSETUP_EmployeeDevelopmentForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on EvaluatorCommentsLink...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EvaluatorCommentsLink = new SeleniumControl( sDriver, "EvaluatorCommentsLink", "ID", "lnk_1002162_HSMSETUP_RFS1CONFIG");
				Function.AssertEqual(true,HSMSETUP_EvaluatorCommentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing Click on EvaluatorCommentsLink...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EvaluatorCommentsLink = new SeleniumControl( sDriver, "EvaluatorCommentsLink", "ID", "lnk_1002162_HSMSETUP_RFS1CONFIG");
				Function.WaitControlDisplayed(HSMSETUP_EvaluatorCommentsLink);
HSMSETUP_EvaluatorCommentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on EvaluatorComments_PrintingOption_PageBreak...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EvaluatorComments_PrintingOption_PageBreak = new SeleniumControl( sDriver, "EvaluatorComments_PrintingOption_PageBreak", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS4CONFIG_')]/ancestor::form[1]/descendant::*[@id='S_BRK_CRIT_CD' and @value='P']");
				Function.AssertEqual(true,HSMSETUP_EvaluatorComments_PrintingOption_PageBreak.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on EvaluatorCommentsForm...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EvaluatorCommentsForm = new SeleniumControl( sDriver, "EvaluatorCommentsForm", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS4CONFIG_')]/ancestor::form[1]");
				Function.AssertEqual(true,HSMSETUP_EvaluatorCommentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing Close on EvaluatorCommentsForm...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EvaluatorCommentsForm = new SeleniumControl( sDriver, "EvaluatorCommentsForm", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS4CONFIG_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HSMSETUP_EvaluatorCommentsForm);
IWebElement formBttn = HSMSETUP_EvaluatorCommentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on EmployeeCommentsLink...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeCommentsLink = new SeleniumControl( sDriver, "EmployeeCommentsLink", "ID", "lnk_1002163_HSMSETUP_RFS1CONFIG");
				Function.AssertEqual(true,HSMSETUP_EmployeeCommentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing Click on EmployeeCommentsLink...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeCommentsLink = new SeleniumControl( sDriver, "EmployeeCommentsLink", "ID", "lnk_1002163_HSMSETUP_RFS1CONFIG");
				Function.WaitControlDisplayed(HSMSETUP_EmployeeCommentsLink);
HSMSETUP_EmployeeCommentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on EmployeeComments_PrintingOption_PageBreak...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeComments_PrintingOption_PageBreak = new SeleniumControl( sDriver, "EmployeeComments_PrintingOption_PageBreak", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS5CONFIG_')]/ancestor::form[1]/descendant::*[@id='S_BRK_CRIT_CD' and @value='P']");
				Function.AssertEqual(true,HSMSETUP_EmployeeComments_PrintingOption_PageBreak.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing VerifyExists on EmployeeCommentsForm...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeCommentsForm = new SeleniumControl( sDriver, "EmployeeCommentsForm", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS5CONFIG_')]/ancestor::form[1]");
				Function.AssertEqual(true,HSMSETUP_EmployeeCommentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing Close on EmployeeCommentsForm...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_EmployeeCommentsForm = new SeleniumControl( sDriver, "EmployeeCommentsForm", "xpath", "//div[starts-with(@id,'pr__HSMSETUP_RFS5CONFIG_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HSMSETUP_EmployeeCommentsForm);
IWebElement formBttn = HSMSETUP_EmployeeCommentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMSETUP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMSETUP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMSETUP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMSETUP_MainForm);
IWebElement formBttn = HSMSETUP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

