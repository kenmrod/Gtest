 
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
    public class HKMSET_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Deferred Compensation Admin", "xpath","//div[@class='deptItem'][.='Deferred Compensation Admin']").Click();
new SeleniumControl(sDriver,"Deferred Compensation Plan Controls", "xpath","//div[@class='navItem'][.='Deferred Compensation Plan Controls']").Click();
new SeleniumControl(sDriver,"Manage Deferred Compensation Plans", "xpath","//div[@class='navItem'][.='Manage Deferred Compensation Plans']").Click();


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
				Function.CurrentComponent = "HKMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HKMSET] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HKMSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HKMSET_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HKMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HKMSET] Performing VerifyExists on DeferredCompensationPlan...", Logger.MessageType.INF);
				SeleniumControl HKMSET_DeferredCompensationPlan = new SeleniumControl( sDriver, "DeferredCompensationPlan", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='CODA_PLAN_CD']");
				Function.AssertEqual(true,HKMSET_DeferredCompensationPlan.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HKMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HKMSET] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HKMSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HKMSET_MainForm);
IWebElement formBttn = HKMSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HKMSET_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HKMSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HKMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HKMSET] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HKMSET_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HKMSET_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Plan Tax Information");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HKMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HKMSET] Performing VerifyExists on PlanTaxInformationLink...", Logger.MessageType.INF);
				SeleniumControl HKMSET_PlanTaxInformationLink = new SeleniumControl( sDriver, "PlanTaxInformationLink", "ID", "lnk_15549_HKMSET_HCODASETUP");
				Function.AssertEqual(true,HKMSET_PlanTaxInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HKMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HKMSET] Performing Click on PlanTaxInformationLink...", Logger.MessageType.INF);
				SeleniumControl HKMSET_PlanTaxInformationLink = new SeleniumControl( sDriver, "PlanTaxInformationLink", "ID", "lnk_15549_HKMSET_HCODASETUP");
				Function.WaitControlDisplayed(HKMSET_PlanTaxInformationLink);
HKMSET_PlanTaxInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HKMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HKMSET] Performing VerifyExists on PlanTaxInformationForm...", Logger.MessageType.INF);
				SeleniumControl HKMSET_PlanTaxInformationForm = new SeleniumControl( sDriver, "PlanTaxInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HKMSET_HCODATAXINFO_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,HKMSET_PlanTaxInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HKMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HKMSET] Performing VerifyExist on PlanTaxInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl HKMSET_PlanTaxInformationFormTable = new SeleniumControl( sDriver, "PlanTaxInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HKMSET_HCODATAXINFO_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HKMSET_PlanTaxInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HKMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HKMSET] Performing ClickButton on PlanTaxInformationForm...", Logger.MessageType.INF);
				SeleniumControl HKMSET_PlanTaxInformationForm = new SeleniumControl( sDriver, "PlanTaxInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HKMSET_HCODATAXINFO_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HKMSET_PlanTaxInformationForm);
IWebElement formBttn = HKMSET_PlanTaxInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HKMSET_PlanTaxInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HKMSET_PlanTaxInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HKMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HKMSET] Performing VerifyExists on PlanTaxInformationForm_PlanDates_StartDate...", Logger.MessageType.INF);
				SeleniumControl HKMSET_PlanTaxInformationForm_PlanDates_StartDate = new SeleniumControl( sDriver, "PlanTaxInformationForm_PlanDates_StartDate", "xpath", "//div[translate(@id,'0123456789','')='pr__HKMSET_HCODATAXINFO_DTL_']/ancestor::form[1]/descendant::*[@id='CODA_START_DT']");
				Function.AssertEqual(true,HKMSET_PlanTaxInformationForm_PlanDates_StartDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HKMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HKMSET] Performing Close on PlanTaxInformationForm...", Logger.MessageType.INF);
				SeleniumControl HKMSET_PlanTaxInformationForm = new SeleniumControl( sDriver, "PlanTaxInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HKMSET_HCODATAXINFO_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HKMSET_PlanTaxInformationForm);
IWebElement formBttn = HKMSET_PlanTaxInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "HKMSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HKMSET] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HKMSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HKMSET_MainForm);
IWebElement formBttn = HKMSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

