 
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
    public class HSMREAS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Personnel", "xpath","//div[@class='deptItem'][.='Personnel']").Click();
new SeleniumControl(sDriver,"Personnel Information", "xpath","//div[@class='navItem'][.='Personnel Information']").Click();
new SeleniumControl(sDriver,"Manage Personnel Actions", "xpath","//div[@class='navItem'][.='Manage Personnel Actions']").Click();


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
				Function.CurrentComponent = "HSMREAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMREAS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMREAS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HSMREAS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMREAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMREAS] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMREAS_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMREAS_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMREAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMREAS] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMREAS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMREAS_MainForm);
IWebElement formBttn = HSMREAS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? HSMREAS_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
HSMREAS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMREAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMREAS] Performing VerifyExists on PersonnelActionCode...", Logger.MessageType.INF);
				SeleniumControl HSMREAS_PersonnelActionCode = new SeleniumControl( sDriver, "PersonnelActionCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PERS_ACT_RSN_CD']");
				Function.AssertEqual(true,HSMREAS_PersonnelActionCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Required Forms by Personnel Action");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMREAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMREAS] Performing VerifyExists on RequiredFormsByPersonnelActionLink...", Logger.MessageType.INF);
				SeleniumControl HSMREAS_RequiredFormsByPersonnelActionLink = new SeleniumControl( sDriver, "RequiredFormsByPersonnelActionLink", "ID", "lnk_4807_HSMREAS_PERSACTREASON_HDR");
				Function.AssertEqual(true,HSMREAS_RequiredFormsByPersonnelActionLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMREAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMREAS] Performing Click on RequiredFormsByPersonnelActionLink...", Logger.MessageType.INF);
				SeleniumControl HSMREAS_RequiredFormsByPersonnelActionLink = new SeleniumControl( sDriver, "RequiredFormsByPersonnelActionLink", "ID", "lnk_4807_HSMREAS_PERSACTREASON_HDR");
				Function.WaitControlDisplayed(HSMREAS_RequiredFormsByPersonnelActionLink);
HSMREAS_RequiredFormsByPersonnelActionLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMREAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMREAS] Performing VerifyExists on RequiredFormsByPersonnelActionForm...", Logger.MessageType.INF);
				SeleniumControl HSMREAS_RequiredFormsByPersonnelActionForm = new SeleniumControl( sDriver, "RequiredFormsByPersonnelActionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMREAS_HRQFRMPERRSN_TBL_']/ancestor::form[1]");
				Function.AssertEqual(true,HSMREAS_RequiredFormsByPersonnelActionForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMREAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMREAS] Performing VerifyExist on RequiredFormsByPersonnelActionFormTable...", Logger.MessageType.INF);
				SeleniumControl HSMREAS_RequiredFormsByPersonnelActionFormTable = new SeleniumControl( sDriver, "RequiredFormsByPersonnelActionFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMREAS_HRQFRMPERRSN_TBL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HSMREAS_RequiredFormsByPersonnelActionFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HSMREAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMREAS] Performing Close on RequiredFormsByPersonnelActionForm...", Logger.MessageType.INF);
				SeleniumControl HSMREAS_RequiredFormsByPersonnelActionForm = new SeleniumControl( sDriver, "RequiredFormsByPersonnelActionForm", "xpath", "//div[translate(@id,'0123456789','')='pr__HSMREAS_HRQFRMPERRSN_TBL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(HSMREAS_RequiredFormsByPersonnelActionForm);
IWebElement formBttn = HSMREAS_RequiredFormsByPersonnelActionForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "HSMREAS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HSMREAS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HSMREAS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HSMREAS_MainForm);
IWebElement formBttn = HSMREAS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

