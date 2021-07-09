 
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
    public class PRQPTF_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"View Payroll Edit Table", "xpath","//div[@class='navItem'][.='View Payroll Edit Table']").Click();


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
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRQPTF_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing ClickButton on FederalStateWagesandTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_FederalStateWagesandTaxesForm = new SeleniumControl( sDriver, "FederalStateWagesandTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPAYROLLADT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_FederalStateWagesandTaxesForm);
IWebElement formBttn = PRQPTF_FederalStateWagesandTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PRQPTF_FederalStateWagesandTaxesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PRQPTF_FederalStateWagesandTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Find...", Logger.MessageType.INF);
				SeleniumControl Query_Find = new SeleniumControl( sDriver, "Find", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Find);
if (Query_Find.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Find.Click(5,5);
else Query_Find.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on TransactionType_Add...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_TransactionType_Add = new SeleniumControl( sDriver, "TransactionType_Add", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ADD']");
				Function.AssertEqual(true,PRQPTF_TransactionType_Add.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Federal State Wages and Taxes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on FederalStateWagesandTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_FederalStateWagesandTaxesForm = new SeleniumControl( sDriver, "FederalStateWagesandTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPAYROLLADT_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQPTF_FederalStateWagesandTaxesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExist on FederalStateWagesandTaxesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_FederalStateWagesandTaxesFormTable = new SeleniumControl( sDriver, "FederalStateWagesandTaxesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPAYROLLADT_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQPTF_FederalStateWagesandTaxesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing ClickButton on FederalStateWagesandTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_FederalStateWagesandTaxesForm = new SeleniumControl( sDriver, "FederalStateWagesandTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPAYROLLADT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_FederalStateWagesandTaxesForm);
IWebElement formBttn = PRQPTF_FederalStateWagesandTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQPTF_FederalStateWagesandTaxesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQPTF_FederalStateWagesandTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on FederalStateWagesAndTaxes_Details_Employee...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_FederalStateWagesAndTaxes_Details_Employee = new SeleniumControl( sDriver, "FederalStateWagesAndTaxes_Details_Employee", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPAYROLLADT_CHLD_']/ancestor::form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PRQPTF_FederalStateWagesAndTaxes_Details_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Sate Pay Types");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on StatePayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StatePayTypesLink = new SeleniumControl( sDriver, "StatePayTypesLink", "ID", "lnk_16808_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.AssertEqual(true,PRQPTF_StatePayTypesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Click on StatePayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StatePayTypesLink = new SeleniumControl( sDriver, "StatePayTypesLink", "ID", "lnk_16808_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.WaitControlDisplayed(PRQPTF_StatePayTypesLink);
PRQPTF_StatePayTypesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on StatePayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StatePayTypesForm = new SeleniumControl( sDriver, "StatePayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRSTCDADT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQPTF_StatePayTypesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExist on StatePayTypesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StatePayTypesFormTable = new SeleniumControl( sDriver, "StatePayTypesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRSTCDADT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQPTF_StatePayTypesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing ClickButton on StatePayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StatePayTypesForm = new SeleniumControl( sDriver, "StatePayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRSTCDADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_StatePayTypesForm);
IWebElement formBttn = PRQPTF_StatePayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQPTF_StatePayTypesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQPTF_StatePayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on StatePayTypes_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StatePayTypes_TransactionType = new SeleniumControl( sDriver, "StatePayTypes_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRSTCDADT_CTW_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQPTF_StatePayTypes_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Close on StatePayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StatePayTypesForm = new SeleniumControl( sDriver, "StatePayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRSTCDADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_StatePayTypesForm);
IWebElement formBttn = PRQPTF_StatePayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Pay Types");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on PayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_PayTypesLink = new SeleniumControl( sDriver, "PayTypesLink", "ID", "lnk_5589_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.AssertEqual(true,PRQPTF_PayTypesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Click on PayTypesLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_PayTypesLink = new SeleniumControl( sDriver, "PayTypesLink", "ID", "lnk_5589_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.WaitControlDisplayed(PRQPTF_PayTypesLink);
PRQPTF_PayTypesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on PayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_PayTypesForm = new SeleniumControl( sDriver, "PayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRPAYTPADT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQPTF_PayTypesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExist on PayTypesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_PayTypesFormTable = new SeleniumControl( sDriver, "PayTypesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRPAYTPADT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQPTF_PayTypesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing ClickButton on PayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_PayTypesForm = new SeleniumControl( sDriver, "PayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRPAYTPADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_PayTypesForm);
IWebElement formBttn = PRQPTF_PayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQPTF_PayTypesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQPTF_PayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on PayTypes_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_PayTypes_TransactionType = new SeleniumControl( sDriver, "PayTypes_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRPAYTPADT_CTW_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQPTF_PayTypes_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Close on PayTypesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_PayTypesForm = new SeleniumControl( sDriver, "PayTypesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRPAYTPADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_PayTypesForm);
IWebElement formBttn = PRQPTF_PayTypesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("State Taxes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on StateTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StateTaxesLink = new SeleniumControl( sDriver, "StateTaxesLink", "ID", "lnk_5593_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.AssertEqual(true,PRQPTF_StateTaxesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Click on StateTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StateTaxesLink = new SeleniumControl( sDriver, "StateTaxesLink", "ID", "lnk_5593_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.WaitControlDisplayed(PRQPTF_StateTaxesLink);
PRQPTF_StateTaxesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on StateTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StateTaxesForm = new SeleniumControl( sDriver, "StateTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRSTATEADT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQPTF_StateTaxesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExist on StateTaxesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StateTaxesFormTable = new SeleniumControl( sDriver, "StateTaxesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRSTATEADT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQPTF_StateTaxesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing ClickButton on StateTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StateTaxesForm = new SeleniumControl( sDriver, "StateTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRSTATEADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_StateTaxesForm);
IWebElement formBttn = PRQPTF_StateTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQPTF_StateTaxesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQPTF_StateTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on StateTaxes_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StateTaxes_TransactionType = new SeleniumControl( sDriver, "StateTaxes_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRSTATEADT_CTW_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQPTF_StateTaxes_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Close on StateTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_StateTaxesForm = new SeleniumControl( sDriver, "StateTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRSTATEADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_StateTaxesForm);
IWebElement formBttn = PRQPTF_StateTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Local Taxes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on LocalTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_LocalTaxesLink = new SeleniumControl( sDriver, "LocalTaxesLink", "ID", "lnk_5597_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.AssertEqual(true,PRQPTF_LocalTaxesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Click on LocalTaxesLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_LocalTaxesLink = new SeleniumControl( sDriver, "LocalTaxesLink", "ID", "lnk_5597_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.WaitControlDisplayed(PRQPTF_LocalTaxesLink);
PRQPTF_LocalTaxesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on LocalTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_LocalTaxesForm = new SeleniumControl( sDriver, "LocalTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRLOCALADT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQPTF_LocalTaxesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExist on LocalTaxesFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_LocalTaxesFormTable = new SeleniumControl( sDriver, "LocalTaxesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRLOCALADT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQPTF_LocalTaxesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing ClickButton on LocalTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_LocalTaxesForm = new SeleniumControl( sDriver, "LocalTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRLOCALADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_LocalTaxesForm);
IWebElement formBttn = PRQPTF_LocalTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQPTF_LocalTaxesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQPTF_LocalTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on LocalTaxes_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_LocalTaxes_TransactionType = new SeleniumControl( sDriver, "LocalTaxes_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRLOCALADT_CTW_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQPTF_LocalTaxes_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Close on LocalTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_LocalTaxesForm = new SeleniumControl( sDriver, "LocalTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRLOCALADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_LocalTaxesForm);
IWebElement formBttn = PRQPTF_LocalTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Deduction");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on DeductionsLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_DeductionsLink = new SeleniumControl( sDriver, "DeductionsLink", "ID", "lnk_5594_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.AssertEqual(true,PRQPTF_DeductionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Click on DeductionsLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_DeductionsLink = new SeleniumControl( sDriver, "DeductionsLink", "ID", "lnk_5594_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.WaitControlDisplayed(PRQPTF_DeductionsLink);
PRQPTF_DeductionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on DeductionsForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_DeductionsForm = new SeleniumControl( sDriver, "DeductionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRDEDADT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQPTF_DeductionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExist on DeductionsFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_DeductionsFormTable = new SeleniumControl( sDriver, "DeductionsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRDEDADT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQPTF_DeductionsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on Deductions_GarnishmentDetailLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_Deductions_GarnishmentDetailLink = new SeleniumControl( sDriver, "Deductions_GarnishmentDetailLink", "ID", "lnk_5595_PRQPTF_EMPLPRDEDADT_CTW");
				Function.AssertEqual(true,PRQPTF_Deductions_GarnishmentDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing ClickButton on DeductionsForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_DeductionsForm = new SeleniumControl( sDriver, "DeductionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRDEDADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_DeductionsForm);
IWebElement formBttn = PRQPTF_DeductionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQPTF_DeductionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQPTF_DeductionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on Deductions_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_Deductions_TransactionType = new SeleniumControl( sDriver, "Deductions_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRDEDADT_CTW_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQPTF_Deductions_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Close on DeductionsForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_DeductionsForm = new SeleniumControl( sDriver, "DeductionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRDEDADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_DeductionsForm);
IWebElement formBttn = PRQPTF_DeductionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Contributions");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on ContributionsLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_ContributionsLink = new SeleniumControl( sDriver, "ContributionsLink", "ID", "lnk_5596_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.AssertEqual(true,PRQPTF_ContributionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Click on ContributionsLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_ContributionsLink = new SeleniumControl( sDriver, "ContributionsLink", "ID", "lnk_5596_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.WaitControlDisplayed(PRQPTF_ContributionsLink);
PRQPTF_ContributionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on ContributionsForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_ContributionsForm = new SeleniumControl( sDriver, "ContributionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRCNTRBADT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQPTF_ContributionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExist on ContributionsFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_ContributionsFormTable = new SeleniumControl( sDriver, "ContributionsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRCNTRBADT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQPTF_ContributionsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing ClickButton on ContributionsForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_ContributionsForm = new SeleniumControl( sDriver, "ContributionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRCNTRBADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_ContributionsForm);
IWebElement formBttn = PRQPTF_ContributionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQPTF_ContributionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQPTF_ContributionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on Contributions_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_Contributions_TransactionType = new SeleniumControl( sDriver, "Contributions_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRCNTRBADT_CTW_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQPTF_Contributions_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Close on ContributionsForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_ContributionsForm = new SeleniumControl( sDriver, "ContributionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRCNTRBADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_ContributionsForm);
IWebElement formBttn = PRQPTF_ContributionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Workers' Comp");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on WorkersCompLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_WorkersCompLink = new SeleniumControl( sDriver, "WorkersCompLink", "ID", "lnk_5591_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.AssertEqual(true,PRQPTF_WorkersCompLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Click on WorkersCompLink...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_WorkersCompLink = new SeleniumControl( sDriver, "WorkersCompLink", "ID", "lnk_5591_PRQPTF_EMPLPAYROLLADT_CHLD");
				Function.WaitControlDisplayed(PRQPTF_WorkersCompLink);
PRQPTF_WorkersCompLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on WorkersCompForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_WorkersCompForm = new SeleniumControl( sDriver, "WorkersCompForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRWCADT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQPTF_WorkersCompForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExist on WorkersCompFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_WorkersCompFormTable = new SeleniumControl( sDriver, "WorkersCompFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRWCADT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQPTF_WorkersCompFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing ClickButton on WorkersCompForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_WorkersCompForm = new SeleniumControl( sDriver, "WorkersCompForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRWCADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_WorkersCompForm);
IWebElement formBttn = PRQPTF_WorkersCompForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQPTF_WorkersCompForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQPTF_WorkersCompForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing VerifyExists on WorkersComp_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_WorkersComp_TransactionType = new SeleniumControl( sDriver, "WorkersComp_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRWCADT_CTW_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQPTF_WorkersComp_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Close on WorkersCompForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_WorkersCompForm = new SeleniumControl( sDriver, "WorkersCompForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQPTF_EMPLPRWCADT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQPTF_WorkersCompForm);
IWebElement formBttn = PRQPTF_WorkersCompForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PRQPTF";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQPTF] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRQPTF_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRQPTF_MainForm);
IWebElement formBttn = PRQPTF_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

