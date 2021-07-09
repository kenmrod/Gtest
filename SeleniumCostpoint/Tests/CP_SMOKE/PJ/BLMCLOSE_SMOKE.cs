 
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
    public class BLMCLOSE_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Billing History", "xpath","//div[@class='navItem'][.='Billing History']").Click();
new SeleniumControl(sDriver,"Manage Closed Billing Detail", "xpath","//div[@class='navItem'][.='Manage Closed Billing Detail']").Click();


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
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMCLOSE_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing VerifyExists on Identification_InvoiceProject...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_Identification_InvoiceProject = new SeleniumControl( sDriver, "Identification_InvoiceProject", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='INVC_PROJ_ID']");
				Function.AssertEqual(true,BLMCLOSE_Identification_InvoiceProject.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMCLOSE_MainTab);
IWebElement mTab = BLMCLOSE_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Billing Detail").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing VerifyExists on BillingDetail_TransactionType...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_BillingDetail_TransactionType = new SeleniumControl( sDriver, "BillingDetail_TransactionType", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_TRN_TYPE']");
				Function.AssertEqual(true,BLMCLOSE_BillingDetail_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMCLOSE_MainTab);
IWebElement mTab = BLMCLOSE_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Labor").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing VerifyExists on Labor_IDType...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_Labor_IDType = new SeleniumControl( sDriver, "Labor_IDType", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_ID_TYPE']");
				Function.AssertEqual(true,BLMCLOSE_Labor_IDType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMCLOSE_MainTab);
IWebElement mTab = BLMCLOSE_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Units").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing VerifyExists on Units_CLIN...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_Units_CLIN = new SeleniumControl( sDriver, "Units_CLIN", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CLIN_ID']");
				Function.AssertEqual(true,BLMCLOSE_Units_CLIN.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMCLOSE_MainTab);
IWebElement mTab = BLMCLOSE_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Sales Tax").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing VerifyExists on SalesTax_SalesTax...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_SalesTax_SalesTax = new SeleniumControl( sDriver, "SalesTax_SalesTax", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SALES_TAX_CD']");
				Function.AssertEqual(true,BLMCLOSE_SalesTax_SalesTax.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMCLOSE_MainTab);
IWebElement mTab = BLMCLOSE_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing VerifyExists on Other_NumberEntry_None...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_Other_NumberEntry_None = new SeleniumControl( sDriver, "Other_NumberEntry_None", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DFRADIO' and @value='0']");
				Function.AssertEqual(true,BLMCLOSE_Other_NumberEntry_None.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMCLOSE_MainForm);
IWebElement formBttn = BLMCLOSE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BLMCLOSE_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BLMCLOSE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMCLOSE_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EXCHANGERATES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_16816_BLMCLOSE_BILLINGDETLHIST_HDR");
				Function.AssertEqual(true,BLMCLOSE_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_16816_BLMCLOSE_BILLINGDETLHIST_HDR");
				Function.WaitControlDisplayed(BLMCLOSE_ExchangeRatesLink);
BLMCLOSE_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMCLOSE_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,BLMCLOSE_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMCLOSE_ExchangeRatesForm);
IWebElement formBttn = BLMCLOSE_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMCLOSE";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMCLOSE] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMCLOSE_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMCLOSE_MainForm);
IWebElement formBttn = BLMCLOSE_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

