 
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
    public class MUMRPD_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Multicurrency", "xpath","//div[@class='deptItem'][.='Multicurrency']").Click();
new SeleniumControl(sDriver,"Exchange Rates", "xpath","//div[@class='navItem'][.='Exchange Rates']").Click();
new SeleniumControl(sDriver,"Manage Exchange Rates by Period", "xpath","//div[@class='navItem'][.='Manage Exchange Rates by Period']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
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
				this.ScriptLogger.WriteLine("MAINFORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRPD] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUMRPD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MUMRPD_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRPD] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl MUMRPD_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MUMRPD_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRPD] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUMRPD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MUMRPD_MainForm);
IWebElement formBttn = MUMRPD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MUMRPD_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MUMRPD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRPD] Performing VerifyExists on RateGroup...", Logger.MessageType.INF);
				SeleniumControl MUMRPD_RateGroup = new SeleniumControl( sDriver, "RateGroup", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='RT_GRP_ID']");
				Function.AssertEqual(true,MUMRPD_RateGroup.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Period Information Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRPD] Performing VerifyExists on PeriodInformationForm...", Logger.MessageType.INF);
				SeleniumControl MUMRPD_PeriodInformationForm = new SeleniumControl( sDriver, "PeriodInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMRPD_RTBYPD_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MUMRPD_PeriodInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRPD] Performing VerifyExist on PeriodInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl MUMRPD_PeriodInformationFormTable = new SeleniumControl( sDriver, "PeriodInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMRPD_RTBYPD_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MUMRPD_PeriodInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRPD] Performing ClickButton on PeriodInformationForm...", Logger.MessageType.INF);
				SeleniumControl MUMRPD_PeriodInformationForm = new SeleniumControl( sDriver, "PeriodInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMRPD_RTBYPD_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MUMRPD_PeriodInformationForm);
IWebElement formBttn = MUMRPD_PeriodInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MUMRPD_PeriodInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MUMRPD_PeriodInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MUMRPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRPD] Performing VerifyExists on PeriodInformation_FiscalYear...", Logger.MessageType.INF);
				SeleniumControl MUMRPD_PeriodInformation_FiscalYear = new SeleniumControl( sDriver, "PeriodInformation_FiscalYear", "xpath", "//div[translate(@id,'0123456789','')='pr__MUMRPD_RTBYPD_CTW_']/ancestor::form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,MUMRPD_PeriodInformation_FiscalYear.Exists());

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
				Function.CurrentComponent = "MUMRPD";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MUMRPD] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MUMRPD_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MUMRPD_MainForm);
IWebElement formBttn = MUMRPD_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

