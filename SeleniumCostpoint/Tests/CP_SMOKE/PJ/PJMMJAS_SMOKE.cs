 
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
    public class PJMMJAS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Projects", "xpath","//div[@class='busItem'][.='Projects']").Click();
new SeleniumControl(sDriver,"Cost and Revenue Processing", "xpath","//div[@class='deptItem'][.='Cost and Revenue Processing']").Click();
new SeleniumControl(sDriver,"Multi-Job Processing", "xpath","//div[@class='navItem'][.='Multi-Job Processing']").Click();
new SeleniumControl(sDriver,"Manage Multi-Job Allocation Information", "xpath","//div[@class='navItem'][.='Manage Multi-Job Allocation Information']").Click();


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
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMMJAS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing VerifyExists on MainForm_ProjectAllocationCode...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_MainForm_ProjectAllocationCode = new SeleniumControl( sDriver, "MainForm_ProjectAllocationCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ALLOC_CD']");
				Function.AssertEqual(true,PJMMJAS_MainForm_ProjectAllocationCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("LINK");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing VerifyExists on MainForm_CostAccountsLink...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_MainForm_CostAccountsLink = new SeleniumControl( sDriver, "MainForm_CostAccountsLink", "ID", "lnk_1001901_PJMMJAS_PROJALLOC_HDR");
				Function.AssertEqual(true,PJMMJAS_MainForm_CostAccountsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing Click on MainForm_CostAccountsLink...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_MainForm_CostAccountsLink = new SeleniumControl( sDriver, "MainForm_CostAccountsLink", "ID", "lnk_1001901_PJMMJAS_PROJALLOC_HDR");
				Function.WaitControlDisplayed(PJMMJAS_MainForm_CostAccountsLink);
PJMMJAS_MainForm_CostAccountsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing VerifyExist on CostAccounts_CostAccountsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_CostAccounts_CostAccountsFormTable = new SeleniumControl( sDriver, "CostAccounts_CostAccountsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMMJAS_PROJALLOCACCT_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMMJAS_CostAccounts_CostAccountsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing VerifyExists on MainForm_CostHoursBaseLink...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_MainForm_CostHoursBaseLink = new SeleniumControl( sDriver, "MainForm_CostHoursBaseLink", "ID", "lnk_1001902_PJMMJAS_PROJALLOC_HDR");
				Function.AssertEqual(true,PJMMJAS_MainForm_CostHoursBaseLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing Close on CostAccountsForm...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_CostAccountsForm = new SeleniumControl( sDriver, "CostAccountsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMMJAS_PROJALLOCACCT_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMMJAS_CostAccountsForm);
IWebElement formBttn = PJMMJAS_CostAccountsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing Click on MainForm_CostHoursBaseLink...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_MainForm_CostHoursBaseLink = new SeleniumControl( sDriver, "MainForm_CostHoursBaseLink", "ID", "lnk_1001902_PJMMJAS_PROJALLOC_HDR");
				Function.WaitControlDisplayed(PJMMJAS_MainForm_CostHoursBaseLink);
PJMMJAS_MainForm_CostHoursBaseLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing VerifyExist on CostHoursBaseFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_CostHoursBaseFormTable = new SeleniumControl( sDriver, "CostHoursBaseFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMMJAS_PROJALLOCQTYBASE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMMJAS_CostHoursBaseFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing ClickButton on CostHoursBaseForm...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_CostHoursBaseForm = new SeleniumControl( sDriver, "CostHoursBaseForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMMJAS_PROJALLOCQTYBASE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMMJAS_CostHoursBaseForm);
IWebElement formBttn = PJMMJAS_CostHoursBaseForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMMJAS_CostHoursBaseForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMMJAS_CostHoursBaseForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing VerifyExists on CostHoursBaseForm...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_CostHoursBaseForm = new SeleniumControl( sDriver, "CostHoursBaseForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMMJAS_PROJALLOCQTYBASE_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMMJAS_CostHoursBaseForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing VerifyExists on CostHoursBase_Line...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_CostHoursBase_Line = new SeleniumControl( sDriver, "CostHoursBase_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMMJAS_PROJALLOCQTYBASE_']/ancestor::form[1]/descendant::*[@id='LN_NO']");
				Function.AssertEqual(true,PJMMJAS_CostHoursBase_Line.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing Close on CostHoursBaseForm...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_CostHoursBaseForm = new SeleniumControl( sDriver, "CostHoursBaseForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMMJAS_PROJALLOCQTYBASE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMMJAS_CostHoursBaseForm);
IWebElement formBttn = PJMMJAS_CostHoursBaseForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing VerifyExists on MainForm_PercentageBaseLink...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_MainForm_PercentageBaseLink = new SeleniumControl( sDriver, "MainForm_PercentageBaseLink", "ID", "lnk_1007113_PJMMJAS_PROJALLOC_HDR");
				Function.AssertEqual(true,PJMMJAS_MainForm_PercentageBaseLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing Click on MainForm_PercentageBaseLink...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_MainForm_PercentageBaseLink = new SeleniumControl( sDriver, "MainForm_PercentageBaseLink", "ID", "lnk_1007113_PJMMJAS_PROJALLOC_HDR");
				Function.WaitControlDisplayed(PJMMJAS_MainForm_PercentageBaseLink);
PJMMJAS_MainForm_PercentageBaseLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing VerifyExist on PercentageBaseFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_PercentageBaseFormTable = new SeleniumControl( sDriver, "PercentageBaseFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMMJAS_PROJALLOCPCTBASE_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMMJAS_PercentageBaseFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing ClickButton on PercentageBaseForm...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_PercentageBaseForm = new SeleniumControl( sDriver, "PercentageBaseForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMMJAS_PROJALLOCPCTBASE_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMMJAS_PercentageBaseForm);
IWebElement formBttn = PJMMJAS_PercentageBaseForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMMJAS_PercentageBaseForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMMJAS_PercentageBaseForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing VerifyExists on PercentageBaseForm...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_PercentageBaseForm = new SeleniumControl( sDriver, "PercentageBaseForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMMJAS_PROJALLOCPCTBASE_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMMJAS_PercentageBaseForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing VerifyExists on PercentageBase_Line...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_PercentageBase_Line = new SeleniumControl( sDriver, "PercentageBase_Line", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMMJAS_PROJALLOCPCTBASE_']/ancestor::form[1]/descendant::*[@id='LN_NO']");
				Function.AssertEqual(true,PJMMJAS_PercentageBase_Line.Exists());

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
				Function.CurrentComponent = "PJMMJAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMMJAS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMMJAS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMMJAS_MainForm);
IWebElement formBttn = PJMMJAS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Dialog";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Function.ClickOkDialogWithMessage("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogWithMessage]" , ex.Message));
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

