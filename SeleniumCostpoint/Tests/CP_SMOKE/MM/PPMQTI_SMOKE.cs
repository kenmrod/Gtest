 
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
    public class PPMQTI_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Vendor Quotes By Item", "xpath","//div[@class='navItem'][.='Manage Vendor Quotes By Item']").Click();


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
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPMQTI_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on Item...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_Item = new SeleniumControl( sDriver, "Item", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,PPMQTI_Item.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing Set on Item...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_Item = new SeleniumControl( sDriver, "Item", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='ITEM_ID']");
				PPMQTI_Item.Click();
PPMQTI_Item.SendKeys(" 3105C28-20", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
PPMQTI_Item.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


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
				this.ScriptLogger.WriteLine("Child Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExist on ChildTable...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildTable = new SeleniumControl( sDriver, "ChildTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMQTI_ChildTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLN_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMQTI_ChildForm);
IWebElement formBttn = PPMQTI_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMQTI_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMQTI_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLN_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMQTI_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing Select on ChildForm_HeaderDetails_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_HeaderDetails_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_HeaderDetails_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMQTI_ChildForm_HeaderDetails_ChildFormTab);
IWebElement mTab = PPMQTI_ChildForm_HeaderDetails_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on ChildForm_HeaderDetails_Terms...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_HeaderDetails_Terms = new SeleniumControl( sDriver, "ChildForm_HeaderDetails_Terms", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='TERMS_DC']");
				Function.AssertEqual(true,PPMQTI_ChildForm_HeaderDetails_Terms.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing Select on ChildForm_HeaderDetails_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_HeaderDetails_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_HeaderDetails_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMQTI_ChildForm_HeaderDetails_ChildFormTab);
IWebElement mTab = PPMQTI_ChildForm_HeaderDetails_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on ChildForm_LineDetails_QuoteLine...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_LineDetails_QuoteLine = new SeleniumControl( sDriver, "ChildForm_LineDetails_QuoteLine", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='QT_LN_NO']");
				Function.AssertEqual(true,PPMQTI_ChildForm_LineDetails_QuoteLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing Select on ChildForm_HeaderDetails_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_HeaderDetails_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_HeaderDetails_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMQTI_ChildForm_HeaderDetails_ChildFormTab);
IWebElement mTab = PPMQTI_ChildForm_HeaderDetails_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "RFQ Info").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on ChildForm_RFQInfo_RFQ...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_RFQInfo_RFQ = new SeleniumControl( sDriver, "ChildForm_RFQInfo_RFQ", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='ORIG_RFQ_ID']");
				Function.AssertEqual(true,PPMQTI_ChildForm_RFQInfo_RFQ.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing Select on ChildForm_HeaderDetails_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_HeaderDetails_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_HeaderDetails_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMQTI_ChildForm_HeaderDetails_ChildFormTab);
IWebElement mTab = PPMQTI_ChildForm_HeaderDetails_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manuf/Vend Parts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on ChildForm_ManufVendParts_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_ManufVendParts_Manufacturer = new SeleniumControl( sDriver, "ChildForm_ManufVendParts_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='MANUF_ID']");
				Function.AssertEqual(true,PPMQTI_ChildForm_ManufVendParts_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing Select on ChildForm_HeaderDetails_ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_HeaderDetails_ChildFormTab = new SeleniumControl( sDriver, "ChildForm_HeaderDetails_ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLN_CHILD_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPMQTI_ChildForm_HeaderDetails_ChildFormTab);
IWebElement mTab = PPMQTI_ChildForm_HeaderDetails_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Notes").FirstOrDefault();
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
				this.ScriptLogger.WriteLine("Qty Breakpts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on ChildForm_QtyBreakptsLink...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_QtyBreakptsLink = new SeleniumControl( sDriver, "ChildForm_QtyBreakptsLink", "ID", "lnk_1003502_PPMQTI_QTLN_CHILD");
				Function.AssertEqual(true,PPMQTI_ChildForm_QtyBreakptsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing Click on ChildForm_QtyBreakptsLink...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_QtyBreakptsLink = new SeleniumControl( sDriver, "ChildForm_QtyBreakptsLink", "ID", "lnk_1003502_PPMQTI_QTLN_CHILD");
				Function.WaitControlDisplayed(PPMQTI_ChildForm_QtyBreakptsLink);
PPMQTI_ChildForm_QtyBreakptsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExist on QtyBreakptsTable...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_QtyBreakptsTable = new SeleniumControl( sDriver, "QtyBreakptsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMQTI_QtyBreakptsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing ClickButton on QtyBreakptsForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_QtyBreakptsForm = new SeleniumControl( sDriver, "QtyBreakptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMQTI_QtyBreakptsForm);
IWebElement formBttn = PPMQTI_QtyBreakptsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPMQTI_QtyBreakptsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPMQTI_QtyBreakptsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on QtyBreakptsForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_QtyBreakptsForm = new SeleniumControl( sDriver, "QtyBreakptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMQTI_QtyBreakptsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on QtyBreakpts_MinimumQuantity...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_QtyBreakpts_MinimumQuantity = new SeleniumControl( sDriver, "QtyBreakpts_MinimumQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]/descendant::*[@id='MIN_QTY']");
				Function.AssertEqual(true,PPMQTI_QtyBreakpts_MinimumQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing Close on QtyBreakptsForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_QtyBreakptsForm = new SeleniumControl( sDriver, "QtyBreakptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMQTI_QtyBreakptsForm);
IWebElement formBttn = PPMQTI_QtyBreakptsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1003503_PPMQTI_QTLN_CHILD");
				Function.AssertEqual(true,PPMQTI_ChildForm_LineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing Click on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1003503_PPMQTI_QTLN_CHILD");
				Function.WaitControlDisplayed(PPMQTI_ChildForm_LineChargesLink);
PPMQTI_ChildForm_LineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExist on LineCharges_Table...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_LineCharges_Table = new SeleniumControl( sDriver, "LineCharges_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLNCHG_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPMQTI_LineCharges_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing Close on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPMQTI_QTLNCHG_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMQTI_LineChargesForm);
IWebElement formBttn = PPMQTI_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_1003987_PPMQTI_QTLN_CHILD");
				Function.AssertEqual(true,PPMQTI_ChildForm_ExchangeRatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing Click on ChildForm_ExchangeRatesLink...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ChildForm_ExchangeRatesLink = new SeleniumControl( sDriver, "ChildForm_ExchangeRatesLink", "ID", "lnk_1003987_PPMQTI_QTLN_CHILD");
				Function.WaitControlDisplayed(PPMQTI_ChildForm_ExchangeRatesLink);
PPMQTI_ChildForm_ExchangeRatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.AssertEqual(true,PPMQTI_ExchangeRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing VerifyExists on ExchangeRates_TransactionCurrency...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ExchangeRates_TransactionCurrency = new SeleniumControl( sDriver, "ExchangeRates_TransactionCurrency", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]/descendant::*[@id='TRN_CRNCY_CD']");
				Function.AssertEqual(true,PPMQTI_ExchangeRates_TransactionCurrency.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing Close on ExchangeRatesForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_ExchangeRatesForm = new SeleniumControl( sDriver, "ExchangeRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPM_SEXR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPMQTI_ExchangeRatesForm);
IWebElement formBttn = PPMQTI_ExchangeRatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPMQTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPMQTI] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPMQTI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPMQTI_MainForm);
IWebElement formBttn = PPMQTI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

