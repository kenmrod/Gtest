 
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
    public class PRMPAYTT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Payroll", "xpath","//div[@class='deptItem'][.='Payroll']").Click();
new SeleniumControl(sDriver,"Payroll Controls", "xpath","//div[@class='navItem'][.='Payroll Controls']").Click();
new SeleniumControl(sDriver,"Manage Pay Type Taxability", "xpath","//div[@class='navItem'][.='Manage Pay Type Taxability']").Click();


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
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMPAYTT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing VerifyExists on PayTypeCode...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_PayTypeCode = new SeleniumControl( sDriver, "PayTypeCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PAY_TYPE']");
				Function.AssertEqual(true,PRMPAYTT_PayTypeCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMPAYTT_MainForm);
IWebElement formBttn = PRMPAYTT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMPAYTT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMPAYTT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPAYTT_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("State Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing VerifyExists on StateLink...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_StateLink = new SeleniumControl( sDriver, "StateLink", "ID", "lnk_1001266_PRMPAYTT_PAYTYPE_HDR");
				Function.AssertEqual(true,PRMPAYTT_StateLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing Click on StateLink...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_StateLink = new SeleniumControl( sDriver, "StateLink", "ID", "lnk_1001266_PRMPAYTT_PAYTYPE_HDR");
				Function.WaitControlDisplayed(PRMPAYTT_StateLink);
PRMPAYTT_StateLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing VerifyExists on StateForm...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_StateForm = new SeleniumControl( sDriver, "StateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPAYTT_STATE_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPAYTT_StateForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing VerifyExist on StateTable...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_StateTable = new SeleniumControl( sDriver, "StateTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPAYTT_STATE_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPAYTT_StateTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing Close on StateForm...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_StateForm = new SeleniumControl( sDriver, "StateForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPAYTT_STATE_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPAYTT_StateForm);
IWebElement formBttn = PRMPAYTT_StateForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Local Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing VerifyExists on LocalLink...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_LocalLink = new SeleniumControl( sDriver, "LocalLink", "ID", "lnk_1002291_PRMPAYTT_PAYTYPE_HDR");
				Function.AssertEqual(true,PRMPAYTT_LocalLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing Click on LocalLink...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_LocalLink = new SeleniumControl( sDriver, "LocalLink", "ID", "lnk_1002291_PRMPAYTT_PAYTYPE_HDR");
				Function.WaitControlDisplayed(PRMPAYTT_LocalLink);
PRMPAYTT_LocalLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing VerifyExists on LocalForm...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_LocalForm = new SeleniumControl( sDriver, "LocalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPAYTT_LOCAL_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMPAYTT_LocalForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing VerifyExist on LocalTable...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_LocalTable = new SeleniumControl( sDriver, "LocalTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPAYTT_LOCAL_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMPAYTT_LocalTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing Close on LocalForm...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_LocalForm = new SeleniumControl( sDriver, "LocalForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMPAYTT_LOCAL_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMPAYTT_LocalForm);
IWebElement formBttn = PRMPAYTT_LocalForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "PRMPAYTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMPAYTT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMPAYTT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMPAYTT_MainForm);
IWebElement formBttn = PRMPAYTT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

