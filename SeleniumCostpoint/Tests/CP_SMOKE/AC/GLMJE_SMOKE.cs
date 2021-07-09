 
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
    public class GLMJE_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"General Ledger", "xpath","//div[@class='deptItem'][.='General Ledger']").Click();
new SeleniumControl(sDriver,"Journal Entry Processing", "xpath","//div[@class='navItem'][.='Journal Entry Processing']").Click();
new SeleniumControl(sDriver,"Manage Journal Entries", "xpath","//div[@class='navItem'][.='Manage Journal Entries']").Click();


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
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMJE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLMJE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on Description...", Logger.MessageType.INF);
				SeleniumControl GLMJE_Description = new SeleniumControl( sDriver, "Description", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='JE_DESC']");
				Function.AssertEqual(true,GLMJE_Description.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMJE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMJE_MainForm);
IWebElement formBttn = GLMJE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? GLMJE_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
GLMJE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMJE_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMJE_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Child Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJE_JETRN_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMJE_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJE_JETRN_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMJE_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJE_JETRN_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMJE_ChildForm);
IWebElement formBttn = GLMJE_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMJE_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMJE_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on ChildForm_Line...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ChildForm_Line = new SeleniumControl( sDriver, "ChildForm_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJE_JETRN_DTL_']/ancestor::form[1]/descendant::*[@id='JE_LN_NO']");
				Function.AssertEqual(true,GLMJE_ChildForm_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Reversing Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on ReversingLink...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ReversingLink = new SeleniumControl( sDriver, "ReversingLink", "ID", "lnk_1002870_GLMJE_JEHDR_HDR");
				Function.AssertEqual(true,GLMJE_ReversingLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing Click on ReversingLink...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ReversingLink = new SeleniumControl( sDriver, "ReversingLink", "ID", "lnk_1002870_GLMJE_JEHDR_HDR");
				Function.WaitControlDisplayed(GLMJE_ReversingLink);
GLMJE_ReversingLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Recurring Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on RecurringLink...", Logger.MessageType.INF);
				SeleniumControl GLMJE_RecurringLink = new SeleniumControl( sDriver, "RecurringLink", "ID", "lnk_1002874_GLMJE_JEHDR_HDR");
				Function.AssertEqual(true,GLMJE_RecurringLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing Click on RecurringLink...", Logger.MessageType.INF);
				SeleniumControl GLMJE_RecurringLink = new SeleniumControl( sDriver, "RecurringLink", "ID", "lnk_1002874_GLMJE_JEHDR_HDR");
				Function.WaitControlDisplayed(GLMJE_RecurringLink);
GLMJE_RecurringLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Exchange Rates Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003709_GLMJE_JEHDR_HDR");
				Function.AssertEqual(true,GLMJE_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003709_GLMJE_JEHDR_HDR");
				Function.WaitControlDisplayed(GLMJE_ExchangeRatesLink);
GLMJE_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMJE_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,GLMJE_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMJE_ExchangeRatesForm);
IWebElement formBttn = GLMJE_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Employee Labor Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on ChildForm_EmployeeLaborLink...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ChildForm_EmployeeLaborLink = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborLink", "ID", "lnk_1002876_GLMJE_JETRN_DTL");
				Function.AssertEqual(true,GLMJE_ChildForm_EmployeeLaborLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing Click on ChildForm_EmployeeLaborLink...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ChildForm_EmployeeLaborLink = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborLink", "ID", "lnk_1002876_GLMJE_JETRN_DTL");
				Function.WaitControlDisplayed(GLMJE_ChildForm_EmployeeLaborLink);
GLMJE_ChildForm_EmployeeLaborLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on EmployeeLaborForm...", Logger.MessageType.INF);
				SeleniumControl GLMJE_EmployeeLaborForm = new SeleniumControl( sDriver, "EmployeeLaborForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__GLMJE_JETRNLABEMPL_EMP_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMJE_EmployeeLaborForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExist on EmployeeLaborFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMJE_EmployeeLaborFormTable = new SeleniumControl( sDriver, "EmployeeLaborFormTable", "XPATH", "//div[translate(@id,'0123456789','')='pr__GLMJE_JETRNLABEMPL_EMP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMJE_EmployeeLaborFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing ClickButton on EmployeeLaborForm...", Logger.MessageType.INF);
				SeleniumControl GLMJE_EmployeeLaborForm = new SeleniumControl( sDriver, "EmployeeLaborForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__GLMJE_JETRNLABEMPL_EMP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMJE_EmployeeLaborForm);
IWebElement formBttn = GLMJE_EmployeeLaborForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMJE_EmployeeLaborForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMJE_EmployeeLaborForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on EmployeeLabor_Employee...", Logger.MessageType.INF);
				SeleniumControl GLMJE_EmployeeLabor_Employee = new SeleniumControl( sDriver, "EmployeeLabor_Employee", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJE_JETRNLABEMPL_EMP_']/ancestor::form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,GLMJE_EmployeeLabor_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing Close on EmployeeLaborForm...", Logger.MessageType.INF);
				SeleniumControl GLMJE_EmployeeLaborForm = new SeleniumControl( sDriver, "EmployeeLaborForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__GLMJE_JETRNLABEMPL_EMP_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMJE_EmployeeLaborForm);
IWebElement formBttn = GLMJE_EmployeeLaborForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Vendor Label Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on ChildForm_VendorLaborLink...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ChildForm_VendorLaborLink = new SeleniumControl( sDriver, "ChildForm_VendorLaborLink", "ID", "lnk_1002878_GLMJE_JETRN_DTL");
				Function.AssertEqual(true,GLMJE_ChildForm_VendorLaborLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing Click on ChildForm_VendorLaborLink...", Logger.MessageType.INF);
				SeleniumControl GLMJE_ChildForm_VendorLaborLink = new SeleniumControl( sDriver, "ChildForm_VendorLaborLink", "ID", "lnk_1002878_GLMJE_JETRN_DTL");
				Function.WaitControlDisplayed(GLMJE_ChildForm_VendorLaborLink);
GLMJE_ChildForm_VendorLaborLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on VendorLaborForm...", Logger.MessageType.INF);
				SeleniumControl GLMJE_VendorLaborForm = new SeleniumControl( sDriver, "VendorLaborForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__GLMJE_JE_TRNLABVEND_VEND_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMJE_VendorLaborForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExist on VendorLaborFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMJE_VendorLaborFormTable = new SeleniumControl( sDriver, "VendorLaborFormTable", "XPATH", "//div[translate(@id,'0123456789','')='pr__GLMJE_JE_TRNLABVEND_VEND_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMJE_VendorLaborFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing ClickButton on VendorLaborForm...", Logger.MessageType.INF);
				SeleniumControl GLMJE_VendorLaborForm = new SeleniumControl( sDriver, "VendorLaborForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__GLMJE_JE_TRNLABVEND_VEND_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMJE_VendorLaborForm);
IWebElement formBttn = GLMJE_VendorLaborForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMJE_VendorLaborForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMJE_VendorLaborForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing VerifyExists on VendorLabor_Vendor...", Logger.MessageType.INF);
				SeleniumControl GLMJE_VendorLabor_Vendor = new SeleniumControl( sDriver, "VendorLabor_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMJE_JE_TRNLABVEND_VEND_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,GLMJE_VendorLabor_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing Close on VendorLaborForm...", Logger.MessageType.INF);
				SeleniumControl GLMJE_VendorLaborForm = new SeleniumControl( sDriver, "VendorLaborForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__GLMJE_JE_TRNLABVEND_VEND_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMJE_VendorLaborForm);
IWebElement formBttn = GLMJE_VendorLaborForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "GLMJE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMJE] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMJE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMJE_MainForm);
IWebElement formBttn = GLMJE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
Function.ClickOkDialogWithMessage("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogWithMessage]" , ex.Message));
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

