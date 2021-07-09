 
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
    public class OER250PS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Sales Order Shipping", "xpath","//div[@class='navItem'][.='Sales Order Shipping']").Click();
new SeleniumControl(sDriver,"Print DD250 Packing Slips", "xpath","//div[@class='navItem'][.='Print DD250 Packing Slips']").Click();


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
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OER250PS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OER250PS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl OER250PS_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,OER250PS_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OER250PS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OER250PS_MainForm);
IWebElement formBttn = OER250PS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OER250PS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OER250PS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl OER250PS_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OER250PS_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CATALOG FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing Click on CatalogNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OER250PS_CatalogNonContiguousRangesLink = new SeleniumControl( sDriver, "CatalogNonContiguousRangesLink", "ID", "lnk_1004974_OER250PS_PARAM");
				Function.WaitControlDisplayed(OER250PS_CatalogNonContiguousRangesLink);
OER250PS_CatalogNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing VerifyExist on CatalogNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl OER250PS_CatalogNonContiguousRangesFormTable = new SeleniumControl( sDriver, "CatalogNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPRICECATLGCD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OER250PS_CatalogNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing Close on CatalogNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OER250PS_CatalogNonContiguousRangesForm = new SeleniumControl( sDriver, "CatalogNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPRICECATLGCD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OER250PS_CatalogNonContiguousRangesForm);
IWebElement formBttn = OER250PS_CatalogNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CUSTOMER FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing Click on CustomerNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OER250PS_CustomerNonContiguousRangesLink = new SeleniumControl( sDriver, "CustomerNonContiguousRangesLink", "ID", "lnk_1004976_OER250PS_PARAM");
				Function.WaitControlDisplayed(OER250PS_CustomerNonContiguousRangesLink);
OER250PS_CustomerNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing VerifyExists on CustomerNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OER250PS_CustomerNonContiguousRangesForm = new SeleniumControl( sDriver, "CustomerNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRCUSTID_']/ancestor::form[1]");
				Function.AssertEqual(true,OER250PS_CustomerNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing VerifyExist on CustomerNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl OER250PS_CustomerNonContiguousRangesFormTable = new SeleniumControl( sDriver, "CustomerNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRCUSTID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OER250PS_CustomerNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing Close on CustomerNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OER250PS_CustomerNonContiguousRangesForm = new SeleniumControl( sDriver, "CustomerNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRCUSTID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OER250PS_CustomerNonContiguousRangesForm);
IWebElement formBttn = OER250PS_CustomerNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PACKING SLIP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing Click on PackingSlipNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OER250PS_PackingSlipNonContiguousRangesLink = new SeleniumControl( sDriver, "PackingSlipNonContiguousRangesLink", "ID", "lnk_1004977_OER250PS_PARAM");
				Function.WaitControlDisplayed(OER250PS_PackingSlipNonContiguousRangesLink);
OER250PS_PackingSlipNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing VerifyExists on PackingSlipNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OER250PS_PackingSlipNonContiguousRangesForm = new SeleniumControl( sDriver, "PackingSlipNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPSID_']/ancestor::form[1]");
				Function.AssertEqual(true,OER250PS_PackingSlipNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing VerifyExist on PackingSlipNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl OER250PS_PackingSlipNonContiguousRangesFormTable = new SeleniumControl( sDriver, "PackingSlipNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPSID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OER250PS_PackingSlipNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing Close on PackingSlipNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OER250PS_PackingSlipNonContiguousRangesForm = new SeleniumControl( sDriver, "PackingSlipNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPSID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OER250PS_PackingSlipNonContiguousRangesForm);
IWebElement formBttn = OER250PS_PackingSlipNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PROJECT FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing Click on ProjectNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OER250PS_ProjectNonContiguousRangesLink = new SeleniumControl( sDriver, "ProjectNonContiguousRangesLink", "ID", "lnk_1004978_OER250PS_PARAM");
				Function.WaitControlDisplayed(OER250PS_ProjectNonContiguousRangesLink);
OER250PS_ProjectNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing VerifyExists on ProjectNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OER250PS_ProjectNonContiguousRangesForm = new SeleniumControl( sDriver, "ProjectNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPROJID_']/ancestor::form[1]");
				Function.AssertEqual(true,OER250PS_ProjectNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing VerifyExist on ProjectNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl OER250PS_ProjectNonContiguousRangesFormTable = new SeleniumControl( sDriver, "ProjectNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPROJID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OER250PS_ProjectNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing Close on ProjectNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OER250PS_ProjectNonContiguousRangesForm = new SeleniumControl( sDriver, "ProjectNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPROJID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OER250PS_ProjectNonContiguousRangesForm);
IWebElement formBttn = OER250PS_ProjectNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SALES ORDER FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing Click on SalesOrderNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OER250PS_SalesOrderNonContiguousRangesLink = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangesLink", "ID", "lnk_1004979_OER250PS_PARAM");
				Function.WaitControlDisplayed(OER250PS_SalesOrderNonContiguousRangesLink);
OER250PS_SalesOrderNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing VerifyExists on SalesOrderNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OER250PS_SalesOrderNonContiguousRangesForm = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRSOID_']/ancestor::form[1]");
				Function.AssertEqual(true,OER250PS_SalesOrderNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing VerifyExist on SalesOrderNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl OER250PS_SalesOrderNonContiguousRangesFormTable = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRSOID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OER250PS_SalesOrderNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing Close on SalesOrderNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OER250PS_SalesOrderNonContiguousRangesForm = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRSOID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OER250PS_SalesOrderNonContiguousRangesForm);
IWebElement formBttn = OER250PS_SalesOrderNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OER250PS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OER250PS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OER250PS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OER250PS_MainForm);
IWebElement formBttn = OER250PS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

