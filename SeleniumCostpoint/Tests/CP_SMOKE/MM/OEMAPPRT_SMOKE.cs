 
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
    public class OEMAPPRT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Sales Order Entry Controls", "xpath","//div[@class='navItem'][.='Sales Order Entry Controls']").Click();
new SeleniumControl(sDriver,"Manage Sales Order Approval Titles", "xpath","//div[@class='navItem'][.='Manage Sales Order Approval Titles']").Click();


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
				Function.CurrentComponent = "OEMAPPRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEMAPPRT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRT] Performing VerifyExists on ApprovalTitleCode...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRT_ApprovalTitleCode = new SeleniumControl( sDriver, "ApprovalTitleCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='OE_APPR_TITLE_DC']");
				Function.AssertEqual(true,OEMAPPRT_ApprovalTitleCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMAPPRT_MainForm);
IWebElement formBttn = OEMAPPRT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEMAPPRT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEMAPPRT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPRT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Childform");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRT] Performing VerifyExist on ApproverDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRT_ApproverDetailsFormTable = new SeleniumControl( sDriver, "ApproverDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPRT_CHILD_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEMAPPRT_ApproverDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRT] Performing ClickButton on ApproverDetailsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRT_ApproverDetailsForm = new SeleniumControl( sDriver, "ApproverDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPRT_CHILD_TBL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEMAPPRT_ApproverDetailsForm);
IWebElement formBttn = OEMAPPRT_ApproverDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEMAPPRT_ApproverDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEMAPPRT_ApproverDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRT] Performing VerifyExists on ApproverDetailsForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRT_ApproverDetailsForm = new SeleniumControl( sDriver, "ApproverDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPRT_CHILD_TBL_']/ancestor::form[1]");
				Function.AssertEqual(true,OEMAPPRT_ApproverDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRT] Performing VerifyExists on ApproverDetails_PreferredSequence...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRT_ApproverDetails_PreferredSequence = new SeleniumControl( sDriver, "ApproverDetails_PreferredSequence", "xpath", "//div[translate(@id,'0123456789','')='pr__OEMAPPRT_CHILD_TBL_']/ancestor::form[1]/descendant::*[@id='PREF_SEQ_NO']");
				Function.AssertEqual(true,OEMAPPRT_ApproverDetails_PreferredSequence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEMAPPRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEMAPPRT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEMAPPRT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEMAPPRT_MainForm);
IWebElement formBttn = OEMAPPRT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

