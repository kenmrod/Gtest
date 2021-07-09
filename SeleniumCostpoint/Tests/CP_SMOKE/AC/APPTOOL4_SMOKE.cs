 
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
    public class APPTOOL4_SMOKE : SeleniumTestScript
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
								try
				{
				this.ScriptLogger.WriteLine("START");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"Accounts Payable", "xpath","//div[@class='deptItem'][.='Accounts Payable']").Click();
new SeleniumControl(sDriver,"Accounts Payable Utilities", "xpath","//div[@class='navItem'][.='Accounts Payable Utilities']").Click();
new SeleniumControl(sDriver,"Update Vendor Default Account Descriptions", "xpath","//div[@class='navItem'][.='Update Vendor Default Account Descriptions']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPTOOL4";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPTOOL4] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APPTOOL4_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APPTOOL4_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPTOOL4";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPTOOL4] Performing VerifyExists on Option_Vendor...", Logger.MessageType.INF);
				SeleniumControl APPTOOL4_Option_Vendor = new SeleniumControl( sDriver, "Option_Vendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VENDOR_RANGE']");
				Function.AssertEqual(true,APPTOOL4_Option_Vendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("VENDOR NON-CONTIGUOUS RANGES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPTOOL4";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPTOOL4] Performing Click on VendorNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl APPTOOL4_VendorNonContiguousRangesLink = new SeleniumControl( sDriver, "VendorNonContiguousRangesLink", "ID", "lnk_3683_APPTOOL4_VENDDFLTACC_HDR");
				Function.WaitControlDisplayed(APPTOOL4_VendorNonContiguousRangesLink);
APPTOOL4_VendorNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPTOOL4";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPTOOL4] Performing VerifyExists on VendorNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl APPTOOL4_VendorNonContiguousRangesForm = new SeleniumControl( sDriver, "VendorNonContiguousRangesForm", "xpath", "//div[starts-with(@id,'pr__APPTOOL4_NCRVENDID_')]/ancestor::form[1]");
				Function.AssertEqual(true,APPTOOL4_VendorNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPTOOL4";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPTOOL4] Performing VerifyExist on VendorNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl APPTOOL4_VendorNonContiguousRangesFormTable = new SeleniumControl( sDriver, "VendorNonContiguousRangesFormTable", "xpath", "//div[starts-with(@id,'pr__APPTOOL4_NCRVENDID_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APPTOOL4_VendorNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPTOOL4";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPTOOL4] Performing Close on VendorNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl APPTOOL4_VendorNonContiguousRangesForm = new SeleniumControl( sDriver, "VendorNonContiguousRangesForm", "xpath", "//div[starts-with(@id,'pr__APPTOOL4_NCRVENDID_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(APPTOOL4_VendorNonContiguousRangesForm);
IWebElement formBttn = APPTOOL4_VendorNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APPTOOL4";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APPTOOL4] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APPTOOL4_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APPTOOL4_MainForm);
IWebElement formBttn = APPTOOL4_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

