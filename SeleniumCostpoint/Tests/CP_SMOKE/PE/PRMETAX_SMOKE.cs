 
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
    public class PRMETAX_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Employee Payroll Information", "xpath","//div[@class='navItem'][.='Employee Payroll Information']").Click();
new SeleniumControl(sDriver,"Manage Employee Taxes", "xpath","//div[@class='navItem'][.='Manage Employee Taxes']").Click();


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
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMETAX_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing VerifyExists on Employee...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_Employee = new SeleniumControl( sDriver, "Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PRMETAX_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Taxes Details");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing Select on TaxDetails_Tab...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_TaxDetails_Tab = new SeleniumControl( sDriver, "TaxDetails_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRMETAX_TaxDetails_Tab);
IWebElement mTab = PRMETAX_TaxDetails_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Taxes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing VerifyExists on TaxDetails_Taxes_PayCycle...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_TaxDetails_Taxes_PayCycle = new SeleniumControl( sDriver, "TaxDetails_Taxes_PayCycle", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PAY_PD_CD']");
				Function.AssertEqual(true,PRMETAX_TaxDetails_Taxes_PayCycle.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing Select on TaxDetails_Tab...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_TaxDetails_Tab = new SeleniumControl( sDriver, "TaxDetails_Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRMETAX_TaxDetails_Tab);
IWebElement mTab = PRMETAX_TaxDetails_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Tax Reporting Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing VerifyExists on TaxDetails_TaxReportingInformation_GeographicCode...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_TaxDetails_TaxReportingInformation_GeographicCode = new SeleniumControl( sDriver, "TaxDetails_TaxReportingInformation_GeographicCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_AK_GEO_CD']");
				Function.AssertEqual(true,PRMETAX_TaxDetails_TaxReportingInformation_GeographicCode.Exists());

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
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMETAX_MainForm);
IWebElement formBttn = PRMETAX_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMETAX_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMETAX_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMETAX_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Multi- State Taxes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing VerifyExists on TaxDetails_MultiStateTaxes...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_TaxDetails_MultiStateTaxes = new SeleniumControl( sDriver, "TaxDetails_MultiStateTaxes", "ID", "lnk_16474_PEMETAX_EMPLTAX_INFO");
				Function.AssertEqual(true,PRMETAX_TaxDetails_MultiStateTaxes.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing Click on TaxDetails_MultiStateTaxes...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_TaxDetails_MultiStateTaxes = new SeleniumControl( sDriver, "TaxDetails_MultiStateTaxes", "ID", "lnk_16474_PEMETAX_EMPLTAX_INFO");
				Function.WaitControlDisplayed(PRMETAX_TaxDetails_MultiStateTaxes);
PRMETAX_TaxDetails_MultiStateTaxes.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing VerifyExists on MultiStateTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_MultiStateTaxesForm = new SeleniumControl( sDriver, "MultiStateTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PEMETAX_EMPLTAXMULTI_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMETAX_MultiStateTaxesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing VerifyExist on MultiStateTaxesTable...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_MultiStateTaxesTable = new SeleniumControl( sDriver, "MultiStateTaxesTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PEMETAX_EMPLTAXMULTI_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMETAX_MultiStateTaxesTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Multi- State Taxes Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing ClickButton on MultiStateTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_MultiStateTaxesForm = new SeleniumControl( sDriver, "MultiStateTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PEMETAX_EMPLTAXMULTI_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMETAX_MultiStateTaxesForm);
IWebElement formBttn = PRMETAX_MultiStateTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRMETAX_MultiStateTaxesForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRMETAX_MultiStateTaxesForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing VerifyExists on MultiStateTaxesForm...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_MultiStateTaxesForm = new SeleniumControl( sDriver, "MultiStateTaxesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PEMETAX_EMPLTAXMULTI_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMETAX_MultiStateTaxesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PRMETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMETAX] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMETAX_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMETAX_MainForm);
IWebElement formBttn = PRMETAX_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

