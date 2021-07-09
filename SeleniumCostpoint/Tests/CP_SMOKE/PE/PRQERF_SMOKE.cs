 
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
    public class PRQERF_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Payroll Reports/Inquiries", "xpath","//div[@class='navItem'][.='Payroll Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Employee Earnings", "xpath","//div[@class='navItem'][.='View Employee Earnings']").Click();


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
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRQERF_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on Identification_Employee...", Logger.MessageType.INF);
				SeleniumControl PRQERF_Identification_Employee = new SeleniumControl( sDriver, "Identification_Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PRQERF_Identification_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Execute.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("FEDERAL/STATE WAGES AND TAXES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on FederalStateWagesandTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxesForm = new SeleniumControl( sDriver, "FederalStateWagesandTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEADT_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQERF_FederalStateWagesandTaxesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExist on FederalStateWagesandTaxesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxesFormTable = new SeleniumControl( sDriver, "FederalStateWagesandTaxesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEADT_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQERF_FederalStateWagesandTaxesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing ClickButton on FederalStateWagesandTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxesForm = new SeleniumControl( sDriver, "FederalStateWagesandTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEADT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_FederalStateWagesandTaxesForm);
IWebElement formBttn = PRQERF_FederalStateWagesandTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQERF_FederalStateWagesandTaxesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQERF_FederalStateWagesandTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on FederalStateWagesandTaxes_EmployeeEarnings_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_TransactionType = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEADT_CHLD_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EMPLOYEE EARNINGS TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PRQERF_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEADT_CHLD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,PRQERF_MainFormTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PRQERF_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEADT_CHLD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRQERF_MainFormTab);
IWebElement mTab = PRQERF_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Employee Earnings").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on FederalStateWagesandTaxes_EmployeeEarnings_FederalTaxes_ExemptPayTypes_Federal...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_FederalTaxes_ExemptPayTypes_Federal = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_FederalTaxes_ExemptPayTypes_Federal", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEADT_CHLD_']/ancestor::form[1]/descendant::*[@id='FED_EXMPT_PT_AMT']");
				Function.AssertEqual(true,PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_FederalTaxes_ExemptPayTypes_Federal.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EMPLYEE TAX SETUP TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PRQERF_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEADT_CHLD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,PRQERF_MainFormTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl PRQERF_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEADT_CHLD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRQERF_MainFormTab);
IWebElement mTab = PRQERF_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Employee Tax Setup").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on FederalStateWagesandTaxes_EmployeeTaxSetup_FederalAndSUTA_Exemptions...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeTaxSetup_FederalAndSUTA_Exemptions = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeTaxSetup_FederalAndSUTA_Exemptions", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEADT_CHLD_']/ancestor::form[1]/descendant::*[@id='FED_EXMPT_NO']");
				Function.AssertEqual(true,PRQERF_FederalStateWagesandTaxes_EmployeeTaxSetup_FederalAndSUTA_Exemptions.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on FederalStateWagesandTaxes_EmployeeEarnings_StatePayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_StatePayTypesLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_StatePayTypesLink", "ID", "lnk_16809_PRQERF_EMPLEADT_CHLD");
				Function.AssertEqual(true,PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_StatePayTypesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Click on FederalStateWagesandTaxes_EmployeeEarnings_StatePayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_StatePayTypesLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_StatePayTypesLink", "ID", "lnk_16809_PRQERF_EMPLEADT_CHLD");
				Function.WaitControlDisplayed(PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_StatePayTypesLink);
PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_StatePayTypesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on StatePayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_StatePayTypesForm = new SeleniumControl( sDriver, "StatePayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLSTATEPAYADT_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQERF_StatePayTypesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on StatePayTypes_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQERF_StatePayTypes_TransactionType = new SeleniumControl( sDriver, "StatePayTypes_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLSTATEPAYADT_DETL_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQERF_StatePayTypes_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing ClickButton on StatePayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_StatePayTypesForm = new SeleniumControl( sDriver, "StatePayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLSTATEPAYADT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_StatePayTypesForm);
IWebElement formBttn = PRQERF_StatePayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRQERF_StatePayTypesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRQERF_StatePayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExist on StatePayTypesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQERF_StatePayTypesFormTable = new SeleniumControl( sDriver, "StatePayTypesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLSTATEPAYADT_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQERF_StatePayTypesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Close on StatePayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_StatePayTypesForm = new SeleniumControl( sDriver, "StatePayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLSTATEPAYADT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_StatePayTypesForm);
IWebElement formBttn = PRQERF_StatePayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on FederalStateWagesandTaxes_EmployeeEarnings_PayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_PayTypesLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_PayTypesLink", "ID", "lnk_1005257_PRQERF_EMPLEADT_CHLD");
				Function.AssertEqual(true,PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_PayTypesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Click on FederalStateWagesandTaxes_EmployeeEarnings_PayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_PayTypesLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_PayTypesLink", "ID", "lnk_1005257_PRQERF_EMPLEADT_CHLD");
				Function.WaitControlDisplayed(PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_PayTypesLink);
PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_PayTypesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExist on PayTypesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQERF_PayTypesFormTable = new SeleniumControl( sDriver, "PayTypesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEPAYTPADT_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQERF_PayTypesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on PayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_PayTypesForm = new SeleniumControl( sDriver, "PayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEPAYTPADT_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQERF_PayTypesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing ClickButton on PayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_PayTypesForm = new SeleniumControl( sDriver, "PayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEPAYTPADT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_PayTypesForm);
IWebElement formBttn = PRQERF_PayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQERF_PayTypesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQERF_PayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on PayTypes_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQERF_PayTypes_TransactionType = new SeleniumControl( sDriver, "PayTypes_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEPAYTPADT_DETL_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQERF_PayTypes_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Close on PayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_PayTypesForm = new SeleniumControl( sDriver, "PayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEPAYTPADT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_PayTypesForm);
IWebElement formBttn = PRQERF_PayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on FederalStateWagesandTaxes_EmployeeEarnings_StateTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_StateTaxesLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_StateTaxesLink", "ID", "lnk_5727_PRQERF_EMPLEADT_CHLD");
				Function.AssertEqual(true,PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_StateTaxesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Click on FederalStateWagesandTaxes_EmployeeEarnings_StateTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_StateTaxesLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_StateTaxesLink", "ID", "lnk_5727_PRQERF_EMPLEADT_CHLD");
				Function.WaitControlDisplayed(PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_StateTaxesLink);
PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_StateTaxesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExist on StateTaxesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQERF_StateTaxesFormTable = new SeleniumControl( sDriver, "StateTaxesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLESTATEADT_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQERF_StateTaxesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on StateTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_StateTaxesForm = new SeleniumControl( sDriver, "StateTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLESTATEADT_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQERF_StateTaxesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing ClickButton on StateTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_StateTaxesForm = new SeleniumControl( sDriver, "StateTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLESTATEADT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_StateTaxesForm);
IWebElement formBttn = PRQERF_StateTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQERF_StateTaxesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQERF_StateTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on StateTaxes_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQERF_StateTaxes_TransactionType = new SeleniumControl( sDriver, "StateTaxes_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLESTATEADT_DETL_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQERF_StateTaxes_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Close on StateTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_StateTaxesForm = new SeleniumControl( sDriver, "StateTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLESTATEADT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_StateTaxesForm);
IWebElement formBttn = PRQERF_StateTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on FederalStateWagesandTaxes_EmployeeEarnings_LocalTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_LocalTaxesLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_LocalTaxesLink", "ID", "lnk_1005264_PRQERF_EMPLEADT_CHLD");
				Function.AssertEqual(true,PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_LocalTaxesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Click on FederalStateWagesandTaxes_EmployeeEarnings_LocalTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_LocalTaxesLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_LocalTaxesLink", "ID", "lnk_1005264_PRQERF_EMPLEADT_CHLD");
				Function.WaitControlDisplayed(PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_LocalTaxesLink);
PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_LocalTaxesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExist on LocalTaxesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQERF_LocalTaxesFormTable = new SeleniumControl( sDriver, "LocalTaxesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLELOCALADT_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQERF_LocalTaxesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on LocalTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_LocalTaxesForm = new SeleniumControl( sDriver, "LocalTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLELOCALADT_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQERF_LocalTaxesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing ClickButton on LocalTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_LocalTaxesForm = new SeleniumControl( sDriver, "LocalTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLELOCALADT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_LocalTaxesForm);
IWebElement formBttn = PRQERF_LocalTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQERF_LocalTaxesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQERF_LocalTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on LocalTaxes_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQERF_LocalTaxes_TransactionType = new SeleniumControl( sDriver, "LocalTaxes_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLELOCALADT_DETL_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQERF_LocalTaxes_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Close on LocalTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_LocalTaxesForm = new SeleniumControl( sDriver, "LocalTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLELOCALADT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_LocalTaxesForm);
IWebElement formBttn = PRQERF_LocalTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on FederalStateWagesandTaxes_EmployeeEarnings_DeductionsLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_DeductionsLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_DeductionsLink", "ID", "lnk_1005260_PRQERF_EMPLEADT_CHLD");
				Function.AssertEqual(true,PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_DeductionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Click on FederalStateWagesandTaxes_EmployeeEarnings_DeductionsLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_DeductionsLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_DeductionsLink", "ID", "lnk_1005260_PRQERF_EMPLEADT_CHLD");
				Function.WaitControlDisplayed(PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_DeductionsLink);
PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_DeductionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExist on DeductionsFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQERF_DeductionsFormTable = new SeleniumControl( sDriver, "DeductionsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEDEDADT_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQERF_DeductionsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on DeductionsForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_DeductionsForm = new SeleniumControl( sDriver, "DeductionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEDEDADT_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQERF_DeductionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing ClickButton on DeductionsForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_DeductionsForm = new SeleniumControl( sDriver, "DeductionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEDEDADT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_DeductionsForm);
IWebElement formBttn = PRQERF_DeductionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQERF_DeductionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQERF_DeductionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on Deductions_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQERF_Deductions_TransactionType = new SeleniumControl( sDriver, "Deductions_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEDEDADT_DETL_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQERF_Deductions_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Close on DeductionsForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_DeductionsForm = new SeleniumControl( sDriver, "DeductionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEDEDADT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_DeductionsForm);
IWebElement formBttn = PRQERF_DeductionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on FederalStateWagesandTaxes_EmployeeEarnings_ContributionsLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_ContributionsLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_ContributionsLink", "ID", "lnk_1005263_PRQERF_EMPLEADT_CHLD");
				Function.AssertEqual(true,PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_ContributionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Click on FederalStateWagesandTaxes_EmployeeEarnings_ContributionsLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_ContributionsLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_ContributionsLink", "ID", "lnk_1005263_PRQERF_EMPLEADT_CHLD");
				Function.WaitControlDisplayed(PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_ContributionsLink);
PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_ContributionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExist on ContributionsFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQERF_ContributionsFormTable = new SeleniumControl( sDriver, "ContributionsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLECNTRBADT_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQERF_ContributionsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on ContributionsForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_ContributionsForm = new SeleniumControl( sDriver, "ContributionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLECNTRBADT_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQERF_ContributionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing ClickButton on ContributionsForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_ContributionsForm = new SeleniumControl( sDriver, "ContributionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLECNTRBADT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_ContributionsForm);
IWebElement formBttn = PRQERF_ContributionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQERF_ContributionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQERF_ContributionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on Contributions_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQERF_Contributions_TransactionType = new SeleniumControl( sDriver, "Contributions_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLECNTRBADT_DETL_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQERF_Contributions_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Close on ContributionsForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_ContributionsForm = new SeleniumControl( sDriver, "ContributionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLECNTRBADT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_ContributionsForm);
IWebElement formBttn = PRQERF_ContributionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on FederalStateWagesandTaxes_EmployeeEarnings_WorkersCompLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_WorkersCompLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_WorkersCompLink", "ID", "lnk_1005258_PRQERF_EMPLEADT_CHLD");
				Function.AssertEqual(true,PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_WorkersCompLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Click on FederalStateWagesandTaxes_EmployeeEarnings_WorkersCompLink...", Logger.MessageType.INF);
				SeleniumControl PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_WorkersCompLink = new SeleniumControl( sDriver, "FederalStateWagesandTaxes_EmployeeEarnings_WorkersCompLink", "ID", "lnk_1005258_PRQERF_EMPLEADT_CHLD");
				Function.WaitControlDisplayed(PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_WorkersCompLink);
PRQERF_FederalStateWagesandTaxes_EmployeeEarnings_WorkersCompLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExist on WorkersCompFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQERF_WorkersCompFormTable = new SeleniumControl( sDriver, "WorkersCompFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEWCADT_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQERF_WorkersCompFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on WorkersCompForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_WorkersCompForm = new SeleniumControl( sDriver, "WorkersCompForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEWCADT_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQERF_WorkersCompForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing ClickButton on WorkersCompForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_WorkersCompForm = new SeleniumControl( sDriver, "WorkersCompForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEWCADT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_WorkersCompForm);
IWebElement formBttn = PRQERF_WorkersCompForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQERF_WorkersCompForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQERF_WorkersCompForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing VerifyExists on WorkersComp_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQERF_WorkersComp_TransactionType = new SeleniumControl( sDriver, "WorkersComp_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEWCADT_CHLD_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQERF_WorkersComp_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Close on WorkersCompForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_WorkersCompForm = new SeleniumControl( sDriver, "WorkersCompForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQERF_EMPLEWCADT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQERF_WorkersCompForm);
IWebElement formBttn = PRQERF_WorkersCompForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PRQERF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQERF] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRQERF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRQERF_MainForm);
IWebElement formBttn = PRQERF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

