 
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
    public class PPMRFQI_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Procurement Planning", "xpath","//div[@class='deptItem'][.='Procurement Planning']").Click();
new SeleniumControl(sDriver,"Vendor Quotes", "xpath","//div[@class='navItem'][.='Vendor Quotes']").Click();
new SeleniumControl(sDriver,"Manage Request for Quotes By Item", "xpath","//div[@class='navItem'][.='Manage Request for Quotes By Item']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMRFQI_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on Header_ItemInformation_Rev...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_Header_ItemInformation_Rev = new SeleniumControl( sDriver, "Header_ItemInformation_Rev", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='REV']");
				Function.AssertEqual(true,PPMRFQI_Header_ItemInformation_Rev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRFQI_MainTab);
IWebElement mTab = PPMRFQI_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Set on Header_ItemInformation_Item...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_Header_ItemInformation_Item = new SeleniumControl( sDriver, "Header_ItemInformation_Item", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_ID']");
				PPMRFQI_Header_ItemInformation_Item.Click();
PPMRFQI_Header_ItemInformation_Item.SendKeys(" 3108C28-24", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PPMRFQI_Header_ItemInformation_Item.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogIfExists("Invalid object Id: undefined.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogIfExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Set on Header_Buyer...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_Header_Buyer = new SeleniumControl( sDriver, "Header_Buyer", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='BUYER']");
				PPMRFQI_Header_Buyer.Click();
PPMRFQI_Header_Buyer.SendKeys("KK1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PPMRFQI_Header_Buyer.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
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
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_MainTab = new SeleniumControl( sDriver, "MainTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRFQI_MainTab);
IWebElement mTab = PPMRFQI_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Defaults").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on LineDefaults_DesiredLeadTimeARO...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_LineDefaults_DesiredLeadTimeARO = new SeleniumControl( sDriver, "LineDefaults_DesiredLeadTimeARO", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DFLT_LT_DAYS_NO']");
				Function.AssertEqual(true,PPMRFQI_LineDefaults_DesiredLeadTimeARO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DefaultLineQuantity");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Click on DefaultLineQuantityBreakpointsFormLink...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_DefaultLineQuantityBreakpointsFormLink = new SeleniumControl( sDriver, "DefaultLineQuantityBreakpointsFormLink", "ID", "lnk_1004734_PPMRFQI_RFQHDR");
				Function.WaitControlDisplayed(PPMRFQI_DefaultLineQuantityBreakpointsFormLink);
PPMRFQI_DefaultLineQuantityBreakpointsFormLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExist on DefaultLineQuantityBreakpointsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_DefaultLineQuantityBreakpointsFormTable = new SeleniumControl( sDriver, "DefaultLineQuantityBreakpointsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_QUANBRK_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRFQI_DefaultLineQuantityBreakpointsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on DefaultLineQuantityBreakpointsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_DefaultLineQuantityBreakpointsForm = new SeleniumControl( sDriver, "DefaultLineQuantityBreakpointsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_QUANBRK_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRFQI_DefaultLineQuantityBreakpointsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Close on DefaultLineQuantityBreakpointsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_DefaultLineQuantityBreakpointsForm = new SeleniumControl( sDriver, "DefaultLineQuantityBreakpointsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_QUANBRK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQI_DefaultLineQuantityBreakpointsForm);
IWebElement formBttn = PPMRFQI_DefaultLineQuantityBreakpointsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("rfqLines");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on RfqLinesForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLinesForm = new SeleniumControl( sDriver, "RfqLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_RFQLN_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRFQI_RfqLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExist on RfqLinesFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLinesFormTable = new SeleniumControl( sDriver, "RfqLinesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_RFQLN_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRFQI_RfqLinesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing ClickButton on RfqLinesForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLinesForm = new SeleniumControl( sDriver, "RfqLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_RFQLN_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQI_RfqLinesForm);
IWebElement formBttn = PPMRFQI_RfqLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRFQI_RfqLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRFQI_RfqLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on RfqLines_RfqDetails_Rfq...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_RfqDetails_Rfq = new SeleniumControl( sDriver, "RfqLines_RfqDetails_Rfq", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_RFQLN_CHLD_']/ancestor::form[1]/descendant::*[@id='RFQ_ID']");
				Function.AssertEqual(true,PPMRFQI_RfqLines_RfqDetails_Rfq.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Select on RfqTab...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqTab = new SeleniumControl( sDriver, "RfqTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_RFQLN_CHLD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRFQI_RfqTab);
IWebElement mTab = PPMRFQI_RfqTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Delivery").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on RfqLines_Delivery_Delivery_DesiredLeadTimeARO...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_Delivery_Delivery_DesiredLeadTimeARO = new SeleniumControl( sDriver, "RfqLines_Delivery_Delivery_DesiredLeadTimeARO", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_RFQLN_CHLD_']/ancestor::form[1]/descendant::*[@id='LT_DAYS_ARO_NO']");
				Function.AssertEqual(true,PPMRFQI_RfqLines_Delivery_Delivery_DesiredLeadTimeARO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Select on RfqTab...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqTab = new SeleniumControl( sDriver, "RfqTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_RFQLN_CHLD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRFQI_RfqTab);
IWebElement mTab = PPMRFQI_RfqTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manuf/Vend Parts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on RfqLines_ManufVendParts_ManufVendParts_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_ManufVendParts_ManufVendParts_Manufacturer = new SeleniumControl( sDriver, "RfqLines_ManufVendParts_ManufVendParts_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_RFQLN_CHLD_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,PPMRFQI_RfqLines_ManufVendParts_ManufVendParts_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Select on RfqTab...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqTab = new SeleniumControl( sDriver, "RfqTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_RFQLN_CHLD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMRFQI_RfqTab);
IWebElement mTab = PPMRFQI_RfqTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on RfqLines_Notes_RfqHeaderNotes...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_Notes_RfqHeaderNotes = new SeleniumControl( sDriver, "RfqLines_Notes_RfqHeaderNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_RFQLN_CHLD_']/ancestor::form[1]/descendant::*[@id='RFQ_NOTES']");
				Function.AssertEqual(true,PPMRFQI_RfqLines_Notes_RfqHeaderNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Click on RfqLines_HeaderStandardTextLink...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_HeaderStandardTextLink = new SeleniumControl( sDriver, "RfqLines_HeaderStandardTextLink", "ID", "lnk_3602_PPMRFQI_RFQLN_CHLD");
				Function.WaitControlDisplayed(PPMRFQI_RfqLines_HeaderStandardTextLink);
PPMRFQI_RfqLines_HeaderStandardTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on RfqLines_HeaderStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_HeaderStandardTextForm = new SeleniumControl( sDriver, "RfqLines_HeaderStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_HDRTXT_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRFQI_RfqLines_HeaderStandardTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExist on RfqLines_HeaderStandardTextFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_HeaderStandardTextFormTable = new SeleniumControl( sDriver, "RfqLines_HeaderStandardTextFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_HDRTXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRFQI_RfqLines_HeaderStandardTextFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Close on RfqLines_HeaderStandardTextForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_HeaderStandardTextForm = new SeleniumControl( sDriver, "RfqLines_HeaderStandardTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_HDRTXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQI_RfqLines_HeaderStandardTextForm);
IWebElement formBttn = PPMRFQI_RfqLines_HeaderStandardTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Click on RfqLines_HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_HeaderDocumentsLink = new SeleniumControl( sDriver, "RfqLines_HeaderDocumentsLink", "ID", "lnk_1007839_PPMRFQI_RFQLN_CHLD");
				Function.WaitControlDisplayed(PPMRFQI_RfqLines_HeaderDocumentsLink);
PPMRFQI_RfqLines_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on RfqLines_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_HeaderDocumentsForm = new SeleniumControl( sDriver, "RfqLines_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQHDR_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRFQI_RfqLines_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExist on RfqLines_HeaderDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_HeaderDocumentsFormTable = new SeleniumControl( sDriver, "RfqLines_HeaderDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQHDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRFQI_RfqLines_HeaderDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing ClickButton on RfqLines_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_HeaderDocumentsForm = new SeleniumControl( sDriver, "RfqLines_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQHDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQI_RfqLines_HeaderDocumentsForm);
IWebElement formBttn = PPMRFQI_RfqLines_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRFQI_RfqLines_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRFQI_RfqLines_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on RfqLines_HeaderDocuments_Rev...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_HeaderDocuments_Rev = new SeleniumControl( sDriver, "RfqLines_HeaderDocuments_Rev", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQHDR_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_RVSN_ID']");
				Function.AssertEqual(true,PPMRFQI_RfqLines_HeaderDocuments_Rev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Close on RfqLines_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_HeaderDocumentsForm = new SeleniumControl( sDriver, "RfqLines_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQHDR_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQI_RfqLines_HeaderDocumentsForm);
IWebElement formBttn = PPMRFQI_RfqLines_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Vendor Item Info");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Click on Rfq_VendorItemInformationLink...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_Rfq_VendorItemInformationLink = new SeleniumControl( sDriver, "Rfq_VendorItemInformationLink", "ID", "lnk_1003378_PPMRFQI_RFQLN_CHLD");
				Function.WaitControlDisplayed(PPMRFQI_Rfq_VendorItemInformationLink);
PPMRFQI_Rfq_VendorItemInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on RfqLines_VendorItemInformationForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_VendorItemInformationForm = new SeleniumControl( sDriver, "RfqLines_VendorItemInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_VEND_VINF_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRFQI_RfqLines_VendorItemInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on RfqLines_VendorItemInformation_Vendor...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_VendorItemInformation_Vendor = new SeleniumControl( sDriver, "RfqLines_VendorItemInformation_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_VEND_VINF_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,PPMRFQI_RfqLines_VendorItemInformation_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Close on RfqLines_VendorItemInformationForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_VendorItemInformationForm = new SeleniumControl( sDriver, "RfqLines_VendorItemInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_VEND_VINF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQI_RfqLines_VendorItemInformationForm);
IWebElement formBttn = PPMRFQI_RfqLines_VendorItemInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Quantity");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Click on RfqLines_LineQuantityBreakpointsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_LineQuantityBreakpointsLink = new SeleniumControl( sDriver, "RfqLines_LineQuantityBreakpointsLink", "ID", "lnk_1003379_PPMRFQI_RFQLN_CHLD");
				Function.WaitControlDisplayed(PPMRFQI_RfqLines_LineQuantityBreakpointsLink);
PPMRFQI_RfqLines_LineQuantityBreakpointsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on RfqLines_LineQuantityBreakpointsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_LineQuantityBreakpointsForm = new SeleniumControl( sDriver, "RfqLines_LineQuantityBreakpointsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_RFQLNBRK_QUBR_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRFQI_RfqLines_LineQuantityBreakpointsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExist on RfqLines_LineQuantityBreakpointsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_LineQuantityBreakpointsFormTable = new SeleniumControl( sDriver, "RfqLines_LineQuantityBreakpointsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_RFQLNBRK_QUBR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRFQI_RfqLines_LineQuantityBreakpointsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Close on RfqLines_LineQuantityBreakpointsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_LineQuantityBreakpointsForm = new SeleniumControl( sDriver, "RfqLines_LineQuantityBreakpointsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMRFQI_RFQLNBRK_QUBR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQI_RfqLines_LineQuantityBreakpointsForm);
IWebElement formBttn = PPMRFQI_RfqLines_LineQuantityBreakpointsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Line Quantity");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Click on RfqLines_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_LineDocumentsLink = new SeleniumControl( sDriver, "RfqLines_LineDocumentsLink", "ID", "lnk_1007831_PPMRFQI_RFQLN_CHLD");
				Function.WaitControlDisplayed(PPMRFQI_RfqLines_LineDocumentsLink);
PPMRFQI_RfqLines_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on RfqLines_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_LineDocumentsForm = new SeleniumControl( sDriver, "RfqLines_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQLN_DOCUMENTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMRFQI_RfqLines_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExist on RfqLines_LineDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_LineDocumentsFormTable = new SeleniumControl( sDriver, "RfqLines_LineDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMRFQI_RfqLines_LineDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing ClickButton on RfqLines_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_LineDocumentsForm = new SeleniumControl( sDriver, "RfqLines_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQLN_DOCUMENTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMRFQI_RfqLines_LineDocumentsForm);
IWebElement formBttn = PPMRFQI_RfqLines_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMRFQI_RfqLines_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMRFQI_RfqLines_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing VerifyExists on RfqLines_LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_RfqLines_LineDocuments_Document = new SeleniumControl( sDriver, "RfqLines_LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__PPM_RFQLN_DOCUMENTS_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,PPMRFQI_RfqLines_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close the application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMRFQI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMRFQI] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMRFQI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMRFQI_MainForm);
IWebElement formBttn = PPMRFQI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

