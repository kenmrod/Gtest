 
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
    public class PRMFTT_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Federal Tax Tables", "xpath","//div[@class='navItem'][.='Manage Federal Tax Tables']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Checking the App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTT] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMFTT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PRMFTT_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTT] Performing VerifyExists on EffectiveDate...", Logger.MessageType.INF);
				SeleniumControl PRMFTT_EffectiveDate = new SeleniumControl( sDriver, "EffectiveDate", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='EFFECT_DT']");
				Function.AssertEqual(true,PRMFTT_EffectiveDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTT] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMFTT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMFTT_MainForm);
IWebElement formBttn = PRMFTT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PRMFTT_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PRMFTT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTT] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMFTT_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMFTT_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTT] Performing VerifyExists on FederalTaxTableLink...", Logger.MessageType.INF);
				SeleniumControl PRMFTT_FederalTaxTableLink = new SeleniumControl( sDriver, "FederalTaxTableLink", "ID", "lnk_3977_PRMFTT_FEDTAXTBL_HDR");
				Function.AssertEqual(true,PRMFTT_FederalTaxTableLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTT] Performing Click on FederalTaxTableLink...", Logger.MessageType.INF);
				SeleniumControl PRMFTT_FederalTaxTableLink = new SeleniumControl( sDriver, "FederalTaxTableLink", "ID", "lnk_3977_PRMFTT_FEDTAXTBL_HDR");
				Function.WaitControlDisplayed(PRMFTT_FederalTaxTableLink);
PRMFTT_FederalTaxTableLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTT] Performing VerifyExists on FederalTaxTableForm...", Logger.MessageType.INF);
				SeleniumControl PRMFTT_FederalTaxTableForm = new SeleniumControl( sDriver, "FederalTaxTableForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMFTT_FEDTAXTBL_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PRMFTT_FederalTaxTableForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTT] Performing VerifyExist on FederalTaxTableFormTable...", Logger.MessageType.INF);
				SeleniumControl PRMFTT_FederalTaxTableFormTable = new SeleniumControl( sDriver, "FederalTaxTableFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMFTT_FEDTAXTBL_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PRMFTT_FederalTaxTableFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTT] Performing Click on FederalTaxTable_Ok...", Logger.MessageType.INF);
				SeleniumControl PRMFTT_FederalTaxTable_Ok = new SeleniumControl( sDriver, "FederalTaxTable_Ok", "xpath", "//div[translate(@id,'0123456789','')='pr__PRMFTT_FEDTAXTBL_CTW_']/ancestor::form[1]/following-sibling::div[1]/descendant::*[@id='bOk']");
				Function.WaitControlDisplayed(PRMFTT_FederalTaxTable_Ok);
if (PRMFTT_FederalTaxTable_Ok.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
PRMFTT_FederalTaxTable_Ok.Click(5,5);
else PRMFTT_FederalTaxTable_Ok.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing the App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PRMFTT";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PRMFTT] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PRMFTT_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PRMFTT_MainForm);
IWebElement formBttn = PRMFTT_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

