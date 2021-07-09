 
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
    public class LDMFCEIL_01_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Labor", "xpath","//div[@class='deptItem'][.='Labor']").Click();
new SeleniumControl(sDriver,"Union Information Controls", "xpath","//div[@class='navItem'][.='Union Information Controls']").Click();
new SeleniumControl(sDriver,"Manage Fringe Ceilings by Local", "xpath","//div[@class='navItem'][.='Manage Fringe Ceilings by Local']").Click();


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
				Function.CurrentComponent = "LDMFCEIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMFCEIL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMFCEIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDMFCEIL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMFCEIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMFCEIL] Performing VerifyExists on Local...", Logger.MessageType.INF);
				SeleniumControl LDMFCEIL_Local = new SeleniumControl( sDriver, "Local", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LOCAL_ID']");
				Function.AssertEqual(true,LDMFCEIL_Local.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMFCEIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMFCEIL] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMFCEIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMFCEIL_MainForm);
IWebElement formBttn = LDMFCEIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? LDMFCEIL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
LDMFCEIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMFCEIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMFCEIL] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMFCEIL_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMFCEIL_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMFCEIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMFCEIL] Performing VerifyExists on LocalFringeCeilingsForm...", Logger.MessageType.INF);
				SeleniumControl LDMFCEIL_LocalFringeCeilingsForm = new SeleniumControl( sDriver, "LocalFringeCeilingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMFCEIL_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMFCEIL_LocalFringeCeilingsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMFCEIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMFCEIL] Performing VerifyExist on LocalFringeCeilingsTable...", Logger.MessageType.INF);
				SeleniumControl LDMFCEIL_LocalFringeCeilingsTable = new SeleniumControl( sDriver, "LocalFringeCeilingsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMFCEIL_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMFCEIL_LocalFringeCeilingsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMFCEIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMFCEIL] Performing ClickButton on LocalFringeCeilingsForm...", Logger.MessageType.INF);
				SeleniumControl LDMFCEIL_LocalFringeCeilingsForm = new SeleniumControl( sDriver, "LocalFringeCeilingsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMFCEIL_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMFCEIL_LocalFringeCeilingsForm);
IWebElement formBttn = LDMFCEIL_LocalFringeCeilingsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? LDMFCEIL_LocalFringeCeilingsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
LDMFCEIL_LocalFringeCeilingsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMFCEIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMFCEIL] Performing VerifyExists on LocalFringeCeilingsForm_StartDate...", Logger.MessageType.INF);
				SeleniumControl LDMFCEIL_LocalFringeCeilingsForm_StartDate = new SeleniumControl( sDriver, "LocalFringeCeilingsForm_StartDate", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMFCEIL_CHILD_']/ancestor::form[1]/descendant::*[@id='START_DT']");
				Function.AssertEqual(true,LDMFCEIL_LocalFringeCeilingsForm_StartDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMFCEIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMFCEIL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMFCEIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMFCEIL_MainForm);
IWebElement formBttn = LDMFCEIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

