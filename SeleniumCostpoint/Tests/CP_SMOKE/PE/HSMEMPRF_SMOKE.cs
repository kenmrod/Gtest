 
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
    public class HSMEMPRF_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Employee", "xpath","//div[@class='deptItem'][.='Employee']").Click();
new SeleniumControl(sDriver,"Performance Review Processing", "xpath","//div[@class='navItem'][.='Performance Review Processing']").Click();
new SeleniumControl(sDriver,"Manage Employee Review", "xpath","//div[@class='navItem'][.='Manage Employee Review']").Click();


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
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HSMEMPRF_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on Employee...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_Employee = new SeleniumControl( sDriver, "Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,HSMEMPRF_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Table");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMEMPRF_MainForm);
IWebElement formBttn = HSMEMPRF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HSMEMPRF_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HSMEMPRF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMEMPRF_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Section II");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionIILink...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionIILink = new SeleniumControl( sDriver, "SectionIILink", "ID", "lnk_1003598_HSMEMPRF_EMPLRFS1HDR_HDR");
				Function.AssertEqual(true,HSMEMPRF_SectionIILink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing Click on SectionIILink...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionIILink = new SeleniumControl( sDriver, "SectionIILink", "ID", "lnk_1003598_HSMEMPRF_EMPLRFS1HDR_HDR");
				Function.WaitControlDisplayed(HSMEMPRF_SectionIILink);
HSMEMPRF_SectionIILink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionIIEmployeeEvaluationForm...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionIIEmployeeEvaluationForm = new SeleniumControl( sDriver, "SectionIIEmployeeEvaluationForm", "xpath", "//div[starts-with(@id,'pr__HSMEMPRF_EMPLRFS2HDR_')]/ancestor::form[1]");
				Function.AssertEqual(true,HSMEMPRF_SectionIIEmployeeEvaluationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionIIEmployeeEvaluation_WeightedAverageRating...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionIIEmployeeEvaluation_WeightedAverageRating = new SeleniumControl( sDriver, "SectionIIEmployeeEvaluation_WeightedAverageRating", "xpath", "//div[starts-with(@id,'pr__HSMEMPRF_EMPLRFS2HDR_')]/ancestor::form[1]/descendant::*[@id='OVERALL_RT']");
				Function.AssertEqual(true,HSMEMPRF_SectionIIEmployeeEvaluation_WeightedAverageRating.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionII_EvaluationCriteriaForm...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionII_EvaluationCriteriaForm = new SeleniumControl( sDriver, "SectionII_EvaluationCriteriaForm", "xpath", "//div[starts-with(@id,'pr__HSMEMPRF_EMPLRFS2LN_')]/ancestor::form[1]");
				Function.AssertEqual(true,HSMEMPRF_SectionII_EvaluationCriteriaForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExist on SectionII_EvaluationCriteriaFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionII_EvaluationCriteriaFormTable = new SeleniumControl( sDriver, "SectionII_EvaluationCriteriaFormTable", "xpath", "//div[starts-with(@id,'pr__HSMEMPRF_EMPLRFS2LN_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMEMPRF_SectionII_EvaluationCriteriaFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing ClickButton on SectionII_EvaluationCriteriaForm...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionII_EvaluationCriteriaForm = new SeleniumControl( sDriver, "SectionII_EvaluationCriteriaForm", "xpath", "//div[starts-with(@id,'pr__HSMEMPRF_EMPLRFS2LN_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(HSMEMPRF_SectionII_EvaluationCriteriaForm);
IWebElement formBttn = HSMEMPRF_SectionII_EvaluationCriteriaForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HSMEMPRF_SectionII_EvaluationCriteriaForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HSMEMPRF_SectionII_EvaluationCriteriaForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionII_EvaluationCriteria_OrderNumber...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionII_EvaluationCriteria_OrderNumber = new SeleniumControl( sDriver, "SectionII_EvaluationCriteria_OrderNumber", "xpath", "//div[starts-with(@id,'pr__HSMEMPRF_EMPLRFS2LN_')]/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,HSMEMPRF_SectionII_EvaluationCriteria_OrderNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Section III");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionIIILink...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionIIILink = new SeleniumControl( sDriver, "SectionIIILink", "ID", "lnk_4861_HSMEMPRF_EMPLRFS1HDR_HDR");
				Function.AssertEqual(true,HSMEMPRF_SectionIIILink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing Click on SectionIIILink...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionIIILink = new SeleniumControl( sDriver, "SectionIIILink", "ID", "lnk_4861_HSMEMPRF_EMPLRFS1HDR_HDR");
				Function.WaitControlDisplayed(HSMEMPRF_SectionIIILink);
HSMEMPRF_SectionIIILink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionIIIEmployeeDevelopmentForm...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionIIIEmployeeDevelopmentForm = new SeleniumControl( sDriver, "SectionIIIEmployeeDevelopmentForm", "xpath", "//div[starts-with(@id,'pr__HSMEMPRF_EMPL_CHILD_S3_')]/ancestor::form[1]");
				Function.AssertEqual(true,HSMEMPRF_SectionIIIEmployeeDevelopmentForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionIIIEmployeeDevelopment_EmployeeDevelopment...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionIIIEmployeeDevelopment_EmployeeDevelopment = new SeleniumControl( sDriver, "SectionIIIEmployeeDevelopment_EmployeeDevelopment", "xpath", "//div[starts-with(@id,'pr__HSMEMPRF_EMPL_CHILD_S3_')]/ancestor::form[1]/descendant::*[@id='DEVL_TEXT']");
				Function.AssertEqual(true,HSMEMPRF_SectionIIIEmployeeDevelopment_EmployeeDevelopment.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Section IV");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionIVLink...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionIVLink = new SeleniumControl( sDriver, "SectionIVLink", "ID", "lnk_1003601_HSMEMPRF_EMPLRFS1HDR_HDR");
				Function.AssertEqual(true,HSMEMPRF_SectionIVLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing Click on SectionIVLink...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionIVLink = new SeleniumControl( sDriver, "SectionIVLink", "ID", "lnk_1003601_HSMEMPRF_EMPLRFS1HDR_HDR");
				Function.WaitControlDisplayed(HSMEMPRF_SectionIVLink);
HSMEMPRF_SectionIVLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionIVEvaluatorCommentsForm...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionIVEvaluatorCommentsForm = new SeleniumControl( sDriver, "SectionIVEvaluatorCommentsForm", "xpath", "//div[starts-with(@id,'pr__HSMEMPRF_EMPLRFS4_')]/ancestor::form[1]");
				Function.AssertEqual(true,HSMEMPRF_SectionIVEvaluatorCommentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionIVEvaluatorComments_EvaluatorComments...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionIVEvaluatorComments_EvaluatorComments = new SeleniumControl( sDriver, "SectionIVEvaluatorComments_EvaluatorComments", "xpath", "//div[starts-with(@id,'pr__HSMEMPRF_EMPLRFS4_')]/ancestor::form[1]/descendant::*[@id='EMPLR_TEXT']");
				Function.AssertEqual(true,HSMEMPRF_SectionIVEvaluatorComments_EvaluatorComments.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Section V");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionVLink...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionVLink = new SeleniumControl( sDriver, "SectionVLink", "ID", "lnk_1003602_HSMEMPRF_EMPLRFS1HDR_HDR");
				Function.AssertEqual(true,HSMEMPRF_SectionVLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing Click on SectionVLink...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionVLink = new SeleniumControl( sDriver, "SectionVLink", "ID", "lnk_1003602_HSMEMPRF_EMPLRFS1HDR_HDR");
				Function.WaitControlDisplayed(HSMEMPRF_SectionVLink);
HSMEMPRF_SectionVLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionVEmployeeCommentsForm...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionVEmployeeCommentsForm = new SeleniumControl( sDriver, "SectionVEmployeeCommentsForm", "xpath", "//div[starts-with(@id,'pr__HSMEMPRF_EMPLRFS5_')]/ancestor::form[1]");
				Function.AssertEqual(true,HSMEMPRF_SectionVEmployeeCommentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing VerifyExists on SectionVEmployeeComments_ManagerRating...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_SectionVEmployeeComments_ManagerRating = new SeleniumControl( sDriver, "SectionVEmployeeComments_ManagerRating", "xpath", "//div[starts-with(@id,'pr__HSMEMPRF_EMPLRFS5_')]/ancestor::form[1]/descendant::*[@id='S_EMPL_EMPLR_CD']");
				Function.AssertEqual(true,HSMEMPRF_SectionVEmployeeComments_ManagerRating.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close Application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMEMPRF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMEMPRF] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMEMPRF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMEMPRF_MainForm);
IWebElement formBttn = HSMEMPRF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

