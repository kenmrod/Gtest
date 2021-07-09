 
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
    public class PRQETAX_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Payroll Reports/Inquiries", "xpath","//div[@class='navItem'][.='Payroll Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Employee Taxes", "xpath","//div[@class='navItem'][.='View Employee Taxes']").Click();


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
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRQETAX_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing VerifyExists on Identification_Employee...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_Identification_Employee = new SeleniumControl( sDriver, "Identification_Employee", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PRQETAX_Identification_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Execute.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Inquiry Details Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing VerifyExists on InquiryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetailsForm = new SeleniumControl( sDriver, "InquiryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQETAX_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQETAX_InquiryDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing VerifyExist on InquiryDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetailsFormTable = new SeleniumControl( sDriver, "InquiryDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQETAX_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQETAX_InquiryDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing ClickButton on InquiryDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetailsForm = new SeleniumControl( sDriver, "InquiryDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQETAX_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQETAX_InquiryDetailsForm);
IWebElement formBttn = PRQETAX_InquiryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQETAX_InquiryDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQETAX_InquiryDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing VerifyExists on InquiryDetails_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetails_TransactionType = new SeleniumControl( sDriver, "InquiryDetails_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQETAX_CTW_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQETAX_InquiryDetails_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing VerifyExists on InquiryDetails_InquiryDetailsTab...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetails_InquiryDetailsTab = new SeleniumControl( sDriver, "InquiryDetails_InquiryDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQETAX_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,PRQETAX_InquiryDetails_InquiryDetailsTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing Select on InquiryDetails_InquiryDetailsTab...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetails_InquiryDetailsTab = new SeleniumControl( sDriver, "InquiryDetails_InquiryDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQETAX_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRQETAX_InquiryDetails_InquiryDetailsTab);
IWebElement mTab = PRQETAX_InquiryDetails_InquiryDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Taxes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing VerifyExists on InquiryDetails_Taxes_PayCycle...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetails_Taxes_PayCycle = new SeleniumControl( sDriver, "InquiryDetails_Taxes_PayCycle", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQETAX_CTW_']/ancestor::form[1]/descendant::*[@id='PAY_PD_CD']");
				Function.AssertEqual(true,PRQETAX_InquiryDetails_Taxes_PayCycle.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing Select on InquiryDetails_InquiryDetailsTab...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetails_InquiryDetailsTab = new SeleniumControl( sDriver, "InquiryDetails_InquiryDetailsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQETAX_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PRQETAX_InquiryDetails_InquiryDetailsTab);
IWebElement mTab = PRQETAX_InquiryDetails_InquiryDetailsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Tax Reporting Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing VerifyExists on InquiryDetails_TaxReportingInformation_AlaskaLabel...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetails_TaxReportingInformation_AlaskaLabel = new SeleniumControl( sDriver, "InquiryDetails_TaxReportingInformation_AlaskaLabel", "xpath", "//input[@id='S_MOD_TYPE_CD']/ancestor::form[1]/descendant::*[@id='ALASKA_BOX']");
				Function.AssertEqual(true,PRQETAX_InquiryDetails_TaxReportingInformation_AlaskaLabel.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Multi State Tax Inquiry");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing VerifyExists on InquiryDetails_MultiStateTaxInquiryLink...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetails_MultiStateTaxInquiryLink = new SeleniumControl( sDriver, "InquiryDetails_MultiStateTaxInquiryLink", "ID", "lnk_5383_PRQETAX_CTW");
				Function.AssertEqual(true,PRQETAX_InquiryDetails_MultiStateTaxInquiryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing Click on InquiryDetails_MultiStateTaxInquiryLink...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetails_MultiStateTaxInquiryLink = new SeleniumControl( sDriver, "InquiryDetails_MultiStateTaxInquiryLink", "ID", "lnk_5383_PRQETAX_CTW");
				Function.WaitControlDisplayed(PRQETAX_InquiryDetails_MultiStateTaxInquiryLink);
PRQETAX_InquiryDetails_MultiStateTaxInquiryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing VerifyExists on InquiryDetails_MultiStateTaxInquiryForm...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetails_MultiStateTaxInquiryForm = new SeleniumControl( sDriver, "InquiryDetails_MultiStateTaxInquiryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQETAX_MULTI_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRQETAX_InquiryDetails_MultiStateTaxInquiryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing VerifyExist on InquiryDetails_MultiStateTaxInquiryFormTable...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetails_MultiStateTaxInquiryFormTable = new SeleniumControl( sDriver, "InquiryDetails_MultiStateTaxInquiryFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQETAX_MULTI_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRQETAX_InquiryDetails_MultiStateTaxInquiryFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing ClickButton on InquiryDetails_MultiStateTaxInquiryForm...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetails_MultiStateTaxInquiryForm = new SeleniumControl( sDriver, "InquiryDetails_MultiStateTaxInquiryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQETAX_MULTI_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQETAX_InquiryDetails_MultiStateTaxInquiryForm);
IWebElement formBttn = PRQETAX_InquiryDetails_MultiStateTaxInquiryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRQETAX_InquiryDetails_MultiStateTaxInquiryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRQETAX_InquiryDetails_MultiStateTaxInquiryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing VerifyExists on InquiryDetails_MultiStateTaxInquiry_TransactionType...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetails_MultiStateTaxInquiry_TransactionType = new SeleniumControl( sDriver, "InquiryDetails_MultiStateTaxInquiry_TransactionType", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQETAX_MULTI_CTW_']/ancestor::form[1]/descendant::*[@id='S_MOD_TYPE_CD']");
				Function.AssertEqual(true,PRQETAX_InquiryDetails_MultiStateTaxInquiry_TransactionType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing Close on InquiryDetails_MultiStateTaxInquiryForm...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_InquiryDetails_MultiStateTaxInquiryForm = new SeleniumControl( sDriver, "InquiryDetails_MultiStateTaxInquiryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRQETAX_MULTI_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRQETAX_InquiryDetails_MultiStateTaxInquiryForm);
IWebElement formBttn = PRQETAX_InquiryDetails_MultiStateTaxInquiryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRQETAX";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRQETAX] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRQETAX_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRQETAX_MainForm);
IWebElement formBttn = PRQETAX_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

