 
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
    public class IWMSUSP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Inter-Company Work Orders", "xpath","//div[@class='deptItem'][.='Inter-Company Work Orders']").Click();
new SeleniumControl(sDriver,"Inter-Company Work Orders Interfaces", "xpath","//div[@class='navItem'][.='Inter-Company Work Orders Interfaces']").Click();
new SeleniumControl(sDriver,"Validate IWO Suspense Transactions", "xpath","//div[@class='navItem'][.='Validate IWO Suspense Transactions']").Click();


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
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Close...", Logger.MessageType.INF);
				SeleniumControl Query_Close = new SeleniumControl( sDriver, "Close", "ID", "closeQ");
				Function.WaitControlDisplayed(Query_Close);
if (Query_Close.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Close.Click(5,5);
else Query_Close.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMSUSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMSUSP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl IWMSUSP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,IWMSUSP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMSUSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMSUSP] Performing VerifyExists on IWONumber...", Logger.MessageType.INF);
				SeleniumControl IWMSUSP_IWONumber = new SeleniumControl( sDriver, "IWONumber", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='IWO_NO']");
				Function.AssertEqual(true,IWMSUSP_IWONumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMSUSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMSUSP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl IWMSUSP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(IWMSUSP_MainForm);
IWebElement formBttn = IWMSUSP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? IWMSUSP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
IWMSUSP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMSUSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMSUSP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl IWMSUSP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,IWMSUSP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("IWO Suspense Details");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMSUSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMSUSP] Performing VerifyExists on IWOSuspenseDetailsLink...", Logger.MessageType.INF);
				SeleniumControl IWMSUSP_IWOSuspenseDetailsLink = new SeleniumControl( sDriver, "IWOSuspenseDetailsLink", "ID", "lnk_1002457_IWMSUSP_IWOALLOCHDRSUSP_HDR");
				Function.AssertEqual(true,IWMSUSP_IWOSuspenseDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMSUSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMSUSP] Performing VerifyExist on IWOSuspenseDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl IWMSUSP_IWOSuspenseDetailsFormTable = new SeleniumControl( sDriver, "IWOSuspenseDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMSUSP_IWOALLOCTRNSUSP_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,IWMSUSP_IWOSuspenseDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMSUSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMSUSP] Performing ClickButton on IWOSuspenseDetailsForm...", Logger.MessageType.INF);
				SeleniumControl IWMSUSP_IWOSuspenseDetailsForm = new SeleniumControl( sDriver, "IWOSuspenseDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMSUSP_IWOALLOCTRNSUSP_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(IWMSUSP_IWOSuspenseDetailsForm);
IWebElement formBttn = IWMSUSP_IWOSuspenseDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? IWMSUSP_IWOSuspenseDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
IWMSUSP_IWOSuspenseDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMSUSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMSUSP] Performing VerifyExists on IWOSuspenseDetailsForm...", Logger.MessageType.INF);
				SeleniumControl IWMSUSP_IWOSuspenseDetailsForm = new SeleniumControl( sDriver, "IWOSuspenseDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMSUSP_IWOALLOCTRNSUSP_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,IWMSUSP_IWOSuspenseDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMSUSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMSUSP] Performing VerifyExists on IWOSuspenseDetails_Line...", Logger.MessageType.INF);
				SeleniumControl IWMSUSP_IWOSuspenseDetails_Line = new SeleniumControl( sDriver, "IWOSuspenseDetails_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMSUSP_IWOALLOCTRNSUSP_CHILD_']/ancestor::form[1]/descendant::*[@id='IWO_LN_NO']");
				Function.AssertEqual(true,IWMSUSP_IWOSuspenseDetails_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMSUSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMSUSP] Performing Close on IWOSuspenseDetailsForm...", Logger.MessageType.INF);
				SeleniumControl IWMSUSP_IWOSuspenseDetailsForm = new SeleniumControl( sDriver, "IWOSuspenseDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__IWMSUSP_IWOALLOCTRNSUSP_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(IWMSUSP_IWOSuspenseDetailsForm);
IWebElement formBttn = IWMSUSP_IWOSuspenseDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "IWMSUSP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[IWMSUSP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl IWMSUSP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(IWMSUSP_MainForm);
IWebElement formBttn = IWMSUSP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

