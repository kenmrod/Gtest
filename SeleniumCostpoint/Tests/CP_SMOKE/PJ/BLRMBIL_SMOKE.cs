 
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
    public class BLRMBIL_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Print Standard Bills", "xpath","//div[@class='navItem'][.='Print Standard Bills']").Click();


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
				Function.CurrentComponent = "BLRMBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRMBIL] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLRMBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,BLRMBIL_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRMBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRMBIL] Performing VerifyExists on ParameterID...", Logger.MessageType.INF);
				SeleniumControl BLRMBIL_ParameterID = new SeleniumControl( sDriver, "ParameterID", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PARM_ID']");
				Function.AssertEqual(true,BLRMBIL_ParameterID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRMBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRMBIL] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLRMBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLRMBIL_MainForm);
IWebElement formBttn = BLRMBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? BLRMBIL_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
BLRMBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRMBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRMBIL] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl BLRMBIL_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLRMBIL_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PROJECT NON CON RANGES");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRMBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRMBIL] Performing VerifyExists on ProjectNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl BLRMBIL_ProjectNonContiguousLink = new SeleniumControl( sDriver, "ProjectNonContiguousLink", "ID", "lnk_1004284_BLRMBIL_WFUNCPARMCATLG_HDR");
				Function.AssertEqual(true,BLRMBIL_ProjectNonContiguousLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRMBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRMBIL] Performing Click on ProjectNonContiguousLink...", Logger.MessageType.INF);
				SeleniumControl BLRMBIL_ProjectNonContiguousLink = new SeleniumControl( sDriver, "ProjectNonContiguousLink", "ID", "lnk_1004284_BLRMBIL_WFUNCPARMCATLG_HDR");
				Function.WaitControlDisplayed(BLRMBIL_ProjectNonContiguousLink);
BLRMBIL_ProjectNonContiguousLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRMBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRMBIL] Performing VerifyExists on ProjectNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl BLRMBIL_ProjectNonContiguousForm = new SeleniumControl( sDriver, "ProjectNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLRMBIL_NONCONTIGUOUS_']/ancestor::form[1]");
				Function.AssertEqual(true,BLRMBIL_ProjectNonContiguousForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRMBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRMBIL] Performing VerifyExist on ProjectNonContiguousLinkTable...", Logger.MessageType.INF);
				SeleniumControl BLRMBIL_ProjectNonContiguousLinkTable = new SeleniumControl( sDriver, "ProjectNonContiguousLinkTable", "xpath", "//div[translate(@id,'0123456789','')='pr__BLRMBIL_NONCONTIGUOUS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,BLRMBIL_ProjectNonContiguousLinkTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "BLRMBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRMBIL] Performing Close on ProjectNonContiguousForm...", Logger.MessageType.INF);
				SeleniumControl BLRMBIL_ProjectNonContiguousForm = new SeleniumControl( sDriver, "ProjectNonContiguousForm", "xpath", "//div[translate(@id,'0123456789','')='pr__BLRMBIL_NONCONTIGUOUS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(BLRMBIL_ProjectNonContiguousForm);
IWebElement formBttn = BLRMBIL_ProjectNonContiguousForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "BLRMBIL";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[BLRMBIL] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl BLRMBIL_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(BLRMBIL_MainForm);
IWebElement formBttn = BLRMBIL_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

