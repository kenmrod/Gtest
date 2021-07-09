 
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
    public class APQVCHRH_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"Accounts Payable", "xpath","//div[@class='deptItem'][.='Accounts Payable']").Click();
new SeleniumControl(sDriver,"Accounts Payable Reports/Inquiries", "xpath","//div[@class='navItem'][.='Accounts Payable Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Voucher History Inquiry", "xpath","//div[@class='navItem'][.='View Voucher History Inquiry']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
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
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing VerifyToolbarButtonExist on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute')]")).FirstOrDefault();
Boolean bFound = tlbrBtn != null ? true : false;
Function.AssertEqual(true , bFound);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyToolbarButtonExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Set on SelectByVendor_Vendor...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_SelectByVendor_Vendor = new SeleniumControl( sDriver, "SelectByVendor_Vendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VEND']");
				APQVCHRH_SelectByVendor_Vendor.Click();
APQVCHRH_SelectByVendor_Vendor.SendKeys("1099NON", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
APQVCHRH_SelectByVendor_Vendor.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
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
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APQVCHRH_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on SelectByVendor_Vendor...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_SelectByVendor_Vendor = new SeleniumControl( sDriver, "SelectByVendor_Vendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VEND']");
				Function.AssertEqual(true,APQVCHRH_SelectByVendor_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VCHRHDRHS_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,APQVCHRH_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VCHRHDRHS_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APQVCHRH_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VCHRHDRHS_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm);
IWebElement formBttn = APQVCHRH_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APQVCHRH_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APQVCHRH_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_Vendor...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_Vendor = new SeleniumControl( sDriver, "ChildForm_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VCHRHDRHS_CHILD_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,APQVCHRH_ChildForm_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_VoucherTotalsLink...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_VoucherTotalsLink = new SeleniumControl( sDriver, "ChildForm_VoucherTotalsLink", "ID", "lnk_1007079_APQVCHRH_VCHRHDRHS_CHILD");
				Function.AssertEqual(true,APQVCHRH_ChildForm_VoucherTotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Click on ChildForm_VoucherTotalsLink...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_VoucherTotalsLink = new SeleniumControl( sDriver, "ChildForm_VoucherTotalsLink", "ID", "lnk_1007079_APQVCHRH_VCHRHDRHS_CHILD");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_VoucherTotalsLink);
APQVCHRH_ChildForm_VoucherTotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_VoucherTotals_VoucherTotals_Transaction_TotalAmount...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_VoucherTotals_VoucherTotals_Transaction_TotalAmount = new SeleniumControl( sDriver, "ChildForm_VoucherTotals_VoucherTotals_Transaction_TotalAmount", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]/descendant::*[@id='TRN_NET_AMT']");
				Function.AssertEqual(true,APQVCHRH_ChildForm_VoucherTotals_VoucherTotals_Transaction_TotalAmount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_VoucherTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_VoucherTotalsForm = new SeleniumControl( sDriver, "ChildForm_VoucherTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]");
				Function.AssertEqual(true,APQVCHRH_ChildForm_VoucherTotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Close on ChildForm_VoucherTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_VoucherTotalsForm = new SeleniumControl( sDriver, "ChildForm_VoucherTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVTOT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_VoucherTotalsForm);
IWebElement formBttn = APQVCHRH_ChildForm_VoucherTotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Click on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_1007041_APQVCHRH_VCHRHDRHS_CHILD");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_ExchangeRatesLink);
APQVCHRH_ChildForm_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_ExchangeRatesForm = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,APQVCHRH_ChildForm_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_ExchangeRates_Currencies_Pay...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_ExchangeRates_Currencies_Pay = new SeleniumControl( sDriver, "ChildForm_ExchangeRates_Currencies_Pay", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]/descendant::*[@id='PAY_CRNCY_CD']");
				Function.AssertEqual(true,APQVCHRH_ChildForm_ExchangeRates_Currencies_Pay.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Close on ChildForm_ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_ExchangeRatesForm = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_MEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_ExchangeRatesForm);
IWebElement formBttn = APQVCHRH_ChildForm_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Click on ChildForm_APVoucherDetailLink...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_APVoucherDetailLink = new SeleniumControl( sDriver, "ChildForm_APVoucherDetailLink", "ID", "lnk_1005833_APQVCHRH_VCHRHDRHS_CHILD");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_APVoucherDetailLink);
APQVCHRH_ChildForm_APVoucherDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExist on ChildForm_APVoucherDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_APVoucherDetailFormTable = new SeleniumControl( sDriver, "ChildForm_APVoucherDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_LN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APQVCHRH_ChildForm_APVoucherDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_APVoucherDetailForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_APVoucherDetailForm = new SeleniumControl( sDriver, "ChildForm_APVoucherDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_LN_']/ancestor::form[1]");
				Function.AssertEqual(true,APQVCHRH_ChildForm_APVoucherDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing ClickButton on ChildForm_APVoucherDetailForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_APVoucherDetailForm = new SeleniumControl( sDriver, "ChildForm_APVoucherDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_LN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_APVoucherDetailForm);
IWebElement formBttn = APQVCHRH_ChildForm_APVoucherDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APQVCHRH_ChildForm_APVoucherDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APQVCHRH_ChildForm_APVoucherDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_APVoucherDetail_Line...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_APVoucherDetail_Line = new SeleniumControl( sDriver, "ChildForm_APVoucherDetail_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_LN_']/ancestor::form[1]/descendant::*[@id='VCHR_LN_NO']");
				Function.AssertEqual(true,APQVCHRH_ChildForm_APVoucherDetail_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Close on ChildForm_APVoucherDetailForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_APVoucherDetailForm = new SeleniumControl( sDriver, "ChildForm_APVoucherDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_LN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_APVoucherDetailForm);
IWebElement formBttn = APQVCHRH_ChildForm_APVoucherDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Click on ChildForm_POVoucherDetailLink...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_POVoucherDetailLink = new SeleniumControl( sDriver, "ChildForm_POVoucherDetailLink", "ID", "lnk_1005834_APQVCHRH_VCHRHDRHS_CHILD");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_POVoucherDetailLink);
APQVCHRH_ChildForm_POVoucherDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExist on ChildForm_POVoucherDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_POVoucherDetailFormTable = new SeleniumControl( sDriver, "ChildForm_POVoucherDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_POLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APQVCHRH_ChildForm_POVoucherDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_POVoucherDetailForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_POVoucherDetailForm = new SeleniumControl( sDriver, "ChildForm_POVoucherDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_POLN_']/ancestor::form[1]");
				Function.AssertEqual(true,APQVCHRH_ChildForm_POVoucherDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing ClickButton on ChildForm_POVoucherDetailForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_POVoucherDetailForm = new SeleniumControl( sDriver, "ChildForm_POVoucherDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_POLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_POVoucherDetailForm);
IWebElement formBttn = APQVCHRH_ChildForm_POVoucherDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APQVCHRH_ChildForm_POVoucherDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APQVCHRH_ChildForm_POVoucherDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_POVoucherDetail_VoucherLine...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_POVoucherDetail_VoucherLine = new SeleniumControl( sDriver, "ChildForm_POVoucherDetail_VoucherLine", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_POLN_']/ancestor::form[1]/descendant::*[@id='VCHR_LN_NO']");
				Function.AssertEqual(true,APQVCHRH_ChildForm_POVoucherDetail_VoucherLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Close on ChildForm_POVoucherDetailForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_POVoucherDetailForm = new SeleniumControl( sDriver, "ChildForm_POVoucherDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_POLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_POVoucherDetailForm);
IWebElement formBttn = APQVCHRH_ChildForm_POVoucherDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Click on ChildForm_POVoucherTotalsLink...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_POVoucherTotalsLink = new SeleniumControl( sDriver, "ChildForm_POVoucherTotalsLink", "ID", "lnk_1007042_APQVCHRH_VCHRHDRHS_CHILD");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_POVoucherTotalsLink);
APQVCHRH_ChildForm_POVoucherTotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_POVoucherTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_POVoucherTotalsForm = new SeleniumControl( sDriver, "ChildForm_POVoucherTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMPOVTO_']/ancestor::form[1]");
				Function.AssertEqual(true,APQVCHRH_ChildForm_POVoucherTotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_POVoucherTotals_InvoiceAmt...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_POVoucherTotals_InvoiceAmt = new SeleniumControl( sDriver, "ChildForm_POVoucherTotals_InvoiceAmt", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMPOVTO_']/ancestor::form[1]/descendant::*[@id='INVC_AMT']");
				Function.AssertEqual(true,APQVCHRH_ChildForm_POVoucherTotals_InvoiceAmt.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Close on ChildForm_POVoucherTotalsForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_POVoucherTotalsForm = new SeleniumControl( sDriver, "ChildForm_POVoucherTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMPOVTO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_POVoucherTotalsForm);
IWebElement formBttn = APQVCHRH_ChildForm_POVoucherTotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Click on ChildForm_ChecksDisbursedLink...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_ChecksDisbursedLink = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursedLink", "ID", "lnk_1005866_APQVCHRH_VCHRHDRHS_CHILD");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_ChecksDisbursedLink);
APQVCHRH_ChildForm_ChecksDisbursedLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_ChecksDisbursedForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_ChecksDisbursedForm = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VCHRCHECK_TOTAL_']/ancestor::form[1]");
				Function.AssertEqual(true,APQVCHRH_ChildForm_ChecksDisbursedForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_ChecksDisbursed_TotalFuncCurrencyAmountPaid...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_ChecksDisbursed_TotalFuncCurrencyAmountPaid = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursed_TotalFuncCurrencyAmountPaid", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VCHRCHECK_TOTAL_']/ancestor::form[1]/descendant::*[@id='FUNC_TOT_PAID_AMT']");
				Function.AssertEqual(true,APQVCHRH_ChildForm_ChecksDisbursed_TotalFuncCurrencyAmountPaid.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_ChecksDisbursed_VoucherChecksDisbursedForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_ChecksDisbursed_VoucherChecksDisbursedForm = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursed_VoucherChecksDisbursedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VENDCHKVCHR_VCHRCHECK_']/ancestor::form[1]");
				Function.AssertEqual(true,APQVCHRH_ChildForm_ChecksDisbursed_VoucherChecksDisbursedForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExist on ChildForm_ChecksDisbursed_VoucherChecksDisbursedFormTable...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_ChecksDisbursed_VoucherChecksDisbursedFormTable = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursed_VoucherChecksDisbursedFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VENDCHKVCHR_VCHRCHECK_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APQVCHRH_ChildForm_ChecksDisbursed_VoucherChecksDisbursedFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing ClickButton on ChildForm_ChecksDisbursed_VoucherChecksDisbursedForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_ChecksDisbursed_VoucherChecksDisbursedForm = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursed_VoucherChecksDisbursedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VENDCHKVCHR_VCHRCHECK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_ChecksDisbursed_VoucherChecksDisbursedForm);
IWebElement formBttn = APQVCHRH_ChildForm_ChecksDisbursed_VoucherChecksDisbursedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APQVCHRH_ChildForm_ChecksDisbursed_VoucherChecksDisbursedForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APQVCHRH_ChildForm_ChecksDisbursed_VoucherChecksDisbursedForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_ChecksDisbursed_VoucherChecksDisbursed_Posted_VoidFY...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_ChecksDisbursed_VoucherChecksDisbursed_Posted_VoidFY = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursed_VoucherChecksDisbursed_Posted_VoidFY", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VENDCHKVCHR_VCHRCHECK_']/ancestor::form[1]/descendant::*[@id='VOID_FY_CD']");
				Function.AssertEqual(true,APQVCHRH_ChildForm_ChecksDisbursed_VoucherChecksDisbursed_Posted_VoidFY.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Close on ChildForm_ChecksDisbursedForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_ChecksDisbursedForm = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VCHRCHECK_TOTAL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_ChecksDisbursedForm);
IWebElement formBttn = APQVCHRH_ChildForm_ChecksDisbursedForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Click on ChildForm_PODetailLink...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_PODetailLink = new SeleniumControl( sDriver, "ChildForm_PODetailLink", "ID", "lnk_1005838_APQVCHRH_VCHRHDRHS_CHILD");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_PODetailLink);
APQVCHRH_ChildForm_PODetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_PODetailForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_PODetailForm = new SeleniumControl( sDriver, "ChildForm_PODetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VCHRLNHS_PODETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,APQVCHRH_ChildForm_PODetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExist on ChildForm_PODetailFormTable...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_PODetailFormTable = new SeleniumControl( sDriver, "ChildForm_PODetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VCHRLNHS_PODETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APQVCHRH_ChildForm_PODetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing ClickButton on ChildForm_PODetailForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_PODetailForm = new SeleniumControl( sDriver, "ChildForm_PODetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VCHRLNHS_PODETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_PODetailForm);
IWebElement formBttn = APQVCHRH_ChildForm_PODetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APQVCHRH_ChildForm_PODetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APQVCHRH_ChildForm_PODetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing VerifyExists on ChildForm_PODetail_VoucherLine...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_PODetail_VoucherLine = new SeleniumControl( sDriver, "ChildForm_PODetail_VoucherLine", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VCHRLNHS_PODETAIL_']/ancestor::form[1]/descendant::*[@id='VCHR_LN_NO']");
				Function.AssertEqual(true,APQVCHRH_ChildForm_PODetail_VoucherLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Close on ChildForm_PODetailForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_ChildForm_PODetailForm = new SeleniumControl( sDriver, "ChildForm_PODetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVCHRH_VCHRLNHS_PODETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVCHRH_ChildForm_PODetailForm);
IWebElement formBttn = APQVCHRH_ChildForm_PODetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVCHRH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVCHRH] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APQVCHRH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APQVCHRH_MainForm);
IWebElement formBttn = APQVCHRH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

