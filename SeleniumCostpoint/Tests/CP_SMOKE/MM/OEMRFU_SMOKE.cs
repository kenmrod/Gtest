 
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
    public class OEMRFU_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Sales Order Invoices", "xpath","//div[@class='navItem'][.='Sales Order Invoices']").Click();
new SeleniumControl(sDriver,"Select Invoices Ready for Use/Acceptance", "xpath","//div[@class='navItem'][.='Select Invoices Ready for Use/Acceptance']").Click();


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
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEMRFU_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExists on SalesOrder...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_SalesOrder = new SeleniumControl( sDriver, "SalesOrder", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SO_ID']");
				Function.AssertEqual(true,OEMRFU_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("InvoiceDetailsForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExist on InvoiceDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetailsFormTable = new SeleniumControl( sDriver, "InvoiceDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMRFU_SOINVCHDR_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMRFU_InvoiceDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing ClickButton on InvoiceDetailsForm...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetailsForm = new SeleniumControl( sDriver, "InvoiceDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMRFU_SOINVCHDR_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMRFU_InvoiceDetailsForm);
IWebElement formBttn = OEMRFU_InvoiceDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMRFU_InvoiceDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMRFU_InvoiceDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExists on InvoiceDetailsForm...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetailsForm = new SeleniumControl( sDriver, "InvoiceDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMRFU_SOINVCHDR_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMRFU_InvoiceDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExists on InvoiceDetails_GeneralInfo_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_GeneralInfo_SalesOrder = new SeleniumControl( sDriver, "InvoiceDetails_GeneralInfo_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMRFU_SOINVCHDR_DTL_']/ancestor::form[1]/descendant::*[@id='SO_ID']");
				Function.AssertEqual(true,OEMRFU_InvoiceDetails_GeneralInfo_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Query");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing ClickButton on InvoiceDetailsForm...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetailsForm = new SeleniumControl( sDriver, "InvoiceDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMRFU_SOINVCHDR_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMRFU_InvoiceDetailsForm);
IWebElement formBttn = OEMRFU_InvoiceDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? OEMRFU_InvoiceDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
OEMRFU_InvoiceDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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

				this.ScriptLogger.WriteLine("[Query] Performing Click on Query...", Logger.MessageType.INF);
				SeleniumControl Query_Query = new SeleniumControl( sDriver, "Query", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Query);
if (Query_Query.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Query.Click(5,5);
else Query_Query.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("InvoiceLineInformation Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExists on InvoiceDetails_InvoiceLineInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_InvoiceLineInformationLink = new SeleniumControl( sDriver, "InvoiceDetails_InvoiceLineInformationLink", "ID", "lnk_3570_OEMRFU_SOINVCHDR_DTL");
				Function.AssertEqual(true,OEMRFU_InvoiceDetails_InvoiceLineInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing Click on InvoiceDetails_InvoiceLineInformationLink...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_InvoiceLineInformationLink = new SeleniumControl( sDriver, "InvoiceDetails_InvoiceLineInformationLink", "ID", "lnk_3570_OEMRFU_SOINVCHDR_DTL");
				Function.WaitControlDisplayed(OEMRFU_InvoiceDetails_InvoiceLineInformationLink);
OEMRFU_InvoiceDetails_InvoiceLineInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExist on InvoiceDetails_InvoiceLineInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_InvoiceLineInformationFormTable = new SeleniumControl( sDriver, "InvoiceDetails_InvoiceLineInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMRFU_SOINVCLN_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMRFU_InvoiceDetails_InvoiceLineInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing ClickButton on InvoiceDetails_InvoiceLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_InvoiceLineInformationForm = new SeleniumControl( sDriver, "InvoiceDetails_InvoiceLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMRFU_SOINVCLN_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMRFU_InvoiceDetails_InvoiceLineInformationForm);
IWebElement formBttn = OEMRFU_InvoiceDetails_InvoiceLineInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMRFU_InvoiceDetails_InvoiceLineInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMRFU_InvoiceDetails_InvoiceLineInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExists on InvoiceDetails_InvoiceLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_InvoiceLineInformationForm = new SeleniumControl( sDriver, "InvoiceDetails_InvoiceLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMRFU_SOINVCLN_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMRFU_InvoiceDetails_InvoiceLineInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("InvoiceLineInformationTab");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing Select on InvoiceDetails_InvoiceLineInformationTab...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_InvoiceLineInformationTab = new SeleniumControl( sDriver, "InvoiceDetails_InvoiceLineInformationTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMRFU_SOINVCLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMRFU_InvoiceDetails_InvoiceLineInformationTab);
IWebElement mTab = OEMRFU_InvoiceDetails_InvoiceLineInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Item Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExists on InvoiceDetails_InvoiceLineInformation_ItemDetails_InvoiceLine...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_InvoiceLineInformation_ItemDetails_InvoiceLine = new SeleniumControl( sDriver, "InvoiceDetails_InvoiceLineInformation_ItemDetails_InvoiceLine", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMRFU_SOINVCLN_DTL_']/ancestor::form[1]/descendant::*[@id='SO_INVC_LN_NO']");
				Function.AssertEqual(true,OEMRFU_InvoiceDetails_InvoiceLineInformation_ItemDetails_InvoiceLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing Select on InvoiceDetails_InvoiceLineInformationTab...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_InvoiceLineInformationTab = new SeleniumControl( sDriver, "InvoiceDetails_InvoiceLineInformationTab", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMRFU_SOINVCLN_DTL_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(OEMRFU_InvoiceDetails_InvoiceLineInformationTab);
IWebElement mTab = OEMRFU_InvoiceDetails_InvoiceLineInformationTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Amounts").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExists on InvoiceDetails_InvoiceLineInformation_Amounts_GrossUnitPrice...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_InvoiceLineInformation_Amounts_GrossUnitPrice = new SeleniumControl( sDriver, "InvoiceDetails_InvoiceLineInformation_Amounts_GrossUnitPrice", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMRFU_SOINVCLN_DTL_']/ancestor::form[1]/descendant::*[@id='GROSS_UNIT_PRC_AMT']");
				Function.AssertEqual(true,OEMRFU_InvoiceDetails_InvoiceLineInformation_Amounts_GrossUnitPrice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing Close on InvoiceDetails_InvoiceLineInformationForm...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_InvoiceLineInformationForm = new SeleniumControl( sDriver, "InvoiceDetails_InvoiceLineInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMRFU_SOINVCLN_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMRFU_InvoiceDetails_InvoiceLineInformationForm);
IWebElement formBttn = OEMRFU_InvoiceDetails_InvoiceLineInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("WAWF Link");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExists on InvoiceDetails_WAWFLink...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_WAWFLink = new SeleniumControl( sDriver, "InvoiceDetails_WAWFLink", "ID", "lnk_3571_OEMRFU_SOINVCHDR_DTL");
				Function.AssertEqual(true,OEMRFU_InvoiceDetails_WAWFLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing Click on InvoiceDetails_WAWFLink...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_WAWFLink = new SeleniumControl( sDriver, "InvoiceDetails_WAWFLink", "ID", "lnk_3571_OEMRFU_SOINVCHDR_DTL");
				Function.WaitControlDisplayed(OEMRFU_InvoiceDetails_WAWFLink);
OEMRFU_InvoiceDetails_WAWFLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExists on InvoiceDetails_WAWFForm...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_WAWFForm = new SeleniumControl( sDriver, "InvoiceDetails_WAWFForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OE_SOINVCHDR_WAWF_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMRFU_InvoiceDetails_WAWFForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExists on InvoiceDetails_WAWF_Invoice...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_WAWF_Invoice = new SeleniumControl( sDriver, "InvoiceDetails_WAWF_Invoice", "xpath", "//div[translate(@id,'0123456789','')='pr__OE_SOINVCHDR_WAWF_']/ancestor::form[1]/descendant::*[@id='SO_INVC_ID']");
				Function.AssertEqual(true,OEMRFU_InvoiceDetails_WAWF_Invoice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing ClickButton on InvoiceDetails_WAWFForm...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_WAWFForm = new SeleniumControl( sDriver, "InvoiceDetails_WAWFForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OE_SOINVCHDR_WAWF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMRFU_InvoiceDetails_WAWFForm);
IWebElement formBttn = OEMRFU_InvoiceDetails_WAWFForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEMRFU_InvoiceDetails_WAWFForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEMRFU_InvoiceDetails_WAWFForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing VerifyExist on InvoiceDetails_WAWFFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_WAWFFormTable = new SeleniumControl( sDriver, "InvoiceDetails_WAWFFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OE_SOINVCHDR_WAWF_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMRFU_InvoiceDetails_WAWFFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing Close on InvoiceDetails_WAWFForm...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_InvoiceDetails_WAWFForm = new SeleniumControl( sDriver, "InvoiceDetails_WAWFForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OE_SOINVCHDR_WAWF_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMRFU_InvoiceDetails_WAWFForm);
IWebElement formBttn = OEMRFU_InvoiceDetails_WAWFForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEMRFU";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMRFU] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMRFU_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMRFU_MainForm);
IWebElement formBttn = OEMRFU_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

