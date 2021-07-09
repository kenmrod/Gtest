 
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
    public class BLMPJPRD_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Projects", "xpath","//div[@class='busItem'][.='Projects']").Click();
new SeleniumControl(sDriver,"Billing", "xpath","//div[@class='deptItem'][.='Billing']").Click();
new SeleniumControl(sDriver,"Project Product Bills Processing", "xpath","//div[@class='navItem'][.='Project Product Bills Processing']").Click();
new SeleniumControl(sDriver,"Manage Project Product Bills", "xpath","//div[@class='navItem'][.='Manage Project Product Bills']").Click();


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
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMPJPRD_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on Identification_Project...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_Identification_Project = new SeleniumControl( sDriver, "Identification_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BLMPJPRD_Identification_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPJPRD_MainTab);
IWebElement mTab = BLMPJPRD_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Billing Detail").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on BillingDetail_Customer...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_BillingDetail_Customer = new SeleniumControl( sDriver, "BillingDetail_Customer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,BLMPJPRD_BillingDetail_Customer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPJPRD_MainTab);
IWebElement mTab = BLMPJPRD_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Address Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on AddressInfo_BillTo_Address...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_AddressInfo_BillTo_Address = new SeleniumControl( sDriver, "AddressInfo_BillTo_Address", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ADDR_DC']");
				Function.AssertEqual(true,BLMPJPRD_AddressInfo_BillTo_Address.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPJPRD_MainTab);
IWebElement mTab = BLMPJPRD_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on OtherInfo_OtherCharges_Code...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_OtherInfo_OtherCharges_Code = new SeleniumControl( sDriver, "OtherInfo_OtherCharges_Code", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='OTH_CHG_CD1']");
				Function.AssertEqual(true,BLMPJPRD_OtherInfo_OtherCharges_Code.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMPJPRD_MainTab);
IWebElement mTab = BLMPJPRD_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on Notes_Notes...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_Notes_Notes = new SeleniumControl( sDriver, "Notes_Notes", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='NOTES']");
				Function.AssertEqual(true,BLMPJPRD_Notes_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMPJPRD_MainForm);
IWebElement formBttn = BLMPJPRD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BLMPJPRD_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BLMPJPRD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMPJPRD_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PROJECT PRODUCT BILLING LINES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExist on ProjectProductBillingLinesFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLinesFormTable = new SeleniumControl( sDriver, "ProjectProductBillingLinesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODINVCLN_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLinesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing ClickButton on ProjectProductBillingLinesForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLinesForm = new SeleniumControl( sDriver, "ProjectProductBillingLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODINVCLN_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPJPRD_ProjectProductBillingLinesForm);
IWebElement formBttn = BLMPJPRD_ProjectProductBillingLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMPJPRD_ProjectProductBillingLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMPJPRD_ProjectProductBillingLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLinesForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLinesForm = new SeleniumControl( sDriver, "ProjectProductBillingLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODINVCLN_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLines_Line...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_Line = new SeleniumControl( sDriver, "ProjectProductBillingLines_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODINVCLN_CHLD_']/ancestor::form[1]/descendant::*[@id='PROD_INVC_LN_NO']");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CUSTOMS INFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLines_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_CustomsInfoLink = new SeleniumControl( sDriver, "ProjectProductBillingLines_CustomsInfoLink", "ID", "lnk_1004115_BLMPJPRD_PROJPRODINVCLN_CHLD");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_CustomsInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Click on ProjectProductBillingLines_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_CustomsInfoLink = new SeleniumControl( sDriver, "ProjectProductBillingLines_CustomsInfoLink", "ID", "lnk_1004115_BLMPJPRD_PROJPRODINVCLN_CHLD");
				Function.WaitControlDisplayed(BLMPJPRD_ProjectProductBillingLines_CustomsInfoLink);
BLMPJPRD_ProjectProductBillingLines_CustomsInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLines_CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_CustomsInfoForm = new SeleniumControl( sDriver, "ProjectProductBillingLines_CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_CustomsInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLines_CustomsInfo_ValueAddedTaxInformation_TaxCode...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_CustomsInfo_ValueAddedTaxInformation_TaxCode = new SeleniumControl( sDriver, "ProjectProductBillingLines_CustomsInfo_ValueAddedTaxInformation_TaxCode", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_CustomsInfo_ValueAddedTaxInformation_TaxCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing ClickButton on ProjectProductBillingLines_CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_CustomsInfoForm = new SeleniumControl( sDriver, "ProjectProductBillingLines_CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPJPRD_ProjectProductBillingLines_CustomsInfoForm);
IWebElement formBttn = BLMPJPRD_ProjectProductBillingLines_CustomsInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BLMPJPRD_ProjectProductBillingLines_CustomsInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BLMPJPRD_ProjectProductBillingLines_CustomsInfoForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExist on ProjectProductBillingLines_CustomsInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_CustomsInfoFormTable = new SeleniumControl( sDriver, "ProjectProductBillingLines_CustomsInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_CustomsInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Close on ProjectProductBillingLines_CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_CustomsInfoForm = new SeleniumControl( sDriver, "ProjectProductBillingLines_CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPJPRD_ProjectProductBillingLines_CustomsInfoForm);
IWebElement formBttn = BLMPJPRD_ProjectProductBillingLines_CustomsInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CURRENCY LINE INFO");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLines_CurrencyLineInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_CurrencyLineInfoLink = new SeleniumControl( sDriver, "ProjectProductBillingLines_CurrencyLineInfoLink", "ID", "lnk_1003410_BLMPJPRD_PROJPRODINVCLN_CHLD");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_CurrencyLineInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Click on ProjectProductBillingLines_CurrencyLineInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_CurrencyLineInfoLink = new SeleniumControl( sDriver, "ProjectProductBillingLines_CurrencyLineInfoLink", "ID", "lnk_1003410_BLMPJPRD_PROJPRODINVCLN_CHLD");
				Function.WaitControlDisplayed(BLMPJPRD_ProjectProductBillingLines_CurrencyLineInfoLink);
BLMPJPRD_ProjectProductBillingLines_CurrencyLineInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLines_CurrencyLineInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_CurrencyLineInfoForm = new SeleniumControl( sDriver, "ProjectProductBillingLines_CurrencyLineInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_CURRLINEINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_CurrencyLineInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLines_CurrencyLineInfo_ExchangeRates_BillingToFunctional...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_CurrencyLineInfo_ExchangeRates_BillingToFunctional = new SeleniumControl( sDriver, "ProjectProductBillingLines_CurrencyLineInfo_ExchangeRates_BillingToFunctional", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_CURRLINEINFO_']/ancestor::form[1]/descendant::*[@id='TRAN_TO_FUNC_ER']");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_CurrencyLineInfo_ExchangeRates_BillingToFunctional.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Close on ProjectProductBillingLines_CurrencyLineInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_CurrencyLineInfoForm = new SeleniumControl( sDriver, "ProjectProductBillingLines_CurrencyLineInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_CURRLINEINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPJPRD_ProjectProductBillingLines_CurrencyLineInfoForm);
IWebElement formBttn = BLMPJPRD_ProjectProductBillingLines_CurrencyLineInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ACRNs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLines_ACRNsLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_ACRNsLink = new SeleniumControl( sDriver, "ProjectProductBillingLines_ACRNsLink", "ID", "lnk_1007746_BLMPJPRD_PROJPRODINVCLN_CHLD");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_ACRNsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Click on ProjectProductBillingLines_ACRNsLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_ACRNsLink = new SeleniumControl( sDriver, "ProjectProductBillingLines_ACRNsLink", "ID", "lnk_1007746_BLMPJPRD_PROJPRODINVCLN_CHLD");
				Function.WaitControlDisplayed(BLMPJPRD_ProjectProductBillingLines_ACRNsLink);
BLMPJPRD_ProjectProductBillingLines_ACRNsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLines_ACRNsForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_ACRNsForm = new SeleniumControl( sDriver, "ProjectProductBillingLines_ACRNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODACRN_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_ACRNsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLines_ACRNs_Ok...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_ACRNs_Ok = new SeleniumControl( sDriver, "ProjectProductBillingLines_ACRNs_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODACRN_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_ACRNs_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExist on ProjectProductBillingLines_ACRNsFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_ACRNsFormTable = new SeleniumControl( sDriver, "ProjectProductBillingLines_ACRNsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODACRN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_ACRNsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Close on ProjectProductBillingLines_ACRNsForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_ACRNsForm = new SeleniumControl( sDriver, "ProjectProductBillingLines_ACRNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODACRN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPJPRD_ProjectProductBillingLines_ACRNsForm);
IWebElement formBttn = BLMPJPRD_ProjectProductBillingLines_ACRNsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MILSTRIPs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLines_MILSTRIPsLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_MILSTRIPsLink = new SeleniumControl( sDriver, "ProjectProductBillingLines_MILSTRIPsLink", "ID", "lnk_1007747_BLMPJPRD_PROJPRODINVCLN_CHLD");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_MILSTRIPsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Click on ProjectProductBillingLines_MILSTRIPsLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_MILSTRIPsLink = new SeleniumControl( sDriver, "ProjectProductBillingLines_MILSTRIPsLink", "ID", "lnk_1007747_BLMPJPRD_PROJPRODINVCLN_CHLD");
				Function.WaitControlDisplayed(BLMPJPRD_ProjectProductBillingLines_MILSTRIPsLink);
BLMPJPRD_ProjectProductBillingLines_MILSTRIPsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLines_MILSTRIPsForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_MILSTRIPsForm = new SeleniumControl( sDriver, "ProjectProductBillingLines_MILSTRIPsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODMILSTRIPPRO_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_MILSTRIPsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExist on ProjectProductBillingLines_MILSTRIPsFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_MILSTRIPsFormTable = new SeleniumControl( sDriver, "ProjectProductBillingLines_MILSTRIPsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODMILSTRIPPRO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_MILSTRIPsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ProjectProductBillingLines_MILSTRIPs_Ok...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_MILSTRIPs_Ok = new SeleniumControl( sDriver, "ProjectProductBillingLines_MILSTRIPs_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODMILSTRIPPRO_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,BLMPJPRD_ProjectProductBillingLines_MILSTRIPs_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Close on ProjectProductBillingLines_MILSTRIPsForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ProjectProductBillingLines_MILSTRIPsForm = new SeleniumControl( sDriver, "ProjectProductBillingLines_MILSTRIPsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODMILSTRIPPRO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPJPRD_ProjectProductBillingLines_MILSTRIPsForm);
IWebElement formBttn = BLMPJPRD_ProjectProductBillingLines_MILSTRIPsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("STANDARD TEXT");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on StandardTextLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_StandardTextLink = new SeleniumControl( sDriver, "StandardTextLink", "ID", "lnk_1003388_BLMPJPRD_PROJPRODINVCHDR");
				Function.AssertEqual(true,BLMPJPRD_StandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Click on StandardTextLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_StandardTextLink = new SeleniumControl( sDriver, "StandardTextLink", "ID", "lnk_1003388_BLMPJPRD_PROJPRODINVCHDR");
				Function.WaitControlDisplayed(BLMPJPRD_StandardTextLink);
BLMPJPRD_StandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_StandardTextForm = new SeleniumControl( sDriver, "StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODINVCTXT_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMPJPRD_StandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExist on StandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_StandardTextFormTable = new SeleniumControl( sDriver, "StandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODINVCTXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMPJPRD_StandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on StandardText_Ok...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_StandardText_Ok = new SeleniumControl( sDriver, "StandardText_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODINVCTXT_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,BLMPJPRD_StandardText_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Close on StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_StandardTextForm = new SeleniumControl( sDriver, "StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMPJPRD_PROJPRODINVCTXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPJPRD_StandardTextForm);
IWebElement formBttn = BLMPJPRD_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EXCHANGE RATES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003406_BLMPJPRD_PROJPRODINVCHDR");
				Function.AssertEqual(true,BLMPJPRD_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003406_BLMPJPRD_PROJPRODINVCHDR");
				Function.WaitControlDisplayed(BLMPJPRD_ExchangeRatesLink);
BLMPJPRD_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMPJPRD_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,BLMPJPRD_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPJPRD_ExchangeRatesForm);
IWebElement formBttn = BLMPJPRD_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("INVOICE TOTALS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on InvoiceTotalsLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_InvoiceTotalsLink = new SeleniumControl( sDriver, "InvoiceTotalsLink", "ID", "lnk_1003391_BLMPJPRD_PROJPRODINVCHDR");
				Function.AssertEqual(true,BLMPJPRD_InvoiceTotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Click on InvoiceTotalsLink...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_InvoiceTotalsLink = new SeleniumControl( sDriver, "InvoiceTotalsLink", "ID", "lnk_1003391_BLMPJPRD_PROJPRODINVCHDR");
				Function.WaitControlDisplayed(BLMPJPRD_InvoiceTotalsLink);
BLMPJPRD_InvoiceTotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on InvoiceTotalsForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_InvoiceTotalsForm = new SeleniumControl( sDriver, "InvoiceTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPBLINVT_INVCTOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMPJPRD_InvoiceTotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing VerifyExists on InvoiceTotals_ExchangeRates_BillingToFunctional...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_InvoiceTotals_ExchangeRates_BillingToFunctional = new SeleniumControl( sDriver, "InvoiceTotals_ExchangeRates_BillingToFunctional", "xpath", "//div[translate(@id,'0123456789','')='pr__CPBLINVT_INVCTOTALS_']/ancestor::form[1]/descendant::*[@id='TRANS_TO_FUNC_ER']");
				Function.AssertEqual(true,BLMPJPRD_InvoiceTotals_ExchangeRates_BillingToFunctional.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Close on InvoiceTotalsForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_InvoiceTotalsForm = new SeleniumControl( sDriver, "InvoiceTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPBLINVT_INVCTOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMPJPRD_InvoiceTotalsForm);
IWebElement formBttn = BLMPJPRD_InvoiceTotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMPJPRD_MainForm);
IWebElement formBttn = BLMPJPRD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).Count <= 0 ? BLMPJPRD_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Delete')]")).FirstOrDefault() :
BLMPJPRD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Delete not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Save.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMPJPRD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMPJPRD] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMPJPRD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMPJPRD_MainForm);
IWebElement formBttn = BLMPJPRD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

