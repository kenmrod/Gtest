 
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
    public class PJQPROJ_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"View Project Activity", "xpath","//div[@class='navItem'][.='View Project Activity']").Click();


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
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,PJQPROJ_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on FiscalYear...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_FiscalYear = new SeleniumControl( sDriver, "FiscalYear", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='FY_CD']");
				Function.AssertEqual(true,PJQPROJ_FiscalYear.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTREVSUM_CHLD_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJ_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTREVSUM_CHLD_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm);
IWebElement formBttn = PJQPROJ_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? PJQPROJ_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
PJQPROJ_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitControlDisplayed(new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel"));
Function.AssertEqual("Query", new SeleniumControl(sDriver,"QueryTitle", "ID", "qryHeaderLabel").GetValue().Trim());


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTitle]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Project']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'begins with']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='SEND']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("SEND");}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SetSearchCriterion]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Fiscal Year']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'begins with']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='2016']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("2016");}


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [SetSearchCriterion]" , ex.Message));
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
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTREVSUM_CHLD_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQPROJ_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_ProjectStatusLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_ProjectStatusLink = new SeleniumControl( sDriver, "ChildForm_ProjectStatusLink", "ID", "lnk_1006531_PJQPROJ_RPTREVSUM_CHLD");
				Function.AssertEqual(true,PJQPROJ_ChildForm_ProjectStatusLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_GLCLaborSummaryLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummaryLink = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummaryLink", "ID", "lnk_1006539_PJQPROJ_RPTREVSUM_CHLD");
				Function.AssertEqual(true,PJQPROJ_ChildForm_GLCLaborSummaryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_PLCLaborSummaryLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLaborSummaryLink = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummaryLink", "ID", "lnk_1006543_PJQPROJ_RPTREVSUM_CHLD");
				Function.AssertEqual(true,PJQPROJ_ChildForm_PLCLaborSummaryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_EmployeeLaborSummaryLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_EmployeeLaborSummaryLink = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummaryLink", "ID", "lnk_1006547_PJQPROJ_RPTREVSUM_CHLD");
				Function.AssertEqual(true,PJQPROJ_ChildForm_EmployeeLaborSummaryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
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
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing Click on ChildForm_ProjectStatusLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_ProjectStatusLink = new SeleniumControl( sDriver, "ChildForm_ProjectStatusLink", "ID", "lnk_1006531_PJQPROJ_RPTREVSUM_CHLD");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_ProjectStatusLink);
PJQPROJ_ChildForm_ProjectStatusLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_ProjectStatusForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_ProjectStatusForm = new SeleniumControl( sDriver, "ChildForm_ProjectStatusForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_PSRHDR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJ_ChildForm_ProjectStatusForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_ProjectStatus_PeriodOfPerformance...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_ProjectStatus_PeriodOfPerformance = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_PeriodOfPerformance", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_PSRHDR_']/ancestor::form[1]/descendant::*[@id='PROJ_START_DT']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_ProjectStatus_PeriodOfPerformance.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_ProjectStatus_ProjectStatusChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChildForm = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_PSRFINALDATA_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExist on ChildForm_ProjectStatus_ProjectStatusChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChildFormTable = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_PSRFINALDATA_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing ClickButton on ChildForm_ProjectStatus_ProjectStatusChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChildForm = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_PSRFINALDATA_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChildForm);
IWebElement formBttn = PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_ProjectStatus_ProjectStatusChild_Description...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChild_Description = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChild_Description", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_PSRFINALDATA_']/ancestor::form[1]/descendant::*[@id='DESCRIPTION']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChild_Description.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_ProjectStatus_ProjectStatusChild_LaborDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChild_LaborDetailLink = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChild_LaborDetailLink", "ID", "lnk_1006533_PJQPROJ_PSRFINALDATA");
				Function.AssertEqual(true,PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChild_LaborDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_ProjectStatus_ProjectStatusChild_TransactionDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChild_TransactionDetailLink = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChild_TransactionDetailLink", "ID", "lnk_1006535_PJQPROJ_PSRFINALDATA");
				Function.AssertEqual(true,PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChild_TransactionDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_ProjectStatus_ProjectStatusChild_PoolDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChild_PoolDetailLink = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChild_PoolDetailLink", "ID", "lnk_1006537_PJQPROJ_PSRFINALDATA");
				Function.AssertEqual(true,PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChild_PoolDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_ProjectStatus_ProjectStatusChild_ProfitsLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChild_ProfitsLink = new SeleniumControl( sDriver, "ChildForm_ProjectStatus_ProjectStatusChild_ProfitsLink", "ID", "lnk_1007283_PJQPROJ_PSRFINALDATA");
				Function.AssertEqual(true,PJQPROJ_ChildForm_ProjectStatus_ProjectStatusChild_ProfitsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing Close on ChildForm_ProjectStatusForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_ProjectStatusForm = new SeleniumControl( sDriver, "ChildForm_ProjectStatusForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_PSRHDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_ProjectStatusForm);
IWebElement formBttn = PJQPROJ_ChildForm_ProjectStatusForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing Click on ChildForm_GLCLaborSummaryLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummaryLink = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummaryLink", "ID", "lnk_1006539_PJQPROJ_RPTREVSUM_CHLD");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_GLCLaborSummaryLink);
PJQPROJ_ChildForm_GLCLaborSummaryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_GLCLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_PSRHDR_GLCLABSUM_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJ_ChildForm_GLCLaborSummaryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_GLCLaborSummary_PeriodOfPerformance...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummary_PeriodOfPerformance = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_PeriodOfPerformance", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_PSRHDR_GLCLABSUM_']/ancestor::form[1]/descendant::*[@id='PROJ_START_DT']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_GLCLaborSummary_PeriodOfPerformance.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExist on ChildForm_GLCLaborSummary_GLCLaborSummaryChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildFormTable = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing ClickButton on ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm);
IWebElement formBttn = PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLC...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLC = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLC", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_']/ancestor::form[1]/descendant::*[@id='GEN_LAB_CAT']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_GLC.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing Select on ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab);
IWebElement mTab = PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Hours").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_GLCLaborSummary_GLCLaborSummaryChild_Hours_SubperiodHours...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_Hours_SubperiodHours = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChild_Hours_SubperiodHours", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_']/ancestor::form[1]/descendant::*[@id='SUB_PD_ACT_HRS']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_Hours_SubperiodHours.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyTabs on ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab);
string[] strTabs = PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChildTab.mElement.FindElements(By.CssSelector("span[class*='TabLbl']")).Where(x => x.Displayed).Select(x => new SeleniumControl( sDriver, "x", x).GetValue().Trim()).ToArray();
Function.AssertEqual(String.Join("~", strTabs), "Hours~Amount");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTabs]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_GLCLaborSummary_GLCLaborSummaryChild_EmployeeDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_EmployeeDetailLink = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummary_GLCLaborSummaryChild_EmployeeDetailLink", "ID", "lnk_1006541_PJQPROJ_RPTPROJLABSUM");
				Function.AssertEqual(true,PJQPROJ_ChildForm_GLCLaborSummary_GLCLaborSummaryChild_EmployeeDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing Close on ChildForm_GLCLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_GLCLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_GLCLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_PSRHDR_GLCLABSUM_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_GLCLaborSummaryForm);
IWebElement formBttn = PJQPROJ_ChildForm_GLCLaborSummaryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing Click on ChildForm_PLCLaborSummaryLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLaborSummaryLink = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummaryLink", "ID", "lnk_1006543_PJQPROJ_RPTREVSUM_CHLD");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_PLCLaborSummaryLink);
PJQPROJ_ChildForm_PLCLaborSummaryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_PLCLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_PSRHDR_PLCLABSUM_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJ_ChildForm_PLCLaborSummaryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_PLCLaborSummary_PeriodOfPerformance...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLaborSummary_PeriodOfPerformance = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PeriodOfPerformance", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_PSRHDR_PLCLABSUM_']/ancestor::form[1]/descendant::*[@id='PROJ_START_DT']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_PLCLaborSummary_PeriodOfPerformance.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJ_ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExist on ChildForm_PLCLaborSummary_PLCLaborSummaryChildFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLaborSummary_PLCLaborSummaryChildFormTable = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PLCLaborSummaryChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_PLCLaborSummary_PLCLaborSummaryChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing ClickButton on ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm);
IWebElement formBttn = PJQPROJ_ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJQPROJ_ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJQPROJ_ChildForm_PLCLaborSummary_PLCLaborSummaryChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_PLCLborSummary_PLCLaborSummaryChild_PLC...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChild_PLC = new SeleniumControl( sDriver, "ChildForm_PLCLborSummary_PLCLaborSummaryChild_PLC", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]/descendant::*[@id='LAB_CAT_CD']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChild_PLC.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_PLCLborSummary_PLCLaborSummaryChildTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChildTab = new SeleniumControl( sDriver, "ChildForm_PLCLborSummary_PLCLaborSummaryChildTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChildTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing Select on ChildForm_PLCLborSummary_PLCLaborSummaryChildTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChildTab = new SeleniumControl( sDriver, "ChildForm_PLCLborSummary_PLCLaborSummaryChildTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChildTab);
IWebElement mTab = PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChildTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Hours").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_PLCLborSummary_PLCLaborSummaryChild_SubperiodHours...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChild_SubperiodHours = new SeleniumControl( sDriver, "ChildForm_PLCLborSummary_PLCLaborSummaryChild_SubperiodHours", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]/descendant::*[@id='SUB_PD_ACT_HRS']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChild_SubperiodHours.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyTabs on ChildForm_PLCLborSummary_PLCLaborSummaryChildTab...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChildTab = new SeleniumControl( sDriver, "ChildForm_PLCLborSummary_PLCLaborSummaryChildTab", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_PLCLAB_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChildTab);
string[] strTabs = PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChildTab.mElement.FindElements(By.CssSelector("span[class*='TabLbl']")).Where(x => x.Displayed).Select(x => new SeleniumControl( sDriver, "x", x).GetValue().Trim()).ToArray();
Function.AssertEqual(String.Join("~", strTabs), "Hours~Amount");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyTabs]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_PLCLborSummary_PLCLaborSummaryChild_EmployeeDetailLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChild_EmployeeDetailLink = new SeleniumControl( sDriver, "ChildForm_PLCLborSummary_PLCLaborSummaryChild_EmployeeDetailLink", "ID", "lnk_1006545_PJQPROJ_RPTPROJLABSUM_PLCLAB");
				Function.AssertEqual(true,PJQPROJ_ChildForm_PLCLborSummary_PLCLaborSummaryChild_EmployeeDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing Close on ChildForm_PLCLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_PLCLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_PLCLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_PSRHDR_PLCLABSUM_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_PLCLaborSummaryForm);
IWebElement formBttn = PJQPROJ_ChildForm_PLCLaborSummaryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing Click on ChildForm_EmployeeLaborSummaryLink...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_EmployeeLaborSummaryLink = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummaryLink", "ID", "lnk_1006547_PJQPROJ_RPTREVSUM_CHLD");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_EmployeeLaborSummaryLink);
PJQPROJ_ChildForm_EmployeeLaborSummaryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_EmployeeLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_EmployeeLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_EMPLABOR_']/ancestor::form[1]");
				Function.AssertEqual(true,PJQPROJ_ChildForm_EmployeeLaborSummaryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExist on ChildForm_EmployeeLaborSummaryFormTable...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_EmployeeLaborSummaryFormTable = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummaryFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_EMPLABOR_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_EmployeeLaborSummaryFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing ClickButton on ChildForm_EmployeeLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_EmployeeLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_EMPLABOR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_EmployeeLaborSummaryForm);
IWebElement formBttn = PJQPROJ_ChildForm_EmployeeLaborSummaryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? PJQPROJ_ChildForm_EmployeeLaborSummaryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
PJQPROJ_ChildForm_EmployeeLaborSummaryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing VerifyExists on ChildForm_EmployeeLaborSummary_Employee...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_EmployeeLaborSummary_Employee = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummary_Employee", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_EMPLABOR_']/ancestor::form[1]/descendant::*[@id='EMPL_ID']");
				Function.AssertEqual(true,PJQPROJ_ChildForm_EmployeeLaborSummary_Employee.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing Close on ChildForm_EmployeeLaborSummaryForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_ChildForm_EmployeeLaborSummaryForm = new SeleniumControl( sDriver, "ChildForm_EmployeeLaborSummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__PJQPROJ_RPTPROJLABSUM_EMPLABOR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(PJQPROJ_ChildForm_EmployeeLaborSummaryForm);
IWebElement formBttn = PJQPROJ_ChildForm_EmployeeLaborSummaryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "PJQPROJ";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[PJQPROJ] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl PJQPROJ_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(PJQPROJ_MainForm);
IWebElement formBttn = PJQPROJ_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

