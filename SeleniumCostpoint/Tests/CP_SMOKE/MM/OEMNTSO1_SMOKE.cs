 
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
    public class OEMNTSO1_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials", "xpath","//div[@class='busItem'][.='Materials']").Click();
new SeleniumControl(sDriver,"Sales Order Entry", "xpath","//div[@class='deptItem'][.='Sales Order Entry']").Click();
new SeleniumControl(sDriver,"Sales Orders", "xpath","//div[@class='navItem'][.='Sales Orders']").Click();
new SeleniumControl(sDriver,"Manage Sales Orders", "xpath","//div[@class='navItem'][.='Manage Sales Orders']").Click();


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
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEMNTSO1_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on Identification_SO...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_Identification_SO = new SeleniumControl( sDriver, "Identification_SO", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SO_ID']");
				Function.AssertEqual(true,OEMNTSO1_Identification_SO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_MainForm);
IWebElement formBttn = OEMNTSO1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEMNTSO1_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEMNTSO1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO1_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_MainForm);
IWebElement formBttn = OEMNTSO1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO1_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_MainFormTab);
IWebElement mTab = OEMNTSO1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on HeaderInfo_Client...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_HeaderInfo_Client = new SeleniumControl( sDriver, "HeaderInfo_Client", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ID']");
				Function.AssertEqual(true,OEMNTSO1_HeaderInfo_Client.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_MainFormTab);
IWebElement mTab = OEMNTSO1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Addresses").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on Addresses_BillTo...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_Addresses_BillTo = new SeleniumControl( sDriver, "Addresses_BillTo", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_TO_ADDR_DC']");
				Function.AssertEqual(true,OEMNTSO1_Addresses_BillTo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_MainFormTab);
IWebElement mTab = OEMNTSO1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Accounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on MainAccounts_SalesGroupAbbrev...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_MainAccounts_SalesGroupAbbrev = new SeleniumControl( sDriver, "MainAccounts_SalesGroupAbbrev", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SALES_ABBRV_CD']");
				Function.AssertEqual(true,OEMNTSO1_MainAccounts_SalesGroupAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_MainFormTab);
IWebElement mTab = OEMNTSO1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Order Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on OrderDetails_Terms...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_OrderDetails_Terms = new SeleniumControl( sDriver, "OrderDetails_Terms", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_TERMS_DC']");
				Function.AssertEqual(true,OEMNTSO1_OrderDetails_Terms.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_MainFormTab);
IWebElement mTab = OEMNTSO1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "iRAPT").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on OrderDetails_WAWF_PrimeContractorCAGECode...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_OrderDetails_WAWF_PrimeContractorCAGECode = new SeleniumControl( sDriver, "OrderDetails_WAWF_PrimeContractorCAGECode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CONTR_CAGE_ID']");
				Function.AssertEqual(true,OEMNTSO1_OrderDetails_WAWF_PrimeContractorCAGECode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_MainFormTab);
IWebElement mTab = OEMNTSO1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_MainFormTab);
IWebElement mTab = OEMNTSO1_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
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
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO1_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_ChildForm);
IWebElement formBttn = OEMNTSO1_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO1_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO1_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_Line...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_Line = new SeleniumControl( sDriver, "ChildForm_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='SO_LN_NO']");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_ChildFormTab);
IWebElement mTab = OEMNTSO1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_LineDetails_CLIN...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_LineDetails_CLIN = new SeleniumControl( sDriver, "ChildForm_LineDetails_CLIN", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='CLIN_ID']");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_LineDetails_CLIN.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_ChildFormTab);
IWebElement mTab = OEMNTSO1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Order Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_OrderDetails_Warehouse...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_OrderDetails_Warehouse = new SeleniumControl( sDriver, "ChildForm_OrderDetails_Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_OrderDetails_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_ChildFormTab);
IWebElement mTab = OEMNTSO1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Price Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_PriceDetails_TransCurrencyGrossUnitPrice...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_PriceDetails_TransCurrencyGrossUnitPrice = new SeleniumControl( sDriver, "ChildForm_PriceDetails_TransCurrencyGrossUnitPrice", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='TRN_GR_UNIT_PR_AMT']");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_PriceDetails_TransCurrencyGrossUnitPrice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_ChildFormTab);
IWebElement mTab = OEMNTSO1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shipping").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_Shipping_ShipID...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_Shipping_ShipID = new SeleniumControl( sDriver, "ChildForm_Shipping_ShipID", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='SHIP_ID']");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_Shipping_ShipID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_ChildFormTab);
IWebElement mTab = OEMNTSO1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Billing").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_Billing_SalesGroupAbbrev...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_Billing_SalesGroupAbbrev = new SeleniumControl( sDriver, "ChildForm_Billing_SalesGroupAbbrev", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='SALES_ABBRV_CD']");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_Billing_SalesGroupAbbrev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_ChildFormTab);
IWebElement mTab = OEMNTSO1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_OtherInfo_NumberOfUsers...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_OtherInfo_NumberOfUsers = new SeleniumControl( sDriver, "ChildForm_OtherInfo_NumberOfUsers", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='USERS_NO']");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_OtherInfo_NumberOfUsers.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMNTSO1_ChildFormTab);
IWebElement mTab = OEMNTSO1_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "SO Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Header Standard Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on HeaderStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_HeaderStandardTextLink = new SeleniumControl( sDriver, "HeaderStandardTextLink", "ID", "lnk_1004586_OEMENTSO_SOHDR_HDR");
				Function.AssertEqual(true,OEMNTSO1_HeaderStandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on HeaderStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_HeaderStandardTextLink = new SeleniumControl( sDriver, "HeaderStandardTextLink", "ID", "lnk_1004586_OEMENTSO_SOHDR_HDR");
				Function.WaitControlDisplayed(OEMNTSO1_HeaderStandardTextLink);
OEMNTSO1_HeaderStandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on HeaderStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_HeaderStandardTextForm = new SeleniumControl( sDriver, "HeaderStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOTEXT_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_HeaderStandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExist on HeaderStandardTextTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_HeaderStandardTextTable = new SeleniumControl( sDriver, "HeaderStandardTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOTEXT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO1_HeaderStandardTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on HeaderStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_HeaderStandardTextForm = new SeleniumControl( sDriver, "HeaderStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_HeaderStandardTextForm);
IWebElement formBttn = OEMNTSO1_HeaderStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Totals");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on TotalsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_TotalsLink = new SeleniumControl( sDriver, "TotalsLink", "ID", "lnk_1004588_OEMENTSO_SOHDR_HDR");
				Function.AssertEqual(true,OEMNTSO1_TotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on TotalsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_TotalsLink = new SeleniumControl( sDriver, "TotalsLink", "ID", "lnk_1004588_OEMENTSO_SOHDR_HDR");
				Function.WaitControlDisplayed(OEMNTSO1_TotalsLink);
OEMNTSO1_TotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOTO_SQ_TOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_TotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on Totals_Totals_Currency...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_Totals_Totals_Currency = new SeleniumControl( sDriver, "Totals_Totals_Currency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOTO_SQ_TOTALS_']/ancestor::form[1]/descendant::*[@id='TRANS_CURR_CODE']");
				Function.AssertEqual(true,OEMNTSO1_Totals_Totals_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on TotalsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_TotalsForm = new SeleniumControl( sDriver, "TotalsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOTO_SQ_TOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_TotalsForm);
IWebElement formBttn = OEMNTSO1_TotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1004589_OEMENTSO_SOHDR_HDR");
				Function.AssertEqual(true,OEMNTSO1_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1004589_OEMENTSO_SOHDR_HDR");
				Function.WaitControlDisplayed(OEMNTSO1_ExchangeRatesLink);
OEMNTSO1_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,OEMNTSO1_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_ExchangeRatesForm);
IWebElement formBttn = OEMNTSO1_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("User - Defined Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_15735_OEMENTSO_SOHDR_HDR");
				Function.AssertEqual(true,OEMNTSO1_UserDefinedInfoLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on UserDefinedInfoLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_UserDefinedInfoLink = new SeleniumControl( sDriver, "UserDefinedInfoLink", "ID", "lnk_15735_OEMENTSO_SOHDR_HDR");
				Function.WaitControlDisplayed(OEMNTSO1_UserDefinedInfoLink);
OEMNTSO1_UserDefinedInfoLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_UserDefinedInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExist on UserDefinedInfoTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_UserDefinedInfoTable = new SeleniumControl( sDriver, "UserDefinedInfoTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO1_UserDefinedInfoTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing ClickButton on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_UserDefinedInfoForm);
IWebElement formBttn = OEMNTSO1_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO1_UserDefinedInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO1_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on UserDefinedInfo_Labels...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_UserDefinedInfo_Labels = new SeleniumControl( sDriver, "UserDefinedInfo_Labels", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]/descendant::*[@id='UDEF_LBL']");
				Function.AssertEqual(true,OEMNTSO1_UserDefinedInfo_Labels.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on UserDefinedInfoForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_UserDefinedInfoForm = new SeleniumControl( sDriver, "UserDefinedInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MMUDINF_USERDEFINEDINFO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_UserDefinedInfoForm);
IWebElement formBttn = OEMNTSO1_UserDefinedInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Header Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007374_OEMENTSO_SOHDR_HDR");
				Function.AssertEqual(true,OEMNTSO1_HeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007374_OEMENTSO_SOHDR_HDR");
				Function.WaitControlDisplayed(OEMNTSO1_HeaderDocumentsLink);
OEMNTSO1_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExist on HeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_HeaderDocumentsTable = new SeleniumControl( sDriver, "HeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO1_HeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing ClickButton on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_HeaderDocumentsForm);
IWebElement formBttn = OEMNTSO1_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO1_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO1_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_HeaderDocuments_Document = new SeleniumControl( sDriver, "HeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,OEMNTSO1_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_HeaderDocumentsForm);
IWebElement formBttn = OEMNTSO1_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Subcontract");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_SubContractLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_SubContractLink = new SeleniumControl( sDriver, "ChildForm_SubContractLink", "ID", "lnk_1004595_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_SubContractLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on ChildForm_SubContractLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_SubContractLink = new SeleniumControl( sDriver, "ChildForm_SubContractLink", "ID", "lnk_1004595_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO1_ChildForm_SubContractLink);
OEMNTSO1_ChildForm_SubContractLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on SubcontractForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_SubcontractForm = new SeleniumControl( sDriver, "SubcontractForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNSUBCTCST_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_SubcontractForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExist on SubcontractTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_SubcontractTable = new SeleniumControl( sDriver, "SubcontractTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNSUBCTCST_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO1_SubcontractTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				Function.ScrollUp();


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ScrollUp]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing ClickButton on SubcontractForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_SubcontractForm = new SeleniumControl( sDriver, "SubcontractForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNSUBCTCST_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_SubcontractForm);
IWebElement formBttn = OEMNTSO1_SubcontractForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO1_SubcontractForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO1_SubcontractForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on Subcontract_Line...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_Subcontract_Line = new SeleniumControl( sDriver, "Subcontract_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNSUBCTCST_DTL_']/ancestor::form[1]/descendant::*[@id='SUBCT_CST_LN_NO']");
				Function.AssertEqual(true,OEMNTSO1_Subcontract_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on SubcontractForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_SubcontractForm = new SeleniumControl( sDriver, "SubcontractForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNSUBCTCST_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_SubcontractForm);
IWebElement formBttn = OEMNTSO1_SubcontractForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Accounts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_AccountsLink = new SeleniumControl( sDriver, "ChildForm_AccountsLink", "ID", "lnk_1004606_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_AccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on ChildForm_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_AccountsLink = new SeleniumControl( sDriver, "ChildForm_AccountsLink", "ID", "lnk_1004606_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO1_ChildForm_AccountsLink);
OEMNTSO1_ChildForm_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SALESGROUPACCTS_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_AccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExist on AccountsTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_AccountsTable = new SeleniumControl( sDriver, "AccountsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SALESGROUPACCTS_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO1_AccountsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing ClickButton on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SALESGROUPACCTS_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_AccountsForm);
IWebElement formBttn = OEMNTSO1_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO1_AccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO1_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on Accounts_Project...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_Accounts_Project = new SeleniumControl( sDriver, "Accounts_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SALESGROUPACCTS_CHLD_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,OEMNTSO1_Accounts_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SALESGROUPACCTS_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_AccountsForm);
IWebElement formBttn = OEMNTSO1_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Components");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_ComponentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_ComponentsLink = new SeleniumControl( sDriver, "ChildForm_ComponentsLink", "ID", "lnk_1004592_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_ComponentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on ChildForm_ComponentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_ComponentsLink = new SeleniumControl( sDriver, "ChildForm_ComponentsLink", "ID", "lnk_1004592_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO1_ChildForm_ComponentsLink);
OEMNTSO1_ChildForm_ComponentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ComponentsForm = new SeleniumControl( sDriver, "ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCOMP_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_ComponentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExist on ComponentsTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ComponentsTable = new SeleniumControl( sDriver, "ComponentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCOMP_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO1_ComponentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing ClickButton on ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ComponentsForm = new SeleniumControl( sDriver, "ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCOMP_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_ComponentsForm);
IWebElement formBttn = OEMNTSO1_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO1_ComponentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO1_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on Components_Line...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_Components_Line = new SeleniumControl( sDriver, "Components_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCOMP_DTL_']/ancestor::form[1]/descendant::*[@id='SO_LN_COMP_NO']");
				Function.AssertEqual(true,OEMNTSO1_Components_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on ComponentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ComponentsForm = new SeleniumControl( sDriver, "ComponentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCOMP_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_ComponentsForm);
IWebElement formBttn = OEMNTSO1_ComponentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Charges");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1004593_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_LineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1004593_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO1_ChildForm_LineChargesLink);
OEMNTSO1_ChildForm_LineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCHG_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_LineChargesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExist on LineChargesTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineChargesTable = new SeleniumControl( sDriver, "LineChargesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCHG_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO1_LineChargesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing ClickButton on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCHG_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_LineChargesForm);
IWebElement formBttn = OEMNTSO1_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO1_LineChargesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO1_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on LineCharges_ChargeType...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineCharges_ChargeType = new SeleniumControl( sDriver, "LineCharges_ChargeType", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCHG_DTL_']/ancestor::form[1]/descendant::*[@id='LN_CHG_TYPE']");
				Function.AssertEqual(true,OEMNTSO1_LineCharges_ChargeType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNCHG_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_LineChargesForm);
IWebElement formBttn = OEMNTSO1_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Standard Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_LineStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_LineStandardTextLink = new SeleniumControl( sDriver, "ChildForm_LineStandardTextLink", "ID", "lnk_1004594_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_LineStandardTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on ChildForm_LineStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_LineStandardTextLink = new SeleniumControl( sDriver, "ChildForm_LineStandardTextLink", "ID", "lnk_1004594_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO1_ChildForm_LineStandardTextLink);
OEMNTSO1_ChildForm_LineStandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineStandardTextForm = new SeleniumControl( sDriver, "LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNTEXT_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_LineStandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExist on LineStandardTextTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineStandardTextTable = new SeleniumControl( sDriver, "LineStandardTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNTEXT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO1_LineStandardTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing ClickButton on LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineStandardTextForm = new SeleniumControl( sDriver, "LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_LineStandardTextForm);
IWebElement formBttn = OEMNTSO1_LineStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO1_LineStandardTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO1_LineStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on LineStandardText_Sequence...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineStandardText_Sequence = new SeleniumControl( sDriver, "LineStandardText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNTEXT_DTL_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,OEMNTSO1_LineStandardText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on LineStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineStandardTextForm = new SeleniumControl( sDriver, "LineStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOLNTEXT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_LineStandardTextForm);
IWebElement formBttn = OEMNTSO1_LineStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Currency Line Information");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_CurrencyLineInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_CurrencyLineInformationLink = new SeleniumControl( sDriver, "ChildForm_CurrencyLineInformationLink", "ID", "lnk_1004596_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_CurrencyLineInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on ChildForm_CurrencyLineInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_CurrencyLineInformationLink = new SeleniumControl( sDriver, "ChildForm_CurrencyLineInformationLink", "ID", "lnk_1004596_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO1_ChildForm_CurrencyLineInformationLink);
OEMNTSO1_ChildForm_CurrencyLineInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on CurrencyLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_CurrencyLineInformationForm = new SeleniumControl( sDriver, "CurrencyLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_CurrencyLineInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on CurrencyLineInformation_LineAmounts_FunctionalCurrency...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_CurrencyLineInformation_LineAmounts_FunctionalCurrency = new SeleniumControl( sDriver, "CurrencyLineInformation_LineAmounts_FunctionalCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]/descendant::*[@id='FUNC_CURR_CODE']");
				Function.AssertEqual(true,OEMNTSO1_CurrencyLineInformation_LineAmounts_FunctionalCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on CurrencyLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_CurrencyLineInformationForm = new SeleniumControl( sDriver, "CurrencyLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPOESOLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_CurrencyLineInformationForm);
IWebElement formBttn = OEMNTSO1_CurrencyLineInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Customs Information");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_CustomsInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_CustomsInformationLink = new SeleniumControl( sDriver, "ChildForm_CustomsInformationLink", "ID", "lnk_1007440_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_CustomsInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on ChildForm_CustomsInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_CustomsInformationLink = new SeleniumControl( sDriver, "ChildForm_CustomsInformationLink", "ID", "lnk_1007440_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO1_ChildForm_CustomsInformationLink);
OEMNTSO1_ChildForm_CustomsInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on CustomsInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_CustomsInformationForm = new SeleniumControl( sDriver, "CustomsInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOHDRAPPRVL_CUSTLNDTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_CustomsInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on CustomsInformation_ValueAddedTaxInfo_TaxID...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_CustomsInformation_ValueAddedTaxInfo_TaxID = new SeleniumControl( sDriver, "CustomsInformation_ValueAddedTaxInfo_TaxID", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOHDRAPPRVL_CUSTLNDTL_']/ancestor::form[1]/descendant::*[@id='VAT_TAX_ID']");
				Function.AssertEqual(true,OEMNTSO1_CustomsInformation_ValueAddedTaxInfo_TaxID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on CustomsInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_CustomsInformationForm = new SeleniumControl( sDriver, "CustomsInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_SOHDRAPPRVL_CUSTLNDTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_CustomsInformationForm);
IWebElement formBttn = OEMNTSO1_CustomsInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Documents");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007697_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on ChildForm_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_LineDocumentsLink = new SeleniumControl( sDriver, "ChildForm_LineDocumentsLink", "ID", "lnk_1007697_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO1_ChildForm_LineDocumentsLink);
OEMNTSO1_ChildForm_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExist on LineDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineDocumentsTable = new SeleniumControl( sDriver, "LineDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO1_LineDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing ClickButton on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_LineDocumentsForm);
IWebElement formBttn = OEMNTSO1_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO1_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO1_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineDocuments_Document = new SeleniumControl( sDriver, "LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,OEMNTSO1_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEM_SOLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_LineDocumentsForm);
IWebElement formBttn = OEMNTSO1_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Consume Forecast");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ChildForm_ConsumeForecastLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_ConsumeForecastLink = new SeleniumControl( sDriver, "ChildForm_ConsumeForecastLink", "ID", "lnk_1007750_OEMENTSO_SOLN_DTL");
				Function.AssertEqual(true,OEMNTSO1_ChildForm_ConsumeForecastLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Click on ChildForm_ConsumeForecastLink...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ChildForm_ConsumeForecastLink = new SeleniumControl( sDriver, "ChildForm_ConsumeForecastLink", "ID", "lnk_1007750_OEMENTSO_SOLN_DTL");
				Function.WaitControlDisplayed(OEMNTSO1_ChildForm_ConsumeForecastLink);
OEMNTSO1_ChildForm_ConsumeForecastLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ConsumeForecastForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ConsumeForecastForm = new SeleniumControl( sDriver, "ConsumeForecastForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_MPSFORECASTSOLN_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMNTSO1_ConsumeForecastForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on ConsumeForecast_Part...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ConsumeForecast_Part = new SeleniumControl( sDriver, "ConsumeForecast_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_MPSFORECASTSOLN_HDR_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,OEMNTSO1_ConsumeForecast_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExist on ForecastTable...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ForecastTable = new SeleniumControl( sDriver, "ForecastTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_MPSFORECASTSOLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMNTSO1_ForecastTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing ClickButton on ForecastForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ForecastForm = new SeleniumControl( sDriver, "ForecastForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_MPSFORECASTSOLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_ForecastForm);
IWebElement formBttn = OEMNTSO1_ForecastForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMNTSO1_ForecastForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMNTSO1_ForecastForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing VerifyExists on Forecast_ForecastPart...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_Forecast_ForecastPart = new SeleniumControl( sDriver, "Forecast_ForecastPart", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_MPSFORECASTSOLN_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,OEMNTSO1_Forecast_ForecastPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on ConsumeForecastForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_ConsumeForecastForm = new SeleniumControl( sDriver, "ConsumeForecastForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMENTSO_MPSFORECASTSOLN_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_ConsumeForecastForm);
IWebElement formBttn = OEMNTSO1_ConsumeForecastForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMNTSO1";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMNTSO1] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMNTSO1_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMNTSO1_MainForm);
IWebElement formBttn = OEMNTSO1_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogWithMessage("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogWithMessage]" , ex.Message));
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

