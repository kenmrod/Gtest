 
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
    public class APMMANCK_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Payment Processing", "xpath","//div[@class='navItem'][.='Payment Processing']").Click();
new SeleniumControl(sDriver,"Manage Manual Checks", "xpath","//div[@class='navItem'][.='Manage Manual Checks']").Click();


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
				Function.CurrentComponent = "APMMANCK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMMANCK] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl APMMANCK_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMMANCK_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMMANCK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMMANCK] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMMANCK_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMMANCK_MainForm);
IWebElement formBttn = APMMANCK_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMMANCK_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMMANCK_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMMANCK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMMANCK] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMMANCK_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APMMANCK_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMMANCK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMMANCK] Performing VerifyExists on Identification_PayVendor...", Logger.MessageType.INF);
				SeleniumControl APMMANCK_Identification_PayVendor = new SeleniumControl( sDriver, "Identification_PayVendor", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='VEND_ID']");
				Function.AssertEqual(true,APMMANCK_Identification_PayVendor.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("OPEN VOUCHERS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMMANCK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMMANCK] Performing VerifyExists on OpenVouchersForm...", Logger.MessageType.INF);
				SeleniumControl APMMANCK_OpenVouchersForm = new SeleniumControl( sDriver, "OpenVouchersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMMANCK_OPENAP_OPENVCHRS_']/ancestor::form[1]");
				Function.AssertEqual(true,APMMANCK_OpenVouchersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMMANCK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMMANCK] Performing VerifyExist on OpenVouchersFormTable...", Logger.MessageType.INF);
				SeleniumControl APMMANCK_OpenVouchersFormTable = new SeleniumControl( sDriver, "OpenVouchersFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMMANCK_OPENAP_OPENVCHRS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMMANCK_OpenVouchersFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SELECTED VOUCHERS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMMANCK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMMANCK] Performing VerifyExists on SelectedVouchersForm...", Logger.MessageType.INF);
				SeleniumControl APMMANCK_SelectedVouchersForm = new SeleniumControl( sDriver, "SelectedVouchersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMMANCK_OPENAP_SELECTEDVCHRS_']/ancestor::form[1]");
				Function.AssertEqual(true,APMMANCK_SelectedVouchersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMMANCK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMMANCK] Performing VerifyExist on SelectedVouchersFormTable...", Logger.MessageType.INF);
				SeleniumControl APMMANCK_SelectedVouchersFormTable = new SeleniumControl( sDriver, "SelectedVouchersFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMMANCK_OPENAP_SELECTEDVCHRS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMMANCK_SelectedVouchersFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "APMMANCK";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMMANCK] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMMANCK_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMMANCK_MainForm);
IWebElement formBttn = APMMANCK_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

