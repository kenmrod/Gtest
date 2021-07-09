 
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
    public class OEPRFID_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Sales Order Entry Utilities", "xpath","//div[@class='navItem'][.='Sales Order Entry Utilities']").Click();
new SeleniumControl(sDriver,"Create RFID Print File", "xpath","//div[@class='navItem'][.='Create RFID Print File']").Click();


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
				Function.CurrentComponent = "OEPRFID";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPRFID] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEPRFID_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,OEPRFID_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPRFID";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPRFID] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl OEPRFID_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,OEPRFID_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPRFID";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPRFID] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEPRFID_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEPRFID_MainForm);
IWebElement formBttn = OEPRFID_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? OEPRFID_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
OEPRFID_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPRFID";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPRFID] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl OEPRFID_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEPRFID_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPRFID";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPRFID] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEPRFID_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEPRFID_MainForm);
IWebElement formBttn = OEPRFID_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? OEPRFID_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
OEPRFID_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPRFID";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPRFID] Performing Click on RFIDNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl OEPRFID_RFIDNonContiguousRangesLink = new SeleniumControl( sDriver, "RFIDNonContiguousRangesLink", "ID", "lnk_5339_OEPRFID_PARAM");
				Function.WaitControlDisplayed(OEPRFID_RFIDNonContiguousRangesLink);
OEPRFID_RFIDNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("RFIDNonContiguousRangesForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPRFID";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPRFID] Performing VerifyExists on RFIDNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OEPRFID_RFIDNonContiguousRangesForm = new SeleniumControl( sDriver, "RFIDNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPRFID_NCR_RFID_CD_']/ancestor::form[1]");
				Function.AssertEqual(true,OEPRFID_RFIDNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPRFID";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPRFID] Performing VerifyExist on RFIDNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl OEPRFID_RFIDNonContiguousRangesFormTable = new SeleniumControl( sDriver, "RFIDNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPRFID_NCR_RFID_CD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,OEPRFID_RFIDNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "OEPRFID";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPRFID] Performing Close on RFIDNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl OEPRFID_RFIDNonContiguousRangesForm = new SeleniumControl( sDriver, "RFIDNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__OEPRFID_NCR_RFID_CD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(OEPRFID_RFIDNonContiguousRangesForm);
IWebElement formBttn = OEPRFID_RFIDNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "OEPRFID";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[OEPRFID] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl OEPRFID_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(OEPRFID_MainForm);
IWebElement formBttn = OEPRFID_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

