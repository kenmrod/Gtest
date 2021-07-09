 
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
    public class PJMPWFRT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Project Setup", "xpath","//div[@class='deptItem'][.='Project Setup']").Click();
new SeleniumControl(sDriver,"Project Labor", "xpath","//div[@class='navItem'][.='Project Labor']").Click();
new SeleniumControl(sDriver,"Link PLC Rates to Employee/Vendor", "xpath","//div[@class='navItem'][.='Link PLC Rates to Employee/Vendor']").Click();


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
				Function.CurrentComponent = "PJMPWFRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPWFRT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPWFRT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMPWFRT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPWFRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPWFRT] Performing VerifyExists on Identification_Project...", Logger.MessageType.INF);
				SeleniumControl PJMPWFRT_Identification_Project = new SeleniumControl( sDriver, "Identification_Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMPWFRT_Identification_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILD FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPWFRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPWFRT] Performing VerifyExist on EmployeeBillingRatesTable...", Logger.MessageType.INF);
				SeleniumControl PJMPWFRT_EmployeeBillingRatesTable = new SeleniumControl( sDriver, "EmployeeBillingRatesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPWFRT_PROJEMPLRTSCH_PWFRT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPWFRT_EmployeeBillingRatesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPWFRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPWFRT] Performing ClickButton on EmployeeBillingRatesForm...", Logger.MessageType.INF);
				SeleniumControl PJMPWFRT_EmployeeBillingRatesForm = new SeleniumControl( sDriver, "EmployeeBillingRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPWFRT_PROJEMPLRTSCH_PWFRT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPWFRT_EmployeeBillingRatesForm);
IWebElement formBttn = PJMPWFRT_EmployeeBillingRatesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMPWFRT_EmployeeBillingRatesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMPWFRT_EmployeeBillingRatesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPWFRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPWFRT] Performing VerifyExists on EmployeeBillingRatesForm...", Logger.MessageType.INF);
				SeleniumControl PJMPWFRT_EmployeeBillingRatesForm = new SeleniumControl( sDriver, "EmployeeBillingRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPWFRT_PROJEMPLRTSCH_PWFRT_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMPWFRT_EmployeeBillingRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPWFRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPWFRT] Performing VerifyExists on EmployeeBillingRates_EMPLOYEEID...", Logger.MessageType.INF);
				SeleniumControl PJMPWFRT_EmployeeBillingRates_EMPLOYEEID = new SeleniumControl( sDriver, "EmployeeBillingRates_EMPLOYEEID", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPWFRT_PROJEMPLRTSCH_PWFRT_']/ancestor::form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PJMPWFRT_EmployeeBillingRates_EMPLOYEEID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPWFRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPWFRT] Performing VerifyExist on VendorBillingRatesTable...", Logger.MessageType.INF);
				SeleniumControl PJMPWFRT_VendorBillingRatesTable = new SeleniumControl( sDriver, "VendorBillingRatesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPWFRT_PROJVENDRTSCH_PWFRT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMPWFRT_VendorBillingRatesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPWFRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPWFRT] Performing ClickButton on VendorBillingRatesForm...", Logger.MessageType.INF);
				SeleniumControl PJMPWFRT_VendorBillingRatesForm = new SeleniumControl( sDriver, "VendorBillingRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPWFRT_PROJVENDRTSCH_PWFRT_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMPWFRT_VendorBillingRatesForm);
IWebElement formBttn = PJMPWFRT_VendorBillingRatesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMPWFRT_VendorBillingRatesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMPWFRT_VendorBillingRatesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPWFRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPWFRT] Performing VerifyExists on VendorBillingRatesForm...", Logger.MessageType.INF);
				SeleniumControl PJMPWFRT_VendorBillingRatesForm = new SeleniumControl( sDriver, "VendorBillingRatesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPWFRT_PROJVENDRTSCH_PWFRT_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMPWFRT_VendorBillingRatesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMPWFRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPWFRT] Performing VerifyExists on VendorBillingRates_VendorEmployee...", Logger.MessageType.INF);
				SeleniumControl PJMPWFRT_VendorBillingRates_VendorEmployee = new SeleniumControl( sDriver, "VendorBillingRates_VendorEmployee", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMPWFRT_PROJVENDRTSCH_PWFRT_']/ancestor::form[1]/descendant::*[@id='VEND_EMPL_ID']");
				Function.AssertEqual(true,PJMPWFRT_VendorBillingRates_VendorEmployee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PJMPWFRT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMPWFRT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMPWFRT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMPWFRT_MainForm);
IWebElement formBttn = PJMPWFRT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

