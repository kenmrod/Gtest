 
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
    public class OEPGRQ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Sales Order Material Processing", "xpath","//div[@class='navItem'][.='Sales Order Material Processing']").Click();
new SeleniumControl(sDriver,"Create Purchase Requisitions from Sales Orders", "xpath","//div[@class='navItem'][.='Create Purchase Requisitions from Sales Orders']").Click();


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
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEPGRQ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,OEPGRQ_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEPGRQ_MainForm);
IWebElement formBttn = OEPGRQ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEPGRQ_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEPGRQ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Catalog Non-Conti.");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing Click on CatalogNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_CatalogNonContiguousRangesLink = new SeleniumControl( sDriver, "CatalogNonContiguousRangesLink", "ID", "lnk_2437_OEPGRQ_PARAM");
				Function.WaitControlDisplayed(OEPGRQ_CatalogNonContiguousRangesLink);
OEPGRQ_CatalogNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing VerifyExist on CatalogNonContiguousRangesTable...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_CatalogNonContiguousRangesTable = new SeleniumControl( sDriver, "CatalogNonContiguousRangesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPRICECATLGCD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEPGRQ_CatalogNonContiguousRangesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing Close on CatalogNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_CatalogNonContiguousRangesForm = new SeleniumControl( sDriver, "CatalogNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPRICECATLGCD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEPGRQ_CatalogNonContiguousRangesForm);
IWebElement formBttn = OEPGRQ_CatalogNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing Click on CustXNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_CustXNonContiguousRangesLink = new SeleniumControl( sDriver, "CustXNonContiguousRangesLink", "ID", "lnk_2436_OEPGRQ_PARAM");
				Function.WaitControlDisplayed(OEPGRQ_CustXNonContiguousRangesLink);
OEPGRQ_CustXNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing VerifyExist on CustXNonContiguousRangesTable...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_CustXNonContiguousRangesTable = new SeleniumControl( sDriver, "CustXNonContiguousRangesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRCUSTID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEPGRQ_CustXNonContiguousRangesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing Close on CustXNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_CustXNonContiguousRangesForm = new SeleniumControl( sDriver, "CustXNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRCUSTID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEPGRQ_CustXNonContiguousRangesForm);
IWebElement formBttn = OEPGRQ_CustXNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Catalog Non-Conti.");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing Click on SalesOrderNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_SalesOrderNonContiguousRangesLink = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangesLink", "ID", "lnk_2440_OEPGRQ_PARAM");
				Function.WaitControlDisplayed(OEPGRQ_SalesOrderNonContiguousRangesLink);
OEPGRQ_SalesOrderNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing VerifyExist on SalesOrderNonContiguousRangesTable...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_SalesOrderNonContiguousRangesTable = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRSOID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEPGRQ_SalesOrderNonContiguousRangesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing Close on SalesOrderNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_SalesOrderNonContiguousRangesForm = new SeleniumControl( sDriver, "SalesOrderNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRSOID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEPGRQ_SalesOrderNonContiguousRangesForm);
IWebElement formBttn = OEPGRQ_SalesOrderNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Catalog Non-Conti.");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing Click on ProjectNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_ProjectNonContiguousRangesLink = new SeleniumControl( sDriver, "ProjectNonContiguousRangesLink", "ID", "lnk_2438_OEPGRQ_PARAM");
				Function.WaitControlDisplayed(OEPGRQ_ProjectNonContiguousRangesLink);
OEPGRQ_ProjectNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing VerifyExist on ProjectNonContiguousRangesTable...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_ProjectNonContiguousRangesTable = new SeleniumControl( sDriver, "ProjectNonContiguousRangesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPROJID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEPGRQ_ProjectNonContiguousRangesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing Close on ProjectNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_ProjectNonContiguousRangesForm = new SeleniumControl( sDriver, "ProjectNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__CPP_NCRPROJID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEPGRQ_ProjectNonContiguousRangesForm);
IWebElement formBttn = OEPGRQ_ProjectNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Catalog Non-Conti.");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing Click on SOLineNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_SOLineNonContiguousRangesLink = new SeleniumControl( sDriver, "SOLineNonContiguousRangesLink", "ID", "lnk_2441_OEPGRQ_PARAM");
				Function.WaitControlDisplayed(OEPGRQ_SOLineNonContiguousRangesLink);
OEPGRQ_SOLineNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing VerifyExist on SOLineNonContiguousRangesTable...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_SOLineNonContiguousRangesTable = new SeleniumControl( sDriver, "SOLineNonContiguousRangesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPGRQ_SOLN_NCR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEPGRQ_SOLineNonContiguousRangesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing Close on SOLineNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_SOLineNonContiguousRangesForm = new SeleniumControl( sDriver, "SOLineNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPGRQ_SOLN_NCR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEPGRQ_SOLineNonContiguousRangesForm);
IWebElement formBttn = OEPGRQ_SOLineNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "OEPGRQ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPGRQ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEPGRQ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEPGRQ_MainForm);
IWebElement formBttn = OEPGRQ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

