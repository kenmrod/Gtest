 
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
    public class HBMEFSA_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Employee Dependent Care FSA Elections", "xpath","//div[@class='navItem'][.='Manage Employee Dependent Care FSA Elections']").Click();


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
				Function.CurrentComponent = "HBMEFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEFSA] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMEFSA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HBMEFSA_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEFSA] Performing VerifyExists on Employee...", Logger.MessageType.INF);
				SeleniumControl HBMEFSA_Employee = new SeleniumControl( sDriver, "Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,HBMEFSA_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEFSA] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMEFSA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMEFSA_MainForm);
IWebElement formBttn = HBMEFSA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HBMEFSA_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HBMEFSA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEFSA] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HBMEFSA_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMEFSA_MainFormTable.Exists());

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
				Function.CurrentComponent = "HBMEFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEFSA] Performing VerifyExists on UpdateDeductionLink...", Logger.MessageType.INF);
				SeleniumControl HBMEFSA_UpdateDeductionLink = new SeleniumControl( sDriver, "UpdateDeductionLink", "ID", "lnk_5575_HBMEFSA_HBDEPFSAELEC");
				Function.AssertEqual(true,HBMEFSA_UpdateDeductionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEFSA] Performing Click on UpdateDeductionLink...", Logger.MessageType.INF);
				SeleniumControl HBMEFSA_UpdateDeductionLink = new SeleniumControl( sDriver, "UpdateDeductionLink", "ID", "lnk_5575_HBMEFSA_HBDEPFSAELEC");
				Function.WaitControlDisplayed(HBMEFSA_UpdateDeductionLink);
HBMEFSA_UpdateDeductionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEFSA] Performing VerifyExists on UpdateDeductionForm...", Logger.MessageType.INF);
				SeleniumControl HBMEFSA_UpdateDeductionForm = new SeleniumControl( sDriver, "UpdateDeductionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMEFSA_UPDATEDED_']/ancestor::form[1]");
				Function.AssertEqual(true,HBMEFSA_UpdateDeductionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEFSA] Performing VerifyExists on UpdateDeductionForm_PayCycle...", Logger.MessageType.INF);
				SeleniumControl HBMEFSA_UpdateDeductionForm_PayCycle = new SeleniumControl( sDriver, "UpdateDeductionForm_PayCycle", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMEFSA_UPDATEDED_']/ancestor::form[1]/descendant::*[@id='PAY_PD_CD']");
				Function.AssertEqual(true,HBMEFSA_UpdateDeductionForm_PayCycle.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMEFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEFSA] Performing Close on UpdateDeductionForm...", Logger.MessageType.INF);
				SeleniumControl HBMEFSA_UpdateDeductionForm = new SeleniumControl( sDriver, "UpdateDeductionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMEFSA_UPDATEDED_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HBMEFSA_UpdateDeductionForm);
IWebElement formBttn = HBMEFSA_UpdateDeductionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "HBMEFSA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMEFSA] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMEFSA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMEFSA_MainForm);
IWebElement formBttn = HBMEFSA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

