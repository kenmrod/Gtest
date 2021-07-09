 
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
    public class BLMMPCB_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Milestone Percent Complete Bills Processing", "xpath","//div[@class='navItem'][.='Milestone Percent Complete Bills Processing']").Click();
new SeleniumControl(sDriver,"Manage Milestone Percent Complete Bills", "xpath","//div[@class='navItem'][.='Manage Milestone Percent Complete Bills']").Click();


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
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMMPCB_MainForm);
IWebElement formBttn = BLMMPCB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BLMMPCB_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BLMMPCB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMMPCB_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMMPCB_MainForm);
IWebElement formBttn = BLMMPCB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMMPCB_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMMPCB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMMPCB_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on Identification_Project...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_Identification_Project = new SeleniumControl( sDriver, "Identification_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BLMMPCB_Identification_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMMPCB_MainTab);
IWebElement mTab = BLMMPCB_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Bill Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on BillDetails_Customer...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_BillDetails_Customer = new SeleniumControl( sDriver, "BillDetails_Customer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,BLMMPCB_BillDetails_Customer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMMPCB_MainTab);
IWebElement mTab = BLMMPCB_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Addresses").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on Addresses_BillAddress_Address...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_Addresses_BillAddress_Address = new SeleniumControl( sDriver, "Addresses_BillAddress_Address", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ADDR_DC']");
				Function.AssertEqual(true,BLMMPCB_Addresses_BillAddress_Address.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMMPCB_MainTab);
IWebElement mTab = BLMMPCB_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Misc Charges").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on MiscCharges_OtherCharges_Code...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_MiscCharges_OtherCharges_Code = new SeleniumControl( sDriver, "MiscCharges_OtherCharges_Code", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='OTH_CHG_CD1']");
				Function.AssertEqual(true,BLMMPCB_MiscCharges_OtherCharges_Code.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMMPCB_MainTab);
IWebElement mTab = BLMMPCB_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Report Options").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on ReportOptions_Columns_ScheduledValue...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_ReportOptions_Columns_ScheduledValue = new SeleniumControl( sDriver, "ReportOptions_Columns_ScheduledValue", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PRT_CONTR_VAL_FL']");
				Function.AssertEqual(true,BLMMPCB_ReportOptions_Columns_ScheduledValue.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMMPCB_MainTab);
IWebElement mTab = BLMMPCB_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Summary Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on SummaryInformation_InvoiceTotals_Billing_TotalContractValueCeiling...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_SummaryInformation_InvoiceTotals_Billing_TotalContractValueCeiling = new SeleniumControl( sDriver, "SummaryInformation_InvoiceTotals_Billing_TotalContractValueCeiling", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TRN_CEILING_AMT']");
				Function.AssertEqual(true,BLMMPCB_SummaryInformation_InvoiceTotals_Billing_TotalContractValueCeiling.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(BLMMPCB_MainTab);
IWebElement mTab = BLMMPCB_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Statement Of Work").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on StatementOfWork_StatementOfWork...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_StatementOfWork_StatementOfWork = new SeleniumControl( sDriver, "StatementOfWork_StatementOfWork", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='STATEMENT_WRK_DESC']");
				Function.AssertEqual(true,BLMMPCB_StatementOfWork_StatementOfWork.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINE DETAILS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExist on LineDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_LineDetailsFormTable = new SeleniumControl( sDriver, "LineDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMPCB_MILESTONEINVCLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMMPCB_LineDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing ClickButton on LineDetailsForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_LineDetailsForm = new SeleniumControl( sDriver, "LineDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMPCB_MILESTONEINVCLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMMPCB_LineDetailsForm);
IWebElement formBttn = BLMMPCB_LineDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMMPCB_LineDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMMPCB_LineDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on LineDetailsForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_LineDetailsForm = new SeleniumControl( sDriver, "LineDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMPCB_MILESTONEINVCLN_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMMPCB_LineDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on LineDetails_Line...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_LineDetails_Line = new SeleniumControl( sDriver, "LineDetails_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMPCB_MILESTONEINVCLN_']/ancestor::form[1]/descendant::*[@id='MILESTONE_LN_NO']");
				Function.AssertEqual(true,BLMMPCB_LineDetails_Line.Exists());

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
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on LineDetails_CurrencyLineInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_LineDetails_CurrencyLineInfoLink = new SeleniumControl( sDriver, "LineDetails_CurrencyLineInfoLink", "ID", "lnk_1003099_BLMMPCB_MILESTONEINVCLN");
				Function.AssertEqual(true,BLMMPCB_LineDetails_CurrencyLineInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Click on LineDetails_CurrencyLineInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_LineDetails_CurrencyLineInfoLink = new SeleniumControl( sDriver, "LineDetails_CurrencyLineInfoLink", "ID", "lnk_1003099_BLMMPCB_MILESTONEINVCLN");
				Function.WaitControlDisplayed(BLMMPCB_LineDetails_CurrencyLineInfoLink);
BLMMPCB_LineDetails_CurrencyLineInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on LineDetails_CurrencyLineInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_LineDetails_CurrencyLineInfoForm = new SeleniumControl( sDriver, "LineDetails_CurrencyLineInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMPCB_CURRLINEINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMMPCB_LineDetails_CurrencyLineInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on LineDetails_CurrencyLineInfo_ExchangeRates_BillingToFunctional...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_LineDetails_CurrencyLineInfo_ExchangeRates_BillingToFunctional = new SeleniumControl( sDriver, "LineDetails_CurrencyLineInfo_ExchangeRates_BillingToFunctional", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMPCB_CURRLINEINFO_']/ancestor::form[1]/descendant::*[@id='DISPLAY_TRNTOFUNC_ER']");
				Function.AssertEqual(true,BLMMPCB_LineDetails_CurrencyLineInfo_ExchangeRates_BillingToFunctional.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Close on LineDetails_CurrencyLineInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_LineDetails_CurrencyLineInfoForm = new SeleniumControl( sDriver, "LineDetails_CurrencyLineInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMPCB_CURRLINEINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMMPCB_LineDetails_CurrencyLineInfoForm);
IWebElement formBttn = BLMMPCB_LineDetails_CurrencyLineInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003383_BLMMPCB_MILESTONEINVCHDR");
				Function.AssertEqual(true,BLMMPCB_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003383_BLMMPCB_MILESTONEINVCHDR");
				Function.WaitControlDisplayed(BLMMPCB_ExchangeRatesLink);
BLMMPCB_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMMPCB_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,BLMMPCB_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMMPCB_ExchangeRatesForm);
IWebElement formBttn = BLMMPCB_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on StandardTextLink...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_StandardTextLink = new SeleniumControl( sDriver, "StandardTextLink", "ID", "lnk_1003061_BLMMPCB_MILESTONEINVCHDR");
				Function.AssertEqual(true,BLMMPCB_StandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Click on StandardTextLink...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_StandardTextLink = new SeleniumControl( sDriver, "StandardTextLink", "ID", "lnk_1003061_BLMMPCB_MILESTONEINVCHDR");
				Function.WaitControlDisplayed(BLMMPCB_StandardTextLink);
BLMMPCB_StandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_StandardTextForm = new SeleniumControl( sDriver, "StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMPCB_MILESTONEINVCTXT_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMMPCB_StandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExist on StandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_StandardTextFormTable = new SeleniumControl( sDriver, "StandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMPCB_MILESTONEINVCTXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMMPCB_StandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on StandardText_Ok...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_StandardText_Ok = new SeleniumControl( sDriver, "StandardText_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMPCB_MILESTONEINVCTXT_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,BLMMPCB_StandardText_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Close on StandardTextForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_StandardTextForm = new SeleniumControl( sDriver, "StandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMMPCB_MILESTONEINVCTXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMMPCB_StandardTextForm);
IWebElement formBttn = BLMMPCB_StandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_CustomsInfoLink = new SeleniumControl( sDriver, "CustomsInfoLink", "ID", "lnk_1003933_BLMMPCB_MILESTONEINVCHDR");
				Function.AssertEqual(true,BLMMPCB_CustomsInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Click on CustomsInfoLink...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_CustomsInfoLink = new SeleniumControl( sDriver, "CustomsInfoLink", "ID", "lnk_1003933_BLMMPCB_MILESTONEINVCHDR");
				Function.WaitControlDisplayed(BLMMPCB_CustomsInfoLink);
BLMMPCB_CustomsInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_CustomsInfoForm = new SeleniumControl( sDriver, "CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,BLMMPCB_CustomsInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing VerifyExists on CustomsInfo_ValueAddedTaxInformation_TaxCode...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_CustomsInfo_ValueAddedTaxInformation_TaxCode = new SeleniumControl( sDriver, "CustomsInfo_ValueAddedTaxInformation_TaxCode", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,BLMMPCB_CustomsInfo_ValueAddedTaxInformation_TaxCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Close on CustomsInfoForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_CustomsInfoForm = new SeleniumControl( sDriver, "CustomsInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPVATSCR_CUSTOMSVATHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMMPCB_CustomsInfoForm);
IWebElement formBttn = BLMMPCB_CustomsInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMMPCB_MainForm);
IWebElement formBttn = BLMMPCB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).Count <= 0 ? BLMMPCB_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Delete')]")).FirstOrDefault() :
BLMMPCB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).FirstOrDefault();
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
				Function.CurrentComponent = "BLMMPCB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMMPCB] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMMPCB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMMPCB_MainForm);
IWebElement formBttn = BLMMPCB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

