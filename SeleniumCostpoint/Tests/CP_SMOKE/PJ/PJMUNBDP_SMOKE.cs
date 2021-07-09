 
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
    public class PJMUNBDP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Period Budgets", "xpath","//div[@class='navItem'][.='Period Budgets']").Click();
new SeleniumControl(sDriver,"Manage Project Unit Budgets By Period", "xpath","//div[@class='navItem'][.='Manage Project Unit Budgets By Period']").Click();


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
				Function.CurrentComponent = "PJMUNBDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMUNBDP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMUNBDP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJMUNBDP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMUNBDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMUNBDP] Performing VerifyExists on Project...", Logger.MessageType.INF);
				SeleniumControl PJMUNBDP_Project = new SeleniumControl( sDriver, "Project", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,PJMUNBDP_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMUNBDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMUNBDP] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMUNBDP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMUNBDP_MainForm);
IWebElement formBttn = PJMUNBDP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? PJMUNBDP_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
PJMUNBDP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMUNBDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMUNBDP] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMUNBDP_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMUNBDP_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Project Unit Budgets By Period Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMUNBDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMUNBDP] Performing VerifyExists on ProjectUnitBudgetsByPeriodDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJMUNBDP_ProjectUnitBudgetsByPeriodDetailLink = new SeleniumControl( sDriver, "ProjectUnitBudgetsByPeriodDetailLink", "ID", "lnk_1001808_PJMUNBDP_PROJBUDUNITS_HDR");
				Function.AssertEqual(true,PJMUNBDP_ProjectUnitBudgetsByPeriodDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMUNBDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMUNBDP] Performing Click on ProjectUnitBudgetsByPeriodDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJMUNBDP_ProjectUnitBudgetsByPeriodDetailLink = new SeleniumControl( sDriver, "ProjectUnitBudgetsByPeriodDetailLink", "ID", "lnk_1001808_PJMUNBDP_PROJBUDUNITS_HDR");
				Function.WaitControlDisplayed(PJMUNBDP_ProjectUnitBudgetsByPeriodDetailLink);
PJMUNBDP_ProjectUnitBudgetsByPeriodDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMUNBDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMUNBDP] Performing VerifyExist on ProjectUnitBudgetsByPeriodChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJMUNBDP_ProjectUnitBudgetsByPeriodChildFormTable = new SeleniumControl( sDriver, "ProjectUnitBudgetsByPeriodChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMUNBDP_PROJBUDUNITS_CHILD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJMUNBDP_ProjectUnitBudgetsByPeriodChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMUNBDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMUNBDP] Performing ClickButton on ProjectUnitBudgetsByPeriodChildForm...", Logger.MessageType.INF);
				SeleniumControl PJMUNBDP_ProjectUnitBudgetsByPeriodChildForm = new SeleniumControl( sDriver, "ProjectUnitBudgetsByPeriodChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMUNBDP_PROJBUDUNITS_CHILD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJMUNBDP_ProjectUnitBudgetsByPeriodChildForm);
IWebElement formBttn = PJMUNBDP_ProjectUnitBudgetsByPeriodChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJMUNBDP_ProjectUnitBudgetsByPeriodChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJMUNBDP_ProjectUnitBudgetsByPeriodChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMUNBDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMUNBDP] Performing VerifyExists on ProjectUnitBudgetsByPeriodChildForm...", Logger.MessageType.INF);
				SeleniumControl PJMUNBDP_ProjectUnitBudgetsByPeriodChildForm = new SeleniumControl( sDriver, "ProjectUnitBudgetsByPeriodChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMUNBDP_PROJBUDUNITS_CHILD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJMUNBDP_ProjectUnitBudgetsByPeriodChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJMUNBDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMUNBDP] Performing VerifyExists on ProjectUnitBudgetsByPeriodChild_Period...", Logger.MessageType.INF);
				SeleniumControl PJMUNBDP_ProjectUnitBudgetsByPeriodChild_Period = new SeleniumControl( sDriver, "ProjectUnitBudgetsByPeriodChild_Period", "xpath", "//div[translate(@id,'0123456789','')='pr__PJMUNBDP_PROJBUDUNITS_CHILD_']/ancestor::form[1]/descendant::*[@id='PD_NO']");
				Function.AssertEqual(true,PJMUNBDP_ProjectUnitBudgetsByPeriodChild_Period.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PJMUNBDP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJMUNBDP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJMUNBDP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJMUNBDP_MainForm);
IWebElement formBttn = PJMUNBDP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

