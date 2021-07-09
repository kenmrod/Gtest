 
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
    public class HAMAPSET_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Affirmative Action", "xpath","//div[@class='deptItem'][.='Affirmative Action']").Click();
new SeleniumControl(sDriver,"Affirmative Action Plan Information", "xpath","//div[@class='navItem'][.='Affirmative Action Plan Information']").Click();
new SeleniumControl(sDriver,"Manage Affirmative Action Plans", "xpath","//div[@class='navItem'][.='Manage Affirmative Action Plans']").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SelectMenu]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("MainForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,HAMAPSET_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing VerifyExists on AffirmativeActionPlanCode...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_AffirmativeActionPlanCode = new SeleniumControl( sDriver, "AffirmativeActionPlanCode", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='AFF_PLAN_CD']");
				Function.AssertEqual(true,HAMAPSET_AffirmativeActionPlanCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Main Table");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HAMAPSET_MainForm);
IWebElement formBttn = HAMAPSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? HAMAPSET_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
HAMAPSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HAMAPSET_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing VerifyExists on AssignLaborLocationsLink...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_AssignLaborLocationsLink = new SeleniumControl( sDriver, "AssignLaborLocationsLink", "ID", "lnk_1002360_HAMAPSET_HAFFPLANSETUP_MAIN");
				Function.AssertEqual(true,HAMAPSET_AssignLaborLocationsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing Click on AssignLaborLocationsLink...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_AssignLaborLocationsLink = new SeleniumControl( sDriver, "AssignLaborLocationsLink", "ID", "lnk_1002360_HAMAPSET_HAFFPLANSETUP_MAIN");
				Function.WaitControlDisplayed(HAMAPSET_AssignLaborLocationsLink);
HAMAPSET_AssignLaborLocationsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Assign Labor Locations");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing VerifyExist on AssignLaborLocationsTable...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_AssignLaborLocationsTable = new SeleniumControl( sDriver, "AssignLaborLocationsTable", "xpath", "//div[translate(@id,'0123456789','')='pr__HAMAPSET_LABLOCATION_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HAMAPSET_AssignLaborLocationsTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing VerifyExists on WeightedPercentagesLink...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_WeightedPercentagesLink = new SeleniumControl( sDriver, "WeightedPercentagesLink", "ID", "lnk_1002363_HAMAPSET_HAFFPLANSETUP_MAIN");
				Function.AssertEqual(true,HAMAPSET_WeightedPercentagesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing Click on WeightedPercentagesLink...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_WeightedPercentagesLink = new SeleniumControl( sDriver, "WeightedPercentagesLink", "ID", "lnk_1002363_HAMAPSET_HAFFPLANSETUP_MAIN");
				Function.WaitControlDisplayed(HAMAPSET_WeightedPercentagesLink);
HAMAPSET_WeightedPercentagesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Weighted Percentages");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing VerifyExist on WeightedPercentages_Table...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_WeightedPercentages_Table = new SeleniumControl( sDriver, "WeightedPercentages_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__HAMAPSET_HAFFWTPCT_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HAMAPSET_WeightedPercentages_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing VerifyExists on ApplicantDataLink...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_ApplicantDataLink = new SeleniumControl( sDriver, "ApplicantDataLink", "ID", "lnk_1002364_HAMAPSET_HAFFPLANSETUP_MAIN");
				Function.AssertEqual(true,HAMAPSET_ApplicantDataLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing Click on ApplicantDataLink...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_ApplicantDataLink = new SeleniumControl( sDriver, "ApplicantDataLink", "ID", "lnk_1002364_HAMAPSET_HAFFPLANSETUP_MAIN");
				Function.WaitControlDisplayed(HAMAPSET_ApplicantDataLink);
HAMAPSET_ApplicantDataLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Application Data");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing VerifyExist on ApplicantData_Table...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_ApplicantData_Table = new SeleniumControl( sDriver, "ApplicantData_Table", "xpath", "//div[translate(@id,'0123456789','')='pr__HAMAPSET_HAPPLICNTDATA_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,HAMAPSET_ApplicantData_Table.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close Application");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "HAMAPSET";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[HAMAPSET] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl HAMAPSET_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(HAMAPSET_MainForm);
IWebElement formBttn = HAMAPSET_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

