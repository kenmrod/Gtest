 
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
    public class ARPPADJ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounts Receivable", "xpath","//div[@class='deptItem'][.='Accounts Receivable']").Click();
new SeleniumControl(sDriver,"Cash Receipts Processing", "xpath","//div[@class='navItem'][.='Cash Receipts Processing']").Click();
new SeleniumControl(sDriver,"Edit/Manage A/R Underpayment Amounts", "xpath","//div[@class='navItem'][.='Edit/Manage A/R Underpayment Amounts']").Click();


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
				Function.CurrentComponent = "ARPPADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARPPADJ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARPPADJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,ARPPADJ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARPPADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARPPADJ] Performing VerifyExists on CustomerAccount...", Logger.MessageType.INF);
				SeleniumControl ARPPADJ_CustomerAccount = new SeleniumControl( sDriver, "CustomerAccount", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ACCT']");
				Function.AssertEqual(true,ARPPADJ_CustomerAccount.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARPPADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARPPADJ] Performing Set on CustomerAccount...", Logger.MessageType.INF);
				SeleniumControl ARPPADJ_CustomerAccount = new SeleniumControl( sDriver, "CustomerAccount", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ACCT']");
				ARPPADJ_CustomerAccount.Click();
ARPPADJ_CustomerAccount.SendKeys("1", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
ARPPADJ_CustomerAccount.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARPPADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARPPADJ] Performing VerifyText on CustomerAccount...", Logger.MessageType.INF);
				SeleniumControl ARPPADJ_CustomerAccount = new SeleniumControl( sDriver, "CustomerAccount", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CUST_ACCT']");
				Function.AssertEqual("1",ARPPADJ_CustomerAccount.GetAttributeValue("value"));


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyText]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARPPADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARPPADJ] Performing VerifyExist on AdjustmentInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl ARPPADJ_AdjustmentInfoFormTable = new SeleniumControl( sDriver, "AdjustmentInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__ARPPADJ_TABLE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,ARPPADJ_AdjustmentInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARPPADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARPPADJ] Performing ClickButton on AdjustmentInfoForm...", Logger.MessageType.INF);
				SeleniumControl ARPPADJ_AdjustmentInfoForm = new SeleniumControl( sDriver, "AdjustmentInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARPPADJ_TABLE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(ARPPADJ_AdjustmentInfoForm);
IWebElement formBttn = ARPPADJ_AdjustmentInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? ARPPADJ_AdjustmentInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
ARPPADJ_AdjustmentInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARPPADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARPPADJ] Performing VerifyExists on AdjustmentInfoForm...", Logger.MessageType.INF);
				SeleniumControl ARPPADJ_AdjustmentInfoForm = new SeleniumControl( sDriver, "AdjustmentInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__ARPPADJ_TABLE_']/ancestor::form[1]");
				Function.AssertEqual(true,ARPPADJ_AdjustmentInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "ARPPADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARPPADJ] Performing VerifyExists on AdjustmentInfo_InvoiceNumber...", Logger.MessageType.INF);
				SeleniumControl ARPPADJ_AdjustmentInfo_InvoiceNumber = new SeleniumControl( sDriver, "AdjustmentInfo_InvoiceNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__ARPPADJ_TABLE_']/ancestor::form[1]/descendant::*[@id='INVC_ID']");
				Function.AssertEqual(true,ARPPADJ_AdjustmentInfo_InvoiceNumber.Exists());

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
				Function.CurrentComponent = "ARPPADJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[ARPPADJ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl ARPPADJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(ARPPADJ_MainForm);
IWebElement formBttn = ARPPADJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

