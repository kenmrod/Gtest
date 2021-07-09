 
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
    public class PPPGPO_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Purchase Requisitions", "xpath","//div[@class='navItem'][.='Purchase Requisitions']").Click();
new SeleniumControl(sDriver,"Create Purchase Orders", "xpath","//div[@class='navItem'][.='Create Purchase Orders']").Click();


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
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PPPGPO_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPPGPO_MainForm);
IWebElement formBttn = PPPGPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PPPGPO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PPPGPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPPGPO_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPPGPO_MainForm);
IWebElement formBttn = PPPGPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PPPGPO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PPPGPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,PPPGPO_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Non-Contiguous Buyer Ranges");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExists on NonContiguousBuyerLink...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousBuyerLink = new SeleniumControl( sDriver, "NonContiguousBuyerLink", "ID", "lnk_2356_PPPGPO_PARAM");
				Function.AssertEqual(true,PPPGPO_NonContiguousBuyerLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing Click on NonContiguousBuyerLink...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousBuyerLink = new SeleniumControl( sDriver, "NonContiguousBuyerLink", "ID", "lnk_2356_PPPGPO_PARAM");
				Function.WaitControlDisplayed(PPPGPO_NonContiguousBuyerLink);
PPPGPO_NonContiguousBuyerLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExists on NonContiguousBuyerForm...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousBuyerForm = new SeleniumControl( sDriver, "NonContiguousBuyerForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPPGPO_NCR_BUYER_']/ancestor::form[1]");
				Function.AssertEqual(true,PPPGPO_NonContiguousBuyerForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExist on NonContiguousBuyerLinkTable...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousBuyerLinkTable = new SeleniumControl( sDriver, "NonContiguousBuyerLinkTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPPGPO_NCR_BUYER_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPPGPO_NonContiguousBuyerLinkTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing Close on NonContiguousBuyerForm...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousBuyerForm = new SeleniumControl( sDriver, "NonContiguousBuyerForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPPGPO_NCR_BUYER_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPPGPO_NonContiguousBuyerForm);
IWebElement formBttn = PPPGPO_NonContiguousBuyerForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Non-Contiguous Vendor Ranges");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExists on NonContiguousVendorLink...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousVendorLink = new SeleniumControl( sDriver, "NonContiguousVendorLink", "ID", "lnk_2357_PPPGPO_PARAM");
				Function.AssertEqual(true,PPPGPO_NonContiguousVendorLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing Click on NonContiguousVendorLink...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousVendorLink = new SeleniumControl( sDriver, "NonContiguousVendorLink", "ID", "lnk_2357_PPPGPO_PARAM");
				Function.WaitControlDisplayed(PPPGPO_NonContiguousVendorLink);
PPPGPO_NonContiguousVendorLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExists on NonContiguousVendorForm...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousVendorForm = new SeleniumControl( sDriver, "NonContiguousVendorForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPPGPO_NCR_VEND_']/ancestor::form[1]");
				Function.AssertEqual(true,PPPGPO_NonContiguousVendorForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExist on NonContiguousVendorTable...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousVendorTable = new SeleniumControl( sDriver, "NonContiguousVendorTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPPGPO_NCR_VEND_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPPGPO_NonContiguousVendorTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing Close on NonContiguousVendorForm...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousVendorForm = new SeleniumControl( sDriver, "NonContiguousVendorForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPPGPO_NCR_VEND_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPPGPO_NonContiguousVendorForm);
IWebElement formBttn = PPPGPO_NonContiguousVendorForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Non-Contiguous Requisition Ranges");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExists on NonContiguousRequisitionLink...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousRequisitionLink = new SeleniumControl( sDriver, "NonContiguousRequisitionLink", "ID", "lnk_2359_PPPGPO_PARAM");
				Function.AssertEqual(true,PPPGPO_NonContiguousRequisitionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing Click on NonContiguousRequisitionLink...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousRequisitionLink = new SeleniumControl( sDriver, "NonContiguousRequisitionLink", "ID", "lnk_2359_PPPGPO_PARAM");
				Function.WaitControlDisplayed(PPPGPO_NonContiguousRequisitionLink);
PPPGPO_NonContiguousRequisitionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExists on NonContiguousRequisitionForm...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousRequisitionForm = new SeleniumControl( sDriver, "NonContiguousRequisitionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPPGPO_NCR_RQ_']/ancestor::form[1]");
				Function.AssertEqual(true,PPPGPO_NonContiguousRequisitionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExist on NonContiguousRequisitionTable...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousRequisitionTable = new SeleniumControl( sDriver, "NonContiguousRequisitionTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPPGPO_NCR_RQ_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPPGPO_NonContiguousRequisitionTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing Close on NonContiguousRequisitionForm...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousRequisitionForm = new SeleniumControl( sDriver, "NonContiguousRequisitionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPPGPO_NCR_RQ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPPGPO_NonContiguousRequisitionForm);
IWebElement formBttn = PPPGPO_NonContiguousRequisitionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Non-Contiguous Purchase Order Ranges");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExists on NonContiguousPurchaseOrderLink...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousPurchaseOrderLink = new SeleniumControl( sDriver, "NonContiguousPurchaseOrderLink", "ID", "lnk_2360_PPPGPO_PARAM");
				Function.AssertEqual(true,PPPGPO_NonContiguousPurchaseOrderLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing Click on NonContiguousPurchaseOrderLink...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousPurchaseOrderLink = new SeleniumControl( sDriver, "NonContiguousPurchaseOrderLink", "ID", "lnk_2360_PPPGPO_PARAM");
				Function.WaitControlDisplayed(PPPGPO_NonContiguousPurchaseOrderLink);
PPPGPO_NonContiguousPurchaseOrderLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExists on NonContiguousPurchaseOrderForm...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousPurchaseOrderForm = new SeleniumControl( sDriver, "NonContiguousPurchaseOrderForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPPGPO_NCR_PO_']/ancestor::form[1]");
				Function.AssertEqual(true,PPPGPO_NonContiguousPurchaseOrderForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing VerifyExist on NonContiguousPurchaseOrderTable...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousPurchaseOrderTable = new SeleniumControl( sDriver, "NonContiguousPurchaseOrderTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PPPGPO_NCR_PO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PPPGPO_NonContiguousPurchaseOrderTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing Close on NonContiguousPurchaseOrderForm...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_NonContiguousPurchaseOrderForm = new SeleniumControl( sDriver, "NonContiguousPurchaseOrderForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PPPGPO_NCR_PO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PPPGPO_NonContiguousPurchaseOrderForm);
IWebElement formBttn = PPPGPO_NonContiguousPurchaseOrderForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PPPGPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PPPGPO] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PPPGPO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PPPGPO_MainForm);
IWebElement formBttn = PPPGPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

