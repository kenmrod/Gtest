 
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
    public class HBMBPSET_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Benefits", "xpath","//div[@class='deptItem'][.='Benefits']").Click();
new SeleniumControl(sDriver,"Benefit Entry and Creation", "xpath","//div[@class='navItem'][.='Benefit Entry and Creation']").Click();
new SeleniumControl(sDriver,"Manage Benefit Plans", "xpath","//div[@class='navItem'][.='Manage Benefit Plans']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HBMBPSET_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on BenefitPlanCode...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_BenefitPlanCode = new SeleniumControl( sDriver, "BenefitPlanCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BEN_PLAN_CD']");
				Function.AssertEqual(true,HBMBPSET_BenefitPlanCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,HBMBPSET_MainFormTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(HBMBPSET_MainFormTab);
IWebElement mTab = HBMBPSET_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Benefit Plan Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on BenefitPlanDetails_Provider...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_BenefitPlanDetails_Provider = new SeleniumControl( sDriver, "BenefitPlanDetails_Provider", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROVIDER_CD']");
				Function.AssertEqual(true,HBMBPSET_BenefitPlanDetails_Provider.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(HBMBPSET_MainFormTab);
IWebElement mTab = HBMBPSET_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Eligibility Rules").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on EligibilityRules_MinimumAge...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_EligibilityRules_MinimumAge = new SeleniumControl( sDriver, "EligibilityRules_MinimumAge", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='MIN_AGE_NO']");
				Function.AssertEqual(true,HBMBPSET_EligibilityRules_MinimumAge.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(HBMBPSET_MainFormTab);
IWebElement mTab = HBMBPSET_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Enrollment/Coverage Rules").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on EnrollmentCoverageRules_CoverageRules_AnyTime...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_EnrollmentCoverageRules_CoverageRules_AnyTime = new SeleniumControl( sDriver, "EnrollmentCoverageRules_CoverageRules_AnyTime", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ENRLL_ANY_FL']");
				Function.AssertEqual(true,HBMBPSET_EnrollmentCoverageRules_CoverageRules_AnyTime.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMBPSET_MainForm);
IWebElement formBttn = HBMBPSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HBMBPSET_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HBMBPSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMBPSET_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMBPSET_MainForm);
IWebElement formBttn = HBMBPSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HBMBPSET_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HBMBPSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on CoverageDetailLink...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CoverageDetailLink = new SeleniumControl( sDriver, "CoverageDetailLink", "ID", "lnk_4071_HBMBPSET_HBBENPLANHDR_HDR");
				Function.AssertEqual(true,HBMBPSET_CoverageDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on CoverageOptionsLink...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CoverageOptionsLink = new SeleniumControl( sDriver, "CoverageOptionsLink", "ID", "lnk_4073_HBMBPSET_HBBENPLANHDR_HDR");
				Function.AssertEqual(true,HBMBPSET_CoverageOptionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on ValidPostalCodesLink...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_ValidPostalCodesLink = new SeleniumControl( sDriver, "ValidPostalCodesLink", "ID", "lnk_4075_HBMBPSET_HBBENPLANHDR_HDR");
				Function.AssertEqual(true,HBMBPSET_ValidPostalCodesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on ValidStatesLink...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_ValidStatesLink = new SeleniumControl( sDriver, "ValidStatesLink", "ID", "lnk_4077_HBMBPSET_HBBENPLANHDR_HDR");
				Function.AssertEqual(true,HBMBPSET_ValidStatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing Click on CoverageDetailLink...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CoverageDetailLink = new SeleniumControl( sDriver, "CoverageDetailLink", "ID", "lnk_4071_HBMBPSET_HBBENPLANHDR_HDR");
				Function.WaitControlDisplayed(HBMBPSET_CoverageDetailLink);
HBMBPSET_CoverageDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on CalculationRulesForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CalculationRulesForm = new SeleniumControl( sDriver, "CalculationRulesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_DETAILS_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,HBMBPSET_CalculationRulesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on CalculationRules_AgeCalculationMethod...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CalculationRules_AgeCalculationMethod = new SeleniumControl( sDriver, "CalculationRules_AgeCalculationMethod", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_DETAILS_HDR_']/ancestor::form[1]/descendant::*[@id='S_AGE_CALC_MTHD_CD']");
				Function.AssertEqual(true,HBMBPSET_CalculationRules_AgeCalculationMethod.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on CalculationRules_CopaymentsDeductiblesLink...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CalculationRules_CopaymentsDeductiblesLink = new SeleniumControl( sDriver, "CalculationRules_CopaymentsDeductiblesLink", "ID", "lnk_4072_HBMBPSET_DETAILS_HDR");
				Function.AssertEqual(true,HBMBPSET_CalculationRules_CopaymentsDeductiblesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on CalculationRules_CopaymentsDeductiblesForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CalculationRules_CopaymentsDeductiblesForm = new SeleniumControl( sDriver, "CalculationRules_CopaymentsDeductiblesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANCOPAY_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,HBMBPSET_CalculationRules_CopaymentsDeductiblesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExist on CalculationRules_CopaymentsDeductiblesTable...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CalculationRules_CopaymentsDeductiblesTable = new SeleniumControl( sDriver, "CalculationRules_CopaymentsDeductiblesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANCOPAY_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMBPSET_CalculationRules_CopaymentsDeductiblesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing ClickButton on CalculationRules_CopaymentsDeductiblesForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CalculationRules_CopaymentsDeductiblesForm = new SeleniumControl( sDriver, "CalculationRules_CopaymentsDeductiblesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANCOPAY_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HBMBPSET_CalculationRules_CopaymentsDeductiblesForm);
IWebElement formBttn = HBMBPSET_CalculationRules_CopaymentsDeductiblesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HBMBPSET_CalculationRules_CopaymentsDeductiblesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HBMBPSET_CalculationRules_CopaymentsDeductiblesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on CalculationRules_CopaymentsDeductibles_Type...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CalculationRules_CopaymentsDeductibles_Type = new SeleniumControl( sDriver, "CalculationRules_CopaymentsDeductibles_Type", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANCOPAY_CTW_']/ancestor::form[1]/descendant::*[@id='COPAY_TYPE_DC']");
				Function.AssertEqual(true,HBMBPSET_CalculationRules_CopaymentsDeductibles_Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing Close on CalculationRulesForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CalculationRulesForm = new SeleniumControl( sDriver, "CalculationRulesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_DETAILS_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HBMBPSET_CalculationRulesForm);
IWebElement formBttn = HBMBPSET_CalculationRulesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing Click on CoverageOptionsLink...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CoverageOptionsLink = new SeleniumControl( sDriver, "CoverageOptionsLink", "ID", "lnk_4073_HBMBPSET_HBBENPLANHDR_HDR");
				Function.WaitControlDisplayed(HBMBPSET_CoverageOptionsLink);
HBMBPSET_CoverageOptionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on CoverageOptionForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CoverageOptionForm = new SeleniumControl( sDriver, "CoverageOptionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_OPTIONS_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,HBMBPSET_CoverageOptionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on CoverageOptions_CashOutOption_PayType...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CoverageOptions_CashOutOption_PayType = new SeleniumControl( sDriver, "CoverageOptions_CashOutOption_PayType", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_OPTIONS_HDR_']/ancestor::form[1]/descendant::*[@id='PAY_TYPE']");
				Function.AssertEqual(true,HBMBPSET_CoverageOptions_CashOutOption_PayType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing Click on CoverageOptions_CoverageOptionsDetailsLink...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CoverageOptions_CoverageOptionsDetailsLink = new SeleniumControl( sDriver, "CoverageOptions_CoverageOptionsDetailsLink", "ID", "lnk_4074_HBMBPSET_OPTIONS_HDR");
				Function.WaitControlDisplayed(HBMBPSET_CoverageOptions_CoverageOptionsDetailsLink);
HBMBPSET_CoverageOptions_CoverageOptionsDetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on CoverageOption_CoverageOptionDetailsForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CoverageOption_CoverageOptionDetailsForm = new SeleniumControl( sDriver, "CoverageOption_CoverageOptionDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,HBMBPSET_CoverageOption_CoverageOptionDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExist on CoverageOptions_CoverageOptionDetailsTable...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CoverageOptions_CoverageOptionDetailsTable = new SeleniumControl( sDriver, "CoverageOptions_CoverageOptionDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMBPSET_CoverageOptions_CoverageOptionDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing ClickButton on CoverageOption_CoverageOptionDetailsForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CoverageOption_CoverageOptionDetailsForm = new SeleniumControl( sDriver, "CoverageOption_CoverageOptionDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HBMBPSET_CoverageOption_CoverageOptionDetailsForm);
IWebElement formBttn = HBMBPSET_CoverageOption_CoverageOptionDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HBMBPSET_CoverageOption_CoverageOptionDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HBMBPSET_CoverageOption_CoverageOptionDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on CoverageOptions_CoverageOptionsDetails_StartDate...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CoverageOptions_CoverageOptionsDetails_StartDate = new SeleniumControl( sDriver, "CoverageOptions_CoverageOptionsDetails_StartDate", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANLN_CTW_']/ancestor::form[1]/descendant::*[@id='EFFECT_DT']");
				Function.AssertEqual(true,HBMBPSET_CoverageOptions_CoverageOptionsDetails_StartDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing Close on CoverageOptionForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_CoverageOptionForm = new SeleniumControl( sDriver, "CoverageOptionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_OPTIONS_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HBMBPSET_CoverageOptionForm);
IWebElement formBttn = HBMBPSET_CoverageOptionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing Click on ValidPostalCodesLink...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_ValidPostalCodesLink = new SeleniumControl( sDriver, "ValidPostalCodesLink", "ID", "lnk_4075_HBMBPSET_HBBENPLANHDR_HDR");
				Function.WaitControlDisplayed(HBMBPSET_ValidPostalCodesLink);
HBMBPSET_ValidPostalCodesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on ValidPostalCodesForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_ValidPostalCodesForm = new SeleniumControl( sDriver, "ValidPostalCodesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANPOSTAL_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,HBMBPSET_ValidPostalCodesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExist on ValidPostalCodesTable...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_ValidPostalCodesTable = new SeleniumControl( sDriver, "ValidPostalCodesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANPOSTAL_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMBPSET_ValidPostalCodesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing Close on ValidPostalCodesForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_ValidPostalCodesForm = new SeleniumControl( sDriver, "ValidPostalCodesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANPOSTAL_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HBMBPSET_ValidPostalCodesForm);
IWebElement formBttn = HBMBPSET_ValidPostalCodesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing Click on ValidStatesLink...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_ValidStatesLink = new SeleniumControl( sDriver, "ValidStatesLink", "ID", "lnk_4077_HBMBPSET_HBBENPLANHDR_HDR");
				Function.WaitControlDisplayed(HBMBPSET_ValidStatesLink);
HBMBPSET_ValidStatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExists on ValidStatesForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_ValidStatesForm = new SeleniumControl( sDriver, "ValidStatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANSTATE_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,HBMBPSET_ValidStatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing VerifyExist on ValidStatesTable...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_ValidStatesTable = new SeleniumControl( sDriver, "ValidStatesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANSTATE_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMBPSET_ValidStatesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing Close on ValidStatesForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_ValidStatesForm = new SeleniumControl( sDriver, "ValidStatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMBPSET_HBBENPLANSTATE_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HBMBPSET_ValidStatesForm);
IWebElement formBttn = HBMBPSET_ValidStatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMBPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMBPSET] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMBPSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMBPSET_MainForm);
IWebElement formBttn = HBMBPSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
Function.ClickOkDialogIfExists("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogIfExists]" , ex.Message));
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

