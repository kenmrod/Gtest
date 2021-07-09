 
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
    public class MSMMPS_SMOKE : SeleniumTestScript
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
new SeleniumControl(sDriver,"Master Production Scheduling", "xpath","//div[@class='deptItem'][.='Master Production Scheduling']").Click();
new SeleniumControl(sDriver,"Master Production Schedules", "xpath","//div[@class='navItem'][.='Master Production Schedules']").Click();
new SeleniumControl(sDriver,"Manage Master Production Schedules", "xpath","//div[@class='navItem'][.='Manage Master Production Schedules']").Click();


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
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on MainForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.AssertEqual(true,MSMMPS_MainForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Part...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				Function.AssertEqual(true,MSMMPS_Part.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Select on ScheduleDisplayOption...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ScheduleDisplayOption = new SeleniumControl( sDriver, "ScheduleDisplayOption", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_SHCEDULE_OPT']");
				Function.WaitControlDisplayed(MSMMPS_ScheduleDisplayOption);
MSMMPS_ScheduleDisplayOption.ScrollIntoViewUsingJavaScript();
MSMMPS_ScheduleDisplayOption.Click();
SeleniumControl comboBoxList = new SeleniumControl(sDriver,"ComboBoxList", "class_display", "tCCBV");
Function.WaitControlDisplayed(comboBoxList);
IWebElement mItem = comboBoxList.mElement.FindElements(By.CssSelector("div")).Where(x => x.Displayed && new SeleniumControl( sDriver, "x", x).GetValue().Trim().ToLower() == "mps default").FirstOrDefault();
if(mItem != null)
mItem.Click();
else
 throw new Exception("[MPS Default] not found in list.");

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on ScheduleForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ScheduleForm = new SeleniumControl( sDriver, "ScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSBCKT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_ScheduleForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Set on Part...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Part = new SeleniumControl( sDriver, "Part", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='PART_ID']");
				MSMMPS_Part.Click();
MSMMPS_Part.SendKeys("#20", true);
Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));
MSMMPS_Part.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Tab);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Set]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Select on InventoryProjectSelection_Option...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_InventoryProjectSelection_Option = new SeleniumControl( sDriver, "InventoryProjectSelection_Option", "xpath", "//div[@id='0']/form[1]/descendant::*[@id='S_PROJ_OPTION']");
				Function.WaitControlDisplayed(MSMMPS_InventoryProjectSelection_Option);
MSMMPS_InventoryProjectSelection_Option.ScrollIntoViewUsingJavaScript();
MSMMPS_InventoryProjectSelection_Option.Click();
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
				Function.Wait(45);


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Wait]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing ClickButton on ScheduleForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ScheduleForm = new SeleniumControl( sDriver, "ScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSBCKT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_ScheduleForm);
IWebElement formBttn = MSMMPS_ScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).Count <= 0 ? MSMMPS_ScheduleForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Query')]")).FirstOrDefault() :
MSMMPS_ScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Query']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Query not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "Query";
								SeleniumControl ctl = new SeleniumControl(sDriver,"Target", "xpath_display", "//*[@id='basicQTbl']/tbody/tr/td/span[text()='Period End Date']");
Function.WaitControlDisplayed(ctl);
SeleniumControl RelationshipField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[1]")));
SeleniumControl SearchField = new SeleniumControl(sDriver,"Relationship", ctl.mElement.FindElement(By.XPath("../following-sibling::td[2]")));
new SeleniumControl(sDriver, "RelDropdown", RelationshipField.mElement.FindElements(By.XPath("./descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "RelItem", "xpath_display", ".//descendant::div[text() = 'begins with']").Click();
if (SearchField.mElement.GetAttribute("class").Equals("tCCB")) {
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='tCCBImg']")).FirstOrDefault()).Click();
new SeleniumControl(sDriver, "SearchItem", "xpath_display", ".//descendant::div[text()='']").Click();
} else { 
new SeleniumControl(sDriver, "SearchDropdown", SearchField.mElement.FindElements(By.XPath(".//descendant::*[@class='queryBasicFld']")).FirstOrDefault()).SendKeys("");}


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
				Function.CurrentComponent = "ProcessProgress";
								Function.WaitProcessProgressFinished(20);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [WaitForProcessFinished]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Load Forecast");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on LoadForecastLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_LoadForecastLink = new SeleniumControl( sDriver, "LoadForecastLink", "ID", "lnk_15698_MSMMPS_FILTER");
				Function.AssertEqual(true,MSMMPS_LoadForecastLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Click on LoadForecastLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_LoadForecastLink = new SeleniumControl( sDriver, "LoadForecastLink", "ID", "lnk_15698_MSMMPS_FILTER");
				Function.WaitControlDisplayed(MSMMPS_LoadForecastLink);
MSMMPS_LoadForecastLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on LoadForecast_BeginningDate...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_LoadForecast_BeginningDate = new SeleniumControl( sDriver, "LoadForecast_BeginningDate", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_LOAD_FORECAST_']/ancestor::form[1]/descendant::*[@id='BEG_DATE']");
				Function.AssertEqual(true,MSMMPS_LoadForecast_BeginningDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Close on LoadForecastForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_LoadForecastForm = new SeleniumControl( sDriver, "LoadForecastForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_LOAD_FORECAST_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_LoadForecastForm);
IWebElement formBttn = MSMMPS_LoadForecastForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Product Family");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on ProductFamilyLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ProductFamilyLink = new SeleniumControl( sDriver, "ProductFamilyLink", "ID", "lnk_5229_MSMMPS_FILTER");
				Function.AssertEqual(true,MSMMPS_ProductFamilyLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Click on ProductFamilyLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ProductFamilyLink = new SeleniumControl( sDriver, "ProductFamilyLink", "ID", "lnk_5229_MSMMPS_FILTER");
				Function.WaitControlDisplayed(MSMMPS_ProductFamilyLink);
MSMMPS_ProductFamilyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on ProductFamilyForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ProductFamilyForm = new SeleniumControl( sDriver, "ProductFamilyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ITEMPRODUCT_DTL_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_ProductFamilyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExist on ProductFamilyFormTable...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ProductFamilyFormTable = new SeleniumControl( sDriver, "ProductFamilyFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ITEMPRODUCT_DTL_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MSMMPS_ProductFamilyFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing ClickButton on ProductFamilyForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ProductFamilyForm = new SeleniumControl( sDriver, "ProductFamilyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ITEMPRODUCT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_ProductFamilyForm);
IWebElement formBttn = MSMMPS_ProductFamilyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MSMMPS_ProductFamilyForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MSMMPS_ProductFamilyForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on ProductFamily_SalesOrderPart...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ProductFamily_SalesOrderPart = new SeleniumControl( sDriver, "ProductFamily_SalesOrderPart", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ITEMPRODUCT_DTL_']/ancestor::form[1]/descendant::*[@id='ITEM_ID']");
				Function.AssertEqual(true,MSMMPS_ProductFamily_SalesOrderPart.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Close on ProductFamilyForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ProductFamilyForm = new SeleniumControl( sDriver, "ProductFamilyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ITEMPRODUCT_DTL_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_ProductFamilyForm);
IWebElement formBttn = MSMMPS_ProductFamilyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on PartDetailLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_PartDetailLink = new SeleniumControl( sDriver, "PartDetailLink", "ID", "lnk_5234_MSMMPS_FILTER");
				Function.AssertEqual(true,MSMMPS_PartDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Click on PartDetailLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_PartDetailLink = new SeleniumControl( sDriver, "PartDetailLink", "ID", "lnk_5234_MSMMPS_FILTER");
				Function.WaitControlDisplayed(MSMMPS_PartDetailLink);
MSMMPS_PartDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on PartDetailForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_PartDetailForm = new SeleniumControl( sDriver, "PartDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_PART_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_PartDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on PartDetail_MinQty...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_PartDetail_MinQty = new SeleniumControl( sDriver, "PartDetail_MinQty", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_PART_HDR_']/ancestor::form[1]/descendant::*[@id='MIN_LOT_SIZE_QTY']");
				Function.AssertEqual(true,MSMMPS_PartDetail_MinQty.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Close on PartDetailForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_PartDetailForm = new SeleniumControl( sDriver, "PartDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_PART_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_PartDetailForm);
IWebElement formBttn = MSMMPS_PartDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on ECNsLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ECNsLink = new SeleniumControl( sDriver, "ECNsLink", "ID", "lnk_5233_MSMMPS_FILTER");
				Function.AssertEqual(true,MSMMPS_ECNsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Click on ECNsLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ECNsLink = new SeleniumControl( sDriver, "ECNsLink", "ID", "lnk_5233_MSMMPS_FILTER");
				Function.WaitControlDisplayed(MSMMPS_ECNsLink);
MSMMPS_ECNsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on ECNsForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ECNsForm = new SeleniumControl( sDriver, "ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_ECNsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExist on ECNsFormTable...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ECNsFormTable = new SeleniumControl( sDriver, "ECNsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MSMMPS_ECNsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing ClickButton on ECNsForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ECNsForm = new SeleniumControl( sDriver, "ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_ECNsForm);
IWebElement formBttn = MSMMPS_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MSMMPS_ECNsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MSMMPS_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on ECNs_EngineeringChangeNotice...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ECNs_EngineeringChangeNotice = new SeleniumControl( sDriver, "ECNs_EngineeringChangeNotice", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]/descendant::*[@id='ECN_ID']");
				Function.AssertEqual(true,MSMMPS_ECNs_EngineeringChangeNotice.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Close on ECNsForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ECNsForm = new SeleniumControl( sDriver, "ECNsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ECNPART_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_ECNsForm);
IWebElement formBttn = MSMMPS_ECNsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Schedule Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on ScheduleForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ScheduleForm = new SeleniumControl( sDriver, "ScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSBCKT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_ScheduleForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExist on ScheduleFormTable...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ScheduleFormTable = new SeleniumControl( sDriver, "ScheduleFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSBCKT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MSMMPS_ScheduleFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing ClickButton on ScheduleForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ScheduleForm = new SeleniumControl( sDriver, "ScheduleForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSBCKT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_ScheduleForm);
IWebElement formBttn = MSMMPS_ScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MSMMPS_ScheduleForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MSMMPS_ScheduleForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Select on Schedule_Tab...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_Tab = new SeleniumControl( sDriver, "Schedule_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSBCKT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MSMMPS_Schedule_Tab);
IWebElement mTab = MSMMPS_Schedule_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Supply/Demand").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Schedule_SupplyDemand_FirmedSupply...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_SupplyDemand_FirmedSupply = new SeleniumControl( sDriver, "Schedule_SupplyDemand_FirmedSupply", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSBCKT_CTW_']/ancestor::form[1]/descendant::*[@id='FIRM_SUPP_QTY']");
				Function.AssertEqual(true,MSMMPS_Schedule_SupplyDemand_FirmedSupply.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Select on Schedule_Tab...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_Tab = new SeleniumControl( sDriver, "Schedule_Tab", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSBCKT_CTW_']/ancestor::form[1]/descendant::*[@id='tbTbl']");
				Function.WaitControlDisplayed(MSMMPS_Schedule_Tab);
IWebElement mTab = MSMMPS_Schedule_Tab.mElement.FindElements(OpenQA.Selenium.By.XPath(".//span[contains(@class, 'TabLbl')]")).Where(x => new SeleniumControl(sDriver,"Tab", x).GetValue() == "Lead Time/Time Fence").FirstOrDefault();
if (sDriver.BrowserType.ToLower() != "ie") new SeleniumControl(sDriver,"Tab", mTab).ScrollIntoViewUsingJavaScript();
else new SeleniumControl(sDriver,"Tab", mTab).ScrollTab(mTab);
mTab.Click();


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Select]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Schedule_LeadTimeTimeFence_InsideMPSTimeFence...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_LeadTimeTimeFence_InsideMPSTimeFence = new SeleniumControl( sDriver, "Schedule_LeadTimeTimeFence_InsideMPSTimeFence", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSBCKT_CTW_']/ancestor::form[1]/descendant::*[@id='MPS_TIME_FENCE']");
				Function.AssertEqual(true,MSMMPS_Schedule_LeadTimeTimeFence_InsideMPSTimeFence.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Forecasts");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Schedule_ForecastsLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_ForecastsLink = new SeleniumControl( sDriver, "Schedule_ForecastsLink", "ID", "lnk_5047_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.AssertEqual(true,MSMMPS_Schedule_ForecastsLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Click on Schedule_ForecastsLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_ForecastsLink = new SeleniumControl( sDriver, "Schedule_ForecastsLink", "ID", "lnk_5047_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.WaitControlDisplayed(MSMMPS_Schedule_ForecastsLink);
MSMMPS_Schedule_ForecastsLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on ForecastsForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ForecastsForm = new SeleniumControl( sDriver, "ForecastsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_MPSFORECASTRQMT_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_ForecastsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Forecasts_ForecastsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Forecasts_ForecastsDetailsForm = new SeleniumControl( sDriver, "Forecasts_ForecastsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_MPSFORECASTRQMT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_Forecasts_ForecastsDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExist on Forecasts_ForecastsDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Forecasts_ForecastsDetailsFormTable = new SeleniumControl( sDriver, "Forecasts_ForecastsDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_MPSFORECASTRQMT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MSMMPS_Forecasts_ForecastsDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing ClickButton on Forecasts_ForecastsDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Forecasts_ForecastsDetailsForm = new SeleniumControl( sDriver, "Forecasts_ForecastsDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_MPSFORECASTRQMT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_Forecasts_ForecastsDetailsForm);
IWebElement formBttn = MSMMPS_Forecasts_ForecastsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MSMMPS_Forecasts_ForecastsDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MSMMPS_Forecasts_ForecastsDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Forecasts_ForecastsDetails_ForecastedNeedDate...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Forecasts_ForecastsDetails_ForecastedNeedDate = new SeleniumControl( sDriver, "Forecasts_ForecastsDetails_ForecastedNeedDate", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_MPSFORECASTRQMT_CTW_']/ancestor::form[1]/descendant::*[@id='MPS_DT']");
				Function.AssertEqual(true,MSMMPS_Forecasts_ForecastsDetails_ForecastedNeedDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Close on ForecastsForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ForecastsForm = new SeleniumControl( sDriver, "ForecastsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_MPSFORECASTRQMT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_ForecastsForm);
IWebElement formBttn = MSMMPS_ForecastsForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Planned Orders");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Schedule_PlannedOrdersLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_PlannedOrdersLink = new SeleniumControl( sDriver, "Schedule_PlannedOrdersLink", "ID", "lnk_5134_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.AssertEqual(true,MSMMPS_Schedule_PlannedOrdersLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Click on Schedule_PlannedOrdersLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_PlannedOrdersLink = new SeleniumControl( sDriver, "Schedule_PlannedOrdersLink", "ID", "lnk_5134_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.WaitControlDisplayed(MSMMPS_Schedule_PlannedOrdersLink);
MSMMPS_Schedule_PlannedOrdersLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on PlannedOrdersForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_PlannedOrdersForm = new SeleniumControl( sDriver, "PlannedOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_SCHEDRECPT_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_PlannedOrdersForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on PlannedOrders_PlannedOrdersDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_PlannedOrders_PlannedOrdersDetailsForm = new SeleniumControl( sDriver, "PlannedOrders_PlannedOrdersDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_SCHEDRECPT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_PlannedOrders_PlannedOrdersDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExist on PlannedOrders_PlannedOrdersDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_PlannedOrders_PlannedOrdersDetailsFormTable = new SeleniumControl( sDriver, "PlannedOrders_PlannedOrdersDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_SCHEDRECPT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MSMMPS_PlannedOrders_PlannedOrdersDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing ClickButton on PlannedOrders_PlannedOrdersDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_PlannedOrders_PlannedOrdersDetailsForm = new SeleniumControl( sDriver, "PlannedOrders_PlannedOrdersDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_SCHEDRECPT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_PlannedOrders_PlannedOrdersDetailsForm);
IWebElement formBttn = MSMMPS_PlannedOrders_PlannedOrdersDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MSMMPS_PlannedOrders_PlannedOrdersDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MSMMPS_PlannedOrders_PlannedOrdersDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on PlannedOrders_PlannedOrderDetails_DueDate...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_PlannedOrders_PlannedOrderDetails_DueDate = new SeleniumControl( sDriver, "PlannedOrders_PlannedOrderDetails_DueDate", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_SCHEDRECPT_CTW_']/ancestor::form[1]/descendant::*[@id='DUE_DT']");
				Function.AssertEqual(true,MSMMPS_PlannedOrders_PlannedOrderDetails_DueDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Close on PlannedOrdersForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_PlannedOrdersForm = new SeleniumControl( sDriver, "PlannedOrdersForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_SCHEDRECPT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_PlannedOrdersForm);
IWebElement formBttn = MSMMPS_PlannedOrdersForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Action Messages");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Schedule_ActionMessagesLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_ActionMessagesLink = new SeleniumControl( sDriver, "Schedule_ActionMessagesLink", "ID", "lnk_5137_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.AssertEqual(true,MSMMPS_Schedule_ActionMessagesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Click on Schedule_ActionMessagesLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_ActionMessagesLink = new SeleniumControl( sDriver, "Schedule_ActionMessagesLink", "ID", "lnk_5137_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.WaitControlDisplayed(MSMMPS_Schedule_ActionMessagesLink);
MSMMPS_Schedule_ActionMessagesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on ActionMessagesForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ActionMessagesForm = new SeleniumControl( sDriver, "ActionMessagesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSMSG_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_ActionMessagesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on ActionMessages_ActionMessagesDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ActionMessages_ActionMessagesDetailsForm = new SeleniumControl( sDriver, "ActionMessages_ActionMessagesDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSMSG_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_ActionMessages_ActionMessagesDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExist on ActionMessages_ActionMessagesDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ActionMessages_ActionMessagesDetailsFormTable = new SeleniumControl( sDriver, "ActionMessages_ActionMessagesDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSMSG_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MSMMPS_ActionMessages_ActionMessagesDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing ClickButton on ActionMessages_ActionMessagesDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ActionMessages_ActionMessagesDetailsForm = new SeleniumControl( sDriver, "ActionMessages_ActionMessagesDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSMSG_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_ActionMessages_ActionMessagesDetailsForm);
IWebElement formBttn = MSMMPS_ActionMessages_ActionMessagesDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MSMMPS_ActionMessages_ActionMessagesDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MSMMPS_ActionMessages_ActionMessagesDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on ActionMessages_ActionMessagesDetails_MessageType...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ActionMessages_ActionMessagesDetails_MessageType = new SeleniumControl( sDriver, "ActionMessages_ActionMessagesDetails_MessageType", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSMSG_CTW_']/ancestor::form[1]/descendant::*[@id='S_MPS_MSG_TYPE_CD']");
				Function.AssertEqual(true,MSMMPS_ActionMessages_ActionMessagesDetails_MessageType.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Close on ActionMessagesForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_ActionMessagesForm = new SeleniumControl( sDriver, "ActionMessagesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSMSG_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_ActionMessagesForm);
IWebElement formBttn = MSMMPS_ActionMessagesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
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
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Schedule_SupplyLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_SupplyLink = new SeleniumControl( sDriver, "Schedule_SupplyLink", "ID", "lnk_5139_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.AssertEqual(true,MSMMPS_Schedule_SupplyLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Click on Schedule_SupplyLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_SupplyLink = new SeleniumControl( sDriver, "Schedule_SupplyLink", "ID", "lnk_5139_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.WaitControlDisplayed(MSMMPS_Schedule_SupplyLink);
MSMMPS_Schedule_SupplyLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on SupplyForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_SupplyForm = new SeleniumControl( sDriver, "SupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSWRK_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_SupplyForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Supply_SupplyDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Supply_SupplyDetailsForm = new SeleniumControl( sDriver, "Supply_SupplyDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSWRK_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_Supply_SupplyDetailsForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExist on Supply_SupplyDetailsFormTable...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Supply_SupplyDetailsFormTable = new SeleniumControl( sDriver, "Supply_SupplyDetailsFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSWRK_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MSMMPS_Supply_SupplyDetailsFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing ClickButton on Supply_SupplyDetailsForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Supply_SupplyDetailsForm = new SeleniumControl( sDriver, "Supply_SupplyDetailsForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSWRK_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_Supply_SupplyDetailsForm);
IWebElement formBttn = MSMMPS_Supply_SupplyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MSMMPS_Supply_SupplyDetailsForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MSMMPS_Supply_SupplyDetailsForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Supply_SupplyInfo_PlannedAvailableDate...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Supply_SupplyInfo_PlannedAvailableDate = new SeleniumControl( sDriver, "Supply_SupplyInfo_PlannedAvailableDate", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSWRK_CTW_']/ancestor::form[1]/descendant::*[@id='PLND_AVAIL_DT']");
				Function.AssertEqual(true,MSMMPS_Supply_SupplyInfo_PlannedAvailableDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Close on SupplyForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_SupplyForm = new SeleniumControl( sDriver, "SupplyForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSWRK_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_SupplyForm);
IWebElement formBttn = MSMMPS_SupplyForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Schedule_DemandLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_DemandLink = new SeleniumControl( sDriver, "Schedule_DemandLink", "ID", "lnk_5141_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.AssertEqual(true,MSMMPS_Schedule_DemandLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Click on Schedule_DemandLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_DemandLink = new SeleniumControl( sDriver, "Schedule_DemandLink", "ID", "lnk_5141_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.WaitControlDisplayed(MSMMPS_Schedule_DemandLink);
MSMMPS_Schedule_DemandLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on DemandForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_DemandForm = new SeleniumControl( sDriver, "DemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_DEMAND_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_DemandForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Demand_DemandInfoForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Demand_DemandInfoForm = new SeleniumControl( sDriver, "Demand_DemandInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_DEMAND_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_Demand_DemandInfoForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExist on Demand_DemandInfoFormTable...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Demand_DemandInfoFormTable = new SeleniumControl( sDriver, "Demand_DemandInfoFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_DEMAND_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MSMMPS_Demand_DemandInfoFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing ClickButton on Demand_DemandInfoForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Demand_DemandInfoForm = new SeleniumControl( sDriver, "Demand_DemandInfoForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_DEMAND_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_Demand_DemandInfoForm);
IWebElement formBttn = MSMMPS_Demand_DemandInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MSMMPS_Demand_DemandInfoForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MSMMPS_Demand_DemandInfoForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Demand_DemandInfo_NeedDate...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Demand_DemandInfo_NeedDate = new SeleniumControl( sDriver, "Demand_DemandInfo_NeedDate", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_DEMAND_CTW_']/ancestor::form[1]/descendant::*[@id='PLND_AVAIL_DT']");
				Function.AssertEqual(true,MSMMPS_Demand_DemandInfo_NeedDate.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Close on DemandForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_DemandForm = new SeleniumControl( sDriver, "DemandForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_DEMAND_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_DemandForm);
IWebElement formBttn = MSMMPS_DemandForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Inventory Detail");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Schedule_InventoryDetailLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_InventoryDetailLink = new SeleniumControl( sDriver, "Schedule_InventoryDetailLink", "ID", "lnk_5148_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.AssertEqual(true,MSMMPS_Schedule_InventoryDetailLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Click on Schedule_InventoryDetailLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_InventoryDetailLink = new SeleniumControl( sDriver, "Schedule_InventoryDetailLink", "ID", "lnk_5148_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.WaitControlDisplayed(MSMMPS_Schedule_InventoryDetailLink);
MSMMPS_Schedule_InventoryDetailLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on InventoryDetailForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_InventoryDetailForm = new SeleniumControl( sDriver, "InventoryDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSINVT_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_InventoryDetailForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on InventoryDetail_ChildForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_InventoryDetail_ChildForm = new SeleniumControl( sDriver, "InventoryDetail_ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSINVT_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_InventoryDetail_ChildForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExist on InventoryDetail_ChildFormTable...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_InventoryDetail_ChildFormTable = new SeleniumControl( sDriver, "InventoryDetail_ChildFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSINVT_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MSMMPS_InventoryDetail_ChildFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing ClickButton on InventoryDetail_ChildForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_InventoryDetail_ChildForm = new SeleniumControl( sDriver, "InventoryDetail_ChildForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSINVT_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_InventoryDetail_ChildForm);
IWebElement formBttn = MSMMPS_InventoryDetail_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MSMMPS_InventoryDetail_ChildForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MSMMPS_InventoryDetail_ChildForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on InventoryDetail_ChildForm_Warehouse...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_InventoryDetail_ChildForm_Warehouse = new SeleniumControl( sDriver, "InventoryDetail_ChildForm_Warehouse", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSINVT_CTW_']/ancestor::form[1]/descendant::*[@id='WHSE_ID']");
				Function.AssertEqual(true,MSMMPS_InventoryDetail_ChildForm_Warehouse.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Close on InventoryDetailForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_InventoryDetailForm = new SeleniumControl( sDriver, "InventoryDetailForm", "xpath", "//div[translate(@id,'0123456789','')='pr__MSMMPS_ZMSMMPSINVT_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_InventoryDetailForm);
IWebElement formBttn = MSMMPS_InventoryDetailForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Schedule_SubstitutesLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_SubstitutesLink = new SeleniumControl( sDriver, "Schedule_SubstitutesLink", "ID", "lnk_5695_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.AssertEqual(true,MSMMPS_Schedule_SubstitutesLink.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Click on Schedule_SubstitutesLink...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Schedule_SubstitutesLink = new SeleniumControl( sDriver, "Schedule_SubstitutesLink", "ID", "lnk_5695_MSMMPS_ZMSMMPSBCKT_CTW");
				Function.WaitControlDisplayed(MSMMPS_Schedule_SubstitutesLink);
MSMMPS_Schedule_SubstitutesLink.Click(1.5);


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Click]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on SubstitutesForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_SubstitutesForm = new SeleniumControl( sDriver, "SubstitutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_HDR_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_SubstitutesForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Substitutes_SubstitutePartInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Substitutes_SubstitutePartInventoryForm = new SeleniumControl( sDriver, "Substitutes_SubstitutePartInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]");
				Function.AssertEqual(true,MSMMPS_Substitutes_SubstitutePartInventoryForm.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExist on Substitutes_SubstitutePartInventoryFormTable...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Substitutes_SubstitutePartInventoryFormTable = new SeleniumControl( sDriver, "Substitutes_SubstitutePartInventoryFormTable", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]/descendant::*[@id='dTbl']");
				Function.AssertEqual(true,MSMMPS_Substitutes_SubstitutePartInventoryFormTable.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExist]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing ClickButton on Substitutes_SubstitutePartInventoryForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Substitutes_SubstitutePartInventoryForm = new SeleniumControl( sDriver, "Substitutes_SubstitutePartInventoryForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_CTW_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_Substitutes_SubstitutePartInventoryForm);
IWebElement formBttn = MSMMPS_Substitutes_SubstitutePartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).Count <= 0 ? MSMMPS_Substitutes_SubstitutePartInventoryForm.mElement.FindElements(By.XPath(".//*[contains(text(),'Form')]")).FirstOrDefault() :
MSMMPS_Substitutes_SubstitutePartInventoryForm.mElement.FindElements(By.CssSelector("*[title*='Form']")).FirstOrDefault();
if (formBttn!=null) { new SeleniumControl(sDriver ,"FormButton",formBttn).MouseOver(); formBttn.Click(); }
else throw new Exception(" Form not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [ClickButton]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing VerifyExists on Substitutes_Project...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_Substitutes_Project = new SeleniumControl( sDriver, "Substitutes_Project", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_HDR_']/ancestor::form[1]/descendant::*[@id='INVT_PROJ_ID']");
				Function.AssertEqual(true,MSMMPS_Substitutes_Project.Exists());

								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [VerifyExists]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Close on SubstitutesForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_SubstitutesForm = new SeleniumControl( sDriver, "SubstitutesForm", "xpath", "//div[translate(@id,'0123456789','')='pr__DVGMRSUB_ZMRMACTMSUBST_HDR_']/ancestor::form[1]");
				Function.WaitControlDisplayed(MSMMPS_SubstitutesForm);
IWebElement formBttn = MSMMPS_SubstitutesForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
	if(formBttn!=null) { new SeleniumControl(sDriver, "Close", formBttn).ScrollIntoViewUsingJavaScript(); formBttn.Click();}
	else throw new Exception("Close Button not found ");


								}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [Close]" , ex.Message));
				}
								try
				{
				this.ScriptLogger.WriteLine("Closing Main Form");


									}
				catch(Exception ex)
				{
					throw new Exception(TraceMessage("Error performing [LogComment]" , ex.Message));
				}
								try {
				Function.CurrentComponent = "MSMMPS";
								Function.WaitLoadingFinished(Function.IsCurrentComponentModal(false));

				this.ScriptLogger.WriteLine("[MSMMPS] Performing Close on MainForm...", Logger.MessageType.INF);
				SeleniumControl MSMMPS_MainForm = new SeleniumControl( sDriver, "MainForm", "xpath", "//div[@id='0']/form[1]");
				Function.WaitControlDisplayed(MSMMPS_MainForm);
IWebElement formBttn = MSMMPS_MainForm.mElement.FindElements(By.CssSelector("*[title*='Close']")).Where(x=>x.Displayed).FirstOrDefault();
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

