 
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
    public class PPQVQT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"View Vendor Quotes", "xpath","//div[@class='navItem'][.='View Vendor Quotes']").Click();


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
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPQVQT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing VerifyExists on MainForm_Vendor...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_MainForm_Vendor = new SeleniumControl( sDriver, "MainForm_Vendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,PPQVQT_MainForm_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVQT_CTW_MAIN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQVQT_ChildForm);
IWebElement formBttn = PPQVQT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PPQVQT_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PPQVQT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
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
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVQT_CTW_MAIN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPQVQT_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVQT_CTW_MAIN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQVQT_ChildForm);
IWebElement formBttn = PPQVQT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPQVQT_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPQVQT_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVQT_CTW_MAIN_']/ancestor::form[1]");
				Function.AssertEqual(true,PPQVQT_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing VerifyExists on ChildForm_Quote...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm_Quote = new SeleniumControl( sDriver, "ChildForm_Quote", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVQT_CTW_MAIN_']/ancestor::form[1]/descendant::*[@id='QUOTE_ID']");
				Function.AssertEqual(true,PPQVQT_ChildForm_Quote.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing Select on ChildForm_tab1...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm_tab1 = new SeleniumControl( sDriver, "ChildForm_tab1", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVQT_CTW_MAIN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPQVQT_ChildForm_tab1);
IWebElement mTab = PPQVQT_ChildForm_tab1.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Quote Line Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing VerifyExists on ChildForm_QuoteLineDetails_LineType...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm_QuoteLineDetails_LineType = new SeleniumControl( sDriver, "ChildForm_QuoteLineDetails_LineType", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVQT_CTW_MAIN_']/ancestor::form[1]/descendant::*[@id='S_PO_LN_TYPE']");
				Function.AssertEqual(true,PPQVQT_ChildForm_QuoteLineDetails_LineType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing Select on ChildForm_tab1...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm_tab1 = new SeleniumControl( sDriver, "ChildForm_tab1", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVQT_CTW_MAIN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPQVQT_ChildForm_tab1);
IWebElement mTab = PPQVQT_ChildForm_tab1.mElement.FindElements(By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Manufacturer/Vend Parts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing VerifyExists on ChildForm_ManufacturerVendParts_Manufacturer...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm_ManufacturerVendParts_Manufacturer = new SeleniumControl( sDriver, "ChildForm_ManufacturerVendParts_Manufacturer", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVQT_CTW_MAIN_']/ancestor::form[1]/descendant::*[@id='MANUF_NAME']");
				Function.AssertEqual(true,PPQVQT_ChildForm_ManufacturerVendParts_Manufacturer.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing Select on ChildForm_tab1...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm_tab1 = new SeleniumControl( sDriver, "ChildForm_tab1", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVQT_CTW_MAIN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPQVQT_ChildForm_tab1);
IWebElement mTab = PPQVQT_ChildForm_tab1.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Line Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing Select on ChildForm_tab1...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm_tab1 = new SeleniumControl( sDriver, "ChildForm_tab1", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVQT_CTW_MAIN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PPQVQT_ChildForm_tab1);
IWebElement mTab = PPQVQT_ChildForm_tab1.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing VerifyExists on ChildForm_Header_Terms...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm_Header_Terms = new SeleniumControl( sDriver, "ChildForm_Header_Terms", "xpath", "//div[translate(@id,'0123456789','')='pr__PPQVQT_CTW_MAIN_']/ancestor::form[1]/descendant::*[@id='TERMS_DC']");
				Function.AssertEqual(true,PPQVQT_ChildForm_Header_Terms.Exists());

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
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing VerifyExists on ChildForm_QtyBreakptsLink...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm_QtyBreakptsLink = new SeleniumControl( sDriver, "ChildForm_QtyBreakptsLink", "ID", "lnk_1007404_PPQVQT_CTW_MAIN");
				Function.AssertEqual(true,PPQVQT_ChildForm_QtyBreakptsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing Click on ChildForm_QtyBreakptsLink...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm_QtyBreakptsLink = new SeleniumControl( sDriver, "ChildForm_QtyBreakptsLink", "ID", "lnk_1007404_PPQVQT_CTW_MAIN");
				Function.WaitControlDisplayed(PPQVQT_ChildForm_QtyBreakptsLink);
PPQVQT_ChildForm_QtyBreakptsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing VerifyExist on QtyBreakptsFormTable...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_QtyBreakptsFormTable = new SeleniumControl( sDriver, "QtyBreakptsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPQVQT_QtyBreakptsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing ClickButton on QtyBreakptsForm...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_QtyBreakptsForm = new SeleniumControl( sDriver, "QtyBreakptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQVQT_QtyBreakptsForm);
IWebElement formBttn = PPQVQT_QtyBreakptsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPQVQT_QtyBreakptsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPQVQT_QtyBreakptsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing VerifyExists on QtyBreakptsForm...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_QtyBreakptsForm = new SeleniumControl( sDriver, "QtyBreakptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]");
				Function.AssertEqual(true,PPQVQT_QtyBreakptsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing VerifyExists on ChildForm_QtyBreakpts_MinimumQuantity...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm_QtyBreakpts_MinimumQuantity = new SeleniumControl( sDriver, "ChildForm_QtyBreakpts_MinimumQuantity", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]/descendant::*[@id='MIN_QTY']");
				Function.AssertEqual(true,PPQVQT_ChildForm_QtyBreakpts_MinimumQuantity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing Close on QtyBreakptsForm...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_QtyBreakptsForm = new SeleniumControl( sDriver, "QtyBreakptsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNBRK_QTYBRPTS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQVQT_QtyBreakptsForm);
IWebElement formBttn = PPQVQT_QtyBreakptsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing VerifyExists on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1007405_PPQVQT_CTW_MAIN");
				Function.AssertEqual(true,PPQVQT_ChildForm_LineChargesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing Click on ChildForm_LineChargesLink...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_ChildForm_LineChargesLink = new SeleniumControl( sDriver, "ChildForm_LineChargesLink", "ID", "lnk_1007405_PPQVQT_CTW_MAIN");
				Function.WaitControlDisplayed(PPQVQT_ChildForm_LineChargesLink);
PPQVQT_ChildForm_LineChargesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing Close on LineChargesForm...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_LineChargesForm = new SeleniumControl( sDriver, "LineChargesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MM_QTLNCHG_LINE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPQVQT_LineChargesForm);
IWebElement formBttn = PPQVQT_LineChargesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPQVQT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPQVQT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPQVQT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPQVQT_MainForm);
IWebElement formBttn = PPQVQT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

