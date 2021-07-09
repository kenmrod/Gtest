 
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
    public class BLRACRN_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Print ACRN Billing Edit Report", "xpath","//div[@class='navItem'][.='Print ACRN Billing Edit Report']").Click();


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
				Function.CurrentComponent = "BLRACRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRACRN] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLRACRN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLRACRN_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRACRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRACRN] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl BLRACRN_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,BLRACRN_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRACRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRACRN] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLRACRN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLRACRN_MainForm);
IWebElement formBttn = BLRACRN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BLRACRN_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BLRACRN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRACRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRACRN] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BLRACRN_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLRACRN_MainFormTable.Exists());

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
				Function.CurrentComponent = "BLRACRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRACRN] Performing VerifyExists on ProjectACRNNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLRACRN_ProjectACRNNonContiguousRangesLink = new SeleniumControl( sDriver, "ProjectACRNNonContiguousRangesLink", "ID", "lnk_3193_BLRACRN_PARAM");
				Function.AssertEqual(true,BLRACRN_ProjectACRNNonContiguousRangesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRACRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRACRN] Performing Click on ProjectACRNNonContiguousRangesLink...", Logger.MessageType.INF);
				SeleniumControl BLRACRN_ProjectACRNNonContiguousRangesLink = new SeleniumControl( sDriver, "ProjectACRNNonContiguousRangesLink", "ID", "lnk_3193_BLRACRN_PARAM");
				Function.WaitControlDisplayed(BLRACRN_ProjectACRNNonContiguousRangesLink);
BLRACRN_ProjectACRNNonContiguousRangesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRACRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRACRN] Performing VerifyExist on ProjectACRNNonContiguousRangesFormTable...", Logger.MessageType.INF);
				SeleniumControl BLRACRN_ProjectACRNNonContiguousRangesFormTable = new SeleniumControl( sDriver, "ProjectACRNNonContiguousRangesFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLRACRN_NONCONTIGUOUS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLRACRN_ProjectACRNNonContiguousRangesFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRACRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRACRN] Performing VerifyExists on ProjectACRNNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLRACRN_ProjectACRNNonContiguousRangesForm = new SeleniumControl( sDriver, "ProjectACRNNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLRACRN_NONCONTIGUOUS_']/ancestor::form[1]");
				Function.AssertEqual(true,BLRACRN_ProjectACRNNonContiguousRangesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRACRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRACRN] Performing VerifyExists on ProjectACRNNonContiguousRanges_Ok...", Logger.MessageType.INF);
				SeleniumControl BLRACRN_ProjectACRNNonContiguousRanges_Ok = new SeleniumControl( sDriver, "ProjectACRNNonContiguousRanges_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__BLRACRN_NONCONTIGUOUS_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.AssertEqual(true,BLRACRN_ProjectACRNNonContiguousRanges_Ok.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRACRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRACRN] Performing Close on ProjectACRNNonContiguousRangesForm...", Logger.MessageType.INF);
				SeleniumControl BLRACRN_ProjectACRNNonContiguousRangesForm = new SeleniumControl( sDriver, "ProjectACRNNonContiguousRangesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLRACRN_NONCONTIGUOUS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLRACRN_ProjectACRNNonContiguousRangesForm);
IWebElement formBttn = BLRACRN_ProjectACRNNonContiguousRangesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLRACRN";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRACRN] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLRACRN_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLRACRN_MainForm);
IWebElement formBttn = BLRACRN_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

