 
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
    public class APMVCHRA_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Approve Vouchers", "xpath","//div[@class='navItem'][.='Approve Vouchers']").Click();


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
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APMVCHRA_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on Identification_Approver...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_Identification_Approver = new SeleniumControl( sDriver, "Identification_Approver", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='USER_ID']");
				Function.AssertEqual(true,APMVCHRA_Identification_Approver.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMVCHRA_MainForm);
IWebElement formBttn = APMVCHRA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? APMVCHRA_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
APMVCHRA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVCHRA_MainFormTable.Exists());

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
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_VCHR_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVCHRA_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_VCHR_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVCHRA_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_VCHR_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHRA_ChildForm);
IWebElement formBttn = APMVCHRA_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMVCHRA_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMVCHRA_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_VCHR_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVCHRA_ChildFormTab);
IWebElement mTab = APMVCHRA_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Voucher Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on ChildForm_VoucherHeader_Vendor...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildForm_VoucherHeader_Vendor = new SeleniumControl( sDriver, "ChildForm_VoucherHeader_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_VCHR_DTL_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,APMVCHRA_ChildForm_VoucherHeader_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_VCHR_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVCHRA_ChildFormTab);
IWebElement mTab = APMVCHRA_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manual Check").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on ChildForm_ManualCheck_CashAccountsDescription...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildForm_ManualCheck_CashAccountsDescription = new SeleniumControl( sDriver, "ChildForm_ManualCheck_CashAccountsDescription", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_VCHR_DTL_']/ancestor::form[1]/descendant::*[@id='CASH_ACCTS_DESC']");
				Function.AssertEqual(true,APMVCHRA_ChildForm_ManualCheck_CashAccountsDescription.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Voucher Detail Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on ChildForm_VoucherDetailLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildForm_VoucherDetailLink = new SeleniumControl( sDriver, "ChildForm_VoucherDetailLink", "ID", "lnk_1003043_APMVCHRA_VCHR_DTL");
				Function.AssertEqual(true,APMVCHRA_ChildForm_VoucherDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing Click on ChildForm_VoucherDetailLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildForm_VoucherDetailLink = new SeleniumControl( sDriver, "ChildForm_VoucherDetailLink", "ID", "lnk_1003043_APMVCHRA_VCHR_DTL");
				Function.WaitControlDisplayed(APMVCHRA_ChildForm_VoucherDetailLink);
APMVCHRA_ChildForm_VoucherDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on VoucherDetailForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_VoucherDetailForm = new SeleniumControl( sDriver, "VoucherDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_LN_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVCHRA_VoucherDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExist on VoucherDetailTable...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_VoucherDetailTable = new SeleniumControl( sDriver, "VoucherDetailTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_LN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVCHRA_VoucherDetailTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing ClickButton on VoucherDetailForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_VoucherDetailForm = new SeleniumControl( sDriver, "VoucherDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_LN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHRA_VoucherDetailForm);
IWebElement formBttn = APMVCHRA_VoucherDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMVCHRA_VoucherDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMVCHRA_VoucherDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on VoucherDetail_VchrLine...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_VoucherDetail_VchrLine = new SeleniumControl( sDriver, "VoucherDetail_VchrLine", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_LN_']/ancestor::form[1]/descendant::*[@id='VCHR_LN_NO']");
				Function.AssertEqual(true,APMVCHRA_VoucherDetail_VchrLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on VoucherDetail_CurrencyLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_VoucherDetail_CurrencyLink = new SeleniumControl( sDriver, "VoucherDetail_CurrencyLink", "ID", "lnk_1003046_APMVCHRA_LN");
				Function.AssertEqual(true,APMVCHRA_VoucherDetail_CurrencyLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing Close on VoucherDetailForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_VoucherDetailForm = new SeleniumControl( sDriver, "VoucherDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_LN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHRA_VoucherDetailForm);
IWebElement formBttn = APMVCHRA_VoucherDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PO Voucher Lines Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on ChildForm_POVoucherLinesLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildForm_POVoucherLinesLink = new SeleniumControl( sDriver, "ChildForm_POVoucherLinesLink", "ID", "lnk_1003047_APMVCHRA_VCHR_DTL");
				Function.AssertEqual(true,APMVCHRA_ChildForm_POVoucherLinesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing Click on ChildForm_POVoucherLinesLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildForm_POVoucherLinesLink = new SeleniumControl( sDriver, "ChildForm_POVoucherLinesLink", "ID", "lnk_1003047_APMVCHRA_VCHR_DTL");
				Function.WaitControlDisplayed(APMVCHRA_ChildForm_POVoucherLinesLink);
APMVCHRA_ChildForm_POVoucherLinesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on POVoucherLinesForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_POVoucherLinesForm = new SeleniumControl( sDriver, "POVoucherLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_VCHRLNPOLN_SUBTSK_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVCHRA_POVoucherLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExist on POVoucherLinesTable...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_POVoucherLinesTable = new SeleniumControl( sDriver, "POVoucherLinesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_VCHRLNPOLN_SUBTSK_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVCHRA_POVoucherLinesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing ClickButton on POVoucherLinesForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_POVoucherLinesForm = new SeleniumControl( sDriver, "POVoucherLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_VCHRLNPOLN_SUBTSK_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHRA_POVoucherLinesForm);
IWebElement formBttn = APMVCHRA_POVoucherLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMVCHRA_POVoucherLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMVCHRA_POVoucherLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on POVoucherLines_VchrLine...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_POVoucherLines_VchrLine = new SeleniumControl( sDriver, "POVoucherLines_VchrLine", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_VCHRLNPOLN_SUBTSK_DTL_']/ancestor::form[1]/descendant::*[@id='VCHR_LN_NO']");
				Function.AssertEqual(true,APMVCHRA_POVoucherLines_VchrLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing Close on POVoucherLinesForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_POVoucherLinesForm = new SeleniumControl( sDriver, "POVoucherLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVCHRA_VCHRLNPOLN_SUBTSK_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHRA_POVoucherLinesForm);
IWebElement formBttn = APMVCHRA_POVoucherLinesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_1003235_APMVCHRA_VCHR_DTL");
				Function.AssertEqual(true,APMVCHRA_ChildForm_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing Click on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_1003235_APMVCHRA_VCHR_DTL");
				Function.WaitControlDisplayed(APMVCHRA_ChildForm_ExchangeRatesLink);
APMVCHRA_ChildForm_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVCHRA_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on ExchangeRates_Currencies_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ExchangeRates_Currencies_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_Currencies_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,APMVCHRA_ExchangeRates_Currencies_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing ClickButton on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHRA_ExchangeRatesForm);
IWebElement formBttn = APMVCHRA_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? APMVCHRA_ExchangeRatesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
APMVCHRA_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExist on ExchangeRatesFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ExchangeRatesFormTable = new SeleniumControl( sDriver, "ExchangeRatesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVCHRA_ExchangeRatesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHRA_ExchangeRatesForm);
IWebElement formBttn = APMVCHRA_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on ChildForm_VoucherTotalsLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildForm_VoucherTotalsLink = new SeleniumControl( sDriver, "ChildForm_VoucherTotalsLink", "ID", "lnk_1007220_APMVCHRA_VCHR_DTL");
				Function.AssertEqual(true,APMVCHRA_ChildForm_VoucherTotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing Click on ChildForm_VoucherTotalsLink...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_ChildForm_VoucherTotalsLink = new SeleniumControl( sDriver, "ChildForm_VoucherTotalsLink", "ID", "lnk_1007220_APMVCHRA_VCHR_DTL");
				Function.WaitControlDisplayed(APMVCHRA_ChildForm_VoucherTotalsLink);
APMVCHRA_ChildForm_VoucherTotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on VoucherTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_VoucherTotalsForm = new SeleniumControl( sDriver, "VoucherTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVCHRA_VoucherTotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing VerifyExists on VoucherTotals_CostAmount...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_VoucherTotals_CostAmount = new SeleniumControl( sDriver, "VoucherTotals_CostAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]/descendant::*[@id='TRN_CST_AMT']");
				Function.AssertEqual(true,APMVCHRA_VoucherTotals_CostAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing Close on VoucherTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_VoucherTotalsForm = new SeleniumControl( sDriver, "VoucherTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVCHRA_VoucherTotalsForm);
IWebElement formBttn = APMVCHRA_VoucherTotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "APMVCHRA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVCHRA] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVCHRA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMVCHRA_MainForm);
IWebElement formBttn = APMVCHRA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

