 
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
    public class BLRRBIL_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Billing", "xpath","//div[@class='deptItem'][.='Billing']").Click();
new SeleniumControl(sDriver,"Standard Bills Processing", "xpath","//div[@class='navItem'][.='Standard Bills Processing']").Click();
new SeleniumControl(sDriver,"Print Retroactive Billing Worksheet", "xpath","//div[@class='navItem'][.='Print Retroactive Billing Worksheet']").Click();


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
				Function.CurrentComponent = "BLRRBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRRBIL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLRRBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLRRBIL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRRBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRRBIL] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl BLRRBIL_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,BLRRBIL_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRRBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRRBIL] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLRRBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLRRBIL_MainForm);
IWebElement formBttn = BLRRBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BLRRBIL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BLRRBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRRBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRRBIL] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BLRRBIL_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLRRBIL_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PROJECT NON-CONTIGUOUS RANGES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRRBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRRBIL] Performing VerifyExists on ProjectNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLRRBIL_ProjectNonContiguousRangesLink = new SeleniumControl( sDriver, "ProjectNonContiguousRangesLink", "ID", "lnk_2716_BLRRBIL_WFUNCPARMCATLG_HDR");
				Function.AssertEqual(true,BLRRBIL_ProjectNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRRBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRRBIL] Performing Click on ProjectNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLRRBIL_ProjectNonContiguousRangesLink = new SeleniumControl( sDriver, "ProjectNonContiguousRangesLink", "ID", "lnk_2716_BLRRBIL_WFUNCPARMCATLG_HDR");
				Function.WaitControlDisplayed(BLRRBIL_ProjectNonContiguousRangesLink);
BLRRBIL_ProjectNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRRBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRRBIL] Performing VerifyExist on ProjectNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl BLRRBIL_ProjectNonContiguousRangesFormTable = new SeleniumControl( sDriver, "ProjectNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLRRBIL_NONCONTIGUOUS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLRRBIL_ProjectNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRRBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRRBIL] Performing VerifyExists on ProjectNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLRRBIL_ProjectNonContiguousRangesForm = new SeleniumControl( sDriver, "ProjectNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLRRBIL_NONCONTIGUOUS_']/ancestor::form[1]");
				Function.AssertEqual(true,BLRRBIL_ProjectNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRRBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRRBIL] Performing Close on ProjectNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLRRBIL_ProjectNonContiguousRangesForm = new SeleniumControl( sDriver, "ProjectNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLRRBIL_NONCONTIGUOUS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLRRBIL_ProjectNonContiguousRangesForm);
IWebElement formBttn = BLRRBIL_ProjectNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRRBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRRBIL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLRRBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLRRBIL_MainForm);
IWebElement formBttn = BLRRBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

