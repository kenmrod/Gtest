 
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
    public class PRPW2F_00_SMOKE_PREREQ : SeleniumTestScript
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

				this.ScriptLogger.WriteLine("[PRMEXTAX] Performing Set on EnablePayrollTaxInterface...", Logger.MessageType.INF);
				SeleniumControl PRMEXTAX_EnablePayrollTaxInterface = new SeleniumControl( sDriver, "EnablePayrollTaxInterface", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='REQUIRE_TAX_CD_FL']");
				Function.WaitControlDisplayed(PRMEXTAX_EnablePayrollTaxInterface);
PRMEXTAX_EnablePayrollTaxInterface.ScrollIntoViewUsingJavaScript();
if (Convert.ToBoolean(PRMEXTAX_EnablePayrollTaxInterface.GetAttributeValue("checked")) != false) PRMEXTAX_EnablePayrollTaxInterface.Click(4.3);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEXTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEXTAX] Performing Set on EnablePayrollTaxInterface...", Logger.MessageType.INF);
				SeleniumControl PRMEXTAX_EnablePayrollTaxInterface = new SeleniumControl( sDriver, "EnablePayrollTaxInterface", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='REQUIRE_TAX_CD_FL']");
				Function.WaitControlDisplayed(PRMEXTAX_EnablePayrollTaxInterface);
PRMEXTAX_EnablePayrollTaxInterface.ScrollIntoViewUsingJavaScript();
if (Convert.ToBoolean(PRMEXTAX_EnablePayrollTaxInterface.GetAttributeValue("checked")) != true) PRMEXTAX_EnablePayrollTaxInterface.Click(4.3);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMEXTAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMEXTAX] Performing Set on EnablePayrollTaxInterface...", Logger.MessageType.INF);
				SeleniumControl PRMEXTAX_EnablePayrollTaxInterface = new SeleniumControl( sDriver, "EnablePayrollTaxInterface", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='REQUIRE_TAX_CD_FL']");
				Function.WaitControlDisplayed(PRMEXTAX_EnablePayrollTaxInterface);
PRMEXTAX_EnablePayrollTaxInterface.ScrollIntoViewUsingJavaScript();
if (Convert.ToBoolean(PRMEXTAX_EnablePayrollTaxInterface.GetAttributeValue("checked")) != false) PRMEXTAX_EnablePayrollTaxInterface.Click(4.3);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
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
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Save.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(true));

				this.ScriptLogger.WriteLine("[CP7Main] Performing VerifyMessageExists on MessagesArea...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MessagesArea = new SeleniumControl( sDriver, "MessagesArea", "XPATH", "//div[contains(@class,'msg') and contains(@style,'visible')]");
				Function.WaitControlDisplayed(CP7Main_MessagesArea);
IList<IWebElement> msgElements = sDriver.Instance.FindElements(By.XPath("//span[contains(@class,'msgTextHdr')]/following-sibling::span[not(contains(@class,'msgTextHdr'))]"));
Function.AssertEqual(true, msgElements.ToList().Select(x => new SeleniumControl( sDriver, "x", x).GetValue().Trim()).Any(x => x == "Record modifications successfully completed."));


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyMessageExists]" , ex.Message));
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

