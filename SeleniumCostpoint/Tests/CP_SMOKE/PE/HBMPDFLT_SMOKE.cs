 
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
    public class HBMPDFLT_SMOKE : SeleniumTestScript
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
								try
				{
				this.ScriptLogger.WriteLine("START");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing SelectMenu on NavMenu...", Logger.MessageType.INF);
				SeleniumControl CP7Main_NavMenu = new SeleniumControl( sDriver, "NavMenu", "ID", "navCont");
				if(!sDriver.Instance.FindElement(By.CssSelector("div[class='navCont']")).Displayed) new SeleniumControl(sDriver,"Browse", "css", "span[id = 'goToLbl']").Click();
new SeleniumControl(sDriver,"People", "xpath","//div[@class='busItem'][.='People']").Click();
new SeleniumControl(sDriver,"Benefits", "xpath","//div[@class='deptItem'][.='Benefits']").Click();
new SeleniumControl(sDriver,"Benefit Entry and Creation", "xpath","//div[@class='navItem'][.='Benefit Entry and Creation']").Click();
new SeleniumControl(sDriver,"Manage Benefit Package Defaults", "xpath","//div[@class='navItem'][.='Manage Benefit Package Defaults']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPDFLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPDFLT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMPDFLT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HBMPDFLT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPDFLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPDFLT] Performing VerifyExists on TaxableEntity...", Logger.MessageType.INF);
				SeleniumControl HBMPDFLT_TaxableEntity = new SeleniumControl( sDriver, "TaxableEntity", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TAXBLE_ENTITY_ID']");
				Function.AssertEqual(true,HBMPDFLT_TaxableEntity.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPDFLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPDFLT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMPDFLT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMPDFLT_MainForm);
IWebElement formBttn = HBMPDFLT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HBMPDFLT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HBMPDFLT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPDFLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPDFLT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HBMPDFLT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMPDFLT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPDFLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPDFLT] Performing Click on BenefitPackageDefaultDetailsLink...", Logger.MessageType.INF);
				SeleniumControl HBMPDFLT_BenefitPackageDefaultDetailsLink = new SeleniumControl( sDriver, "BenefitPackageDefaultDetailsLink", "ID", "lnk_4064_HBMPDFLT_HBBENPKGDFLT_HDR");
				Function.WaitControlDisplayed(HBMPDFLT_BenefitPackageDefaultDetailsLink);
HBMPDFLT_BenefitPackageDefaultDetailsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPDFLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPDFLT] Performing VerifyExists on BenefitPackageDefaultDetailsForm...", Logger.MessageType.INF);
				SeleniumControl HBMPDFLT_BenefitPackageDefaultDetailsForm = new SeleniumControl( sDriver, "BenefitPackageDefaultDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMPDFLT_HBBENPKGDFLT_DETAIL_']/ancestor::form[1]");
				Function.AssertEqual(true,HBMPDFLT_BenefitPackageDefaultDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPDFLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPDFLT] Performing VerifyExist on BenefitPackageDefaultDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl HBMPDFLT_BenefitPackageDefaultDetailsFormTable = new SeleniumControl( sDriver, "BenefitPackageDefaultDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMPDFLT_HBBENPKGDFLT_DETAIL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HBMPDFLT_BenefitPackageDefaultDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPDFLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPDFLT] Performing ClickButton on BenefitPackageDefaultDetailsForm...", Logger.MessageType.INF);
				SeleniumControl HBMPDFLT_BenefitPackageDefaultDetailsForm = new SeleniumControl( sDriver, "BenefitPackageDefaultDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMPDFLT_HBBENPKGDFLT_DETAIL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HBMPDFLT_BenefitPackageDefaultDetailsForm);
IWebElement formBttn = HBMPDFLT_BenefitPackageDefaultDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HBMPDFLT_BenefitPackageDefaultDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HBMPDFLT_BenefitPackageDefaultDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPDFLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPDFLT] Performing VerifyExists on BenefitPackageDefaultDetails_DefaultBenefitPackage...", Logger.MessageType.INF);
				SeleniumControl HBMPDFLT_BenefitPackageDefaultDetails_DefaultBenefitPackage = new SeleniumControl( sDriver, "BenefitPackageDefaultDetails_DefaultBenefitPackage", "xpath", "//div[translate(@id,'0123456789','')='pr__HBMPDFLT_HBBENPKGDFLT_DETAIL_']/ancestor::form[1]/descendant::*[@id='BEN_PKG_CD']");
				Function.AssertEqual(true,HBMPDFLT_BenefitPackageDefaultDetails_DefaultBenefitPackage.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HBMPDFLT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HBMPDFLT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HBMPDFLT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HBMPDFLT_MainForm);
IWebElement formBttn = HBMPDFLT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

