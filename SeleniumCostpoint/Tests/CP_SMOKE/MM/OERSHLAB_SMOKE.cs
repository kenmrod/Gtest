 
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
    public class OERSHLAB_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Print Shipping Labels", "xpath","//div[@class='navItem'][.='Print Shipping Labels']").Click();


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
								try
				{
				this.ScriptLogger.WriteLine("Catalog");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExists on CatalogNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_CatalogNonContiguousRangesLink = new SeleniumControl( sDriver, "CatalogNonContiguousRangesLink", "ID", "lnk_1004725_OERSHLAB_PARAM");
				Function.AssertEqual(true,OERSHLAB_CatalogNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing Click on CatalogNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_CatalogNonContiguousRangesLink = new SeleniumControl( sDriver, "CatalogNonContiguousRangesLink", "ID", "lnk_1004725_OERSHLAB_PARAM");
				Function.WaitControlDisplayed(OERSHLAB_CatalogNonContiguousRangesLink);
OERSHLAB_CatalogNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExist on CatalogNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_CatalogNonContiguousRangesFormTable = new SeleniumControl( sDriver, "CatalogNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPRICECATLGCD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OERSHLAB_CatalogNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExists on CatalogNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_CatalogNonContiguousRanges_Ok = new SeleniumControl( sDriver, "CatalogNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPRICECATLGCD_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,OERSHLAB_CatalogNonContiguousRanges_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing Close on CatalogNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_CatalogNonContiguousRangesForm = new SeleniumControl( sDriver, "CatalogNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPRICECATLGCD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OERSHLAB_CatalogNonContiguousRangesForm);
IWebElement formBttn = OERSHLAB_CatalogNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Customer");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExists on CustomerNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_CustomerNonContiguousRangesLink = new SeleniumControl( sDriver, "CustomerNonContiguousRangesLink", "ID", "lnk_1004726_OERSHLAB_PARAM");
				Function.AssertEqual(true,OERSHLAB_CustomerNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing Click on CustomerNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_CustomerNonContiguousRangesLink = new SeleniumControl( sDriver, "CustomerNonContiguousRangesLink", "ID", "lnk_1004726_OERSHLAB_PARAM");
				Function.WaitControlDisplayed(OERSHLAB_CustomerNonContiguousRangesLink);
OERSHLAB_CustomerNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExist on CustomerNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_CustomerNonContiguousRangesFormTable = new SeleniumControl( sDriver, "CustomerNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRCUSTID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OERSHLAB_CustomerNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExists on CustomerNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_CustomerNonContiguousRanges_Ok = new SeleniumControl( sDriver, "CustomerNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRCUSTID_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,OERSHLAB_CustomerNonContiguousRanges_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing Close on CustomerNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_CustomerNonContiguousRangesForm = new SeleniumControl( sDriver, "CustomerNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRCUSTID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OERSHLAB_CustomerNonContiguousRangesForm);
IWebElement formBttn = OERSHLAB_CustomerNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Packing Slip");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExists on PackingSlipNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_PackingSlipNonContiguousRangesLink = new SeleniumControl( sDriver, "PackingSlipNonContiguousRangesLink", "ID", "lnk_1004727_OERSHLAB_PARAM");
				Function.AssertEqual(true,OERSHLAB_PackingSlipNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing Click on PackingSlipNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_PackingSlipNonContiguousRangesLink = new SeleniumControl( sDriver, "PackingSlipNonContiguousRangesLink", "ID", "lnk_1004727_OERSHLAB_PARAM");
				Function.WaitControlDisplayed(OERSHLAB_PackingSlipNonContiguousRangesLink);
OERSHLAB_PackingSlipNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExist on PackingSlipNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_PackingSlipNonContiguousRangesFormTable = new SeleniumControl( sDriver, "PackingSlipNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPSID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OERSHLAB_PackingSlipNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExists on PackingSlipNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_PackingSlipNonContiguousRanges_Ok = new SeleniumControl( sDriver, "PackingSlipNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPSID_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,OERSHLAB_PackingSlipNonContiguousRanges_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing Close on PackingSlipNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_PackingSlipNonContiguousRangesForm = new SeleniumControl( sDriver, "PackingSlipNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPSID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OERSHLAB_PackingSlipNonContiguousRangesForm);
IWebElement formBttn = OERSHLAB_PackingSlipNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Project");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExists on ProjectNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_ProjectNonContiguousRangesLink = new SeleniumControl( sDriver, "ProjectNonContiguousRangesLink", "ID", "lnk_1004728_OERSHLAB_PARAM");
				Function.AssertEqual(true,OERSHLAB_ProjectNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing Click on ProjectNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_ProjectNonContiguousRangesLink = new SeleniumControl( sDriver, "ProjectNonContiguousRangesLink", "ID", "lnk_1004728_OERSHLAB_PARAM");
				Function.WaitControlDisplayed(OERSHLAB_ProjectNonContiguousRangesLink);
OERSHLAB_ProjectNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExist on ProjectNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_ProjectNonContiguousRangesFormTable = new SeleniumControl( sDriver, "ProjectNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPROJID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OERSHLAB_ProjectNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExists on ProjectNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_ProjectNonContiguousRanges_Ok = new SeleniumControl( sDriver, "ProjectNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPROJID_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,OERSHLAB_ProjectNonContiguousRanges_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing Close on ProjectNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_ProjectNonContiguousRangesForm = new SeleniumControl( sDriver, "ProjectNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPROJID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OERSHLAB_ProjectNonContiguousRangesForm);
IWebElement formBttn = OERSHLAB_ProjectNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Sales Order ");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExists on SalesOrderNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_SalesOrderNonContiguousRangesLink = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangesLink", "ID", "lnk_1004729_OERSHLAB_PARAM");
				Function.AssertEqual(true,OERSHLAB_SalesOrderNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing Click on SalesOrderNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_SalesOrderNonContiguousRangesLink = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangesLink", "ID", "lnk_1004729_OERSHLAB_PARAM");
				Function.WaitControlDisplayed(OERSHLAB_SalesOrderNonContiguousRangesLink);
OERSHLAB_SalesOrderNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExist on SalesOrderNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_SalesOrderNonContiguousRangesFormTable = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRSOID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OERSHLAB_SalesOrderNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing VerifyExists on SalesOrderNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_SalesOrderNonContiguousRanges_Ok = new SeleniumControl( sDriver, "SalesOrderNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRSOID_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,OERSHLAB_SalesOrderNonContiguousRanges_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing Close on SalesOrderNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_SalesOrderNonContiguousRangesForm = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRSOID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OERSHLAB_SalesOrderNonContiguousRangesForm);
IWebElement formBttn = OERSHLAB_SalesOrderNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OERSHLAB";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OERSHLAB] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OERSHLAB_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OERSHLAB_MainForm);
IWebElement formBttn = OERSHLAB_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

