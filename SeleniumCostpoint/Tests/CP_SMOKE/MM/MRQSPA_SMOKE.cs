 
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
    public class MRQSPA_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Materials", "xpath","//div[@class='busItem'][.='Materials']").Click();
new SeleniumControl(sDriver,"Material Requirements Planning", "xpath","//div[@class='deptItem'][.='Material Requirements Planning']").Click();
new SeleniumControl(sDriver,"MRP Reports/Inquiries", "xpath","//div[@class='navItem'][.='MRP Reports/Inquiries']").Click();
new SeleniumControl(sDriver,"View Summary Part Availability", "xpath","//div[@class='navItem'][.='View Summary Part Availability']").Click();


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
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MRQSPA_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on Part...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,MRQSPA_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Set on Part...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				MRQSPA_Part.Click();
MRQSPA_Part.SendKeys("A-100-1/4", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
MRQSPA_Part.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Select on InventoryProjectSelection_Option...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_InventoryProjectSelection_Option = new SeleniumControl( sDriver, "InventoryProjectSelection_Option", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.WaitControlDisplayed(MRQSPA_InventoryProjectSelection_Option);
MRQSPA_InventoryProjectSelection_Option.ScrollIntoViewUsingJavaScript();
MRQSPA_InventoryProjectSelection_Option.Click();
SeleniumControl comboBoxList = new SeleniumControl(sDriver,"ComboBoxList", "class_display", "tCCBV");
Function.WaitControlDisplayed(comboBoxList);
IWebElement mItem = comboBoxList.mElement.FindElements(By.CssSelector("div")).Where(x => x.Displayed && new SeleniumControl( sDriver, "x", x).GetValue().Trim().ToLower() == "all projects").FirstOrDefault();
if(mItem != null)
mItem.Click();
else
 throw new Exception("[All Projects] not found in list.");

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Warehouse lookup");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing ClickTextBoxButton on Warehouse...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_Warehouse = new SeleniumControl( sDriver, "Warehouse", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='WHSE_ID']");
				MRQSPA_Warehouse.Click();
Thread.Sleep(800);
new SeleniumControl(sDriver,"TextBoxButton","class_display","lookupIcon").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickTextBoxButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Lookup";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Lookup] Performing ClickButton on LookUpForm...", Logger.MessageType.INF);
				SeleniumControl Lookup_LookUpForm = new SeleniumControl( sDriver, "LookUpForm", "XPATH", "//div[contains(@id,'LKP') or contains(@id,'LOOKUP')]/ancestor::form[1]");
				Function.WaitControlDisplayed(Lookup_LookUpForm);
IWebElement formBttn = Lookup_LookUpForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? Lookup_LookUpForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
Lookup_LookUpForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
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

				this.ScriptLogger.WriteLine("[Query] Performing Select on MainTab...", Logger.MessageType.INF);
				SeleniumControl Query_MainTab = new SeleniumControl( sDriver, "MainTab", "ID", "qryTabsDiv");
				Function.WaitControlDisplayed(Query_MainTab);
IWebElement mTab = Query_MainTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Query").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								new SeleniumControl(sDriver, "ConditionName", "id", "fieldList").Click();
new SeleniumControl(sDriver, "ConditionItem", "xpath_display", ".//div[@class='tCCBV']//descendant::div[text() = 'Warehouse']").Click();
new SeleniumControl(sDriver, "Relationship", "id", "relationList").Click();
new SeleniumControl(sDriver, "RelationItem", "xpath_display", ".//descendant::div[text() = 'is not equal']").Click();
new SeleniumControl(sDriver, "Value", "id", "valueEntered").SendKeys("'ADWHSE'");
new SeleniumControl(sDriver, "AddButton", "id", "AddBtn").Click();
								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [AddQueryCondition]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Query_Add...", Logger.MessageType.INF);
				SeleniumControl Query_Query_Add = new SeleniumControl( sDriver, "Query_Add", "ID", "AddBtn");
				Function.WaitControlDisplayed(Query_Query_Add);
if (Query_Query_Add.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Query_Add.Click(5,5);
else Query_Query_Add.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								new SeleniumControl(sDriver, "ConditionName", "id", "fieldList").Click();
                    new SeleniumControl(sDriver, "ConditionItem", "xpath_display", ".//div[@class='tCCBV']//descendant::div[text() = 'Warehouse']").Click();
new SeleniumControl(sDriver, "Relationship", "id", "relationList").Click();
new SeleniumControl(sDriver, "RelationItem", "xpath_display", ".//descendant::div[text() = 'is not equal']").Click();
SeleniumControl txtValue = new SeleniumControl(sDriver, "Value", "id", "valueEntered");
SeleniumControl cboValue = new SeleniumControl(sDriver, "ValueCB", "id", "valueCBView");
if(txtValue.Exists()){
txtValue.SendKeys("'TEST'");
} else {
cboValue.Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()=''TEST'']").Click(); }
new SeleniumControl(sDriver, "LogicalOperator", "id", "CombineOperator").Click();
new SeleniumControl(sDriver, "OperatorItem", "xpath_display", ".//descendant::div[text() = 'and']").Click();
new SeleniumControl(sDriver, "AddButton", "id", "AddBtn").Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [AddQueryCondition]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Query_Add...", Logger.MessageType.INF);
				SeleniumControl Query_Query_Add = new SeleniumControl( sDriver, "Query_Add", "ID", "AddBtn");
				Function.WaitControlDisplayed(Query_Query_Add);
if (Query_Query_Add.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Query_Add.Click(5,5);
else Query_Query_Add.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[Query] Performing Click on Query...", Logger.MessageType.INF);
				SeleniumControl Query_Query = new SeleniumControl( sDriver, "Query", "ID", "submitQ");
				Function.WaitControlDisplayed(Query_Query);
if (Query_Query.mElement.GetAttribute("class") == "popupBtn" && sDriver.BrowserType == "ie")
Query_Query.Click(5,5);
else Query_Query.Click(4.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "CP7Main";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[CP7Main] Performing ClickToolbarButton on MainToolBar...", Logger.MessageType.INF);
				SeleniumControl CP7Main_MainToolBar = new SeleniumControl( sDriver, "MainToolBar", "ID", "tlbr");
				Function.WaitControlDisplayed(CP7Main_MainToolBar);
IWebElement tlbrBtn = CP7Main_MainToolBar.mElement.FindElements(By.XPath(".//*[@class='tbBtnContainer']//div[contains(@title,'Execute')]")).FirstOrDefault();
if (tlbrBtn==null) throw new Exception("Unable to find button Execute.");
tlbrBtn.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickToolbarButton]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Part Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on PartDetailLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_PartDetailLink = new SeleniumControl( sDriver, "PartDetailLink", "ID", "lnk_4721_MRQSPA_HDR");
				Function.AssertEqual(true,MRQSPA_PartDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Click on PartDetailLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_PartDetailLink = new SeleniumControl( sDriver, "PartDetailLink", "ID", "lnk_4721_MRQSPA_HDR");
				Function.WaitControlDisplayed(MRQSPA_PartDetailLink);
MRQSPA_PartDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on PartDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_PartDetailForm = new SeleniumControl( sDriver, "PartDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_PartDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on PartDetail_PartPlanningDetail_PlanningType...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_PartDetail_PartPlanningDetail_PlanningType = new SeleniumControl( sDriver, "PartDetail_PartPlanningDetail_PlanningType", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_HDR_']/ancestor::form[1]/descendant::*[@id='S_PLAN_DESC']");
				Function.AssertEqual(true,MRQSPA_PartDetail_PartPlanningDetail_PlanningType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExist on PartDetail_PartProjectInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_PartDetail_PartProjectInformationFormTable = new SeleniumControl( sDriver, "PartDetail_PartProjectInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRQSPA_PartDetail_PartProjectInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing ClickButton on PartDetail_PartProjectInformationForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_PartDetail_PartProjectInformationForm = new SeleniumControl( sDriver, "PartDetail_PartProjectInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_PartDetail_PartProjectInformationForm);
IWebElement formBttn = MRQSPA_PartDetail_PartProjectInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRQSPA_PartDetail_PartProjectInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRQSPA_PartDetail_PartProjectInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on PartDetail_PartProjectInformationForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_PartDetail_PartProjectInformationForm = new SeleniumControl( sDriver, "PartDetail_PartProjectInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_PartDetail_PartProjectInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on PartDetail_PartProjectInformation_Project...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_PartDetail_PartProjectInformation_Project = new SeleniumControl( sDriver, "PartDetail_PartProjectInformation_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='PROJ_ID']");
				Function.AssertEqual(true,MRQSPA_PartDetail_PartProjectInformation_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Close on PartDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_PartDetailForm = new SeleniumControl( sDriver, "PartDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_PARTPROJ_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_PartDetailForm);
IWebElement formBttn = MRQSPA_PartDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Weekly Monthly");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExist on WeeklyMonthlySummaryFormTable...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummaryFormTable = new SeleniumControl( sDriver, "WeeklyMonthlySummaryFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPABCKT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummaryFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing ClickButton on WeeklyMonthlySummaryForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummaryForm = new SeleniumControl( sDriver, "WeeklyMonthlySummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPABCKT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummaryForm);
IWebElement formBttn = MRQSPA_WeeklyMonthlySummaryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRQSPA_WeeklyMonthlySummaryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRQSPA_WeeklyMonthlySummaryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummaryForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummaryForm = new SeleniumControl( sDriver, "WeeklyMonthlySummaryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPABCKT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummaryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_PeriodEndDate...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_PeriodEndDate = new SeleniumControl( sDriver, "WeeklyMonthlySummary_PeriodEndDate", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPABCKT_CTW_']/ancestor::form[1]/descendant::*[@id='PD_END_DT_TEMP']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_PeriodEndDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Projects");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_ProjectsLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_ProjectsLink = new SeleniumControl( sDriver, "WeeklyMonthlySummary_ProjectsLink", "ID", "lnk_4835_MRQSPA_ZMRQSPABCKT_CTW");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_ProjectsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Click on WeeklyMonthlySummary_ProjectsLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_ProjectsLink = new SeleniumControl( sDriver, "WeeklyMonthlySummary_ProjectsLink", "ID", "lnk_4835_MRQSPA_ZMRQSPABCKT_CTW");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_ProjectsLink);
MRQSPA_WeeklyMonthlySummary_ProjectsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_ProjectsForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_ProjectsForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_ProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_ProjectsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_Projects_SelectionCriteria_Option...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Projects_SelectionCriteria_Option = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Projects_SelectionCriteria_Option", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_HDR_']/ancestor::form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Projects_SelectionCriteria_Option.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExist on WeeklyMonthlySummary_Projects_InventoryAbbrevationsFormTable...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Projects_InventoryAbbrevationsFormTable = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Projects_InventoryAbbrevationsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Projects_InventoryAbbrevationsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing ClickButton on WeeklyMonthlySummary_Projects_InventoryAbbrevationsForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Projects_InventoryAbbrevationsForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Projects_InventoryAbbrevationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_Projects_InventoryAbbrevationsForm);
IWebElement formBttn = MRQSPA_WeeklyMonthlySummary_Projects_InventoryAbbrevationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRQSPA_WeeklyMonthlySummary_Projects_InventoryAbbrevationsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRQSPA_WeeklyMonthlySummary_Projects_InventoryAbbrevationsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_Projects_InventoryAbbrevationsForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Projects_InventoryAbbrevationsForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Projects_InventoryAbbrevationsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Projects_InventoryAbbrevationsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_Projects_InventoryAbbrevations_InventoryAbbreviation...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Projects_InventoryAbbrevations_InventoryAbbreviation = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Projects_InventoryAbbrevations_InventoryAbbreviation", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_CTW_']/ancestor::form[1]/descendant::*[@id='INVT_ABBRV_CD']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Projects_InventoryAbbrevations_InventoryAbbreviation.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Close on WeeklyMonthlySummary_ProjectsForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_ProjectsForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_ProjectsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTPROJ_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_ProjectsForm);
IWebElement formBttn = MRQSPA_WeeklyMonthlySummary_ProjectsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Warehouse Inventory");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_WarehouseInventoryLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_WarehouseInventoryLink = new SeleniumControl( sDriver, "WeeklyMonthlySummary_WarehouseInventoryLink", "ID", "lnk_4671_MRQSPA_ZMRQSPABCKT_CTW");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_WarehouseInventoryLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Click on WeeklyMonthlySummary_WarehouseInventoryLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_WarehouseInventoryLink = new SeleniumControl( sDriver, "WeeklyMonthlySummary_WarehouseInventoryLink", "ID", "lnk_4671_MRQSPA_ZMRQSPABCKT_CTW");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_WarehouseInventoryLink);
MRQSPA_WeeklyMonthlySummary_WarehouseInventoryLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_WarehouseInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_WarehouseInventoryForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_WarehouseInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_WarehouseInventoryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_WarehouseInventory_SelectionCriteria_Option...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_WarehouseInventory_SelectionCriteria_Option = new SeleniumControl( sDriver, "WeeklyMonthlySummary_WarehouseInventory_SelectionCriteria_Option", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_HDR_']/ancestor::form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_WarehouseInventory_SelectionCriteria_Option.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExist on WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailFormTable...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailFormTable = new SeleniumControl( sDriver, "WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing ClickButton on WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailForm);
IWebElement formBttn = MRQSPA_WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRQSPA_WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRQSPA_WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetail_Warehouse...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetail_Warehouse = new SeleniumControl( sDriver, "WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetail_Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_CTW_']/ancestor::form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_WarehouseInventory_WarehouseInventoryDetail_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Close on WeeklyMonthlySummary_WarehouseInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_WarehouseInventoryForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_WarehouseInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_INVTWHSELOC_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_WarehouseInventoryForm);
IWebElement formBttn = MRQSPA_WeeklyMonthlySummary_WarehouseInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Inventory Details");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Supply");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_SupplyLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_SupplyLink = new SeleniumControl( sDriver, "WeeklyMonthlySummary_SupplyLink", "ID", "lnk_4719_MRQSPA_ZMRQSPABCKT_CTW");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_SupplyLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Click on WeeklyMonthlySummary_SupplyLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_SupplyLink = new SeleniumControl( sDriver, "WeeklyMonthlySummary_SupplyLink", "ID", "lnk_4719_MRQSPA_ZMRQSPABCKT_CTW");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_SupplyLink);
MRQSPA_WeeklyMonthlySummary_SupplyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_SupplyForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_SupplyForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_SupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPAWRK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_SupplyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_Supply_SelectionCriteria_SelectionOption...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Supply_SelectionCriteria_SelectionOption = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Supply_SelectionCriteria_SelectionOption", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPAWRK_HDR_']/ancestor::form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Supply_SelectionCriteria_SelectionOption.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExist on WeeklyMonthlySummary_Supply_SupplyInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Supply_SupplyInformationFormTable = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Supply_SupplyInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPAWRK_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Supply_SupplyInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing ClickButton on WeeklyMonthlySummary_Supply_SupplyInformationForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Supply_SupplyInformationForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Supply_SupplyInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPAWRK_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_Supply_SupplyInformationForm);
IWebElement formBttn = MRQSPA_WeeklyMonthlySummary_Supply_SupplyInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRQSPA_WeeklyMonthlySummary_Supply_SupplyInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRQSPA_WeeklyMonthlySummary_Supply_SupplyInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_Supply_SupplyInformationForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Supply_SupplyInformationForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Supply_SupplyInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPAWRK_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Supply_SupplyInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_Supply_SupplyInformation_OrderInformation_SupplyType...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Supply_SupplyInformation_OrderInformation_SupplyType = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Supply_SupplyInformation_OrderInformation_SupplyType", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPAWRK_CTW_']/ancestor::form[1]/descendant::*[@id='SUPPLY_TYPE']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Supply_SupplyInformation_OrderInformation_SupplyType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Close on WeeklyMonthlySummary_SupplyForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_SupplyForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_SupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPAWRK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_SupplyForm);
IWebElement formBttn = MRQSPA_WeeklyMonthlySummary_SupplyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Demand");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_DemandLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_DemandLink = new SeleniumControl( sDriver, "WeeklyMonthlySummary_DemandLink", "ID", "lnk_4695_MRQSPA_ZMRQSPABCKT_CTW");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_DemandLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Click on WeeklyMonthlySummary_DemandLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_DemandLink = new SeleniumControl( sDriver, "WeeklyMonthlySummary_DemandLink", "ID", "lnk_4695_MRQSPA_ZMRQSPABCKT_CTW");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_DemandLink);
MRQSPA_WeeklyMonthlySummary_DemandLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_DemandForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_DemandForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_DemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_PART_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_DemandForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_Demand_SelectionCriteria_SelectionOption...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Demand_SelectionCriteria_SelectionOption = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Demand_SelectionCriteria_SelectionOption", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_PART_HDR_']/ancestor::form[1]/descendant::*[@id='PROJ_OPTION']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Demand_SelectionCriteria_SelectionOption.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExist on WeeklyMonthlySummary_Demand_DemandInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Demand_DemandInformationFormTable = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Demand_DemandInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPAWRK_PROJ_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Demand_DemandInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing ClickButton on WeeklyMonthlySummary_Demand_DemandInformationForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Demand_DemandInformationForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Demand_DemandInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPAWRK_PROJ_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_Demand_DemandInformationForm);
IWebElement formBttn = MRQSPA_WeeklyMonthlySummary_Demand_DemandInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRQSPA_WeeklyMonthlySummary_Demand_DemandInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRQSPA_WeeklyMonthlySummary_Demand_DemandInformationForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_Demand_DemandInformationForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Demand_DemandInformationForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Demand_DemandInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPAWRK_PROJ_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Demand_DemandInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_Demand_DemandInformation_RequirementInformation_DemandType...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Demand_DemandInformation_RequirementInformation_DemandType = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Demand_DemandInformation_RequirementInformation_DemandType", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_ZMRQSPAWRK_PROJ_']/ancestor::form[1]/descendant::*[@id='DEMAND_TYPE']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Demand_DemandInformation_RequirementInformation_DemandType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Close on WeeklyMonthlySummary_DemandForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_DemandForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_DemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MRQSPA_PART_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_DemandForm);
IWebElement formBttn = MRQSPA_WeeklyMonthlySummary_DemandForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Substitutes");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_SubstitutesLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_SubstitutesLink = new SeleniumControl( sDriver, "WeeklyMonthlySummary_SubstitutesLink", "ID", "lnk_4677_MRQSPA_ZMRQSPABCKT_CTW");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_SubstitutesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Click on WeeklyMonthlySummary_SubstitutesLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_SubstitutesLink = new SeleniumControl( sDriver, "WeeklyMonthlySummary_SubstitutesLink", "ID", "lnk_4677_MRQSPA_ZMRQSPABCKT_CTW");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_SubstitutesLink);
MRQSPA_WeeklyMonthlySummary_SubstitutesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_SubstitutesForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_SubstitutesForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_SubstitutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_SubstitutesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_Substitutes_Project...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Substitutes_Project = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Substitutes_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_HDR_']/ancestor::form[1]/descendant::*[@id='INVT_PROJ_ID']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Substitutes_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExist on WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryFormTable...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryFormTable = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing ClickButton on WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryForm);
IWebElement formBttn = MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventoryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_Substitutes_SubstitutePartInventory_Rev...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventory_Rev = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Substitutes_SubstitutePartInventory_Rev", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]/descendant::*[@id='PART_RVSN_ID']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventory_Rev.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Select on WeeklyMonthlySummary_Substitutes_SubstitutePartInventory_SubstitutePartInventoryTab...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventory_SubstitutePartInventoryTab = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Substitutes_SubstitutePartInventory_SubstitutePartInventoryTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventory_SubstitutePartInventoryTab);
IWebElement mTab = MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventory_SubstitutePartInventoryTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Quantities").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_Substitutes_SubstitutePartInventory_Quantities_Quantities_NetAvailable...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventory_Quantities_Quantities_NetAvailable = new SeleniumControl( sDriver, "WeeklyMonthlySummary_Substitutes_SubstitutePartInventory_Quantities_Quantities_NetAvailable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]/descendant::*[@id='NET_AVAIL_QTY']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_Substitutes_SubstitutePartInventory_Quantities_Quantities_NetAvailable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Close on WeeklyMonthlySummary_SubstitutesForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_SubstitutesForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_SubstitutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_SubstitutesForm);
IWebElement formBttn = MRQSPA_WeeklyMonthlySummary_SubstitutesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("ECNs");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_ECNsLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_ECNsLink = new SeleniumControl( sDriver, "WeeklyMonthlySummary_ECNsLink", "ID", "lnk_4688_MRQSPA_ZMRQSPABCKT_CTW");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_ECNsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Click on WeeklyMonthlySummary_ECNsLink...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_ECNsLink = new SeleniumControl( sDriver, "WeeklyMonthlySummary_ECNsLink", "ID", "lnk_4688_MRQSPA_ZMRQSPABCKT_CTW");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_ECNsLink);
MRQSPA_WeeklyMonthlySummary_ECNsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExist on WeeklyMonthlySummary_ECNsFormTable...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_ECNsFormTable = new SeleniumControl( sDriver, "WeeklyMonthlySummary_ECNsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_ECNsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing ClickButton on WeeklyMonthlySummary_ECNsForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_ECNsForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_ECNsForm);
IWebElement formBttn = MRQSPA_WeeklyMonthlySummary_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MRQSPA_WeeklyMonthlySummary_ECNsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MRQSPA_WeeklyMonthlySummary_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_ECNsForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_ECNsForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_ECNsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_ECNs_EngineeringChangeNotice...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_ECNs_EngineeringChangeNotice = new SeleniumControl( sDriver, "WeeklyMonthlySummary_ECNs_EngineeringChangeNotice", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='ECN_ID']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_ECNs_EngineeringChangeNotice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Select on WeeklyMonthlySummary_ECNs_ECNsTab...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_ECNs_ECNsTab = new SeleniumControl( sDriver, "WeeklyMonthlySummary_ECNs_ECNsTab", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_ECNs_ECNsTab);
IWebElement mTab = MRQSPA_WeeklyMonthlySummary_ECNs_ECNsTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "ECN Details").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing VerifyExists on WeeklyMonthlySummary_ECNs_ECNDetails_Status...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_ECNs_ECNDetails_Status = new SeleniumControl( sDriver, "WeeklyMonthlySummary_ECNs_ECNDetails_Status", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='S_ECN_STATUS_CD']");
				Function.AssertEqual(true,MRQSPA_WeeklyMonthlySummary_ECNs_ECNDetails_Status.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Close on WeeklyMonthlySummary_ECNsForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_WeeklyMonthlySummary_ECNsForm = new SeleniumControl( sDriver, "WeeklyMonthlySummary_ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MRQSPA_WeeklyMonthlySummary_ECNsForm);
IWebElement formBttn = MRQSPA_WeeklyMonthlySummary_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MRQSPA";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MRQSPA] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MRQSPA_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MRQSPA_MainForm);
IWebElement formBttn = MRQSPA_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

