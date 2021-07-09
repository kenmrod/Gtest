 
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
    public class PRMEXTAX_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Payroll Interfaces", "xpath","//div[@class='navItem'][.='Payroll Interfaces']").Click();
new SeleniumControl(sDriver,"Configure Payroll Tax Export Settings", "xpath","//div[@class='navItem'][.='Configure Payroll Tax Export Settings']").Click();


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
				Function.CurrentComponent = "PRMEXTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEXTAX] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMEXTAX_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMEXTAX_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEXTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEXTAX] Performing VerifyExists on EnablePayrollTaxInterface...", Logger.MessageType.INF);
				SeleniumControl PRMEXTAX_EnablePayrollTaxInterface = new SeleniumControl( sDriver, "EnablePayrollTaxInterface", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='REQUIRE_TAX_CD_FL']");
				Function.AssertEqual(true,PRMEXTAX_EnablePayrollTaxInterface.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TAX SERVICE GROUP IDS LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEXTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEXTAX] Performing Click on TaxServiceGroupIDsLink...", Logger.MessageType.INF);
				SeleniumControl PRMEXTAX_TaxServiceGroupIDsLink = new SeleniumControl( sDriver, "TaxServiceGroupIDsLink", "ID", "lnk_16518_PRMEXTAX_HDR");
				Function.WaitControlDisplayed(PRMEXTAX_TaxServiceGroupIDsLink);
PRMEXTAX_TaxServiceGroupIDsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEXTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEXTAX] Performing VerifyExist on TaxServiceGroupIDsFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMEXTAX_TaxServiceGroupIDsFormTable = new SeleniumControl( sDriver, "TaxServiceGroupIDsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMEXTAX_TAX_SVC_GRP_IDS_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMEXTAX_TaxServiceGroupIDsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEXTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEXTAX] Performing VerifyExists on TaxServiceGroupIDsForm...", Logger.MessageType.INF);
				SeleniumControl PRMEXTAX_TaxServiceGroupIDsForm = new SeleniumControl( sDriver, "TaxServiceGroupIDsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMEXTAX_TAX_SVC_GRP_IDS_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMEXTAX_TaxServiceGroupIDsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEXTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEXTAX] Performing Close on TaxServiceGroupIDsForm...", Logger.MessageType.INF);
				SeleniumControl PRMEXTAX_TaxServiceGroupIDsForm = new SeleniumControl( sDriver, "TaxServiceGroupIDsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMEXTAX_TAX_SVC_GRP_IDS_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMEXTAX_TaxServiceGroupIDsForm);
IWebElement formBttn = PRMEXTAX_TaxServiceGroupIDsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRMEXTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEXTAX] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMEXTAX_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMEXTAX_MainForm);
IWebElement formBttn = PRMEXTAX_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

