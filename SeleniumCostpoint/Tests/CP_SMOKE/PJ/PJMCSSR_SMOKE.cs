 
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
    public class PJMCSSR_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Budgeting and ETC", "xpath","//div[@class='deptItem'][.='Budgeting and ETC']").Click();
new SeleniumControl(sDriver,"Cost Schedule Status Report", "xpath","//div[@class='navItem'][.='Cost Schedule Status Report']").Click();
new SeleniumControl(sDriver,"Manage CSSR Information", "xpath","//div[@class='navItem'][.='Manage CSSR Information']").Click();


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
				Function.CurrentComponent = "PJMCSSR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCSSR] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMCSSR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMCSSR_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCSSR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCSSR] Performing VerifyExists on SelectionRanges_Category...", Logger.MessageType.INF);
				SeleniumControl PJMCSSR_SelectionRanges_Category = new SeleniumControl( sDriver, "SelectionRanges_Category", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='SELECT_BY_CD']");
				Function.AssertEqual(true,PJMCSSR_SelectionRanges_Category.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCSSR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCSSR] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMCSSR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMCSSR_MainForm);
IWebElement formBttn = PJMCSSR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMCSSR_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMCSSR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCSSR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCSSR] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMCSSR_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMCSSR_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CSSR Project Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCSSR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCSSR] Performing VerifyExists on CSSRProjectDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJMCSSR_CSSRProjectDetailLink = new SeleniumControl( sDriver, "CSSRProjectDetailLink", "ID", "lnk_3811_PJMCSSR_PROJCSSRINFO_HEADER");
				Function.AssertEqual(true,PJMCSSR_CSSRProjectDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCSSR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCSSR] Performing Click on CSSRProjectDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJMCSSR_CSSRProjectDetailLink = new SeleniumControl( sDriver, "CSSRProjectDetailLink", "ID", "lnk_3811_PJMCSSR_PROJCSSRINFO_HEADER");
				Function.WaitControlDisplayed(PJMCSSR_CSSRProjectDetailLink);
PJMCSSR_CSSRProjectDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCSSR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCSSR] Performing VerifyExist on CSSRProjectDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMCSSR_CSSRProjectDetailsFormTable = new SeleniumControl( sDriver, "CSSRProjectDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMCSSR_PROJCSSRINFO_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMCSSR_CSSRProjectDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCSSR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCSSR] Performing ClickButton on CSSRProjectDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMCSSR_CSSRProjectDetailsForm = new SeleniumControl( sDriver, "CSSRProjectDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMCSSR_PROJCSSRINFO_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMCSSR_CSSRProjectDetailsForm);
IWebElement formBttn = PJMCSSR_CSSRProjectDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMCSSR_CSSRProjectDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMCSSR_CSSRProjectDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCSSR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCSSR] Performing VerifyExists on CSSRProjectDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMCSSR_CSSRProjectDetailsForm = new SeleniumControl( sDriver, "CSSRProjectDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMCSSR_PROJCSSRINFO_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMCSSR_CSSRProjectDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCSSR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCSSR] Performing VerifyExists on CSSRProjectDetails_Project...", Logger.MessageType.INF);
				SeleniumControl PJMCSSR_CSSRProjectDetails_Project = new SeleniumControl( sDriver, "CSSRProjectDetails_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMCSSR_PROJCSSRINFO_CHILD_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMCSSR_CSSRProjectDetails_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCSSR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCSSR] Performing Close on CSSRProjectDetailsForm...", Logger.MessageType.INF);
				SeleniumControl PJMCSSR_CSSRProjectDetailsForm = new SeleniumControl( sDriver, "CSSRProjectDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMCSSR_PROJCSSRINFO_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMCSSR_CSSRProjectDetailsForm);
IWebElement formBttn = PJMCSSR_CSSRProjectDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMCSSR";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMCSSR] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMCSSR_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMCSSR_MainForm);
IWebElement formBttn = PJMCSSR_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

