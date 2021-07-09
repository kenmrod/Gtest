 
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
    public class PJM533FM_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"NASA 533s", "xpath","//div[@class='deptItem'][.='NASA 533s']").Click();
new SeleniumControl(sDriver,"NASA 533 Processing", "xpath","//div[@class='navItem'][.='NASA 533 Processing']").Click();
new SeleniumControl(sDriver,"Manage NASA 533 Formats", "xpath","//div[@class='navItem'][.='Manage NASA 533 Formats']").Click();


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
				Function.CurrentComponent = "PJM533FM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJM533FM] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJM533FM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJM533FM_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJM533FM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJM533FM] Performing VerifyExists on Format...", Logger.MessageType.INF);
				SeleniumControl PJM533FM_Format = new SeleniumControl( sDriver, "Format", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='NASA_FRMT_CD']");
				Function.AssertEqual(true,PJM533FM_Format.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJM533FM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJM533FM] Performing VerifyExists on LineDetailsLink...", Logger.MessageType.INF);
				SeleniumControl PJM533FM_LineDetailsLink = new SeleniumControl( sDriver, "LineDetailsLink", "ID", "lnk_1001151_PJM533FM_NASAFRMT_HDR");
				Function.AssertEqual(true,PJM533FM_LineDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJM533FM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJM533FM] Performing Click on LineDetailsLink...", Logger.MessageType.INF);
				SeleniumControl PJM533FM_LineDetailsLink = new SeleniumControl( sDriver, "LineDetailsLink", "ID", "lnk_1001151_PJM533FM_NASAFRMT_HDR");
				Function.WaitControlDisplayed(PJM533FM_LineDetailsLink);
PJM533FM_LineDetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJM533FM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJM533FM] Performing VerifyExist on LineDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJM533FM_LineDetailsFormTable = new SeleniumControl( sDriver, "LineDetailsFormTable", "xpath", "//div[starts-with(@id,'pr__PJM533FM_NASAFRMT_CHLD_')]/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJM533FM_LineDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJM533FM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJM533FM] Performing ClickButton on LineDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJM533FM_LineDetailsForm = new SeleniumControl( sDriver, "LineDetailsForm", "xpath", "//div[starts-with(@id,'pr__PJM533FM_NASAFRMT_CHLD_')]/ancestor::form[1]");
				Function.WaitControlDisplayed(PJM533FM_LineDetailsForm);
IWebElement formBttn = PJM533FM_LineDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJM533FM_LineDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJM533FM_LineDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJM533FM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJM533FM] Performing VerifyExists on LineDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJM533FM_LineDetailsForm = new SeleniumControl( sDriver, "LineDetailsForm", "xpath", "//div[starts-with(@id,'pr__PJM533FM_NASAFRMT_CHLD_')]/ancestor::form[1]");
				Function.AssertEqual(true,PJM533FM_LineDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJM533FM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJM533FM] Performing VerifyExists on LineDetails_LineType...", Logger.MessageType.INF);
				SeleniumControl PJM533FM_LineDetails_LineType = new SeleniumControl( sDriver, "LineDetails_LineType", "xpath", "//div[starts-with(@id,'pr__PJM533FM_NASAFRMT_CHLD_')]/ancestor::form[1]/descendant::*[@id='S_NASA_FM_LN_TYPE']");
				Function.AssertEqual(true,PJM533FM_LineDetails_LineType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFOrMTABLE");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJM533FM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJM533FM] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJM533FM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJM533FM_MainForm);
IWebElement formBttn = PJM533FM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJM533FM_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJM533FM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJM533FM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJM533FM] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJM533FM_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJM533FM_MainFormTable.Exists());

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
				Function.CurrentComponent = "PJM533FM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJM533FM] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJM533FM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJM533FM_MainForm);
IWebElement formBttn = PJM533FM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

