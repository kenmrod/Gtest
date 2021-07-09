 
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
    public class LDMTIME_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Manage Timesheets", "xpath","//div[@class='navItem'][.='Manage Timesheets']").Click();


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
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,LDMTIME_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on Date...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_Date = new SeleniumControl( sDriver, "Date", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TS_DT']");
				Function.AssertEqual(true,LDMTIME_Date.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on Tab...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,LDMTIME_Tab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(LDMTIME_Tab);
IWebElement mTab = LDMTIME_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Timesheet Header").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on TimesheetHeader_HoursAndAccountingPeriod_RegularHours...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_TimesheetHeader_HoursAndAccountingPeriod_RegularHours = new SeleniumControl( sDriver, "TimesheetHeader_HoursAndAccountingPeriod_RegularHours", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='REG_HRS']");
				Function.AssertEqual(true,LDMTIME_TimesheetHeader_HoursAndAccountingPeriod_RegularHours.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing Select on Tab...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_Tab = new SeleniumControl( sDriver, "Tab", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(LDMTIME_Tab);
IWebElement mTab = LDMTIME_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Entry Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on EntryInformation_EnteredBy...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_EntryInformation_EnteredBy = new SeleniumControl( sDriver, "EntryInformation_EnteredBy", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='TH___USER_ID']");
				Function.AssertEqual(true,LDMTIME_EntryInformation_EnteredBy.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMTIME_ChildForm);
IWebElement formBttn = LDMTIME_ChildForm.mElement.FindElements(By.CssSelector("*[title*='New']")).Count <= 0 ? LDMTIME_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'New')]")).FirstOrDefault() :
LDMTIME_ChildForm.mElement.FindElements(By.CssSelector("*[title*='New']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" New not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on ChildForm...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLN_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMTIME_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExist on ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ChildFormTable = new SeleniumControl( sDriver, "ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLN_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMTIME_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing ClickButton on ChildForm...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ChildForm = new SeleniumControl( sDriver, "ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLN_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMTIME_ChildForm);
IWebElement formBttn = LDMTIME_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? LDMTIME_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
LDMTIME_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.AssertEqual(true,LDMTIME_ChildFormTab.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(LDMTIME_ChildFormTab);
IWebElement mTab = LDMTIME_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Charge Information").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on ChildForm_ChargeInformation_LineNumber...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ChildForm_ChargeInformation_LineNumber = new SeleniumControl( sDriver, "ChildForm_ChargeInformation_LineNumber", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLN_']/ancestor::form[1]/descendant::*[@id='TS_LN___TS_LN_NO']");
				Function.AssertEqual(true,LDMTIME_ChildForm_ChargeInformation_LineNumber.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing Select on ChildFormTab...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ChildFormTab = new SeleniumControl( sDriver, "ChildFormTab", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLN_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(LDMTIME_ChildFormTab);
IWebElement mTab = LDMTIME_ChildFormTab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Reference and Notes").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on ChildForm_ReferenceAndNotes_FringeBasis_UnionFringeCode...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ChildForm_ReferenceAndNotes_FringeBasis_UnionFringeCode = new SeleniumControl( sDriver, "ChildForm_ReferenceAndNotes_FringeBasis_UnionFringeCode", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLN_']/ancestor::form[1]/descendant::*[@id='TS_LN___FRINGE_CD']");
				Function.AssertEqual(true,LDMTIME_ChildForm_ReferenceAndNotes_FringeBasis_UnionFringeCode.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on ManufacturingOrderTimesheetInformationLink...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ManufacturingOrderTimesheetInformationLink = new SeleniumControl( sDriver, "ManufacturingOrderTimesheetInformationLink", "ID", "lnk_1832_LDMTIME_TSLN");
				Function.AssertEqual(true,LDMTIME_ManufacturingOrderTimesheetInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on SalesOrderTimesheetInformationLink...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_SalesOrderTimesheetInformationLink = new SeleniumControl( sDriver, "SalesOrderTimesheetInformationLink", "ID", "lnk_1833_LDMTIME_TSLN");
				Function.AssertEqual(true,LDMTIME_SalesOrderTimesheetInformationLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing Click on ManufacturingOrderTimesheetInformationLink...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ManufacturingOrderTimesheetInformationLink = new SeleniumControl( sDriver, "ManufacturingOrderTimesheetInformationLink", "ID", "lnk_1832_LDMTIME_TSLN");
				Function.WaitControlDisplayed(LDMTIME_ManufacturingOrderTimesheetInformationLink);
LDMTIME_ManufacturingOrderTimesheetInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on ManufacturingOrderTimesheetInformationForm...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ManufacturingOrderTimesheetInformationForm = new SeleniumControl( sDriver, "ManufacturingOrderTimesheetInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLNMO_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMTIME_ManufacturingOrderTimesheetInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on ManufacturingOrderTimesheetInformation_ManufacturingOrder_ManufacturingOrder...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ManufacturingOrderTimesheetInformation_ManufacturingOrder_ManufacturingOrder = new SeleniumControl( sDriver, "ManufacturingOrderTimesheetInformation_ManufacturingOrder_ManufacturingOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLNMO_']/ancestor::form[1]/descendant::*[@id='MO_ID']");
				Function.AssertEqual(true,LDMTIME_ManufacturingOrderTimesheetInformation_ManufacturingOrder_ManufacturingOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing Close on ManufacturingOrderTimesheetInformationForm...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_ManufacturingOrderTimesheetInformationForm = new SeleniumControl( sDriver, "ManufacturingOrderTimesheetInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLNMO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMTIME_ManufacturingOrderTimesheetInformationForm);
IWebElement formBttn = LDMTIME_ManufacturingOrderTimesheetInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing Click on SalesOrderTimesheetInformationLink...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_SalesOrderTimesheetInformationLink = new SeleniumControl( sDriver, "SalesOrderTimesheetInformationLink", "ID", "lnk_1833_LDMTIME_TSLN");
				Function.WaitControlDisplayed(LDMTIME_SalesOrderTimesheetInformationLink);
LDMTIME_SalesOrderTimesheetInformationLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on SalesOrderTimesheetInformationForm...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_SalesOrderTimesheetInformationForm = new SeleniumControl( sDriver, "SalesOrderTimesheetInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLNSO_']/ancestor::form[1]");
				Function.AssertEqual(true,LDMTIME_SalesOrderTimesheetInformationForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExists on SalesOrderTimesheetInformation_SalesOrder...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_SalesOrderTimesheetInformation_SalesOrder = new SeleniumControl( sDriver, "SalesOrderTimesheetInformation_SalesOrder", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLNSO_']/ancestor::form[1]/descendant::*[@id='SO_ID']");
				Function.AssertEqual(true,LDMTIME_SalesOrderTimesheetInformation_SalesOrder.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing ClickButton on SalesOrderTimesheetInformationForm...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_SalesOrderTimesheetInformationForm = new SeleniumControl( sDriver, "SalesOrderTimesheetInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLNSO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMTIME_SalesOrderTimesheetInformationForm);
IWebElement formBttn = LDMTIME_SalesOrderTimesheetInformationForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).Count <= 0 ? LDMTIME_SalesOrderTimesheetInformationForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Table')]")).FirstOrDefault() :
LDMTIME_SalesOrderTimesheetInformationForm.mElement.FindElements(By.CssSelector("*[title*='Table']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Table not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing VerifyExist on SalesOrderTimesheetInformationTable...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_SalesOrderTimesheetInformationTable = new SeleniumControl( sDriver, "SalesOrderTimesheetInformationTable", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLNSO_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,LDMTIME_SalesOrderTimesheetInformationTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing Close on SalesOrderTimesheetInformationForm...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_SalesOrderTimesheetInformationForm = new SeleniumControl( sDriver, "SalesOrderTimesheetInformationForm", "xpath", "//div[translate(@id,'0123456789','')='pr__LDMTIME_TSLNSO_']/ancestor::form[1]");
				Function.WaitControlDisplayed(LDMTIME_SalesOrderTimesheetInformationForm);
IWebElement formBttn = LDMTIME_SalesOrderTimesheetInformationForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "LDMTIME";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[LDMTIME] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl LDMTIME_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(LDMTIME_MainForm);
IWebElement formBttn = LDMTIME_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
Function.ClickOkDialogIfExists("You have unsaved changes. Select Cancel to go back and save changes or select OK to discard changes and close this application.");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickOkDialogIfExists]" , ex.Message));
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

