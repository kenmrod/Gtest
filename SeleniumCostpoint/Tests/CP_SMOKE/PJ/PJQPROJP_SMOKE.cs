 
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
    public class PJQPROJP_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Project Inquiry and Reporting", "xpath","//div[@class='deptItem'][.='Project Inquiry and Reporting']").Click();
new SeleniumControl(sDriver,"Project Reports/Inquiries", "xpath","//div[@class='navItem'][.='Project Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Project Activity by Level", "xpath","//div[@class='navItem'][.='View Project Activity by Level']").Click();


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
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJQPROJP_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_FiscalYear = new SeleniumControl( sDriver, "FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,PJQPROJP_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Budget Line Item Revisions");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTREVSUM_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJP_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTREVSUM_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm);
IWebElement formBttn = PJQPROJP_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PJQPROJP_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PJQPROJP_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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

				this.ScriptLogger.WriteLine("[Query] Performing Set on Find_CriteriaValue1...", Logger.MessageType.INF);
				SeleniumControl Query_Find_CriteriaValue1 = new SeleniumControl( sDriver, "Find_CriteriaValue1", "ID", "basicField0");
				Query_Find_CriteriaValue1.Click();
Query_Find_CriteriaValue1.SendKeys("RTR4", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
Query_Find_CriteriaValue1.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
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
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTREVSUM_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQPROJP_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_ProjectStatusLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_ProjectStatusLink = new SeleniumControl( sDriver, "ChildForm_ProjectStatusLink", "ID", "lnk_1006686_PJQPROJP_RPTREVSUM_CHLD");
				Function.AssertEqual(true,PJQPROJP_ChildForm_ProjectStatusLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_GLCLaborSummaryLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_GLCLaborSummaryLink = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummaryLink", "ID", "lnk_1006705_PJQPROJP_RPTREVSUM_CHLD");
				Function.AssertEqual(true,PJQPROJP_ChildForm_GLCLaborSummaryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_PLCLaborSummaryLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummaryLink = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummaryLink", "ID", "lnk_1006709_PJQPROJP_RPTREVSUM_CHLD");
				Function.AssertEqual(true,PJQPROJP_ChildForm_PLCLaborSummaryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_EmployeeLaborSummaryLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_EmployeeLaborSummaryLink = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummaryLink", "ID", "lnk_1006713_PJQPROJP_RPTREVSUM_CHLD");
				Function.AssertEqual(true,PJQPROJP_ChildForm_EmployeeLaborSummaryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing Click on ChildForm_ProjectStatusLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_ProjectStatusLink = new SeleniumControl( sDriver, "ChildForm_ProjectStatusLink", "ID", "lnk_1006686_PJQPROJP_RPTREVSUM_CHLD");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_ProjectStatusLink);
PJQPROJP_ChildForm_ProjectStatusLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Project Status");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_ProjectStatusForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_ProjectStatusForm = new SeleniumControl( sDriver, "ChildForm_ProjectStatusForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJP_ChildForm_ProjectStatusForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_ProjectStatus_PeriodOfPerformance...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_ProjectStatus_PeriodOfPerformance = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_PeriodOfPerformance", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRHDR_']/ancestor::form[1]/descendant::*[@id='PROJ_START_DT']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_ProjectStatus_PeriodOfPerformance.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_ProjectStatus_ProjectStatusChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChildForm = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRFINALDATA_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExist on ChildForm_ProjectStatus_ProjectStatusChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChildFormTable = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRFINALDATA_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing ClickButton on ChildForm_ProjectStatus_ProjectStatusChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChildForm = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRFINALDATA_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChildForm);
IWebElement formBttn = PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_ProjectStatus_ProjectStatusChild_Description...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChild_Description = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChild_Description", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRFINALDATA_']/ancestor::form[1]/descendant::*[@id='DESCRIPTION']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChild_Description.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_ProjectStatus_ProjectStatusChild_LaborDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChild_LaborDetailLink = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChild_LaborDetailLink", "ID", "lnk_1006688_PJQPROJP_PSRFINALDATA");
				Function.AssertEqual(true,PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChild_LaborDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_ProjectStatus_ProjectStatusChild_TransactionDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChild_TransactionDetailLink = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChild_TransactionDetailLink", "ID", "lnk_1006690_PJQPROJP_PSRFINALDATA");
				Function.AssertEqual(true,PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChild_TransactionDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_ProjectStatus_ProjectStatusChild_PoolDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChild_PoolDetailLink = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChild_PoolDetailLink", "ID", "lnk_1006694_PJQPROJP_PSRFINALDATA");
				Function.AssertEqual(true,PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChild_PoolDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_ProjectStatus_ProjectStatusChild_ProfitsLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChild_ProfitsLink = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChild_ProfitsLink", "ID", "lnk_1007284_PJQPROJP_PSRFINALDATA");
				Function.AssertEqual(true,PJQPROJP_ChildForm_ProjectStatus_ProjectStatusChild_ProfitsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing Close on ChildForm_ProjectStatusForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_ProjectStatusForm = new SeleniumControl( sDriver, "ChildForm_ProjectStatusForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_ProjectStatusForm);
IWebElement formBttn = PJQPROJP_ChildForm_ProjectStatusForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("GLC Labor Summary");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing Click on ChildForm_GLCLaborSummaryLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_GLCLaborSummaryLink = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummaryLink", "ID", "lnk_1006705_PJQPROJP_RPTREVSUM_CHLD");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_GLCLaborSummaryLink);
PJQPROJP_ChildForm_GLCLaborSummaryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_GLCLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_GLCLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRHDR_GLCLABSUM_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJP_ChildForm_GLCLaborSummaryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_GLCLaborSummary_PeriodOfPerformance...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_GLCLaborSummary_PeriodOfPerformance = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_PeriodOfPerformance", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRHDR_GLCLABSUM_']/ancestor::form[1]/descendant::*[@id='PROJ_START_DT']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_GLCLaborSummary_PeriodOfPerformance.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_GLCLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_GLCLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRHDR_GLCLABSUM_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJP_ChildForm_GLCLaborSummaryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExist on ChildForm_GLCLaborSummary_GLCLaborSummaryChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChildFormTable = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing ClickButton on ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm);
IWebElement formBttn = PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLC...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLC = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLC", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_']/ancestor::form[1]/descendant::*[@id='GEN_LAB_CAT']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLC.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLCLaborSummaryChildTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLCLaborSummaryChildTab = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLCLaborSummaryChildTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLCLaborSummaryChildTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing Select on ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLCLaborSummaryChildTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLCLaborSummaryChildTab = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLCLaborSummaryChildTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLCLaborSummaryChildTab);
IWebElement mTab = PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLCLaborSummaryChildTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Hours").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_GLCLaborSummary_GLCLaborSummaryChild_Hours_SubpdHrs...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_Hours_SubpdHrs = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChild_Hours_SubpdHrs", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_']/ancestor::form[1]/descendant::*[@id='SUB_PD_ACT_HRS']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_Hours_SubpdHrs.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_GLCLaborSummary_GLCLaborSummaryChild_EmployeeDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_EmployeeDetailLink = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChild_EmployeeDetailLink", "ID", "lnk_1006707_PJQPROJP_RPTPROJLABSUM");
				Function.AssertEqual(true,PJQPROJP_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_EmployeeDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing Close on ChildForm_GLCLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_GLCLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRHDR_GLCLABSUM_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_GLCLaborSummaryForm);
IWebElement formBttn = PJQPROJP_ChildForm_GLCLaborSummaryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("PLC Labor Summary");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing Click on ChildForm_PLCLaborSummaryLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummaryLink = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummaryLink", "ID", "lnk_1006709_PJQPROJP_RPTREVSUM_CHLD");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_PLCLaborSummaryLink);
PJQPROJP_ChildForm_PLCLaborSummaryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_PLCLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRHDR_PLCLABSUM_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJP_ChildForm_PLCLaborSummaryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_PLCLaborSummary_PeriodOfPerformance...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummary_PeriodOfPerformance = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PeriodOfPerformance", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRHDR_PLCLABSUM_']/ancestor::form[1]/descendant::*[@id='PROJ_START_DT']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_PLCLaborSummary_PeriodOfPerformance.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_PLCLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRHDR_PLCLABSUM_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJP_ChildForm_PLCLaborSummaryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExist on ChildForm_PLCLaborSummary_PLCLaborSummaryChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChildFormTable = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PLCLaborSummaryChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing ClickButton on ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm);
IWebElement formBttn = PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLC...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLC = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLC", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]/descendant::*[@id='LAB_CAT_CD']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLC.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing Select on ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab);
IWebElement mTab = PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Hours").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_PLCLaborSummary_PLCLaborSummaryChild_Hours_SubpdHrs...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_Hours_SubpdHrs = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PLCLaborSummaryChild_Hours_SubpdHrs", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]/descendant::*[@id='SUB_PD_ACT_HRS']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_Hours_SubpdHrs.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing Select on ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab);
IWebElement mTab = PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_PLCLaborSummaryChildTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Hours").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_PLCLaborSummary_PLCLaborSummaryChild_Hours_SubpdHrs...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_Hours_SubpdHrs = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PLCLaborSummaryChild_Hours_SubpdHrs", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]/descendant::*[@id='SUB_PD_ACT_HRS']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_Hours_SubpdHrs.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_PLCLaborSummary_PLCLaborSummaryChild_EmployeeDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_EmployeeDetailLink = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PLCLaborSummaryChild_EmployeeDetailLink", "ID", "lnk_1006711_PJQPROJP_RPTPROJLABSUM_PLCLAB");
				Function.AssertEqual(true,PJQPROJP_ChildForm_PLCLaborSummary_PLCLaborSummaryChild_EmployeeDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing Close on ChildForm_PLCLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_PLCLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_PSRHDR_PLCLABSUM_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_PLCLaborSummaryForm);
IWebElement formBttn = PJQPROJP_ChildForm_PLCLaborSummaryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Employee Labor Summary");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing Click on ChildForm_EmployeeLaborSummaryLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_EmployeeLaborSummaryLink = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummaryLink", "ID", "lnk_1006713_PJQPROJP_RPTREVSUM_CHLD");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_EmployeeLaborSummaryLink);
PJQPROJP_ChildForm_EmployeeLaborSummaryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_EmployeeLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_EmployeeLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_EMPLABR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJP_ChildForm_EmployeeLaborSummaryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExist on ChildForm_EmployeeLaborSummaryFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_EmployeeLaborSummaryFormTable = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummaryFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_EMPLABR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_EmployeeLaborSummaryFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing ClickButton on ChildForm_EmployeeLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_EmployeeLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_EMPLABR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_EmployeeLaborSummaryForm);
IWebElement formBttn = PJQPROJP_ChildForm_EmployeeLaborSummaryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJQPROJP_ChildForm_EmployeeLaborSummaryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJQPROJP_ChildForm_EmployeeLaborSummaryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing VerifyExists on ChildForm_EmployeeLaborSummary_Employee...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_EmployeeLaborSummary_Employee = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummary_Employee", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_EMPLABR_']/ancestor::form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PJQPROJP_ChildForm_EmployeeLaborSummary_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing Close on ChildForm_EmployeeLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_ChildForm_EmployeeLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJP_RPTPROJLABSUM_EMPLABR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJP_ChildForm_EmployeeLaborSummaryForm);
IWebElement formBttn = PJQPROJP_ChildForm_EmployeeLaborSummaryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJP";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJP] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJP_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJQPROJP_MainForm);
IWebElement formBttn = PJQPROJP_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

