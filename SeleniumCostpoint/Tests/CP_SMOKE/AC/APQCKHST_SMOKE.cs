 
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
    public class APQCKHST_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"View Check History Inquiry", "xpath","//div[@class='navItem'][.='View Check History Inquiry']").Click();


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
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APQCKHST_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExists on CashAccount...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_CashAccount = new SeleniumControl( sDriver, "CashAccount", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CASH_ACCTID']");
				Function.AssertEqual(true,APQCKHST_CashAccount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VENDCHK_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,APQCKHST_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VENDCHK_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APQCKHST_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExists on ChildForm_ContactsLink...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_ChildForm_ContactsLink = new SeleniumControl( sDriver, "ChildForm_ContactsLink", "ID", "lnk_1005358_APQCKHST_VENDCHK_CHILD");
				Function.AssertEqual(true,APQCKHST_ChildForm_ContactsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExists on ChildForm_VendorLink...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_ChildForm_VendorLink = new SeleniumControl( sDriver, "ChildForm_VendorLink", "ID", "lnk_1005361_APQCKHST_VENDCHK_CHILD");
				Function.AssertEqual(true,APQCKHST_ChildForm_VendorLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExists on ChildForm_VouchersLink...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_ChildForm_VouchersLink = new SeleniumControl( sDriver, "ChildForm_VouchersLink", "ID", "lnk_1005374_APQCKHST_VENDCHK_CHILD");
				Function.AssertEqual(true,APQCKHST_ChildForm_VouchersLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing Click on ChildForm_ContactsLink...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_ChildForm_ContactsLink = new SeleniumControl( sDriver, "ChildForm_ContactsLink", "ID", "lnk_1005358_APQCKHST_VENDCHK_CHILD");
				Function.WaitControlDisplayed(APQCKHST_ChildForm_ContactsLink);
APQCKHST_ChildForm_ContactsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExist on ContactsFormTable...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_ContactsFormTable = new SeleniumControl( sDriver, "ContactsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VENDADDRCNTACT_CNTACT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APQCKHST_ContactsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing ClickButton on ContactsForm...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_ContactsForm = new SeleniumControl( sDriver, "ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VENDADDRCNTACT_CNTACT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQCKHST_ContactsForm);
IWebElement formBttn = APQCKHST_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APQCKHST_ContactsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APQCKHST_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExists on Contacts_FirstName...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_Contacts_FirstName = new SeleniumControl( sDriver, "Contacts_FirstName", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VENDADDRCNTACT_CNTACT_']/ancestor::form[1]/descendant::*[@id='CNTACT_FIRST_NAME']");
				Function.AssertEqual(true,APQCKHST_Contacts_FirstName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing Close on ContactsForm...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_ContactsForm = new SeleniumControl( sDriver, "ContactsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VENDADDRCNTACT_CNTACT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQCKHST_ContactsForm);
IWebElement formBttn = APQCKHST_ContactsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing Click on ChildForm_VendorLink...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_ChildForm_VendorLink = new SeleniumControl( sDriver, "ChildForm_VendorLink", "ID", "lnk_1005361_APQCKHST_VENDCHK_CHILD");
				Function.WaitControlDisplayed(APQCKHST_ChildForm_VendorLink);
APQCKHST_ChildForm_VendorLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExists on VendorForm...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_VendorForm = new SeleniumControl( sDriver, "VendorForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VENDADDR_VENDOR_']/ancestor::form[1]");
				Function.AssertEqual(true,APQCKHST_VendorForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExists on Vendor_Line1...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_Vendor_Line1 = new SeleniumControl( sDriver, "Vendor_Line1", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VENDADDR_VENDOR_']/ancestor::form[1]/descendant::*[@id='LN_1_ADR']");
				Function.AssertEqual(true,APQCKHST_Vendor_Line1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing ClickButton on VendorForm...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_VendorForm = new SeleniumControl( sDriver, "VendorForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VENDADDR_VENDOR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQCKHST_VendorForm);
IWebElement formBttn = APQCKHST_VendorForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? APQCKHST_VendorForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
APQCKHST_VendorForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExist on VendorFormTable...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_VendorFormTable = new SeleniumControl( sDriver, "VendorFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VENDADDR_VENDOR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APQCKHST_VendorFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing Close on VendorForm...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_VendorForm = new SeleniumControl( sDriver, "VendorForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VENDADDR_VENDOR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQCKHST_VendorForm);
IWebElement formBttn = APQCKHST_VendorForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing Click on ChildForm_VouchersLink...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_ChildForm_VouchersLink = new SeleniumControl( sDriver, "ChildForm_VouchersLink", "ID", "lnk_1005374_APQCKHST_VENDCHK_CHILD");
				Function.WaitControlDisplayed(APQCKHST_ChildForm_VouchersLink);
APQCKHST_ChildForm_VouchersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExists on VouchersForm...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_VouchersForm = new SeleniumControl( sDriver, "VouchersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VCHRHDRHS_VOUCHERS_']/ancestor::form[1]");
				Function.AssertEqual(true,APQCKHST_VouchersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExist on VouchersFormTable...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_VouchersFormTable = new SeleniumControl( sDriver, "VouchersFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VCHRHDRHS_VOUCHERS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APQCKHST_VouchersFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing ClickButton on VouchersForm...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_VouchersForm = new SeleniumControl( sDriver, "VouchersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VCHRHDRHS_VOUCHERS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQCKHST_VouchersForm);
IWebElement formBttn = APQCKHST_VouchersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APQCKHST_VouchersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APQCKHST_VouchersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing VerifyExists on Vouchers_Voucher...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_Vouchers_Voucher = new SeleniumControl( sDriver, "Vouchers_Voucher", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VCHRHDRHS_VOUCHERS_']/ancestor::form[1]/descendant::*[@id='VCHR_NO']");
				Function.AssertEqual(true,APQCKHST_Vouchers_Voucher.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing Close on VouchersForm...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_VouchersForm = new SeleniumControl( sDriver, "VouchersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQCKHST_VCHRHDRHS_VOUCHERS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQCKHST_VouchersForm);
IWebElement formBttn = APQCKHST_VouchersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQCKHST";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQCKHST] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APQCKHST_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APQCKHST_MainForm);
IWebElement formBttn = APQCKHST_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

