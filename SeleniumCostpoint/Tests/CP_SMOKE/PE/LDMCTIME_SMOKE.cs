 
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
    public class LDMCTIME_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Labor", "xpath","//div[@class='deptItem'][.='Labor']").Click();
new SeleniumControl(sDriver,"Timesheet Entry/Creation", "xpath","//div[@class='navItem'][.='Timesheet Entry/Creation']").Click();
new SeleniumControl(sDriver,"Manage Correcting Timesheets", "xpath","//div[@class='navItem'][.='Manage Correcting Timesheets']").Click();


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
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDMCTIME_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExist on MainFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_MainFormTable = new SeleniumControl( sDriver, "MainFormTable", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMCTIME_MainFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing ClickButton on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMCTIME_MainForm);
IWebElement formBttn = LDMCTIME_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? LDMCTIME_MainForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
LDMCTIME_MainForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on Date...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_Date = new SeleniumControl( sDriver, "Date", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='NEW_TS_DT']");
				Function.AssertEqual(true,LDMCTIME_Date.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(LDMCTIME_MainFormTab);
IWebElement mTab = LDMCTIME_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Timesheet Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on TimesheetHeader_HoursAccountingPeriod_RegularHours...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetHeader_HoursAccountingPeriod_RegularHours = new SeleniumControl( sDriver, "TimesheetHeader_HoursAccountingPeriod_RegularHours", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='REG_HRS']");
				Function.AssertEqual(true,LDMCTIME_TimesheetHeader_HoursAccountingPeriod_RegularHours.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing Select on MainFormTab...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_MainFormTab = new SeleniumControl( sDriver, "MainFormTab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(LDMCTIME_MainFormTab);
IWebElement mTab = LDMCTIME_MainFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Entry Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on EntryInformation_EnteredBy...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_EntryInformation_EnteredBy = new SeleniumControl( sDriver, "EntryInformation_EnteredBy", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TH___USER_ID']");
				Function.AssertEqual(true,LDMCTIME_EntryInformation_EnteredBy.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("TimesheetLineForm");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on TimesheetLineForm...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLineForm = new SeleniumControl( sDriver, "TimesheetLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLN_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMCTIME_TimesheetLineForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExist on TimesheetLineFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLineFormTable = new SeleniumControl( sDriver, "TimesheetLineFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMCTIME_TimesheetLineFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing ClickButton on TimesheetLineForm...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLineForm = new SeleniumControl( sDriver, "TimesheetLineForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMCTIME_TimesheetLineForm);
IWebElement formBttn = LDMCTIME_TimesheetLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? LDMCTIME_TimesheetLineForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
LDMCTIME_TimesheetLineForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on TimesheetLineTab...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLineTab = new SeleniumControl( sDriver, "TimesheetLineTab", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,LDMCTIME_TimesheetLineTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing Select on TimesheetLineTab...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLineTab = new SeleniumControl( sDriver, "TimesheetLineTab", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(LDMCTIME_TimesheetLineTab);
IWebElement mTab = LDMCTIME_TimesheetLineTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Charge Data").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on TimesheetLine_ChargeData_LineType...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_ChargeData_LineType = new SeleniumControl( sDriver, "TimesheetLine_ChargeData_LineType", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLN_']/ancestor::form[1]/descendant::*[@id='TS_LN___S_TS_LN_TYPE_CD']");
				Function.AssertEqual(true,LDMCTIME_TimesheetLine_ChargeData_LineType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing Select on TimesheetLineTab...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLineTab = new SeleniumControl( sDriver, "TimesheetLineTab", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(LDMCTIME_TimesheetLineTab);
IWebElement mTab = LDMCTIME_TimesheetLineTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Miscellaneous").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on TimesheetLine_Miscellaneous_AC2...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_Miscellaneous_AC2 = new SeleniumControl( sDriver, "TimesheetLine_Miscellaneous_AC2", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLN_']/ancestor::form[1]/descendant::*[@id='TS_LN___REF_STRUC_2_ID']");
				Function.AssertEqual(true,LDMCTIME_TimesheetLine_Miscellaneous_AC2.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Manufacturing Order Timesheet Information Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on TimesheetLine_ManufacturingOrderTimesheetInformationLink...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationLink = new SeleniumControl( sDriver, "TimesheetLine_ManufacturingOrderTimesheetInformationLink", "ID", "lnk_2597_LDMCTIME_TSLN");
				Function.AssertEqual(true,LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing Click on TimesheetLine_ManufacturingOrderTimesheetInformationLink...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationLink = new SeleniumControl( sDriver, "TimesheetLine_ManufacturingOrderTimesheetInformationLink", "ID", "lnk_2597_LDMCTIME_TSLN");
				Function.WaitControlDisplayed(LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationLink);
LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on TimesheetLine_ManufacturingOrderTimesheetInformationForm...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationForm = new SeleniumControl( sDriver, "TimesheetLine_ManufacturingOrderTimesheetInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLNMO_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on TimesheetLine_ManufacturingOrderTimesheetInformation_ManufacturingOrder_ManufacturingOrder...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformation_ManufacturingOrder_ManufacturingOrder = new SeleniumControl( sDriver, "TimesheetLine_ManufacturingOrderTimesheetInformation_ManufacturingOrder_ManufacturingOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLNMO_']/ancestor::form[1]/descendant::*[@id='MO_ID']");
				Function.AssertEqual(true,LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformation_ManufacturingOrder_ManufacturingOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing ClickButton on TimesheetLine_ManufacturingOrderTimesheetInformationForm...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationForm = new SeleniumControl( sDriver, "TimesheetLine_ManufacturingOrderTimesheetInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLNMO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationForm);
IWebElement formBttn = LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExist on TimesheetLine_ManufacturingOrderTimesheetInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationFormTable = new SeleniumControl( sDriver, "TimesheetLine_ManufacturingOrderTimesheetInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLNMO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing Close on TimesheetLine_ManufacturingOrderTimesheetInformationForm...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationForm = new SeleniumControl( sDriver, "TimesheetLine_ManufacturingOrderTimesheetInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLNMO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationForm);
IWebElement formBttn = LDMCTIME_TimesheetLine_ManufacturingOrderTimesheetInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Sales Order Timesheet Information Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on TimesheetLine_SalesOrderTimesheetInformationLink...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationLink = new SeleniumControl( sDriver, "TimesheetLine_SalesOrderTimesheetInformationLink", "ID", "lnk_2598_LDMCTIME_TSLN");
				Function.AssertEqual(true,LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing Click on TimesheetLine_SalesOrderTimesheetInformationLink...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationLink = new SeleniumControl( sDriver, "TimesheetLine_SalesOrderTimesheetInformationLink", "ID", "lnk_2598_LDMCTIME_TSLN");
				Function.WaitControlDisplayed(LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationLink);
LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on TimesheetLine_SalesOrderTimesheetInformationForm...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationForm = new SeleniumControl( sDriver, "TimesheetLine_SalesOrderTimesheetInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLNSO_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExists on TimesheetLine_SalesOrderTimesheetInformation_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_SalesOrderTimesheetInformation_SalesOrder = new SeleniumControl( sDriver, "TimesheetLine_SalesOrderTimesheetInformation_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLNSO_']/ancestor::form[1]/descendant::*[@id='SO_ID']");
				Function.AssertEqual(true,LDMCTIME_TimesheetLine_SalesOrderTimesheetInformation_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing ClickButton on TimesheetLine_SalesOrderTimesheetInformationForm...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationForm = new SeleniumControl( sDriver, "TimesheetLine_SalesOrderTimesheetInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLNSO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationForm);
IWebElement formBttn = LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing VerifyExist on TimesheetLine_SalesOrderTimesheetInformationFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationFormTable = new SeleniumControl( sDriver, "TimesheetLine_SalesOrderTimesheetInformationFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLNSO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing Close on TimesheetLine_SalesOrderTimesheetInformationForm...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationForm = new SeleniumControl( sDriver, "TimesheetLine_SalesOrderTimesheetInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMCTIME_TSLNSO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationForm);
IWebElement formBttn = LDMCTIME_TimesheetLine_SalesOrderTimesheetInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Close App");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMCTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMCTIME] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMCTIME_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMCTIME_MainForm);
IWebElement formBttn = LDMCTIME_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

