 
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
    public class APMCISVH_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage CIS Voucher History", "xpath","//div[@class='navItem'][.='Manage CIS Voucher History']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAIN TABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCISVH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCISVH] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMCISVH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,APMCISVH_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCISVH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCISVH] Performing VerifyExists on SelectEntityID_TaxEntityID...", Logger.MessageType.INF);
				SeleniumControl APMCISVH_SelectEntityID_TaxEntityID = new SeleniumControl( sDriver, "SelectEntityID_TaxEntityID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TAXBLE_ENTITY_ID']");
				Function.AssertEqual(true,APMCISVH_SelectEntityID_TaxEntityID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCISVH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCISVH] Performing VerifyExist on CISVendorInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl APMCISVH_CISVendorInformationFormTable = new SeleniumControl( sDriver, "CISVendorInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__APMCISVH_VENDCISHS_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,APMCISVH_CISVendorInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCISVH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCISVH] Performing ClickButton on CISVendorInformationForm...", Logger.MessageType.INF);
				SeleniumControl APMCISVH_CISVendorInformationForm = new SeleniumControl( sDriver, "CISVendorInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMCISVH_VENDCISHS_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(APMCISVH_CISVendorInformationForm);
IWebElement formBttn = APMCISVH_CISVendorInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? APMCISVH_CISVendorInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
APMCISVH_CISVendorInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCISVH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCISVH] Performing VerifyExists on CISVendorInformationForm...", Logger.MessageType.INF);
				SeleniumControl APMCISVH_CISVendorInformationForm = new SeleniumControl( sDriver, "CISVendorInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__APMCISVH_VENDCISHS_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,APMCISVH_CISVendorInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "APMCISVH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCISVH] Performing VerifyExists on CISVendorInformtaion_CISDetails_CISVoucher...", Logger.MessageType.INF);
				SeleniumControl APMCISVH_CISVendorInformtaion_CISDetails_CISVoucher = new SeleniumControl( sDriver, "CISVendorInformtaion_CISDetails_CISVoucher", "xpath", "//div[translate(@id,'0123456789','')='pr__APMCISVH_VENDCISHS_CTW_']/ancestor::form[1]/descendant::*[@id='CIS_VCHR_NO']");
				Function.AssertEqual(true,APMCISVH_CISVendorInformtaion_CISDetails_CISVoucher.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "APMCISVH";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[APMCISVH] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl APMCISVH_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(APMCISVH_MainForm);
IWebElement formBttn = APMCISVH_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

