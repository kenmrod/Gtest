 
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
    public class GLMCFLOW_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Preliminary Cash Flow Statements", "xpath","//div[@class='navItem'][.='Manage Preliminary Cash Flow Statements']").Click();


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
								try {
				Function.CurrentComponent = "GLMCFLOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCFLOW] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMCFLOW_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMCFLOW_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCFLOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCFLOW] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMCFLOW_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMCFLOW_MainForm);
IWebElement formBttn = GLMCFLOW_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMCFLOW_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMCFLOW_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCFLOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCFLOW] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMCFLOW_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,GLMCFLOW_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCFLOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCFLOW] Performing VerifyExists on Identification_FSCode...", Logger.MessageType.INF);
				SeleniumControl GLMCFLOW_Identification_FSCode = new SeleniumControl( sDriver, "Identification_FSCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FS_CD']");
				Function.AssertEqual(true,GLMCFLOW_Identification_FSCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCFLOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCFLOW] Performing VerifyExist on CashFlowDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl GLMCFLOW_CashFlowDetailsFormTable = new SeleniumControl( sDriver, "CashFlowDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMCFLOW_FSLNADJ_CH_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,GLMCFLOW_CashFlowDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCFLOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCFLOW] Performing ClickButton on CashFlowDetailsForm...", Logger.MessageType.INF);
				SeleniumControl GLMCFLOW_CashFlowDetailsForm = new SeleniumControl( sDriver, "CashFlowDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMCFLOW_FSLNADJ_CH_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMCFLOW_CashFlowDetailsForm);
IWebElement formBttn = GLMCFLOW_CashFlowDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? GLMCFLOW_CashFlowDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
GLMCFLOW_CashFlowDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCFLOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCFLOW] Performing VerifyExists on CashFlowDetailsForm...", Logger.MessageType.INF);
				SeleniumControl GLMCFLOW_CashFlowDetailsForm = new SeleniumControl( sDriver, "CashFlowDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMCFLOW_FSLNADJ_CH_']/ancestor::form[1]");
				Function.AssertEqual(true,GLMCFLOW_CashFlowDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCFLOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCFLOW] Performing VerifyExists on CashFlowDetails_ActivityType...", Logger.MessageType.INF);
				SeleniumControl GLMCFLOW_CashFlowDetails_ActivityType = new SeleniumControl( sDriver, "CashFlowDetails_ActivityType", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMCFLOW_FSLNADJ_CH_']/ancestor::form[1]/descendant::*[@id='FS_S_CF_ACTVTY_CD']");
				Function.AssertEqual(true,GLMCFLOW_CashFlowDetails_ActivityType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CLOSE APP");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCFLOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCFLOW] Performing ClickButton on CashFlowDetailsForm...", Logger.MessageType.INF);
				SeleniumControl GLMCFLOW_CashFlowDetailsForm = new SeleniumControl( sDriver, "CashFlowDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__GLMCFLOW_FSLNADJ_CH_']/ancestor::form[1]");
				Function.WaitControlDisplayed(GLMCFLOW_CashFlowDetailsForm);
IWebElement formBttn = GLMCFLOW_CashFlowDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).Count <= 0 ? GLMCFLOW_CashFlowDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Delete')]")).FirstOrDefault() :
GLMCFLOW_CashFlowDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Delete']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Delete not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Save')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Save.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "GLMCFLOW";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[GLMCFLOW] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl GLMCFLOW_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(GLMCFLOW_MainForm);
IWebElement formBttn = GLMCFLOW_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

