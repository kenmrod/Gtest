 
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
    public class PCPMRR_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Production Control", "xpath","//div[@class='deptItem'][.='Production Control']").Click();
new SeleniumControl(sDriver,"Materials Planning", "xpath","//div[@class='navItem'][.='Materials Planning']").Click();
new SeleniumControl(sDriver,"Compute Material Requirements", "xpath","//div[@class='navItem'][.='Compute Material Requirements']").Click();


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
				Function.CurrentComponent = "PCPMRR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCPMRR] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCPMRR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PCPMRR_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCPMRR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCPMRR] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl PCPMRR_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,PCPMRR_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCPMRR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCPMRR] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCPMRR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCPMRR_MainForm);
IWebElement formBttn = PCPMRR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCPMRR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCPMRR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCPMRR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCPMRR] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PCPMRR_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCPMRR_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("EndPartsForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCPMRR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCPMRR] Performing VerifyExists on EndPartsLink...", Logger.MessageType.INF);
				SeleniumControl PCPMRR_EndPartsLink = new SeleniumControl( sDriver, "EndPartsLink", "ID", "lnk_1004746_PCPMRR_PARAM");
				Function.AssertEqual(true,PCPMRR_EndPartsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCPMRR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCPMRR] Performing Click on EndPartsLink...", Logger.MessageType.INF);
				SeleniumControl PCPMRR_EndPartsLink = new SeleniumControl( sDriver, "EndPartsLink", "ID", "lnk_1004746_PCPMRR_PARAM");
				Function.WaitControlDisplayed(PCPMRR_EndPartsLink);
PCPMRR_EndPartsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCPMRR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCPMRR] Performing VerifyExists on EndPartsForm...", Logger.MessageType.INF);
				SeleniumControl PCPMRR_EndPartsForm = new SeleniumControl( sDriver, "EndPartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCPMRR_PARMSPCPMRR_ENDPART_']/ancestor::form[1]");
				Function.AssertEqual(true,PCPMRR_EndPartsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCPMRR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCPMRR] Performing VerifyExists on EndParts_Part...", Logger.MessageType.INF);
				SeleniumControl PCPMRR_EndParts_Part = new SeleniumControl( sDriver, "EndParts_Part", "xpath", "//div[translate(@id,'0123456789','')='pr__PCPMRR_PARMSPCPMRR_ENDPART_']/ancestor::form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,PCPMRR_EndParts_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCPMRR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCPMRR] Performing ClickButton on EndPartsForm...", Logger.MessageType.INF);
				SeleniumControl PCPMRR_EndPartsForm = new SeleniumControl( sDriver, "EndPartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCPMRR_PARMSPCPMRR_ENDPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCPMRR_EndPartsForm);
IWebElement formBttn = PCPMRR_EndPartsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PCPMRR_EndPartsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PCPMRR_EndPartsForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCPMRR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCPMRR] Performing VerifyExist on EndPartsFormTable...", Logger.MessageType.INF);
				SeleniumControl PCPMRR_EndPartsFormTable = new SeleniumControl( sDriver, "EndPartsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PCPMRR_PARMSPCPMRR_ENDPART_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PCPMRR_EndPartsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PCPMRR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCPMRR] Performing Close on EndPartsForm...", Logger.MessageType.INF);
				SeleniumControl PCPMRR_EndPartsForm = new SeleniumControl( sDriver, "EndPartsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PCPMRR_PARMSPCPMRR_ENDPART_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PCPMRR_EndPartsForm);
IWebElement formBttn = PCPMRR_EndPartsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PCPMRR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PCPMRR] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PCPMRR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PCPMRR_MainForm);
IWebElement formBttn = PCPMRR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

