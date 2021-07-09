 
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
    public class PDMWARR_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials", "xpath","//div[@class='busItem'][.='Materials']").Click();
new SeleniumControl(sDriver,"Product Definition", "xpath","//div[@class='deptItem'][.='Product Definition']").Click();
new SeleniumControl(sDriver,"Product Billing", "xpath","//div[@class='navItem'][.='Product Billing']").Click();
new SeleniumControl(sDriver,"Manage Warranty Information", "xpath","//div[@class='navItem'][.='Manage Warranty Information']").Click();


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
				Function.CurrentComponent = "PDMWARR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMWARR] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMWARR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PDMWARR_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMWARR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMWARR] Performing VerifyExists on WarrantyCode...", Logger.MessageType.INF);
				SeleniumControl PDMWARR_WarrantyCode = new SeleniumControl( sDriver, "WarrantyCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WARR_CD']");
				Function.AssertEqual(true,PDMWARR_WarrantyCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMWARR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMWARR] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMWARR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMWARR_MainForm);
IWebElement formBttn = PDMWARR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PDMWARR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PDMWARR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMWARR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMWARR] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMWARR_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMWARR_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("DETAILSFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMWARR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMWARR] Performing VerifyExist on WarrantyTermsFormTable...", Logger.MessageType.INF);
				SeleniumControl PDMWARR_WarrantyTermsFormTable = new SeleniumControl( sDriver, "WarrantyTermsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMWARR_WARRANTYTERMS_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PDMWARR_WarrantyTermsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMWARR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMWARR] Performing ClickButton on WarrantyTermsForm...", Logger.MessageType.INF);
				SeleniumControl PDMWARR_WarrantyTermsForm = new SeleniumControl( sDriver, "WarrantyTermsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMWARR_WARRANTYTERMS_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PDMWARR_WarrantyTermsForm);
IWebElement formBttn = PDMWARR_WarrantyTermsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PDMWARR_WarrantyTermsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PDMWARR_WarrantyTermsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMWARR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMWARR] Performing VerifyExists on WarrantyTermsForm...", Logger.MessageType.INF);
				SeleniumControl PDMWARR_WarrantyTermsForm = new SeleniumControl( sDriver, "WarrantyTermsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMWARR_WARRANTYTERMS_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,PDMWARR_WarrantyTermsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMWARR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMWARR] Performing VerifyExists on WarrantyTerms_Line...", Logger.MessageType.INF);
				SeleniumControl PDMWARR_WarrantyTerms_Line = new SeleniumControl( sDriver, "WarrantyTerms_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__PDMWARR_WARRANTYTERMS_DTL_']/ancestor::form[1]/descendant::*[@id='LN_NO']");
				Function.AssertEqual(true,PDMWARR_WarrantyTerms_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PDMWARR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PDMWARR] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PDMWARR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PDMWARR_MainForm);
IWebElement formBttn = PDMWARR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

