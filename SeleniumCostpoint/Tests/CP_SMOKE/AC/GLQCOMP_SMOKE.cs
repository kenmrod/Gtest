 
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
    public class GLQCOMP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Accounting", "xpath","//div[@class='busItem'][.='Accounting']").Click();
new SeleniumControl(sDriver,"General Ledger", "xpath","//div[@class='deptItem'][.='General Ledger']").Click();
new SeleniumControl(sDriver,"General Ledger Reports/Inquiries", "xpath","//div[@class='navItem'][.='General Ledger Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"Compare General Ledger Actual to Budget Activity", "xpath","//div[@class='navItem'][.='Compare General Ledger Actual to Budget Activity']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQCOMP] Performing VerifyExists on FiscalYear...", Logger.MessageType.INF);
				SeleniumControl GLQCOMP_FiscalYear = new SeleniumControl( sDriver, "FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,GLQCOMP_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Child Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQCOMP] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQCOMP_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQCOMP_RPTFSCOMPARE_MAINTABLE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQCOMP_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQCOMP] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl GLQCOMP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQCOMP_RPTFSCOMPARE_MAINTABLE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQCOMP_ChildForm);
IWebElement formBttn = GLQCOMP_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQCOMP_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQCOMP_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQCOMP] Performing VerifyExists on ChildForm_Account...", Logger.MessageType.INF);
				SeleniumControl GLQCOMP_ChildForm_Account = new SeleniumControl( sDriver, "ChildForm_Account", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQCOMP_RPTFSCOMPARE_MAINTABLE_']/ancestor::form[1]/descendant::*[@id='ACCT_ID']");
				Function.AssertEqual(true,GLQCOMP_ChildForm_Account.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQCOMP] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl GLQCOMP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQCOMP_RPTFSCOMPARE_MAINTABLE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQCOMP_ChildForm);
IWebElement formBttn = GLQCOMP_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? GLQCOMP_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
GLQCOMP_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Find...", Logger.MessageType.INF);
				SeleniumControl Query_Find = new SeleniumControl( sDriver, "Find", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Find);
if (Query_Find.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Find.Click(5,5);
else Query_Find.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Period");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQCOMP] Performing Click on ChildForm_PeriodLink...", Logger.MessageType.INF);
				SeleniumControl GLQCOMP_ChildForm_PeriodLink = new SeleniumControl( sDriver, "ChildForm_PeriodLink", "ID", "lnk_1005969_GLQCOMP_RPTFSCOMPARE_MAINTABLE");
				Function.WaitControlDisplayed(GLQCOMP_ChildForm_PeriodLink);
GLQCOMP_ChildForm_PeriodLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQCOMP] Performing VerifyExist on ChildForm_PeriodFormTable...", Logger.MessageType.INF);
				SeleniumControl GLQCOMP_ChildForm_PeriodFormTable = new SeleniumControl( sDriver, "ChildForm_PeriodFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQCOMP_RPTFSCOMPARE_PERIOD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLQCOMP_ChildForm_PeriodFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQCOMP] Performing ClickButton on ChildForm_PeriodForm...", Logger.MessageType.INF);
				SeleniumControl GLQCOMP_ChildForm_PeriodForm = new SeleniumControl( sDriver, "ChildForm_PeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQCOMP_RPTFSCOMPARE_PERIOD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQCOMP_ChildForm_PeriodForm);
IWebElement formBttn = GLQCOMP_ChildForm_PeriodForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLQCOMP_ChildForm_PeriodForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLQCOMP_ChildForm_PeriodForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQCOMP] Performing VerifyExists on ChildForm_Period_Period...", Logger.MessageType.INF);
				SeleniumControl GLQCOMP_ChildForm_Period_Period = new SeleniumControl( sDriver, "ChildForm_Period_Period", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQCOMP_RPTFSCOMPARE_PERIOD_']/ancestor::form[1]/descendant::*[@id='PD_NO']");
				Function.AssertEqual(true,GLQCOMP_ChildForm_Period_Period.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQCOMP] Performing Close on ChildForm_PeriodForm...", Logger.MessageType.INF);
				SeleniumControl GLQCOMP_ChildForm_PeriodForm = new SeleniumControl( sDriver, "ChildForm_PeriodForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLQCOMP_RPTFSCOMPARE_PERIOD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLQCOMP_ChildForm_PeriodForm);
IWebElement formBttn = GLQCOMP_ChildForm_PeriodForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLQCOMP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLQCOMP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLQCOMP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLQCOMP_MainForm);
IWebElement formBttn = GLQCOMP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

