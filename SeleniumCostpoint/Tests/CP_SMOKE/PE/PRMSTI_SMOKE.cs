 
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
    public class PRMSTI_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"State Taxes", "xpath","//div[@class='navItem'][.='State Taxes']").Click();
new SeleniumControl(sDriver,"Manage State Taxes", "xpath","//div[@class='navItem'][.='Manage State Taxes']").Click();


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
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMSTI_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing VerifyExists on State...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_State = new SeleniumControl( sDriver, "State", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='STATE_CD']");
				Function.AssertEqual(true,PRMSTI_State.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMSTI_MainForm);
IWebElement formBttn = PRMSTI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMSTI_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMSTI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMSTI_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing VerifyExists on TaxIDReferenceNumbersVendorInformationLink...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_TaxIDReferenceNumbersVendorInformationLink = new SeleniumControl( sDriver, "TaxIDReferenceNumbersVendorInformationLink", "ID", "lnk_1002323_PRMSTI_STATETAXINFO_HDR");
				Function.AssertEqual(true,PRMSTI_TaxIDReferenceNumbersVendorInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing VerifyExists on StateTaxDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_StateTaxDetailsForm = new SeleniumControl( sDriver, "StateTaxDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSTI_STATETAXHS_CHLTBL_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMSTI_StateTaxDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing VerifyExist on StateTaxDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_StateTaxDetailsFormTable = new SeleniumControl( sDriver, "StateTaxDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSTI_STATETAXHS_CHLTBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMSTI_StateTaxDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing ClickButton on StateTaxDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_StateTaxDetailsForm = new SeleniumControl( sDriver, "StateTaxDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSTI_STATETAXHS_CHLTBL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMSTI_StateTaxDetailsForm);
IWebElement formBttn = PRMSTI_StateTaxDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRMSTI_StateTaxDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRMSTI_StateTaxDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing VerifyExists on StateTaxDetails_EffectiveDate...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_StateTaxDetails_EffectiveDate = new SeleniumControl( sDriver, "StateTaxDetails_EffectiveDate", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSTI_STATETAXHS_CHLTBL_']/ancestor::form[1]/descendant::*[@id='EFFECT_DT']");
				Function.AssertEqual(true,PRMSTI_StateTaxDetails_EffectiveDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing Click on TaxIDReferenceNumbersVendorInformationLink...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_TaxIDReferenceNumbersVendorInformationLink = new SeleniumControl( sDriver, "TaxIDReferenceNumbersVendorInformationLink", "ID", "lnk_1002323_PRMSTI_STATETAXINFO_HDR");
				Function.WaitControlDisplayed(PRMSTI_TaxIDReferenceNumbersVendorInformationLink);
PRMSTI_TaxIDReferenceNumbersVendorInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing VerifyExists on TaxIDReferenceNumbersVendorInformationForm...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_TaxIDReferenceNumbersVendorInformationForm = new SeleniumControl( sDriver, "TaxIDReferenceNumbersVendorInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSTI_STATETAXCO_SUB_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMSTI_TaxIDReferenceNumbersVendorInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing VerifyExists on TaxIDReferenceNumbersVendorInformation_TaxID...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_TaxIDReferenceNumbersVendorInformation_TaxID = new SeleniumControl( sDriver, "TaxIDReferenceNumbersVendorInformation_TaxID", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSTI_STATETAXCO_SUB_']/ancestor::form[1]/descendant::*[@id='STATE_TAX_ID']");
				Function.AssertEqual(true,PRMSTI_TaxIDReferenceNumbersVendorInformation_TaxID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing ClickButton on TaxIDReferenceNumbersVendorInformationForm...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_TaxIDReferenceNumbersVendorInformationForm = new SeleniumControl( sDriver, "TaxIDReferenceNumbersVendorInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSTI_STATETAXCO_SUB_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMSTI_TaxIDReferenceNumbersVendorInformationForm);
IWebElement formBttn = PRMSTI_TaxIDReferenceNumbersVendorInformationForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMSTI_TaxIDReferenceNumbersVendorInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMSTI_TaxIDReferenceNumbersVendorInformationForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing VerifyExist on TaxIDReferenceNumbersVendorInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_TaxIDReferenceNumbersVendorInformationFormTable = new SeleniumControl( sDriver, "TaxIDReferenceNumbersVendorInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSTI_STATETAXCO_SUB_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMSTI_TaxIDReferenceNumbersVendorInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing Close on TaxIDReferenceNumbersVendorInformationForm...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_TaxIDReferenceNumbersVendorInformationForm = new SeleniumControl( sDriver, "TaxIDReferenceNumbersVendorInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMSTI_STATETAXCO_SUB_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMSTI_TaxIDReferenceNumbersVendorInformationForm);
IWebElement formBttn = PRMSTI_TaxIDReferenceNumbersVendorInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMSTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMSTI] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMSTI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMSTI_MainForm);
IWebElement formBttn = PRMSTI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

