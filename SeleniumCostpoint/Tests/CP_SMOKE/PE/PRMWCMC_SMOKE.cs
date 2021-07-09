 
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
    public class PRMWCMC_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Payroll", "xpath","//div[@class='deptItem'][.='Payroll']").Click();
new SeleniumControl(sDriver,"Payroll Controls", "xpath","//div[@class='navItem'][.='Payroll Controls']").Click();
                    sDriver.Instance.FindElements(By.XPath("//div[@id='activityArea']/div[@class='navItem']")).ToList().Where(x => x.Displayed && x.Text == "Manage Workers' Compensation Modify Codes").FirstOrDefault().Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMWCMC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMWCMC] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMWCMC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMWCMC_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMWCMC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMWCMC] Performing VerifyExists on WCModifyCode...", Logger.MessageType.INF);
				SeleniumControl PRMWCMC_WCModifyCode = new SeleniumControl( sDriver, "WCModifyCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WC_MOD_CD']");
				Function.AssertEqual(true,PRMWCMC_WCModifyCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Table");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMWCMC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMWCMC] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMWCMC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMWCMC_MainForm);
IWebElement formBttn = PRMWCMC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMWCMC_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMWCMC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMWCMC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMWCMC] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMWCMC_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMWCMC_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Workers Compensation Mod");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMWCMC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMWCMC] Performing VerifyExists on WorkersCompensationModifyCodeDetailsLink...", Logger.MessageType.INF);
				SeleniumControl PRMWCMC_WorkersCompensationModifyCodeDetailsLink = new SeleniumControl( sDriver, "WorkersCompensationModifyCodeDetailsLink", "ID", "lnk_3837_PRMWCMC_WCMODCD_HDR");
				Function.AssertEqual(true,PRMWCMC_WorkersCompensationModifyCodeDetailsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMWCMC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMWCMC] Performing Click on WorkersCompensationModifyCodeDetailsLink...", Logger.MessageType.INF);
				SeleniumControl PRMWCMC_WorkersCompensationModifyCodeDetailsLink = new SeleniumControl( sDriver, "WorkersCompensationModifyCodeDetailsLink", "ID", "lnk_3837_PRMWCMC_WCMODCD_HDR");
				Function.WaitControlDisplayed(PRMWCMC_WorkersCompensationModifyCodeDetailsLink);
PRMWCMC_WorkersCompensationModifyCodeDetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMWCMC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMWCMC] Performing VerifyExists on WorkersCompensationModifyCodeDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PRMWCMC_WorkersCompensationModifyCodeDetailsForm = new SeleniumControl( sDriver, "WorkersCompensationModifyCodeDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMWCMC_WCMODPAYTYPE_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMWCMC_WorkersCompensationModifyCodeDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMWCMC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMWCMC] Performing VerifyExist on WorkersCompensationModifyCodeDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMWCMC_WorkersCompensationModifyCodeDetailsFormTable = new SeleniumControl( sDriver, "WorkersCompensationModifyCodeDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMWCMC_WCMODPAYTYPE_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMWCMC_WorkersCompensationModifyCodeDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close Application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMWCMC";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMWCMC] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMWCMC_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMWCMC_MainForm);
IWebElement formBttn = PRMWCMC_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

