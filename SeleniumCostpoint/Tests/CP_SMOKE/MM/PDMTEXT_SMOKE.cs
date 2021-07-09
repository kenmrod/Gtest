 
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
    public class PDMTEXT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Product Definition", "xpath","//div[@class='deptItem'][.='Product Definition']").Click();
new SeleniumControl(sDriver,"Product Definition Controls", "xpath","//div[@class='navItem'][.='Product Definition Controls']").Click();
new SeleniumControl(sDriver,"Manage Standard Text", "xpath","//div[@class='navItem'][.='Manage Standard Text']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMTEXT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMTEXT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PDMTEXT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMTEXT] Performing VerifyExists on StandardTextCode...", Logger.MessageType.INF);
				SeleniumControl PDMTEXT_StandardTextCode = new SeleniumControl( sDriver, "StandardTextCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TEXT_CD']");
				Function.AssertEqual(true,PDMTEXT_StandardTextCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMTEXT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMTEXT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMTEXT_MainForm);
IWebElement formBttn = PDMTEXT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PDMTEXT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PDMTEXT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMTEXT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMTEXT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMTEXT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Where-Used");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMTEXT] Performing VerifyExists on WhereUsedLink...", Logger.MessageType.INF);
				SeleniumControl PDMTEXT_WhereUsedLink = new SeleniumControl( sDriver, "WhereUsedLink", "ID", "lnk_1002174_PDMTEXT_STD_TEXT_HDR");
				Function.AssertEqual(true,PDMTEXT_WhereUsedLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMTEXT] Performing Click on WhereUsedLink...", Logger.MessageType.INF);
				SeleniumControl PDMTEXT_WhereUsedLink = new SeleniumControl( sDriver, "WhereUsedLink", "ID", "lnk_1002174_PDMTEXT_STD_TEXT_HDR");
				Function.WaitControlDisplayed(PDMTEXT_WhereUsedLink);
PDMTEXT_WhereUsedLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMTEXT] Performing VerifyExist on WhereUsedCodeFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMTEXT_WhereUsedCodeFormTable = new SeleniumControl( sDriver, "WhereUsedCodeFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMTEXT_TEXTWHEREUSED_SELWHER_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMTEXT_WhereUsedCodeFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMTEXT] Performing VerifyExists on WhereUsedCodeForm...", Logger.MessageType.INF);
				SeleniumControl PDMTEXT_WhereUsedCodeForm = new SeleniumControl( sDriver, "WhereUsedCodeForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMTEXT_TEXTWHEREUSED_SELWHER_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMTEXT_WhereUsedCodeForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMTEXT] Performing VerifyExist on WhereUsedDescriptionFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMTEXT_WhereUsedDescriptionFormTable = new SeleniumControl( sDriver, "WhereUsedDescriptionFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMTEXT_SWHEREUSED_WHEREUSED_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMTEXT_WhereUsedDescriptionFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMTEXT] Performing VerifyExists on WhereUsedDescriptionForm...", Logger.MessageType.INF);
				SeleniumControl PDMTEXT_WhereUsedDescriptionForm = new SeleniumControl( sDriver, "WhereUsedDescriptionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMTEXT_SWHEREUSED_WHEREUSED_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMTEXT_WhereUsedDescriptionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close the application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMTEXT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMTEXT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMTEXT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMTEXT_MainForm);
IWebElement formBttn = PDMTEXT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

