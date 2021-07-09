 
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
    public class PRMERF_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Payroll", "xpath","//div[@class='deptItem'][.='Payroll']").Click();
new SeleniumControl(sDriver,"Payroll History", "xpath","//div[@class='navItem'][.='Payroll History']").Click();
new SeleniumControl(sDriver,"Manage Employee Earnings History", "xpath","//div[@class='navItem'][.='Manage Employee Earnings History']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMERF_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on EMPLOYEE...", Logger.MessageType.INF);
				SeleniumControl PRMERF_EMPLOYEE = new SeleniumControl( sDriver, "EMPLOYEE", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PRMERF_EMPLOYEE.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMERF_MainForm);
IWebElement formBttn = PRMERF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMERF_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMERF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMERF_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMERF_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("STATE PAY TYPES LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on StatePayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_StatePayTypesLink = new SeleniumControl( sDriver, "StatePayTypesLink", "ID", "lnk_15363_PRMERF_EARNINGS");
				Function.AssertEqual(true,PRMERF_StatePayTypesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Click on StatePayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_StatePayTypesLink = new SeleniumControl( sDriver, "StatePayTypesLink", "ID", "lnk_15363_PRMERF_EARNINGS");
				Function.WaitControlDisplayed(PRMERF_StatePayTypesLink);
PRMERF_StatePayTypesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on StatePayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_StatePayTypesForm = new SeleniumControl( sDriver, "StatePayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_PAYTYPE_STATE_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMERF_StatePayTypesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExist on StatePayTypesTable...", Logger.MessageType.INF);
				SeleniumControl PRMERF_StatePayTypesTable = new SeleniumControl( sDriver, "StatePayTypesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_PAYTYPE_STATE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMERF_StatePayTypesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on StatePayType_YTDInfoLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_StatePayType_YTDInfoLink = new SeleniumControl( sDriver, "StatePayType_YTDInfoLink", "ID", "lnk_15365_PRMERF_PAYTYPE_STATE");
				Function.AssertEqual(true,PRMERF_StatePayType_YTDInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Close on StatePayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_StatePayTypesForm = new SeleniumControl( sDriver, "StatePayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_PAYTYPE_STATE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMERF_StatePayTypesForm);
IWebElement formBttn = PRMERF_StatePayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PAY TYPES LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on PayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_PayTypesLink = new SeleniumControl( sDriver, "PayTypesLink", "ID", "lnk_15358_PRMERF_EARNINGS");
				Function.AssertEqual(true,PRMERF_PayTypesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Click on PayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_PayTypesLink = new SeleniumControl( sDriver, "PayTypesLink", "ID", "lnk_15358_PRMERF_EARNINGS");
				Function.WaitControlDisplayed(PRMERF_PayTypesLink);
PRMERF_PayTypesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on PayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_PayTypesForm = new SeleniumControl( sDriver, "PayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_PAYTYPE_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMERF_PayTypesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExist on PayTypesTable...", Logger.MessageType.INF);
				SeleniumControl PRMERF_PayTypesTable = new SeleniumControl( sDriver, "PayTypesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_PAYTYPE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMERF_PayTypesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on PayTypeProjectDistributionLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_PayTypeProjectDistributionLink = new SeleniumControl( sDriver, "PayTypeProjectDistributionLink", "ID", "lnk_15360_PRMERF_PAYTYPE");
				Function.AssertEqual(true,PRMERF_PayTypeProjectDistributionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on PayType_YTDInfoLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_PayType_YTDInfoLink = new SeleniumControl( sDriver, "PayType_YTDInfoLink", "ID", "lnk_15361_PRMERF_PAYTYPE");
				Function.AssertEqual(true,PRMERF_PayType_YTDInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Close on PayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_PayTypesForm = new SeleniumControl( sDriver, "PayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_PAYTYPE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMERF_PayTypesForm);
IWebElement formBttn = PRMERF_PayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("STATE TAXES LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on StateTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_StateTaxesLink = new SeleniumControl( sDriver, "StateTaxesLink", "ID", "lnk_15351_PRMERF_EARNINGS");
				Function.AssertEqual(true,PRMERF_StateTaxesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Click on StateTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_StateTaxesLink = new SeleniumControl( sDriver, "StateTaxesLink", "ID", "lnk_15351_PRMERF_EARNINGS");
				Function.WaitControlDisplayed(PRMERF_StateTaxesLink);
PRMERF_StateTaxesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on StateTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_StateTaxesForm = new SeleniumControl( sDriver, "StateTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_TAXES_STATE_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMERF_StateTaxesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExist on StateTaxesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMERF_StateTaxesFormTable = new SeleniumControl( sDriver, "StateTaxesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_TAXES_STATE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMERF_StateTaxesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Close on StateTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_StateTaxesForm = new SeleniumControl( sDriver, "StateTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_TAXES_STATE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMERF_StateTaxesForm);
IWebElement formBttn = PRMERF_StateTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LOCAL TAXES LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on LocalTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_LocalTaxesLink = new SeleniumControl( sDriver, "LocalTaxesLink", "ID", "lnk_15352_PRMERF_EARNINGS");
				Function.AssertEqual(true,PRMERF_LocalTaxesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Click on LocalTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_LocalTaxesLink = new SeleniumControl( sDriver, "LocalTaxesLink", "ID", "lnk_15352_PRMERF_EARNINGS");
				Function.WaitControlDisplayed(PRMERF_LocalTaxesLink);
PRMERF_LocalTaxesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on LocalTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_LocalTaxesForm = new SeleniumControl( sDriver, "LocalTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_TAXES_LOCAL_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMERF_LocalTaxesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExist on LocalTaxesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMERF_LocalTaxesFormTable = new SeleniumControl( sDriver, "LocalTaxesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_TAXES_LOCAL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMERF_LocalTaxesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Close on LocalTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_LocalTaxesForm = new SeleniumControl( sDriver, "LocalTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_TAXES_LOCAL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMERF_LocalTaxesForm);
IWebElement formBttn = PRMERF_LocalTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DEDUCTION LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on DeductionsLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_DeductionsLink = new SeleniumControl( sDriver, "DeductionsLink", "ID", "lnk_15371_PRMERF_EARNINGS");
				Function.AssertEqual(true,PRMERF_DeductionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Click on DeductionsLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_DeductionsLink = new SeleniumControl( sDriver, "DeductionsLink", "ID", "lnk_15371_PRMERF_EARNINGS");
				Function.WaitControlDisplayed(PRMERF_DeductionsLink);
PRMERF_DeductionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on DeductionsForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_DeductionsForm = new SeleniumControl( sDriver, "DeductionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_DED_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMERF_DeductionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExist on DeductionsTable...", Logger.MessageType.INF);
				SeleniumControl PRMERF_DeductionsTable = new SeleniumControl( sDriver, "DeductionsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_DED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMERF_DeductionsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on Deductions_UnionDeductionDetailLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_Deductions_UnionDeductionDetailLink = new SeleniumControl( sDriver, "Deductions_UnionDeductionDetailLink", "ID", "lnk_15372_PRMERF_DED");
				Function.AssertEqual(true,PRMERF_Deductions_UnionDeductionDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on Deductions_GarnishmentDetailLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_Deductions_GarnishmentDetailLink = new SeleniumControl( sDriver, "Deductions_GarnishmentDetailLink", "ID", "lnk_15373_PRMERF_DED");
				Function.AssertEqual(true,PRMERF_Deductions_GarnishmentDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on Deductions_YTDInfoLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_Deductions_YTDInfoLink = new SeleniumControl( sDriver, "Deductions_YTDInfoLink", "ID", "lnk_15376_PRMERF_DED");
				Function.AssertEqual(true,PRMERF_Deductions_YTDInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Close on DeductionsForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_DeductionsForm = new SeleniumControl( sDriver, "DeductionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_DED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMERF_DeductionsForm);
IWebElement formBttn = PRMERF_DeductionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("WORKERS' COMP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on WorkersCompLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_WorkersCompLink = new SeleniumControl( sDriver, "WorkersCompLink", "ID", "lnk_15367_PRMERF_EARNINGS");
				Function.AssertEqual(true,PRMERF_WorkersCompLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Click on WorkersCompLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_WorkersCompLink = new SeleniumControl( sDriver, "WorkersCompLink", "ID", "lnk_15367_PRMERF_EARNINGS");
				Function.WaitControlDisplayed(PRMERF_WorkersCompLink);
PRMERF_WorkersCompLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on WorkersCompForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_WorkersCompForm = new SeleniumControl( sDriver, "WorkersCompForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_WC_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMERF_WorkersCompForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExist on WorkersCompTable...", Logger.MessageType.INF);
				SeleniumControl PRMERF_WorkersCompTable = new SeleniumControl( sDriver, "WorkersCompTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_WC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMERF_WorkersCompTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on WorkersComProjectDistributionLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_WorkersComProjectDistributionLink = new SeleniumControl( sDriver, "WorkersComProjectDistributionLink", "ID", "lnk_15368_PRMERF_WC");
				Function.AssertEqual(true,PRMERF_WorkersComProjectDistributionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on WorkersComp_YTDInfoLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_WorkersComp_YTDInfoLink = new SeleniumControl( sDriver, "WorkersComp_YTDInfoLink", "ID", "lnk_15369_PRMERF_WC");
				Function.AssertEqual(true,PRMERF_WorkersComp_YTDInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Close on WorkersCompForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_WorkersCompForm = new SeleniumControl( sDriver, "WorkersCompForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_WC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMERF_WorkersCompForm);
IWebElement formBttn = PRMERF_WorkersCompForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TAX WITHHOLDING PROJECT DISTRIBUTION LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on TaxWithholdingProjectDistributionLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_TaxWithholdingProjectDistributionLink = new SeleniumControl( sDriver, "TaxWithholdingProjectDistributionLink", "ID", "lnk_15353_PRMERF_EARNINGS");
				Function.AssertEqual(true,PRMERF_TaxWithholdingProjectDistributionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Click on TaxWithholdingProjectDistributionLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_TaxWithholdingProjectDistributionLink = new SeleniumControl( sDriver, "TaxWithholdingProjectDistributionLink", "ID", "lnk_15353_PRMERF_EARNINGS");
				Function.WaitControlDisplayed(PRMERF_TaxWithholdingProjectDistributionLink);
PRMERF_TaxWithholdingProjectDistributionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on TaxesWithheldProjectDistributionForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_TaxesWithheldProjectDistributionForm = new SeleniumControl( sDriver, "TaxesWithheldProjectDistributionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_PROJDIST_TAXES_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMERF_TaxesWithheldProjectDistributionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExist on TaxesWithheldProjectDistributionTable...", Logger.MessageType.INF);
				SeleniumControl PRMERF_TaxesWithheldProjectDistributionTable = new SeleniumControl( sDriver, "TaxesWithheldProjectDistributionTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_PROJDIST_TAXES_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMERF_TaxesWithheldProjectDistributionTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Close on TaxesWithheldProjectDistributionForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_TaxesWithheldProjectDistributionForm = new SeleniumControl( sDriver, "TaxesWithheldProjectDistributionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_PROJDIST_TAXES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMERF_TaxesWithheldProjectDistributionForm);
IWebElement formBttn = PRMERF_TaxesWithheldProjectDistributionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("YTD TAXES LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on YTDTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_YTDTaxesLink = new SeleniumControl( sDriver, "YTDTaxesLink", "ID", "lnk_15354_PRMERF_EARNINGS");
				Function.AssertEqual(true,PRMERF_YTDTaxesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Click on YTDTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_YTDTaxesLink = new SeleniumControl( sDriver, "YTDTaxesLink", "ID", "lnk_15354_PRMERF_EARNINGS");
				Function.WaitControlDisplayed(PRMERF_YTDTaxesLink);
PRMERF_YTDTaxesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on TaxesYTDInfoForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_TaxesYTDInfoForm = new SeleniumControl( sDriver, "TaxesYTDInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_YTD_TAXES_WH_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMERF_TaxesYTDInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on TaxesYTDInfo_YTDTaxes_Taxable_Federal...", Logger.MessageType.INF);
				SeleniumControl PRMERF_TaxesYTDInfo_YTDTaxes_Taxable_Federal = new SeleniumControl( sDriver, "TaxesYTDInfo_YTDTaxes_Taxable_Federal", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_YTD_TAXES_WH_']/ancestor::form[1]/descendant::*[@id='FED_TXBL_AMT']");
				Function.AssertEqual(true,PRMERF_TaxesYTDInfo_YTDTaxes_Taxable_Federal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Close on TaxesYTDInfoForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_TaxesYTDInfoForm = new SeleniumControl( sDriver, "TaxesYTDInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_YTD_TAXES_WH_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMERF_TaxesYTDInfoForm);
IWebElement formBttn = PRMERF_TaxesYTDInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TIMESHEETS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on TimesheetsLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_TimesheetsLink = new SeleniumControl( sDriver, "TimesheetsLink", "ID", "lnk_15385_PRMERF_EARNINGS");
				Function.AssertEqual(true,PRMERF_TimesheetsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Click on TimesheetsLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_TimesheetsLink = new SeleniumControl( sDriver, "TimesheetsLink", "ID", "lnk_15385_PRMERF_EARNINGS");
				Function.WaitControlDisplayed(PRMERF_TimesheetsLink);
PRMERF_TimesheetsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on TimesheetsForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_TimesheetsForm = new SeleniumControl( sDriver, "TimesheetsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_TIMESHEET_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMERF_TimesheetsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExist on TimesheetsTable...", Logger.MessageType.INF);
				SeleniumControl PRMERF_TimesheetsTable = new SeleniumControl( sDriver, "TimesheetsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_TIMESHEET_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMERF_TimesheetsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Close on TimesheetsForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_TimesheetsForm = new SeleniumControl( sDriver, "TimesheetsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_TIMESHEET_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMERF_TimesheetsForm);
IWebElement formBttn = PRMERF_TimesheetsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DIRECT DEPOSIT INFORMATION LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on DirectDepositInformationLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_DirectDepositInformationLink = new SeleniumControl( sDriver, "DirectDepositInformationLink", "ID", "lnk_15386_PRMERF_EARNINGS");
				Function.AssertEqual(true,PRMERF_DirectDepositInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Click on DirectDepositInformationLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_DirectDepositInformationLink = new SeleniumControl( sDriver, "DirectDepositInformationLink", "ID", "lnk_15386_PRMERF_EARNINGS");
				Function.WaitControlDisplayed(PRMERF_DirectDepositInformationLink);
PRMERF_DirectDepositInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on DirectDepositInfoForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_DirectDepositInfoForm = new SeleniumControl( sDriver, "DirectDepositInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_DIRDEPOSIT_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMERF_DirectDepositInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExist on DirectDepositInfoTable...", Logger.MessageType.INF);
				SeleniumControl PRMERF_DirectDepositInfoTable = new SeleniumControl( sDriver, "DirectDepositInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_DIRDEPOSIT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMERF_DirectDepositInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Close on DirectDepositInfoForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_DirectDepositInfoForm = new SeleniumControl( sDriver, "DirectDepositInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_DIRDEPOSIT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMERF_DirectDepositInfoForm);
IWebElement formBttn = PRMERF_DirectDepositInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("FRINGE DETAIL LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on FringeDetailLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_FringeDetailLink = new SeleniumControl( sDriver, "FringeDetailLink", "ID", "lnk_15384_PRMERF_EARNINGS");
				Function.AssertEqual(true,PRMERF_FringeDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Click on FringeDetailLink...", Logger.MessageType.INF);
				SeleniumControl PRMERF_FringeDetailLink = new SeleniumControl( sDriver, "FringeDetailLink", "ID", "lnk_15384_PRMERF_EARNINGS");
				Function.WaitControlDisplayed(PRMERF_FringeDetailLink);
PRMERF_FringeDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExists on FringeDetailForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_FringeDetailForm = new SeleniumControl( sDriver, "FringeDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_FRNG_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMERF_FringeDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing VerifyExist on FringeDetailTable...", Logger.MessageType.INF);
				SeleniumControl PRMERF_FringeDetailTable = new SeleniumControl( sDriver, "FringeDetailTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_FRNG_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMERF_FringeDetailTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Close on FringeDetailForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_FringeDetailForm = new SeleniumControl( sDriver, "FringeDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMERF_FRNG_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMERF_FringeDetailForm);
IWebElement formBttn = PRMERF_FringeDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMERF] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMERF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMERF_MainForm);
IWebElement formBttn = PRMERF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

