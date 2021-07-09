 
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
    public class PRQEINFO_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"View Employee Information", "xpath","//div[@class='navItem'][.='View Employee Information']").Click();


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
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRQEINFO_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Identification_Employee...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Identification_Employee = new SeleniumControl( sDriver, "Identification_Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PRQEINFO_Identification_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExist on TransactionFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_TransactionFormTable = new SeleniumControl( sDriver, "TransactionFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQEINFO_TransactionFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing ClickButton on TransactionForm...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_TransactionForm = new SeleniumControl( sDriver, "TransactionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQEINFO_TransactionForm);
IWebElement formBttn = PRQEINFO_TransactionForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQEINFO_TransactionForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQEINFO_TransactionForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on TransactionForm...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_TransactionForm = new SeleniumControl( sDriver, "TransactionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQEINFO_TransactionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_Employee...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_Employee = new SeleniumControl( sDriver, "Transaction_Employee", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PRQEINFO_Transaction_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("BASIC INFORMATION TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_TransactionTab...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_TransactionTab = new SeleniumControl( sDriver, "Transaction_TransactionTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,PRQEINFO_Transaction_TransactionTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing Select on Transaction_TransactionTab...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_TransactionTab = new SeleniumControl( sDriver, "Transaction_TransactionTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRQEINFO_Transaction_TransactionTab);
IWebElement mTab = PRQEINFO_Transaction_TransactionTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_BasicInformation_SocialSecurityNo...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_BasicInformation_SocialSecurityNo = new SeleniumControl( sDriver, "Transaction_BasicInformation_SocialSecurityNo", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='SSN_ID']");
				Function.AssertEqual(true,PRQEINFO_Transaction_BasicInformation_SocialSecurityNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("HR DATA TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing Select on Transaction_TransactionTab...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_TransactionTab = new SeleniumControl( sDriver, "Transaction_TransactionTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRQEINFO_Transaction_TransactionTab);
IWebElement mTab = PRQEINFO_Transaction_TransactionTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "HR Data").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_HRData_MiscellanousData_Gender...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_HRData_MiscellanousData_Gender = new SeleniumControl( sDriver, "Transaction_HRData_MiscellanousData_Gender", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='SEX_CD']");
				Function.AssertEqual(true,PRQEINFO_Transaction_HRData_MiscellanousData_Gender.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ADDRESS/CONTACT TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing Select on Transaction_TransactionTab...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_TransactionTab = new SeleniumControl( sDriver, "Transaction_TransactionTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRQEINFO_Transaction_TransactionTab);
IWebElement mTab = PRQEINFO_Transaction_TransactionTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Address/Contact").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_AddressContact_MailingAddress_Line1...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_AddressContact_MailingAddress_Line1 = new SeleniumControl( sDriver, "Transaction_AddressContact_MailingAddress_Line1", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='LN_1_ADR']");
				Function.AssertEqual(true,PRQEINFO_Transaction_AddressContact_MailingAddress_Line1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TIMESHEET DEFAULTS TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing Select on Transaction_TransactionTab...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_TransactionTab = new SeleniumControl( sDriver, "Transaction_TransactionTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRQEINFO_Transaction_TransactionTab);
IWebElement mTab = PRQEINFO_Transaction_TransactionTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Timesheet Defaults").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_TimesheetDefaults_TimesheetLine_Account...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_TimesheetDefaults_TimesheetLine_Account = new SeleniumControl( sDriver, "Transaction_TimesheetDefaults_TimesheetLine_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,PRQEINFO_Transaction_TimesheetDefaults_TimesheetLine_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PRODUCT INTERFACE TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing Select on Transaction_TransactionTab...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_TransactionTab = new SeleniumControl( sDriver, "Transaction_TransactionTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRQEINFO_Transaction_TransactionTab);
IWebElement mTab = PRQEINFO_Transaction_TransactionTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Product Interface").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_ProductInterface_PayrollServiceID...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_ProductInterface_PayrollServiceID = new SeleniumControl( sDriver, "Transaction_ProductInterface_PayrollServiceID", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='PR_SERV_EMPL_ID']");
				Function.AssertEqual(true,PRQEINFO_Transaction_ProductInterface_PayrollServiceID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("NOTES TAB");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing Select on Transaction_TransactionTab...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_TransactionTab = new SeleniumControl( sDriver, "Transaction_TransactionTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRQEINFO_Transaction_TransactionTab);
IWebElement mTab = PRQEINFO_Transaction_TransactionTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_Notes_Notes = new SeleniumControl( sDriver, "Transaction_Notes_Notes", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]/descendant::*[@id='NOTES']");
				Function.AssertEqual(true,PRQEINFO_Transaction_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ADDITIONAL ADDRESSESSES LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing ClickButton on TransactionForm...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_TransactionForm = new SeleniumControl( sDriver, "TransactionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQEINFO_TransactionForm);
IWebElement formBttn = PRQEINFO_TransactionForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PRQEINFO_TransactionForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PRQEINFO_TransactionForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								new SeleniumControl(sDriver, "ConditionName", "id", "fieldList").Click();
                new OpenQA.Selenium.Interactions.Actions(sDriver.Instance).SendKeys(Keys.PageDown).SendKeys(Keys.PageDown).Build().Perform();
                new SeleniumControl(sDriver, "ConditionItem", "xpath_display", ".//div[@class='tCCBV']//descendant::div[text() = 'Employee']").Click();
new SeleniumControl(sDriver, "Relationship", "id", "relationList").Click();
new SeleniumControl(sDriver, "RelationItem", "xpath_display", ".//descendant::div[text() = 'is equal']").Click();
                new SeleniumControl(sDriver, "Value", "id", "valueEntered").SendKeys("KAREN");
new SeleniumControl(sDriver, "AddButton", "id", "AddBtn").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [AddQueryCondition]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Query...", Logger.MessageType.INF);
				SeleniumControl Query_Query = new SeleniumControl( sDriver, "Query", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Query);
                    Query_Query.Click();

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_AdditionalAddressesLink...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_AdditionalAddressesLink = new SeleniumControl( sDriver, "Transaction_AdditionalAddressesLink", "ID", "lnk_16095_PRQEINFO_EMPLADT_CTW");
				Function.AssertEqual(true,PRQEINFO_Transaction_AdditionalAddressesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing Click on Transaction_AdditionalAddressesLink...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_AdditionalAddressesLink = new SeleniumControl( sDriver, "Transaction_AdditionalAddressesLink", "ID", "lnk_16095_PRQEINFO_EMPLADT_CTW");
				Function.WaitControlDisplayed(PRQEINFO_Transaction_AdditionalAddressesLink);
PRQEINFO_Transaction_AdditionalAddressesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExist on Transaction_AdditionalAddressesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_AdditionalAddressesFormTable = new SeleniumControl( sDriver, "Transaction_AdditionalAddressesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLSUPADR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQEINFO_Transaction_AdditionalAddressesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing ClickButton on Transaction_AdditionalAddressesForm...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_AdditionalAddressesForm = new SeleniumControl( sDriver, "Transaction_AdditionalAddressesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLSUPADR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQEINFO_Transaction_AdditionalAddressesForm);
IWebElement formBttn = PRQEINFO_Transaction_AdditionalAddressesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQEINFO_Transaction_AdditionalAddressesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQEINFO_Transaction_AdditionalAddressesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_AdditionalAddresses_Line1...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_AdditionalAddresses_Line1 = new SeleniumControl( sDriver, "Transaction_AdditionalAddresses_Line1", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLSUPADR_']/ancestor::form[1]/descendant::*[@id='SUP_LN_1_ADR']");
				Function.AssertEqual(true,PRQEINFO_Transaction_AdditionalAddresses_Line1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing Close on Transaction_AdditionalAddressesForm...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_AdditionalAddressesForm = new SeleniumControl( sDriver, "Transaction_AdditionalAddressesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLSUPADR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQEINFO_Transaction_AdditionalAddressesForm);
IWebElement formBttn = PRQEINFO_Transaction_AdditionalAddressesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PHONE LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_PhoneLink...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_PhoneLink = new SeleniumControl( sDriver, "Transaction_PhoneLink", "ID", "lnk_16096_PRQEINFO_EMPLADT_CTW");
				Function.AssertEqual(true,PRQEINFO_Transaction_PhoneLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing Click on Transaction_PhoneLink...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_PhoneLink = new SeleniumControl( sDriver, "Transaction_PhoneLink", "ID", "lnk_16096_PRQEINFO_EMPLADT_CTW");
				Function.WaitControlDisplayed(PRQEINFO_Transaction_PhoneLink);
PRQEINFO_Transaction_PhoneLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExist on Transaction_EmployeePhoneInquiryFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_EmployeePhoneInquiryFormTable = new SeleniumControl( sDriver, "Transaction_EmployeePhoneInquiryFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLPHONEADT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQEINFO_Transaction_EmployeePhoneInquiryFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_EmployeePhoneInquiryForm...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_EmployeePhoneInquiryForm = new SeleniumControl( sDriver, "Transaction_EmployeePhoneInquiryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLPHONEADT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQEINFO_Transaction_EmployeePhoneInquiryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing ClickButton on Transaction_EmployeePhoneInquiryForm...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_EmployeePhoneInquiryForm = new SeleniumControl( sDriver, "Transaction_EmployeePhoneInquiryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLPHONEADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQEINFO_Transaction_EmployeePhoneInquiryForm);
IWebElement formBttn = PRQEINFO_Transaction_EmployeePhoneInquiryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQEINFO_Transaction_EmployeePhoneInquiryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQEINFO_Transaction_EmployeePhoneInquiryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_EmployeePhoneInquiry_Transaction_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_EmployeePhoneInquiry_Transaction_TransactionType = new SeleniumControl( sDriver, "Transaction_EmployeePhoneInquiry_Transaction_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLPHONEADT_CTW_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQEINFO_Transaction_EmployeePhoneInquiry_Transaction_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing Close on Transaction_EmployeePhoneInquiryForm...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_EmployeePhoneInquiryForm = new SeleniumControl( sDriver, "Transaction_EmployeePhoneInquiryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_EMPLPHONEADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQEINFO_Transaction_EmployeePhoneInquiryForm);
IWebElement formBttn = PRQEINFO_Transaction_EmployeePhoneInquiryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ADDITIONAL DEFAULT PAY TYPES LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExists on Transaction_AdditionalDefaultPayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_AdditionalDefaultPayTypesLink = new SeleniumControl( sDriver, "Transaction_AdditionalDefaultPayTypesLink", "ID", "lnk_16097_PRQEINFO_EMPLADT_CTW");
				Function.AssertEqual(true,PRQEINFO_Transaction_AdditionalDefaultPayTypesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing Click on Transaction_AdditionalDefaultPayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_AdditionalDefaultPayTypesLink = new SeleniumControl( sDriver, "Transaction_AdditionalDefaultPayTypesLink", "ID", "lnk_16097_PRQEINFO_EMPLADT_CTW");
				Function.WaitControlDisplayed(PRQEINFO_Transaction_AdditionalDefaultPayTypesLink);
PRQEINFO_Transaction_AdditionalDefaultPayTypesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing VerifyExist on Transaction_AdditionalDefaultPayTypesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_Transaction_AdditionalDefaultPayTypesFormTable = new SeleniumControl( sDriver, "Transaction_AdditionalDefaultPayTypesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQEINFO_PAYTYPE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQEINFO_Transaction_AdditionalDefaultPayTypesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "PRQEINFO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQEINFO] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRQEINFO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRQEINFO_MainForm);
IWebElement formBttn = PRQEINFO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

