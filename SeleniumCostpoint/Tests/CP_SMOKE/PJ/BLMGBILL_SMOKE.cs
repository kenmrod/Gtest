 
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
    public class BLMGBILL_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Standard Bills Processing", "xpath","//div[@class='navItem'][.='Standard Bills Processing']").Click();
new SeleniumControl(sDriver,"Manage Standard Bills", "xpath","//div[@class='navItem'][.='Manage Standard Bills']").Click();


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
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMGBILL_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMGBILL_MainForm);
IWebElement formBttn = BLMGBILL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMGBILL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMGBILL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMGBILL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BLMGBILL_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMGBILL_MainTab);
IWebElement mTab = BLMGBILL_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Standard Billing Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on StandardBillingInfo_InvoiceInfo_InvoiceNumber...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_StandardBillingInfo_InvoiceInfo_InvoiceNumber = new SeleniumControl( sDriver, "StandardBillingInfo_InvoiceInfo_InvoiceNumber", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVC_ID_DISP']");
				Function.AssertEqual(true,BLMGBILL_StandardBillingInfo_InvoiceInfo_InvoiceNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMGBILL_MainTab);
IWebElement mTab = BLMGBILL_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on Header_BillDetails_UsedFor...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_Header_BillDetails_UsedFor = new SeleniumControl( sDriver, "Header_BillDetails_UsedFor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='USED_FOR']");
				Function.AssertEqual(true,BLMGBILL_Header_BillDetails_UsedFor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMGBILL_MainTab);
IWebElement mTab = BLMGBILL_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Totals").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on Totals_OtherCharges_Code1...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_Totals_OtherCharges_Code1 = new SeleniumControl( sDriver, "Totals_OtherCharges_Code1", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='OTH_CHG_CD1']");
				Function.AssertEqual(true,BLMGBILL_Totals_OtherCharges_Code1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMGBILL_MainTab);
IWebElement mTab = BLMGBILL_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Addresses").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on Addresses_BillTo_Address...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_Addresses_BillTo_Address = new SeleniumControl( sDriver, "Addresses_BillTo_Address", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ADDR_DC']");
				Function.AssertEqual(true,BLMGBILL_Addresses_BillTo_Address.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1007102_BLMGBILL_BILLEDITINVCHDR");
				Function.AssertEqual(true,BLMGBILL_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1007102_BLMGBILL_BILLEDITINVCHDR");
				Function.WaitControlDisplayed(BLMGBILL_ExchangeRatesLink);
BLMGBILL_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_BLREXR_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMGBILL_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on ExchangeRates_BillingCurrency...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_ExchangeRates_BillingCurrency = new SeleniumControl( sDriver, "ExchangeRates_BillingCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_BLREXR_']/ancestor::form[1]/descendant::*[@id='PAY_CRNCY_CD']");
				Function.AssertEqual(true,BLMGBILL_ExchangeRates_BillingCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_BLREXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMGBILL_ExchangeRatesForm);
IWebElement formBttn = BLMGBILL_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMGBILL_BILLEDITDETL_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMGBILL_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMGBILL_BILLEDITDETL_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMGBILL_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on ChildForm_DetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_ChildForm_DetailLink = new SeleniumControl( sDriver, "ChildForm_DetailLink", "ID", "lnk_1002836_BLMGBILL_BILLEDITDETL_CHILD");
				Function.AssertEqual(true,BLMGBILL_ChildForm_DetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing Click on ChildForm_DetailLink...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_ChildForm_DetailLink = new SeleniumControl( sDriver, "ChildForm_DetailLink", "ID", "lnk_1002836_BLMGBILL_BILLEDITDETL_CHILD");
				Function.WaitControlDisplayed(BLMGBILL_ChildForm_DetailLink);
BLMGBILL_ChildForm_DetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExist on DetailFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_DetailFormTable = new SeleniumControl( sDriver, "DetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMGBILL_BILLEDITDETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMGBILL_DetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on Detail_Recalculate...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_Detail_Recalculate = new SeleniumControl( sDriver, "Detail_Recalculate", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMGBILL_BILLEDITDETL_']/ancestor::form[1]/descendant::*[contains(@id,'ACTION_BUTTON') and contains(@style,'visible')]");
				Function.AssertEqual(true,BLMGBILL_Detail_Recalculate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Customs Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on Detail_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_Detail_CustomsInfoLink = new SeleniumControl( sDriver, "Detail_CustomsInfoLink", "ID", "lnk_1003931_BLMGBILL_BILLEDITDETL");
				Function.AssertEqual(true,BLMGBILL_Detail_CustomsInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing Click on Detail_CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_Detail_CustomsInfoLink = new SeleniumControl( sDriver, "Detail_CustomsInfoLink", "ID", "lnk_1003931_BLMGBILL_BILLEDITDETL");
				Function.WaitControlDisplayed(BLMGBILL_Detail_CustomsInfoLink);
BLMGBILL_Detail_CustomsInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_CustomsInfoForm = new SeleniumControl( sDriver, "CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMGBILL_CustomsInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing VerifyExists on CustomsInfo_ValueAddedTaxInformation_TaxCode...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_CustomsInfo_ValueAddedTaxInformation_TaxCode = new SeleniumControl( sDriver, "CustomsInfo_ValueAddedTaxInformation_TaxCode", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,BLMGBILL_CustomsInfo_ValueAddedTaxInformation_TaxCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing Close on CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_CustomsInfoForm = new SeleniumControl( sDriver, "CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMGBILL_CustomsInfoForm);
IWebElement formBttn = BLMGBILL_CustomsInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMGBILL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMGBILL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMGBILL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMGBILL_MainForm);
IWebElement formBttn = BLMGBILL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

