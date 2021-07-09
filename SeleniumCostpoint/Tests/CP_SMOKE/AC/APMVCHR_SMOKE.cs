 
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
    public class APMVCHR_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounts Payable", "xpath","//div[@class='deptItem'][.='Accounts Payable']").Click();
new SeleniumControl(sDriver,"Voucher Processing", "xpath","//div[@class='navItem'][.='Voucher Processing']").Click();
new SeleniumControl(sDriver,"Manage Accounts Payable Vouchers", "xpath","//div[@class='navItem'][.='Manage Accounts Payable Vouchers']").Click();


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
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APMVCHR_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on Voucher...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_Voucher = new SeleniumControl( sDriver, "Voucher", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VCHR_NO']");
				Function.AssertEqual(true,APMVCHR_Voucher.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,APMVCHR_MainFormTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVCHR_MainFormTab);
IWebElement mTab = APMVCHR_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on HeaderInfo_Invoice_Number...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_HeaderInfo_Invoice_Number = new SeleniumControl( sDriver, "HeaderInfo_Invoice_Number", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVC_ID']");
				Function.AssertEqual(true,APMVCHR_HeaderInfo_Invoice_Number.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVCHR_MainFormTab);
IWebElement mTab = APMVCHR_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on Details_VATInfo_TaxID...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_Details_VATInfo_TaxID = new SeleniumControl( sDriver, "Details_VATInfo_TaxID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,APMVCHR_Details_VATInfo_TaxID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVCHR_MainFormTab);
IWebElement mTab = APMVCHR_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Address").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on Address_Select_PayVendor...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_Address_Select_PayVendor = new SeleniumControl( sDriver, "Address_Select_PayVendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PAY_VEND_ID']");
				Function.AssertEqual(true,APMVCHR_Address_Select_PayVendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVCHR_MainFormTab);
IWebElement mTab = APMVCHR_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Check").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on Check_PayVendor...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_Check_PayVendor = new SeleniumControl( sDriver, "Check_PayVendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CH_PAY_VEND_ID']");
				Function.AssertEqual(true,APMVCHR_Check_PayVendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVCHR_MainFormTab);
IWebElement mTab = APMVCHR_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Recur").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on Recur_RecurringCode...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_Recur_RecurringCode = new SeleniumControl( sDriver, "Recur_RecurringCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RECUR_VCHR_DC']");
				Function.AssertEqual(true,APMVCHR_Recur_RecurringCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVCHR_MainFormTab);
IWebElement mTab = APMVCHR_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Subcontractor Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on SubcontractorInfo_SubcontractorPaymentControl_InvoicePeriodOfPerformanceDate...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_SubcontractorInfo_SubcontractorPaymentControl_InvoicePeriodOfPerformanceDate = new SeleniumControl( sDriver, "SubcontractorInfo_SubcontractorPaymentControl_InvoicePeriodOfPerformanceDate", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVC_POP_DT']");
				Function.AssertEqual(true,APMVCHR_SubcontractorInfo_SubcontractorPaymentControl_InvoicePeriodOfPerformanceDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVCHR_MainFormTab);
IWebElement mTab = APMVCHR_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes/Doc Loc").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on NotesDocLoc_PrintNotesOnCheck...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_NotesDocLoc_PrintNotesOnCheck = new SeleniumControl( sDriver, "NotesDocLoc_PrintNotesOnCheck", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PRINT_NOTE_FL']");
				Function.AssertEqual(true,APMVCHR_NotesDocLoc_PrintNotesOnCheck.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVCHR_MainFormTab);
IWebElement mTab = APMVCHR_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Entry Defaults").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on EntryDefaults_AllowPayVendorOnWarningStatus...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_EntryDefaults_AllowPayVendorOnWarningStatus = new SeleniumControl( sDriver, "EntryDefaults_AllowPayVendorOnWarningStatus", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CB_USE_VEND_ONWARN']");
				Function.AssertEqual(true,APMVCHR_EntryDefaults_AllowPayVendorOnWarningStatus.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMVCHR_MainForm);
IWebElement formBttn = APMVCHR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? APMVCHR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
APMVCHR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVCHR_MainFormTable.Exists());

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
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_LN_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVCHR_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_LN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVCHR_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_LN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHR_ChildForm);
IWebElement formBttn = APMVCHR_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMVCHR_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMVCHR_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_LN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,APMVCHR_ChildFormTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_LN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVCHR_ChildFormTab);
IWebElement mTab = APMVCHR_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Account Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on ChildForm_AccountInfo_LineNo...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ChildForm_AccountInfo_LineNo = new SeleniumControl( sDriver, "ChildForm_AccountInfo_LineNo", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_LN_']/ancestor::form[1]/descendant::*[@id='VCHR_LN_NO']");
				Function.AssertEqual(true,APMVCHR_ChildForm_AccountInfo_LineNo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_LN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVCHR_ChildFormTab);
IWebElement mTab = APMVCHR_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on ChildForm_OtherInfo_Vendor1099s_1099Type...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ChildForm_OtherInfo_Vendor1099s_1099Type = new SeleniumControl( sDriver, "ChildForm_OtherInfo_Vendor1099s_1099Type", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_LN_']/ancestor::form[1]/descendant::*[@id='S_AP_1099_TYPE_CD']");
				Function.AssertEqual(true,APMVCHR_ChildForm_OtherInfo_Vendor1099s_1099Type.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_LN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVCHR_ChildFormTab);
IWebElement mTab = APMVCHR_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Exchange Rates");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003304_APMVCHR_VCHRHDR");
				Function.AssertEqual(true,APMVCHR_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003304_APMVCHR_VCHRHDR");
				Function.WaitControlDisplayed(APMVCHR_ExchangeRatesLink);
APMVCHR_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVCHR_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on ExchangeRates_RateGroup...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ExchangeRates_RateGroup = new SeleniumControl( sDriver, "ExchangeRates_RateGroup", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]/descendant::*[@id='RATE_GRP_ID']");
				Function.AssertEqual(true,APMVCHR_ExchangeRates_RateGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHR_ExchangeRatesForm);
IWebElement formBttn = APMVCHR_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Voucher Totals Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on VoucherTotalsLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_VoucherTotalsLink = new SeleniumControl( sDriver, "VoucherTotalsLink", "ID", "lnk_2797_APMVCHR_VCHRHDR");
				Function.AssertEqual(true,APMVCHR_VoucherTotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Click on VoucherTotalsLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_VoucherTotalsLink = new SeleniumControl( sDriver, "VoucherTotalsLink", "ID", "lnk_2797_APMVCHR_VCHRHDR");
				Function.WaitControlDisplayed(APMVCHR_VoucherTotalsLink);
APMVCHR_VoucherTotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on VoucherTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_VoucherTotalsForm = new SeleniumControl( sDriver, "VoucherTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVCHR_VoucherTotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on VoucherTotals_DiscountTakenAmount...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_VoucherTotals_DiscountTakenAmount = new SeleniumControl( sDriver, "VoucherTotals_DiscountTakenAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]/descendant::*[@id='T_TRN_DISC_TAKEN_AMT']");
				Function.AssertEqual(true,APMVCHR_VoucherTotals_DiscountTakenAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Close on VoucherTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_VoucherTotalsForm = new SeleniumControl( sDriver, "VoucherTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHR_VoucherTotalsForm);
IWebElement formBttn = APMVCHR_VoucherTotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Query (NO NEED!)");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Vendor Labor Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on VendorLaborLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_VendorLaborLink = new SeleniumControl( sDriver, "VendorLaborLink", "ID", "lnk_1003290_APMVCHR_LN");
				Function.AssertEqual(true,APMVCHR_VendorLaborLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Click on VendorLaborLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_VendorLaborLink = new SeleniumControl( sDriver, "VendorLaborLink", "ID", "lnk_1003290_APMVCHR_LN");
				Function.WaitControlDisplayed(APMVCHR_VendorLaborLink);
APMVCHR_VendorLaborLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on VendorLaborForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_VendorLaborForm = new SeleniumControl( sDriver, "VendorLaborForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_VCHRLABVEND_VEND_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVCHR_VendorLaborForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExist on VendorLaborTable...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_VendorLaborTable = new SeleniumControl( sDriver, "VendorLaborTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_VCHRLABVEND_VEND_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVCHR_VendorLaborTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing ClickButton on VendorLaborForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_VendorLaborForm = new SeleniumControl( sDriver, "VendorLaborForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_VCHRLABVEND_VEND_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHR_VendorLaborForm);
IWebElement formBttn = APMVCHR_VendorLaborForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMVCHR_VendorLaborForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMVCHR_VendorLaborForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on VendorLabor_SubLine...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_VendorLabor_SubLine = new SeleniumControl( sDriver, "VendorLabor_SubLine", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_VCHRLABVEND_VEND_']/ancestor::form[1]/descendant::*[@id='SUB_LN_NO']");
				Function.AssertEqual(true,APMVCHR_VendorLabor_SubLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Close on VendorLaborForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_VendorLaborForm = new SeleniumControl( sDriver, "VendorLaborForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHR_VCHRLABVEND_VEND_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHR_VendorLaborForm);
IWebElement formBttn = APMVCHR_VendorLaborForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Currency Line Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CurrencyLineLink = new SeleniumControl( sDriver, "CurrencyLineLink", "ID", "lnk_1003308_APMVCHR_LN");
				Function.AssertEqual(true,APMVCHR_CurrencyLineLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Click on CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CurrencyLineLink = new SeleniumControl( sDriver, "CurrencyLineLink", "ID", "lnk_1003308_APMVCHR_LN");
				Function.WaitControlDisplayed(APMVCHR_CurrencyLineLink);
APMVCHR_CurrencyLineLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPCURLN_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVCHR_CurrencyLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on CurrencyLine_LineAmounts_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CurrencyLine_LineAmounts_TransactionCurrency = new SeleniumControl( sDriver, "CurrencyLine_LineAmounts_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPCURLN_']/ancestor::form[1]/descendant::*[@id='T_CURRENCY']");
				Function.AssertEqual(true,APMVCHR_CurrencyLine_LineAmounts_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing ClickButton on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPCURLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHR_CurrencyLineForm);
IWebElement formBttn = APMVCHR_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? APMVCHR_CurrencyLineForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
APMVCHR_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExist on CurrencyLineTable...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CurrencyLineTable = new SeleniumControl( sDriver, "CurrencyLineTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPCURLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVCHR_CurrencyLineTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Close on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPCURLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHR_CurrencyLineForm);
IWebElement formBttn = APMVCHR_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Customs Info Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CustomsInfoLink = new SeleniumControl( sDriver, "CustomsInfoLink", "ID", "lnk_1003310_APMVCHR_LN");
				Function.AssertEqual(true,APMVCHR_CustomsInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Click on CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CustomsInfoLink = new SeleniumControl( sDriver, "CustomsInfoLink", "ID", "lnk_1003310_APMVCHR_LN");
				Function.WaitControlDisplayed(APMVCHR_CustomsInfoLink);
APMVCHR_CustomsInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CustomsInfoForm = new SeleniumControl( sDriver, "CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVCHR_CustomsInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExists on CustomsInfo_CustomsHeaderInformation_DestinationCountry...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CustomsInfo_CustomsHeaderInformation_DestinationCountry = new SeleniumControl( sDriver, "CustomsInfo_CustomsHeaderInformation_DestinationCountry", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]/descendant::*[@id='EC_COUNTRY_DEST_NAME']");
				Function.AssertEqual(true,APMVCHR_CustomsInfo_CustomsHeaderInformation_DestinationCountry.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing ClickButton on CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CustomsInfoForm = new SeleniumControl( sDriver, "CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHR_CustomsInfoForm);
IWebElement formBttn = APMVCHR_CustomsInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? APMVCHR_CustomsInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
APMVCHR_CustomsInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing VerifyExist on CustomsInfoTable...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CustomsInfoTable = new SeleniumControl( sDriver, "CustomsInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVCHR_CustomsInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Close on CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_CustomsInfoForm = new SeleniumControl( sDriver, "CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHR_CustomsInfoForm);
IWebElement formBttn = APMVCHR_CustomsInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "APMVCHR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHR] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMVCHR_MainForm);
IWebElement formBttn = APMVCHR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

