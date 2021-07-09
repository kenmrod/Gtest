 
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
    public class POMMAIN_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Purchasing", "xpath","//div[@class='deptItem'][.='Purchasing']").Click();
new SeleniumControl(sDriver,"Purchase Orders", "xpath","//div[@class='navItem'][.='Purchase Orders']").Click();
new SeleniumControl(sDriver,"Manage Purchase Orders", "xpath","//div[@class='navItem'][.='Manage Purchase Orders']").Click();


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
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing ClickButtonIfExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainForm = new SeleniumControl( sDriver, "MainForm", "XPATH", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMMAIN_MainForm);
IWebElement formBttn = POMMAIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMMAIN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMMAIN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault();
if (formBttn!=null && formBttn.Displayed)
{ new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click();
this.ScriptLogger.WriteLine("Button [Form] found and clicked.", Logger.MessageType.INF);
}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButtonIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainForm = new SeleniumControl( sDriver, "MainForm", "XPATH", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,POMMAIN_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on PurchaseOrderID...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_PurchaseOrderID = new SeleniumControl( sDriver, "PurchaseOrderID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PO_ID']");
				Function.AssertEqual(true,POMMAIN_PurchaseOrderID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainForm = new SeleniumControl( sDriver, "MainForm", "XPATH", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMMAIN_MainForm);
IWebElement formBttn = POMMAIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? POMMAIN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
POMMAIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMMAIN_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainForm = new SeleniumControl( sDriver, "MainForm", "XPATH", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMMAIN_MainForm);
IWebElement formBttn = POMMAIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMMAIN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMMAIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_MainFormTab);
IWebElement mTab = POMMAIN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on Header_Buyer...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_Header_Buyer = new SeleniumControl( sDriver, "Header_Buyer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BUYER_ID']");
				Function.AssertEqual(true,POMMAIN_Header_Buyer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_MainFormTab);
IWebElement mTab = POMMAIN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on OtherInformation_VendorTerms...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_OtherInformation_VendorTerms = new SeleniumControl( sDriver, "OtherInformation_VendorTerms", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TERMS_DC']");
				Function.AssertEqual(true,POMMAIN_OtherInformation_VendorTerms.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_MainFormTab);
IWebElement mTab = POMMAIN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Accounting Defaults").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on AccountingDefaults_Project...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_AccountingDefaults_Project = new SeleniumControl( sDriver, "AccountingDefaults_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,POMMAIN_AccountingDefaults_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_MainFormTab);
IWebElement mTab = POMMAIN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Defaults").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on OtherDefaults_ShippingInformation_ShippingID...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_OtherDefaults_ShippingInformation_ShippingID = new SeleniumControl( sDriver, "OtherDefaults_ShippingInformation_ShippingID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SHIP_ID']");
				Function.AssertEqual(true,POMMAIN_OtherDefaults_ShippingInformation_ShippingID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_MainFormTab);
IWebElement mTab = POMMAIN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Vendor Address").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on VendorAddress_AddressLine1...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_VendorAddress_AddressLine1 = new SeleniumControl( sDriver, "VendorAddress_AddressLine1", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LN_1_ADR']");
				Function.AssertEqual(true,POMMAIN_VendorAddress_AddressLine1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_MainFormTab);
IWebElement mTab = POMMAIN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Bill To & Return Address").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on BillToAndReturnAddress_BillToAddress_BranchLocation...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_BillToAndReturnAddress_BillToAddress_BranchLocation = new SeleniumControl( sDriver, "BillToAndReturnAddress_BillToAddress_BranchLocation", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BILL_TO_LOC_ID']");
				Function.AssertEqual(true,POMMAIN_BillToAndReturnAddress_BillToAddress_BranchLocation.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_MainFormTab);
IWebElement mTab = POMMAIN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Blanket Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on BlanketInfo_BlanketAmts_Total...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_BlanketInfo_BlanketAmts_Total = new SeleniumControl( sDriver, "BlanketInfo_BlanketAmts_Total", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TRN_BLKT_AMT']");
				Function.AssertEqual(true,POMMAIN_BlanketInfo_BlanketAmts_Total.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_MainFormTab);
IWebElement mTab = POMMAIN_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("Header Notes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on HeaderNotesLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderNotesLink = new SeleniumControl( sDriver, "HeaderNotesLink", "ID", "lnk_1003130_POMMAIN_POHDR");
				Function.AssertEqual(true,POMMAIN_HeaderNotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Click on HeaderNotesLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderNotesLink = new SeleniumControl( sDriver, "HeaderNotesLink", "ID", "lnk_1003130_POMMAIN_POHDR");
				Function.WaitControlDisplayed(POMMAIN_HeaderNotesLink);
POMMAIN_HeaderNotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on HeaderNotesForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderNotesForm = new SeleniumControl( sDriver, "HeaderNotesForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POHDRNOTES_']/ancestor::form[1]");
				Function.AssertEqual(true,POMMAIN_HeaderNotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Close on HeaderNotesForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderNotesForm = new SeleniumControl( sDriver, "HeaderNotesForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POHDRNOTES_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_HeaderNotesForm);
IWebElement formBttn = POMMAIN_HeaderNotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Header Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on HeaderTextLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderTextLink = new SeleniumControl( sDriver, "HeaderTextLink", "ID", "lnk_1003131_POMMAIN_POHDR");
				Function.AssertEqual(true,POMMAIN_HeaderTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Click on HeaderTextLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderTextLink = new SeleniumControl( sDriver, "HeaderTextLink", "ID", "lnk_1003131_POMMAIN_POHDR");
				Function.WaitControlDisplayed(POMMAIN_HeaderTextLink);
POMMAIN_HeaderTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on HeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderTextForm = new SeleniumControl( sDriver, "HeaderTextForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POHDRTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMMAIN_HeaderTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExist on HeaderTextTable...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderTextTable = new SeleniumControl( sDriver, "HeaderTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POHDRTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMMAIN_HeaderTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing ClickButton on HeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderTextForm = new SeleniumControl( sDriver, "HeaderTextForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POHDRTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_HeaderTextForm);
IWebElement formBttn = POMMAIN_HeaderTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMMAIN_HeaderTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMMAIN_HeaderTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on HeaderText_Sequence...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderText_Sequence = new SeleniumControl( sDriver, "HeaderText_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POHDRTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,POMMAIN_HeaderText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Close on HeaderTextForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderTextForm = new SeleniumControl( sDriver, "HeaderTextForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POHDRTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_HeaderTextForm);
IWebElement formBttn = POMMAIN_HeaderTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007701_POMMAIN_POHDR");
				Function.AssertEqual(true,POMMAIN_HeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Click on HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderDocumentsLink = new SeleniumControl( sDriver, "HeaderDocumentsLink", "ID", "lnk_1007701_POMMAIN_POHDR");
				Function.WaitControlDisplayed(POMMAIN_HeaderDocumentsLink);
POMMAIN_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMMAIN_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExist on HeaderDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderDocumentsTable = new SeleniumControl( sDriver, "HeaderDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMMAIN_HeaderDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing ClickButton on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_HeaderDocumentsForm);
IWebElement formBttn = POMMAIN_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMMAIN_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMMAIN_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderDocuments_Document = new SeleniumControl( sDriver, "HeaderDocuments_Document", "XPATH", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POMMAIN_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Close on HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_HeaderDocumentsForm = new SeleniumControl( sDriver, "HeaderDocumentsForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_HeaderDocumentsForm);
IWebElement formBttn = POMMAIN_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PO Totals");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on POTotalsLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_POTotalsLink = new SeleniumControl( sDriver, "POTotalsLink", "ID", "lnk_1003396_POMMAIN_POHDR");
				Function.AssertEqual(true,POMMAIN_POTotalsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Click on POTotalsLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_POTotalsLink = new SeleniumControl( sDriver, "POTotalsLink", "ID", "lnk_1003396_POMMAIN_POHDR");
				Function.WaitControlDisplayed(POMMAIN_POTotalsLink);
POMMAIN_POTotalsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on POTotalsForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_POTotalsForm = new SeleniumControl( sDriver, "POTotalsForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_TOTALS_']/ancestor::form[1]");
				Function.AssertEqual(true,POMMAIN_POTotalsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on POTotals_CurrencyTransaction...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_POTotals_CurrencyTransaction = new SeleniumControl( sDriver, "POTotals_CurrencyTransaction", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_TOTALS_']/ancestor::form[1]/descendant::*[@id='TRANS_CURR_CODE']");
				Function.AssertEqual(true,POMMAIN_POTotals_CurrencyTransaction.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Close on POTotalsForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_POTotalsForm = new SeleniumControl( sDriver, "POTotalsForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_TOTALS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_POTotalsForm);
IWebElement formBttn = POMMAIN_POTotalsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003394_POMMAIN_POHDR");
				Function.AssertEqual(true,POMMAIN_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Click on ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ExchangeRatesLink = new SeleniumControl( sDriver, "ExchangeRatesLink", "ID", "lnk_1003394_POMMAIN_POHDR");
				Function.WaitControlDisplayed(POMMAIN_ExchangeRatesLink);
POMMAIN_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,POMMAIN_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "XPATH", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,POMMAIN_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_ExchangeRatesForm);
IWebElement formBttn = POMMAIN_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm = new SeleniumControl( sDriver, "ChildForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]");
				Function.AssertEqual(true,POMMAIN_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMMAIN_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm = new SeleniumControl( sDriver, "ChildForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_ChildForm);
IWebElement formBttn = POMMAIN_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMMAIN_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMMAIN_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_ChildForm_Tab);
IWebElement mTab = POMMAIN_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on ChildForm_Line_Item...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_Line_Item = new SeleniumControl( sDriver, "ChildForm_Line_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,POMMAIN_ChildForm_Line_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_ChildForm_Tab);
IWebElement mTab = POMMAIN_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Cost Amounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on ChildForm_CostAmounts_GrossUnitCost...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_CostAmounts_GrossUnitCost = new SeleniumControl( sDriver, "ChildForm_CostAmounts_GrossUnitCost", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='TRN_GR_UN_CST_AMT']");
				Function.AssertEqual(true,POMMAIN_ChildForm_CostAmounts_GrossUnitCost.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_ChildForm_Tab);
IWebElement mTab = POMMAIN_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Receiving & Inspection").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on ChildForm_ReceivingAndInspection_ShipID...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_ReceivingAndInspection_ShipID = new SeleniumControl( sDriver, "ChildForm_ReceivingAndInspection_ShipID", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='SHIP_ID']");
				Function.AssertEqual(true,POMMAIN_ChildForm_ReceivingAndInspection_ShipID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_ChildForm_Tab);
IWebElement mTab = POMMAIN_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Other Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on ChildForm_OtherInformation_Requisition...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_OtherInformation_Requisition = new SeleniumControl( sDriver, "ChildForm_OtherInformation_Requisition", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='RQ_ID']");
				Function.AssertEqual(true,POMMAIN_ChildForm_OtherInformation_Requisition.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_ChildForm_Tab);
IWebElement mTab = POMMAIN_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Blanket Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on ChildForm_BlanketInformation_UnreleasedBlanketQty...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_BlanketInformation_UnreleasedBlanketQty = new SeleniumControl( sDriver, "ChildForm_BlanketInformation_UnreleasedBlanketQty", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='UNREL_BLKT_QTY']");
				Function.AssertEqual(true,POMMAIN_ChildForm_BlanketInformation_UnreleasedBlanketQty.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_ChildForm_Tab);
IWebElement mTab = POMMAIN_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "A/P").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on ChildForm_AP_VoucherReceived...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_AP_VoucherReceived = new SeleniumControl( sDriver, "ChildForm_AP_VoucherReceived", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='VCHR_RCV_FL']");
				Function.AssertEqual(true,POMMAIN_ChildForm_AP_VoucherReceived.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_ChildForm_Tab);
IWebElement mTab = POMMAIN_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Alternate Part Numbers").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on ChildForm_AlternatePartNumbers_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_AlternatePartNumbers_Manufacturer = new SeleniumControl( sDriver, "ChildForm_AlternatePartNumbers_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,POMMAIN_ChildForm_AlternatePartNumbers_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on ChildForm_Tab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_Tab = new SeleniumControl( sDriver, "ChildForm_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_ChildForm_Tab);
IWebElement mTab = POMMAIN_ChildForm_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("ChildForm_SerialLotInfoForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_SerialLotLink = new SeleniumControl( sDriver, "SerialLotLink", "ID", "lnk_16743_POMMAIN_POLN");
				Function.AssertEqual(true,POMMAIN_SerialLotLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Click on SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_SerialLotLink = new SeleniumControl( sDriver, "SerialLotLink", "ID", "lnk_16743_POMMAIN_POLN");
				Function.WaitControlDisplayed(POMMAIN_SerialLotLink);
POMMAIN_SerialLotLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExist on SerialLotTable...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_SerialLotTable = new SeleniumControl( sDriver, "SerialLotTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_SERIALLOT_DETL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMMAIN_SerialLotTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_SerialLotForm = new SeleniumControl( sDriver, "SerialLotForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_SERIALLOT_DETL_']/ancestor::form[1]");
				Function.AssertEqual(true,POMMAIN_SerialLotForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing ClickButton on SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_SerialLotForm = new SeleniumControl( sDriver, "SerialLotForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_SERIALLOT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_SerialLotForm);
IWebElement formBttn = POMMAIN_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMMAIN_SerialLotForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMMAIN_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on SerialLot_BasicInformation_Quantity...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_SerialLot_BasicInformation_Quantity = new SeleniumControl( sDriver, "SerialLot_BasicInformation_Quantity", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_SERIALLOT_DETL_']/ancestor::form[1]/descendant::*[@id='QTY']");
				Function.AssertEqual(true,POMMAIN_SerialLot_BasicInformation_Quantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on SerialLot_Tab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_SerialLot_Tab = new SeleniumControl( sDriver, "SerialLot_Tab", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_SERIALLOT_DETL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_SerialLot_Tab);
IWebElement mTab = POMMAIN_SerialLot_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "User-Defined Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on SerialLot_UserDefinedInfo_Field1...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_SerialLot_UserDefinedInfo_Field1 = new SeleniumControl( sDriver, "SerialLot_UserDefinedInfo_Field1", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_SERIALLOT_DETL_']/ancestor::form[1]/descendant::*[@id='UDEF_DESC_1']");
				Function.AssertEqual(true,POMMAIN_SerialLot_UserDefinedInfo_Field1.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on SerialLot_Tab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_SerialLot_Tab = new SeleniumControl( sDriver, "SerialLot_Tab", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_SERIALLOT_DETL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_SerialLot_Tab);
IWebElement mTab = POMMAIN_SerialLot_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on SerialLot_Notes...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_SerialLot_Notes = new SeleniumControl( sDriver, "SerialLot_Notes", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_SERIALLOT_DETL_']/ancestor::form[1]/descendant::*[@id='NOTES_NT']");
				Function.AssertEqual(true,POMMAIN_SerialLot_Notes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Select on SerialLot_Tab...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_SerialLot_Tab = new SeleniumControl( sDriver, "SerialLot_Tab", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_SERIALLOT_DETL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POMMAIN_SerialLot_Tab);
IWebElement mTab = POMMAIN_SerialLot_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Shelf Life").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on ChildForm_SerialLot_ShelfLife_ShelfLife_LastExtensionDate...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_ChildForm_SerialLot_ShelfLife_ShelfLife_LastExtensionDate = new SeleniumControl( sDriver, "ChildForm_SerialLot_ShelfLife_ShelfLife_LastExtensionDate", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_SERIALLOT_DETL_']/ancestor::form[1]/descendant::*[@id='LAST_EXT_DT']");
				Function.AssertEqual(true,POMMAIN_ChildForm_SerialLot_ShelfLife_ShelfLife_LastExtensionDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Close on SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_SerialLotForm = new SeleniumControl( sDriver, "SerialLotForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_SERIALLOT_DETL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_SerialLotForm);
IWebElement formBttn = POMMAIN_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on AccountsLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_AccountsLink = new SeleniumControl( sDriver, "AccountsLink", "ID", "lnk_1003249_POMMAIN_POLN");
				Function.AssertEqual(true,POMMAIN_AccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Click on AccountsLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_AccountsLink = new SeleniumControl( sDriver, "AccountsLink", "ID", "lnk_1003249_POMMAIN_POLN");
				Function.WaitControlDisplayed(POMMAIN_AccountsLink);
POMMAIN_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__PO_POLNACCT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMMAIN_AccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExist on AccountsTable...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_AccountsTable = new SeleniumControl( sDriver, "AccountsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PO_POLNACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMMAIN_AccountsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing ClickButton on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__PO_POLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_AccountsForm);
IWebElement formBttn = POMMAIN_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMMAIN_AccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMMAIN_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on Accounts_Project...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_Accounts_Project = new SeleniumControl( sDriver, "Accounts_Project", "XPATH", "//div[translate(@id,'0123456789','')='pr__PO_POLNACCT_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,POMMAIN_Accounts_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Close on AccountsForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_AccountsForm = new SeleniumControl( sDriver, "AccountsForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__PO_POLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_AccountsForm);
IWebElement formBttn = POMMAIN_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineChargesLink = new SeleniumControl( sDriver, "LineChargesLink", "ID", "lnk_1003250_POMMAIN_POLN");
				Function.AssertEqual(true,POMMAIN_LineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Click on LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineChargesLink = new SeleniumControl( sDriver, "LineChargesLink", "ID", "lnk_1003250_POMMAIN_POLN");
				Function.WaitControlDisplayed(POMMAIN_LineChargesLink);
POMMAIN_LineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLNCHG_']/ancestor::form[1]");
				Function.AssertEqual(true,POMMAIN_LineChargesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExist on LineChargesTable...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineChargesTable = new SeleniumControl( sDriver, "LineChargesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLNCHG_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMMAIN_LineChargesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing ClickButton on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLNCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_LineChargesForm);
IWebElement formBttn = POMMAIN_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMMAIN_LineChargesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMMAIN_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on LineCharges_Code...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineCharges_Code = new SeleniumControl( sDriver, "LineCharges_Code", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLNCHG_']/ancestor::form[1]/descendant::*[@id='LN_CHG_TYPE']");
				Function.AssertEqual(true,POMMAIN_LineCharges_Code.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Close on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLNCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_LineChargesForm);
IWebElement formBttn = POMMAIN_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Text");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on LineTextLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineTextLink = new SeleniumControl( sDriver, "LineTextLink", "ID", "lnk_1003251_POMMAIN_POLN");
				Function.AssertEqual(true,POMMAIN_LineTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Click on LineTextLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineTextLink = new SeleniumControl( sDriver, "LineTextLink", "ID", "lnk_1003251_POMMAIN_POLN");
				Function.WaitControlDisplayed(POMMAIN_LineTextLink);
POMMAIN_LineTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on LineTextForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineTextForm = new SeleniumControl( sDriver, "LineTextForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLNTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMMAIN_LineTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExist on LineTextTable...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineTextTable = new SeleniumControl( sDriver, "LineTextTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLNTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMMAIN_LineTextTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing ClickButton on LineTextForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineTextForm = new SeleniumControl( sDriver, "LineTextForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_LineTextForm);
IWebElement formBttn = POMMAIN_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMMAIN_LineTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMMAIN_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on LineText_Sequence...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineText_Sequence = new SeleniumControl( sDriver, "LineText_Sequence", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLNTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,POMMAIN_LineText_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Close on LineTextForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineTextForm = new SeleniumControl( sDriver, "LineTextForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_LineTextForm);
IWebElement formBttn = POMMAIN_LineTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineDocumentsLink = new SeleniumControl( sDriver, "LineDocumentsLink", "ID", "lnk_1007700_POMMAIN_POLN");
				Function.AssertEqual(true,POMMAIN_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Click on LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineDocumentsLink = new SeleniumControl( sDriver, "LineDocumentsLink", "ID", "lnk_1007700_POMMAIN_POLN");
				Function.WaitControlDisplayed(POMMAIN_LineDocumentsLink);
POMMAIN_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POMMAIN_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExist on LineDocumentsTable...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineDocumentsTable = new SeleniumControl( sDriver, "LineDocumentsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POMMAIN_LineDocumentsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing ClickButton on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_LineDocumentsForm);
IWebElement formBttn = POMMAIN_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POMMAIN_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POMMAIN_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineDocuments_Document = new SeleniumControl( sDriver, "LineDocuments_Document", "XPATH", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POMMAIN_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Close on LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_LineDocumentsForm = new SeleniumControl( sDriver, "LineDocumentsForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_LineDocumentsForm);
IWebElement formBttn = POMMAIN_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Currency Line");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_CurrencyLineLink = new SeleniumControl( sDriver, "CurrencyLineLink", "ID", "lnk_1003941_POMMAIN_POLN");
				Function.AssertEqual(true,POMMAIN_CurrencyLineLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Click on CurrencyLineLink...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_CurrencyLineLink = new SeleniumControl( sDriver, "CurrencyLineLink", "ID", "lnk_1003941_POMMAIN_POLN");
				Function.WaitControlDisplayed(POMMAIN_CurrencyLineLink);
POMMAIN_CurrencyLineLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLNCUR_']/ancestor::form[1]");
				Function.AssertEqual(true,POMMAIN_CurrencyLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing VerifyExists on CurrencyLine_LineAmounts_Currency...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_CurrencyLine_LineAmounts_Currency = new SeleniumControl( sDriver, "CurrencyLine_LineAmounts_Currency", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLNCUR_']/ancestor::form[1]/descendant::*[@id='DFSTRANSCURRCODE']");
				Function.AssertEqual(true,POMMAIN_CurrencyLine_LineAmounts_Currency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Close on CurrencyLineForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_CurrencyLineForm = new SeleniumControl( sDriver, "CurrencyLineForm", "XPATH", "//div[translate(@id,'0123456789','')='pr__POMMAIN_POLNCUR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POMMAIN_CurrencyLineForm);
IWebElement formBttn = POMMAIN_CurrencyLineForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "POMMAIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POMMAIN] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl POMMAIN_MainForm = new SeleniumControl( sDriver, "MainForm", "XPATH", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POMMAIN_MainForm);
IWebElement formBttn = POMMAIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

