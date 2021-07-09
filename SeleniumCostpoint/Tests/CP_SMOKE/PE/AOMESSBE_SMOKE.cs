 
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
    public class AOMESSBE_SMOKE : SeleniumTestScript
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

				this.ScriptLogger.WriteLine("[CP7Main] Performing Set on SearchApplications...", Logger.MessageType.INF);
				SeleniumControl CP7Main_SearchApplications = new SeleniumControl( sDriver, "SearchApplications", "ID", "appFltrFld");
				CP7Main_SearchApplications.Click();
CP7Main_SearchApplications.SendKeys("AOMESSBE", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
CP7Main_SearchApplications.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try
				{
				Function.SendKeys("Down");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SendKeys]" , ex.Message));
				}
								try
				{
				Function.SendKeys("Enter");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SendKeys]" , ex.Message));
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
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,AOMESSBE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExists on Employee...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_Employee = new SeleniumControl( sDriver, "Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,AOMESSBE_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExists on BenefitPlanDetailsForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_BenefitPlanDetailsForm = new SeleniumControl( sDriver, "BenefitPlanDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,AOMESSBE_BenefitPlanDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing ClickButtonIfExists on BenefitPlanDetailsForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_BenefitPlanDetailsForm = new SeleniumControl( sDriver, "BenefitPlanDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMESSBE_BenefitPlanDetailsForm);
IWebElement formBttn = AOMESSBE_BenefitPlanDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? AOMESSBE_BenefitPlanDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
AOMESSBE_BenefitPlanDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Table] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExist on BenefitPlanDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_BenefitPlanDetailsFormTable = new SeleniumControl( sDriver, "BenefitPlanDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMESSBE_BenefitPlanDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing ClickButton on BenefitPlanDetailsForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_BenefitPlanDetailsForm = new SeleniumControl( sDriver, "BenefitPlanDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMESSBE_BenefitPlanDetailsForm);
IWebElement formBttn = AOMESSBE_BenefitPlanDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? AOMESSBE_BenefitPlanDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
AOMESSBE_BenefitPlanDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExists on BenefitPlanDetails_BenefitPlan...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_BenefitPlanDetails_BenefitPlan = new SeleniumControl( sDriver, "BenefitPlanDetails_BenefitPlan", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_CTW_']/ancestor::form[1]/descendant::*[@id='BEN_PLAN_CD']");
				Function.AssertEqual(true,AOMESSBE_BenefitPlanDetails_BenefitPlan.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExists on DependentFSAElectionLink...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_DependentFSAElectionLink = new SeleniumControl( sDriver, "DependentFSAElectionLink", "ID", "lnk_5204_AOMESSBE_HBEMPLESSELEC_HDR");
				Function.AssertEqual(true,AOMESSBE_DependentFSAElectionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExists on MedicalFSAElectionLink...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_MedicalFSAElectionLink = new SeleniumControl( sDriver, "MedicalFSAElectionLink", "ID", "lnk_5205_AOMESSBE_HBEMPLESSELEC_HDR");
				Function.AssertEqual(true,AOMESSBE_MedicalFSAElectionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExists on BenefitPlanDetails_EditDependentElectionsLink...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_BenefitPlanDetails_EditDependentElectionsLink = new SeleniumControl( sDriver, "BenefitPlanDetails_EditDependentElectionsLink", "ID", "lnk_5206_AOMESSBE_HBEMPLESSELEC_CTW");
				Function.AssertEqual(true,AOMESSBE_BenefitPlanDetails_EditDependentElectionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing Click on DependentFSAElectionLink...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_DependentFSAElectionLink = new SeleniumControl( sDriver, "DependentFSAElectionLink", "ID", "lnk_5204_AOMESSBE_HBEMPLESSELEC_HDR");
				Function.WaitControlDisplayed(AOMESSBE_DependentFSAElectionLink);
AOMESSBE_DependentFSAElectionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExists on DependentFSAElectionForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_DependentFSAElectionForm = new SeleniumControl( sDriver, "DependentFSAElectionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_FSAELEC_']/ancestor::form[1]");
				Function.AssertEqual(true,AOMESSBE_DependentFSAElectionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExists on DependentFSAElection_FSAYear...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_DependentFSAElection_FSAYear = new SeleniumControl( sDriver, "DependentFSAElection_FSAYear", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_FSAELEC_']/ancestor::form[1]/descendant::*[@id='DEP_FSA_YR_NO']");
				Function.AssertEqual(true,AOMESSBE_DependentFSAElection_FSAYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing ClickButton on DependentFSAElectionForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_DependentFSAElectionForm = new SeleniumControl( sDriver, "DependentFSAElectionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_FSAELEC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMESSBE_DependentFSAElectionForm);
IWebElement formBttn = AOMESSBE_DependentFSAElectionForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? AOMESSBE_DependentFSAElectionForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
AOMESSBE_DependentFSAElectionForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExist on DependentFSAElectionFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_DependentFSAElectionFormTable = new SeleniumControl( sDriver, "DependentFSAElectionFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_FSAELEC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMESSBE_DependentFSAElectionFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing Close on DependentFSAElectionForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_DependentFSAElectionForm = new SeleniumControl( sDriver, "DependentFSAElectionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_FSAELEC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMESSBE_DependentFSAElectionForm);
IWebElement formBttn = AOMESSBE_DependentFSAElectionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing Click on MedicalFSAElectionLink...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_MedicalFSAElectionLink = new SeleniumControl( sDriver, "MedicalFSAElectionLink", "ID", "lnk_5205_AOMESSBE_HBEMPLESSELEC_HDR");
				Function.WaitControlDisplayed(AOMESSBE_MedicalFSAElectionLink);
AOMESSBE_MedicalFSAElectionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExists on MedicalFSAElectionForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_MedicalFSAElectionForm = new SeleniumControl( sDriver, "MedicalFSAElectionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_FSA_']/ancestor::form[1]");
				Function.AssertEqual(true,AOMESSBE_MedicalFSAElectionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExists on MedicalFSAElection_FSAYear...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_MedicalFSAElection_FSAYear = new SeleniumControl( sDriver, "MedicalFSAElection_FSAYear", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_FSA_']/ancestor::form[1]/descendant::*[@id='MED_FSA_YR_NO']");
				Function.AssertEqual(true,AOMESSBE_MedicalFSAElection_FSAYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing ClickButton on MedicalFSAElectionForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_MedicalFSAElectionForm = new SeleniumControl( sDriver, "MedicalFSAElectionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_FSA_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMESSBE_MedicalFSAElectionForm);
IWebElement formBttn = AOMESSBE_MedicalFSAElectionForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? AOMESSBE_MedicalFSAElectionForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
AOMESSBE_MedicalFSAElectionForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExist on MedicalFSAElectionFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_MedicalFSAElectionFormTable = new SeleniumControl( sDriver, "MedicalFSAElectionFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_FSA_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMESSBE_MedicalFSAElectionFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing Close on MedicalFSAElectionForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_MedicalFSAElectionForm = new SeleniumControl( sDriver, "MedicalFSAElectionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBEMPLESSELEC_FSA_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMESSBE_MedicalFSAElectionForm);
IWebElement formBttn = AOMESSBE_MedicalFSAElectionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing Click on BenefitPlanDetails_EditDependentElectionsLink...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_BenefitPlanDetails_EditDependentElectionsLink = new SeleniumControl( sDriver, "BenefitPlanDetails_EditDependentElectionsLink", "ID", "lnk_5206_AOMESSBE_HBEMPLESSELEC_CTW");
				Function.WaitControlDisplayed(AOMESSBE_BenefitPlanDetails_EditDependentElectionsLink);
AOMESSBE_BenefitPlanDetails_EditDependentElectionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExists on BenefitPlanDetails_EditDependentElectionsForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_BenefitPlanDetails_EditDependentElectionsForm = new SeleniumControl( sDriver, "BenefitPlanDetails_EditDependentElectionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBDEPESSELEC_DEP_']/ancestor::form[1]");
				Function.AssertEqual(true,AOMESSBE_BenefitPlanDetails_EditDependentElectionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExist on BenefitPlanDetails_EditDependentElectionsFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_BenefitPlanDetails_EditDependentElectionsFormTable = new SeleniumControl( sDriver, "BenefitPlanDetails_EditDependentElectionsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBDEPESSELEC_DEP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMESSBE_BenefitPlanDetails_EditDependentElectionsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing ClickButton on BenefitPlanDetails_EditDependentElectionsForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_BenefitPlanDetails_EditDependentElectionsForm = new SeleniumControl( sDriver, "BenefitPlanDetails_EditDependentElectionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBDEPESSELEC_DEP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMESSBE_BenefitPlanDetails_EditDependentElectionsForm);
IWebElement formBttn = AOMESSBE_BenefitPlanDetails_EditDependentElectionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? AOMESSBE_BenefitPlanDetails_EditDependentElectionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
AOMESSBE_BenefitPlanDetails_EditDependentElectionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExists on BenefitPlanDetails_EditDependentElections_DependentName...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_BenefitPlanDetails_EditDependentElections_DependentName = new SeleniumControl( sDriver, "BenefitPlanDetails_EditDependentElections_DependentName", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBDEPESSELEC_DEP_']/ancestor::form[1]/descendant::*[@id='LAST_FIRST_NAME']");
				Function.AssertEqual(true,AOMESSBE_BenefitPlanDetails_EditDependentElections_DependentName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing Close on BenefitPlanDetails_EditDependentElectionsForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_BenefitPlanDetails_EditDependentElectionsForm = new SeleniumControl( sDriver, "BenefitPlanDetails_EditDependentElectionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__AOMESSBE_HBDEPESSELEC_DEP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(AOMESSBE_BenefitPlanDetails_EditDependentElectionsForm);
IWebElement formBttn = AOMESSBE_BenefitPlanDetails_EditDependentElectionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMESSBE_MainForm);
IWebElement formBttn = AOMESSBE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? AOMESSBE_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
AOMESSBE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,AOMESSBE_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "AOMESSBE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[AOMESSBE] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl AOMESSBE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(AOMESSBE_MainForm);
IWebElement formBttn = AOMESSBE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

