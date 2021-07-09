 
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
    public class APQVENDH_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounts Payable Reports/Inquiries", "xpath","//div[@class='navItem'][.='Accounts Payable Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Vendor History Inquiry", "xpath","//div[@class='navItem'][.='View Vendor History Inquiry']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APQVENDH_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExists on Vendor...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_Vendor = new SeleniumControl( sDriver, "Vendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VEND']");
				Function.AssertEqual(true,APQVENDH_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VEND_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APQVENDH_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VEND_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVENDH_ChildForm);
IWebElement formBttn = APQVENDH_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? APQVENDH_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
APQVENDH_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
								try
				{
				this.ScriptLogger.WriteLine("Vouchers");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExists on ChildForm_VouchersLink...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_VouchersLink = new SeleniumControl( sDriver, "ChildForm_VouchersLink", "ID", "lnk_1005417_APQVENDH_VEND_CHILD");
				Function.AssertEqual(true,APQVENDH_ChildForm_VouchersLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing Click on ChildForm_VouchersLink...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_VouchersLink = new SeleniumControl( sDriver, "ChildForm_VouchersLink", "ID", "lnk_1005417_APQVENDH_VEND_CHILD");
				Function.WaitControlDisplayed(APQVENDH_ChildForm_VouchersLink);
APQVENDH_ChildForm_VouchersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExist on ChildForm_VouchersFormTable...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_VouchersFormTable = new SeleniumControl( sDriver, "ChildForm_VouchersFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VCHRHDRHS_VENDVCHR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APQVENDH_ChildForm_VouchersFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing ClickButton on ChildForm_VouchersForm...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_VouchersForm = new SeleniumControl( sDriver, "ChildForm_VouchersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VCHRHDRHS_VENDVCHR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVENDH_ChildForm_VouchersForm);
IWebElement formBttn = APQVENDH_ChildForm_VouchersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APQVENDH_ChildForm_VouchersForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APQVENDH_ChildForm_VouchersForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExists on ChildForm_VouchersForm...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_VouchersForm = new SeleniumControl( sDriver, "ChildForm_VouchersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VCHRHDRHS_VENDVCHR_']/ancestor::form[1]");
				Function.AssertEqual(true,APQVENDH_ChildForm_VouchersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExists on ChildForm_Vouchers_Vchr...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_Vouchers_Vchr = new SeleniumControl( sDriver, "ChildForm_Vouchers_Vchr", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VCHRHDRHS_VENDVCHR_']/ancestor::form[1]/descendant::*[@id='VCHR_NO']");
				Function.AssertEqual(true,APQVENDH_ChildForm_Vouchers_Vchr.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing Close on ChildForm_VouchersForm...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_VouchersForm = new SeleniumControl( sDriver, "ChildForm_VouchersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VCHRHDRHS_VENDVCHR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVENDH_ChildForm_VouchersForm);
IWebElement formBttn = APQVENDH_ChildForm_VouchersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Checks Disbursed");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExists on ChildForm_ChecksDisbursedLink...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_ChecksDisbursedLink = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursedLink", "ID", "lnk_1005414_APQVENDH_VEND_CHILD");
				Function.AssertEqual(true,APQVENDH_ChildForm_ChecksDisbursedLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing Click on ChildForm_ChecksDisbursedLink...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_ChecksDisbursedLink = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursedLink", "ID", "lnk_1005414_APQVENDH_VEND_CHILD");
				Function.WaitControlDisplayed(APQVENDH_ChildForm_ChecksDisbursedLink);
APQVENDH_ChildForm_ChecksDisbursedLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExists on ChildForm_ChecksDisbursedForm...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_ChecksDisbursedForm = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_CHECKDISBURSEDTOTAL_']/ancestor::form[1]");
				Function.AssertEqual(true,APQVENDH_ChildForm_ChecksDisbursedForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExists on ChildForm_ChecksDisbursed_TotalAllChecks...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_ChecksDisbursed_TotalAllChecks = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursed_TotalAllChecks", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_CHECKDISBURSEDTOTAL_']/ancestor::form[1]/descendant::*[@id='TOT_CHKS_PAID']");
				Function.AssertEqual(true,APQVENDH_ChildForm_ChecksDisbursed_TotalAllChecks.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExist on ChildForm_ChecksDisbursed_ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_ChecksDisbursed_ChildFormTable = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursed_ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VENDCHK_CHECKDISBRSD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APQVENDH_ChildForm_ChecksDisbursed_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing ClickButton on ChildForm_ChecksDisbursed_ChildForm...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_ChecksDisbursed_ChildForm = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursed_ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VENDCHK_CHECKDISBRSD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVENDH_ChildForm_ChecksDisbursed_ChildForm);
IWebElement formBttn = APQVENDH_ChildForm_ChecksDisbursed_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APQVENDH_ChildForm_ChecksDisbursed_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APQVENDH_ChildForm_ChecksDisbursed_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExists on ChildForm_ChecksDisbursed_ChildForm...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_ChecksDisbursed_ChildForm = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursed_ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VENDCHK_CHECKDISBRSD_']/ancestor::form[1]");
				Function.AssertEqual(true,APQVENDH_ChildForm_ChecksDisbursed_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExists on ChildForm_ChecksDisbursed_ChildForm_CashAccount...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_ChecksDisbursed_ChildForm_CashAccount = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursed_ChildForm_CashAccount", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VENDCHK_CHECKDISBRSD_']/ancestor::form[1]/descendant::*[@id='CASH_ACCT_ID']");
				Function.AssertEqual(true,APQVENDH_ChildForm_ChecksDisbursed_ChildForm_CashAccount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing Close on ChildForm_ChecksDisbursedForm...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_ChecksDisbursedForm = new SeleniumControl( sDriver, "ChildForm_ChecksDisbursedForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_CHECKDISBURSEDTOTAL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVENDH_ChildForm_ChecksDisbursedForm);
IWebElement formBttn = APQVENDH_ChildForm_ChecksDisbursedForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Address");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExists on ChildForm_AddressLink...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_AddressLink = new SeleniumControl( sDriver, "ChildForm_AddressLink", "ID", "lnk_1005409_APQVENDH_VEND_CHILD");
				Function.AssertEqual(true,APQVENDH_ChildForm_AddressLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing Click on ChildForm_AddressLink...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_AddressLink = new SeleniumControl( sDriver, "ChildForm_AddressLink", "ID", "lnk_1005409_APQVENDH_VEND_CHILD");
				Function.WaitControlDisplayed(APQVENDH_ChildForm_AddressLink);
APQVENDH_ChildForm_AddressLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExist on ChildForm_AddressFormTable...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_AddressFormTable = new SeleniumControl( sDriver, "ChildForm_AddressFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VENDADDR_ADDRESS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APQVENDH_ChildForm_AddressFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing ClickButton on ChildForm_AddressForm...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_AddressForm = new SeleniumControl( sDriver, "ChildForm_AddressForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VENDADDR_ADDRESS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVENDH_ChildForm_AddressForm);
IWebElement formBttn = APQVENDH_ChildForm_AddressForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APQVENDH_ChildForm_AddressForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APQVENDH_ChildForm_AddressForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExists on ChildForm_AddressForm...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_AddressForm = new SeleniumControl( sDriver, "ChildForm_AddressForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VENDADDR_ADDRESS_']/ancestor::form[1]");
				Function.AssertEqual(true,APQVENDH_ChildForm_AddressForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing VerifyExists on ChildForm_Address_AddressCode...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_Address_AddressCode = new SeleniumControl( sDriver, "ChildForm_Address_AddressCode", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VENDADDR_ADDRESS_']/ancestor::form[1]/descendant::*[@id='ADDR_DC']");
				Function.AssertEqual(true,APQVENDH_ChildForm_Address_AddressCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing Close on ChildForm_AddressForm...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_ChildForm_AddressForm = new SeleniumControl( sDriver, "ChildForm_AddressForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APQVENDH_VENDADDR_ADDRESS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APQVENDH_ChildForm_AddressForm);
IWebElement formBttn = APQVENDH_ChildForm_AddressForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APQVENDH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APQVENDH] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APQVENDH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APQVENDH_MainForm);
IWebElement formBttn = APQVENDH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

