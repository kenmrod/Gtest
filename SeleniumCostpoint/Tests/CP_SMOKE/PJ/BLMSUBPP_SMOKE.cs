 
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
    public class BLMSUBPP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Projects", "xpath","//div[@class='busItem'][.='Projects']").Click();
new SeleniumControl(sDriver,"Billing", "xpath","//div[@class='deptItem'][.='Billing']").Click();
new SeleniumControl(sDriver,"Billing History", "xpath","//div[@class='navItem'][.='Billing History']").Click();
new SeleniumControl(sDriver,"Manage Subcontractor Progress Payments", "xpath","//div[@class='navItem'][.='Manage Subcontractor Progress Payments']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("QUERY");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
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
				Function.CurrentComponent = "BLMSUBPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSUBPP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMSUBPP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLMSUBPP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSUBPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSUBPP] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl BLMSUBPP_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,BLMSUBPP_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSUBPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSUBPP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMSUBPP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMSUBPP_MainForm);
IWebElement formBttn = BLMSUBPP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BLMSUBPP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BLMSUBPP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSUBPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSUBPP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMSUBPP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMSUBPP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILD FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSUBPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSUBPP] Performing VerifyExist on InvoiceDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMSUBPP_InvoiceDetailsFormTable = new SeleniumControl( sDriver, "InvoiceDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMSUBPP_SUBCTRPRGPMT_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMSUBPP_InvoiceDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSUBPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSUBPP] Performing ClickButton on InvoiceDetailsForm...", Logger.MessageType.INF);
				SeleniumControl BLMSUBPP_InvoiceDetailsForm = new SeleniumControl( sDriver, "InvoiceDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMSUBPP_SUBCTRPRGPMT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLMSUBPP_InvoiceDetailsForm);
IWebElement formBttn = BLMSUBPP_InvoiceDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? BLMSUBPP_InvoiceDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
BLMSUBPP_InvoiceDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSUBPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSUBPP] Performing VerifyExists on InvoiceDetails_VoucherNumber...", Logger.MessageType.INF);
				SeleniumControl BLMSUBPP_InvoiceDetails_VoucherNumber = new SeleniumControl( sDriver, "InvoiceDetails_VoucherNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMSUBPP_SUBCTRPRGPMT_CHLD_']/ancestor::form[1]/descendant::*[@id='VCHR_NO']");
				Function.AssertEqual(true,BLMSUBPP_InvoiceDetails_VoucherNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILDFORM LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSUBPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSUBPP] Performing VerifyExists on InvoiceDetails_PaymentsLink...", Logger.MessageType.INF);
				SeleniumControl BLMSUBPP_InvoiceDetails_PaymentsLink = new SeleniumControl( sDriver, "InvoiceDetails_PaymentsLink", "ID", "lnk_1002481_BLMSUBPP_SUBCTRPRGPMT_CHLD");
				Function.AssertEqual(true,BLMSUBPP_InvoiceDetails_PaymentsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSUBPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSUBPP] Performing Click on InvoiceDetails_PaymentsLink...", Logger.MessageType.INF);
				SeleniumControl BLMSUBPP_InvoiceDetails_PaymentsLink = new SeleniumControl( sDriver, "InvoiceDetails_PaymentsLink", "ID", "lnk_1002481_BLMSUBPP_SUBCTRPRGPMT_CHLD");
				Function.WaitControlDisplayed(BLMSUBPP_InvoiceDetails_PaymentsLink);
BLMSUBPP_InvoiceDetails_PaymentsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLMSUBPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSUBPP] Performing VerifyExist on PaymentsFormTable...", Logger.MessageType.INF);
				SeleniumControl BLMSUBPP_PaymentsFormTable = new SeleniumControl( sDriver, "PaymentsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLMSUBPP_SUBCTRPRGPMTCHK_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLMSUBPP_PaymentsFormTable.Exists());

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
				Function.CurrentComponent = "BLMSUBPP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLMSUBPP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLMSUBPP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLMSUBPP_MainForm);
IWebElement formBttn = BLMSUBPP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

