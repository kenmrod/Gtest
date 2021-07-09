 
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
    public class APMVEND_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Vendors", "xpath","//div[@class='navItem'][.='Vendors']").Click();
new SeleniumControl(sDriver,"Manage Vendors", "xpath","//div[@class='navItem'][.='Manage Vendors']").Click();


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
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APMVEND_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on VendorID...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorID = new SeleniumControl( sDriver, "VendorID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,APMVEND_VendorID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVEND_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVEND_MainFormTab);
IWebElement mTab = APMVEND_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on Header_LongName...", Logger.MessageType.INF);
				SeleniumControl APMVEND_Header_LongName = new SeleniumControl( sDriver, "Header_LongName", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VEND_LONG_NAME']");
				Function.AssertEqual(true,APMVEND_Header_LongName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVEND_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVEND_MainFormTab);
IWebElement mTab = APMVEND_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Defaults").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on Defaults_PayVendorName...", Logger.MessageType.INF);
				SeleniumControl APMVEND_Defaults_PayVendorName = new SeleniumControl( sDriver, "Defaults_PayVendorName", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VEND_NAME1']");
				Function.AssertEqual(true,APMVEND_Defaults_PayVendorName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl APMVEND_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(APMVEND_MainFormTab);
IWebElement mTab = APMVEND_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on Notes_Text...", Logger.MessageType.INF);
				SeleniumControl APMVEND_Notes_Text = new SeleniumControl( sDriver, "Notes_Text", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VEND_NOTES']");
				Function.AssertEqual(true,APMVEND_Notes_Text.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMVEND_MainForm);
IWebElement formBttn = APMVEND_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? APMVEND_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
APMVEND_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVEND_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVEND_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("VENDOR EMPLOYEES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on VendorEMPLOYEESLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorEMPLOYEESLink = new SeleniumControl( sDriver, "VendorEMPLOYEESLink", "ID", "lnk_1005727_CPMVEND_VEND");
				Function.AssertEqual(true,APMVEND_VendorEMPLOYEESLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Click on VendorEMPLOYEESLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorEMPLOYEESLink = new SeleniumControl( sDriver, "VendorEMPLOYEESLink", "ID", "lnk_1005727_CPMVEND_VEND");
				Function.WaitControlDisplayed(APMVEND_VendorEMPLOYEESLink);
APMVEND_VendorEMPLOYEESLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on VendorEmployeeDetailsForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorEmployeeDetailsForm = new SeleniumControl( sDriver, "VendorEmployeeDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVENDE_VENDEMPL_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVEND_VendorEmployeeDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on VendorEmployeeDetails_VendorEMPLOYEEID...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorEmployeeDetails_VendorEMPLOYEEID = new SeleniumControl( sDriver, "VendorEmployeeDetails_VendorEMPLOYEEID", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVENDE_VENDEMPL_HDR_']/ancestor::form[1]/descendant::*[@id='VEND_EMPL_ID']");
				Function.AssertEqual(true,APMVEND_VendorEmployeeDetails_VendorEMPLOYEEID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing ClickButton on VendorEmployeeDetailsForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorEmployeeDetailsForm = new SeleniumControl( sDriver, "VendorEmployeeDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVENDE_VENDEMPL_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_VendorEmployeeDetailsForm);
IWebElement formBttn = APMVEND_VendorEmployeeDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? APMVEND_VendorEmployeeDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
APMVEND_VendorEmployeeDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExist on VendorEmployeeDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorEmployeeDetailsFormTable = new SeleniumControl( sDriver, "VendorEmployeeDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVENDE_VENDEMPL_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVEND_VendorEmployeeDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Close on VendorEmployeeDetailsForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorEmployeeDetailsForm = new SeleniumControl( sDriver, "VendorEmployeeDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVENDE_VENDEMPL_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_VendorEmployeeDetailsForm);
IWebElement formBttn = APMVEND_VendorEmployeeDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("VENDOR CLASSIFICATION");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on VendorClassificationLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorClassificationLink = new SeleniumControl( sDriver, "VendorClassificationLink", "ID", "lnk_1005132_CPMVEND_VEND");
				Function.AssertEqual(true,APMVEND_VendorClassificationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Click on VendorClassificationLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorClassificationLink = new SeleniumControl( sDriver, "VendorClassificationLink", "ID", "lnk_1005132_CPMVEND_VEND");
				Function.WaitControlDisplayed(APMVEND_VendorClassificationLink);
APMVEND_VendorClassificationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on VendorClassificationForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorClassificationForm = new SeleniumControl( sDriver, "VendorClassificationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VEND_CLASSIF_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVEND_VendorClassificationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on VendorClassification_DefaultSize_Large...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorClassification_DefaultSize_Large = new SeleniumControl( sDriver, "VendorClassification_DefaultSize_Large", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VEND_CLASSIF_']/ancestor::form[1]/descendant::*[@id='S_CL_SM_BUS_CD' and @value='L']");
				Function.AssertEqual(true,APMVEND_VendorClassification_DefaultSize_Large.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on VendorClassificationChildForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorClassificationChildForm = new SeleniumControl( sDriver, "VendorClassificationChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDINDCLASS_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVEND_VendorClassificationChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExist on VendorClassificationChildFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorClassificationChildFormTable = new SeleniumControl( sDriver, "VendorClassificationChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDINDCLASS_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVEND_VendorClassificationChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Close on VendorClassificationForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VendorClassificationForm = new SeleniumControl( sDriver, "VendorClassificationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VEND_CLASSIF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_VendorClassificationForm);
IWebElement formBttn = APMVEND_VendorClassificationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CURRENCIES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on CurrenciesLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CurrenciesLink = new SeleniumControl( sDriver, "CurrenciesLink", "ID", "lnk_1005729_CPMVEND_VEND");
				Function.AssertEqual(true,APMVEND_CurrenciesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Click on CurrenciesLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CurrenciesLink = new SeleniumControl( sDriver, "CurrenciesLink", "ID", "lnk_1005729_CPMVEND_VEND");
				Function.WaitControlDisplayed(APMVEND_CurrenciesLink);
APMVEND_CurrenciesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on CurrenciesForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CurrenciesForm = new SeleniumControl( sDriver, "CurrenciesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VEND_CURRENCY_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVEND_CurrenciesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on Currencies_RateGroup...", Logger.MessageType.INF);
				SeleniumControl APMVEND_Currencies_RateGroup = new SeleniumControl( sDriver, "Currencies_RateGroup", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VEND_CURRENCY_']/ancestor::form[1]/descendant::*[@id='DFLT_RT_GRP_ID']");
				Function.AssertEqual(true,APMVEND_Currencies_RateGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on Currencies_TransactionCurrenciesForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_Currencies_TransactionCurrenciesForm = new SeleniumControl( sDriver, "Currencies_TransactionCurrenciesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDLIMITCRNCY_TRANS_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVEND_Currencies_TransactionCurrenciesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExist on Currencies_TransactionCurrenciesFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVEND_Currencies_TransactionCurrenciesFormTable = new SeleniumControl( sDriver, "Currencies_TransactionCurrenciesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDLIMITCRNCY_TRANS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVEND_Currencies_TransactionCurrenciesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on Currencies_PayCurrenciesForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_Currencies_PayCurrenciesForm = new SeleniumControl( sDriver, "Currencies_PayCurrenciesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDLIMITCRNCY_PAY_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVEND_Currencies_PayCurrenciesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExist on Currencies_PayCurrenciesFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVEND_Currencies_PayCurrenciesFormTable = new SeleniumControl( sDriver, "Currencies_PayCurrenciesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDLIMITCRNCY_PAY_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVEND_Currencies_PayCurrenciesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Close on CurrenciesForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CurrenciesForm = new SeleniumControl( sDriver, "CurrenciesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VEND_CURRENCY_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_CurrenciesForm);
IWebElement formBttn = APMVEND_CurrenciesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SUBCONTRACTOR INFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on SubcontractorInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_SubcontractorInfoLink = new SeleniumControl( sDriver, "SubcontractorInfoLink", "ID", "lnk_1005150_CPMVEND_VEND");
				Function.AssertEqual(true,APMVEND_SubcontractorInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Click on SubcontractorInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_SubcontractorInfoLink = new SeleniumControl( sDriver, "SubcontractorInfoLink", "ID", "lnk_1005150_CPMVEND_VEND");
				Function.WaitControlDisplayed(APMVEND_SubcontractorInfoLink);
APMVEND_SubcontractorInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on SubContractorInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_SubContractorInfoForm = new SeleniumControl( sDriver, "SubContractorInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VEND_SUBPAY_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVEND_SubContractorInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on SubcontractorInfo_PaymentControl...", Logger.MessageType.INF);
				SeleniumControl APMVEND_SubcontractorInfo_PaymentControl = new SeleniumControl( sDriver, "SubcontractorInfo_PaymentControl", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VEND_SUBPAY_']/ancestor::form[1]/descendant::*[@id='SUBCTR_FL']");
				Function.AssertEqual(true,APMVEND_SubcontractorInfo_PaymentControl.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Close on SubContractorInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_SubContractorInfoForm = new SeleniumControl( sDriver, "SubContractorInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VEND_SUBPAY_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_SubContractorInfoForm);
IWebElement formBttn = APMVEND_SubContractorInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CREDIT CARD INFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on CreditCardInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CreditCardInfoLink = new SeleniumControl( sDriver, "CreditCardInfoLink", "ID", "lnk_1005599_CPMVEND_VEND");
				Function.AssertEqual(true,APMVEND_CreditCardInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Click on CreditCardInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CreditCardInfoLink = new SeleniumControl( sDriver, "CreditCardInfoLink", "ID", "lnk_1005599_CPMVEND_VEND");
				Function.WaitControlDisplayed(APMVEND_CreditCardInfoLink);
APMVEND_CreditCardInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExist on CreditCardInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CreditCardInfoFormTable = new SeleniumControl( sDriver, "CreditCardInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVCCI_CRCARDVENDINFO_HDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVEND_CreditCardInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing ClickButton on CreditCardInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CreditCardInfoForm = new SeleniumControl( sDriver, "CreditCardInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVCCI_CRCARDVENDINFO_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_CreditCardInfoForm);
IWebElement formBttn = APMVEND_CreditCardInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMVEND_CreditCardInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMVEND_CreditCardInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on CreditCardInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CreditCardInfoForm = new SeleniumControl( sDriver, "CreditCardInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVCCI_CRCARDVENDINFO_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVEND_CreditCardInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on CreditCardInfo_CreditCardType...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CreditCardInfo_CreditCardType = new SeleniumControl( sDriver, "CreditCardInfo_CreditCardType", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVCCI_CRCARDVENDINFO_HDR_']/ancestor::form[1]/descendant::*[@id='CR_CARD_TYPE']");
				Function.AssertEqual(true,APMVEND_CreditCardInfo_CreditCardType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Close on CreditCardInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CreditCardInfoForm = new SeleniumControl( sDriver, "CreditCardInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVCCI_CRCARDVENDINFO_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_CreditCardInfoForm);
IWebElement formBttn = APMVEND_CreditCardInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ADDRESSES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on AddressesLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_AddressesLink = new SeleniumControl( sDriver, "AddressesLink", "ID", "lnk_1005127_CPMVEND_VEND");
				Function.AssertEqual(true,APMVEND_AddressesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Click on AddressesLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_AddressesLink = new SeleniumControl( sDriver, "AddressesLink", "ID", "lnk_1005127_CPMVEND_VEND");
				Function.WaitControlDisplayed(APMVEND_AddressesLink);
APMVEND_AddressesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExist on AddressesFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVEND_AddressesFormTable = new SeleniumControl( sDriver, "AddressesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDADDR_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVEND_AddressesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing ClickButton on AddressesForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_AddressesForm = new SeleniumControl( sDriver, "AddressesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDADDR_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_AddressesForm);
IWebElement formBttn = APMVEND_AddressesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMVEND_AddressesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMVEND_AddressesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on AddressesForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_AddressesForm = new SeleniumControl( sDriver, "AddressesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDADDR_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVEND_AddressesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on Addresses_AddressCode...", Logger.MessageType.INF);
				SeleniumControl APMVEND_Addresses_AddressCode = new SeleniumControl( sDriver, "Addresses_AddressCode", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDADDR_CHLD_']/ancestor::form[1]/descendant::*[@id='ADDR_DC']");
				Function.AssertEqual(true,APMVEND_Addresses_AddressCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Close on AddressesForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_AddressesForm = new SeleniumControl( sDriver, "AddressesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDADDR_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_AddressesForm);
IWebElement formBttn = APMVEND_AddressesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DEFAULT EXPENSE ACCOUNTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on DefaultExpenseAccountsLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_DefaultExpenseAccountsLink = new SeleniumControl( sDriver, "DefaultExpenseAccountsLink", "ID", "lnk_1005129_CPMVEND_VEND");
				Function.AssertEqual(true,APMVEND_DefaultExpenseAccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Click on DefaultExpenseAccountsLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_DefaultExpenseAccountsLink = new SeleniumControl( sDriver, "DefaultExpenseAccountsLink", "ID", "lnk_1005129_CPMVEND_VEND");
				Function.WaitControlDisplayed(APMVEND_DefaultExpenseAccountsLink);
APMVEND_DefaultExpenseAccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExist on DefaultExpenseAccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVEND_DefaultExpenseAccountsFormTable = new SeleniumControl( sDriver, "DefaultExpenseAccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDEXPACCT_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVEND_DefaultExpenseAccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing ClickButton on DefaultExpenseAccountsForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_DefaultExpenseAccountsForm = new SeleniumControl( sDriver, "DefaultExpenseAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDEXPACCT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_DefaultExpenseAccountsForm);
IWebElement formBttn = APMVEND_DefaultExpenseAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMVEND_DefaultExpenseAccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMVEND_DefaultExpenseAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on DefaultExpenseAccountsForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_DefaultExpenseAccountsForm = new SeleniumControl( sDriver, "DefaultExpenseAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDEXPACCT_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVEND_DefaultExpenseAccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on DefaultExpenseAccounts_Line...", Logger.MessageType.INF);
				SeleniumControl APMVEND_DefaultExpenseAccounts_Line = new SeleniumControl( sDriver, "DefaultExpenseAccounts_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDEXPACCT_CHLD_']/ancestor::form[1]/descendant::*[@id='LN_NO']");
				Function.AssertEqual(true,APMVEND_DefaultExpenseAccounts_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Close on DefaultExpenseAccountsForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_DefaultExpenseAccountsForm = new SeleniumControl( sDriver, "DefaultExpenseAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDEXPACCT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_DefaultExpenseAccountsForm);
IWebElement formBttn = APMVEND_DefaultExpenseAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("VAT INFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on VATInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VATInfoLink = new SeleniumControl( sDriver, "VATInfoLink", "ID", "lnk_1005130_CPMVEND_VEND");
				Function.AssertEqual(true,APMVEND_VATInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Click on VATInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VATInfoLink = new SeleniumControl( sDriver, "VATInfoLink", "ID", "lnk_1005130_CPMVEND_VEND");
				Function.WaitControlDisplayed(APMVEND_VATInfoLink);
APMVEND_VATInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on VATInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VATInfoForm = new SeleniumControl( sDriver, "VATInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDVATINFO_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVEND_VATInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExist on VATInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VATInfoFormTable = new SeleniumControl( sDriver, "VATInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDVATINFO_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVEND_VATInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Close on VATInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_VATInfoForm = new SeleniumControl( sDriver, "VATInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDVATINFO_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_VATInfoForm);
IWebElement formBttn = APMVEND_VATInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CIS INFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on CISInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CISInfoLink = new SeleniumControl( sDriver, "CISInfoLink", "ID", "lnk_1005131_CPMVEND_VEND");
				Function.AssertEqual(true,APMVEND_CISInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Click on CISInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CISInfoLink = new SeleniumControl( sDriver, "CISInfoLink", "ID", "lnk_1005131_CPMVEND_VEND");
				Function.WaitControlDisplayed(APMVEND_CISInfoLink);
APMVEND_CISInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on CISInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CISInfoForm = new SeleniumControl( sDriver, "CISInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDCISINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVEND_CISInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on CISInfo_DetailData_CISCode...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CISInfo_DetailData_CISCode = new SeleniumControl( sDriver, "CISInfo_DetailData_CISCode", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDCISINFO_']/ancestor::form[1]/descendant::*[@id='CIS_CD']");
				Function.AssertEqual(true,APMVEND_CISInfo_DetailData_CISCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Close on CISInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_CISInfoForm = new SeleniumControl( sDriver, "CISInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMVEND_VENDCISINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_CISInfoForm);
IWebElement formBttn = APMVEND_CISInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("USER-DEFINED INFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_1005157_CPMVEND_VEND");
				Function.AssertEqual(true,APMVEND_UserDefinedInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Click on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl APMVEND_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_1005157_CPMVEND_VEND");
				Function.WaitControlDisplayed(APMVEND_UserDefinedInfoLink);
APMVEND_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExist on UserDefinedInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl APMVEND_UserDefinedInfoFormTable = new SeleniumControl( sDriver, "UserDefinedInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVEND_UserDefinedInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing ClickButton on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_UserDefinedInfoForm);
IWebElement formBttn = APMVEND_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMVEND_UserDefinedInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMVEND_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVEND_UserDefinedInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing VerifyExists on UserDefinedInfo_DataType...", Logger.MessageType.INF);
				SeleniumControl APMVEND_UserDefinedInfo_DataType = new SeleniumControl( sDriver, "UserDefinedInfo_DataType", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]/descendant::*[@id='S_DATA_TYPE']");
				Function.AssertEqual(true,APMVEND_UserDefinedInfo_DataType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Close on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPMUDINF_UDEFLBL_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMVEND_UserDefinedInfoForm);
IWebElement formBttn = APMVEND_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVEND";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVEND] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVEND_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMVEND_MainForm);
IWebElement formBttn = APMVEND_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

