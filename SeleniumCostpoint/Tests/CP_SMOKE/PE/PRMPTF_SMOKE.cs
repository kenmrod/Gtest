 
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
    public class PRMPTF_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Payroll Processing", "xpath","//div[@class='navItem'][.='Payroll Processing']").Click();
new SeleniumControl(sDriver,"Manage Payroll Records", "xpath","//div[@class='navItem'][.='Manage Payroll Records']").Click();


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
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMPTF_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on EMPLOYEE...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_EMPLOYEE = new SeleniumControl( sDriver, "EMPLOYEE", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PRMPTF_EMPLOYEE.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMPTF_MainForm);
IWebElement formBttn = PRMPTF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMPTF_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMPTF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPTF_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("STATE PAY RATES LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on StatePayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_StatePayTypesLink = new SeleniumControl( sDriver, "StatePayTypesLink", "ID", "lnk_15568_PRMPTF_EDIT_PAYROLL");
				Function.AssertEqual(true,PRMPTF_StatePayTypesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Click on StatePayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_StatePayTypesLink = new SeleniumControl( sDriver, "StatePayTypesLink", "ID", "lnk_15568_PRMPTF_EDIT_PAYROLL");
				Function.WaitControlDisplayed(PRMPTF_StatePayTypesLink);
PRMPTF_StatePayTypesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on StatePayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_StatePayTypesForm = new SeleniumControl( sDriver, "StatePayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_PAYTYPE_STATE_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPTF_StatePayTypesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExist on StatePayTypesTable...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_StatePayTypesTable = new SeleniumControl( sDriver, "StatePayTypesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_PAYTYPE_STATE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPTF_StatePayTypesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Close on StatePayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_StatePayTypesForm = new SeleniumControl( sDriver, "StatePayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_PAYTYPE_STATE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPTF_StatePayTypesForm);
IWebElement formBttn = PRMPTF_StatePayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on PayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_PayTypesLink = new SeleniumControl( sDriver, "PayTypesLink", "ID", "lnk_15565_PRMPTF_EDIT_PAYROLL");
				Function.AssertEqual(true,PRMPTF_PayTypesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Click on PayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_PayTypesLink = new SeleniumControl( sDriver, "PayTypesLink", "ID", "lnk_15565_PRMPTF_EDIT_PAYROLL");
				Function.WaitControlDisplayed(PRMPTF_PayTypesLink);
PRMPTF_PayTypesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on PayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_PayTypesForm = new SeleniumControl( sDriver, "PayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_PAYTYPE_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPTF_PayTypesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExist on PayTypesTable...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_PayTypesTable = new SeleniumControl( sDriver, "PayTypesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_PAYTYPE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPTF_PayTypesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on PayTypeProjectDistributionLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_PayTypeProjectDistributionLink = new SeleniumControl( sDriver, "PayTypeProjectDistributionLink", "ID", "lnk_15567_PRMPTF_PAYTYPE");
				Function.AssertEqual(true,PRMPTF_PayTypeProjectDistributionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Close on PayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_PayTypesForm = new SeleniumControl( sDriver, "PayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_PAYTYPE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPTF_PayTypesForm);
IWebElement formBttn = PRMPTF_PayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on StateTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_StateTaxesLink = new SeleniumControl( sDriver, "StateTaxesLink", "ID", "lnk_15528_PRMPTF_EDIT_PAYROLL");
				Function.AssertEqual(true,PRMPTF_StateTaxesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Click on StateTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_StateTaxesLink = new SeleniumControl( sDriver, "StateTaxesLink", "ID", "lnk_15528_PRMPTF_EDIT_PAYROLL");
				Function.WaitControlDisplayed(PRMPTF_StateTaxesLink);
PRMPTF_StateTaxesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on StateTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_StateTaxesForm = new SeleniumControl( sDriver, "StateTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_TAXES_STATE_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPTF_StateTaxesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExist on StateTaxesTable...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_StateTaxesTable = new SeleniumControl( sDriver, "StateTaxesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_TAXES_STATE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPTF_StateTaxesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Close on StateTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_StateTaxesForm = new SeleniumControl( sDriver, "StateTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_TAXES_STATE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPTF_StateTaxesForm);
IWebElement formBttn = PRMPTF_StateTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on LocalTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_LocalTaxesLink = new SeleniumControl( sDriver, "LocalTaxesLink", "ID", "lnk_15529_PRMPTF_EDIT_PAYROLL");
				Function.AssertEqual(true,PRMPTF_LocalTaxesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Click on LocalTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_LocalTaxesLink = new SeleniumControl( sDriver, "LocalTaxesLink", "ID", "lnk_15529_PRMPTF_EDIT_PAYROLL");
				Function.WaitControlDisplayed(PRMPTF_LocalTaxesLink);
PRMPTF_LocalTaxesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on LocalTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_LocalTaxesForm = new SeleniumControl( sDriver, "LocalTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_TAXES_LOCAL_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPTF_LocalTaxesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExist on LocalTaxesTable...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_LocalTaxesTable = new SeleniumControl( sDriver, "LocalTaxesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_TAXES_LOCAL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPTF_LocalTaxesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Close on LocalTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_LocalTaxesForm = new SeleniumControl( sDriver, "LocalTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_TAXES_LOCAL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPTF_LocalTaxesForm);
IWebElement formBttn = PRMPTF_LocalTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DEDUCTIONS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on DeductionsLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_DeductionsLink = new SeleniumControl( sDriver, "DeductionsLink", "ID", "lnk_15572_PRMPTF_EDIT_PAYROLL");
				Function.AssertEqual(true,PRMPTF_DeductionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Click on DeductionsLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_DeductionsLink = new SeleniumControl( sDriver, "DeductionsLink", "ID", "lnk_15572_PRMPTF_EDIT_PAYROLL");
				Function.WaitControlDisplayed(PRMPTF_DeductionsLink);
PRMPTF_DeductionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on DeductionsForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_DeductionsForm = new SeleniumControl( sDriver, "DeductionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_DED_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPTF_DeductionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExist on DeductionsTable...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_DeductionsTable = new SeleniumControl( sDriver, "DeductionsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_DED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPTF_DeductionsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on UnionDeductionDetailLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_UnionDeductionDetailLink = new SeleniumControl( sDriver, "UnionDeductionDetailLink", "ID", "lnk_15573_PRMPTF_DED");
				Function.AssertEqual(true,PRMPTF_UnionDeductionDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on GarnishmentDetailLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_GarnishmentDetailLink = new SeleniumControl( sDriver, "GarnishmentDetailLink", "ID", "lnk_15574_PRMPTF_DED");
				Function.AssertEqual(true,PRMPTF_GarnishmentDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Close on DeductionsForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_DeductionsForm = new SeleniumControl( sDriver, "DeductionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_DED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPTF_DeductionsForm);
IWebElement formBttn = PRMPTF_DeductionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CONTRIBUTIONS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on ContributionsLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_ContributionsLink = new SeleniumControl( sDriver, "ContributionsLink", "ID", "lnk_15575_PRMPTF_EDIT_PAYROLL");
				Function.AssertEqual(true,PRMPTF_ContributionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Click on ContributionsLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_ContributionsLink = new SeleniumControl( sDriver, "ContributionsLink", "ID", "lnk_15575_PRMPTF_EDIT_PAYROLL");
				Function.WaitControlDisplayed(PRMPTF_ContributionsLink);
PRMPTF_ContributionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on ContributionsForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_ContributionsForm = new SeleniumControl( sDriver, "ContributionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_CNTRB_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPTF_ContributionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExist on ContributionsTable...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_ContributionsTable = new SeleniumControl( sDriver, "ContributionsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_CNTRB_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPTF_ContributionsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on ContributionProjectDistributionLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_ContributionProjectDistributionLink = new SeleniumControl( sDriver, "ContributionProjectDistributionLink", "ID", "lnk_15576_PRMPTF_CNTRB");
				Function.AssertEqual(true,PRMPTF_ContributionProjectDistributionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Close on ContributionsForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_ContributionsForm = new SeleniumControl( sDriver, "ContributionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_CNTRB_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPTF_ContributionsForm);
IWebElement formBttn = PRMPTF_ContributionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("WORKERS' COMP LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on WorkersCompLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_WorkersCompLink = new SeleniumControl( sDriver, "WorkersCompLink", "ID", "lnk_15570_PRMPTF_EDIT_PAYROLL");
				Function.AssertEqual(true,PRMPTF_WorkersCompLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Click on WorkersCompLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_WorkersCompLink = new SeleniumControl( sDriver, "WorkersCompLink", "ID", "lnk_15570_PRMPTF_EDIT_PAYROLL");
				Function.WaitControlDisplayed(PRMPTF_WorkersCompLink);
PRMPTF_WorkersCompLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on WorkersCompForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_WorkersCompForm = new SeleniumControl( sDriver, "WorkersCompForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_WC_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPTF_WorkersCompForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExist on WorkersCompTable...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_WorkersCompTable = new SeleniumControl( sDriver, "WorkersCompTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_WC_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPTF_WorkersCompTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on WorkersComProjectDistributionLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_WorkersComProjectDistributionLink = new SeleniumControl( sDriver, "WorkersComProjectDistributionLink", "ID", "lnk_15571_PRMPTF_WC");
				Function.AssertEqual(true,PRMPTF_WorkersComProjectDistributionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Close on WorkersCompForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_WorkersCompForm = new SeleniumControl( sDriver, "WorkersCompForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_WC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPTF_WorkersCompForm);
IWebElement formBttn = PRMPTF_WorkersCompForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on TaxWithholdingProjectDistributionLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_TaxWithholdingProjectDistributionLink = new SeleniumControl( sDriver, "TaxWithholdingProjectDistributionLink", "ID", "lnk_15530_PRMPTF_EDIT_PAYROLL");
				Function.AssertEqual(true,PRMPTF_TaxWithholdingProjectDistributionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Click on TaxWithholdingProjectDistributionLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_TaxWithholdingProjectDistributionLink = new SeleniumControl( sDriver, "TaxWithholdingProjectDistributionLink", "ID", "lnk_15530_PRMPTF_EDIT_PAYROLL");
				Function.WaitControlDisplayed(PRMPTF_TaxWithholdingProjectDistributionLink);
PRMPTF_TaxWithholdingProjectDistributionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on TaxesWithheldProjectDistributionForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_TaxesWithheldProjectDistributionForm = new SeleniumControl( sDriver, "TaxesWithheldProjectDistributionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_PROJDIST_TAXES_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPTF_TaxesWithheldProjectDistributionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExist on TaxesWithheldProjectDistributionTable...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_TaxesWithheldProjectDistributionTable = new SeleniumControl( sDriver, "TaxesWithheldProjectDistributionTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_PROJDIST_TAXES_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPTF_TaxesWithheldProjectDistributionTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Close on TaxesWithheldProjectDistributionForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_TaxesWithheldProjectDistributionForm = new SeleniumControl( sDriver, "TaxesWithheldProjectDistributionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_PROJDIST_TAXES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPTF_TaxesWithheldProjectDistributionForm);
IWebElement formBttn = PRMPTF_TaxesWithheldProjectDistributionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on TimesheetsLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_TimesheetsLink = new SeleniumControl( sDriver, "TimesheetsLink", "ID", "lnk_15577_PRMPTF_EDIT_PAYROLL");
				Function.AssertEqual(true,PRMPTF_TimesheetsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Click on TimesheetsLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_TimesheetsLink = new SeleniumControl( sDriver, "TimesheetsLink", "ID", "lnk_15577_PRMPTF_EDIT_PAYROLL");
				Function.WaitControlDisplayed(PRMPTF_TimesheetsLink);
PRMPTF_TimesheetsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on TimesheetsForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_TimesheetsForm = new SeleniumControl( sDriver, "TimesheetsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_TIMESHEET_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPTF_TimesheetsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExist on TimesheetsTable...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_TimesheetsTable = new SeleniumControl( sDriver, "TimesheetsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_TIMESHEET_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPTF_TimesheetsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Close on TimesheetsForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_TimesheetsForm = new SeleniumControl( sDriver, "TimesheetsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_TIMESHEET_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPTF_TimesheetsForm);
IWebElement formBttn = PRMPTF_TimesheetsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on DirectDepositInformationLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_DirectDepositInformationLink = new SeleniumControl( sDriver, "DirectDepositInformationLink", "ID", "lnk_15578_PRMPTF_EDIT_PAYROLL");
				Function.AssertEqual(true,PRMPTF_DirectDepositInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Click on DirectDepositInformationLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_DirectDepositInformationLink = new SeleniumControl( sDriver, "DirectDepositInformationLink", "ID", "lnk_15578_PRMPTF_EDIT_PAYROLL");
				Function.WaitControlDisplayed(PRMPTF_DirectDepositInformationLink);
PRMPTF_DirectDepositInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on DirectDepositInfoForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_DirectDepositInfoForm = new SeleniumControl( sDriver, "DirectDepositInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_DIRDEPOSIT_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPTF_DirectDepositInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExist on DirectDepositInfoTable...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_DirectDepositInfoTable = new SeleniumControl( sDriver, "DirectDepositInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_DIRDEPOSIT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPTF_DirectDepositInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Close on DirectDepositInfoForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_DirectDepositInfoForm = new SeleniumControl( sDriver, "DirectDepositInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_DIRDEPOSIT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPTF_DirectDepositInfoForm);
IWebElement formBttn = PRMPTF_DirectDepositInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on FringeDetailLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_FringeDetailLink = new SeleniumControl( sDriver, "FringeDetailLink", "ID", "lnk_15579_PRMPTF_EDIT_PAYROLL");
				Function.AssertEqual(true,PRMPTF_FringeDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Click on FringeDetailLink...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_FringeDetailLink = new SeleniumControl( sDriver, "FringeDetailLink", "ID", "lnk_15579_PRMPTF_EDIT_PAYROLL");
				Function.WaitControlDisplayed(PRMPTF_FringeDetailLink);
PRMPTF_FringeDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExists on FrigeDetailForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_FrigeDetailForm = new SeleniumControl( sDriver, "FrigeDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_FRNG_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPTF_FrigeDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing VerifyExist on FrigeDetailTable...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_FrigeDetailTable = new SeleniumControl( sDriver, "FrigeDetailTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_FRNG_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPTF_FrigeDetailTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Close on FrigeDetailForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_FrigeDetailForm = new SeleniumControl( sDriver, "FrigeDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPTF_FRNG_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPTF_FrigeDetailForm);
IWebElement formBttn = PRMPTF_FrigeDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPTF] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMPTF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMPTF_MainForm);
IWebElement formBttn = PRMPTF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

