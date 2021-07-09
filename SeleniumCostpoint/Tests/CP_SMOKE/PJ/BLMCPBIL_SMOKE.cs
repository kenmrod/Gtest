 
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
    public class BLMCPBIL_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Customer Product Bills Processing", "xpath","//div[@class='navItem'][.='Customer Product Bills Processing']").Click();
new SeleniumControl(sDriver,"Manage Customer Product Bills", "xpath","//div[@class='navItem'][.='Manage Customer Product Bills']").Click();


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
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMCPBIL_MainForm);
IWebElement formBttn = BLMCPBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? BLMCPBIL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
BLMCPBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitControlDisplayed(new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel"));
Function.AssertEqual("Manage Customer Product Bills", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
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
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMCPBIL_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMCPBIL_MainForm);
IWebElement formBttn = BLMCPBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMCPBIL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMCPBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMCPBIL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on Identification_Invoice...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_Identification_Invoice = new SeleniumControl( sDriver, "Identification_Invoice", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVC_ID']");
				Function.AssertEqual(true,BLMCPBIL_Identification_Invoice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMCPBIL_MainTab);
IWebElement mTab = BLMCPBIL_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Invoice Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on InvoiceDetails_Customer...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceDetails_Customer = new SeleniumControl( sDriver, "InvoiceDetails_Customer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,BLMCPBIL_InvoiceDetails_Customer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMCPBIL_MainTab);
IWebElement mTab = BLMCPBIL_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Addresses").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on Addresses_BillAddress_Address...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_Addresses_BillAddress_Address = new SeleniumControl( sDriver, "Addresses_BillAddress_Address", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ADDR_DC']");
				Function.AssertEqual(true,BLMCPBIL_Addresses_BillAddress_Address.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMCPBIL_MainTab);
IWebElement mTab = BLMCPBIL_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Charges").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on OtherCharges_ChargeDetails_Code...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_OtherCharges_ChargeDetails_Code = new SeleniumControl( sDriver, "OtherCharges_ChargeDetails_Code", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='OTH_CHG_CD1']");
				Function.AssertEqual(true,BLMCPBIL_OtherCharges_ChargeDetails_Code.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("INVOICE LINE DETAILS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExist on InvoiceLineDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetailsFormTable = new SeleniumControl( sDriver, "InvoiceLineDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMCPBIL_CUSTPRODINVCLN_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMCPBIL_InvoiceLineDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing ClickButton on InvoiceLineDetailsForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetailsForm = new SeleniumControl( sDriver, "InvoiceLineDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMCPBIL_CUSTPRODINVCLN_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMCPBIL_InvoiceLineDetailsForm);
IWebElement formBttn = BLMCPBIL_InvoiceLineDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMCPBIL_InvoiceLineDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMCPBIL_InvoiceLineDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on InvoiceLineDetailsForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetailsForm = new SeleniumControl( sDriver, "InvoiceLineDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMCPBIL_CUSTPRODINVCLN_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMCPBIL_InvoiceLineDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on InvoiceLineDetails_Line...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetails_Line = new SeleniumControl( sDriver, "InvoiceLineDetails_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMCPBIL_CUSTPRODINVCLN_CHLD_']/ancestor::form[1]/descendant::*[@id='PROD_INVC_LN_NO']");
				Function.AssertEqual(true,BLMCPBIL_InvoiceLineDetails_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on InvoiceLineDetails_CurrencyLineInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetails_CurrencyLineInfoLink = new SeleniumControl( sDriver, "InvoiceLineDetails_CurrencyLineInfoLink", "ID", "lnk_1002580_BLMCPBIL_CUSTPRODINVCLN_CHLD");
				Function.AssertEqual(true,BLMCPBIL_InvoiceLineDetails_CurrencyLineInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Click on InvoiceLineDetails_CurrencyLineInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetails_CurrencyLineInfoLink = new SeleniumControl( sDriver, "InvoiceLineDetails_CurrencyLineInfoLink", "ID", "lnk_1002580_BLMCPBIL_CUSTPRODINVCLN_CHLD");
				Function.WaitControlDisplayed(BLMCPBIL_InvoiceLineDetails_CurrencyLineInfoLink);
BLMCPBIL_InvoiceLineDetails_CurrencyLineInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on InvoiceLineDetails_CurrencyLineInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetails_CurrencyLineInfoForm = new SeleniumControl( sDriver, "InvoiceLineDetails_CurrencyLineInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMCPBIL_CURRENCYLINEINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMCPBIL_InvoiceLineDetails_CurrencyLineInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on InvoiceLineDetails_CurrencyLineInfo_Line...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetails_CurrencyLineInfo_Line = new SeleniumControl( sDriver, "InvoiceLineDetails_CurrencyLineInfo_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMCPBIL_CURRENCYLINEINFO_']/ancestor::form[1]/descendant::*[@id='LINE']");
				Function.AssertEqual(true,BLMCPBIL_InvoiceLineDetails_CurrencyLineInfo_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Close on InvoiceLineDetails_CurrencyLineInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetails_CurrencyLineInfoForm = new SeleniumControl( sDriver, "InvoiceLineDetails_CurrencyLineInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMCPBIL_CURRENCYLINEINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMCPBIL_InvoiceLineDetails_CurrencyLineInfoForm);
IWebElement formBttn = BLMCPBIL_InvoiceLineDetails_CurrencyLineInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on InvoiceLineDetails_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetails_CustomsInfoLink = new SeleniumControl( sDriver, "InvoiceLineDetails_CustomsInfoLink", "ID", "lnk_1004056_BLMCPBIL_CUSTPRODINVCLN_CHLD");
				Function.AssertEqual(true,BLMCPBIL_InvoiceLineDetails_CustomsInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Click on InvoiceLineDetails_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetails_CustomsInfoLink = new SeleniumControl( sDriver, "InvoiceLineDetails_CustomsInfoLink", "ID", "lnk_1004056_BLMCPBIL_CUSTPRODINVCLN_CHLD");
				Function.WaitControlDisplayed(BLMCPBIL_InvoiceLineDetails_CustomsInfoLink);
BLMCPBIL_InvoiceLineDetails_CustomsInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on InvoiceLineDetails_CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetails_CustomsInfoForm = new SeleniumControl( sDriver, "InvoiceLineDetails_CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMCPBIL_InvoiceLineDetails_CustomsInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on InvoiceLineDetails_CustomsInfo_ValueAddedTaxInformation_TaxCode...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetails_CustomsInfo_ValueAddedTaxInformation_TaxCode = new SeleniumControl( sDriver, "InvoiceLineDetails_CustomsInfo_ValueAddedTaxInformation_TaxCode", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,BLMCPBIL_InvoiceLineDetails_CustomsInfo_ValueAddedTaxInformation_TaxCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Close on InvoiceLineDetails_CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceLineDetails_CustomsInfoForm = new SeleniumControl( sDriver, "InvoiceLineDetails_CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMCPBIL_InvoiceLineDetails_CustomsInfoForm);
IWebElement formBttn = BLMCPBIL_InvoiceLineDetails_CustomsInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on StandardTextLink...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_StandardTextLink = new SeleniumControl( sDriver, "StandardTextLink", "ID", "lnk_1002579_BLMCPBIL_CUSTPRODINVCHDR");
				Function.AssertEqual(true,BLMCPBIL_StandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Click on StandardTextLink...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_StandardTextLink = new SeleniumControl( sDriver, "StandardTextLink", "ID", "lnk_1002579_BLMCPBIL_CUSTPRODINVCHDR");
				Function.WaitControlDisplayed(BLMCPBIL_StandardTextLink);
BLMCPBIL_StandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_StandardTextForm = new SeleniumControl( sDriver, "StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMCPBIL_CUSTPRODINVCTXT_STD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMCPBIL_StandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExist on StandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_StandardTextFormTable = new SeleniumControl( sDriver, "StandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMCPBIL_CUSTPRODINVCTXT_STD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMCPBIL_StandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on StandardText_Ok...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_StandardText_Ok = new SeleniumControl( sDriver, "StandardText_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMCPBIL_CUSTPRODINVCTXT_STD_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,BLMCPBIL_StandardText_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Close on StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_StandardTextForm = new SeleniumControl( sDriver, "StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMCPBIL_CUSTPRODINVCTXT_STD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMCPBIL_StandardTextForm);
IWebElement formBttn = BLMCPBIL_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003467_BLMCPBIL_CUSTPRODINVCHDR");
				Function.AssertEqual(true,BLMCPBIL_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003467_BLMCPBIL_CUSTPRODINVCHDR");
				Function.WaitControlDisplayed(BLMCPBIL_ExchangeRatesLink);
BLMCPBIL_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMCPBIL_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,BLMCPBIL_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMCPBIL_ExchangeRatesForm);
IWebElement formBttn = BLMCPBIL_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on InvoiceTotalsLink...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceTotalsLink = new SeleniumControl( sDriver, "InvoiceTotalsLink", "ID", "lnk_1002582_BLMCPBIL_CUSTPRODINVCHDR");
				Function.AssertEqual(true,BLMCPBIL_InvoiceTotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Click on InvoiceTotalsLink...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceTotalsLink = new SeleniumControl( sDriver, "InvoiceTotalsLink", "ID", "lnk_1002582_BLMCPBIL_CUSTPRODINVCHDR");
				Function.WaitControlDisplayed(BLMCPBIL_InvoiceTotalsLink);
BLMCPBIL_InvoiceTotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on InvoiceTotalsForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceTotalsForm = new SeleniumControl( sDriver, "InvoiceTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPBLINVT_INVCTOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMCPBIL_InvoiceTotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing VerifyExists on InvoiceTotals_ExchangeRates_BillingToFunctional...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceTotals_ExchangeRates_BillingToFunctional = new SeleniumControl( sDriver, "InvoiceTotals_ExchangeRates_BillingToFunctional", "xpath", "//div[translate(@id,'0123456789','')='pr__CPBLINVT_INVCTOTALS_']/ancestor::form[1]/descendant::*[@id='TRANS_TO_FUNC_ER']");
				Function.AssertEqual(true,BLMCPBIL_InvoiceTotals_ExchangeRates_BillingToFunctional.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Close on InvoiceTotalsForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_InvoiceTotalsForm = new SeleniumControl( sDriver, "InvoiceTotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPBLINVT_INVCTOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMCPBIL_InvoiceTotalsForm);
IWebElement formBttn = BLMCPBIL_InvoiceTotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMCPBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCPBIL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMCPBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMCPBIL_MainForm);
IWebElement formBttn = BLMCPBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

