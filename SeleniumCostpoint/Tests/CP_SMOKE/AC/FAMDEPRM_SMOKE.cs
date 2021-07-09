 
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
    public class FAMDEPRM_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"Fixed Assets", "xpath","//div[@class='deptItem'][.='Fixed Assets']").Click();
new SeleniumControl(sDriver,"Fixed Assets Controls", "xpath","//div[@class='navItem'][.='Fixed Assets Controls']").Click();
new SeleniumControl(sDriver,"Manage Depreciation Methods", "xpath","//div[@class='navItem'][.='Manage Depreciation Methods']").Click();


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
				Function.CurrentComponent = "FAMDEPRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMDEPRM] Performing VerifyExists on DepreciationMethodCode...", Logger.MessageType.INF);
				SeleniumControl FAMDEPRM_DepreciationMethodCode = new SeleniumControl( sDriver, "DepreciationMethodCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='DEPR_MTHD_CD']");
				Function.AssertEqual(true,FAMDEPRM_DepreciationMethodCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMDEPRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMDEPRM] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMDEPRM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAMDEPRM_MainForm);
IWebElement formBttn = FAMDEPRM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? FAMDEPRM_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
FAMDEPRM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMDEPRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMDEPRM] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl FAMDEPRM_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,FAMDEPRM_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Auto Calc");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMDEPRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMDEPRM] Performing Click on AutoCalc...", Logger.MessageType.INF);
				SeleniumControl FAMDEPRM_AutoCalc = new SeleniumControl( sDriver, "AutoCalc", "ID", "lnk_1000952_FAMDEPRM_DEPRMTHD_HDR");
				Function.WaitControlDisplayed(FAMDEPRM_AutoCalc);
FAMDEPRM_AutoCalc.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMDEPRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMDEPRM] Performing VerifyExists on AutoCalcForm...", Logger.MessageType.INF);
				SeleniumControl FAMDEPRM_AutoCalcForm = new SeleniumControl( sDriver, "AutoCalcForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMDEPRM_AUTOCALC_']/ancestor::form[1]");
				Function.AssertEqual(true,FAMDEPRM_AutoCalcForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMDEPRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMDEPRM] Performing VerifyExists on AutoCalc_DepreciationMethodOptions_StraightLine...", Logger.MessageType.INF);
				SeleniumControl FAMDEPRM_AutoCalc_DepreciationMethodOptions_StraightLine = new SeleniumControl( sDriver, "AutoCalc_DepreciationMethodOptions_StraightLine", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMDEPRM_AUTOCALC_']/ancestor::form[1]/descendant::*[@id='DEPR_METHOD_OPT' and @value='SL']");
				Function.AssertEqual(true,FAMDEPRM_AutoCalc_DepreciationMethodOptions_StraightLine.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMDEPRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMDEPRM] Performing Close on AutoCalcForm...", Logger.MessageType.INF);
				SeleniumControl FAMDEPRM_AutoCalcForm = new SeleniumControl( sDriver, "AutoCalcForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMDEPRM_AUTOCALC_']/ancestor::form[1]");
				Function.WaitControlDisplayed(FAMDEPRM_AutoCalcForm);
IWebElement formBttn = FAMDEPRM_AutoCalcForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Child Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMDEPRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMDEPRM] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl FAMDEPRM_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__FAMDEPRM_DEPRMTHDYRS_DEPR_']/ancestor::form[1]");
				Function.AssertEqual(true,FAMDEPRM_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "FAMDEPRM";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[FAMDEPRM] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl FAMDEPRM_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(FAMDEPRM_MainForm);
IWebElement formBttn = FAMDEPRM_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

