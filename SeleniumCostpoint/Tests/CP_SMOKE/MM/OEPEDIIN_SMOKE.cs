 
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
    public class OEPEDIIN_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Sales Order Entry Utilities", "xpath","//div[@class='navItem'][.='Sales Order Entry Utilities']").Click();
new SeleniumControl(sDriver,"Create EDI Invoice File", "xpath","//div[@class='navItem'][.='Create EDI Invoice File']").Click();


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
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEPEDIIN_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,OEPEDIIN_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CATALOG NON CONTIGUOUS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing VerifyExists on CatalogNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_CatalogNonContiguousRangesLink = new SeleniumControl( sDriver, "CatalogNonContiguousRangesLink", "ID", "lnk_2381_OEPEDIIN_PARAM");
				Function.AssertEqual(true,OEPEDIIN_CatalogNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing Click on CatalogNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_CatalogNonContiguousRangesLink = new SeleniumControl( sDriver, "CatalogNonContiguousRangesLink", "ID", "lnk_2381_OEPEDIIN_PARAM");
				Function.WaitControlDisplayed(OEPEDIIN_CatalogNonContiguousRangesLink);
OEPEDIIN_CatalogNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing VerifyExist on CatalogNonContiguousRangersFormTable...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_CatalogNonContiguousRangersFormTable = new SeleniumControl( sDriver, "CatalogNonContiguousRangersFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPEDIIN_CATALOG_NCR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEPEDIIN_CatalogNonContiguousRangersFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing Close on CatalogNonContiguousRangersForm...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_CatalogNonContiguousRangersForm = new SeleniumControl( sDriver, "CatalogNonContiguousRangersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPEDIIN_CATALOG_NCR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEPEDIIN_CatalogNonContiguousRangersForm);
IWebElement formBttn = OEPEDIIN_CatalogNonContiguousRangersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CUSTOMER NON CONTIGUOUS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing VerifyExists on CustomerNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_CustomerNonContiguousRangesLink = new SeleniumControl( sDriver, "CustomerNonContiguousRangesLink", "ID", "lnk_2383_OEPEDIIN_PARAM");
				Function.AssertEqual(true,OEPEDIIN_CustomerNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing Click on CustomerNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_CustomerNonContiguousRangesLink = new SeleniumControl( sDriver, "CustomerNonContiguousRangesLink", "ID", "lnk_2383_OEPEDIIN_PARAM");
				Function.WaitControlDisplayed(OEPEDIIN_CustomerNonContiguousRangesLink);
OEPEDIIN_CustomerNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing VerifyExist on CustomerNonContiguousRangersFormTable...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_CustomerNonContiguousRangersFormTable = new SeleniumControl( sDriver, "CustomerNonContiguousRangersFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPEDIIN_CUSTOMER_NCR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEPEDIIN_CustomerNonContiguousRangersFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing Close on CustomerNonContiguousRangersForm...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_CustomerNonContiguousRangersForm = new SeleniumControl( sDriver, "CustomerNonContiguousRangersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPEDIIN_CUSTOMER_NCR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEPEDIIN_CustomerNonContiguousRangersForm);
IWebElement formBttn = OEPEDIIN_CustomerNonContiguousRangersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("INVOICE NON CONTIGUOUS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing VerifyExists on InvoiceNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_InvoiceNonContiguousRangesLink = new SeleniumControl( sDriver, "InvoiceNonContiguousRangesLink", "ID", "lnk_2384_OEPEDIIN_PARAM");
				Function.AssertEqual(true,OEPEDIIN_InvoiceNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing Click on InvoiceNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_InvoiceNonContiguousRangesLink = new SeleniumControl( sDriver, "InvoiceNonContiguousRangesLink", "ID", "lnk_2384_OEPEDIIN_PARAM");
				Function.WaitControlDisplayed(OEPEDIIN_InvoiceNonContiguousRangesLink);
OEPEDIIN_InvoiceNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing VerifyExist on InvoiceNonContiguousRangersFormTable...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_InvoiceNonContiguousRangersFormTable = new SeleniumControl( sDriver, "InvoiceNonContiguousRangersFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPEDIIN_INVOICE_NCR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEPEDIIN_InvoiceNonContiguousRangersFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing Close on InvoiceNonContiguousRangersForm...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_InvoiceNonContiguousRangersForm = new SeleniumControl( sDriver, "InvoiceNonContiguousRangersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPEDIIN_INVOICE_NCR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEPEDIIN_InvoiceNonContiguousRangersForm);
IWebElement formBttn = OEPEDIIN_InvoiceNonContiguousRangersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PROJECT NON CONTIGUOUS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing VerifyExists on ProjectNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_ProjectNonContiguousRangesLink = new SeleniumControl( sDriver, "ProjectNonContiguousRangesLink", "ID", "lnk_2385_OEPEDIIN_PARAM");
				Function.AssertEqual(true,OEPEDIIN_ProjectNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing Click on ProjectNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_ProjectNonContiguousRangesLink = new SeleniumControl( sDriver, "ProjectNonContiguousRangesLink", "ID", "lnk_2385_OEPEDIIN_PARAM");
				Function.WaitControlDisplayed(OEPEDIIN_ProjectNonContiguousRangesLink);
OEPEDIIN_ProjectNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing VerifyExist on ProjectNonContiguousRangersFormTable...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_ProjectNonContiguousRangersFormTable = new SeleniumControl( sDriver, "ProjectNonContiguousRangersFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPEDIIN_PROJECT_NCR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEPEDIIN_ProjectNonContiguousRangersFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing Close on ProjectNonContiguousRangersForm...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_ProjectNonContiguousRangersForm = new SeleniumControl( sDriver, "ProjectNonContiguousRangersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPEDIIN_PROJECT_NCR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEPEDIIN_ProjectNonContiguousRangersForm);
IWebElement formBttn = OEPEDIIN_ProjectNonContiguousRangersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SALES ORDER NON CONTIGUOUS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing VerifyExists on SalesOrderNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_SalesOrderNonContiguousRangesLink = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangesLink", "ID", "lnk_2386_OEPEDIIN_PARAM");
				Function.AssertEqual(true,OEPEDIIN_SalesOrderNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing Click on SalesOrderNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_SalesOrderNonContiguousRangesLink = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangesLink", "ID", "lnk_2386_OEPEDIIN_PARAM");
				Function.WaitControlDisplayed(OEPEDIIN_SalesOrderNonContiguousRangesLink);
OEPEDIIN_SalesOrderNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing VerifyExist on SalesOrderNonContiguousRangersFormTable...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_SalesOrderNonContiguousRangersFormTable = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangersFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPEDIIN_SALES_ORDER_NCR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEPEDIIN_SalesOrderNonContiguousRangersFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing Close on SalesOrderNonContiguousRangersForm...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_SalesOrderNonContiguousRangersForm = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPEDIIN_SALES_ORDER_NCR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEPEDIIN_SalesOrderNonContiguousRangersForm);
IWebElement formBttn = OEPEDIIN_SalesOrderNonContiguousRangersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN FORM TABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEPEDIIN_MainForm);
IWebElement formBttn = OEPEDIIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEPEDIIN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEPEDIIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEPEDIIN_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPEDIIN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPEDIIN] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEPEDIIN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEPEDIIN_MainForm);
IWebElement formBttn = OEPEDIIN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

