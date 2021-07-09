 
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
    public class HBMMFSA_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Employee", "xpath","//div[@class='deptItem'][.='Employee']").Click();
new SeleniumControl(sDriver,"Employee FSA/HSA Information", "xpath","//div[@class='navItem'][.='Employee FSA/HSA Information']").Click();
new SeleniumControl(sDriver,"Manage Employee Medical Care FSA Elections", "xpath","//div[@class='navItem'][.='Manage Employee Medical Care FSA Elections']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MAINFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMMFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMMFSA] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMMFSA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HBMMFSA_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMMFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMMFSA] Performing VerifyExists on Employee...", Logger.MessageType.INF);
				SeleniumControl HBMMFSA_Employee = new SeleniumControl( sDriver, "Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,HBMMFSA_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMMFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMMFSA] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMMFSA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMMFSA_MainForm);
IWebElement formBttn = HBMMFSA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HBMMFSA_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HBMMFSA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMMFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMMFSA] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HBMMFSA_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMMFSA_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Update Deduction Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMMFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMMFSA] Performing VerifyExists on UpdateDeductionLink...", Logger.MessageType.INF);
				SeleniumControl HBMMFSA_UpdateDeductionLink = new SeleniumControl( sDriver, "UpdateDeductionLink", "ID", "lnk_1005700_HBMMFSA_HBMEDFSAELEC_HDR");
				Function.AssertEqual(true,HBMMFSA_UpdateDeductionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMMFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMMFSA] Performing Click on UpdateDeductionLink...", Logger.MessageType.INF);
				SeleniumControl HBMMFSA_UpdateDeductionLink = new SeleniumControl( sDriver, "UpdateDeductionLink", "ID", "lnk_1005700_HBMMFSA_HBMEDFSAELEC_HDR");
				Function.WaitControlDisplayed(HBMMFSA_UpdateDeductionLink);
HBMMFSA_UpdateDeductionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMMFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMMFSA] Performing VerifyExists on UpdateDeductionForm...", Logger.MessageType.INF);
				SeleniumControl HBMMFSA_UpdateDeductionForm = new SeleniumControl( sDriver, "UpdateDeductionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMMFSA_HBMEDFSAELEC_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,HBMMFSA_UpdateDeductionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMMFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMMFSA] Performing VerifyExists on UpdateDeductionForm_PayCycle...", Logger.MessageType.INF);
				SeleniumControl HBMMFSA_UpdateDeductionForm_PayCycle = new SeleniumControl( sDriver, "UpdateDeductionForm_PayCycle", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMMFSA_HBMEDFSAELEC_CHLD_']/ancestor::form[1]/descendant::*[@id='PAY_PD_CD']");
				Function.AssertEqual(true,HBMMFSA_UpdateDeductionForm_PayCycle.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMMFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMMFSA] Performing Close on UpdateDeductionForm...", Logger.MessageType.INF);
				SeleniumControl HBMMFSA_UpdateDeductionForm = new SeleniumControl( sDriver, "UpdateDeductionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMMFSA_HBMEDFSAELEC_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HBMMFSA_UpdateDeductionForm);
IWebElement formBttn = HBMMFSA_UpdateDeductionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "HBMMFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMMFSA] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMMFSA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMMFSA_MainForm);
IWebElement formBttn = HBMMFSA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

