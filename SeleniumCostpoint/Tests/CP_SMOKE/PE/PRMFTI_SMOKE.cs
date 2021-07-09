 
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
    public class PRMFTI_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Federal Taxes", "xpath","//div[@class='navItem'][.='Federal Taxes']").Click();
new SeleniumControl(sDriver,"Manage Federal Taxes", "xpath","//div[@class='navItem'][.='Manage Federal Taxes']").Click();


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
				Function.CurrentComponent = "PRMFTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTI] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMFTI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMFTI_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTI] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl PRMFTI_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMFTI_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTI] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMFTI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMFTI_MainForm);
IWebElement formBttn = PRMFTI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRMFTI_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRMFTI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTI] Performing VerifyExists on PayrollYear...", Logger.MessageType.INF);
				SeleniumControl PRMFTI_PayrollYear = new SeleniumControl( sDriver, "PayrollYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PR_YR_NO']");
				Function.AssertEqual(true,PRMFTI_PayrollYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("FUTA Credit Reduction States From");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTI] Performing VerifyExists on FUTACreditReductionStatesLink...", Logger.MessageType.INF);
				SeleniumControl PRMFTI_FUTACreditReductionStatesLink = new SeleniumControl( sDriver, "FUTACreditReductionStatesLink", "ID", "lnk_15756_PRMFTI_FEDTAXINFO_HDR");
				Function.AssertEqual(true,PRMFTI_FUTACreditReductionStatesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTI] Performing Click on FUTACreditReductionStatesLink...", Logger.MessageType.INF);
				SeleniumControl PRMFTI_FUTACreditReductionStatesLink = new SeleniumControl( sDriver, "FUTACreditReductionStatesLink", "ID", "lnk_15756_PRMFTI_FEDTAXINFO_HDR");
				Function.WaitControlDisplayed(PRMFTI_FUTACreditReductionStatesLink);
PRMFTI_FUTACreditReductionStatesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTI] Performing VerifyExists on FUTACreditReductionStatesForm...", Logger.MessageType.INF);
				SeleniumControl PRMFTI_FUTACreditReductionStatesForm = new SeleniumControl( sDriver, "FUTACreditReductionStatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMFTI_FUTA_CREDIT_REDUC_ST_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMFTI_FUTACreditReductionStatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTI] Performing VerifyExist on FUTACreditReductionStatesTable...", Logger.MessageType.INF);
				SeleniumControl PRMFTI_FUTACreditReductionStatesTable = new SeleniumControl( sDriver, "FUTACreditReductionStatesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMFTI_FUTA_CREDIT_REDUC_ST_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMFTI_FUTACreditReductionStatesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTI] Performing Close on FUTACreditReductionStatesForm...", Logger.MessageType.INF);
				SeleniumControl PRMFTI_FUTACreditReductionStatesForm = new SeleniumControl( sDriver, "FUTACreditReductionStatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMFTI_FUTA_CREDIT_REDUC_ST_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMFTI_FUTACreditReductionStatesForm);
IWebElement formBttn = PRMFTI_FUTACreditReductionStatesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRMFTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTI] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMFTI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMFTI_MainForm);
IWebElement formBttn = PRMFTI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

