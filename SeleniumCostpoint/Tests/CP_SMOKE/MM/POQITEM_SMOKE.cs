 
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
    public class POQITEM_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Proc Planning Reports/Inquiries", "xpath","//div[@class='navItem'][.='Proc Planning Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Item Purchasing Information", "xpath","//div[@class='navItem'][.='View Item Purchasing Information']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,POQITEM_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on Item...", Logger.MessageType.INF);
				SeleniumControl POQITEM_Item = new SeleniumControl( sDriver, "Item", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,POQITEM_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Execute");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Set on Item...", Logger.MessageType.INF);
				SeleniumControl POQITEM_Item = new SeleniumControl( sDriver, "Item", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_ID']");
				POQITEM_Item.Click();
POQITEM_Item.SendKeys(" 3105C28-20", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
POQITEM_Item.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
								try
				{
				this.ScriptLogger.WriteLine("PO Lines Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on POLinesFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLinesFormTable = new SeleniumControl( sDriver, "POLinesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_POLinesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on POLinesForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLinesForm = new SeleniumControl( sDriver, "POLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLinesForm);
IWebElement formBttn = POQITEM_POLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_POLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_POLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLinesForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLinesForm = new SeleniumControl( sDriver, "POLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_POLinesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_PO...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_PO = new SeleniumControl( sDriver, "POLines_PO", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='PO_ID']");
				Function.AssertEqual(true,POQITEM_POLines_PO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on POLinesForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLinesForm = new SeleniumControl( sDriver, "POLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLinesForm);
IWebElement formBttn = POQITEM_POLinesForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? POQITEM_POLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
POQITEM_POLinesForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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
Function.AssertEqual("Query", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Vendor']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath", ".//descendant::div[text() = 'is equal to']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='BESTBUY']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("BESTBUY");}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SetSearchCriterion]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Vendor Name']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath", ".//descendant::div[text() = 'is equal to']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='BEST BUY']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("BEST BUY");}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SetSearchCriterion]" , ex.Message));
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
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on POLinesForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLinesForm = new SeleniumControl( sDriver, "POLinesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLinesForm);
IWebElement formBttn = POQITEM_POLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_POLinesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_POLinesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POLines Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Select on POLinesTab...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLinesTab = new SeleniumControl( sDriver, "POLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQITEM_POLinesTab);
IWebElement mTab = POQITEM_POLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_BasicInformation_Item...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_BasicInformation_Item = new SeleniumControl( sDriver, "POLines_BasicInformation_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,POQITEM_POLines_BasicInformation_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Select on POLinesTab...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLinesTab = new SeleniumControl( sDriver, "POLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQITEM_POLinesTab);
IWebElement mTab = POQITEM_POLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_Details_ShipID...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_Details_ShipID = new SeleniumControl( sDriver, "POLines_Details_ShipID", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='SHIP_ID']");
				Function.AssertEqual(true,POQITEM_POLines_Details_ShipID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Select on POLinesTab...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLinesTab = new SeleniumControl( sDriver, "POLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQITEM_POLinesTab);
IWebElement mTab = POQITEM_POLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Vendor Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_VendorInformation_Vendor...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorInformation_Vendor = new SeleniumControl( sDriver, "POLines_VendorInformation_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,POQITEM_POLines_VendorInformation_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Select on POLinesTab...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLinesTab = new SeleniumControl( sDriver, "POLinesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQITEM_POLinesTab);
IWebElement mTab = POQITEM_POLinesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_Notes_HeaderExpeditingNotes...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_Notes_HeaderExpeditingNotes = new SeleniumControl( sDriver, "POLines_Notes_HeaderExpeditingNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLN_CTW_']/ancestor::form[1]/descendant::*[@id='PO_EXPDT_TX']");
				Function.AssertEqual(true,POQITEM_POLines_Notes_HeaderExpeditingNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Quotes Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on QuotesLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_QuotesLink = new SeleniumControl( sDriver, "QuotesLink", "ID", "lnk_1006491_POQITEM_HDD");
				Function.AssertEqual(true,POQITEM_QuotesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on QuotesLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_QuotesLink = new SeleniumControl( sDriver, "QuotesLink", "ID", "lnk_1006491_POQITEM_HDD");
				Function.WaitControlDisplayed(POQITEM_QuotesLink);
POQITEM_QuotesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on QuotesFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_QuotesFormTable = new SeleniumControl( sDriver, "QuotesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_QTLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_QuotesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on QuotesForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_QuotesForm = new SeleniumControl( sDriver, "QuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_QTLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_QuotesForm);
IWebElement formBttn = POQITEM_QuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_QuotesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_QuotesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on QuotesForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_QuotesForm = new SeleniumControl( sDriver, "QuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_QTLN_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_QuotesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on Quotes_Item...", Logger.MessageType.INF);
				SeleniumControl POQITEM_Quotes_Item = new SeleniumControl( sDriver, "Quotes_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_QTLN_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,POQITEM_Quotes_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Quotes Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Select on QuotesTab...", Logger.MessageType.INF);
				SeleniumControl POQITEM_QuotesTab = new SeleniumControl( sDriver, "QuotesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_QTLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQITEM_QuotesTab);
IWebElement mTab = POQITEM_QuotesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Quote").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on Quotes_Quote_QuoteDate...", Logger.MessageType.INF);
				SeleniumControl POQITEM_Quotes_Quote_QuoteDate = new SeleniumControl( sDriver, "Quotes_Quote_QuoteDate", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_QTLN_']/ancestor::form[1]/descendant::*[@id='QT_DT']");
				Function.AssertEqual(true,POQITEM_Quotes_Quote_QuoteDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Select on QuotesTab...", Logger.MessageType.INF);
				SeleniumControl POQITEM_QuotesTab = new SeleniumControl( sDriver, "QuotesTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_QTLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQITEM_QuotesTab);
IWebElement mTab = POQITEM_QuotesTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Additional Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on Quotes_AdditionalInformation_ManufacturerVendorPart_ManufacturerName...", Logger.MessageType.INF);
				SeleniumControl POQITEM_Quotes_AdditionalInformation_ManufacturerVendorPart_ManufacturerName = new SeleniumControl( sDriver, "Quotes_AdditionalInformation_ManufacturerVendorPart_ManufacturerName", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_QTLN_']/ancestor::form[1]/descendant::*[@id='MANUF_NAME']");
				Function.AssertEqual(true,POQITEM_Quotes_AdditionalInformation_ManufacturerVendorPart_ManufacturerName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Qty Breakpts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on Quotes_QtyBreakptsFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_Quotes_QtyBreakptsFormTable = new SeleniumControl( sDriver, "Quotes_QtyBreakptsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_Quotes_QtyBreakptsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on Quotes_QtyBreakptsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_Quotes_QtyBreakptsForm = new SeleniumControl( sDriver, "Quotes_QtyBreakptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_Quotes_QtyBreakptsForm);
IWebElement formBttn = POQITEM_Quotes_QtyBreakptsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_Quotes_QtyBreakptsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_Quotes_QtyBreakptsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on Quotes_QtyBreakptsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_Quotes_QtyBreakptsForm = new SeleniumControl( sDriver, "Quotes_QtyBreakptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_Quotes_QtyBreakptsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on Quotes_QtyBreakpts_MinimumQuantity...", Logger.MessageType.INF);
				SeleniumControl POQITEM_Quotes_QtyBreakpts_MinimumQuantity = new SeleniumControl( sDriver, "Quotes_QtyBreakpts_MinimumQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]/descendant::*[@id='MIN_QTY']");
				Function.AssertEqual(true,POQITEM_Quotes_QtyBreakpts_MinimumQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on QuotesForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_QuotesForm = new SeleniumControl( sDriver, "QuotesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_QTLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_QuotesForm);
IWebElement formBttn = POQITEM_QuotesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("RFQs Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on RFQsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RFQsLink = new SeleniumControl( sDriver, "RFQsLink", "ID", "lnk_1006493_POQITEM_HDD");
				Function.AssertEqual(true,POQITEM_RFQsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on RFQsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RFQsLink = new SeleniumControl( sDriver, "RFQsLink", "ID", "lnk_1006493_POQITEM_HDD");
				Function.WaitControlDisplayed(POQITEM_RFQsLink);
POQITEM_RFQsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on RFQsFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RFQsFormTable = new SeleniumControl( sDriver, "RFQsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RFQLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_RFQsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on RFQsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RFQsForm = new SeleniumControl( sDriver, "RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RFQLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_RFQsForm);
IWebElement formBttn = POQITEM_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_RFQsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on RFQsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RFQsForm = new SeleniumControl( sDriver, "RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RFQLN_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_RFQsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on RFQs_Item...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RFQs_Item = new SeleniumControl( sDriver, "RFQs_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RFQLN_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,POQITEM_RFQs_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("RFQs Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Select on RFQsTab...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RFQsTab = new SeleniumControl( sDriver, "RFQsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RFQLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQITEM_RFQsTab);
IWebElement mTab = POQITEM_RFQsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "RFQ").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on RFQs_RFQ_Status...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RFQs_RFQ_Status = new SeleniumControl( sDriver, "RFQs_RFQ_Status", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RFQLN_']/ancestor::form[1]/descendant::*[@id='S_RFQ_STATUS']");
				Function.AssertEqual(true,POQITEM_RFQs_RFQ_Status.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Quantity Breakpoints");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on RFQs_QuantityBreakpointsFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RFQs_QuantityBreakpointsFormTable = new SeleniumControl( sDriver, "RFQs_QuantityBreakpointsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RFQ_QTYBKP_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_RFQs_QuantityBreakpointsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on RFQs_QuantityBreakpointsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RFQs_QuantityBreakpointsForm = new SeleniumControl( sDriver, "RFQs_QuantityBreakpointsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RFQ_QTYBKP_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_RFQs_QuantityBreakpointsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on RFQsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RFQsForm = new SeleniumControl( sDriver, "RFQsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RFQLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_RFQsForm);
IWebElement formBttn = POQITEM_RFQsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Requisitions Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on RequisitionsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RequisitionsLink = new SeleniumControl( sDriver, "RequisitionsLink", "ID", "lnk_1006495_POQITEM_HDD");
				Function.AssertEqual(true,POQITEM_RequisitionsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on RequisitionsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RequisitionsLink = new SeleniumControl( sDriver, "RequisitionsLink", "ID", "lnk_1006495_POQITEM_HDD");
				Function.WaitControlDisplayed(POQITEM_RequisitionsLink);
POQITEM_RequisitionsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on RequisitionsFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RequisitionsFormTable = new SeleniumControl( sDriver, "RequisitionsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RQ_LN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_RequisitionsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on RequisitionsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RequisitionsForm = new SeleniumControl( sDriver, "RequisitionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RQ_LN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_RequisitionsForm);
IWebElement formBttn = POQITEM_RequisitionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_RequisitionsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_RequisitionsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on RequisitionsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RequisitionsForm = new SeleniumControl( sDriver, "RequisitionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RQ_LN_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_RequisitionsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on Requisitions_Requisition_Item...", Logger.MessageType.INF);
				SeleniumControl POQITEM_Requisitions_Requisition_Item = new SeleniumControl( sDriver, "Requisitions_Requisition_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RQ_LN_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,POQITEM_Requisitions_Requisition_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on RequisitionsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_RequisitionsForm = new SeleniumControl( sDriver, "RequisitionsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_RQ_LN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_RequisitionsForm);
IWebElement formBttn = POQITEM_RequisitionsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POHistoryLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POHistoryLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POHistoryLink = new SeleniumControl( sDriver, "POHistoryLink", "ID", "lnk_1006500_POQITEM_HDD");
				Function.AssertEqual(true,POQITEM_POHistoryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on POHistoryLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POHistoryLink = new SeleniumControl( sDriver, "POHistoryLink", "ID", "lnk_1006500_POQITEM_HDD");
				Function.WaitControlDisplayed(POQITEM_POHistoryLink);
POQITEM_POHistoryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on POHistoryFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POHistoryFormTable = new SeleniumControl( sDriver, "POHistoryFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLNHS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_POHistoryFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on POHistoryForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POHistoryForm = new SeleniumControl( sDriver, "POHistoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLNHS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POHistoryForm);
IWebElement formBttn = POQITEM_POHistoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_POHistoryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_POHistoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POHistoryForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POHistoryForm = new SeleniumControl( sDriver, "POHistoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLNHS_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_POHistoryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POHistory_PO...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POHistory_PO = new SeleniumControl( sDriver, "POHistory_PO", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLNHS_']/ancestor::form[1]/descendant::*[@id='PO_ID']");
				Function.AssertEqual(true,POQITEM_POHistory_PO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POHistory Tab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Select on POHistoryTab...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POHistoryTab = new SeleniumControl( sDriver, "POHistoryTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLNHS_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQITEM_POHistoryTab);
IWebElement mTab = POQITEM_POHistoryTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Basic Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POHistory_BasicInformation_Item...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POHistory_BasicInformation_Item = new SeleniumControl( sDriver, "POHistory_BasicInformation_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLNHS_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,POQITEM_POHistory_BasicInformation_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Select on POHistoryTab...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POHistoryTab = new SeleniumControl( sDriver, "POHistoryTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLNHS_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQITEM_POHistoryTab);
IWebElement mTab = POQITEM_POHistoryTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POHistory_Details_Commodity...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POHistory_Details_Commodity = new SeleniumControl( sDriver, "POHistory_Details_Commodity", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLNHS_']/ancestor::form[1]/descendant::*[@id='COMM_CD']");
				Function.AssertEqual(true,POQITEM_POHistory_Details_Commodity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Select on POHistoryTab...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POHistoryTab = new SeleniumControl( sDriver, "POHistoryTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLNHS_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQITEM_POHistoryTab);
IWebElement mTab = POQITEM_POHistoryTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POHistory_Notes_ExptNotes...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POHistory_Notes_ExptNotes = new SeleniumControl( sDriver, "POHistory_Notes_ExptNotes", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLNHS_']/ancestor::form[1]/descendant::*[@id='PO_EXPDT_TX']");
				Function.AssertEqual(true,POQITEM_POHistory_Notes_ExptNotes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on POHistoryForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POHistoryForm = new SeleniumControl( sDriver, "POHistoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_POLNHS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POHistoryForm);
IWebElement formBttn = POQITEM_POHistoryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("AssignedVendors Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on AssignedVendorsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AssignedVendorsLink = new SeleniumControl( sDriver, "AssignedVendorsLink", "ID", "lnk_1006926_POQITEM_HDD");
				Function.AssertEqual(true,POQITEM_AssignedVendorsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on AssignedVendorsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AssignedVendorsLink = new SeleniumControl( sDriver, "AssignedVendorsLink", "ID", "lnk_1006926_POQITEM_HDD");
				Function.WaitControlDisplayed(POQITEM_AssignedVendorsLink);
POQITEM_AssignedVendorsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on AssignedVendorsFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AssignedVendorsFormTable = new SeleniumControl( sDriver, "AssignedVendorsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_ITEMVEND_SUBTASK_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_AssignedVendorsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on AssignedVendorsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AssignedVendorsForm = new SeleniumControl( sDriver, "AssignedVendorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_ITEMVEND_SUBTASK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_AssignedVendorsForm);
IWebElement formBttn = POQITEM_AssignedVendorsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_AssignedVendorsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_AssignedVendorsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on AssignedVendorsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AssignedVendorsForm = new SeleniumControl( sDriver, "AssignedVendorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_ITEMVEND_SUBTASK_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_AssignedVendorsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on AssignedVendors_Vendor...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AssignedVendors_Vendor = new SeleniumControl( sDriver, "AssignedVendors_Vendor", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_ITEMVEND_SUBTASK_']/ancestor::form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,POQITEM_AssignedVendors_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("AssignedVendorsTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Select on AssignedVendorsTab...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AssignedVendorsTab = new SeleniumControl( sDriver, "AssignedVendorsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_ITEMVEND_SUBTASK_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQITEM_AssignedVendorsTab);
IWebElement mTab = POQITEM_AssignedVendorsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Vendor Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on AssignedVendors_VendorDetails_VendorHistory_LastPO...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AssignedVendors_VendorDetails_VendorHistory_LastPO = new SeleniumControl( sDriver, "AssignedVendors_VendorDetails_VendorHistory_LastPO", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_ITEMVEND_SUBTASK_']/ancestor::form[1]/descendant::*[@id='LAST_PO_ID']");
				Function.AssertEqual(true,POQITEM_AssignedVendors_VendorDetails_VendorHistory_LastPO.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Select on AssignedVendorsTab...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AssignedVendorsTab = new SeleniumControl( sDriver, "AssignedVendorsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_ITEMVEND_SUBTASK_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQITEM_AssignedVendorsTab);
IWebElement mTab = POQITEM_AssignedVendorsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Performance").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on AssignedVendors_Performance_Delivery_Number_POReceipts...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AssignedVendors_Performance_Delivery_Number_POReceipts = new SeleniumControl( sDriver, "AssignedVendors_Performance_Delivery_Number_POReceipts", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_ITEMVEND_SUBTASK_']/ancestor::form[1]/descendant::*[@id='RECPT_LN_NO']");
				Function.AssertEqual(true,POQITEM_AssignedVendors_Performance_Delivery_Number_POReceipts.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on AssignedVendorsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AssignedVendorsForm = new SeleniumControl( sDriver, "AssignedVendorsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_ITEMVEND_SUBTASK_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_AssignedVendorsForm);
IWebElement formBttn = POQITEM_AssignedVendorsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("AlternatePartsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AlternatePartsLink = new SeleniumControl( sDriver, "AlternatePartsLink", "ID", "lnk_1007329_POQITEM_HDD");
				Function.AssertEqual(true,POQITEM_AlternatePartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on AlternatePartsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AlternatePartsLink = new SeleniumControl( sDriver, "AlternatePartsLink", "ID", "lnk_1007329_POQITEM_HDD");
				Function.WaitControlDisplayed(POQITEM_AlternatePartsLink);
POQITEM_AlternatePartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ChildForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on AlternateParts_ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AlternateParts_ChildFormTable = new SeleniumControl( sDriver, "AlternateParts_ChildFormTable", "xpath", "//input[@id='PART_PREF_TYPE']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_AlternateParts_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on AlternateParts_ChildForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AlternateParts_ChildForm = new SeleniumControl( sDriver, "AlternateParts_ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ALTPART_MEALTPARTS_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_AlternateParts_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on AlternatePartsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_AlternatePartsForm = new SeleniumControl( sDriver, "AlternatePartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_HDR_COMMON_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_AlternatePartsForm);
IWebElement formBttn = POQITEM_AlternatePartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PartDocumentsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_1007334_POQITEM_HDD");
				Function.AssertEqual(true,POQITEM_PartDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on PartDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_PartDocumentsLink = new SeleniumControl( sDriver, "PartDocumentsLink", "ID", "lnk_1007334_POQITEM_HDD");
				Function.WaitControlDisplayed(POQITEM_PartDocumentsLink);
POQITEM_PartDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PartDocuments ChildForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on PartDocuments_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_PartDocuments_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocuments_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_PartDocuments_PartDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on PartDocuments_PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_PartDocuments_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocuments_PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMMDOC_PARTDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_PartDocuments_PartDocumentsForm);
IWebElement formBttn = POQITEM_PartDocuments_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_PartDocuments_PartDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_PartDocuments_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on PartDocuments_Item...", Logger.MessageType.INF);
				SeleniumControl POQITEM_PartDocuments_Item = new SeleniumControl( sDriver, "PartDocuments_Item", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_ITEMDOC_HDR_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,POQITEM_PartDocuments_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on PartDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_PartDocumentsForm = new SeleniumControl( sDriver, "PartDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_ITEMDOC_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_PartDocumentsForm);
IWebElement formBttn = POQITEM_PartDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("StdTextLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on StdTextLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_StdTextLink = new SeleniumControl( sDriver, "StdTextLink", "ID", "lnk_1007336_POQITEM_HDD");
				Function.AssertEqual(true,POQITEM_StdTextLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on StdTextLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_StdTextLink = new SeleniumControl( sDriver, "StdTextLink", "ID", "lnk_1007336_POQITEM_HDD");
				Function.WaitControlDisplayed(POQITEM_StdTextLink);
POQITEM_StdTextLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("StdText ChildForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on StdText_StdTextForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_StdText_StdTextForm = new SeleniumControl( sDriver, "StdText_StdTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ITEMTEXT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_StdText_StdTextForm);
IWebElement formBttn = POQITEM_StdText_StdTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_StdText_StdTextForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_StdText_StdTextForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on StdText_StdTextForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_StdText_StdTextForm = new SeleniumControl( sDriver, "StdText_StdTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ITEMTEXT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_StdText_StdTextForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on StdText_StdText_TextCode...", Logger.MessageType.INF);
				SeleniumControl POQITEM_StdText_StdText_TextCode = new SeleniumControl( sDriver, "StdText_StdText_TextCode", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_ITEMTEXT_CTW_']/ancestor::form[1]/descendant::*[@id='TEXT_CD']");
				Function.AssertEqual(true,POQITEM_StdText_StdText_TextCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on StdTextForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_StdTextForm = new SeleniumControl( sDriver, "StdTextForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_ITENSTD_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_StdTextForm);
IWebElement formBttn = POQITEM_StdTextForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_SerialLotLink = new SeleniumControl( sDriver, "POLines_SerialLotLink", "ID", "lnk_16796_POQITEM_POLN_CTW");
				Function.AssertEqual(true,POQITEM_POLines_SerialLotLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on POLines_SerialLotLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_SerialLotLink = new SeleniumControl( sDriver, "POLines_SerialLotLink", "ID", "lnk_16796_POQITEM_POLN_CTW");
				Function.WaitControlDisplayed(POQITEM_POLines_SerialLotLink);
POQITEM_POLines_SerialLotLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_SerialLotForm = new SeleniumControl( sDriver, "SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNSERIALLOT_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_SerialLotForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_SerialLotForm = new SeleniumControl( sDriver, "SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNSERIALLOT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_SerialLotForm);
IWebElement formBttn = POQITEM_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_SerialLotForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on SerialLot_BasicInformation_Quantity...", Logger.MessageType.INF);
				SeleniumControl POQITEM_SerialLot_BasicInformation_Quantity = new SeleniumControl( sDriver, "SerialLot_BasicInformation_Quantity", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNSERIALLOT_']/ancestor::form[1]/descendant::*[@id='QTY']");
				Function.AssertEqual(true,POQITEM_SerialLot_BasicInformation_Quantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on SerialLotForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_SerialLotForm = new SeleniumControl( sDriver, "SerialLotForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNSERIALLOT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_SerialLotForm);
IWebElement formBttn = POQITEM_SerialLotForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Execute");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ECNsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on ECNsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_ECNsLink = new SeleniumControl( sDriver, "ECNsLink", "ID", "lnk_1007339_POQITEM_HDD");
				Function.AssertEqual(true,POQITEM_ECNsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on ECNsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_ECNsLink = new SeleniumControl( sDriver, "ECNsLink", "ID", "lnk_1007339_POQITEM_HDD");
				Function.WaitControlDisplayed(POQITEM_ECNsLink);
POQITEM_ECNsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ECNS Childform");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on ECNs_ECNsFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_ECNs_ECNsFormTable = new SeleniumControl( sDriver, "ECNs_ECNsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_ECNs_ECNsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on ECNs_ECNsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_ECNs_ECNsForm = new SeleniumControl( sDriver, "ECNs_ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_ECNs_ECNsForm);
IWebElement formBttn = POQITEM_ECNs_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_ECNs_ECNsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_ECNs_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on ECNs_ECNsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_ECNs_ECNsForm = new SeleniumControl( sDriver, "ECNs_ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_ECNs_ECNsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on ECNs_ECNs_ECN...", Logger.MessageType.INF);
				SeleniumControl POQITEM_ECNs_ECNs_ECN = new SeleniumControl( sDriver, "ECNs_ECNs_ECN", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]/descendant::*[@id='ECN_ID']");
				Function.AssertEqual(true,POQITEM_ECNs_ECNs_ECN.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ECNs_ECNsTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Select on ECNs_ECNsTab...", Logger.MessageType.INF);
				SeleniumControl POQITEM_ECNs_ECNsTab = new SeleniumControl( sDriver, "ECNs_ECNsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(POQITEM_ECNs_ECNsTab);
IWebElement mTab = POQITEM_ECNs_ECNsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "ECN Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on ECNs_ECNs_ECNDetails_Status...", Logger.MessageType.INF);
				SeleniumControl POQITEM_ECNs_ECNs_ECNDetails_Status = new SeleniumControl( sDriver, "ECNs_ECNs_ECNDetails_Status", "xpath", "//div[translate(@id,'0123456789','')='pr__MRGMRSUB_ECNPART_ECN_']/ancestor::form[1]/descendant::*[@id='S_ECN_STATUS_CD']");
				Function.AssertEqual(true,POQITEM_ECNs_ECNs_ECNDetails_Status.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on ECNsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_ECNsForm = new SeleniumControl( sDriver, "ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_ITEMECN_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_ECNsForm);
IWebElement formBttn = POQITEM_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POLines_AccountsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_AccountsLink = new SeleniumControl( sDriver, "POLines_AccountsLink", "ID", "lnk_1006951_POQITEM_POLN_CTW");
				Function.AssertEqual(true,POQITEM_POLines_AccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on POLines_AccountsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_AccountsLink = new SeleniumControl( sDriver, "POLines_AccountsLink", "ID", "lnk_1006951_POQITEM_POLN_CTW");
				Function.WaitControlDisplayed(POQITEM_POLines_AccountsLink);
POQITEM_POLines_AccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on POLines_AccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_AccountsFormTable = new SeleniumControl( sDriver, "POLines_AccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PO_POLNACCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_POLines_AccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on POLines_AccountsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_AccountsForm = new SeleniumControl( sDriver, "POLines_AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PO_POLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_AccountsForm);
IWebElement formBttn = POQITEM_POLines_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_POLines_AccountsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_POLines_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_AccountsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_AccountsForm = new SeleniumControl( sDriver, "POLines_AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PO_POLNACCT_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_POLines_AccountsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_Accounts_Project...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_Accounts_Project = new SeleniumControl( sDriver, "POLines_Accounts_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__PO_POLNACCT_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,POQITEM_POLines_Accounts_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on POLines_AccountsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_AccountsForm = new SeleniumControl( sDriver, "POLines_AccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PO_POLNACCT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_AccountsForm);
IWebElement formBttn = POQITEM_POLines_AccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POLines_VendorReturnsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_VendorReturnsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorReturnsLink = new SeleniumControl( sDriver, "POLines_VendorReturnsLink", "ID", "lnk_1006336_POQITEM_POLN_CTW");
				Function.AssertEqual(true,POQITEM_POLines_VendorReturnsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on POLines_VendorReturnsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorReturnsLink = new SeleniumControl( sDriver, "POLines_VendorReturnsLink", "ID", "lnk_1006336_POQITEM_POLN_CTW");
				Function.WaitControlDisplayed(POQITEM_POLines_VendorReturnsLink);
POQITEM_POLines_VendorReturnsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on POLines_VendorReturnsFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorReturnsFormTable = new SeleniumControl( sDriver, "POLines_VendorReturnsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_VENDRTRNLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_POLines_VendorReturnsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on POLines_VendorReturnsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorReturnsForm = new SeleniumControl( sDriver, "POLines_VendorReturnsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_VENDRTRNLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_VendorReturnsForm);
IWebElement formBttn = POQITEM_POLines_VendorReturnsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_POLines_VendorReturnsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_POLines_VendorReturnsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_VendorReturnsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorReturnsForm = new SeleniumControl( sDriver, "POLines_VendorReturnsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_VENDRTRNLN_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_POLines_VendorReturnsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_VendorReturns_Warehouse...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorReturns_Warehouse = new SeleniumControl( sDriver, "POLines_VendorReturns_Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_VENDRTRNLN_']/ancestor::form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,POQITEM_POLines_VendorReturns_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on POLines_VendorReturnsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorReturnsForm = new SeleniumControl( sDriver, "POLines_VendorReturnsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POQITEM_VENDRTRNLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_VendorReturnsForm);
IWebElement formBttn = POQITEM_POLines_VendorReturnsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POLines_VendorContactInformationLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_VendorContactInformationLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorContactInformationLink = new SeleniumControl( sDriver, "POLines_VendorContactInformationLink", "ID", "lnk_1006330_POQITEM_POLN_CTW");
				Function.AssertEqual(true,POQITEM_POLines_VendorContactInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on POLines_VendorContactInformationLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorContactInformationLink = new SeleniumControl( sDriver, "POLines_VendorContactInformationLink", "ID", "lnk_1006330_POQITEM_POLN_CTW");
				Function.WaitControlDisplayed(POQITEM_POLines_VendorContactInformationLink);
POQITEM_POLines_VendorContactInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on POLines_VendorContactInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorContactInformationFormTable = new SeleniumControl( sDriver, "POLines_VendorContactInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PO_VENDADDRCNTACT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_POLines_VendorContactInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on POLines_VendorContactInformationForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorContactInformationForm = new SeleniumControl( sDriver, "POLines_VendorContactInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PO_VENDADDRCNTACT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_VendorContactInformationForm);
IWebElement formBttn = POQITEM_POLines_VendorContactInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_POLines_VendorContactInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_POLines_VendorContactInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_VendorContactInformationForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorContactInformationForm = new SeleniumControl( sDriver, "POLines_VendorContactInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PO_VENDADDRCNTACT_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_POLines_VendorContactInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_VendorContactInformation_SequenceNumber...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorContactInformation_SequenceNumber = new SeleniumControl( sDriver, "POLines_VendorContactInformation_SequenceNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__PO_VENDADDRCNTACT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,POQITEM_POLines_VendorContactInformation_SequenceNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on POLines_VendorContactInformationForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_VendorContactInformationForm = new SeleniumControl( sDriver, "POLines_VendorContactInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PO_VENDADDRCNTACT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_VendorContactInformationForm);
IWebElement formBttn = POQITEM_POLines_VendorContactInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POLines_HeaderDocumentsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_HeaderDocumentsLink = new SeleniumControl( sDriver, "POLines_HeaderDocumentsLink", "ID", "lnk_1007741_POQITEM_POLN_CTW");
				Function.AssertEqual(true,POQITEM_POLines_HeaderDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on POLines_HeaderDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_HeaderDocumentsLink = new SeleniumControl( sDriver, "POLines_HeaderDocumentsLink", "ID", "lnk_1007741_POQITEM_POLN_CTW");
				Function.WaitControlDisplayed(POQITEM_POLines_HeaderDocumentsLink);
POQITEM_POLines_HeaderDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on POLines_HeaderDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_HeaderDocumentsFormTable = new SeleniumControl( sDriver, "POLines_HeaderDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_POLines_HeaderDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on POLines_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_HeaderDocumentsForm = new SeleniumControl( sDriver, "POLines_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_HeaderDocumentsForm);
IWebElement formBttn = POQITEM_POLines_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_POLines_HeaderDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_POLines_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_HeaderDocumentsForm = new SeleniumControl( sDriver, "POLines_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_POLines_HeaderDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_HeaderDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_HeaderDocuments_Document = new SeleniumControl( sDriver, "POLines_HeaderDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POQITEM_POLines_HeaderDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on POLines_HeaderDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_HeaderDocumentsForm = new SeleniumControl( sDriver, "POLines_HeaderDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_PODOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_HeaderDocumentsForm);
IWebElement formBttn = POQITEM_POLines_HeaderDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POLines_POLineTextCodesLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_POLineTextCodesLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineTextCodesLink = new SeleniumControl( sDriver, "POLines_POLineTextCodesLink", "ID", "lnk_1007092_POQITEM_POLN_CTW");
				Function.AssertEqual(true,POQITEM_POLines_POLineTextCodesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on POLines_POLineTextCodesLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineTextCodesLink = new SeleniumControl( sDriver, "POLines_POLineTextCodesLink", "ID", "lnk_1007092_POQITEM_POLN_CTW");
				Function.WaitControlDisplayed(POQITEM_POLines_POLineTextCodesLink);
POQITEM_POLines_POLineTextCodesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on POLines_POLineTextCodesFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineTextCodesFormTable = new SeleniumControl( sDriver, "POLines_POLineTextCodesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_POLNTEXT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_POLines_POLineTextCodesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on POLines_POLineTextCodesForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineTextCodesForm = new SeleniumControl( sDriver, "POLines_POLineTextCodesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_POLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_POLineTextCodesForm);
IWebElement formBttn = POQITEM_POLines_POLineTextCodesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_POLines_POLineTextCodesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_POLines_POLineTextCodesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_POLineTextCodesForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineTextCodesForm = new SeleniumControl( sDriver, "POLines_POLineTextCodesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_POLNTEXT_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_POLines_POLineTextCodesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_POLineTextCodes_Sequence...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineTextCodes_Sequence = new SeleniumControl( sDriver, "POLines_POLineTextCodes_Sequence", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_POLNTEXT_']/ancestor::form[1]/descendant::*[@id='SEQ_NO']");
				Function.AssertEqual(true,POQITEM_POLines_POLineTextCodes_Sequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on POLines_POLineTextCodesForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineTextCodesForm = new SeleniumControl( sDriver, "POLines_POLineTextCodesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_POLNTEXT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_POLineTextCodesForm);
IWebElement formBttn = POQITEM_POLines_POLineTextCodesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POLines_POLineChargesLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_POLineChargesLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineChargesLink = new SeleniumControl( sDriver, "POLines_POLineChargesLink", "ID", "lnk_1007093_POQITEM_POLN_CTW");
				Function.AssertEqual(true,POQITEM_POLines_POLineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on POLines_POLineChargesLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineChargesLink = new SeleniumControl( sDriver, "POLines_POLineChargesLink", "ID", "lnk_1007093_POQITEM_POLN_CTW");
				Function.WaitControlDisplayed(POQITEM_POLines_POLineChargesLink);
POQITEM_POLines_POLineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on POLines_POLineChargesFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineChargesFormTable = new SeleniumControl( sDriver, "POLines_POLineChargesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_POLNCHG_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_POLines_POLineChargesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on POLines_POLineChargesForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineChargesForm = new SeleniumControl( sDriver, "POLines_POLineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_POLNCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_POLineChargesForm);
IWebElement formBttn = POQITEM_POLines_POLineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_POLines_POLineChargesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_POLines_POLineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_POLineChargesForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineChargesForm = new SeleniumControl( sDriver, "POLines_POLineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_POLNCHG_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_POLines_POLineChargesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_POLineCharges_LineCharge...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineCharges_LineCharge = new SeleniumControl( sDriver, "POLines_POLineCharges_LineCharge", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_POLNCHG_']/ancestor::form[1]/descendant::*[@id='LN_CHG_TYPE']");
				Function.AssertEqual(true,POQITEM_POLines_POLineCharges_LineCharge.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on POLines_POLineChargesForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_POLineChargesForm = new SeleniumControl( sDriver, "POLines_POLineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_POLNCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_POLineChargesForm);
IWebElement formBttn = POQITEM_POLines_POLineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("POLines_LineDocumentsLink");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_LineDocumentsLink = new SeleniumControl( sDriver, "POLines_LineDocumentsLink", "ID", "lnk_1007736_POQITEM_POLN_CTW");
				Function.AssertEqual(true,POQITEM_POLines_LineDocumentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Click on POLines_LineDocumentsLink...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_LineDocumentsLink = new SeleniumControl( sDriver, "POLines_LineDocumentsLink", "ID", "lnk_1007736_POQITEM_POLN_CTW");
				Function.WaitControlDisplayed(POQITEM_POLines_LineDocumentsLink);
POQITEM_POLines_LineDocumentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExist on POLines_LineDocumentsFormTable...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_LineDocumentsFormTable = new SeleniumControl( sDriver, "POLines_LineDocumentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,POQITEM_POLines_LineDocumentsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing ClickButton on POLines_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_LineDocumentsForm = new SeleniumControl( sDriver, "POLines_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_LineDocumentsForm);
IWebElement formBttn = POQITEM_POLines_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? POQITEM_POLines_LineDocumentsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
POQITEM_POLines_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_LineDocumentsForm = new SeleniumControl( sDriver, "POLines_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.AssertEqual(true,POQITEM_POLines_LineDocumentsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing VerifyExists on POLines_LineDocuments_Document...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_LineDocuments_Document = new SeleniumControl( sDriver, "POLines_LineDocuments_Document", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]/descendant::*[@id='DOCUMENT_ID']");
				Function.AssertEqual(true,POQITEM_POLines_LineDocuments_Document.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on POLines_LineDocumentsForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_POLines_LineDocumentsForm = new SeleniumControl( sDriver, "POLines_LineDocumentsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__POM_POLNDOCUMENT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(POQITEM_POLines_LineDocumentsForm);
IWebElement formBttn = POQITEM_POLines_LineDocumentsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "POQITEM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[POQITEM] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl POQITEM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(POQITEM_MainForm);
IWebElement formBttn = POQITEM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

