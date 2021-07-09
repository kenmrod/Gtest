 
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
    public class APMVENDA_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"Accounts Payable", "xpath","//div[@class='deptItem'][.='Accounts Payable']").Click();
new SeleniumControl(sDriver,"Vendors", "xpath","//div[@class='navItem'][.='Vendors']").Click();
new SeleniumControl(sDriver,"Approve Vendors", "xpath","//div[@class='navItem'][.='Approve Vendors']").Click();


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
				Function.CurrentComponent = "APMVENDA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDA] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APMVENDA_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDA] Performing VerifyExists on ApproveAll...", Logger.MessageType.INF);
				SeleniumControl APMVENDA_ApproveAll = new SeleniumControl( sDriver, "ApproveAll", "xpath", "//div[@id='0']/form[1]/descendant::*[contains(@id,'APPRV_ALL') and contains(@style,'visible')]");
				Function.AssertEqual(true,APMVENDA_ApproveAll.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDA] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl APMVENDA_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMVENDA_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PAY VENDOR");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDA] Performing VerifyExists on PayVendorForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDA_PayVendorForm = new SeleniumControl( sDriver, "PayVendorForm", "xpath", "//div[translate(@id,'0123456789','')='ph__APMVENDA_PAYVEND_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,APMVENDA_PayVendorForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDA] Performing VerifyExists on ChildForm_PayVendor_PayVendor...", Logger.MessageType.INF);
				SeleniumControl APMVENDA_ChildForm_PayVendor_PayVendor = new SeleniumControl( sDriver, "ChildForm_PayVendor_PayVendor", "xpath", "//div[translate(@id,'0123456789','')='pr__APMVENDA_PAYVEND_CTW_']/ancestor::form[1]/descendant::*[@id='PAY_VEND']");
				Function.AssertEqual(true,APMVENDA_ChildForm_PayVendor_PayVendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMVENDA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMVENDA] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMVENDA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMVENDA_MainForm);
IWebElement formBttn = APMVENDA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

