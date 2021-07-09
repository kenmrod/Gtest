 
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
    public class PRMLTI_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Local Taxes", "xpath","//div[@class='navItem'][.='Local Taxes']").Click();
new SeleniumControl(sDriver,"Manage Local Taxes", "xpath","//div[@class='navItem'][.='Manage Local Taxes']").Click();


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
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMLTI_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing VerifyExists on Locality...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_Locality = new SeleniumControl( sDriver, "Locality", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='LOCAL_CD']");
				Function.AssertEqual(true,PRMLTI_Locality.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMLTI_MainForm);
IWebElement formBttn = PRMLTI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMLTI_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMLTI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing VerifyExist on MainTable...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_MainTable = new SeleniumControl( sDriver, "MainTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMLTI_MainTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Local Tax Details Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing VerifyExists on LocalTaxDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_LocalTaxDetailsForm = new SeleniumControl( sDriver, "LocalTaxDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMLTI_LOCALTAXHS_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMLTI_LocalTaxDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing VerifyExist on LocalTaxDetailsTable...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_LocalTaxDetailsTable = new SeleniumControl( sDriver, "LocalTaxDetailsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMLTI_LOCALTAXHS_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMLTI_LocalTaxDetailsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing ClickButton on LocalTaxDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_LocalTaxDetailsForm = new SeleniumControl( sDriver, "LocalTaxDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMLTI_LOCALTAXHS_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMLTI_LocalTaxDetailsForm);
IWebElement formBttn = PRMLTI_LocalTaxDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PRMLTI_LocalTaxDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PRMLTI_LocalTaxDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing VerifyExists on LocalTaxDetails_EffectiveDate...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_LocalTaxDetails_EffectiveDate = new SeleniumControl( sDriver, "LocalTaxDetails_EffectiveDate", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMLTI_LOCALTAXHS_CHILD_']/ancestor::form[1]/descendant::*[@id='EFFECT_DT']");
				Function.AssertEqual(true,PRMLTI_LocalTaxDetails_EffectiveDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Tax ID / Reference Numbers / Vendor Information Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing VerifyExists on TaxIDRefNoVendorInfo...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_TaxIDRefNoVendorInfo = new SeleniumControl( sDriver, "TaxIDRefNoVendorInfo", "ID", "lnk_1002383_PRMLTI_LOCALITY_HDR");
				Function.AssertEqual(true,PRMLTI_TaxIDRefNoVendorInfo.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing Click on TaxIDRefNoVendorInfo...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_TaxIDRefNoVendorInfo = new SeleniumControl( sDriver, "TaxIDRefNoVendorInfo", "ID", "lnk_1002383_PRMLTI_LOCALITY_HDR");
				Function.WaitControlDisplayed(PRMLTI_TaxIDRefNoVendorInfo);
PRMLTI_TaxIDRefNoVendorInfo.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing VerifyExists on TaxIDRefNoVendorInfoForm...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_TaxIDRefNoVendorInfoForm = new SeleniumControl( sDriver, "TaxIDRefNoVendorInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMLTI_LOCALITYCO_SUB_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMLTI_TaxIDRefNoVendorInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing VerifyExists on TaxIDRefNoVendorInfo_TaxID...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_TaxIDRefNoVendorInfo_TaxID = new SeleniumControl( sDriver, "TaxIDRefNoVendorInfo_TaxID", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMLTI_LOCALITYCO_SUB_']/ancestor::form[1]/descendant::*[@id='LOCAL_TAX_ID']");
				Function.AssertEqual(true,PRMLTI_TaxIDRefNoVendorInfo_TaxID.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing Close on TaxIDRefNoVendorInfoForm...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_TaxIDRefNoVendorInfoForm = new SeleniumControl( sDriver, "TaxIDRefNoVendorInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMLTI_LOCALITYCO_SUB_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PRMLTI_TaxIDRefNoVendorInfoForm);
IWebElement formBttn = PRMLTI_TaxIDRefNoVendorInfoForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PRMLTI";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMLTI] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMLTI_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMLTI_MainForm);
IWebElement formBttn = PRMLTI_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

