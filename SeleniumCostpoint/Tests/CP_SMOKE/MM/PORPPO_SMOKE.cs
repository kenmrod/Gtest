 
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
    public class PORPPO_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Purchasing", "xpath","//div[@class='deptItem'][.='Purchasing']").Click();
new SeleniumControl(sDriver,"Purchase Orders", "xpath","//div[@class='navItem'][.='Purchase Orders']").Click();
new SeleniumControl(sDriver,"Print Purchase Orders", "xpath","//div[@class='navItem'][.='Print Purchase Orders']").Click();


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
				Function.CurrentComponent = "PORPPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PORPPO] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PORPPO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PORPPO_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PORPPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PORPPO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PORPPO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PORPPO_MainForm);
IWebElement formBttn = PORPPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PORPPO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PORPPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PORPPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PORPPO] Performing VerifyExist on MainForm_Table...", Logger.MessageType.INF);
				SeleniumControl PORPPO_MainForm_Table = new SeleniumControl( sDriver, "MainForm_Table", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PORPPO_MainForm_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PORPPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PORPPO] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PORPPO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PORPPO_MainForm);
IWebElement formBttn = PORPPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PORPPO_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PORPPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PORPPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PORPPO] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl PORPPO_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,PORPPO_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Purchase Order Non-Contiguous Ranges");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PORPPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PORPPO] Performing VerifyExists on PurchaseOrderNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PORPPO_PurchaseOrderNonContiguousRangesLink = new SeleniumControl( sDriver, "PurchaseOrderNonContiguousRangesLink", "ID", "lnk_2728_PORPPO_PARAM");
				Function.AssertEqual(true,PORPPO_PurchaseOrderNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PORPPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PORPPO] Performing Click on PurchaseOrderNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl PORPPO_PurchaseOrderNonContiguousRangesLink = new SeleniumControl( sDriver, "PurchaseOrderNonContiguousRangesLink", "ID", "lnk_2728_PORPPO_PARAM");
				Function.WaitControlDisplayed(PORPPO_PurchaseOrderNonContiguousRangesLink);
PORPPO_PurchaseOrderNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PORPPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PORPPO] Performing VerifyExists on PurchaseOrderNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl PORPPO_PurchaseOrderNonContiguousRangesForm = new SeleniumControl( sDriver, "PurchaseOrderNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PORPPO_NCR_POID_']/ancestor::form[1]");
				Function.AssertEqual(true,PORPPO_PurchaseOrderNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PORPPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PORPPO] Performing VerifyExist on PurchaseOrderNonContiguousRanges_Table...", Logger.MessageType.INF);
				SeleniumControl PORPPO_PurchaseOrderNonContiguousRanges_Table = new SeleniumControl( sDriver, "PurchaseOrderNonContiguousRanges_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__PORPPO_NCR_POID_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PORPPO_PurchaseOrderNonContiguousRanges_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PORPPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PORPPO] Performing Close on PurchaseOrderNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl PORPPO_PurchaseOrderNonContiguousRangesForm = new SeleniumControl( sDriver, "PurchaseOrderNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PORPPO_NCR_POID_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PORPPO_PurchaseOrderNonContiguousRangesForm);
IWebElement formBttn = PORPPO_PurchaseOrderNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PORPPO";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PORPPO] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PORPPO_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PORPPO_MainForm);
IWebElement formBttn = PORPPO_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

