 
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
    public class PRMEIC_SMOKE : SeleniumTestScript
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
								try
				{
				this.ScriptLogger.WriteLine("START");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Payroll", "xpath","//div[@class='deptItem'][.='Payroll']").Click();
new SeleniumControl(sDriver,"Federal Taxes", "xpath","//div[@class='navItem'][.='Federal Taxes']").Click();
new SeleniumControl(sDriver,"Manage Advance Earned Income Credit Tables", "xpath","//div[@class='navItem'][.='Manage Advance Earned Income Credit Tables']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEIC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMEIC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMEIC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEIC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMEIC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMEIC_MainForm);
IWebElement formBttn = PRMEIC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMEIC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMEIC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEIC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMEIC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMEIC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEIC] Performing Click on AdvanceEarnedIncomeCreditAndNonresidentAlienTableLink...", Logger.MessageType.INF);
				SeleniumControl PRMEIC_AdvanceEarnedIncomeCreditAndNonresidentAlienTableLink = new SeleniumControl( sDriver, "AdvanceEarnedIncomeCreditAndNonresidentAlienTableLink", "ID", "lnk_1001147_PRMEIC_EICTAXTBL_HDR");
				Function.WaitControlDisplayed(PRMEIC_AdvanceEarnedIncomeCreditAndNonresidentAlienTableLink);
PRMEIC_AdvanceEarnedIncomeCreditAndNonresidentAlienTableLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEIC] Performing VerifyExists on AdvanceEarnedIncomeCreditAndNonresidentAlienTableForm...", Logger.MessageType.INF);
				SeleniumControl PRMEIC_AdvanceEarnedIncomeCreditAndNonresidentAlienTableForm = new SeleniumControl( sDriver, "AdvanceEarnedIncomeCreditAndNonresidentAlienTableForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMEIC_EICTAXTBL_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMEIC_AdvanceEarnedIncomeCreditAndNonresidentAlienTableForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEIC] Performing VerifyExist on AdvanceEarnedIncomeCreditAndNonresidentAlienTableFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMEIC_AdvanceEarnedIncomeCreditAndNonresidentAlienTableFormTable = new SeleniumControl( sDriver, "AdvanceEarnedIncomeCreditAndNonresidentAlienTableFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMEIC_EICTAXTBL_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMEIC_AdvanceEarnedIncomeCreditAndNonresidentAlienTableFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEIC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEIC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMEIC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMEIC_MainForm);
IWebElement formBttn = PRMEIC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

