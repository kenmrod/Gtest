 
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
    public class PDMUOM_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Units of Measure", "xpath","//div[@class='navItem'][.='Manage Units of Measure']").Click();


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
				Function.CurrentComponent = "PDMUOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMUOM] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMUOM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PDMUOM_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMUOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMUOM] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMUOM_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMUOM_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMUOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMUOM] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMUOM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMUOM_MainForm);
IWebElement formBttn = PDMUOM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMUOM_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMUOM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMUOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMUOM] Performing VerifyExists on Description...", Logger.MessageType.INF);
				SeleniumControl PDMUOM_Description = new SeleniumControl( sDriver, "Description", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='UM_DESC']");
				Function.AssertEqual(true,PDMUOM_Description.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMUOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMUOM] Performing Click on ConversionLink...", Logger.MessageType.INF);
				SeleniumControl PDMUOM_ConversionLink = new SeleniumControl( sDriver, "ConversionLink", "ID", "lnk_3498_PDMUOM_UM");
				Function.WaitControlDisplayed(PDMUOM_ConversionLink);
PDMUOM_ConversionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ConversionForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMUOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMUOM] Performing VerifyExists on ConversionForm...", Logger.MessageType.INF);
				SeleniumControl PDMUOM_ConversionForm = new SeleniumControl( sDriver, "ConversionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMUOM_UMCONV_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMUOM_ConversionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMUOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMUOM] Performing VerifyExist on ConversionFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMUOM_ConversionFormTable = new SeleniumControl( sDriver, "ConversionFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMUOM_UMCONV_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMUOM_ConversionFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ToUnitOfMeasureForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMUOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMUOM] Performing VerifyExists on ToUnitOfMeasureForm...", Logger.MessageType.INF);
				SeleniumControl PDMUOM_ToUnitOfMeasureForm = new SeleniumControl( sDriver, "ToUnitOfMeasureForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMUOM_UM_AVAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMUOM_ToUnitOfMeasureForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMUOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMUOM] Performing VerifyExist on ToUnitOfMeasureFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMUOM_ToUnitOfMeasureFormTable = new SeleniumControl( sDriver, "ToUnitOfMeasureFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMUOM_UM_AVAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMUOM_ToUnitOfMeasureFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMUOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMUOM] Performing Click on ToUnitOfMeasure_Ok...", Logger.MessageType.INF);
				SeleniumControl PDMUOM_ToUnitOfMeasure_Ok = new SeleniumControl( sDriver, "ToUnitOfMeasure_Ok", "xpath", "//div[@class='app']/div[@id='0']/following::span[@class='layerSpan' and contains(@style,'block')]/descendant::input[@id='bOk']");
				Function.WaitControlDisplayed(PDMUOM_ToUnitOfMeasure_Ok);
if (PDMUOM_ToUnitOfMeasure_Ok.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PDMUOM_ToUnitOfMeasure_Ok.Click(5,5);
else PDMUOM_ToUnitOfMeasure_Ok.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
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
				Function.CurrentComponent = "PDMUOM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMUOM] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMUOM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMUOM_MainForm);
IWebElement formBttn = PDMUOM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

