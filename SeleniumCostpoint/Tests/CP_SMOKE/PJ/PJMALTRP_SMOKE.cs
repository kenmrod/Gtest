 
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
    public class PJMALTRP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Project Setup", "xpath","//div[@class='deptItem'][.='Project Setup']").Click();
new SeleniumControl(sDriver,"Alternate Projects", "xpath","//div[@class='navItem'][.='Alternate Projects']").Click();
new SeleniumControl(sDriver,"Manage Alternate Projects", "xpath","//div[@class='navItem'][.='Manage Alternate Projects']").Click();


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
				Function.CurrentComponent = "PJMALTRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALTRP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMALTRP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMALTRP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALTRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALTRP] Performing VerifyExists on ProjectReportName...", Logger.MessageType.INF);
				SeleniumControl PJMALTRP_ProjectReportName = new SeleniumControl( sDriver, "ProjectReportName", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_RPT_ID']");
				Function.AssertEqual(true,PJMALTRP_ProjectReportName.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALTRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALTRP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMALTRP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMALTRP_MainForm);
IWebElement formBttn = PJMALTRP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMALTRP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMALTRP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALTRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALTRP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMALTRP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMALTRP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("CHILD FORM");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALTRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALTRP] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PJMALTRP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALTRP_TOPLVLRPT_TBLVIEW_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMALTRP_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALTRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALTRP] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMALTRP_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALTRP_TOPLVLRPT_TBLVIEW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMALTRP_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("SELECTED PROJECTS");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALTRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALTRP] Performing VerifyExists on ProjectsForm...", Logger.MessageType.INF);
				SeleniumControl PJMALTRP_ProjectsForm = new SeleniumControl( sDriver, "ProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALTRP_PROJEDIT_PROJ_FROMCTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMALTRP_ProjectsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALTRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALTRP] Performing VerifyExist on ProjectsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMALTRP_ProjectsFormTable = new SeleniumControl( sDriver, "ProjectsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALTRP_PROJEDIT_PROJ_FROMCTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMALTRP_ProjectsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALTRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALTRP] Performing VerifyExists on Projects_Select...", Logger.MessageType.INF);
				SeleniumControl PJMALTRP_Projects_Select = new SeleniumControl( sDriver, "Projects_Select", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALTRP_PROJEDIT_PROJ_FROMCTW_']/ancestor::form[1]/descendant::*[contains(@id,'BUTTON__SELECT') and contains(@style,'visible')]");
				Function.AssertEqual(true,PJMALTRP_Projects_Select.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALTRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALTRP] Performing VerifyExists on SelectedProjectsForm...", Logger.MessageType.INF);
				SeleniumControl PJMALTRP_SelectedProjectsForm = new SeleniumControl( sDriver, "SelectedProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALTRP_PROJRPTPROJ_TOCTW_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMALTRP_SelectedProjectsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMALTRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALTRP] Performing VerifyExist on SelectedProjectsFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMALTRP_SelectedProjectsFormTable = new SeleniumControl( sDriver, "SelectedProjectsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMALTRP_PROJRPTPROJ_TOCTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMALTRP_SelectedProjectsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
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
				Function.CurrentComponent = "PJMALTRP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMALTRP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMALTRP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMALTRP_MainForm);
IWebElement formBttn = PJMALTRP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

